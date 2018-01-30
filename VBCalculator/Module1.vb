Module Module1
    'Robert Ince 
    'OCR Applied ICT GCE Unit 8: Task 1 - Calculator
    Dim _sum As String
    Dim _total As Double = 0
    '------------------------------------------------------------------------------------
    Sub Initialise()
        _total = 0
        _sum = ""

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
        Dim op

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
        Dim theNum As String
        Dim num As Double

        Do
            For i = 0 To 2
                Console.WriteLine(Environment.NewLine)
            Next

            Console.WriteLine("Enter a number: ")
            theNum = Console.ReadLine

            If Not IsNumeric(theNum) Then
                Console.WriteLine("Invalid number try again")
            End If

        Loop While Not IsNumeric(theNum)
        num = theNum
        Return num
    End Function
    '------------------------------------------------------------------------------------
    Sub Main()
        Dim op As String
        Dim num As Double
        Dim thisNum As String
        Dim goAgain As String

        Do
            initialise()
            Do
                num = get_num()
                thisNum = Convert.ToString(num)
                _sum = String.Concat(_sum, thisNum)

                Select Case op
                    Case "+"
                        _total = _total + num
                    Case "-"
                        _total = _total - num
                    Case "/"
                        _total = _total / num
                    Case "*"
                        _total = _total * num
                    Case Else
                        _total = num
                End Select

                op = get_operator()
                _sum = String.Concat(_sum, op)

            Loop Until op = "="

            For i = 0 To 14
                Console.WriteLine(Environment.NewLine)
            Next

            Console.WriteLine(_sum & _total)

            Console.WriteLine("Another Go? (Y/N)")
            goAgain = Console.ReadLine

        Loop While goAgain = "y" Or goAgain = "Y"
    End Sub

End Module
'------------------------------------------------------------------------------------
