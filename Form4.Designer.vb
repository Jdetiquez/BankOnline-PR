<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label1 = New Label()
        txtAmount = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(54, 104)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 20)
        Label1.TabIndex = 0
        Label1.Text = "Amount:"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(129, 101)
        txtAmount.Margin = New Padding(2, 2, 2, 2)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(259, 27)
        txtAmount.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = My.Resources.Resources.deposit
        PictureBox1.Location = New Point(426, 70)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(113, 88)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.gradient_mint_background_23_2150284417
        ClientSize = New Size(550, 226)
        Controls.Add(PictureBox1)
        Controls.Add(txtAmount)
        Controls.Add(Label1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form4"
        Text = "Deposit"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
