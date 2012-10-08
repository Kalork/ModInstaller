<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TB_src = New System.Windows.Forms.TextBox()
        Me.BT_Install = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OFD_src = New System.Windows.Forms.OpenFileDialog()
        Me.BT_openOFD = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TB_src
        '
        Me.TB_src.Location = New System.Drawing.Point(10, 19)
        Me.TB_src.Name = "TB_src"
        Me.TB_src.ReadOnly = True
        Me.TB_src.Size = New System.Drawing.Size(389, 20)
        Me.TB_src.TabIndex = 0
        '
        'BT_Install
        '
        Me.BT_Install.Location = New System.Drawing.Point(436, 17)
        Me.BT_Install.Name = "BT_Install"
        Me.BT_Install.Size = New System.Drawing.Size(75, 23)
        Me.BT_Install.TabIndex = 1
        Me.BT_Install.Text = "Installer"
        Me.BT_Install.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BT_openOFD)
        Me.GroupBox1.Controls.Add(Me.TB_src)
        Me.GroupBox1.Controls.Add(Me.BT_Install)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(517, 53)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Installer un addon"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 48)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Créer un fichier d'addon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prochainement..."
        '
        'OFD_src
        '
        Me.OFD_src.DefaultExt = "mi"
        Me.OFD_src.Filter = "Fichier d'addon MI|*.mi"
        '
        'BT_openOFD
        '
        Me.BT_openOFD.Location = New System.Drawing.Point(405, 17)
        Me.BT_openOFD.Name = "BT_openOFD"
        Me.BT_openOFD.Size = New System.Drawing.Size(25, 23)
        Me.BT_openOFD.TabIndex = 2
        Me.BT_openOFD.Text = "..."
        Me.BT_openOFD.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 135)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "main"
        Me.Text = "ModInstaller"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TB_src As System.Windows.Forms.TextBox
    Friend WithEvents BT_Install As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OFD_src As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BT_openOFD As System.Windows.Forms.Button

End Class
