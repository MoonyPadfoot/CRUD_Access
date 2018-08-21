<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudents
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
        Me.pnlStudID = New System.Windows.Forms.Panel()
        Me.txtStudID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblStudID = New System.Windows.Forms.Label()
        Me.pnlStudID.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlStudID
        '
        Me.pnlStudID.BackColor = System.Drawing.Color.White
        Me.pnlStudID.Controls.Add(Me.txtStudID)
        Me.pnlStudID.Location = New System.Drawing.Point(134, 22)
        Me.pnlStudID.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlStudID.Name = "pnlStudID"
        Me.pnlStudID.Padding = New System.Windows.Forms.Padding(1)
        Me.pnlStudID.Size = New System.Drawing.Size(221, 39)
        Me.pnlStudID.TabIndex = 5
        '
        'txtStudID
        '
        Me.txtStudID.BackColor = System.Drawing.SystemColors.Window
        Me.txtStudID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudID.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtStudID.Enabled = False
        Me.txtStudID.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudID.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtStudID.Location = New System.Drawing.Point(1, 1)
        Me.txtStudID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudID.Multiline = True
        Me.txtStudID.Name = "txtStudID"
        Me.txtStudID.Size = New System.Drawing.Size(220, 37)
        Me.txtStudID.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(134, 82)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(221, 39)
        Me.Panel1.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox1.Location = New System.Drawing.Point(1, 1)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 37)
        Me.TextBox1.TabIndex = 1
        '
        'lblStudID
        '
        Me.lblStudID.AutoSize = True
        Me.lblStudID.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudID.Location = New System.Drawing.Point(20, 31)
        Me.lblStudID.Name = "lblStudID"
        Me.lblStudID.Size = New System.Drawing.Size(98, 21)
        Me.lblStudID.TabIndex = 7
        Me.lblStudID.Text = "Student ID"
        '
        'frmStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CRUD_Access.My.Resources.Resources.minmalist1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1190, 484)
        Me.Controls.Add(Me.lblStudID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlStudID)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStudents"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STUDENTS"
        Me.pnlStudID.ResumeLayout(False)
        Me.pnlStudID.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlStudID As Panel
    Friend WithEvents txtStudID As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblStudID As Label
    Friend WithEvents Panel1 As Panel
End Class
