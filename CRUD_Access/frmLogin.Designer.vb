<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.pnlUsername = New System.Windows.Forms.Panel()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.pnlPassword = New System.Windows.Forms.Panel()
        Me.picPass = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlUsername.SuspendLayout()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPassword.SuspendLayout()
        CType(Me.picPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtUsername.Location = New System.Drawing.Point(1, 1)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(177, 37)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.Text = "username"
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLogin
        '
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(55, 377)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(103, 50)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtPassword.Location = New System.Drawing.Point(1, 1)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(177, 37)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Text = "password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlUsername
        '
        Me.pnlUsername.BackColor = System.Drawing.Color.White
        Me.pnlUsername.Controls.Add(Me.picUser)
        Me.pnlUsername.Controls.Add(Me.txtUsername)
        Me.pnlUsername.Location = New System.Drawing.Point(53, 245)
        Me.pnlUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlUsername.Name = "pnlUsername"
        Me.pnlUsername.Padding = New System.Windows.Forms.Padding(1)
        Me.pnlUsername.Size = New System.Drawing.Size(221, 39)
        Me.pnlUsername.TabIndex = 3
        '
        'picUser
        '
        Me.picUser.BackColor = System.Drawing.Color.White
        Me.picUser.BackgroundImage = Global.CRUD_Access.My.Resources.Resources.if_41_User_2123927
        Me.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.picUser.Location = New System.Drawing.Point(173, 1)
        Me.picUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(47, 37)
        Me.picUser.TabIndex = 1
        Me.picUser.TabStop = False
        '
        'pnlPassword
        '
        Me.pnlPassword.BackColor = System.Drawing.Color.White
        Me.pnlPassword.Controls.Add(Me.picPass)
        Me.pnlPassword.Controls.Add(Me.txtPassword)
        Me.pnlPassword.Location = New System.Drawing.Point(52, 313)
        Me.pnlPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlPassword.Name = "pnlPassword"
        Me.pnlPassword.Padding = New System.Windows.Forms.Padding(1)
        Me.pnlPassword.Size = New System.Drawing.Size(221, 39)
        Me.pnlPassword.TabIndex = 4
        '
        'picPass
        '
        Me.picPass.BackColor = System.Drawing.Color.White
        Me.picPass.BackgroundImage = Global.CRUD_Access.My.Resources.Resources.if_46_Lock_2123931
        Me.picPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picPass.Dock = System.Windows.Forms.DockStyle.Right
        Me.picPass.Location = New System.Drawing.Point(173, 1)
        Me.picPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPass.Name = "picPass"
        Me.picPass.Size = New System.Drawing.Size(47, 37)
        Me.picPass.TabIndex = 2
        Me.picPass.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picLogo.BackgroundImage = Global.CRUD_Access.My.Resources.Resources.R_logo_svg
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLogo.Location = New System.Drawing.Point(61, 42)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(211, 185)
        Me.picLogo.TabIndex = 3
        Me.picLogo.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(172, 377)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(103, 50)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(335, 479)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.pnlPassword)
        Me.Controls.Add(Me.pnlUsername)
        Me.Controls.Add(Me.btnLogin)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AUTHENTICATION"
        Me.pnlUsername.ResumeLayout(False)
        Me.pnlUsername.PerformLayout()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPassword.ResumeLayout(False)
        Me.pnlPassword.PerformLayout()
        CType(Me.picPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents pnlUsername As Panel
    Friend WithEvents pnlPassword As Panel
    Friend WithEvents picUser As PictureBox
    Friend WithEvents picPass As PictureBox
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnBack As Button
End Class
