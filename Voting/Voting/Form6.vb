Partial Public Class AdminPage

    Inherits System.Windows.Forms.Form

    Private Sub BtnPositionsPage_Click(sender As Object, e As EventArgs) Handles BtnPositionsPage.Click
        ' Open the next form (MembersPage)
        Dim newForm As New PositionsPage()
        newForm.Show()     ' Show the new form
        '   Me.Hide()          ' Optionally hide the current form
    End Sub

    Private Sub BtnCandidatesPage_Click(sender As Object, e As EventArgs) Handles BtnCandidatesPage.Click
        ' Open the next form (MembersPage)
        Dim newForm As New CandidatesPage()
        newForm.Show()     ' Show the new form
        '   Me.Hide()          ' Optionally hide the current form
    End Sub

    Private Sub BtnMembersPage2_Click(sender As Object, e As EventArgs) Handles BtnMembersPage2.Click
        ' Open the next form (MembersPage)
        Dim newForm As New memberspage3()
        newForm.Show()     ' Show the new form
        '   Me.Hide()          ' Optionally hide the current form
    End Sub

    Private Sub BtnPending_Click(sender As Object, e As EventArgs) Handles BtnPending.Click
        ' Open the next form (MembersPage)
        Dim newForm As New PendingPage()
        newForm.Show()     ' Show the new form
        '   Me.Hide()          ' Optionally hide the current form
    End Sub
End Class
