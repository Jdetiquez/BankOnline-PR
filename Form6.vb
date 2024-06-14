Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class Form6
    Dim connectionString As String = "Server=localhost;port=3306;Database=finals;Username=root;Password=;"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub Btnrgtr_Click(sender As Object, e As EventArgs) Handles Btnrgtr.Click



        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("INSERT INTO `login`(`Username`, `Password`, `Pin`) VALUES (@Username,@Password,@Pin)", connection)
            command.Parameters.Add("@Username", MySqlDbType.VarChar).Value = Txtr1.Text
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = Txtr2.Text
            command.Parameters.Add("@Pin", MySqlDbType.VarChar).Value = Txtr3.Text
            connection.Open()
            If command.ExecuteNonQuery > 0 Then
                MessageBox.Show("Registered Successfully", "Registered!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form1.Show()
                Txtr1.Clear()
                Txtr2.Clear()
                Txtr3.Clear()
                Me.Hide()
            Else
                MessageBox.Show("Error", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End Using
    End Sub
End Class