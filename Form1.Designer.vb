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

    Me.cbxMostFreq = New System.Windows.Forms.ComboBox()
    Me.lblThird = New System.Windows.Forms.Label()
    Me.lblFav3Label = New System.Windows.Forms.Label()
    Me.lblSecond = New System.Windows.Forms.Label()
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
    Me.tpLinks = New System.Windows.Forms.TabPage()

    Me.Panel5 = New System.Windows.Forms.Panel()
    Me.lbxLinks = New System.Windows.Forms.ListBox()
    Me.Panel4 = New System.Windows.Forms.Panel()
    Me.cbxEmailTo = New System.Windows.Forms.ComboBox()
    Me.btnFwdLink = New System.Windows.Forms.Button()
r
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
    Me.tsslPollStat = New System.Windows.Forms.ToolStripStatusLabel()
    Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
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
    Me.tpLinks.SuspendLayout()
    Me.Panel5.SuspendLayout()
    Me.Panel4.SuspendLayout()

    Me.gbConsole.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.ssMain.SuspendLayout()
    CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblCBContents
    '
    Me.lblCBContents.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblCBContents.AutoEllipsis = True
    Me.lblCBContents.AutoSize = True
    Me.lblCBContents.Location = New System.Drawing.Point(94, 8)

    Me.lblCBContents.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.lblCBContents.Name = "lblCBContents"
    Me.lblCBContents.Size = New System.Drawing.Size(33, 13)
    Me.lblCBContents.TabIndex = 0
    Me.lblCBContents.Text = "None"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(2, 8)
    Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(88, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Current Clipboard"
    '
    'splMain
    '
    Me.splMain.Dock = System.Windows.Forms.DockStyle.Fill
    Me.splMain.Location = New System.Drawing.Point(0, 0)
    Me.splMain.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
    Me.splMain.Name = "splMain"
    Me.splMain.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'splMain.Panel1
    '
    Me.splMain.Panel1.Controls.Add(Me.Panel3)
    Me.splMain.Panel1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
    Me.splMain.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
    Me.splMain.Panel1MinSize = 75
    '
    'splMain.Panel2
    '
    Me.splMain.Panel2.Controls.Add(Me.GroupBox1)
    Me.splMain.Panel2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
    Me.splMain.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
    Me.splMain.Size = New System.Drawing.Size(599, 502)
    Me.splMain.SplitterDistance = 100

    Me.splMain.SplitterWidth = 8
    Me.splMain.TabIndex = 3
    '
    'Panel3
    '
    Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink

    Me.Panel3.Controls.Add(Me.cbxMostFreq)

    Me.Panel3.Controls.Add(Me.Label1)
    Me.Panel3.Controls.Add(Me.lblThird)
    Me.Panel3.Controls.Add(Me.lblCBContents)
    Me.Panel3.Controls.Add(Me.lblFav3Label)
    Me.Panel3.Controls.Add(Me.lblSecond)
    Me.Panel3.Controls.Add(Me.lblFav1Label)
    Me.Panel3.Controls.Add(Me.lblFreq)
    Me.Panel3.Controls.Add(Me.Label2)
    Me.Panel3.Controls.Add(Me.lblFirst)
    Me.Panel3.Controls.Add(Me.Label3)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel3.Location = New System.Drawing.Point(0, 0)
    Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
    Me.Panel3.MinimumSize = New System.Drawing.Size(288, 75)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(599, 90)
    Me.Panel3.TabIndex = 11
    '
    'cbxMostFreq
    '
    Me.cbxMostFreq.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbxMostFreq.FormattingEnabled = True
    Me.cbxMostFreq.Location = New System.Drawing.Point(82, 27)
    Me.cbxMostFreq.Name = "cbxMostFreq"
    Me.cbxMostFreq.Size = New System.Drawing.Size(513, 21)
    Me.cbxMostFreq.TabIndex = 11
    '

    'lblThird
    '
    Me.lblThird.AutoEllipsis = True
    Me.lblThird.AutoSize = True
    Me.lblThird.Location = New System.Drawing.Point(242, 66)
    Me.lblThird.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.lblThird.Name = "lblThird"
    Me.lblThird.Size = New System.Drawing.Size(34, 13)
    Me.lblThird.TabIndex = 10
    Me.lblThird.Text = "Fav 3"
    '
    'lblFav3Label
    '
    Me.lblFav3Label.AutoEllipsis = True
    Me.lblFav3Label.AutoSize = True
    Me.lblFav3Label.Location = New System.Drawing.Point(218, 66)
    Me.lblFav3Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.lblFav3Label.Name = "lblFav3Label"
    Me.lblFav3Label.Size = New System.Drawing.Size(20, 13)
    Me.lblFav3Label.TabIndex = 7
    Me.lblFav3Label.Text = "#3"
    '
    'lblSecond
    '
    Me.lblSecond.AutoEllipsis = True
    Me.lblSecond.AutoSize = True
    Me.lblSecond.Location = New System.Drawing.Point(130, 66)
    Me.lblSecond.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.lblSecond.Name = "lblSecond"
    Me.lblSecond.Size = New System.Drawing.Size(34, 13)
    Me.lblSecond.TabIndex = 9
    Me.lblSecond.Text = "Fav 3"
    '
    'lblFav1Label
    '
    Me.lblFav1Label.AutoEllipsis = True
    Me.lblFav1Label.AutoSize = True
    Me.lblFav1Label.Location = New System.Drawing.Point(106, 66)
    Me.lblFav1Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.lblFav1Label.Name = "lblFav1Label"
    Me.lblFav1Label.Size = New System.Drawing.Size(20, 13)
    Me.lblFav1Label.TabIndex = 8
    Me.lblFav1Label.Text = "#2"
    '
    'lblFreq
    '
    Me.lblFreq.AutoSize = True
    Me.lblFreq.Location = New System.Drawing.Point(2, 30)
    Me.lblFreq.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.lblFreq.Name = "lblFreq"
    Me.lblFreq.Size = New System.Drawing.Size(75, 13)
    Me.lblFreq.TabIndex = 3
    Me.lblFreq.Text = "Most frequent:"
    '
    'Label2
    '
    Me.Label2.AutoEllipsis = True
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(10, 48)
    Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(50, 13)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Favorites"
    '
    'lblFirst
    '
    Me.lblFirst.AutoEllipsis = True
    Me.lblFirst.AutoSize = True
    Me.lblFirst.Location = New System.Drawing.Point(35, 66)
    Me.lblFirst.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.lblFirst.Name = "lblFirst"
    Me.lblFirst.Size = New System.Drawing.Size(31, 13)
    Me.lblFirst.TabIndex = 6
    Me.lblFirst.Text = "Fav1"
    '
    'Label3
    '
    Me.Label3.AutoEllipsis = True
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(11, 66)
    Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(20, 13)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "#1"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.Panel2)
    Me.GroupBox1.Controls.Add(Me.Panel1)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
    Me.GroupBox1.Size = New System.Drawing.Size(599, 374)

    Me.GroupBox1.TabIndex = 4
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Clipboard History"
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.SplitContainer1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(2, 49)
    Me.Panel2.Name = "Panel2"

    Me.Panel2.Size = New System.Drawing.Size(595, 323)

    Me.Panel2.TabIndex = 7
    '
    'SplitContainer1
    '
    Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
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

    Me.SplitContainer1.Size = New System.Drawing.Size(595, 323)
    Me.SplitContainer1.SplitterDistance = 185

    Me.SplitContainer1.SplitterWidth = 3
    Me.SplitContainer1.TabIndex = 6
    '
    'gbBuffer
    '
    Me.gbBuffer.Controls.Add(Me.TabControl1)
    Me.gbBuffer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gbBuffer.Location = New System.Drawing.Point(0, 0)
    Me.gbBuffer.Name = "gbBuffer"
    Me.gbBuffer.Padding = New System.Windows.Forms.Padding(2)

    Me.gbBuffer.Size = New System.Drawing.Size(595, 185)

    Me.gbBuffer.TabIndex = 0
    Me.gbBuffer.TabStop = False
    Me.gbBuffer.Text = "Buffer"
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.tbpBufferRaw)
    Me.TabControl1.Controls.Add(Me.tbpUnique)
    Me.TabControl1.Controls.Add(Me.tpInspect)
    Me.TabControl1.Controls.Add(Me.tpLinks)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(2, 15)
    Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0

    Me.TabControl1.Size = New System.Drawing.Size(591, 168)

    Me.TabControl1.TabIndex = 7
    '
    'tbpBufferRaw
    '
    Me.tbpBufferRaw.Controls.Add(Me.lbxClipboardBuffer)
    Me.tbpBufferRaw.Location = New System.Drawing.Point(4, 22)
    Me.tbpBufferRaw.Margin = New System.Windows.Forms.Padding(2)
    Me.tbpBufferRaw.Name = "tbpBufferRaw"
    Me.tbpBufferRaw.Padding = New System.Windows.Forms.Padding(2)

    Me.tbpBufferRaw.Size = New System.Drawing.Size(583, 142)

    Me.tbpBufferRaw.TabIndex = 0
    Me.tbpBufferRaw.Text = "Buffer"
    Me.tbpBufferRaw.UseVisualStyleBackColor = True
    '
    'lbxClipboardBuffer
    '
    Me.lbxClipboardBuffer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lbxClipboardBuffer.FormattingEnabled = True
    Me.lbxClipboardBuffer.HorizontalScrollbar = True
    Me.lbxClipboardBuffer.Location = New System.Drawing.Point(2, 2)
    Me.lbxClipboardBuffer.Margin = New System.Windows.Forms.Padding(2)
    Me.lbxClipboardBuffer.Name = "lbxClipboardBuffer"
    Me.lbxClipboardBuffer.ScrollAlwaysVisible = True

    Me.lbxClipboardBuffer.Size = New System.Drawing.Size(579, 138)

    Me.lbxClipboardBuffer.TabIndex = 6
    '
    'tbpUnique
    '
    Me.tbpUnique.Controls.Add(Me.lbxUniqueBuffer)
    Me.tbpUnique.Location = New System.Drawing.Point(4, 22)
    Me.tbpUnique.Margin = New System.Windows.Forms.Padding(2)
    Me.tbpUnique.Name = "tbpUnique"
    Me.tbpUnique.Padding = New System.Windows.Forms.Padding(2)

    Me.tbpUnique.Size = New System.Drawing.Size(583, 142)

    Me.tbpUnique.TabIndex = 1
    Me.tbpUnique.Text = "Ranked Buffer"
    Me.tbpUnique.UseVisualStyleBackColor = True
    '
    'lbxUniqueBuffer
    '
    Me.lbxUniqueBuffer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lbxUniqueBuffer.FormattingEnabled = True
    Me.lbxUniqueBuffer.Location = New System.Drawing.Point(2, 2)
    Me.lbxUniqueBuffer.Margin = New System.Windows.Forms.Padding(2)
    Me.lbxUniqueBuffer.Name = "lbxUniqueBuffer"
    Me.lbxUniqueBuffer.Size = New System.Drawing.Size(579, 138)

    Me.lbxUniqueBuffer.TabIndex = 0
    '
    'tpInspect
    '
    Me.tpInspect.Controls.Add(Me.tbxInspect)
    Me.tpInspect.Location = New System.Drawing.Point(4, 22)
    Me.tpInspect.Margin = New System.Windows.Forms.Padding(2)
    Me.tpInspect.Name = "tpInspect"
    Me.tpInspect.Padding = New System.Windows.Forms.Padding(2)
    Me.tpInspect.Size = New System.Drawing.Size(583, 142)

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

    Me.tbxInspect.Size = New System.Drawing.Size(579, 138)

    Me.tbxInspect.TabIndex = 0
    '
    'tpLinks
    '

    Me.tpLinks.Controls.Add(Me.Panel5)
    Me.tpLinks.Controls.Add(Me.Panel4)
    Me.tpLinks.Location = New System.Drawing.Point(4, 22)
    Me.tpLinks.Name = "tpLinks"
    Me.tpLinks.Padding = New System.Windows.Forms.Padding(3)
    Me.tpLinks.Size = New System.Drawing.Size(583, 142)

    Me.tpLinks.TabIndex = 3
    Me.tpLinks.Text = "Links"
    Me.tpLinks.UseVisualStyleBackColor = True
    '

    'Panel5
    '
    Me.Panel5.Controls.Add(Me.lbxLinks)
    Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel5.Location = New System.Drawing.Point(3, 32)
    Me.Panel5.Name = "Panel5"
    Me.Panel5.Size = New System.Drawing.Size(577, 107)
    Me.Panel5.TabIndex = 2
    '

    'lbxLinks
    '
    Me.lbxLinks.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lbxLinks.FormattingEnabled = True
    Me.lbxLinks.Location = New System.Drawing.Point(0, 0)
    Me.lbxLinks.Name = "lbxLinks"
    Me.lbxLinks.Size = New System.Drawing.Size(577, 107)
    Me.lbxLinks.TabIndex = 1
    '
    'Panel4
    '
    Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Panel4.Controls.Add(Me.cbxEmailTo)
    Me.Panel4.Controls.Add(Me.btnFwdLink)
    Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel4.Location = New System.Drawing.Point(3, 3)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(577, 29)
    Me.Panel4.TabIndex = 0
    '
    'cbxEmailTo
    '
    Me.cbxEmailTo.Enabled = False
    Me.cbxEmailTo.FormattingEnabled = True
    Me.cbxEmailTo.Location = New System.Drawing.Point(81, 4)
    Me.cbxEmailTo.Name = "cbxEmailTo"
    Me.cbxEmailTo.Size = New System.Drawing.Size(262, 21)
    Me.cbxEmailTo.TabIndex = 1
    Me.cbxEmailTo.Text = "Select Recipient"
    Me.ToolTip1.SetToolTip(Me.cbxEmailTo, "Select a recient to fwd copied links")
    '
    'btnFwdLink
    '
    Me.btnFwdLink.Dock = System.Windows.Forms.DockStyle.Left
    Me.btnFwdLink.Enabled = False
    Me.btnFwdLink.Location = New System.Drawing.Point(0, 0)
    Me.btnFwdLink.Name = "btnFwdLink"
    Me.btnFwdLink.Size = New System.Drawing.Size(75, 27)
    Me.btnFwdLink.TabIndex = 0
    Me.btnFwdLink.Text = "Fwd"
    Me.ToolTip1.SetToolTip(Me.btnFwdLink, "Fwd selected link to selected recipient")
    Me.btnFwdLink.UseVisualStyleBackColor = True

    '
    'gbConsole
    '
    Me.gbConsole.Controls.Add(Me.lbxConsole)
    Me.gbConsole.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gbConsole.Location = New System.Drawing.Point(0, 0)
    Me.gbConsole.Name = "gbConsole"
    Me.gbConsole.Padding = New System.Windows.Forms.Padding(2)

    Me.gbConsole.Size = New System.Drawing.Size(595, 135)
    Me.gbConsole.TabIndex = 0
    Me.gbConsole.TabStop = False
    Me.gbConsole.Text = "Console"
    '
    'lbxConsole
    '
    Me.lbxConsole.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lbxConsole.FormattingEnabled = True
    Me.lbxConsole.Location = New System.Drawing.Point(2, 15)
    Me.lbxConsole.Name = "lbxConsole"

    Me.lbxConsole.Size = New System.Drawing.Size(591, 118)

    Me.lbxConsole.TabIndex = 0
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.cbxTmrEn)
    Me.Panel1.Controls.Add(Me.btnGetCB)
    Me.Panel1.Controls.Add(Me.btnClearClipboard)
    Me.Panel1.Controls.Add(Me.btnClearBuffer)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(2, 15)
    Me.Panel1.Name = "Panel1"

    Me.Panel1.Size = New System.Drawing.Size(595, 34)

    Me.Panel1.TabIndex = 6
    '
    'cbxTmrEn
    '
    Me.cbxTmrEn.Anchor = System.Windows.Forms.AnchorStyles.Left
    Me.cbxTmrEn.AutoSize = True
    Me.cbxTmrEn.Location = New System.Drawing.Point(243, 12)
    Me.cbxTmrEn.Name = "cbxTmrEn"
    Me.cbxTmrEn.Size = New System.Drawing.Size(63, 17)
    Me.cbxTmrEn.TabIndex = 9
    Me.cbxTmrEn.Text = "Capture"
    Me.cbxTmrEn.UseVisualStyleBackColor = True
    '
    'btnGetCB
    '
    Me.btnGetCB.Dock = System.Windows.Forms.DockStyle.Left
    Me.btnGetCB.Location = New System.Drawing.Point(162, 0)
    Me.btnGetCB.Name = "btnGetCB"
    Me.btnGetCB.Size = New System.Drawing.Size(75, 34)
    Me.btnGetCB.TabIndex = 8
    Me.btnGetCB.Text = "Get CB"
    Me.ToolTip1.SetToolTip(Me.btnGetCB, "Manually aquire contents of clipboard")
    Me.btnGetCB.UseVisualStyleBackColor = True
    '
    'btnClearClipboard
    '
    Me.btnClearClipboard.Dock = System.Windows.Forms.DockStyle.Left
    Me.btnClearClipboard.Location = New System.Drawing.Point(75, 0)
    Me.btnClearClipboard.Name = "btnClearClipboard"
    Me.btnClearClipboard.Size = New System.Drawing.Size(87, 34)
    Me.btnClearClipboard.TabIndex = 7
    Me.btnClearClipboard.Text = "Clear Clipboard"
    Me.btnClearClipboard.UseVisualStyleBackColor = True
    '
    'btnClearBuffer
    '
    Me.btnClearBuffer.Dock = System.Windows.Forms.DockStyle.Left
    Me.btnClearBuffer.Location = New System.Drawing.Point(0, 0)
    Me.btnClearBuffer.Name = "btnClearBuffer"
    Me.btnClearBuffer.Size = New System.Drawing.Size(75, 34)
    Me.btnClearBuffer.TabIndex = 6
    Me.btnClearBuffer.Text = "Clear Buffer"
    Me.btnClearBuffer.UseVisualStyleBackColor = True
    '
    'Timer1
    '

    'NotifyIcon1
    '
    Me.NotifyIcon1.Text = "NotifyIcon1"
    Me.NotifyIcon1.Visible = True
    '
    'ssMain
    '
    Me.ssMain.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus, Me.tsslCount, Me.tsslCmd, Me.tsslCopyCount, Me.tsslCOCout, Me.tsslPollStat, Me.ToolStripStatusLabel1})

    Me.ssMain.Location = New System.Drawing.Point(0, 480)
    Me.ssMain.Name = "ssMain"
    Me.ssMain.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
    Me.ssMain.Size = New System.Drawing.Size(599, 22)

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
    'tsslCOCout
    '
    Me.tsslCOCout.Name = "tsslCOCout"
    Me.tsslCOCout.Size = New System.Drawing.Size(63, 17)
    Me.tsslCOCout.Text = "CO Count:"
    '
    'tsslPollStat
    '
    Me.tsslPollStat.Name = "tsslPollStat"
    Me.tsslPollStat.Size = New System.Drawing.Size(60, 17)
    Me.tsslPollStat.Text = "Polling: --"
    Me.tsslPollStat.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
    '
    'ToolStripStatusLabel1
    '
    Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
l1.Size = New System.Drawing.Size(119, 17)

    Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
    '
    'EventLog1
    '
    Me.EventLog1.SynchronizingObject = Me
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

    Me.ClientSize = New System.Drawing.Size(599, 502)

    Me.Controls.Add(Me.ssMain)
    Me.Controls.Add(Me.splMain)
    Me.Margin = New System.Windows.Forms.Padding(2)
    Me.MinimumSize = New System.Drawing.Size(334, 373)
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
    Me.tpLinks.ResumeLayout(False)

    Me.Panel5.ResumeLayout(False)
    Me.Panel4.ResumeLayout(False)

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
  Friend WithEvents tsslPollStat As ToolStripStatusLabel
  Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
  Friend WithEvents tpLinks As TabPage
  Friend WithEvents lbxLinks As ListBox

  Friend WithEvents Panel4 As Panel
  Friend WithEvents btnFwdLink As Button
  Friend WithEvents Panel5 As Panel
  Friend WithEvents cbxEmailTo As ComboBox
  Friend WithEvents cbxMostFreq As ComboBox

End Class
