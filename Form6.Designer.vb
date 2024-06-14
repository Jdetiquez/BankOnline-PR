<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Lbl10 = New Label()
        Lbl12 = New Label()
        Lbl13 = New Label()
        Txtr1 = New TextBox()
        Txtr2 = New TextBox()
        Txtr3 = New TextBox()
        Label4 = New Label()
        Btnrgtr = New Button()
        SuspendLayout()
        ' 
        ' Lbl10
        ' 
        Lbl10.AutoSize = True
        Lbl10.BackColor = Color.Transparent
        Lbl10.Font = New Font("Bauhaus 93", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl10.Location = New Point(122, 104)
        Lbl10.Name = "Lbl10"
        Lbl10.Size = New Size(119, 23)
        Lbl10.TabIndex = 0
        Lbl10.Text = "USERNAME:"
        ' 
        ' Lbl12
        ' 
        Lbl12.AutoSize = True
        Lbl12.BackColor = Color.Transparent
        Lbl12.Font = New Font("Bauhaus 93", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl12.Location = New Point(117, 167)
        Lbl12.Name = "Lbl12"
        Lbl12.Size = New Size(124, 23)
        Lbl12.TabIndex = 1
        Lbl12.Text = "PASSWORD:"
        ' 
        ' Lbl13
        ' 
        Lbl13.AutoSize = True
        Lbl13.BackColor = Color.Transparent
        Lbl13.Font = New Font("Bauhaus 93", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl13.Location = New Point(190, 228)
        Lbl13.Name = "Lbl13"
        Lbl13.Size = New Size(52, 23)
        Lbl13.TabIndex = 2
        Lbl13.Text = "PIN:"
        ' 
        ' Txtr1
        ' 
        Txtr1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Txtr1.Location = New Point(326, 104)
        Txtr1.Name = "Txtr1"
        Txtr1.Size = New Size(171, 34)
        Txtr1.TabIndex = 3
        ' 
        ' Txtr2
        ' 
        Txtr2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Txtr2.Location = New Point(326, 167)
        Txtr2.Name = "Txtr2"
        Txtr2.Size = New Size(171, 34)
        Txtr2.TabIndex = 4
        ' 
        ' Txtr3
        ' 
        Txtr3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Txtr3.Location = New Point(326, 228)
        Txtr3.Name = "Txtr3"
        Txtr3.Size = New Size(125, 34)
        Txtr3.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(198, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(233, 38)
        Label4.TabIndex = 6
        Label4.Text = "REGISTER FORM"
        ' 
        ' Btnrgtr
        ' 
        Btnrgtr.BackColor = Color.Transparent
        Btnrgtr.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btnrgtr.Image = My.Resources.Resources.grey_gradient_abstract_176532_7758
        Btnrgtr.Location = New Point(226, 309)
        Btnrgtr.Name = "Btnrgtr"
        Btnrgtr.Size = New Size(152, 55)
        Btnrgtr.TabIndex = 7
        Btnrgtr.Text = "REGISTER"
        Btnrgtr.UseVisualStyleBackColor = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.download
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(567, 402)
        Controls.Add(Btnrgtr)
        Controls.Add(Label4)
        Controls.Add(Txtr3)
        Controls.Add(Txtr2)
        Controls.Add(Txtr1)
        Controls.Add(Lbl13)
        Controls.Add(Lbl12)
        Controls.Add(Lbl10)
        Name = "Form6"
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl10 As Label
    Friend WithEvents Lbl12 As Label
    Friend WithEvents Lbl13 As Label
    Friend WithEvents Txtr1 As TextBox
    Friend WithEvents Txtr2 As TextBox
    Friend WithEvents Txtr3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Btnrgtr As Button
End Class
