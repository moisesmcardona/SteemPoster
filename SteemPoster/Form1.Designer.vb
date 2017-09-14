<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AccountName = New System.Windows.Forms.TextBox()
        Me.PK = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.TextBox()
        Me.Tags = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Permalink = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Body = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Remember = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Name:"
        '
        'AccountName
        '
        Me.AccountName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccountName.Location = New System.Drawing.Point(15, 24)
        Me.AccountName.Name = "AccountName"
        Me.AccountName.Size = New System.Drawing.Size(428, 20)
        Me.AccountName.TabIndex = 1
        '
        'PK
        '
        Me.PK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PK.Location = New System.Drawing.Point(453, 24)
        Me.PK.Name = "PK"
        Me.PK.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PK.Size = New System.Drawing.Size(462, 20)
        Me.PK.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(450, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Private Posting Key:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Title:"
        '
        'Title
        '
        Me.Title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Title.Location = New System.Drawing.Point(15, 64)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(900, 20)
        Me.Title.TabIndex = 3
        '
        'Tags
        '
        Me.Tags.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tags.Location = New System.Drawing.Point(15, 555)
        Me.Tags.Name = "Tags"
        Me.Tags.Size = New System.Drawing.Size(428, 20)
        Me.Tags.TabIndex = 5
        Me.Tags.Text = "tag1,tag2,tag3,tag4,tag5"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 539)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tags:"
        '
        'Permalink
        '
        Me.Permalink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Permalink.Location = New System.Drawing.Point(453, 555)
        Me.Permalink.Name = "Permalink"
        Me.Permalink.Size = New System.Drawing.Size(462, 20)
        Me.Permalink.TabIndex = 6
        Me.Permalink.Text = "link-to-the-post"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(450, 539)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Link:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Body:"
        '
        'Body
        '
        Me.Body.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Body.Location = New System.Drawing.Point(15, 103)
        Me.Body.Name = "Body"
        Me.Body.Size = New System.Drawing.Size(900, 432)
        Me.Body.TabIndex = 4
        Me.Body.Text = ""
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(15, 582)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(904, 31)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Preview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(15, 616)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(281, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "v1.2 - Developed by Moises Cardona (@moisesmcardona)"
        '
        'Remember
        '
        Me.Remember.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Remember.AutoSize = True
        Me.Remember.Location = New System.Drawing.Point(453, 616)
        Me.Remember.Name = "Remember"
        Me.Remember.Size = New System.Drawing.Size(200, 17)
        Me.Remember.TabIndex = 8
        Me.Remember.Text = "Remember Account and Posting Key"
        Me.Remember.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 633)
        Me.Controls.Add(Me.Remember)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Body)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Permalink)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Tags)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AccountName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "STEEM Poster"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AccountName As TextBox
    Friend WithEvents PK As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Title As TextBox
    Friend WithEvents Tags As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Permalink As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Body As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Remember As CheckBox
End Class
