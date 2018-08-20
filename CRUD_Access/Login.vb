Public Class Login
    Dim flag As Integer = 0
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        Me.Panel1.BackColor = Color.LightSkyBlue
        If flag > 2 Then Exit Sub
        Me.TextBox1.Clear()
        Me.TextBox1.ForeColor = Color.Black
        flag += 1
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        Me.Panel2.BackColor = Color.LightSkyBlue
        If flag > 2 Then Exit Sub
        Me.TextBox2.Clear()
        Me.TextBox2.ForeColor = Color.Black
        Me.TextBox2.Font = New Font("", 14, FontStyle.Regular)
        Me.TextBox2.PasswordChar = "*"
        flag += 1
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Button1.Select()
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        ' If Me.TextBox1.Text = "" Then
        'Me.TextBox1.ForeColor = Color.Gray
        'Me.TextBox1.Text = "username"
        Me.Panel1.BackColor = Color.White
        'End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        'If Me.TextBox2.Text = "" Then
        'Me.TextBox2.ForeColor = Color.Gray
        'Me.TextBox2.Text = "password"
        'e.TextBox2.Font = New Font("century gothic", 14, FontStyle.Regular)
        'Me.TextBox2.PasswordChar = ""
        Me.Panel2.BackColor = Color.White
        ' End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.TextBox1.Text = "" Then
            Me.Panel1.BackColor = ColorTranslator.FromHtml("#e74c3c")
        End If
        If Me.TextBox2.Text = "" Then
            Me.Panel2.BackColor = ColorTranslator.FromHtml("#e74c3c")
            TextBox2.Text = vbNullString
        End If
    End Sub

    Private Sub PictureBox4_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox4.DoubleClick
        'Me.Close()
        Application.Exit()
        End
    End Sub

    Private Sub PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        Me.PictureBox4.BackColor = Color.DarkRed
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        Me.PictureBox4.BackColor = Color.White
    End Sub
End Class