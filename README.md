# SOLID Principles in .NET Application

This repository contains a .NET application developed as part of the ITI Professional Web Development and Business Intelligence 9-month scholarship. The application is designed to demonstrate the application of SOLID principles in a software development context.

## Instructor Acknowledgment

Special thanks to Eng. Akram Elhayani, the instructor of the SOLID principles course, for his invaluable guidance and support throughout the learning process.

## About the Application

The application is structured to illustrate the SOLID principles, which are fundamental to designing and writing flexible, scalable, and maintainable software. Each principle is showcased through various components of the application, making it an excellent reference for understanding and applying these principles in .NET projects.

### SOLID Principles Overview

- **Single Responsibility Principle (SRP):** Ensures that a class has only one reason to change, promoting modularity and responsibility segregation.
- **Open/Closed Principle (OCP):** Classes should be open for extension but closed for modification, facilitating easier future enhancements.
- **Liskov Substitution Principle (LSP):** Subtypes must be substitutable for their base types without altering the correctness of the program.
- **Interface Segregation Principle (ISP):** Clients should not be forced to depend on interfaces they do not use, promoting lean interfaces.
- **Dependency Inversion Principle (DIP):** High-level modules should not depend on low-level modules but on abstractions.

## Project Structure

The project is organized into several files, each demonstrating specific SOLID principles:

- `Program.cs`: The entry point of the application, orchestrating the demonstration of SOLID principles.
- `Employee.cs`, `Account.cs`, `PaymentProcessor.cs`: Examples of SRP, showcasing how responsibilities are segregated into distinct classes.
- `Account.cs`: Illustrates the Liskov Substitution Principle (LSP) and Open/Closed Principle (OCP). 
- `ECommerceSystem.cs`: Demonstrates the use of DIP and OCP by depending on abstractions rather than concrete implementations.
- `FileProcessor.cs`: An example of DIP, showing how high-level modules can depend on abstractions rather than low-level details.
- `AudioPlayer.cs`: Illustrates ISP by defining interfaces specific to audio and video functionalities.


