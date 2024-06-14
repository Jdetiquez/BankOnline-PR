Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form2
    Dim connectionString As String = "Server=localhost;Database=finals;Uid=root;Pwd=;"



    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Pintxt.Text &= "1"
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Pintxt.Text &= "2"
    End Sub
    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Pintxt.Text &= "3"
    End Sub
    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        Pintxt.Text &= "4"
    End Sub
    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        Pintxt.Text &= "5"
    End Sub
    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        Pintxt.Text &= "6"
    End Sub
    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        Pintxt.Text &= "7"
    End Sub
    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        Pintxt.Text &= "8"

    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        Pintxt.Text &= "9"

    End Sub

    Private Sub B10_Click(sender As Object, e As EventArgs) Handles B10.Click
        Pintxt.Text &= "0"

    End Sub
    Private Sub btnp_Click(sender As Object, e As EventArgs) Handles btnp.Click
        Dim username As String = Form1.Utxt.Text
        Dim password As String = Form1.Ptxt.Text
        Dim pin As String = Pintxt.Text

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim sqlQuery As String = "SELECT COUNT(*) FROM login WHERE username = @Username AND password = @Password AND pin = @Pin"
                Using command As New MySqlCommand(sqlQuery, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", password)
                    command.Parameters.AddWithValue("@Pin", pin)

                    Dim result As Integer = CInt(command.ExecuteScalar())

                    If result > 0 Then
                        MessageBox.Show("Login Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Form3.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Incorrect PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Pintxt.Clear() ' Clear PIN input on incorrect attempt
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim response As MsgBoxResult
        response = MsgBox("Are you sure you want to log-out?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Exit")
        If response = MsgBoxResult.Yes Then
            Form1.Utxt.Clear()
            Form1.Ptxt.Clear()
            Pintxt.Clear()
            Form1.Show()
            Me.Hide()
        ElseIf response = MsgBoxResult.No Then 'Button to exit the program completely 
            Exit Sub
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
