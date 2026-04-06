Partial Public Class MembersPage

    Inherits System.Windows.Forms.Form

    Private Sub BtnNomPage_Click(sender As Object, e As EventArgs) Handles BtnNomPage.Click
        ' Open the next form (MembersPage)
        Dim newForm As New NominationPage()
        newForm.Show()     ' Show the new form
        'Me.Hide()          ' Optionally hide the current form
    End Sub

    Private Sub BtnVotePage_Click(sender As Object, e As EventArgs) Handles BtnVotePage.Click
        ' Open the next form (MembersPage)
        Dim newForm As New VotingPage()
        newForm.Show()     ' Show the new form
        'Me.Hide()          ' Optionally hide the current form
    End Sub


End Class
