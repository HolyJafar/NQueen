using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GUI_Main
{
    public partial class MainForm : Form
    {
        private Thread backgroundWorker;
        private readonly SynchronizationContext mainThread;
        private int[] lastAnswer;

        public MainForm()
        {
            InitializeComponent();
            InitializeBoard();

            mainThread = SynchronizationContext.Current;
            if (mainThread == null) mainThread = new SynchronizationContext();
        }

        private void UpdateUI(int[] answer, int generation)
        {
            if (lastAnswer == null || !answer.SequenceEqual(lastAnswer))
            {
                lastAnswer = answer;
                tlpChecker.Invalidate();
                tlpChecker.Update();
                lblCurrentFitness.Text = "Fitness: " + answer[answer.Length - 1];
                lblCurrentFitness.Update();
            }

            lblCurrentGeneration.Text = "Generation #" + generation;
            lblCurrentGeneration.Update();
        }

        #region Event Methods

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (tlpChecker != null)
            {
                this.tlpChecker.Size = new Size(this.Height - 39, this.Height - 39);

                this.pnlControls.Size = new Size(this.Width - this.Height + 20, this.Height);
                this.pnlControls.Location = new Point(this.Height - 39, 0);

                this.MinimumSize = new Size(this.tlpChecker.Width + 210, 513);
            }

            foreach (var control in this.pnlControls.Controls.OfType<ComboBox>().Where(p => p.DropDownStyle == ComboBoxStyle.DropDown))
                control.SelectionLength = 0;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker != null) backgroundWorker.Abort();
        }

        private void TlpChecker_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column + e.Row) % 2 == 0)
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.Snow, e.CellBounds);

            if (lastAnswer != null && lastAnswer.Length >= e.Column && lastAnswer[e.Column] == e.Row)
                e.Graphics.FillEllipse(Brushes.Orange, e.CellBounds.X + 3, e.CellBounds.Y + 3, e.CellBounds.Width - 6, e.CellBounds.Height - 6);
        }

        private void DigitInputs_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void DigitInputs_Leave(object sender, EventArgs e)
        {
            lastAnswer = null;

            int input;

            ComboBox cb = sender as ComboBox;

            if (cb.Name is "cbGenerationsLimit" && cb.Text == "Unlimited")
                return;
            else if (!int.TryParse(cb.Text, out input)
            || (cb.Name is "cbN" && (input == 0 || input == 2 || input == 3))
            || (cb.Name is "cbPopulationSize" && input < 2)
            || (cb.Name is "cbGenerationsLimit" && input == 0))
            {
                MessageBox.Show("Invalid Input", "Please enter a number.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (cb.Name is "cbN") cb.Text = tlpChecker.ColumnCount.ToString();
            }
            else if (cb.Name is "cbMutationChance" && (input > 100 || input < 0))
                MessageBox.Show("Invalid Input", "Mutation chance should be bettwen 0~100%.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CbBoardSize_TextChanged(object sender, EventArgs e)
        {
            int input = 0;

            if (int.TryParse(cbN.Text, out input))
            {
                lastAnswer = null;

                if (!(input <= 0 || input == 2 || input == 3))
                    ChangeBoardSize(input);
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (backgroundWorker == null || !backgroundWorker.IsAlive)
            {
                Array.ForEach(this.pnlControls.Controls.OfType<ComboBox>().ToArray(), i => i.Enabled = false);
                btnStart.ForeColor = Color.Red;
                btnStart.Text = "Stop";
                backgroundWorker = new Thread(RunGenetic);
                backgroundWorker.Start();
                this.Cursor = Cursors.WaitCursor;
            }
            else
            {
                Array.ForEach(this.pnlControls.Controls.OfType<ComboBox>().ToArray(), i => i.Enabled = true);
                btnStart.ForeColor = Color.Black;
                btnStart.Text = "Start";
                backgroundWorker.Abort();
                System.Media.SystemSounds.Exclamation.Play();
                this.Cursor = Cursors.Arrow;
            }
        }

        #endregion

        #region NQueenAlgorithm Methods

        public void RunGenetic()
        {
            if (!int.TryParse((string)this.Invoke(new Func<String>(() => cbGenerationsLimit.Text)), out int generationLimit)) generationLimit = -1;
            int delay = int.Parse((string)this.Invoke(new Func<string>(() => cbDelay.Text)));

            AIAlgorithms.GeneticAlgorithms NQueen = new AIAlgorithms.GeneticAlgorithms(Fittness((int)this.Invoke(new Func<int>(() => cbFitnessFuncMethod.SelectedIndex))), int.Parse((string)this.Invoke(new Func<string>(() => cbN.Text))))
            {
                PopulationSize = int.Parse((string)this.Invoke(new Func<string>(() => cbPopulationSize.Text))),
                GenerationLimit = generationLimit,
                TotalMutationPercent = int.Parse((string)this.Invoke(new Func<string>(() => cbMutationChance.Text)))
            };

            while (NQueen.NextStep())
            {
                mainThread.Send((object state) => { UpdateUI(NQueen.BestChromosome, NQueen.CurrentGeneration); }, null);
                Thread.Sleep(delay);
            }

            mainThread.Send((object state) =>
            {
                this.Cursor = Cursors.Arrow;
                btnStart.ForeColor = Color.Black;
                btnStart.Text = "Start";
                System.Media.SystemSounds.Exclamation.Play();
                Array.ForEach(this.pnlControls.Controls.OfType<ComboBox>().ToArray(), i => i.Enabled = true);

            }, null);
        }

        private Func<int[], int> Fittness(int selectedFittness)
        {
            if (selectedFittness == 0)
                return FittnessMethod1;
            else
                return FittnessMethod2;
        }

        private int FittnessMethod1(int[] input)
        {
            int grade = 0;
            List<int> visitd = new List<int>();

            for (int x = 0; x < input.Length - 2; x++)
            {
                for (int y = x + 1; y < input.Length - 1; y++)
                    if (Math.Abs(x - y) == Math.Abs(input[x] - input[y]) || (input[x] == input[y] && !visitd.Contains(input[x])))
                        grade++;

                if (visitd.Contains(input[x]))
                    visitd.Add(input[x]);
            }

            return grade;
        }

        private int FittnessMethod2(int[] input)
        {
            int grade = 0;

            for (int x = 0; x < input.Length - 1; x++)
                for (int y = 0; y < input.Length - 1; y++)
                    if (x == y)
                        continue;
                    else if (Math.Abs(x - y) == Math.Abs(input[x] - input[y]) || input[x] == input[y])
                    {
                        grade++;
                        break;
                    }

            return grade;
        }

        #endregion
    }
}