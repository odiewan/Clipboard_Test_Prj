<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.lblCBContents = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.splMain = New System.Windows.Forms.SplitContainer()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.lblThird = New System.Windows.Forms.Label()
    Me.lblFav3Label = New System.Windows.Forms.Label()
    Me.lblSecond = New System.Windows.Forms.Label()
    Me.cbxMostFreq = New System.Windows.Forms.ComboBox()
    Me.lblFav1Label = New System.Windows.Forms.Label()
    Me.lblFreq = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.lblFirst = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.gbBuffer = New System.Windows.Forms.GroupBox()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.tbpBufferRaw = New System.Windows.Forms.TabPage()
    Me.lbxClipboardBuffer = New System.Windows.Forms.ListBox()
    Me.tbpUnique = New System.Windows.Forms.TabPage()
    Me.lbxUniqueBuffer = New System.Windows.Forms.ListBox()
    Me.tpInspect = New System.Windows.Forms.TabPage()
    Me.tbxInspect = New System.Windows.Forms.TextBox()
    Me.gbConsole = New System.Windows.Forms.GroupBox()
    Me.lbxConsole = New System.Windows.Forms.ListBox()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.cbxTmrEn = New System.Windows.Forms.CheckBox()
    Me.btnGetCB = New System.Windows.Forms.Button()
    Me.btnClearClipboard = New System.Windows.Forms.Button()
    Me.btnClearBuffer = New System.Windows.Forms.Button()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
    Me.ssMain = New System.Windows.Forms.StatusStrip()
    Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tsslCount = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tsslCmd = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tsslCopyCount = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tsslCOCout = New System.Windows.Forms.ToolStripStatusLabel()
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.EventLog1 = New System.Diagnostics.EventLog()
    CType(Me.splMain, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.splMain.Panel1.SuspendLayout()
    Me.splMain.Panel2.SuspendLayout()
    Me.splMain.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.gbBuffer.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.tbpBufferRaw.SuspendLayout()
    Me.tbpUnique.SuspendLayout()
    Me.tpInspect.SuspendLayout()
    Me.gbConsole.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.ssMain.SuspendLayout()
    CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblCBContents
    '
    Me.lblCBContents.AutoEllipsis = True
    Me.lblCBContents.AutoSize = True
    Me.lblCBContents.Location = New System.Drawing.Point(93, 10)
    Me.lblCBContents.Name = "lblCBContents"
    Me.lblCBContents.Size = New System.Drawing.Size(42, 17)
    Me.lblCBContents.TabIndex = 0
    Me.lblCBContents.Text = "None"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 10)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(119, 17)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Current Clipboard"
    '
    'splMain
    '
    Me.splMain.Dock = System.Windows.Forms.DockStyle.Fill
    Me.splMain.Location = New System.Drawing.Point(0, 0)
    Me.splMain.Margin = New System.Windows.Forms.Padding(4)
    Me.splMain.Name = "splMain"
    Me.splMain.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'splMain.Panel1
    '
    Me.splMain.Panel1.Controls.Add(Me.Panel3)
    '
    'splMain.Panel2
    '
    Me.splMain.Panel2.Controls.Add(Me.GroupBox1)
    Me.splMain.Size = New System.Drawing.Size(384, 411)
    Me.splMain.SplitterDistance = 67
    Me.splMain.SplitterWidth = 10
    Me.splMain.TabIndex = 3
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.Label1)
    Me.Panel3.Controls.Add(Me.lblThird)
    Me.Panel3.Controls.Add(Me.lblCBContents)
    Me.Panel3.Controls.Add(Me.lblFav3Label)
    Me.Panel3.Controls.Add(Me.lblSecond)
    Me.Panel3.Controls.Add(Me.cbxMostFreq)
    Me.Panel3.Controls.Add(Me.lblFav1Label)
    Me.Panel3.Controls.Add(Me.lblFreq)
    Me.Panel3.Controls.Add(Me.Label2)
    Me.Panel3.Controls.Add(Me.lblFirst)
    Me.Panel3.Controls.Add(Me.Label3)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel3.Location = New System.Drawing.Point(0, 0)
    Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
    Me.Panel3.MinimumSize = New System.Drawing.Size(384, 411)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(384, 411)
    Me.Panel3.TabIndex = 11
    '
    'lblThird
    '
    Me.lblThird.AutoEllipsis = True
    Me.lblThird.AutoSize = True
    Me.lblThird.Location = New System.Drawing.Point(271, 47)
    Me.lblThird.Name = "lblThird"
    Me.lblThird.Size = New System.Drawing.Size(43, 17)
    Me.lblThird.TabIndex = 10
    Me.lblThird.Text = "Fav 3"
    '
    'lblFav3Label
    '
    Me.lblFav3Label.AutoEllipsis = True
    Me.lblFav3Label.AutoSize = True
    Me.lblFav3Label.Location = New System.Drawing.Point(253, 47)
    Me.lblFav3Label.Name = "lblFav3Label"
    Me.lblFav3Label.Size = New System.Drawing.Size(24, 17)
    Me.lblFav3Label.TabIndex = 7
    Me.lblFav3Label.Text = "#3"
    '
    'lblSecond
    '
    Me.lblSecond.AutoEllipsis = True
    Me.lblSecond.AutoSize = True
    Me.lblSecond.Location = New System.Drawing.Point(163, 47)
    Me.lblSecond.Name = "lblSecond"
    Me.lblSecond.Size = New System.Drawing.Size(43, 17)
    Me.lblSecond.TabIndex = 9
    Me.lblSecond.Text = "Fav 3"
    '
    'cbxMostFreq
    '
    Me.cbxMostFreq.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbxMostFreq.FormattingEnabled = True
    Me.cbxMostFreq.Location = New System.Drawing.Point(95, 24)
    Me.cbxMostFreq.Name = "cbxMostFreq"
    Me.cbxMostFreq.Size = New System.Drawing.Size(287, 24)
    Me.cbxMostFreq.TabIndex = 2
    '
    'lblFav1Label
    '
    Me.lblFav1Label.AutoEllipsis = True
    Me.lblFav1Label.AutoSize = True
    Me.lblFav1Label.Location = New System.Drawing.Point(148, 47)
    Me.lblFav1Label.Name = "lblFav1Label"
    Me.lblFav1Label.Size = New System.Drawing.Size(24, 17)
    Me.lblFav1Label.TabIndex = 8
    Me.lblFav1Label.Text = "#2"
    '
    'lblFreq
    '
    Me.lblFreq.AutoSize = True
    Me.lblFreq.Location = New System.Drawing.Point(3, 27)
    Me.lblFreq.Name = "lblFreq"
    Me.lblFreq.Size = New System.Drawing.Size(99, 17)
    Me.lblFreq.TabIndex = 3
    Me.lblFreq.Text = "Most frequent:"
    '
    'Label2
    '
    Me.Label2.AutoEllipsis = True
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(4, 47)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(66, 17)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Favorites"
    '
    'lblFirst
    '
    Me.lblFirst.AutoEllipsis = True
    Me.lblFirst.AutoSize = True
    Me.lblFirst.Location = New System.Drawing.Point(77, 47)
    Me.lblFirst.Name = "lblFirst"
    Me.lblFirst.Size = New System.Drawing.Size(39, 17)
    Me.lblFirst.TabIndex = 6
    Me.lblFirst.Text = "Fav1"
    '
    'Label3
    '
    Me.Label3.AutoEllipsis = True
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(55, 47)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(24, 17)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "#1"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.Panel2)
    Me.GroupBox1.Controls.Add(Me.Panel1)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
    Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(384, 334)
    Me.GroupBox1.TabIndex = 4
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Clipboard History"
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.SplitContainer1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(3, 47)
    Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(378, 284)
    Me.Panel2.TabIndex = 7
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
    Me.SplitContainer1.Name = "SplitContainer1"
    Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.gbBuffer)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.gbConsole)
    Me.SplitContainer1.Size = New System.Drawing.Size(378, 284)
    Me.SplitContainer1.SplitterDistance = 165
    Me.SplitContainer1.TabIndex = 6
    '
    'gbBuffer
    '
    Me.gbBuffer.Controls.Add(Me.TabControl1)
    Me.gbBuffer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gbBuffer.Location = New System.Drawing.Point(0, 0)
    Me.gbBuffer.Margin = New System.Windows.Forms.Padding(4)
    Me.gbBuffer.Name = "gbBuffer"
    Me.gbBuffer.Size = New System.Drawing.Size(378, 165)
    Me.gbBuffer.TabIndex = 0
    Me.gbBuffer.TabStop = False
    Me.gbBuffer.Text = "Buffer"
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.tbpBufferRaw)
    Me.TabControl1.Controls.Add(Me.tbpUnique)
    Me.TabControl1.Controls.Add(Me.tpInspect)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(3, 18)
    Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(372, 144)
    Me.TabControl1.TabIndex = 7
    '
    'tbpBufferRaw
    '
    Me.tbpBufferRaw.Controls.Add(Me.lbxClipboardBuffer)
    Me.tbpBufferRaw.Location = New System.Drawing.Point(4, 25)
    Me.tbpBufferRaw.Margin = New System.Windows.Forms.Padding(2)
    Me.tbpBufferRaw.Name = "tbpBufferRaw"
    Me.tbpBufferRaw.Padding = New System.Windows.Forms.Padding(2)
    Me.tbpBufferRaw.Size = New System.Drawing.Size(364, 115)
    Me.tbpBufferRaw.TabIndex = 0
    Me.tbpBufferRaw.Text = "Buffer"
    Me.tbpBufferRaw.UseVisualStyleBackColor = True
    '
    'lbxClipboardBuffer
    '
    Me.lbxClipboardBuffer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lbxClipboardBuffer.FormattingEnabled = True
    Me.lbxClipboardBuffer.HorizontalScrollbar = True
    Me.lbxClipboardBuffer.ItemHeight = 16
    Me.lbxClipboardBuffer.Location = New System.Drawing.Point(2, 2)
    Me.lbxClipboardBuffer.Name = "lbxClipboardBuffer"
    Me.lbxClipboardBuffer.ScrollAlwaysVisible = True
    Me.lbxClipboardBuffer.Size = New System.Drawing.Size(360, 111)
    Me.lbxClipboardBuffer.TabIndex = 6
    '
    'tbpUnique
    '
    Me.tbpUnique.Controls.Add(Me.lbxUniqueBuffer)
    Me.tbpUnique.Location = New System.Drawing.Point(4, 25)
    Me.tbpUnique.Margin = New System.Windows.Forms.Padding(2)
    Me.tbpUnique.Name = "tbpUnique"
    Me.tbpUnique.Padding = New System.Windows.Forms.Padding(2)
    Me.tbpUnique.Size = New System.Drawing.Size(364, 115)
    Me.tbpUnique.TabIndex = 1
    Me.tbpUnique.Text = "Ranked Buffer"
    Me.tbpUnique.UseVisualStyleBackColor = True
    '
    'lbxUniqueBuffer
    '
    Me.lbxUniqueBuffer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lbxUniqueBuffer.FormattingEnabled = True
    Me.lbxUniqueBuffer.ItemHeight = 16
    Me.lbxUniqueBuffer.Location = New System.Drawing.Point(2, 2)
    Me.lbxUniqueBuffer.Margin = New System.Windows.Forms.Padding(2)
    Me.lbxUniqueBuffer.Name = "lbxUniqueBuffer"
    Me.lbxUniqueBuffer.Size = New System.Drawing.Size(360, 111)
    Me.lbxUniqueBuffer.TabIndex = 0
    '
    'tpInspect
    '
    Me.tpInspect.Controls.Add(Me.tbxInspect)
    Me.tpInspect.Location = New System.Drawing.Point(4, 25)
    Me.tpInspect.Margin = New System.Windows.Forms.Padding(2)
    Me.tpInspect.Name = "tpInspect"
    Me.tpInspect.Padding = New System.Windows.Forms.Padding(2)
    Me.tpInspect.Size = New System.Drawing.Size(364, 115)
    Me.tpInspect.TabIndex = 2
    Me.tpInspect.Text = "Inspect"
    Me.tpInspect.UseVisualStyleBackColor = True
    '
    'tbxInspect
    '
    Me.tbxInspect.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tbxInspect.Location = New System.Drawing.Point(2, 2)
    Me.tbxInspect.Margin = New System.Windows.Forms.Padding(2)
    Me.tbxInspect.Multiline = True
    Me.tbxInspect.Name = "tbxInspect"
    Me.tbxInspect.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.tbxInspect.Size = New System.Drawing.Size(360, 111)
    Me.tbxInspect.TabIndex = 0
    '
    'gbConsole
    '
    Me.gbConsole.Controls.Add(Me.lbxConsole)
    Me.gbConsole.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gbConsole.Location = New System.Drawing.Point(0, 0)
    Me.gbConsole.Margin = New System.Windows.Forms.Padding(4)
    Me.gbConsole.Name = "gbConsole"
    Me.gbConsole.Size = New System.Drawing.Size(378, 115)
    Me.gbConsole.TabIndex = 0
    Me.gbConsole.TabStop = False
    Me.gbConsole.Text = "Console"
    '
    'lbxConsole
    '
    Me.lbxConsole.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lbxConsole.FormattingEnabled = True
    Me.lbxConsole.ItemHeight = 16
    Me.lbxConsole.Location = New System.Drawing.Point(3, 18)
    Me.lbxConsole.Margin = New System.Windows.Forms.Padding(4)
    Me.lbxConsole.Name = "lbxConsole"
    Me.lbxConsole.Size = New System.Drawing.Size(372, 94)
    Me.lbxConsole.TabIndex = 0
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.cbxTmrEn)
    Me.Panel1.Controls.Add(Me.btnGetCB)
    Me.Panel1.Controls.Add(Me.btnClearClipboard)
    Me.Panel1.Controls.Add(Me.btnClearBuffer)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(3, 18)
    Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(378, 29)
    Me.Panel1.TabIndex = 6
    '
    'cbxTmrEn
    '
    Me.cbxTmrEn.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.cbxTmrEn.AutoSize = True
    Me.cbxTmrEn.Location = New System.Drawing.Point(324, 9)
    Me.cbxTmrEn.Margin = New System.Windows.Forms.Padding(4)
    Me.cbxTmrEn.Name = "cbxTmrEn"
    Me.cbxTmrEn.Size = New System.Drawing.Size(80, 21)
    Me.cbxTmrEn.TabIndex = 9
    Me.cbxTmrEn.Text = "Capture"
    Me.cbxTmrEn.UseVisualStyleBackColor = True
    '
    'btnGetCB
    '
    Me.btnGetCB.Dock = System.Windows.Forms.DockStyle.Left
    Me.btnGetCB.Location = New System.Drawing.Point(216, 0)
    Me.btnGetCB.Margin = New System.Windows.Forms.Padding(4)
    Me.btnGetCB.Name = "btnGetCB"
    Me.btnGetCB.Size = New System.Drawing.Size(100, 29)
    Me.btnGetCB.TabIndex = 8
    Me.btnGetCB.Text = "Get CB"
    Me.btnGetCB.UseVisualStyleBackColor = True
    '
    'btnClearClipboard
    '
    Me.btnClearClipboard.Dock = System.Windows.Forms.DockStyle.Left
    Me.btnClearClipboard.Location = New System.Drawing.Point(100, 0)
    Me.btnClearClipboard.Margin = New System.Windows.Forms.Padding(4)
    Me.btnClearClipboard.Name = "btnClearClipboard"
    Me.btnClearClipboard.Size = New System.Drawing.Size(116, 29)
    Me.btnClearClipboard.TabIndex = 7
    Me.btnClearClipboard.Text = "Clear Clipboard"
    Me.btnClearClipboard.UseVisualStyleBackColor = True
    '
    'btnClearBuffer
    '
    Me.btnClearBuffer.Dock = System.Windows.Forms.DockStyle.Left
    Me.btnClearBuffer.Location = New System.Drawing.Point(0, 0)
    Me.btnClearBuffer.Margin = New System.Windows.Forms.Padding(4)
    Me.btnClearBuffer.Name = "btnClearBuffer"
    Me.btnClearBuffer.Size = New System.Drawing.Size(100, 29)
    Me.btnClearBuffer.TabIndex = 6
    Me.btnClearBuffer.Text = "Clear Buffer"
    Me.btnClearBuffer.UseVisualStyleBackColor = True
    '
    'Timer1
    '
    Me.Timer1.Interval = 10
    '
    'NotifyIcon1
    '
    Me.NotifyIcon1.Text = "NotifyIcon1"
    Me.NotifyIcon1.Visible = True
    '
    'ssMain
    '
    Me.ssMain.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus, Me.tsslCount, Me.tsslCmd, Me.tsslCopyCount, Me.tsslCOCout})
    Me.ssMain.Location = New System.Drawing.Point(0, 385)
    Me.ssMain.Name = "ssMain"
    Me.ssMain.Size = New System.Drawing.Size(384, 26)
    Me.ssMain.TabIndex = 4
    Me.ssMain.Text = "StatusStrip1"
    '
    'tsslStatus
    '
    Me.tsslStatus.Name = "tsslStatus"
    Me.tsslStatus.Size = New System.Drawing.Size(50, 20)
    Me.tsslStatus.Text = "Ready"
    '
    'tsslCount
    '
    Me.tsslCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
    Me.tsslCount.Name = "tsslCount"
    Me.tsslCount.Size = New System.Drawing.Size(27, 20)
    Me.tsslCount.Text = "##"
    '
    'tsslCmd
    '
    Me.tsslCmd.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
    Me.tsslCmd.Name = "tsslCmd"
    Me.tsslCmd.Size = New System.Drawing.Size(40, 20)
    Me.tsslCmd.Text = "Cmd"
    '
    'tsslCopyCount
    '
    Me.tsslCopyCount.Name = "tsslCopyCount"
    Me.tsslCopyCount.Size = New System.Drawing.Size(86, 20)
    Me.tsslCopyCount.Text = "Copy Count"
    '
    'tsslCOCout
    '
    Me.tsslCOCout.Name = "tsslCOCout"
    Me.tsslCOCout.Size = New System.Drawing.Size(75, 20)
    Me.tsslCOCout.Text = "CO Count:"
    '
    'EventLog1
    '
    Me.EventLog1.SynchronizingObject = Me
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(384, 411)
    Me.Controls.Add(Me.ssMain)
    Me.Controls.Add(Me.splMain)
    Me.MinimumSize = New System.Drawing.Size(400, 450)
    Me.Name = "Form1"
    Me.Text = "Clipboard++"
    Me.splMain.Panel1.ResumeLayout(False)
    Me.splMain.Panel2.ResumeLayout(False)
    CType(Me.splMain, System.ComponentModel.ISupportInitialize).EndInit()
    Me.splMain.ResumeLayout(False)
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    Me.gbBuffer.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.tbpBufferRaw.ResumeLayout(False)
    Me.tbpUnique.ResumeLayout(False)
    Me.tpInspect.ResumeLayout(False)
    Me.tpInspect.PerformLayout()
    Me.gbConsole.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ssMain.ResumeLayout(False)
    Me.ssMain.PerformLayout()
    CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents btnGetCB As Button
  Friend WithEvents cbxTmrEn As CheckBox
  Friend WithEvents SplitContainer1 As SplitContainer
  Friend WithEvents gbBuffer As GroupBox
  Friend WithEvents lbxClipboardBuffer As ListBox
  Friend WithEvents gbConsole As GroupBox
  Friend WithEvents EventLog1 As EventLog
  Friend WithEvents lbxConsole As ListBox
  Friend WithEvents cbxMostFreq As ComboBox
  Friend WithEvents lblFreq As Label
  Friend WithEvents lblFirst As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents lblFav3Label As Label
  Friend WithEvents lblThird As Label
  Friend WithEvents lblSecond As Label
  Friend WithEvents lblFav1Label As Label
    Friend WithEvents tsslCopyCount As ToolStripStatusLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbpBufferRaw As TabPage
    Friend WithEvents tbpUnique As TabPage
    Friend WithEvents lbxUniqueBuffer As ListBox
    Friend WithEvents tsslCOCout As ToolStripStatusLabel
    Friend WithEvents tpInspect As TabPage
    Friend WithEvents tbxInspect As TextBox
    Friend WithEvents Panel3 As Panel

End Class
