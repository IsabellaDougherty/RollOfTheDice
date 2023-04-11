'Isabella Dougherty
'RCET0265
'Spring 2023
'Roll of the Dice
'https://github.com/IsabellaDougherty/RollOfTheDice.git


Imports System

Module RollOfTheDice
    Sub Main()
        Dim count(10, 1) As Integer
        Dim title As String = "|                   Roll Of The Dice                   |"
        Dim buffer As String
        Dim output As String
        Dim numbers As String
        Dim counting As Integer = 1
        Dim rollOne As Integer
        Dim rollTwo As Integer
        Dim sum As Integer
        Dim random As New Random()

        For i = 0 To 999
            rollOne = random.Next(1, 7)
            rollTwo = random.Next(1, 7)
            sum = rollOne + rollTwo
            Select Case sum
                Case 2
                    count(0, 1) += 1
                Case 3
                    count(1, 1) += 1
                Case 4
                    count(2, 1) += 1
                Case 5
                    count(3, 1) += 1
                Case 6
                    count(4, 1) += 1
                Case 7
                    count(5, 1) += 1
                Case 8
                    count(6, 1) += 1
                Case 9
                    count(7, 1) += 1
                Case 10
                    count(8, 1) += 1
                Case 11
                    count(9, 1) += 1
                Case 12
                    count(10, 1) += 1
            End Select
        Next

        For i As Integer = 2 To 12
            numbers += "|"
            numbers += i.ToString().PadRight(4).PadLeft(4)

        Next
        numbers += "|"

        buffer = StrDup(56, "-")

        For i = 0 To 10
            output += "|"
            output += CStr(count(i, 1)).ToString().PadRight(4).PadLeft(4)
        Next
        output += "|"

        Console.WriteLine(buffer)
        Console.WriteLine(title)
        Console.WriteLine(buffer)
        Console.WriteLine(numbers)
        Console.WriteLine(buffer)
        Console.WriteLine(output)
        Console.WriteLine(buffer)

    End Sub
End Module