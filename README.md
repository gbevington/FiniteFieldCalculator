# Finite Field Calculator. Coded by Greg Bevington in collaboration with Saeed Fouladi Fard, January 2024.

## Overview

This repository houses an application designed for performing basic arithmetic operations within finite fields. The primary motivation for developing this tool is its utility in cryptography, where computations often involve extremely large numbers. To handle such scenarios, the application employs the "big integer" data type rather than regular integers.

For user convenience, the application supports the automatic generation of "NIST primes."

## Usage

### Building on Windows

To use this application, follow these steps:

1. Clone the repository to your local machine.

    ```bash
    git clone https://github.com/your-username/finite-field-calculator.git
    ```

2. Open the project in Visual Studio.

3. Build the solution in Visual Studio.

4. Run the application to perform finite field calculations.


## Upcoming Changes

- The project is currently employing the (probabilistic) Miller-Rabin primality test ( https://en.wikipedia.org/wiki/Miller%E2%80%93Rabin_primality_test ) to confirm the primality of input. This seems to work quickly for very large numbers, but there is a possibility of greater accuracy with the use of (deterministic) elliptic curve primality testing - so, upcoming versions of the application aim to employ the latter style of test.

- Linux GUI: Future releases will include a graphical user interface (GUI) for Linux, providing a cross-platform solution for users on different operating systems.
