Public Class Form1
    Dim turn As Boolean = True

    Private Sub btns(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click

        Dim tictactoe As Button = CType(sender, Button)

        If turn Then
            tictactoe.Text = "X"
            'inverting the value 
            turn = False

        Else
            tictactoe.Text = "O"

            turn = True

        End If
        tictactoe.Enabled = False



    End Sub
    Public Sub Checker()
        '    
        If btn1.Text.Equals(btn2.Text) And btn2.Text.Equals(btn3.Text) And btn1.Text <> "" Then


        ElseIf btn4.Text.Equals(btn5.Text) And btn5.Text.Equals(btn6.Text) And btn4.Text <> "" Then


        ElseIf btn7.Text.Equals(btn8.Text) And btn8.Text.Equals(btn9.Text) And btn7.Text <> "" Then

        ElseIf btn1.Text.Equals(btn4.Text) And btn4.Text.Equals(btn7.Text) And btn1.Text <> "" Then

        ElseIf btn2.Text = btn5.Text And btn5.Text = btn8.Text And btn2.Text <> "" Then

        ElseIf btn3.Text = btn6.Text And btn6.Text = btn9.Text And btn3.Text <> "" Then

        ElseIf btn1.Text.Equals(btn5.Text) And btn5.Text.Equals(btn9.Text) And btn1.Text <> "" Then

        ElseIf btn3.Text.Equals(btn5.Text) And btn5.Text.Equals(btn7.Text) And btn3.Text <> "" Then

        End If

    End Sub

End Class
