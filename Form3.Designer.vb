<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        btnD = New Button()
        btnW = New Button()
        lblBalance = New Label()
        Label1 = New Label()
        MenuStrip3 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        LB1 = New ListBox()
        MenuStrip3.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnD
        ' 
        btnD.BackColor = SystemColors.Info
        btnD.BackgroundImage = My.Resources.Resources.blue_texture_1253_136
        btnD.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnD.Location = New Point(226, 314)
        btnD.Margin = New Padding(2)
        btnD.Name = "btnD"
        btnD.Size = New Size(190, 70)
        btnD.TabIndex = 2
        btnD.Text = "Deposit"
        btnD.UseVisualStyleBackColor = False
        ' 
        ' btnW
        ' 
        btnW.BackColor = SystemColors.Info
        btnW.BackgroundImage = My.Resources.Resources.blue_texture_1253_136
        btnW.FlatStyle = FlatStyle.Flat
        btnW.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnW.Location = New Point(514, 314)
        btnW.Margin = New Padding(2)
        btnW.Name = "btnW"
        btnW.Size = New Size(190, 70)
        btnW.TabIndex = 7
        btnW.Text = "Withdraw"
        btnW.UseVisualStyleBackColor = False
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.BackColor = SystemColors.ButtonFace
        lblBalance.BorderStyle = BorderStyle.FixedSingle
        lblBalance.FlatStyle = FlatStyle.Popup
        lblBalance.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        lblBalance.Location = New Point(514, 174)
        lblBalance.Margin = New Padding(2, 0, 2, 0)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(158, 83)
        lblBalance.TabIndex = 4
        lblBalance.Text = "0.00"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Menu
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(346, 174)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 81)
        Label1.TabIndex = 6
        Label1.Text = "$"
        ' 
        ' MenuStrip3
        ' 
        MenuStrip3.ImageScalingSize = New Size(20, 20)
        MenuStrip3.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1})
        MenuStrip3.Location = New Point(0, 0)
        MenuStrip3.Name = "MenuStrip3"
        MenuStrip3.Size = New Size(936, 28)
        MenuStrip3.TabIndex = 8
        MenuStrip3.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(76, 24)
        ToolStripMenuItem1.Text = "Log-out"
        ' 
        ' LB1
        ' 
        LB1.FormattingEnabled = True
        LB1.ItemHeight = 20
        LB1.Location = New Point(874, 396)
        LB1.Name = "LB1"
        LB1.Size = New Size(70, 144)
        LB1.TabIndex = 9
        LB1.Visible = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.geometric_shapes_neon_lights_background_23_2148424984
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(936, 556)
        Controls.Add(LB1)
        Controls.Add(Label1)
        Controls.Add(lblBalance)
        Controls.Add(btnD)
        Controls.Add(btnW)
        Controls.Add(MenuStrip3)
        DoubleBuffered = True
        MainMenuStrip = MenuStrip3
        Margin = New Padding(2)
        Name = "Form3"
        Text = "Account"
        MenuStrip3.ResumeLayout(False)
        MenuStrip3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnW As Button
    Friend WithEvents lblBalance As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LB1 As ListBox
End Class
