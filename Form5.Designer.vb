<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        txtwidth = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtwidth
        ' 
        txtwidth.Location = New Point(120, 107)
        txtwidth.Margin = New Padding(2, 2, 2, 2)
        txtwidth.Name = "txtwidth"
        txtwidth.Size = New Size(259, 27)
        txtwidth.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(45, 110)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 20)
        Label1.TabIndex = 3
        Label1.Text = "Amount:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = My.Resources.Resources.withdraw
        PictureBox1.Location = New Point(394, 64)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(106, 97)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.gradient_mint_background_23_2150284417
        ClientSize = New Size(520, 215)
        Controls.Add(PictureBox1)
        Controls.Add(txtwidth)
        Controls.Add(Label1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form5"
        Text = "Widthdraw"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtwidth As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
