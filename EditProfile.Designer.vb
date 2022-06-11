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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtxboxFullname = New System.Windows.Forms.TextBox()
        Me.TxtxboxEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtxboxUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtxboxPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ShowPassword = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtboxId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(31, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 39)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Edit Your Profiles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(33, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(426, 26)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "edit your profile to be known by other users"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.ChatApp.My.Resources.Resources._442008112_GLANCING_AVATAR_3D_400px
        Me.PictureBox1.Location = New System.Drawing.Point(69, 162)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(417, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 26)
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
        Me.TxtxboxFullname.Location = New System.Drawing.Point(422, 253)
        Me.TxtxboxFullname.Name = "TxtxboxFullname"
        Me.TxtxboxFullname.Size = New System.Drawing.Size(328, 36)
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
        Me.TxtxboxEmail.Location = New System.Drawing.Point(853, 253)
        Me.TxtxboxEmail.Name = "TxtxboxEmail"
        Me.TxtxboxEmail.Size = New System.Drawing.Size(328, 36)
        Me.TxtxboxEmail.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(848, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 26)
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
        Me.TxtxboxUsername.Location = New System.Drawing.Point(422, 349)
        Me.TxtxboxUsername.Name = "TxtxboxUsername"
        Me.TxtxboxUsername.Size = New System.Drawing.Size(328, 36)
        Me.TxtxboxUsername.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(417, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 26)
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
        Me.TxtxboxPassword.Location = New System.Drawing.Point(853, 349)
        Me.TxtxboxPassword.Name = "TxtxboxPassword"
        Me.TxtxboxPassword.Size = New System.Drawing.Size(328, 36)
        Me.TxtxboxPassword.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Location = New System.Drawing.Point(848, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 26)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Password"
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
        Me.Button1.Location = New System.Drawing.Point(422, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 45)
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
        Me.Button2.Location = New System.Drawing.Point(587, 448)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 45)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Save"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ShowPassword
        '
        Me.ShowPassword.AutoSize = True
        Me.ShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ShowPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ShowPassword.Location = New System.Drawing.Point(853, 391)
        Me.ShowPassword.Name = "ShowPassword"
        Me.ShowPassword.Size = New System.Drawing.Size(151, 24)
        Me.ShowPassword.TabIndex = 40
        Me.ShowPassword.Text = "Show Password"
        Me.ShowPassword.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtboxId
        '
        Me.txtboxId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxId.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtboxId.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtboxId.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtboxId.Location = New System.Drawing.Point(422, 153)
        Me.txtboxId.Name = "txtboxId"
        Me.txtboxId.ReadOnly = True
        Me.txtboxId.Size = New System.Drawing.Size(328, 36)
        Me.txtboxId.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(422, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 26)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Id users"
        '
        'EditProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1329, 630)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtboxId)
        Me.Controls.Add(Me.ShowPassword)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtxboxPassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtxboxUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtxboxEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtxboxFullname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditProfile"
        Me.Text = "Edit Profile"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtxboxFullname As TextBox
    Friend WithEvents TxtxboxEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtxboxUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtxboxPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ShowPassword As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtboxId As TextBox
    Friend WithEvents Label7 As Label
End Class
