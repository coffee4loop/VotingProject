<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.BtnMembers = New System.Windows.Forms.Button()
        Me.BtnAdminPage = New System.Windows.Forms.Button()
        Me.BtnCreateAcc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnMembers
        '
        Me.BtnMembers.Location = New System.Drawing.Point(256, 226)
        Me.BtnMembers.Name = "BtnMembers"
        Me.BtnMembers.Size = New System.Drawing.Size(273, 107)
        Me.BtnMembers.TabIndex = 0
        Me.BtnMembers.Text = "Members"
        Me.BtnMembers.UseVisualStyleBackColor = True
        '
        'BtnAdminPage
        '
        Me.BtnAdminPage.Location = New System.Drawing.Point(256, 74)
        Me.BtnAdminPage.Name = "BtnAdminPage"
        Me.BtnAdminPage.Size = New System.Drawing.Size(258, 100)
        Me.BtnAdminPage.TabIndex = 1
        Me.BtnAdminPage.Text = "Admin"
        Me.BtnAdminPage.UseVisualStyleBackColor = True
        '
        'BtnCreateAcc
        '
        Me.BtnCreateAcc.Location = New System.Drawing.Point(626, 376)
        Me.BtnCreateAcc.Name = "BtnCreateAcc"
        Me.BtnCreateAcc.Size = New System.Drawing.Size(147, 37)
        Me.BtnCreateAcc.TabIndex = 2
        Me.BtnCreateAcc.Text = "CreateAcc"
        Me.BtnCreateAcc.UseVisualStyleBackColor = True
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCreateAcc)
        Me.Controls.Add(Me.BtnAdminPage)
        Me.Controls.Add(Me.BtnMembers)
        Me.Name = "MainPage"
        Me.Text = " "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnMembers As Button
    Friend WithEvents BtnAdminPage As Button
    Friend WithEvents BtnCreateAcc As Button
End Class
