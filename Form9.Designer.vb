<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        LB2 = New ListBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' LB2
        ' 
        LB2.FormattingEnabled = True
        LB2.ItemHeight = 20
        LB2.Location = New Point(147, 124)
        LB2.Name = "LB2"
        LB2.Size = New Size(520, 284)
        LB2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(288, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(260, 35)
        Label1.TabIndex = 1
        Label1.Text = "Transaction Report"
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.creative_gradient_futuristic_background_23_2149136586
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(LB2)
        Name = "Form9"
        Text = "Form9"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LB2 As ListBox
    Friend WithEvents Label1 As Label
End Class
