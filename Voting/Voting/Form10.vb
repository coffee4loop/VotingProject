Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class CreateAcc
    Dim selectedImagePath As String = ""

    Private Function HashPassword(password As String) As String ' <- Basic encryption functionalities'
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub CreateAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnSubmitAcc.Enabled = False '<- Submit button is disabled when not all fields are filled' 
        Try

            Dim con As New MySqlConnection("server=localhost;port=3306;userid=root;password=;database=elect_database")


            con.Open()
            MessageBox.Show("Connection successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Proceed with data retrieval
            Dim da As New MySqlDataAdapter("SELECT * FROM voters_table", con)
            Dim dt As New DataTable()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadData()
        Dim con As New MySqlConnection("server=localhost;port=3306;userid=root;password=;database=elect_database")
        Dim query As String = "Select * FROM voters_table"
        Dim adapter As New MySqlDataAdapter(query, con)
        Dim table As New DataTable()
        adapter.Fill(table)
    End Sub

    Private Sub Photo_Click(sender As Object, e As EventArgs) Handles Photo.Click
        'Para saan ito?' 
    End Sub


    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles TxtUsername.TextChanged, TxtPassword.TextChanged, TextName.TextChanged, TxtDepartment.TextChanged, TxtEmail.TextChanged
        CheckFormCompletion()
    End Sub


    Private Sub CheckFormCompletion() '<- For disabling submission if a field is empty (includes pictures)' 

        Dim allFilled As Boolean =
        Not String.IsNullOrWhiteSpace(TxtUsername.Text) AndAlso
        Not String.IsNullOrWhiteSpace(TxtPassword.Text) AndAlso
        Not String.IsNullOrWhiteSpace(TextName.Text) AndAlso
        Not String.IsNullOrWhiteSpace(TxtDepartment.Text) AndAlso
        Not String.IsNullOrWhiteSpace(TxtEmail.Text)


        If Photo.Image Is Nothing Then
            allFilled = False
        End If ' <- Checks if no photo was submitted' 

        BtnSubmitAcc.Enabled = allFilled
    End Sub


    Private Sub ClearFields()
        TxtUsername.Clear()
        TxtPassword.Clear()
        TextName.Clear()
        TxtDepartment.Clear()
        TxtEmail.Clear()
        Photo.Image = Nothing
        selectedImagePath = ""
        CheckFormCompletion()
    End Sub


    Private Sub BtnSubmitAcc_Click(sender As Object, e As EventArgs) Handles BtnSubmitAcc.Click
        Dim con As New MySqlConnection("server=localhost;port=3306;userid=root;password=;database=elect_database")
        Dim query As String = "INSERT INTO voters_table(username, password, name, department, email, voter_pic) VALUES(@username, @password, @Name, @Department, @Email, @voter_pic)"
        Using cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@username", TxtUsername.Text)
            cmd.Parameters.AddWithValue("@password", HashPassword(TxtPassword.Text))
            cmd.Parameters.AddWithValue("@Name", TextName.Text)
            cmd.Parameters.AddWithValue("@Department", TxtDepartment.Text)
            cmd.Parameters.AddWithValue("@Email", TxtEmail.Text)


            If Not String.IsNullOrEmpty(selectedImagePath) Then
                Dim imgBytes() As Byte = File.ReadAllBytes(selectedImagePath)
                cmd.Parameters.Add("@voter_pic", MySqlDbType.Blob).Value = imgBytes
            Else
                cmd.Parameters.Add("@voter_pic", MySqlDbType.Blob).Value = DBNull.Value
            End If

            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            ClearFields() ' <- For clearing fields after submissio or if "clear" button is clicked'
            con.Close()

        End Using

    End Sub

    Private Sub BtnSubmitPhoto_Click(sender As Object, e As EventArgs) Handles BtnSubmitPhoto.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png"
        If ofd.ShowDialog() = DialogResult.OK Then
            selectedImagePath = ofd.FileName
            Photo.Image = Image.FromFile(selectedImagePath)
            CheckFormCompletion()
        End If
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        ClearFields()
    End Sub
End Class
