# Bank Account Application

## Overview
This project is a simple **Bank Account Management Application** built using **C#** and **Windows Forms**. It was created as part of my journey to learn and apply **Object-Oriented Programming (OOP)** concepts. The goal of the project was to build an interactive application to manage bank accounts while implementing key OOP principles like encapsulation, abstraction, and inheritance.

## Features
1. **Account Creation**
   - Users can create a bank account with an owner's name and an initial deposit amount.
   - Each account is assigned a unique identifier using `Guid`.

2. **Deposits**
   - Users can deposit money into an account.
   - Validations include preventing deposits of zero, negative amounts, or amounts exceeding $20,000.

3. **Withdrawals**
   - Users can withdraw money from an account.
   - Validations ensure sufficient balance and prevent zero or negative withdrawals.

4. **Data Display**
   - All accounts are displayed in a grid view, allowing users to select an account to perform transactions.
   - The grid view dynamically updates after each transaction.

## OOP Concepts Applied
### 1. **Encapsulation**
   - The `BankAccount` class encapsulates data such as `Owner`, `AccountNumber`, and `Balance`. The balance is kept private and can only be modified through methods (`Deposit` and `Withdraw`).
   
   ```csharp
   public decimal Balance { get; private set; }
   ```

   - This ensures that the balance cannot be directly manipulated from outside the class.

### 2. **Abstraction**
   - The `BankAccount` class provides methods like `Deposit` and `Withdraw`, abstracting away the internal logic from the user interface.
   - Example:

   ```csharp
   public string Deposit(decimal amount)
   {
       if (amount <= 0)
           return "You cannot deposit $" + amount;
       if (amount > 20000)
           return "Deposit limit reached";

       Balance += amount;
       return "Deposit completed successfully";
   }
   ```

### 3. **Reusability and Modularity**
   - The class design allows easy reuse. For instance, if I wanted to extend functionality to support different account types, I could create subclasses for `SavingsAccount` or `CheckingAccount`.

### 4. **Error Handling**
   - Error handling is incorporated into the `Deposit` and `Withdraw` methods by returning meaningful messages, ensuring smooth user interaction.

## Learning Outcomes
This project helped me:
- Understand the importance of encapsulating data and controlling access through properties and methods.
- Learn how to use constructors to initialize objects with default or user-defined values.
- Improve my debugging and problem-solving skills while handling edge cases for transactions.
- Build a functional user interface in Windows Forms to interact with my OOP logic.

## Challenges Faced
- Ensuring that the grid dynamically updates after each transaction.
- Validating edge cases like negative or excessive deposit and withdrawal amounts.
- Balancing user feedback (return messages) with internal error handling (exceptions).

## Future Enhancements
1. **Add Account Types:**
   - Extend the application to support different types of accounts (e.g., savings, checking).

2. **Transaction History:**
   - Implement a feature to track and display a list of transactions for each account.

3. **UI Improvements:**
   - Enhance the interface to be more user-friendly and visually appealing.

4. **Data Persistence:**
   - Save account data to a file or database so that it persists between application sessions.

5. **Authentication:**
   - Add a login system for users to manage their accounts securely.

## How to Run the Project
1. Clone this repository.
2. Open the solution file (`.sln`) in Visual Studio.
3. Build and run the project.

## Technologies Used
- **C#**
- **Windows Forms**

## Conclusion
This project was a valuable step in my journey to mastering OOP principles in C#. It combined theoretical concepts with practical implementation, providing me with a deeper understanding of how to design and build applications using OOP.

