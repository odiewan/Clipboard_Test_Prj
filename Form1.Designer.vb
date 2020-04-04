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
    Me.lblThird = New System.Windows.Forms.Label()
    Me.lblSecond = New System.Windows.Forms.Label()
    Me.lblFav1Label = New System.Windows.Forms.Label()
    Me.lblFav3Label = New System.Windows.Forms.Label()
    Me.lblFirst = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.lblFreq = New System.Windows.Forms.Label()
    Me.cbxMostFreq = New System.Windows.Forms.ComboBox()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.gbBuffer = New System.Windows.Forms.GroupBox()
    Me.lbxClipboardBuffer = New System.Windows.Forms.ListBox()
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpBufferRaw = New System.Windows.Forms.TabPage()
        Me.tbpUnique = New System.Windows.Forms.TabPage()
        Me.lbxUniqueBuffer = New System.Windows.Forms.ListBox()
        Me.tsslCOCout = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.splMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splMain.Panel1.SuspendLayout()
        Me.splMain.Panel2.SuspendLayout()
        Me.splMain.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbBuffer.SuspendLayout()
        Me.gbConsole.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ssMain.SuspendLayout()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tbpBufferRaw.SuspendLayout()
        Me.tbpUnique.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCBContents
        '
        Me.lblCBContents.AutoEllipsis = True
        Me.lblCBContents.AutoSize = True
        Me.lblCBContents.Location = New System.Drawing.Point(141, 10)
        Me.lblCBContents.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCBContents.Name = "lblCBContents"
        Me.lblCBContents.Size = New System.Drawing.Size(41, 16)
        Me.lblCBContents.TabIndex = 0
        Me.lblCBContents.Text = "None"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
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
        Me.splMain.Panel1.Controls.Add(Me.lblThird)
        Me.splMain.Panel1.Controls.Add(Me.lblSecond)
        Me.splMain.Panel1.Controls.Add(Me.lblFav1Label)
        Me.splMain.Panel1.Controls.Add(Me.lblFav3Label)
        Me.splMain.Panel1.Controls.Add(Me.lblFirst)
        Me.splMain.Panel1.Controls.Add(Me.Label3)
        Me.splMain.Panel1.Controls.Add(Me.Label2)
        Me.splMain.Panel1.Controls.Add(Me.lblFreq)
        Me.splMain.Panel1.Controls.Add(Me.cbxMostFreq)
        Me.splMain.Panel1.Controls.Add(Me.lblCBContents)
        Me.splMain.Panel1.Controls.Add(Me.Label1)
        '
        'splMain.Panel2
        '
        Me.splMain.Panel2.Controls.Add(Me.GroupBox1)
        Me.splMain.Size = New System.Drawing.Size(512, 506)
        Me.splMain.SplitterDistance = 72
        Me.splMain.SplitterWidth = 12
        Me.splMain.TabIndex = 3
        '
        'lblThird
        '
        Me.lblThird.AutoEllipsis = True
        Me.lblThird.AutoSize = True
        Me.lblThird.Location = New System.Drawing.Point(405, 58)
        Me.lblThird.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(41, 16)
        Me.lblThird.TabIndex = 10
        Me.lblThird.Text = "Fav 3"
        '
        'lblSecond
        '
        Me.lblSecond.AutoEllipsis = True
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Location = New System.Drawing.Point(279, 59)
        Me.lblSecond.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(41, 16)
        Me.lblSecond.TabIndex = 9
        Me.lblSecond.Text = "Fav 3"
        '
        'lblFav1Label
        '
        Me.lblFav1Label.AutoEllipsis = True
        Me.lblFav1Label.AutoSize = True
        Me.lblFav1Label.Location = New System.Drawing.Point(256, 59)
        Me.lblFav1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFav1Label.Name = "lblFav1Label"
        Me.lblFav1Label.Size = New System.Drawing.Size(22, 16)
        Me.lblFav1Label.TabIndex = 8
        Me.lblFav1Label.Text = "#2"
        '
        'lblFav3Label
        '
        Me.lblFav3Label.AutoEllipsis = True
        Me.lblFav3Label.AutoSize = True
        Me.lblFav3Label.Location = New System.Drawing.Point(385, 59)
        Me.lblFav3Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFav3Label.Name = "lblFav3Label"
        Me.lblFav3Label.Size = New System.Drawing.Size(22, 16)
        Me.lblFav3Label.TabIndex = 7
        Me.lblFav3Label.Text = "#3"
        '
        'lblFirst
        '
        Me.lblFirst.AutoEllipsis = True
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(161, 59)
        Me.lblFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(38, 16)
        Me.lblFirst.TabIndex = 6
        Me.lblFirst.Text = "Fav1"
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 59)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "#1"
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Three top favorite"
        '
        'lblFreq
        '
        Me.lblFreq.AutoSize = True
        Me.lblFreq.Location = New System.Drawing.Point(16, 33)
        Me.lblFreq.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFreq.Name = "lblFreq"
        Me.lblFreq.Size = New System.Drawing.Size(91, 16)
        Me.lblFreq.TabIndex = 3
        Me.lblFreq.Text = "Most frequent:"
        '
        'cbxMostFreq
        '
        Me.cbxMostFreq.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxMostFreq.FormattingEnabled = True
        Me.cbxMostFreq.Location = New System.Drawing.Point(124, 30)
        Me.cbxMostFreq.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxMostFreq.Name = "cbxMostFreq"
        Me.cbxMostFreq.Size = New System.Drawing.Size(379, 24)
        Me.cbxMostFreq.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(512, 422)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clipboard History"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SplitContainer1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(4, 55)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(504, 363)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(504, 363)
        Me.SplitContainer1.SplitterDistance = 213
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 6
        '
        'gbBuffer
        '
        Me.gbBuffer.Controls.Add(Me.TabControl1)
        Me.gbBuffer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbBuffer.Location = New System.Drawing.Point(0, 0)
        Me.gbBuffer.Margin = New System.Windows.Forms.Padding(4)
        Me.gbBuffer.Name = "gbBuffer"
        Me.gbBuffer.Padding = New System.Windows.Forms.Padding(4)
        Me.gbBuffer.Size = New System.Drawing.Size(504, 213)
        Me.gbBuffer.TabIndex = 0
        Me.gbBuffer.TabStop = False
        Me.gbBuffer.Text = "Buffer"
        '
        'lbxClipboardBuffer
        '
        Me.lbxClipboardBuffer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxClipboardBuffer.FormattingEnabled = True
        Me.lbxClipboardBuffer.HorizontalScrollbar = True
        Me.lbxClipboardBuffer.ItemHeight = 16
        Me.lbxClipboardBuffer.Location = New System.Drawing.Point(3, 3)
        Me.lbxClipboardBuffer.Margin = New System.Windows.Forms.Padding(4)
        Me.lbxClipboardBuffer.Name = "lbxClipboardBuffer"
        Me.lbxClipboardBuffer.ScrollAlwaysVisible = True
        Me.lbxClipboardBuffer.Size = New System.Drawing.Size(482, 155)
        Me.lbxClipboardBuffer.TabIndex = 6
        '
        'gbConsole
        '
        Me.gbConsole.Controls.Add(Me.lbxConsole)
        Me.gbConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbConsole.Location = New System.Drawing.Point(0, 0)
        Me.gbConsole.Margin = New System.Windows.Forms.Padding(4)
        Me.gbConsole.Name = "gbConsole"
        Me.gbConsole.Padding = New System.Windows.Forms.Padding(4)
        Me.gbConsole.Size = New System.Drawing.Size(504, 145)
        Me.gbConsole.TabIndex = 0
        Me.gbConsole.TabStop = False
        Me.gbConsole.Text = "Console"
        '
        'lbxConsole
        '
        Me.lbxConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxConsole.FormattingEnabled = True
        Me.lbxConsole.ItemHeight = 16
        Me.lbxConsole.Location = New System.Drawing.Point(4, 19)
        Me.lbxConsole.Margin = New System.Windows.Forms.Padding(4)
        Me.lbxConsole.Name = "lbxConsole"
        Me.lbxConsole.Size = New System.Drawing.Size(496, 122)
        Me.lbxConsole.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbxTmrEn)
        Me.Panel1.Controls.Add(Me.btnGetCB)
        Me.Panel1.Controls.Add(Me.btnClearClipboard)
        Me.Panel1.Controls.Add(Me.btnClearBuffer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(4, 19)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(504, 36)
        Me.Panel1.TabIndex = 6
        '
        'cbxTmrEn
        '
        Me.cbxTmrEn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxTmrEn.AutoSize = True
        Me.cbxTmrEn.Location = New System.Drawing.Point(324, 9)
        Me.cbxTmrEn.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxTmrEn.Name = "cbxTmrEn"
        Me.cbxTmrEn.Size = New System.Drawing.Size(74, 20)
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
        Me.btnGetCB.Size = New System.Drawing.Size(100, 36)
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
        Me.btnClearClipboard.Size = New System.Drawing.Size(116, 36)
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
        Me.btnClearBuffer.Size = New System.Drawing.Size(100, 36)
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
        Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus, Me.tsslCount, Me.tsslCmd, Me.tsslCopyCount, Me.tsslCOCout})
        Me.ssMain.Location = New System.Drawing.Point(0, 484)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.ssMain.Size = New System.Drawing.Size(512, 22)
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
        Me.tsslCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tsslCount.Name = "tsslCount"
        Me.tsslCount.Size = New System.Drawing.Size(21, 17)
        Me.tsslCount.Text = "##"
        '
        'tsslCmd
        '
        Me.tsslCmd.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tsslCmd.Name = "tsslCmd"
        Me.tsslCmd.Size = New System.Drawing.Size(33, 17)
        Me.tsslCmd.Text = "Cmd"
        '
        'tsslCopyCount
        '
        Me.tsslCopyCount.Name = "tsslCopyCount"
        Me.tsslCopyCount.Size = New System.Drawing.Size(71, 17)
        Me.tsslCopyCount.Text = "Copy Count"
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbpBufferRaw)
        Me.TabControl1.Controls.Add(Me.tbpUnique)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(4, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(496, 190)
        Me.TabControl1.TabIndex = 7
        '
        'tbpBufferRaw
        '
        Me.tbpBufferRaw.Controls.Add(Me.lbxClipboardBuffer)
        Me.tbpBufferRaw.Location = New System.Drawing.Point(4, 25)
        Me.tbpBufferRaw.Name = "tbpBufferRaw"
        Me.tbpBufferRaw.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpBufferRaw.Size = New System.Drawing.Size(488, 161)
        Me.tbpBufferRaw.TabIndex = 0
        Me.tbpBufferRaw.Text = "Buffer"
        Me.tbpBufferRaw.UseVisualStyleBackColor = True
        '
        'tbpUnique
        '
        Me.tbpUnique.Controls.Add(Me.lbxUniqueBuffer)
        Me.tbpUnique.Location = New System.Drawing.Point(4, 25)
        Me.tbpUnique.Name = "tbpUnique"
        Me.tbpUnique.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpUnique.Size = New System.Drawing.Size(488, 161)
        Me.tbpUnique.TabIndex = 1
        Me.tbpUnique.Text = "Ranked Buffer"
        Me.tbpUnique.UseVisualStyleBackColor = True
        '
        'lbxUniqueBuffer
        '
        Me.lbxUniqueBuffer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxUniqueBuffer.FormattingEnabled = True
        Me.lbxUniqueBuffer.ItemHeight = 16
        Me.lbxUniqueBuffer.Location = New System.Drawing.Point(3, 3)
        Me.lbxUniqueBuffer.Name = "lbxUniqueBuffer"
        Me.lbxUniqueBuffer.Size = New System.Drawing.Size(482, 155)
        Me.lbxUniqueBuffer.TabIndex = 0
        '
        'tsslCOCout
        '
        Me.tsslCOCout.Name = "tsslCOCout"
        Me.tsslCOCout.Size = New System.Drawing.Size(63, 17)
        Me.tsslCOCout.Text = "CO Count:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 506)
        Me.Controls.Add(Me.ssMain)
        Me.Controls.Add(Me.splMain)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(528, 545)
        Me.Name = "Form1"
        Me.Text = "Clipboard++"
        Me.splMain.Panel1.ResumeLayout(False)
        Me.splMain.Panel1.PerformLayout()
        Me.splMain.Panel2.ResumeLayout(False)
        CType(Me.splMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splMain.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbBuffer.ResumeLayout(False)
        Me.gbConsole.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tbpBufferRaw.ResumeLayout(False)
        Me.tbpUnique.ResumeLayout(False)
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
End Class
