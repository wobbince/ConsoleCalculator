Module Module1
    'Robert Ince 
    'OCR Applied ICT GCE Unit 8: Task 1 - Calculator
    Dim sum As String
    Dim total As Double = 0
    '------------------------------------------------------------------------------------
    Sub initialise()
        Dim i As Integer
        total = 0
        sum = ""

        For i = 0 To 4
            Console.WriteLine(Environment.NewLine)
        Next
        Console.WriteLine("          Welcome to My Calculator" & Environment.NewLine & "                Robert Ince" & Environment.NewLine & "GCE Applied ICT Unit 8: Task 1 - Calculator")
        For i = 0 To 1
            Console.WriteLine(Environment.NewLine)
        Next

    End Sub
    '------------------------------------------------------------------------------------
    Public Function get_operator() As String
        Dim op As String = ""

        Do
            Console.WriteLine("Please enter an operator (+, -, /, *, =")
            op = Console.ReadLine

            If op <> "+" And op <> "-" And op <> "/" And op <> "*" And op <> "=" Then
                Console.WriteLine("Invalid operator try again")
            End If

        Loop While op <> "+" And op <> "-" And op <> "/" And op <> "*" And op <> "="

        Return op

    End Function
    '------------------------------------------------------------------------------------
    Public Function get_num()
        Dim the_num As String
        Dim num As Double
        Dim i As Integer

        Do
            For i = 0 To 2
                Console.WriteLine(Environment.NewLine)
            Next

            Console.WriteLine("Enter a number: ")
            the_num = Console.ReadLine

            If Not IsNumeric(the_num) Then
                Console.WriteLine("Invalid number try again")
            End If

        Loop While Not IsNumeric(the_num)
        num = the_num
        Return num
    End Function
    '------------------------------------------------------------------------------------
    Sub Main()
        Dim i As Integer = 0
        Dim op As String
        Dim num As Double
        Dim this_num As String
        Dim go_again As String

        Do
            initialise()
            Do
                num = get_num()
                this_num = Convert.ToString(num)
                sum = String.Concat(sum, this_num)

                Select Case op
                    Case "+"
                        total = total + num
                    Case "-"
                        total = total - num
                    Case "/"
                        total = total / num
                    Case "*"
                        total = total * num
                    Case Else
                        total = num
                End Select

                op = get_operator()
                sum = String.Concat(sum, op)

            Loop Until op = "="

            For i = 0 To 14
                Console.WriteLine(Environment.NewLine)
            Next

            Console.WriteLine(sum & total)

            Console.WriteLine("Another Go? (Y/N)")
            go_again = Console.ReadLine

        Loop While go_again = "y" Or go_again = "Y"
    End Sub

End Module
'------------------------------------------------------------------------------------
