Public Class Login
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        Me.TextBox1.Clear()
        Me.TextBox1.ForeColor = Color.Black
        Me.Panel1.BackColor = Color.LightSkyBlue

    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        Me.TextBox2.Clear()
        Me.TextBox2.ForeColor = Color.Black
        Me.TextBox2.Font = New Font("", 17, FontStyle.Regular)
        Me.TextBox2.PasswordChar = "*"
        Me.Panel2.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Button1.Select()
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If Me.TextBox1.Text = "" Then
            Me.TextBox1.ForeColor = Color.Gray
            Me.TextBox1.Text = "username"
            Me.Panel1.BackColor = Color.White
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If Me.TextBox2.Text = "" Then
            Me.TextBox2.ForeColor = Color.Gray
            Me.TextBox2.Text = "password"
            Me.TextBox2.Font = New Font("century gothic", 12, FontStyle.Regular)
            Me.TextBox2.PasswordChar = ""
            Me.Panel2.BackColor = Color.White
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.TextBox1.Text = "username" Then
            Me.Panel1.BackColor = ColorTranslator.FromHtml("#e74c3c")
        End If
        If Me.TextBox2.Text = "password" Then
            Me.Panel2.BackColor = ColorTranslator.FromHtml("#e74c3c")
        End If
    End Sub
End Class