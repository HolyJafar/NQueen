
namespace GUI_Main
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void InitializeBoard()
        {
            this.tlpChecker = new System.Windows.Forms.TableLayoutPanel();
            this.tlpChecker.BackColor = System.Drawing.Color.Gray;
            this.tlpChecker.Location = new System.Drawing.Point(0, 0);
            this.tlpChecker.Size = new System.Drawing.Size(this.Height - 39, this.Height - 39);
            this.Controls.Add(this.tlpChecker);
            this.tlpChecker.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.TlpChecker_CellPaint);
            this.cbFitnessFuncMethod.SelectedIndex = 0;
            this.ClientSize = new System.Drawing.Size(700, 474);
            ChangeBoardSize(int.Parse(this.cbN.Text));
        }

        public void ChangeBoardSize(int n)
        {
            this.tlpChecker.RowStyles.Clear();
            this.tlpChecker.ColumnStyles.Clear();

            this.tlpChecker.ColumnCount = this.tlpChecker.RowCount = n;

            for (int i = 0; i < n; i++)
            {
                this.tlpChecker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float)100 / n));
                this.tlpChecker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float)100f / n));
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlSplit2 = new System.Windows.Forms.Panel();
            this.pnlSplit1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbFitnessFuncMethod = new System.Windows.Forms.ComboBox();
            this.cbDelay = new System.Windows.Forms.ComboBox();
            this.cbMutationChance = new System.Windows.Forms.ComboBox();
            this.cbGenerationsLimit = new System.Windows.Forms.ComboBox();
            this.cbN = new System.Windows.Forms.ComboBox();
            this.cbPopulationSize = new System.Windows.Forms.ComboBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblFinessMethod = new System.Windows.Forms.Label();
            this.lblGenerationsNumber = new System.Windows.Forms.Label();
            this.lblMutationChance = new System.Windows.Forms.Label();
            this.lblPopulationSize = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblCurrentFitness = new System.Windows.Forms.Label();
            this.lblCurrentGeneration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.pnlSplit2);
            this.pnlControls.Controls.Add(this.pnlSplit1);
            this.pnlControls.Controls.Add(this.btnStart);
            this.pnlControls.Controls.Add(this.cbFitnessFuncMethod);
            this.pnlControls.Controls.Add(this.cbDelay);
            this.pnlControls.Controls.Add(this.cbMutationChance);
            this.pnlControls.Controls.Add(this.cbGenerationsLimit);
            this.pnlControls.Controls.Add(this.cbN);
            this.pnlControls.Controls.Add(this.cbPopulationSize);
            this.pnlControls.Controls.Add(this.lblDelay);
            this.pnlControls.Controls.Add(this.lblFinessMethod);
            this.pnlControls.Controls.Add(this.lblGenerationsNumber);
            this.pnlControls.Controls.Add(this.lblMutationChance);
            this.pnlControls.Controls.Add(this.lblPopulationSize);
            this.pnlControls.Controls.Add(this.lblN);
            this.pnlControls.Controls.Add(this.lblCurrentFitness);
            this.pnlControls.Controls.Add(this.lblCurrentGeneration);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.lblTitle);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControls.Location = new System.Drawing.Point(632, 0);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(280, 583);
            this.pnlControls.TabIndex = 1;
            // 
            // pnlSplit2
            // 
            this.pnlSplit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSplit2.BackColor = System.Drawing.Color.Gray;
            this.pnlSplit2.Location = new System.Drawing.Point(23, 468);
            this.pnlSplit2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSplit2.Name = "pnlSplit2";
            this.pnlSplit2.Size = new System.Drawing.Size(240, 1);
            this.pnlSplit2.TabIndex = 3;
            // 
            // pnlSplit1
            // 
            this.pnlSplit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSplit1.BackColor = System.Drawing.Color.Gray;
            this.pnlSplit1.Location = new System.Drawing.Point(25, 80);
            this.pnlSplit1.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSplit1.Name = "pnlSplit1";
            this.pnlSplit1.Size = new System.Drawing.Size(233, 1);
            this.pnlSplit1.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(23, 479);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 36);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // cbFitnessFuncMethod
            // 
            this.cbFitnessFuncMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFitnessFuncMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFitnessFuncMethod.FormattingEnabled = true;
            this.cbFitnessFuncMethod.Items.AddRange(new object[] {
            "# of Conflicts",
            "# of Queens that do not conflict"});
            this.cbFitnessFuncMethod.Location = new System.Drawing.Point(23, 335);
            this.cbFitnessFuncMethod.Margin = new System.Windows.Forms.Padding(4);
            this.cbFitnessFuncMethod.Name = "cbFitnessFuncMethod";
            this.cbFitnessFuncMethod.Size = new System.Drawing.Size(239, 24);
            this.cbFitnessFuncMethod.TabIndex = 1;
            this.cbFitnessFuncMethod.Tag = "input";
            // 
            // cbDelay
            // 
            this.cbDelay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDelay.FormattingEnabled = true;
            this.cbDelay.Items.AddRange(new object[] {
            "0",
            "50",
            "100",
            "250",
            "500",
            "1000"});
            this.cbDelay.Location = new System.Drawing.Point(180, 265);
            this.cbDelay.Margin = new System.Windows.Forms.Padding(4);
            this.cbDelay.Name = "cbDelay";
            this.cbDelay.Size = new System.Drawing.Size(81, 24);
            this.cbDelay.TabIndex = 1;
            this.cbDelay.Tag = "";
            this.cbDelay.Text = "0";
            this.cbDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitInputs_KeyPress);
            this.cbDelay.Leave += new System.EventHandler(this.DigitInputs_Leave);
            // 
            // cbMutationChance
            // 
            this.cbMutationChance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMutationChance.FormattingEnabled = true;
            this.cbMutationChance.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "25",
            "50",
            "80"});
            this.cbMutationChance.Location = new System.Drawing.Point(180, 224);
            this.cbMutationChance.Margin = new System.Windows.Forms.Padding(4);
            this.cbMutationChance.Name = "cbMutationChance";
            this.cbMutationChance.Size = new System.Drawing.Size(81, 24);
            this.cbMutationChance.TabIndex = 1;
            this.cbMutationChance.Tag = "";
            this.cbMutationChance.Text = "80";
            this.cbMutationChance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitInputs_KeyPress);
            this.cbMutationChance.Leave += new System.EventHandler(this.DigitInputs_Leave);
            // 
            // cbGenerationsLimit
            // 
            this.cbGenerationsLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGenerationsLimit.FormattingEnabled = true;
            this.cbGenerationsLimit.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "400",
            "800",
            "1600",
            "20000",
            "40000",
            "100000",
            "1000000",
            "Unlimited"});
            this.cbGenerationsLimit.Location = new System.Drawing.Point(180, 183);
            this.cbGenerationsLimit.Margin = new System.Windows.Forms.Padding(4);
            this.cbGenerationsLimit.Name = "cbGenerationsLimit";
            this.cbGenerationsLimit.Size = new System.Drawing.Size(81, 24);
            this.cbGenerationsLimit.TabIndex = 1;
            this.cbGenerationsLimit.Tag = "";
            this.cbGenerationsLimit.Text = "40000";
            this.cbGenerationsLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitInputs_KeyPress);
            this.cbGenerationsLimit.Leave += new System.EventHandler(this.DigitInputs_Leave);
            // 
            // cbN
            // 
            this.cbN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbN.FormattingEnabled = true;
            this.cbN.Items.AddRange(new object[] {
            "1",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbN.Location = new System.Drawing.Point(179, 103);
            this.cbN.Margin = new System.Windows.Forms.Padding(4);
            this.cbN.Name = "cbN";
            this.cbN.Size = new System.Drawing.Size(83, 24);
            this.cbN.TabIndex = 1;
            this.cbN.Tag = "";
            this.cbN.Text = "4";
            this.cbN.TextChanged += new System.EventHandler(this.CbBoardSize_TextChanged);
            this.cbN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitInputs_KeyPress);
            this.cbN.Leave += new System.EventHandler(this.DigitInputs_Leave);
            // 
            // cbPopulationSize
            // 
            this.cbPopulationSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPopulationSize.FormattingEnabled = true;
            this.cbPopulationSize.Items.AddRange(new object[] {
            "2",
            "3",
            "5",
            "10",
            "25",
            "50",
            "75",
            "100",
            "150",
            "200",
            "300",
            "500",
            "1000"});
            this.cbPopulationSize.Location = new System.Drawing.Point(179, 142);
            this.cbPopulationSize.Margin = new System.Windows.Forms.Padding(4);
            this.cbPopulationSize.Name = "cbPopulationSize";
            this.cbPopulationSize.Size = new System.Drawing.Size(83, 24);
            this.cbPopulationSize.TabIndex = 1;
            this.cbPopulationSize.Tag = "";
            this.cbPopulationSize.Text = "25";
            this.cbPopulationSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitInputs_KeyPress);
            this.cbPopulationSize.Leave += new System.EventHandler(this.DigitInputs_Leave);
            // 
            // lblDelay
            // 
            this.lblDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDelay.Location = new System.Drawing.Point(19, 262);
            this.lblDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(161, 28);
            this.lblDelay.TabIndex = 0;
            this.lblDelay.Text = "Delay (Milliseconds)";
            this.lblDelay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinessMethod
            // 
            this.lblFinessMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinessMethod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFinessMethod.Location = new System.Drawing.Point(19, 306);
            this.lblFinessMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinessMethod.Name = "lblFinessMethod";
            this.lblFinessMethod.Size = new System.Drawing.Size(176, 28);
            this.lblFinessMethod.TabIndex = 0;
            this.lblFinessMethod.Text = "Fitness Func Method";
            this.lblFinessMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGenerationsNumber
            // 
            this.lblGenerationsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerationsNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGenerationsNumber.Location = new System.Drawing.Point(19, 180);
            this.lblGenerationsNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenerationsNumber.Name = "lblGenerationsNumber";
            this.lblGenerationsNumber.Size = new System.Drawing.Size(176, 28);
            this.lblGenerationsNumber.TabIndex = 0;
            this.lblGenerationsNumber.Text = "# of Generations";
            this.lblGenerationsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMutationChance
            // 
            this.lblMutationChance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMutationChance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMutationChance.Location = new System.Drawing.Point(19, 220);
            this.lblMutationChance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMutationChance.Name = "lblMutationChance";
            this.lblMutationChance.Size = new System.Drawing.Size(176, 28);
            this.lblMutationChance.TabIndex = 0;
            this.lblMutationChance.Text = "Mutation Chance (%)";
            this.lblMutationChance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPopulationSize
            // 
            this.lblPopulationSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopulationSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPopulationSize.Location = new System.Drawing.Point(19, 142);
            this.lblPopulationSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPopulationSize.Name = "lblPopulationSize";
            this.lblPopulationSize.Size = new System.Drawing.Size(127, 28);
            this.lblPopulationSize.TabIndex = 0;
            this.lblPopulationSize.Text = "Population Size";
            this.lblPopulationSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblN
            // 
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblN.Location = new System.Drawing.Point(21, 103);
            this.lblN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(101, 28);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "Board Size:";
            this.lblN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentFitness
            // 
            this.lblCurrentFitness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentFitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentFitness.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCurrentFitness.Location = new System.Drawing.Point(23, 543);
            this.lblCurrentFitness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentFitness.Name = "lblCurrentFitness";
            this.lblCurrentFitness.Size = new System.Drawing.Size(240, 28);
            this.lblCurrentFitness.TabIndex = 0;
            this.lblCurrentFitness.Text = "Fitness: 0";
            this.lblCurrentFitness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentGeneration
            // 
            this.lblCurrentGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentGeneration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCurrentGeneration.Location = new System.Drawing.Point(23, 519);
            this.lblCurrentGeneration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentGeneration.Name = "lblCurrentGeneration";
            this.lblCurrentGeneration.Size = new System.Drawing.Size(240, 28);
            this.lblCurrentGeneration.TabIndex = 0;
            this.lblCurrentGeneration.Text = "Generation #0";
            this.lblCurrentGeneration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Genetic Algorithm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(4, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(272, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "N Queen";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(912, 583);
            this.Controls.Add(this.pnlControls);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(927, 621);
            this.Name = "MainForm";
            this.Text = "NQueen-Problem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label lblFinessMethod;
        private System.Windows.Forms.Label lblGenerationsNumber;
        private System.Windows.Forms.Label lblMutationChance;
        private System.Windows.Forms.Label lblPopulationSize;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblCurrentFitness;
        private System.Windows.Forms.Label lblCurrentGeneration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbFitnessFuncMethod;
        private System.Windows.Forms.ComboBox cbDelay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbMutationChance;
        private System.Windows.Forms.ComboBox cbGenerationsLimit;
        private System.Windows.Forms.ComboBox cbN;
        private System.Windows.Forms.ComboBox cbPopulationSize;
        private System.Windows.Forms.TableLayoutPanel tlpChecker;
        private System.Windows.Forms.Panel pnlSplit1;
        private System.Windows.Forms.Panel pnlSplit2;
    }
}

