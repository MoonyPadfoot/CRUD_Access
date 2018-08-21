Public Class frmLogin
    Dim flag As Integer = 0
    Private Sub TxtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        Me.pnlUsername.BackColor = Color.FromArgb(128, 255, 255)
        Me.picUser.BackColor = Color.FromArgb(128, 255, 255)
        Me.txtUsername.Clear()
        If flag > 2 Then Exit Sub
        Me.txtUsername.ForeColor = Color.Black
        flag += 1
    End Sub

    Private Sub TxtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        Me.pnlPassword.BackColor = Color.FromArgb(128, 255, 255)
        Me.picPass.BackColor = Color.FromArgb(128, 255, 255)
        Me.txtPassword.Clear()
        If flag > 2 Then Exit Sub
        Me.txtPassword.ForeColor = Color.Black
        Me.txtPassword.Font = New Font("", 14, FontStyle.Regular)
        Me.txtPassword.PasswordChar = "*"
        flag += 1
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnLogin.Select()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim student As New Students
        student.UName = Me.txtUsername.Text
        student.PWord = Me.txtPassword.Text
        If student.Save() = True Then
            MessageBox.Show("success")
        End If
        If Trim(Me.txtUsername.Text) = "" Or Trim(Me.txtUsername.Text) = "username" Then
            Me.pnlUsername.BackColor = ColorTranslator.FromHtml("#e74c3c")
            Me.picUser.BackColor = ColorTranslator.FromHtml("#e74c3c")
            txtUsername.Text = vbNullString
        End If
        If Trim(Me.txtPassword.Text) = "" Or Trim(Me.txtPassword.Text) = "password" Then
            Me.pnlPassword.BackColor = ColorTranslator.FromHtml("#e74c3c")
            Me.picPass.BackColor = ColorTranslator.FromHtml("#e74c3c")
            txtPassword.Text = vbNullString
        End If
    End Sub

    Private Sub PicExit_DoubleClick(sender As Object, e As EventArgs)
        Application.Exit()  'Me.Close()
        End
    End Sub
    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        Me.picPass.BackColor = Color.White
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        Me.picUser.BackColor = Color.White
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmDb.Show()
    End Sub
End Class