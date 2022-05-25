<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.haveAccount = New System.Windows.Forms.LinkLabel()
        Me.txtboxPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxFullname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtboxUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegister
        '
        Me.btnRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.btnRegister.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegister.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegister.Location = New System.Drawing.Point(174, 459)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(261, 59)
        Me.btnRegister.TabIndex = 29
        Me.btnRegister.Text = "Register"
        Me.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'haveAccount
        '
        Me.haveAccount.AutoSize = True
        Me.haveAccount.Font = New System.Drawing.Font("Candara", 10.2!)
        Me.haveAccount.Location = New System.Drawing.Point(402, 424)
        Me.haveAccount.Name = "haveAccount"
        Me.haveAccount.Size = New System.Drawing.Size(120, 21)
        Me.haveAccount.TabIndex = 28
        Me.haveAccount.TabStop = True
        Me.haveAccount.Text = "Have Account ?"
        '
        'txtboxPassword
        '
        Me.txtboxPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtboxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtboxPassword.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtboxPassword.Location = New System.Drawing.Point(274, 363)
        Me.txtboxPassword.Name = "txtboxPassword"
        Me.txtboxPassword.Size = New System.Drawing.Size(248, 36)
        Me.txtboxPassword.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 40)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Password"
        '
        'txtboxFullname
        '
        Me.txtboxFullname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxFullname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtboxFullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtboxFullname.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtboxFullname.Location = New System.Drawing.Point(274, 180)
        Me.txtboxFullname.Name = "txtboxFullname"
        Me.txtboxFullname.Size = New System.Drawing.Size(248, 36)
        Me.txtboxFullname.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 40)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Fullname"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 40)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Register"
        '
        'txtboxEmail
        '
        Me.txtboxEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtboxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtboxEmail.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtboxEmail.Location = New System.Drawing.Point(274, 241)
        Me.txtboxEmail.Name = "txtboxEmail"
        Me.txtboxEmail.Size = New System.Drawing.Size(248, 36)
        Me.txtboxEmail.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 40)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Email"
        '
        'txtboxUsername
        '
        Me.txtboxUsername.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxUsername.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtboxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtboxUsername.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtboxUsername.Location = New System.Drawing.Point(274, 300)
        Me.txtboxUsername.Name = "txtboxUsername"
        Me.txtboxUsername.Size = New System.Drawing.Size(248, 36)
        Me.txtboxUsername.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 40)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.ChatApp.My.Resources.Resources._38435_register
        Me.PictureBox1.Location = New System.Drawing.Point(634, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(695, 630)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1329, 630)
        Me.Controls.Add(Me.txtboxUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtboxEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.haveAccount)
        Me.Controls.Add(Me.txtboxPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtboxFullname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Register"
        Me.Text = "Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents haveAccount As LinkLabel
    Friend WithEvents txtboxPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxFullname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtboxUsername As TextBox
    Friend WithEvents Label5 As Label
End Class
