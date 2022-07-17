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


    End Sub
End Class
