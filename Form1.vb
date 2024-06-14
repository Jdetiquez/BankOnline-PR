Imports MySql.Data.MySqlClient

Public Class Form1
    Private connectionString As String = "Server=localhost;Database=finals;Uid=root;Pwd=;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Database connection is opened and closed within this method
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM Login"
                Using cmd As New MySqlCommand(query, connection)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        Dim userId As Integer = Convert.ToInt32(reader("id"))
                        Dim username As String = reader("Username").ToString()
                        Dim password As String = reader("Password").ToString()
                        ' Process the data
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If String.IsNullOrWhiteSpace(Utxt.Text) OrElse String.IsNullOrWhiteSpace(Ptxt.Text) Then
            MessageBox.Show("Username and Password are required.")
            Return
        End If

        Dim username As String = Utxt.Text
        Dim password As String = Ptxt.Text
        Dim pin As String = Form2.Pintxt.Text

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim sqlQuery As String = "SELECT COUNT(*) FROM login WHERE username = @Username AND password = @Password"
                Using command As New MySqlCommand(sqlQuery, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", password)
                    Dim result As Integer = CInt(command.ExecuteScalar())
                    If result > 0 Then
                        MessageBox.Show("Login Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Form2.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Login failed. Invalid username or password.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Bcancel_Click(sender As Object, e As EventArgs) Handles Bcancel.Click
        Dim response As MsgBoxResult
        response = MsgBox("Do you want to close the form?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Exit")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
        ElseIf response = MsgBoxResult.No Then 'Button to exit the program completely 
            Exit Sub
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If Ptxt.UseSystemPasswordChar = True Then

            Ptxt.UseSystemPasswordChar = False
        Else
            Ptxt.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub Badmin_Click(sender As Object, e As EventArgs) Handles Badmin.Click
        Form8.Show()
        Me.Hide()

    End Sub
End Class
