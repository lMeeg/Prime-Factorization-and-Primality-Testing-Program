# Prime-Factorization-and-Primality-Testing-Program

# Introduction
The Prime Factorization and Primality Testing Program is a console application written in C# that serves two main purposes: prime factorization and primality testing. Prime factorization is the process of breaking down a positive integer into its prime factors, and primality testing determines whether a given positive integer is prime or not. This program provides a user-friendly interface to input integers, perform factorization, and test for primality.

## Technical Details
This program is written in C# and utilizes basic mathematical concepts and control structures to achieve its objectives. Here are some key technical details:

• Language: C#.<br />
• Development Environment: Visual Studio or any C# IDE.<br />
• Libraries Used: System (for console I/O), Math (for square root calculations).<br />

## How It Works
1. The program begins by prompting the user to enter a positive integer greater than 1.

2. If the user provides valid input, the program proceeds to either perform prime factorization or primality testing, depending on the input value.

3. For prime factorization, the program iterates through the integer's factors, starting from 2, and appends them to the result string in the format "factor1 * factor2 * ...". It keeps dividing the input integer by its factors until the quotient becomes 1. If the input integer is prime, it is indicated as such.

4. For primality testing, the program checks whether the input integer is divisible by any integer from 2 to the square root of the input. If it is, the number is not prime; otherwise, it is considered prime.

5. The program displays the results, including the prime factorization or the primality test outcome.

## Functions and Classes
• `PrimeFactorization.Factorize(int n)`- This static method performs prime factorization and primality testing for the given integer n and returns the results as a formatted string.<br />
• `Program.Main()`- The program's entry point that handles user input invokes the factorization-primality test, and displays the results.<br />

## Installation and Usage
1. Ensure you have the .NET Framework installed on your system.

2. Open the code in Visual Studio or any C# IDE.

3. Build and run the program.

4. Follow the on-screen prompts to input a positive integer greater than 1, and the program will perform factorization or primality testing accordingly.

5. To exit the program, type "exit" when prompted for input.

## Conclusion
The Prime Factorization and Primality Testing Program is a simple yet useful tool for understanding the prime factors of a positive integer and determining whether it is prime. It can be educational and handy for various mathematical and programming purposes. This project provides a practical example of basic mathematical algorithms and console-based user interaction in C#.
