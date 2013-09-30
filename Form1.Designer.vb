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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Theme1 = New ROMKitchenHelper.NSTheme()
        Me.pnlRecovery = New System.Windows.Forms.Panel()
        Me.LblFlashStatus1 = New System.Windows.Forms.Label()
        Me.lblDeviceInfo1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pnlFlash = New System.Windows.Forms.Panel()
        Me.LblFlashStatus = New System.Windows.Forms.Label()
        Me.lblDeviceInfo = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.pnlKernel = New System.Windows.Forms.Panel()
        Me.lblKernelDownload = New System.Windows.Forms.Label()
        Me.lblKernelTotal = New System.Windows.Forms.Label()
        Me.lblKernelDownloadName = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.NsProgressBar2 = New ROMKitchenHelper.NSProgressBar()
        Me.pnlFinished = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.pnlROM = New System.Windows.Forms.Panel()
        Me.lblROMDownload = New System.Windows.Forms.Label()
        Me.lblROMTotal = New System.Windows.Forms.Label()
        Me.lblROMDownloadName = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.NsProgressBar1 = New ROMKitchenHelper.NSProgressBar()
        Me.NsButton2 = New ROMKitchenHelper.NSButton()
        Me.NsButton1 = New ROMKitchenHelper.NSButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NsOnOffBox1 = New ROMKitchenHelper.NSOnOffBox()
        Me.NsSeperator1 = New ROMKitchenHelper.NSSeperator()
        Me.NsControlButton3 = New ROMKitchenHelper.NSControlButton()
        Me.NsControlButton1 = New ROMKitchenHelper.NSControlButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.barTotal = New ROMKitchenHelper.NSProgressBar()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.txtROM = New System.Windows.Forms.Label()
        Me.txtRecovery = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtFinished = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtKernel = New System.Windows.Forms.Label()
        Me.txtFlash = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Theme1.SuspendLayout()
        Me.pnlRecovery.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFlash.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlKernel.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFinished.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlROM.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Theme1
        '
        Me.Theme1.AccentOffset = 42
        Me.Theme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Theme1.Colors = New ROMKitchenHelper.Bloom(-1) {}
        Me.Theme1.Controls.Add(Me.pnlRecovery)
        Me.Theme1.Controls.Add(Me.pnlFlash)
        Me.Theme1.Controls.Add(Me.pnlROM)
        Me.Theme1.Controls.Add(Me.pnlKernel)
        Me.Theme1.Controls.Add(Me.NsButton2)
        Me.Theme1.Controls.Add(Me.NsButton1)
        Me.Theme1.Controls.Add(Me.Label1)
        Me.Theme1.Controls.Add(Me.NsOnOffBox1)
        Me.Theme1.Controls.Add(Me.NsSeperator1)
        Me.Theme1.Controls.Add(Me.NsControlButton3)
        Me.Theme1.Controls.Add(Me.NsControlButton1)
        Me.Theme1.Controls.Add(Me.Panel1)
        Me.Theme1.Controls.Add(Me.pnlFinished)
        Me.Theme1.Customization = ""
        Me.Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Theme1.Image = Nothing
        Me.Theme1.Location = New System.Drawing.Point(0, 0)
        Me.Theme1.Movable = True
        Me.Theme1.Name = "Theme1"
        Me.Theme1.NoRounding = False
        Me.Theme1.Sizable = False
        Me.Theme1.Size = New System.Drawing.Size(610, 403)
        Me.Theme1.SmartBounds = True
        Me.Theme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Theme1.TabIndex = 0
        Me.Theme1.Text = "Cyanlabs ROM Kitchen Helper"
        Me.Theme1.TransparencyKey = System.Drawing.Color.Empty
        Me.Theme1.Transparent = False
        '
        'pnlRecovery
        '
        Me.pnlRecovery.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlRecovery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRecovery.Controls.Add(Me.LblFlashStatus1)
        Me.pnlRecovery.Controls.Add(Me.lblDeviceInfo1)
        Me.pnlRecovery.Controls.Add(Me.PictureBox3)
        Me.pnlRecovery.Location = New System.Drawing.Point(147, 38)
        Me.pnlRecovery.Name = "pnlRecovery"
        Me.pnlRecovery.Size = New System.Drawing.Size(450, 352)
        Me.pnlRecovery.TabIndex = 6
        Me.pnlRecovery.Visible = False
        '
        'LblFlashStatus1
        '
        Me.LblFlashStatus1.ForeColor = System.Drawing.Color.White
        Me.LblFlashStatus1.Location = New System.Drawing.Point(3, 277)
        Me.LblFlashStatus1.Name = "LblFlashStatus1"
        Me.LblFlashStatus1.Size = New System.Drawing.Size(442, 13)
        Me.LblFlashStatus1.TabIndex = 14
        Me.LblFlashStatus1.Text = "Flashing ROM via recovery to connected device"
        Me.LblFlashStatus1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDeviceInfo1
        '
        Me.lblDeviceInfo1.ForeColor = System.Drawing.Color.White
        Me.lblDeviceInfo1.Location = New System.Drawing.Point(3, 312)
        Me.lblDeviceInfo1.Name = "lblDeviceInfo1"
        Me.lblDeviceInfo1.Size = New System.Drawing.Size(442, 13)
        Me.lblDeviceInfo1.TabIndex = 13
        Me.lblDeviceInfo1.Text = "No device detected, Enable ADB Debugging and connect device"
        Me.lblDeviceInfo1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ROMKitchenHelper.My.Resources.Resources.android_searching
        Me.PictureBox3.Location = New System.Drawing.Point(95, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'pnlFlash
        '
        Me.pnlFlash.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlFlash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFlash.Controls.Add(Me.LblFlashStatus)
        Me.pnlFlash.Controls.Add(Me.lblDeviceInfo)
        Me.pnlFlash.Controls.Add(Me.PictureBox10)
        Me.pnlFlash.Location = New System.Drawing.Point(147, 38)
        Me.pnlFlash.Name = "pnlFlash"
        Me.pnlFlash.Size = New System.Drawing.Size(450, 352)
        Me.pnlFlash.TabIndex = 5
        Me.pnlFlash.Visible = False
        '
        'LblFlashStatus
        '
        Me.LblFlashStatus.ForeColor = System.Drawing.Color.White
        Me.LblFlashStatus.Location = New System.Drawing.Point(3, 277)
        Me.LblFlashStatus.Name = "LblFlashStatus"
        Me.LblFlashStatus.Size = New System.Drawing.Size(442, 13)
        Me.LblFlashStatus.TabIndex = 11
        Me.LblFlashStatus.Text = "Flashing kernel via fastboot to connected device"
        Me.LblFlashStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDeviceInfo
        '
        Me.lblDeviceInfo.ForeColor = System.Drawing.Color.White
        Me.lblDeviceInfo.Location = New System.Drawing.Point(3, 312)
        Me.lblDeviceInfo.Name = "lblDeviceInfo"
        Me.lblDeviceInfo.Size = New System.Drawing.Size(442, 13)
        Me.lblDeviceInfo.TabIndex = 11
        Me.lblDeviceInfo.Text = "No device detected, Enable ADB Debugging and connect device"
        Me.lblDeviceInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.ROMKitchenHelper.My.Resources.Resources.android_searching
        Me.PictureBox10.Location = New System.Drawing.Point(95, 14)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox10.TabIndex = 7
        Me.PictureBox10.TabStop = False
        '
        'pnlKernel
        '
        Me.pnlKernel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlKernel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlKernel.Controls.Add(Me.lblKernelDownload)
        Me.pnlKernel.Controls.Add(Me.lblKernelTotal)
        Me.pnlKernel.Controls.Add(Me.lblKernelDownloadName)
        Me.pnlKernel.Controls.Add(Me.PictureBox8)
        Me.pnlKernel.Controls.Add(Me.NsProgressBar2)
        Me.pnlKernel.Location = New System.Drawing.Point(147, 38)
        Me.pnlKernel.Name = "pnlKernel"
        Me.pnlKernel.Size = New System.Drawing.Size(450, 352)
        Me.pnlKernel.TabIndex = 5
        Me.pnlKernel.Visible = False
        '
        'lblKernelDownload
        '
        Me.lblKernelDownload.ForeColor = System.Drawing.Color.White
        Me.lblKernelDownload.Location = New System.Drawing.Point(325, 327)
        Me.lblKernelDownload.Name = "lblKernelDownload"
        Me.lblKernelDownload.Size = New System.Drawing.Size(117, 13)
        Me.lblKernelDownload.TabIndex = 6
        Me.lblKernelDownload.Text = "0% Complete"
        Me.lblKernelDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKernelTotal
        '
        Me.lblKernelTotal.ForeColor = System.Drawing.Color.White
        Me.lblKernelTotal.Location = New System.Drawing.Point(6, 327)
        Me.lblKernelTotal.Name = "lblKernelTotal"
        Me.lblKernelTotal.Size = New System.Drawing.Size(313, 13)
        Me.lblKernelTotal.TabIndex = 7
        Me.lblKernelTotal.Text = "File Size:"
        Me.lblKernelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKernelDownloadName
        '
        Me.lblKernelDownloadName.AutoSize = True
        Me.lblKernelDownloadName.ForeColor = System.Drawing.Color.White
        Me.lblKernelDownloadName.Location = New System.Drawing.Point(6, 273)
        Me.lblKernelDownloadName.Name = "lblKernelDownloadName"
        Me.lblKernelDownloadName.Size = New System.Drawing.Size(126, 13)
        Me.lblKernelDownloadName.TabIndex = 8
        Me.lblKernelDownloadName.Text = "Downloading Kernel:"
        Me.lblKernelDownloadName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.ROMKitchenHelper.My.Resources.Resources.android_download
        Me.PictureBox8.Location = New System.Drawing.Point(97, 10)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox8.TabIndex = 5
        Me.PictureBox8.TabStop = False
        '
        'NsProgressBar2
        '
        Me.NsProgressBar2.Location = New System.Drawing.Point(8, 291)
        Me.NsProgressBar2.Maximum = 100
        Me.NsProgressBar2.Minimum = 0
        Me.NsProgressBar2.Name = "NsProgressBar2"
        Me.NsProgressBar2.Size = New System.Drawing.Size(433, 33)
        Me.NsProgressBar2.TabIndex = 4
        Me.NsProgressBar2.Text = "NsProgressBar2"
        Me.NsProgressBar2.Value = 0
        '
        'pnlFinished
        '
        Me.pnlFinished.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlFinished.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFinished.Controls.Add(Me.Label9)
        Me.pnlFinished.Controls.Add(Me.PictureBox11)
        Me.pnlFinished.Location = New System.Drawing.Point(147, 38)
        Me.pnlFinished.Name = "pnlFinished"
        Me.pnlFinished.Size = New System.Drawing.Size(450, 352)
        Me.pnlFinished.TabIndex = 7
        Me.pnlFinished.Visible = False
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(-1, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(450, 57)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Kernel and ROM have been downloaded." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kernel and ROM have been flashed to your " & _
    "device."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.ROMKitchenHelper.My.Resources.Resources.android_success
        Me.PictureBox11.Location = New System.Drawing.Point(95, 11)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox11.TabIndex = 4
        Me.PictureBox11.TabStop = False
        '
        'pnlROM
        '
        Me.pnlROM.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlROM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlROM.Controls.Add(Me.lblROMDownload)
        Me.pnlROM.Controls.Add(Me.lblROMTotal)
        Me.pnlROM.Controls.Add(Me.lblROMDownloadName)
        Me.pnlROM.Controls.Add(Me.PictureBox7)
        Me.pnlROM.Controls.Add(Me.NsProgressBar1)
        Me.pnlROM.Location = New System.Drawing.Point(147, 38)
        Me.pnlROM.Name = "pnlROM"
        Me.pnlROM.Size = New System.Drawing.Size(450, 352)
        Me.pnlROM.TabIndex = 3
        '
        'lblROMDownload
        '
        Me.lblROMDownload.ForeColor = System.Drawing.Color.White
        Me.lblROMDownload.Location = New System.Drawing.Point(325, 327)
        Me.lblROMDownload.Name = "lblROMDownload"
        Me.lblROMDownload.Size = New System.Drawing.Size(114, 13)
        Me.lblROMDownload.TabIndex = 2
        Me.lblROMDownload.Text = "0% Complete"
        Me.lblROMDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblROMTotal
        '
        Me.lblROMTotal.ForeColor = System.Drawing.Color.White
        Me.lblROMTotal.Location = New System.Drawing.Point(6, 327)
        Me.lblROMTotal.Name = "lblROMTotal"
        Me.lblROMTotal.Size = New System.Drawing.Size(300, 13)
        Me.lblROMTotal.TabIndex = 3
        Me.lblROMTotal.Text = "File Size: "
        Me.lblROMTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblROMDownloadName
        '
        Me.lblROMDownloadName.AutoSize = True
        Me.lblROMDownloadName.ForeColor = System.Drawing.Color.White
        Me.lblROMDownloadName.Location = New System.Drawing.Point(6, 273)
        Me.lblROMDownloadName.Name = "lblROMDownloadName"
        Me.lblROMDownloadName.Size = New System.Drawing.Size(119, 13)
        Me.lblROMDownloadName.TabIndex = 3
        Me.lblROMDownloadName.Text = "Downloading ROM: "
        Me.lblROMDownloadName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.ROMKitchenHelper.My.Resources.Resources.android_download
        Me.PictureBox7.Location = New System.Drawing.Point(97, 10)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 1
        Me.PictureBox7.TabStop = False
        '
        'NsProgressBar1
        '
        Me.NsProgressBar1.Location = New System.Drawing.Point(8, 291)
        Me.NsProgressBar1.Maximum = 100
        Me.NsProgressBar1.Minimum = 0
        Me.NsProgressBar1.Name = "NsProgressBar1"
        Me.NsProgressBar1.Size = New System.Drawing.Size(433, 33)
        Me.NsProgressBar1.TabIndex = 0
        Me.NsProgressBar1.Text = "NsProgressBar1"
        Me.NsProgressBar1.Value = 0
        '
        'NsButton2
        '
        Me.NsButton2.Enabled = False
        Me.NsButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NsButton2.Location = New System.Drawing.Point(305, 406)
        Me.NsButton2.Name = "NsButton2"
        Me.NsButton2.Size = New System.Drawing.Size(144, 38)
        Me.NsButton2.TabIndex = 9
        Me.NsButton2.Text = "      Previous"
        '
        'NsButton1
        '
        Me.NsButton1.Enabled = False
        Me.NsButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NsButton1.Location = New System.Drawing.Point(455, 406)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(144, 38)
        Me.NsButton1.TabIndex = 9
        Me.NsButton1.Text = "          Next"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(72, 417)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Start next step automatically"
        '
        'NsOnOffBox1
        '
        Me.NsOnOffBox1.Checked = True
        Me.NsOnOffBox1.Enabled = False
        Me.NsOnOffBox1.Location = New System.Drawing.Point(14, 414)
        Me.NsOnOffBox1.MaximumSize = New System.Drawing.Size(56, 24)
        Me.NsOnOffBox1.MinimumSize = New System.Drawing.Size(56, 24)
        Me.NsOnOffBox1.Name = "NsOnOffBox1"
        Me.NsOnOffBox1.Size = New System.Drawing.Size(56, 24)
        Me.NsOnOffBox1.TabIndex = 7
        Me.NsOnOffBox1.Text = "NsOnOffBox1"
        '
        'NsSeperator1
        '
        Me.NsSeperator1.Location = New System.Drawing.Point(2, 396)
        Me.NsSeperator1.Name = "NsSeperator1"
        Me.NsSeperator1.Size = New System.Drawing.Size(607, 10)
        Me.NsSeperator1.TabIndex = 1
        Me.NsSeperator1.Text = "NsSeperator1"
        '
        'NsControlButton3
        '
        Me.NsControlButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsControlButton3.ControlButton = ROMKitchenHelper.NSControlButton.Button.Minimize
        Me.NsControlButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NsControlButton3.Location = New System.Drawing.Point(571, 4)
        Me.NsControlButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.NsControlButton3.MaximumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton3.MinimumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton3.Name = "NsControlButton3"
        Me.NsControlButton3.Size = New System.Drawing.Size(18, 20)
        Me.NsControlButton3.TabIndex = 0
        Me.NsControlButton3.Text = "NsControlButton1"
        '
        'NsControlButton1
        '
        Me.NsControlButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsControlButton1.ControlButton = ROMKitchenHelper.NSControlButton.Button.Close
        Me.NsControlButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NsControlButton1.Location = New System.Drawing.Point(588, 4)
        Me.NsControlButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.NsControlButton1.MaximumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.MinimumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.Name = "NsControlButton1"
        Me.NsControlButton1.Size = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.TabIndex = 0
        Me.NsControlButton1.Text = "NsControlButton1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.barTotal)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.txtROM)
        Me.Panel1.Controls.Add(Me.txtRecovery)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.txtFinished)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.txtKernel)
        Me.Panel1.Controls.Add(Me.txtFlash)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Location = New System.Drawing.Point(10, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(139, 352)
        Me.Panel1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(-1, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Help && About"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'barTotal
        '
        Me.barTotal.Location = New System.Drawing.Point(4, 320)
        Me.barTotal.Maximum = 5
        Me.barTotal.Minimum = 0
        Me.barTotal.Name = "barTotal"
        Me.barTotal.Size = New System.Drawing.Size(128, 27)
        Me.barTotal.TabIndex = 4
        Me.barTotal.Text = "NsProgressBar3"
        Me.barTotal.Value = 0
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.ROMKitchenHelper.My.Resources.Resources.current
        Me.PictureBox6.Location = New System.Drawing.Point(16, 242)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'txtROM
        '
        Me.txtROM.BackColor = System.Drawing.Color.Transparent
        Me.txtROM.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtROM.ForeColor = System.Drawing.Color.White
        Me.txtROM.Location = New System.Drawing.Point(34, 37)
        Me.txtROM.Name = "txtROM"
        Me.txtROM.Size = New System.Drawing.Size(96, 25)
        Me.txtROM.TabIndex = 4
        Me.txtROM.Text = "ROM"
        Me.txtROM.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtRecovery
        '
        Me.txtRecovery.BackColor = System.Drawing.Color.Transparent
        Me.txtRecovery.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecovery.ForeColor = System.Drawing.Color.DimGray
        Me.txtRecovery.Location = New System.Drawing.Point(34, 137)
        Me.txtRecovery.Name = "txtRecovery"
        Me.txtRecovery.Size = New System.Drawing.Size(96, 25)
        Me.txtRecovery.TabIndex = 4
        Me.txtRecovery.Text = "Recovery"
        Me.txtRecovery.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ROMKitchenHelper.My.Resources.Resources.current
        Me.PictureBox1.Location = New System.Drawing.Point(16, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'txtFinished
        '
        Me.txtFinished.BackColor = System.Drawing.Color.Transparent
        Me.txtFinished.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinished.ForeColor = System.Drawing.Color.DimGray
        Me.txtFinished.Location = New System.Drawing.Point(34, 237)
        Me.txtFinished.Name = "txtFinished"
        Me.txtFinished.Size = New System.Drawing.Size(96, 25)
        Me.txtFinished.TabIndex = 4
        Me.txtFinished.Text = "Finished"
        Me.txtFinished.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ROMKitchenHelper.My.Resources.Resources.current
        Me.PictureBox2.Location = New System.Drawing.Point(16, 92)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'txtKernel
        '
        Me.txtKernel.BackColor = System.Drawing.Color.Transparent
        Me.txtKernel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKernel.ForeColor = System.Drawing.Color.DimGray
        Me.txtKernel.Location = New System.Drawing.Point(34, 87)
        Me.txtKernel.Name = "txtKernel"
        Me.txtKernel.Size = New System.Drawing.Size(96, 25)
        Me.txtKernel.TabIndex = 4
        Me.txtKernel.Text = "Kernel"
        Me.txtKernel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtFlash
        '
        Me.txtFlash.BackColor = System.Drawing.Color.Transparent
        Me.txtFlash.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlash.ForeColor = System.Drawing.Color.DimGray
        Me.txtFlash.Location = New System.Drawing.Point(34, 186)
        Me.txtFlash.Name = "txtFlash"
        Me.txtFlash.Size = New System.Drawing.Size(96, 25)
        Me.txtFlash.TabIndex = 4
        Me.txtFlash.Text = "Flash"
        Me.txtFlash.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.ROMKitchenHelper.My.Resources.Resources.current
        Me.PictureBox5.Location = New System.Drawing.Point(16, 191)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ROMKitchenHelper.My.Resources.Resources.current
        Me.PictureBox4.Location = New System.Drawing.Point(16, 142)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 403)
        Me.Controls.Add(Me.Theme1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CYanlabs ROM Kitchen Helper"
        Me.Theme1.ResumeLayout(False)
        Me.Theme1.PerformLayout()
        Me.pnlRecovery.ResumeLayout(False)
        Me.pnlRecovery.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFlash.ResumeLayout(False)
        Me.pnlFlash.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlKernel.ResumeLayout(False)
        Me.pnlKernel.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFinished.ResumeLayout(False)
        Me.pnlFinished.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlROM.ResumeLayout(False)
        Me.pnlROM.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme1 As ROMKitchenHelper.NSTheme
    Friend WithEvents NsSeperator1 As ROMKitchenHelper.NSSeperator
    Friend WithEvents NsControlButton3 As ROMKitchenHelper.NSControlButton
    Friend WithEvents NsControlButton1 As ROMKitchenHelper.NSControlButton
    Friend WithEvents NsButton2 As ROMKitchenHelper.NSButton
    Friend WithEvents NsButton1 As ROMKitchenHelper.NSButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NsOnOffBox1 As ROMKitchenHelper.NSOnOffBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents txtROM As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents txtFlash As System.Windows.Forms.Label
    Friend WithEvents txtRecovery As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtFinished As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtKernel As System.Windows.Forms.Label
    Friend WithEvents pnlROM As System.Windows.Forms.Panel
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents NsProgressBar1 As ROMKitchenHelper.NSProgressBar
    Friend WithEvents pnlRecovery As System.Windows.Forms.Panel
    Friend WithEvents pnlFinished As System.Windows.Forms.Panel
    Friend WithEvents pnlFlash As System.Windows.Forms.Panel
    Friend WithEvents pnlKernel As System.Windows.Forms.Panel
    Friend WithEvents lblROMDownload As System.Windows.Forms.Label
    Friend WithEvents lblDeviceInfo As System.Windows.Forms.Label
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents LblFlashStatus As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents lblROMDownloadName As System.Windows.Forms.Label
    Friend WithEvents lblROMTotal As System.Windows.Forms.Label
    Friend WithEvents barTotal As ROMKitchenHelper.NSProgressBar
    Friend WithEvents lblKernelDownload As System.Windows.Forms.Label
    Friend WithEvents lblKernelTotal As System.Windows.Forms.Label
    Friend WithEvents lblKernelDownloadName As System.Windows.Forms.Label
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents NsProgressBar2 As ROMKitchenHelper.NSProgressBar
    Friend WithEvents LblFlashStatus1 As System.Windows.Forms.Label
    Friend WithEvents lblDeviceInfo1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
