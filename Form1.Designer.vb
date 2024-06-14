<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Ptxt = New TextBox()
        Utxt = New TextBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Bcancel = New Button()
        LinkLabel1 = New LinkLabel()
        CheckBox1 = New CheckBox()
        Badmin = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkOrange
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.Location = New Point(76, 429)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(67, 30)
        Button1.TabIndex = 0
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 267)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 1
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(44, 318)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 2
        Label2.Text = "Password:"
        ' 
        ' Ptxt
        ' 
        Ptxt.Location = New Point(145, 316)
        Ptxt.Margin = New Padding(2)
        Ptxt.Name = "Ptxt"
        Ptxt.Size = New Size(126, 27)
        Ptxt.TabIndex = 3
        Ptxt.UseSystemPasswordChar = True
        ' 
        ' Utxt
        ' 
        Utxt.Location = New Point(145, 265)
        Utxt.Margin = New Padding(2)
        Utxt.Name = "Utxt"
        Utxt.Size = New Size(126, 27)
        Utxt.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(53, 48)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(239, 168)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.download
        PictureBox2.Location = New Point(356, 1)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(488, 565)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Bcancel
        ' 
        Bcancel.BackColor = Color.DarkOrange
        Bcancel.Font = New Font("Segoe UI", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Bcancel.Location = New Point(181, 429)
        Bcancel.Margin = New Padding(2)
        Bcancel.Name = "Bcancel"
        Bcancel.Size = New Size(90, 30)
        Bcancel.TabIndex = 7
        Bcancel.Text = "Cancel"
        Bcancel.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(53, 396)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(136, 20)
        LinkLabel1.TabIndex = 8
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Not yet registered?"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(145, 348)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(132, 24)
        CheckBox1.TabIndex = 9
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Badmin
        ' 
        Badmin.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Badmin.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Badmin.Location = New Point(181, 477)
        Badmin.Name = "Badmin"
        Badmin.Size = New Size(88, 28)
        Badmin.TabIndex = 10
        Badmin.Text = "Admin"
        Badmin.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(844, 567)
        Controls.Add(Badmin)
        Controls.Add(CheckBox1)
        Controls.Add(LinkLabel1)
        Controls.Add(Bcancel)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Utxt)
        Controls.Add(Ptxt)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Margin = New Padding(2)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Ptxt As TextBox
    Friend WithEvents Utxt As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Bcancel As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Badmin As Button
End Class
