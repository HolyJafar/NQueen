# Genetic Algorithm for N-Queens Problem

This repository contains a C# implementation of a Genetic Algorithm to solve the N-Queens problem. The algorithm uses genetic principles such as selection, crossover, and mutation to find solutions that minimize the number of conflicts among queens on a chessboard.

![image](https://github.com/user-attachments/assets/ed7e5de9-b775-46af-b63e-9b1f1e8a6798)

## Features
- **Chromosome Representation**: Each chromosome is an array where the index represents a column on the chessboard, and the value represents the row of the queen in that column.
- **Fitness Function**:
  - Based on the number of conflicts between queens.
  - Alternatively, based on the number of non-threatening queens.
  - The user can choose the fitness evaluation method.
- **Conflict Detection**:
  - Row conflicts are detected if duplicate values exist in the chromosome.
  - Diagonal conflicts are detected using the equation: \( |C_1 - C_2| = |R_1 - R_2| \), where \( C \) and \( R \) are column and row indices, respectively.
- **Selection**: Elite chromosomes are selected based on fitness scores for crossover.
- **Crossover**: Random split points are used for combining selected parent chromosomes.
- **Mutation**: A user-defined percentage of chromosomes undergo random mutations.
- **Termination Criteria**:
  - Stops when a solution is found.
  - Alternatively, stops after a user-defined number of generations.

## How It Works
1. **Initialization**:
   - Generate an initial population of chromosomes.
2. **Evaluation**:
   - Compute the fitness of each chromosome.
3. **Selection**:
   - Rank chromosomes by fitness and select the best ones for reproduction.
4. **Crossover**:
   - Combine parent chromosomes at random split points to produce offspring.
5. **Mutation**:
   - Apply random changes to a subset of chromosomes based on user-defined mutation probability.
6. **Repeat**:
   - Iterate through the above steps until the termination condition is met.
7. **Output**:
   - Display the best solution found along with its fitness score.

## How to Use
1. Clone this repository:
   ```bash
   git clone https://github.com/your-username/your-repo-name.git
   ```
2. Navigate to the project directory:
   ```bash
   cd your-repo-name
   ```
3. Open the solution file (`.sln`) in your preferred C# IDE (e.g., Visual Studio).
4. Configure parameters such as population size, mutation rate, and number of generations in the program.
5. Run the program.

## Configuration
- **Population Size**: Number of chromosomes in each generation.
- **Mutation Rate**: Percentage of chromosomes that undergo mutation.
- **Number of Generations**: Maximum iterations for the algorithm.
- **Fitness Evaluation Method**: Choose between conflict-based or non-threatening queen evaluation.

## Dependencies
- .NET Framework or .NET Core

## License
This project is licensed under the MIT License. See the `LICENSE` file for details.

## Contributions
Contributions are welcome! Feel free to submit a pull request or open an issue for suggestions and improvements.

## Author
Jafar Mirzaei

## Acknowledgments
- This project was developed as part of a university course on genetic algorithms and artificial intelligence.
