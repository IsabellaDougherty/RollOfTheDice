'Isabella Dougherty
'RCET0265
'Spring 2023
'Better Calculator
'https://github.com/IsabellaDougherty/BetterCalculator.git

Option Explicit On
Option Infer On
Option Strict Off
Option Compare Text


Imports System
Imports System.Linq.Expressions
Imports System.Reflection.Metadata.Ecma335
Imports System.Transactions

Module Program
    Sub Main()

        'Initiate all variables
        Dim userInput As String 'contains last user input string
        Dim quit As Boolean = False
        Dim isValidNumber = False
        Dim validAnswer As Boolean = False
        Dim first As Integer
        Dim second As Integer
        Dim answer As Decimal

        Console.WriteLine("Please enter two numbers. Press 'Q' any time to quit.")

        'Do until the user quits
        Do Until quit
            Console.WriteLine("Choose a Number: ")
            Do
                userInput = Console.ReadLine()
                isValidNumber = False
                Select Case userInput
                'Compares user's input to the letter Q to check for the user wanting to quit
                    Case "Q"
                        Console.WriteLine($"You have selected 'Q'.")
                        quit = True
                        isValidNumber = True
                        validAnswer = True
                    Case Else
                        Try
                            first = userInput
                            first = CDec(first)
                            isValidNumber = True
                            validAnswer = True
                        Catch ex As Exception
                            Console.WriteLine("Please enter a valid number.")
                        End Try
                End Select
            Loop Until isValidNumber Or quit
            isValidNumber = False
            Do

                Console.WriteLine("Choose a Number: ")
                If userInput = "Q" Or validAnswer = False Then
                    Console.WriteLine($"You have selected 'Q'.")
                    quit = True
                    validAnswer = True
                    isValidNumber = True
                Else
                    Try
                        userInput = Console.ReadLine()
                        second = userInput
                        second = CDec(second)
                        isValidNumber = True
                    Catch ex As Exception
                        Console.WriteLine("Please enter a valid number.")
                    End Try
                End If
            Loop Until isValidNumber

            If quit = True Then

            Else
                validAnswer = False
            End If

            While validAnswer = False
                Console.WriteLine("Plese choose one of the following:
1 Add
2 Subtract
3 Multiply
4 Divide")
                userInput = Console.ReadLine()
                If quit = False Then
                    Select Case userInput
                        'Checks if user wants to quit
                        Case "Q"
                            quit = True
                            validAnswer = True

                            'Following cases read out the computation the user wants.
                        Case "1"
                            answer = first + second
                            Console.WriteLine($"You have chosen to add the two numbers {first} and {second}")
                            Console.WriteLine($"The answer is {answer}")
                            validAnswer = True
                        Case "2"
                            answer = first - second
                            Console.WriteLine($"You have chosen to subtract {first} from {second}")
                            Console.WriteLine($"The answer is {answer}")
                            validAnswer = True
                        Case "3"
                            answer = first * second
                            Console.WriteLine($"You have chosen to multiply {first} and {second}")
                            Console.WriteLine($"The answer is {answer}")
                            validAnswer = True
                        Case "4"
                            answer = first / second
                            Console.WriteLine($"You have chosen to divide {first} from {second}")
                            Console.WriteLine($"The answer is {answer}")
                            validAnswer = True
                        Case Else
                            Console.WriteLine($"You have entered {userInput}.")
                    End Select
                ElseIf quit = True Then

                End If
            End While

        Loop
        Console.Clear()
        Console.WriteLine("Have a great day!")
    End Sub
End Module