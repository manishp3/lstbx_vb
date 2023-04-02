<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListBox
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
        Me.lstalpha = New System.Windows.Forms.ListBox
        Me.l = New System.Windows.Forms.Label
        Me.lblmsg = New System.Windows.Forms.Label
        Me.lstname = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lstalpha
        '
        Me.lstalpha.FormattingEnabled = True
        Me.lstalpha.Items.AddRange(New Object() {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"})
        Me.lstalpha.Location = New System.Drawing.Point(16, 22)
        Me.lstalpha.Name = "lstalpha"
        Me.lstalpha.Size = New System.Drawing.Size(60, 212)
        Me.lstalpha.TabIndex = 0
        '
        'l
        '
        Me.l.AutoSize = True
        Me.l.Location = New System.Drawing.Point(28, 267)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(0, 13)
        Me.l.TabIndex = 2
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Location = New System.Drawing.Point(63, 251)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(39, 13)
        Me.lblmsg.TabIndex = 3
        Me.lblmsg.Text = "Label1"
        '
        'lstname
        '
        Me.lstname.FormattingEnabled = True
        Me.lstname.Items.AddRange(New Object() {"ashish", "Manish", "parth", "akash", "milan", "kesari", "anil", "mihir", "meet", "priyansh"})
        Me.lstname.Location = New System.Drawing.Point(119, 25)
        Me.lstname.Name = "lstname"
        Me.lstname.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstname.Size = New System.Drawing.Size(129, 199)
        Me.lstname.TabIndex = 4
        '
        'ListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 286)
        Me.Controls.Add(Me.lstname)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.l)
        Me.Controls.Add(Me.lstalpha)
        Me.Name = "ListBox"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstalpha As System.Windows.Forms.ListBox
    Friend WithEvents l As System.Windows.Forms.Label
    Friend WithEvents lblmsg As System.Windows.Forms.Label
    Friend WithEvents lstname As System.Windows.Forms.ListBox

End Class
