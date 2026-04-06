<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnPositionsPage = New System.Windows.Forms.Button()
        Me.BtnCandidatesPage = New System.Windows.Forms.Button()
        Me.BtnMembersPage2 = New System.Windows.Forms.Button()
        Me.BtnPending = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnPositionsPage
        '
        Me.BtnPositionsPage.Location = New System.Drawing.Point(59, 29)
        Me.BtnPositionsPage.Name = "BtnPositionsPage"
        Me.BtnPositionsPage.Size = New System.Drawing.Size(240, 85)
        Me.BtnPositionsPage.TabIndex = 0
        Me.BtnPositionsPage.Text = "PositionPage"
        Me.BtnPositionsPage.UseVisualStyleBackColor = True
        '
        'BtnCandidatesPage
        '
        Me.BtnCandidatesPage.Location = New System.Drawing.Point(59, 120)
        Me.BtnCandidatesPage.Name = "BtnCandidatesPage"
        Me.BtnCandidatesPage.Size = New System.Drawing.Size(257, 106)
        Me.BtnCandidatesPage.TabIndex = 1
        Me.BtnCandidatesPage.Text = "CandidatesPage"
        Me.BtnCandidatesPage.UseVisualStyleBackColor = True
        '
        'BtnMembersPage2
        '
        Me.BtnMembersPage2.Location = New System.Drawing.Point(59, 248)
        Me.BtnMembersPage2.Name = "BtnMembersPage2"
        Me.BtnMembersPage2.Size = New System.Drawing.Size(251, 85)
        Me.BtnMembersPage2.TabIndex = 2
        Me.BtnMembersPage2.Text = "MembersPage"
        Me.BtnMembersPage2.UseVisualStyleBackColor = True
        '
        'BtnPending
        '
        Me.BtnPending.Location = New System.Drawing.Point(522, 301)
        Me.BtnPending.Name = "BtnPending"
        Me.BtnPending.Size = New System.Drawing.Size(175, 61)
        Me.BtnPending.TabIndex = 3
        Me.BtnPending.Text = "Pending"
        Me.BtnPending.UseVisualStyleBackColor = True
        '
        'AdminPage
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnPending)
        Me.Controls.Add(Me.BtnMembersPage2)
        Me.Controls.Add(Me.BtnCandidatesPage)
        Me.Controls.Add(Me.BtnPositionsPage)
        Me.Name = "AdminPage"
        Me.Text = "AdminPage"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnPositionsPage As Button
    Friend WithEvents BtnCandidatesPage As Button
    Friend WithEvents BtnMembersPage2 As Button
    Friend WithEvents BtnPending As Button
End Class
