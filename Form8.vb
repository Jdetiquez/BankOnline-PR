Imports MySql.Data.MySqlClient
Public Class Form8

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New MySqlConnection("Server=localhost;port=3306;username=root;password=")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM finals.login", connection)

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub


    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()

    End Sub


End Class