<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeedBack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FeedBack))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TxtBoxIssue = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.RdbuttonOther = New System.Windows.Forms.RadioButton()
        Me.RdbuttonComment = New System.Windows.Forms.RadioButton()
        Me.RdbuttonBugs = New System.Windows.Forms.RadioButton()
        Me.TxtboxFullname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LinkLabel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtBoxIssue)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnSubmit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RdbuttonOther)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RdbuttonComment)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RdbuttonBugs)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtboxFullname)
        Me.SplitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.SplitContainer1.Size = New System.Drawing.Size(1495, 788)
        Me.SplitContainer1.SplitterDistance = 498
        Me.SplitContainer1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ChatApp.My.Resources.Resources._41111_man_filling_a_survey_with_a_woman_watching_at_5_star_feedback_dialog
        Me.PictureBox1.Location = New System.Drawing.Point(-249, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(989, 784)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(58, 370)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 45)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Share Your FeedBack"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LinkLabel1.Location = New System.Drawing.Point(782, 528)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(102, 29)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Kembali"
        '
        'TxtBoxIssue
        '
        Me.TxtBoxIssue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxIssue.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtBoxIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtBoxIssue.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtBoxIssue.Location = New System.Drawing.Point(174, 429)
        Me.TxtBoxIssue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtBoxIssue.Name = "TxtBoxIssue"
        Me.TxtBoxIssue.Size = New System.Drawing.Size(701, 41)
        Me.TxtBoxIssue.TabIndex = 27
        '
        'BtnSubmit
        '
        Me.BtnSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.BtnSubmit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSubmit.Font = New System.Drawing.Font("Bahnschrift", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSubmit.Location = New System.Drawing.Point(176, 568)
        Me.BtnSubmit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(701, 74)
        Me.BtnSubmit.TabIndex = 25
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'RdbuttonOther
        '
        Me.RdbuttonOther.AutoSize = True
        Me.RdbuttonOther.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RdbuttonOther.Location = New System.Drawing.Point(430, 488)
        Me.RdbuttonOther.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdbuttonOther.Name = "RdbuttonOther"
        Me.RdbuttonOther.Size = New System.Drawing.Size(74, 24)
        Me.RdbuttonOther.TabIndex = 24
        Me.RdbuttonOther.TabStop = True
        Me.RdbuttonOther.Text = "Other"
        Me.RdbuttonOther.UseVisualStyleBackColor = True
        '
        'RdbuttonComment
        '
        Me.RdbuttonComment.AutoSize = True
        Me.RdbuttonComment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RdbuttonComment.Location = New System.Drawing.Point(287, 488)
        Me.RdbuttonComment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdbuttonComment.Name = "RdbuttonComment"
        Me.RdbuttonComment.Size = New System.Drawing.Size(100, 24)
        Me.RdbuttonComment.TabIndex = 23
        Me.RdbuttonComment.TabStop = True
        Me.RdbuttonComment.Text = "comment"
        Me.RdbuttonComment.UseVisualStyleBackColor = True
        '
        'RdbuttonBugs
        '
        Me.RdbuttonBugs.AutoSize = True
        Me.RdbuttonBugs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RdbuttonBugs.Location = New System.Drawing.Point(176, 488)
        Me.RdbuttonBugs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdbuttonBugs.Name = "RdbuttonBugs"
        Me.RdbuttonBugs.Size = New System.Drawing.Size(71, 24)
        Me.RdbuttonBugs.TabIndex = 22
        Me.RdbuttonBugs.TabStop = True
        Me.RdbuttonBugs.Text = "Bugs"
        Me.RdbuttonBugs.UseVisualStyleBackColor = True
        '
        'TxtboxFullname
        '
        Me.TxtboxFullname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtboxFullname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtboxFullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtboxFullname.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtboxFullname.Location = New System.Drawing.Point(174, 312)
        Me.TxtboxFullname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtboxFullname.Name = "TxtboxFullname"
        Me.TxtboxFullname.Size = New System.Drawing.Size(701, 41)
        Me.TxtboxFullname.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(324, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(403, 45)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Share Your FeedBack"
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(171, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 30)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Fullname "
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(171, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(337, 30)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Describe your issue or ideas"
        '
        'FeedBack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1495, 788)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FeedBack"
        Me.Text = "FeedBack"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RdbuttonOther As RadioButton
    Friend WithEvents RdbuttonComment As RadioButton
    Friend WithEvents RdbuttonBugs As RadioButton
    Friend WithEvents TxtboxFullname As TextBox
    Friend WithEvents TxtBoxIssue As TextBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
End Class
