Public Class frmLogin

    Dim kunik As connection = New connection
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kunik.connect()
        txtUsername.Focus()
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        kunik.flag = 0
        kunik.login("select * from tblusers where username = '" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Close application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class