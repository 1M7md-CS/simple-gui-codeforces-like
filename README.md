# Simple GUI Codeforces-like Application

A desktop application built with C# Windows Forms that provides a Codeforces-like interface for solving programming problems.

## Features

- User authentication system with login functionality
- Admin and User interfaces
- Support for multiple programming problems:
  - Sum Two Numbers
  - Reverse Array
  - Sort Array
- Code compilation and testing
- Error handling and validation

## Project Structure

```
├── Forms/                 # Windows Forms
│   ├── Admin.cs          # Admin interface
│   ├── Login.cs          # Login form
│   └── User.cs           # User interface
├── Codes/                # Problem solutions
│   ├── SumTwoNumbers/
│   ├── ReverseArray/
│   └── SortArray/
├── Properties/           # Project properties
└── Program.cs           # Application entry point
```

## Getting Started

### Prerequisites

- Visual Studio or compatible C# IDE

### Building and Running

1. Open `Login.csproj` in Visual Studio
2. Build the solution
3. Run the application

## Usage

1. Launch the application
2. Login with appropriate credentials
3. Access problems through the User interface
4. Submit solutions and view results

## Built With

- C# Windows Forms