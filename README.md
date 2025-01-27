# Bank Account Application

## Overview

This project is a simple Bank Account Management Application built using C# and Windows Forms. It was created as part of my journey to learn and apply Object-Oriented Programming (OOP) concepts. The goal of the project was to build an interactive application to manage bank accounts while implementing key OOP principles like **encapsulation**, **abstraction**, **inheritance**, and **polymorphism**.

## Features

- **Account Creation**
  - Users can create a bank account with an owner's name and an initial deposit amount.
  - Supports savings accounts with interest rates.
  - Each account is assigned a unique identifier using `Guid`.

- **Deposits**
  - Users can deposit money into an account.
  - Validations include preventing deposits of zero, negative amounts, or amounts exceeding $20,000.

- **Withdrawals**
  - Users can withdraw money from an account.
  - Validations ensure sufficient balance and prevent zero or negative withdrawals.

- **Interest Calculation**
  - Savings accounts apply an interest rate to deposits, encouraging long-term savings.

- **Data Display**
  - All accounts are displayed in a grid view, allowing users to select an account to perform transactions.
  - The grid view dynamically updates after each transaction.

## OOP Concepts Applied

### 1. Encapsulation

- The `BankAccount` class encapsulates data such as `Owner`, `AccountNumber`, and `Balance`. The balance is kept private and can only be modified through methods (`Deposit` and `Withdraw`).

```csharp
public decimal Balance { get; private set; }
```

- This ensures that the balance cannot be directly manipulated from outside the class.

### 2. Abstraction

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

### 3. Inheritance

- The `SavingsAccount` class inherits from the `BankAccount` class, reusing its common properties and methods while introducing new functionality like interest calculation.

```csharp
public class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; set; }

    public SavingsAccount(string owner, decimal initialDeposit, decimal interest)
        : base(owner + " (S)", initialDeposit)
    {
        InterestRate = interest;
    }

    public override string Deposit(decimal amount)
    {
        decimal interestAmount = (InterestRate / 100) * amount;
        Balance += amount + interestAmount;
        return "Deposit completed successfully with interest.";
    }
}
```

- This demonstrates the ability to extend existing classes without rewriting code, promoting reusability.

### 4. Polymorphism

- Polymorphism is implemented through method overriding. For example, the `Deposit` method in the `SavingsAccount` class overrides the base class's implementation to include interest calculations.

```csharp
public override string Deposit(decimal amount)
{
    decimal interestAmount = (InterestRate / 100) * amount;
    Balance += amount + interestAmount;
    return "Deposit completed successfully with interest.";
}
```

- This allows the same method name (`Deposit`) to have different behavior depending on the type of account.

### 5. Reusability and Modularity

- The class design allows easy reuse. By using inheritance and polymorphism, new account types (e.g., checking accounts) can be added with minimal changes to the existing codebase.

### 6. Error Handling

- Error handling is incorporated into the `Deposit` and `Withdraw` methods by returning meaningful messages, ensuring smooth user interaction.

## Learning Outcomes

This project helped me:

- Understand and apply key OOP concepts like encapsulation, abstraction, inheritance, and polymorphism.
- Use constructors to initialize objects with default or user-defined values.
- Extend functionality using inheritance and method overriding.
- Improve debugging and problem-solving skills while handling edge cases for transactions.
- Build a functional user interface in Windows Forms to interact with OOP logic.

## Challenges Faced

- Ensuring that the grid dynamically updates after each transaction.
- Implementing inheritance and polymorphism effectively for savings accounts.
- Validating edge cases like negative or excessive deposit and withdrawal amounts.
- Designing a reusable and extensible architecture for future account types.

## Future Enhancements

1. **Add Account Types**
   - Extend the application to support different types of accounts (e.g., checking, fixed deposit).

2. **Transaction History**
   - Implement a feature to track and display a list of transactions for each account.

3. **UI Improvements**
   - Enhance the interface to be more user-friendly and visually appealing.

4. **Data Persistence**
   - Save account data to a file or database so that it persists between application sessions.

5. **Authentication**
   - Add a login system for users to manage their accounts securely.

## How to Run the Project

1. Clone this repository.
2. Open the solution file (`.sln`) in Visual Studio.
3. Build and run the project.

## Technologies Used

- C#
- Windows Forms

## Conclusion

This project has been a valuable step in my journey to mastering OOP principles in C#. By incorporating concepts like inheritance and polymorphism, I gained deeper insights into designing robust and extensible applications. This project reflects my continuous learning and growth as a software developer.

