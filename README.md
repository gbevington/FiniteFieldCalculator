# C# Finite Field Calculator (Deprecated). Greg Bevington in collaboration with Saeed Fouladi Fard, January 2024.

## Overview

This repository houses an application designed for performing basic arithmetic operations within finite fields. The primary motivation for developing this tool is its utility in cryptography, where computations often involve extremely large numbers. To handle such scenarios, the application employs the "big integer" data type rather than regular integers.

For user convenience, the application supports the automatic generation of "NIST primes." Further, the applicaion validates the primality of initial input numbers.

### Transition to Python
Moving forward, development efforts will focus on the OS-agnostic Python version of the Finite Field Calculator. This C# implementation will be deprecated and no longer actively maintained. 

### Important Note
NIST Prime Generator: Please be aware that one of the NIST prime generator buttons may produce inaccurate results. Specifically, the P256 calculation might not yield a prime number that passes the primality test. Exercise caution when using this feature and consider cross-verifying the generated prime numbers.

### Building on Windows

To use this application, follow these steps:

1. Clone the repository to your local machine.

    ```bash
    git clone https://github.com/your-username/finite-field-calculator.git
    ```

2. Open the project in Visual Studio.

3. Build the solution in Visual Studio.

4. Run the application to perform finite field calculations.

