# Prework_Calculator
C# Calculator Console App

## Objective
The goal of the program is to perform simple operations ( add, subtract, multiply, divide ) on any two numbers.

IN - What type of operation, string ("Add", "Subtract", "Multiply" & "Divide");
* An incorrect input will reprompt the user

IN - Any 2 Numbers
* The program will prompt the user for each number

OUT - The solution of the opertion on the numbers

#### This Program is recursive with no option to close the program

## How it Works

The entry point for this program is shown in the following code.
The program executes and then enters into the Controller.

 ![MainEntry] (calc_controller.png)

Once in the Controller the User is prompted to enter data. This is where the operation and 2 numbers are inputed.

![Controller] (calc_controller.png)

The Controller calls the respective method and passes the numbers to those methods. The methods print the solution and again call the Controller.

![Methods] (calc_methods.png)
