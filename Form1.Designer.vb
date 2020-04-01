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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'lblCBContents
        '
        Me.lblCBContents.AutoEllipsis = True
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
        Me.splMain.Panel1.Controls.Add(Me.Label2)
        Me.splMain.Panel1.Controls.Add(Me.lblCBContents)
        Me.splMain.Panel1.Controls.Add(Me.Label1)
        '
        'splMain.Panel2
        '
        Me.splMain.Panel2.Controls.Add(Me.GroupBox1)
        Me.splMain.Size = New System.Drawing.Size(405, 516)
        Me.splMain.SplitterDistance = 36
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
        Me.GroupBox1.Size = New System.Drawing.Size(405, 470)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clipboard History"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SplitContainer1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(399, 422)
        Me.Panel2.TabIndex = 7
        '
        'SplitContainer1
        '
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
        Me.SplitContainer1.Size = New System.Drawing.Size(399, 422)
        Me.SplitContainer1.SplitterDistance = 249
        Me.SplitContainer1.TabIndex = 6
        '
        'gbBuffer
        '
        Me.gbBuffer.Controls.Add(Me.lbxClipboardBuffer)
        Me.gbBuffer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbBuffer.Location = New System.Drawing.Point(0, 0)
        Me.gbBuffer.Name = "gbBuffer"
        Me.gbBuffer.Size = New System.Drawing.Size(399, 249)
        Me.gbBuffer.TabIndex = 0
        Me.gbBuffer.TabStop = False
        Me.gbBuffer.Text = "Buffer"
        '
        'lbxClipboardBuffer
        '
        Me.lbxClipboardBuffer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxClipboardBuffer.FormattingEnabled = True
        Me.lbxClipboardBuffer.HorizontalScrollbar = True
        Me.lbxClipboardBuffer.Location = New System.Drawing.Point(3, 16)
        Me.lbxClipboardBuffer.Name = "lbxClipboardBuffer"
        Me.lbxClipboardBuffer.ScrollAlwaysVisible = True
        Me.lbxClipboardBuffer.Size = New System.Drawing.Size(393, 230)
        Me.lbxClipboardBuffer.TabIndex = 6
        '
        'gbConsole
        '
        Me.gbConsole.Controls.Add(Me.lbxConsole)
        Me.gbConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbConsole.Location = New System.Drawing.Point(0, 0)
        Me.gbConsole.Name = "gbConsole"
        Me.gbConsole.Size = New System.Drawing.Size(399, 169)
        Me.gbConsole.TabIndex = 0
        Me.gbConsole.TabStop = False
        Me.gbConsole.Text = "Console"
        '
        'lbxConsole
        '
        Me.lbxConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxConsole.FormattingEnabled = True
        Me.lbxConsole.Location = New System.Drawing.Point(3, 16)
        Me.lbxConsole.Name = "lbxConsole"
        Me.lbxConsole.Size = New System.Drawing.Size(393, 150)
        Me.lbxConsole.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbxTmrEn)
        Me.Panel1.Controls.Add(Me.btnGetCB)
        Me.Panel1.Controls.Add(Me.btnClearClipboard)
        Me.Panel1.Controls.Add(Me.btnClearBuffer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 29)
        Me.Panel1.TabIndex = 6
        '
        'cbxTmrEn
        '
        Me.cbxTmrEn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxTmrEn.AutoSize = True
        Me.cbxTmrEn.Location = New System.Drawing.Point(243, 7)
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
        Me.btnGetCB.Size = New System.Drawing.Size(75, 29)
        Me.btnGetCB.TabIndex = 8
        Me.btnGetCB.Text = "Get CB"
        Me.btnGetCB.UseVisualStyleBackColor = True
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
        Me.ssMain.Location = New System.Drawing.Point(0, 494)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(405, 22)
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
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 516)
        Me.Controls.Add(Me.ssMain)
        Me.Controls.Add(Me.splMain)
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
    Friend WithEvents Label2 As Label
End Class
