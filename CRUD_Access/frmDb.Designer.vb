<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDb
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
        Me.pnlPath = New System.Windows.Forms.Panel()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlPath.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPath
        '
        Me.pnlPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPath.Controls.Add(Me.btnPath)
        Me.pnlPath.Controls.Add(Me.txtPath)
        Me.pnlPath.Location = New System.Drawing.Point(30, 41)
        Me.pnlPath.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlPath.Name = "pnlPath"
        Me.pnlPath.Padding = New System.Windows.Forms.Padding(1)
        Me.pnlPath.Size = New System.Drawing.Size(350, 31)
        Me.pnlPath.TabIndex = 4
        '
        'btnPath
        '
        Me.btnPath.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPath.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPath.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnPath.Image = Global.CRUD_Access.My.Resources.Resources.if_2_Folder_2672696__1_
        Me.btnPath.Location = New System.Drawing.Point(306, 1)
        Me.btnPath.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(41, 27)
        Me.btnPath.TabIndex = 6
        Me.btnPath.UseVisualStyleBackColor = False
        '
        'txtPath
        '
        Me.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPath.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtPath.Enabled = False
        Me.txtPath.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtPath.Location = New System.Drawing.Point(1, 1)
        Me.txtPath.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPath.Multiline = True
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtPath.Size = New System.Drawing.Size(309, 27)
        Me.txtPath.TabIndex = 0
        '
        'btnTest
        '
        Me.btnTest.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTest.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.Location = New System.Drawing.Point(479, 42)
        Me.btnTest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(87, 30)
        Me.btnTest.TabIndex = 6
        Me.btnTest.Text = "TEST"
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MintCream
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(386, 41)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 30)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmDb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CRUD_Access.My.Resources.Resources.minmalist1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(587, 125)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.pnlPath)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDb"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATABASE PATH"
        Me.pnlPath.ResumeLayout(False)
        Me.pnlPath.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPath As Panel
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents btnTest As Button
    Friend WithEvents btnSave As Button
End Class
