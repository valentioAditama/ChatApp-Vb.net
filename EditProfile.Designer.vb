<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditProfile))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtxboxFullname = New System.Windows.Forms.TextBox()
        Me.TxtxboxEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtxboxUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtxboxPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtBoxBio = New System.Windows.Forms.RichTextBox()
        Me.ShowPassword = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(35, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 46)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Edit Your Profiles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(37, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(501, 30)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "edit your profile to be known by other users"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.ChatApp.My.Resources.Resources._442008112_GLANCING_AVATAR_3D_400px
        Me.PictureBox1.Location = New System.Drawing.Point(86, 180)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.Button5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(73, 362)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(222, 56)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Change Your Images "
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(482, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 30)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Fullname "
        '
        'TxtxboxFullname
        '
        Me.TxtxboxFullname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtxboxFullname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtxboxFullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtxboxFullname.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtxboxFullname.Location = New System.Drawing.Point(487, 216)
        Me.TxtxboxFullname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtxboxFullname.Name = "TxtxboxFullname"
        Me.TxtxboxFullname.Size = New System.Drawing.Size(368, 41)
        Me.TxtxboxFullname.TabIndex = 28
        '
        'TxtxboxEmail
        '
        Me.TxtxboxEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtxboxEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtxboxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtxboxEmail.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtxboxEmail.Location = New System.Drawing.Point(972, 216)
        Me.TxtxboxEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtxboxEmail.Name = "TxtxboxEmail"
        Me.TxtxboxEmail.Size = New System.Drawing.Size(368, 41)
        Me.TxtxboxEmail.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(966, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 30)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Email "
        '
        'TxtxboxUsername
        '
        Me.TxtxboxUsername.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtxboxUsername.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtxboxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtxboxUsername.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtxboxUsername.Location = New System.Drawing.Point(487, 336)
        Me.TxtxboxUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtxboxUsername.Name = "TxtxboxUsername"
        Me.TxtxboxUsername.Size = New System.Drawing.Size(368, 41)
        Me.TxtxboxUsername.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(482, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 30)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Username"
        '
        'TxtxboxPassword
        '
        Me.TxtxboxPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtxboxPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtxboxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtxboxPassword.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtxboxPassword.Location = New System.Drawing.Point(972, 336)
        Me.TxtxboxPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtxboxPassword.Name = "TxtxboxPassword"
        Me.TxtxboxPassword.Size = New System.Drawing.Size(368, 41)
        Me.TxtxboxPassword.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Location = New System.Drawing.Point(966, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 30)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(482, 421)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 30)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Bio"
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(487, 655)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 56)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Cancel"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.Button2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(673, 655)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(183, 56)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Save"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtBoxBio)
        Me.GroupBox1.Location = New System.Drawing.Point(487, 458)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(854, 175)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'TxtBoxBio
        '
        Me.TxtBoxBio.Location = New System.Drawing.Point(0, 15)
        Me.TxtBoxBio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtBoxBio.Name = "TxtBoxBio"
        Me.TxtBoxBio.Size = New System.Drawing.Size(853, 155)
        Me.TxtBoxBio.TabIndex = 0
        Me.TxtBoxBio.Text = ""
        '
        'ShowPassword
        '
        Me.ShowPassword.AutoSize = True
        Me.ShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ShowPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ShowPassword.Location = New System.Drawing.Point(972, 389)
        Me.ShowPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ShowPassword.Name = "ShowPassword"
        Me.ShowPassword.Size = New System.Drawing.Size(179, 29)
        Me.ShowPassword.TabIndex = 40
        Me.ShowPassword.Text = "Show Password"
        Me.ShowPassword.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'EditProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1495, 788)
        Me.Controls.Add(Me.ShowPassword)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtxboxPassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtxboxUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtxboxEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtxboxFullname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EditProfile"
        Me.Text = "Edit Profile"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtxboxFullname As TextBox
    Friend WithEvents TxtxboxEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtxboxUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtxboxPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtBoxBio As RichTextBox
    Friend WithEvents ShowPassword As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
