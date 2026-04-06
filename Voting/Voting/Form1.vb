Partial Public Class MainPage

    Inherits System.Windows.Forms.Form

    Private Sub BtnMembers_Click(sender As Object, e As EventArgs) Handles BtnMembers.Click
        ' Open the next form (MembersPage)
        Dim newForm As New MembersPage()
        newForm.Show()     ' Show the new form
        '   Me.Hide()          ' Optionally hide the current form
    End Sub

    Private Sub BtnAdminPage_Click(sender As Object, e As EventArgs) Handles BtnAdminPage.Click
        ' Open the next form (MembersPage)
        Dim newForm As New AdminPage()
        newForm.Show()     ' Show the new form
        '   Me.Hide()          ' Optionally hide the current form
    End Sub

    Private Sub BtnCreateAcc_Click(sender As Object, e As EventArgs) Handles BtnCreateAcc.Click
        ' Open the next form (MembersPage)
        Dim newForm As New CreateAcc()
        newForm.Show()     ' Show the new form
        '   Me.Hide()          ' Optionally hide the current form
    End Sub


End Class
