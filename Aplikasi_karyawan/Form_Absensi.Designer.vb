<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Absensi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Absensi))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TextBoxNIK = New System.Windows.Forms.TextBox
        Me.Labeltgsekarang = New System.Windows.Forms.Label
        Me.LabelJamsekarang = New System.Windows.Forms.Label
        Me.LabelNIK = New System.Windows.Forms.Label
        Me.LabelInfo = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(55, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 184)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBoxNIK
        '
        Me.TextBoxNIK.Location = New System.Drawing.Point(55, 274)
        Me.TextBoxNIK.Name = "TextBoxNIK"
        Me.TextBoxNIK.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxNIK.TabIndex = 1
        '
        'Labeltgsekarang
        '
        Me.Labeltgsekarang.AutoSize = True
        Me.Labeltgsekarang.Location = New System.Drawing.Point(249, 68)
        Me.Labeltgsekarang.Name = "Labeltgsekarang"
        Me.Labeltgsekarang.Size = New System.Drawing.Size(39, 13)
        Me.Labeltgsekarang.TabIndex = 2
        Me.Labeltgsekarang.Text = "Label1"
        '
        'LabelJamsekarang
        '
        Me.LabelJamsekarang.AutoSize = True
        Me.LabelJamsekarang.Location = New System.Drawing.Point(249, 96)
        Me.LabelJamsekarang.Name = "LabelJamsekarang"
        Me.LabelJamsekarang.Size = New System.Drawing.Size(39, 13)
        Me.LabelJamsekarang.TabIndex = 3
        Me.LabelJamsekarang.Text = "Label2"
        '
        'LabelNIK
        '
        Me.LabelNIK.AutoSize = True
        Me.LabelNIK.Location = New System.Drawing.Point(249, 125)
        Me.LabelNIK.Name = "LabelNIK"
        Me.LabelNIK.Size = New System.Drawing.Size(39, 13)
        Me.LabelNIK.TabIndex = 4
        Me.LabelNIK.Text = "Label3"
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Location = New System.Drawing.Point(249, 155)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(39, 13)
        Me.LabelInfo.TabIndex = 5
        Me.LabelInfo.Text = "Label4"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form_Absensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(392, 368)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.LabelNIK)
        Me.Controls.Add(Me.LabelJamsekarang)
        Me.Controls.Add(Me.Labeltgsekarang)
        Me.Controls.Add(Me.TextBoxNIK)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form_Absensi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Absensi"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxNIK As System.Windows.Forms.TextBox
    Friend WithEvents Labeltgsekarang As System.Windows.Forms.Label
    Friend WithEvents LabelJamsekarang As System.Windows.Forms.Label
    Friend WithEvents LabelNIK As System.Windows.Forms.Label
    Friend WithEvents LabelInfo As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
