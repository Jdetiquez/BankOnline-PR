Imports MySql.Data.MySqlClient

Public Class Form3
    Dim connectionString As String = "Server=localhost;Database=finals;Uid=root;Pwd=;"
    Dim connection As New MySqlConnection(connectionString)

    Public Shared transactionHistory As New List(Of String)
    Dim form4 As Form4
    Dim form5 As Form5
    Dim form9 As Form9

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form9 = New Form9()
        form9.Show()

        Dim username As String = Form1.Utxt.Text
        Dim password As String = Form1.Ptxt.Text
        Dim pin As String = Form2.Pintxt.Text

        Try
            connection.Open()
            Dim sqlQuery As String = "SELECT balance FROM login WHERE username = @Username AND password = @Password AND pin = @Pin"

            Using command As New MySqlCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)
                command.Parameters.AddWithValue("@Pin", pin)

                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    Dim balance As String = reader("balance").ToString()
                    lblBalance.Text = balance
                Else
                    lblBalance.Text = "User not found or credentials incorrect."
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub UpdateBalanceLabel()
        Dim username As String = Form1.Utxt.Text
        Dim password As String = Form1.Ptxt.Text
        Dim pin As String = Form2.Pintxt.Text

        Try
            connection.Open()
            Dim sqlQuery As String = "SELECT balance FROM login WHERE username = @Username AND password = @Password AND pin = @Pin"

            Using command As New MySqlCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)
                command.Parameters.AddWithValue("@Pin", pin)

                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    Dim balance As String = reader("balance").ToString()
                    lblBalance.Text = balance
                Else
                    lblBalance.Text = "User not found or credentials incorrect."
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
        UpdateTransactionHistory()
    End Sub

    Public Sub UpdateTransactionHistory()
        LB1.Items.Clear()
        For Each transaction As String In transactionHistory
            LB1.Items.Add(transaction)
        Next
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        form4 = New Form4(Me, form9)
        form4.Show()
        Me.Hide()
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        form5 = New Form5(Me, form9)
        form5.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim response As MsgBoxResult
        response = MsgBox("Are you sure you want to log-out?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Exit")
        If response = MsgBoxResult.Yes Then
            Form1.Utxt.Clear()
            Form1.Ptxt.Clear()
            Form2.Pintxt.Clear()
            Form1.Show()
            Me.Hide()

        ElseIf response = MsgBoxResult.No Then 'Button to exit the program completely 
            Exit Sub
        End If
    End Sub


End Class
