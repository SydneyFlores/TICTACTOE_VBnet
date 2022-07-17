Public Class Form1
    Dim turn As Boolean = True

    Private Sub btns(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click

        Dim tictactoe As Button = CType(sender, Button)

        If turn Then
            tictactoe.Text = "X"

            turn = False

        Else
            tictactoe.Text = "O"

            turn = True

        End If
        tictactoe.Enabled = False
        Checker()


    End Sub
    Public Sub Checker()
        '    
        If btn1.Text.Equals(btn2.Text) And btn2.Text.Equals(btn3.Text) And btn1.Text <> "" Then
            If btn1.Text.Equals("X") Then
                MessageBox.Show("Player X wins")
            Else
                MessageBox.Show("Player O wins")


            End If

        ElseIf btn4.Text.Equals(btn5.Text) And btn5.Text.Equals(btn6.Text) And btn4.Text <> "" Then
            If btn4.Text.Equals("X") Then
                MessageBox.Show("Player X wins")
            Else
                MessageBox.Show("Player O wins")


            End If

        ElseIf btn7.Text.Equals(btn8.Text) And btn8.Text.Equals(btn9.Text) And btn7.Text <> "" Then
            If btn7.Text.Equals("X") Then
                MessageBox.Show("Player X wins")
            Else
                MessageBox.Show("Player O wins")


            End If
        ElseIf btn1.Text.Equals(btn4.Text) And btn4.Text.Equals(btn7.Text) And btn1.Text <> "" Then
            If btn1.Text.Equals("X") Then
                MessageBox.Show("Player X wins")
            Else
                MessageBox.Show("Player O wins")


            End If
        ElseIf btn2.Text = btn5.Text And btn5.Text = btn8.Text And btn2.Text <> "" Then
            If btn2.Text.Equals("X") Then
                MessageBox.Show("Player X wins")
            Else
                MessageBox.Show("Player O wins")


            End If
        ElseIf btn3.Text = btn6.Text And btn6.Text = btn9.Text And btn3.Text <> "" Then
            If btn3.Text.Equals("X") Then
                MessageBox.Show("Player X wins")
            Else
                MessageBox.Show("Player O wins")


            End If
        ElseIf btn1.Text.Equals(btn5.Text) And btn5.Text.Equals(btn9.Text) And btn1.Text <> "" Then
            If btn1.Text.Equals("X") Then
                MessageBox.Show("Player X wins")
            Else
                MessageBox.Show("Player O wins")


            End If
        ElseIf btn3.Text.Equals(btn5.Text) And btn5.Text.Equals(btn7.Text) And btn3.Text <> "" Then
            If btn3.Text.Equals("X") Then
                MessageBox.Show("Player X wins")
            Else
                MessageBox.Show("Player O wins")


            End If
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btn1.Text = ""
        btn1.Enabled = True
        btn2.Text = ""
        btn2.Enabled = True
        btn3.Text = ""
        btn3.Enabled = True
        btn4.Text = ""
        btn4.Enabled = True
        btn5.Text = ""
        btn5.Enabled = True
        btn6.Text = ""
        btn6.Enabled = True
        btn7.Text = ""
        btn7.Enabled = True
        btn8.Text = ""
        btn8.Enabled = True
        btn9.Text = ""
        btn9.Enabled = True




    End Sub
End Class
