Public Class Form1

    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles ConvertButton.Click

        Dim n As Long
        Dim nCopy As String
        Dim output As String = ""
        Dim base As Short
        Dim result As Long
        Dim remainder As String
        Dim numberOfDigitsTillSpace As Integer = 4

        n = Val(InputTextBox.Text)

        If n > 0 Then

            n = Int(InputTextBox.Text)
            nCopy = n

            base = Val(BaseTextBox.Text)

            If base >= 2 And base <= 62 Then

                base = Int(BaseTextBox.Text)

                If base = 8 Then

                    numberOfDigitsTillSpace = 3

                End If

            Else

                MessageBox.Show("Please enter an integer equal to or between 2 and 62", "Error", MessageBoxButtons.OK)

            End If

            While n <> 0

                result = Int(n / base)
                remainder = Int(n Mod base)
                n = result

#Region "Remainders"

                If remainder = "10" Then
                    remainder = "A"
                ElseIf remainder = "11" Then
                    remainder = "B"
                ElseIf remainder = "12" Then
                    remainder = "C"
                ElseIf remainder = "13" Then
                    remainder = "D"
                ElseIf remainder = "14" Then
                    remainder = "E"
                ElseIf remainder = "15" Then
                    remainder = "F"
                ElseIf remainder = "16" Then
                    remainder = "G"
                ElseIf remainder = "17" Then
                    remainder = "H"
                ElseIf remainder = "18" Then
                    remainder = "I"
                ElseIf remainder = "19" Then
                    remainder = "J"
                ElseIf remainder = "20" Then
                    remainder = "K"
                ElseIf remainder = "21" Then
                    remainder = "L"
                ElseIf remainder = "22" Then
                    remainder = "M"
                ElseIf remainder = "23" Then
                    remainder = "N"
                ElseIf remainder = "24" Then
                    remainder = "O"
                ElseIf remainder = "25" Then
                    remainder = "P"
                ElseIf remainder = "26" Then
                    remainder = "Q"
                ElseIf remainder = "27" Then
                    remainder = "R"
                ElseIf remainder = "28" Then
                    remainder = "S"
                ElseIf remainder = "29" Then
                    remainder = "T"
                ElseIf remainder = "30" Then
                    remainder = "U"
                ElseIf remainder = "31" Then
                    remainder = "V"
                ElseIf remainder = "32" Then
                    remainder = "W"
                ElseIf remainder = "33" Then
                    remainder = "X"
                ElseIf remainder = "34" Then
                    remainder = "Y"
                ElseIf remainder = "35" Then
                    remainder = "Z"
                ElseIf remainder = "36" Then
                    remainder = "a"
                ElseIf remainder = "37" Then
                    remainder = "b"
                ElseIf remainder = "38" Then
                    remainder = "c"
                ElseIf remainder = "39" Then
                    remainder = "d"
                ElseIf remainder = "40" Then
                    remainder = "e"
                ElseIf remainder = "41" Then
                    remainder = "f"
                ElseIf remainder = "42" Then
                    remainder = "g"
                ElseIf remainder = "43" Then
                    remainder = "h"
                ElseIf remainder = "44" Then
                    remainder = "i"
                ElseIf remainder = "45" Then
                    remainder = "j"
                ElseIf remainder = "46" Then
                    remainder = "k"
                ElseIf remainder = "47" Then
                    remainder = "l"
                ElseIf remainder = "48" Then
                    remainder = "m"
                ElseIf remainder = "49" Then
                    remainder = "n"
                ElseIf remainder = "50" Then
                    remainder = "o"
                ElseIf remainder = "51" Then
                    remainder = "p"
                ElseIf remainder = "52" Then
                    remainder = "q"
                ElseIf remainder = "53" Then
                    remainder = "r"
                ElseIf remainder = "54" Then
                    remainder = "s"
                ElseIf remainder = "55" Then
                    remainder = "t"
                ElseIf remainder = "56" Then
                    remainder = "u"
                ElseIf remainder = "57" Then
                    remainder = "v"
                ElseIf remainder = "58" Then
                    remainder = "w"
                ElseIf remainder = "59" Then
                    remainder = "x"
                ElseIf remainder = "60" Then
                    remainder = "y"
                ElseIf remainder = "61" Then
                    remainder = "z"
                End If

#End Region

                If base <> 8 And numberOfDigitsTillSpace = 0 Then
                    output = remainder & " " & output
                    numberOfDigitsTillSpace = 3
                ElseIf base = 8 And numberOfDigitsTillSpace = 0 Then
                    output = remainder & " " & output
                    numberOfDigitsTillSpace = 2
                Else
                    output = remainder & output
                    numberOfDigitsTillSpace -= 1
                End If

            End While

            If base = 2 Then

                If numberOfDigitsTillSpace = 3 Then
                    output = "000" & output
                ElseIf numberOfDigitsTillSpace = 2 Then
                    output = "00" & output
                ElseIf numberOfDigitsTillSpace = 1 Then
                    output = "0" & output
                End If

            End If

            Label3.Text = nCopy & " in decimal when converted to base " & base & " is:"
            OutputLabel.Text = output

        Else

            MessageBox.Show("Please enter a positive integer", "Error", MessageBoxButtons.OK)

        End If

    End Sub

End Class