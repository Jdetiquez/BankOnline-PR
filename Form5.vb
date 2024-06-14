Imports MySql.Data.MySqlClient

Public Class Form5
    Dim connectionString As String = "Server=localhost;Database=finals;Uid=root;Pwd=;"
    Dim connection As New MySqlConnection(connectionString)
    Dim form3 As Form3
    Dim form9 As Form9

    Public Sub New(ByRef form3Instance As Form3, ByRef form9Instance As Form9)
        InitializeComponent()
        form3 = form3Instance
        form9 = form9Instance
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim username As String = Form1.Utxt.Text
        Dim amount As Double

        If Double.TryParse(txtwidth.Text, amount) Then
            Try
                connection.Open()

                ' Update the balance in the database by subtracting the withdrawal amount.
                Dim sqlQuery As String = "UPDATE login SET balance = balance - @Amount WHERE username = @Username"
                Using command As New MySqlCommand(sqlQuery, connection)
                    command.Parameters.AddWithValue("@Amount", amount)
                    command.Parameters.AddWithValue("@Username", username)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Withdrawal successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("User not found or an error occurred.")
                    End If
                End Using

                ' Update the transaction history with the withdrawal details.
                Dim transactionDetails As String = $"Mr./Mrs. {username} Withdrawn ${amount} on {DateTime.Now}"
                Form3.transactionHistory.Add(transactionDetails)
                form3.UpdateTransactionHistory()

                ' Update Form9's transaction list.
                form9.UpdateTransactionList(transactionDetails)

                ' Close the withdrawal form and update the balance label in Form3.
                Me.Close()
                form3.UpdateBalanceLabel()
                form3.Show()
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MessageBox.Show("Please enter a valid amount.")
        End If
    End Sub
End Class
