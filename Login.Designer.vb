<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtxboxEmail = New System.Windows.Forms.TextBox()
        Me.txtboxPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnForgotpassword = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.linktoform = New System.Windows.Forms.LinkLabel()
        Me.ShowPassword = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(973, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Login "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(787, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 40)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Email"
        '
        'TxtxboxEmail
        '
        Me.TxtxboxEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtxboxEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtxboxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtxboxEmail.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtxboxEmail.Location = New System.Drawing.Point(980, 177)
        Me.TxtxboxEmail.Name = "TxtxboxEmail"
        Me.TxtxboxEmail.Size = New System.Drawing.Size(248, 36)
        Me.TxtxboxEmail.TabIndex = 7
        '
        'txtboxPassword
        '
        Me.txtboxPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtboxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtboxPassword.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtboxPassword.Location = New System.Drawing.Point(980, 247)
        Me.txtboxPassword.Name = "txtboxPassword"
        Me.txtboxPassword.Size = New System.Drawing.Size(248, 36)
        Me.txtboxPassword.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara Light", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(787, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 40)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password"
        '
        'btnForgotpassword
        '
        Me.btnForgotpassword.AutoSize = True
        Me.btnForgotpassword.Font = New System.Drawing.Font("Candara", 10.2!)
        Me.btnForgotpassword.Location = New System.Drawing.Point(1133, 343)
        Me.btnForgotpassword.Name = "btnForgotpassword"
        Me.btnForgotpassword.Size = New System.Drawing.Size(132, 21)
        Me.btnForgotpassword.TabIndex = 11
        Me.btnForgotpassword.TabStop = True
        Me.btnForgotpassword.Text = "Forgot Password"
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(904, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(261, 59)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Login"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.btnRegister.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegister.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegister.Location = New System.Drawing.Point(946, 488)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(187, 50)
        Me.btnRegister.TabIndex = 13
        Me.btnRegister.Text = "Register"
        Me.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'linktoform
        '
        Me.linktoform.AutoSize = True
        Me.linktoform.Font = New System.Drawing.Font("Candara", 10.2!)
        Me.linktoform.Location = New System.Drawing.Point(1133, 377)
        Me.linktoform.Name = "linktoform"
        Me.linktoform.Size = New System.Drawing.Size(72, 21)
        Me.linktoform.TabIndex = 14
        Me.linktoform.TabStop = True
        Me.linktoform.Text = "Kembali "
        '
        'ShowPassword
        '
        Me.ShowPassword.AutoSize = True
        Me.ShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ShowPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ShowPassword.Location = New System.Drawing.Point(980, 298)
        Me.ShowPassword.Name = "ShowPassword"
        Me.ShowPassword.Size = New System.Drawing.Size(151, 24)
        Me.ShowPassword.TabIndex = 15
        Me.ShowPassword.Text = "Show Password"
        Me.ShowPassword.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.ChatApp.My.Resources.Resources._27649_lets_chat
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(695, 630)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1329, 630)
        Me.Controls.Add(Me.ShowPassword)
        Me.Controls.Add(Me.linktoform)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnForgotpassword)
        Me.Controls.Add(Me.txtboxPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtxboxEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtxboxEmail As TextBox
    Friend WithEvents txtboxPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnForgotpassword As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents linktoform As LinkLabel
    Friend WithEvents ShowPassword As CheckBox
End Class
