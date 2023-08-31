# SimpleATM Program

The **SimpleATM** program simulates a basic ATM (Automated Teller Machine) interaction. Users can access their accounts, perform deposits, withdrawals, check balances, and exit the program.

## Usage

1. Clone or download the repository to your local machine.
2. Open the solution in your preferred C# development environment (e.g., Visual Studio).
3. Build and run the program.
4. Follow the on-screen prompts to interact with the ATM simulation.
5. Choose options using numeric inputs and follow the instructions.

## Features

- Account holders' information (card number, PIN, name, balance) is stored and retrieved from a list.
- Users can select options to deposit money, withdraw money, check their balance, and exit the program.
- Basic input validation is implemented to handle user input errors.

## Implementation Details

- The `CardHolder` class represents an account holder with methods to manage account details.
- The `Program` class contains the main logic of the ATM program, including user input and option handling.
- Users are prompted to input their card number and PIN to access their account.
- Users can perform transactions and check their balance.
- The program loop continues until the user chooses to exit.

## Example Data

- Example account holder data is provided in the form of a list within the `Program` class.

## Future Improvements

- Enhanced input validation and error handling could be implemented.
- The program could be extended to support multiple accounts, storing data in a more persistent manner (e.g., a database).

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
