Imports MySql.Data.MySqlClient
Public Class CandidatesPage

    Private Sub MembersPage3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call LoadData to fill the DataGridView with data
        LoadData2()
        LoadCandidates()
    End Sub


    Private Sub LoadCandidates()
        ' Clear old items if reloading
        FlowLayoutPanel2.Controls.Clear()

        ' Let's say you have a list of image paths or a loop from DB records

        Dim imagePaths As List(Of String) = New List(Of String) From {
            Application.StartupPath & "\Resources\woman.jpg"
            }

        MessageBox.Show("Looking for image at: " & imagePaths(0))

        For Each imgPath In imagePaths
            Try
                If System.IO.File.Exists(imgPath) Then
                    Dim pic As New PictureBox
                    pic.Image = Image.FromFile(imgPath)
                    pic.SizeMode = PictureBoxSizeMode.Zoom
                    pic.Width = 100
                    pic.Height = 100
                    pic.Margin = New Padding(10)
                    pic.Cursor = Cursors.Hand
                    pic.Tag = imgPath

                    AddHandler pic.Click, AddressOf Candidate_Clicked
                    FlowLayoutPanel2.Controls.Add(pic)
                Else
                    MessageBox.Show("Image not found: " & imgPath)
                End If
            Catch ex As Exception
                MessageBox.Show("Failed to load image: " & ex.Message)
            End Try
        Next
    End Sub '<- For appearing and clickable pictures


    Private Sub Candidate_Clicked(sender As Object, e As EventArgs)
        Dim clickedPic As PictureBox = CType(sender, PictureBox)
        Dim tagInfo As String = clickedPic.Tag.ToString()

        ' Open Form6 and pass the tag info (image path, ID, etc.)
        Dim nextForm As New AdminPage()
        nextForm.Show()

    End Sub



    Public Sub LoadData2()
        Dim con As New MySqlConnection("server=localhost;port=3306;userid=root;password=;database=elect_database")
        Dim query As String = "SELECT * FROM voters_table"
        Dim adapter As New MySqlDataAdapter(query, con)
        Dim table As New DataTable()

        Try
            ' Fill the DataTable with data
            adapter.Fill(table)

            ' Bind the DataTable to DataGridView1
            '  DataGridMembers.DataSource = table ' 

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Class
