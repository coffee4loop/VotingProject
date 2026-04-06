<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MembersPage
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
        Me.BtnNomPage = New System.Windows.Forms.Button()
        Me.BtnVotePage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnNomPage
        '
        Me.BtnNomPage.Location = New System.Drawing.Point(268, 73)
        Me.BtnNomPage.Name = "BtnNomPage"
        Me.BtnNomPage.Size = New System.Drawing.Size(260, 77)
        Me.BtnNomPage.TabIndex = 0
        Me.BtnNomPage.Text = "Nomination Page"
        Me.BtnNomPage.UseVisualStyleBackColor = True
        '
        'BtnVotePage
        '
        Me.BtnVotePage.Location = New System.Drawing.Point(258, 224)
        Me.BtnVotePage.Name = "BtnVotePage"
        Me.BtnVotePage.Size = New System.Drawing.Size(282, 108)
        Me.BtnVotePage.TabIndex = 1
        Me.BtnVotePage.Text = "Voting Page"
        Me.BtnVotePage.UseVisualStyleBackColor = True
        '
        'MembersPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnVotePage)
        Me.Controls.Add(Me.BtnNomPage)
        Me.Name = "MembersPage"
        Me.Text = "MembersPage"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnNomPage As Button
    Friend WithEvents BtnVotePage As Button
End Class
