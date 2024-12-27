using System;
using System.Linq;

namespace AIAlgorithms
{
    public class GeneticAlgorithms
    {
        #region fileds

        private readonly Random rnd;
        private int[][] population;
        private int currentGeneration;
        private bool thereIsGoalFitness;
        private int generationLimit;
        private int populationSize;
        private int totalMutationPercent;
        private int chromosomeSize;
        private int goalFitness;
        private bool minimize;
        private bool finded;
        private Func<int[], int> fitness;

        #endregion

        #region propertys

        public int GenerationLimit { get => generationLimit; set => generationLimit = value; }
        public int PopulationSize { get => populationSize; set => populationSize = value; }
        public int TotalMutationPercent { get => totalMutationPercent; set { if (value >= 0 && value <= 100) totalMutationPercent = value; } }
        public int ChromosomeSize { get => chromosomeSize; set => chromosomeSize = value; }
        public int GoalFitness { get => goalFitness; set => goalFitness = value; }
        public bool Minimize { get => minimize; set => minimize = value; }
        public Func<int[], int> Fitness { get => fitness; set => fitness = value; }
        public bool ThereIsGoalFitness { get => thereIsGoalFitness; set => thereIsGoalFitness = value; }
        public int CurrentGeneration { get => currentGeneration; set => currentGeneration = value; }
        public int CurrentGeneration1 { get => currentGeneration; }
        public int[][] Population { get => population; }
        public int[] BestChromosome { get => population[0]; }
        public bool Finded { get => finded; }

        #endregion

        public GeneticAlgorithms(Func<int[], int> fitness, int chromosomeSize, int goalFitness = 0, int populationSize = 25, int generationLimit = 40000, int totalMutationPercent = 80, bool thereIsGoalFitness = true)
        {
            this.Fitness = fitness;
            this.ChromosomeSize = chromosomeSize;
            this.GoalFitness = goalFitness;
            this.generationLimit = generationLimit;
            this.PopulationSize = populationSize;
            this.TotalMutationPercent = totalMutationPercent;
            this.thereIsGoalFitness = thereIsGoalFitness;

            rnd = new Random();
            Minimize = false;
            CurrentGeneration = 0;
        }

        public int[] TakeStep()
        {
            if (CurrentGeneration == 0)
                InitializeFirstPopulation();
            else
            {
                CrossOver();
                Mutation();
                Sort();

                currentGeneration++;

                if (population[0][ChromosomeSize] == GoalFitness && ThereIsGoalFitness)
                    finded = true;
            }

            return population[0];
        }

        public bool NextStep()
        {
            if(!(!finded && CurrentGeneration < GenerationLimit && GenerationLimit != -1))
                return false;   
            else if (CurrentGeneration == 0)
                InitializeFirstPopulation();
            else
            {
                CrossOver();
                Mutation();
                Sort();

                currentGeneration++;

                if (population[0][ChromosomeSize] == GoalFitness && ThereIsGoalFitness)
                    finded = true;
            }

            return true;
        }

        public int[] Search()
        {
            while (NextStep());

            return population[0];
        }

        private void InitializeFirstPopulation()
        {
            finded = false;
            CurrentGeneration = 1;
            population = new int[PopulationSize][];

            for (int i = 0; i < PopulationSize; i++)
            {
                population[i] = new int[ChromosomeSize + 1];

                for (int j = 0; j < ChromosomeSize; j++)
                    population[i][j] = rnd.Next(0, ChromosomeSize);

                population[i][ChromosomeSize] = Fitness(population[i]);
            }

            int[][] nextPopulation = new int[PopulationSize][];

            for (int i = 0; i < PopulationSize; i++)
                nextPopulation[i] = new int[ChromosomeSize + 1];

            Sort();

            population = population.Union(nextPopulation).ToArray();

            if (population[0][ChromosomeSize] == GoalFitness && ThereIsGoalFitness)
                finded = true;
        }

        private void Sort()
        {
            if (Minimize)
                population = population.OrderByDescending(fittness => fittness[ChromosomeSize]).ToArray();
            else
                population = population.OrderBy(fittness => fittness[ChromosomeSize]).ToArray();
        }

        private void CrossOver()
        {
            int crossPoint = rnd.Next(0, ChromosomeSize);

            if (ChromosomeSize > 1)
                for (int x = 0; x <= 1; x++)
                    for (int y = 1; y + (x * PopulationSize - (2 * x)) < PopulationSize; y++)
                        for (int i = 0; i < ChromosomeSize; i++)
                            if (i < crossPoint)
                                population[PopulationSize + (x * PopulationSize - (1 * x)) + y - 1][i] = population[x][i];
                            else
                                population[PopulationSize + (x * PopulationSize - (1 * x)) + y - 1][i] = population[y + x][i];
        }

        private void Mutation()
        {
            int[] mut = Enumerable.Range(1, PopulationSize * ChromosomeSize).OrderBy(g => Guid.NewGuid()).ToArray();

            for (int i = 0; i < ((PopulationSize * ChromosomeSize) * ((float)TotalMutationPercent / 100f)); i++)
                population[PopulationSize + ((mut[i] - 1) / ChromosomeSize)][mut[i] % ChromosomeSize] = rnd.Next(0, ChromosomeSize);

            for (int i = PopulationSize; i < PopulationSize * 2; i++)
                population[i][ChromosomeSize] = Fitness(population[i]);
        }
    }
}