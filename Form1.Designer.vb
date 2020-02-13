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
    Me.components = New System.ComponentModel.Container()
    Me.lblCBContents = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.splMain = New System.Windows.Forms.SplitContainer()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.btnClearClipboard = New System.Windows.Forms.Button()
    Me.btnClearBuffer = New System.Windows.Forms.Button()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
    Me.ssMain = New System.Windows.Forms.StatusStrip()
    Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tsslCount = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tsslCmd = New System.Windows.Forms.ToolStripStatusLabel()
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.lbxClipboardBuffer = New System.Windows.Forms.ListBox()
    CType(Me.splMain, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.splMain.Panel1.SuspendLayout()
    Me.splMain.Panel2.SuspendLayout()
    Me.splMain.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.ssMain.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'lblCBContents
    '
    Me.lblCBContents.AutoSize = True
    Me.lblCBContents.Location = New System.Drawing.Point(106, 8)
    Me.lblCBContents.Name = "lblCBContents"
    Me.lblCBContents.Size = New System.Drawing.Size(33, 13)
    Me.lblCBContents.TabIndex = 0
    Me.lblCBContents.Text = "None"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 8)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(88, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Current Clipboard"
    '
    'splMain
    '
    Me.splMain.Dock = System.Windows.Forms.DockStyle.Fill
    Me.splMain.Location = New System.Drawing.Point(0, 0)
    Me.splMain.Name = "splMain"
    Me.splMain.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'splMain.Panel1
    '
    Me.splMain.Panel1.Controls.Add(Me.lblCBContents)
    Me.splMain.Panel1.Controls.Add(Me.Label1)
    '
    'splMain.Panel2
    '
    Me.splMain.Panel2.Controls.Add(Me.GroupBox1)
    Me.splMain.Size = New System.Drawing.Size(386, 354)
    Me.splMain.SplitterDistance = 31
    Me.splMain.SplitterWidth = 10
    Me.splMain.TabIndex = 3
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.Panel2)
    Me.GroupBox1.Controls.Add(Me.Panel1)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(386, 313)
    Me.GroupBox1.TabIndex = 4
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Clipboard History"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.btnClearClipboard)
    Me.Panel1.Controls.Add(Me.btnClearBuffer)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(3, 16)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(380, 29)
    Me.Panel1.TabIndex = 6
    '
    'btnClearClipboard
    '
    Me.btnClearClipboard.Dock = System.Windows.Forms.DockStyle.Left
    Me.btnClearClipboard.Location = New System.Drawing.Point(75, 0)
    Me.btnClearClipboard.Name = "btnClearClipboard"
    Me.btnClearClipboard.Size = New System.Drawing.Size(87, 29)
    Me.btnClearClipboard.TabIndex = 7
    Me.btnClearClipboard.Text = "Clear Clipboard"
    Me.btnClearClipboard.UseVisualStyleBackColor = True
    '
    'btnClearBuffer
    '
    Me.btnClearBuffer.Dock = System.Windows.Forms.DockStyle.Left
    Me.btnClearBuffer.Location = New System.Drawing.Point(0, 0)
    Me.btnClearBuffer.Name = "btnClearBuffer"
    Me.btnClearBuffer.Size = New System.Drawing.Size(75, 29)
    Me.btnClearBuffer.TabIndex = 6
    Me.btnClearBuffer.Text = "Clear Buffer"
    Me.btnClearBuffer.UseVisualStyleBackColor = True
    '
    'Timer1
    '
    Me.Timer1.Enabled = True
    Me.Timer1.Interval = 10
    '
    'NotifyIcon1
    '
    Me.NotifyIcon1.Text = "NotifyIcon1"
    Me.NotifyIcon1.Visible = True
    '
    'ssMain
    '
    Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus, Me.tsslCount, Me.tsslCmd})
    Me.ssMain.Location = New System.Drawing.Point(0, 332)
    Me.ssMain.Name = "ssMain"
    Me.ssMain.Size = New System.Drawing.Size(386, 22)
    Me.ssMain.TabIndex = 4
    Me.ssMain.Text = "StatusStrip1"
    '
    'tsslStatus
    '
    Me.tsslStatus.Name = "tsslStatus"
    Me.tsslStatus.Size = New System.Drawing.Size(39, 17)
    Me.tsslStatus.Text = "Ready"
    '
    'tsslCount
    '
    Me.tsslCount.Name = "tsslCount"
    Me.tsslCount.Size = New System.Drawing.Size(21, 17)
    Me.tsslCount.Text = "##"
    '
    'tsslCmd
    '
    Me.tsslCmd.Name = "tsslCmd"
    Me.tsslCmd.Size = New System.Drawing.Size(33, 17)
    Me.tsslCmd.Text = "Cmd"
    '
    'ToolTip1
    '
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.lbxClipboardBuffer)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(3, 45)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(380, 265)
    Me.Panel2.TabIndex = 7
    '
    'lbxClipboardBuffer
    '
    Me.lbxClipboardBuffer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lbxClipboardBuffer.FormattingEnabled = True
    Me.lbxClipboardBuffer.HorizontalScrollbar = True
    Me.lbxClipboardBuffer.Items.AddRange(New Object() {"Test"})
    Me.lbxClipboardBuffer.Location = New System.Drawing.Point(0, 0)
    Me.lbxClipboardBuffer.Name = "lbxClipboardBuffer"
    Me.lbxClipboardBuffer.ScrollAlwaysVisible = True
    Me.lbxClipboardBuffer.Size = New System.Drawing.Size(380, 265)
    Me.lbxClipboardBuffer.TabIndex = 5
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(386, 354)
    Me.Controls.Add(Me.ssMain)
    Me.Controls.Add(Me.splMain)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.splMain.Panel1.ResumeLayout(False)
    Me.splMain.Panel1.PerformLayout()
    Me.splMain.Panel2.ResumeLayout(False)
    CType(Me.splMain, System.ComponentModel.ISupportInitialize).EndInit()
    Me.splMain.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.ssMain.ResumeLayout(False)
    Me.ssMain.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents lblCBContents As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents splMain As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClearBuffer As Button
  Friend WithEvents Timer1 As Timer
  Friend WithEvents NotifyIcon1 As NotifyIcon
  Friend WithEvents ssMain As StatusStrip
  Friend WithEvents tsslStatus As ToolStripStatusLabel
  Friend WithEvents tsslCount As ToolStripStatusLabel
  Friend WithEvents tsslCmd As ToolStripStatusLabel
  Friend WithEvents btnClearClipboard As Button
  Friend WithEvents ToolTip1 As ToolTip
  Friend WithEvents Panel2 As Panel
  Friend WithEvents lbxClipboardBuffer As ListBox
End Class
