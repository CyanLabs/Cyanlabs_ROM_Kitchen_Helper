Imports System.Net
Imports RegawMOD.Android

Public Class Form1
    Dim android As AndroidController
    Dim device As Device
    Dim FastbootCMD As FastbootCommand
    Dim CommandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
    Dim ROMDownload As New WebClient
    Dim KernelDownload As New WebClient
    Dim FullURI As String = ""
    Dim ROMURI As String = ""
    Dim KernelFilename As String = ""
    Dim ROMFilename As String = ""
    Dim KernelURI As String = ""

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Functions.WriteRegistryHandler() 'Write protocol/intent
        If Not IO.Directory.Exists(Application.StartupPath & "\Downloads\") Then IO.Directory.CreateDirectory(Application.StartupPath & "\Downloads\")
        Try
            If CommandLineArgs(0).Contains("http://kitchen.cyanlabs.co.uk/") AndAlso CommandLineArgs(0).Contains("|") Then
                AddHandler ROMDownload.DownloadProgressChanged, AddressOf ROMDownloadProgressChanged
                AddHandler ROMDownload.DownloadFileCompleted, AddressOf ROMDownloadCompleted
                FullURI = CommandLineArgs(0)
                Dim FullURIArray As String() = FullURI.Replace("cyanlabsromkitchen:", "").Split("|")

                ROMURI = FullURIArray(0)
                KernelURI = FullURIArray(1)
                ROMFilename = ROMURI.Substring(ROMURI.LastIndexOf("/") + 1).Replace("%20", " ")
                KernelFilename = KernelURI.Substring(KernelURI.LastIndexOf("/") + 1).Replace("%20", " ")

                Debug.WriteLine("ROM URI: " & ROMURI)
                Debug.WriteLine("Kernel URI: " & KernelURI)

                ROMDownload.DownloadFileAsync(New Uri(ROMURI), Application.StartupPath & "\Downloads\" & ROMFilename)
                lblROMDownloadName.Text = "Downloading ROM: " & ROMFilename.Replace(".zip", "").Substring(0, ROMFilename.LastIndexOf("_"))
            Else
                Debug.WriteLine("Invalid parameter, Application exiting.")
                MsgBox("URL Protocol added to registry, Use ""Flash N Download"" button on Cyanlabs ROM kitchen to launch application correctly.", MsgBoxStyle.Information, "Notice")
                Application.Exit()
            End If
        Catch
            Application.Exit()
        End Try
    End Sub
    Sub VerifyROM()
        barTotal.Value = 2
        Dim RemoteROMMD5 As String = ""
        Dim LocalROMMD5 As String = GetMD5(Application.StartupPath & "\Downloads\" & ROMFilename)

        Try
            RemoteROMMD5 = KernelDownload.DownloadString(New Uri(KernelURI & ".md5")).ToUpper
        Catch
            RemoteROMMD5 = "nomd5"
            Debug.WriteLine("Skipping MD5 check no remote file found")
        End Try

        Debug.WriteLine("Local ROM MD5: " & LocalROMMD5)
        Debug.WriteLine("Remote ROM  MD5: " & RemoteROMMD5)

        If LocalROMMD5 = RemoteROMMD5 Or RemoteROMMD5 = "nomd5" Then
            VerifyKernel()
        Else
            MsgBox("ROM checksums do not match", MsgBoxStyle.Critical, "Checksum Mismatch")
        End If
    End Sub

    Sub VerifyKernel()
        Dim RemoteKernelMD5 As String = ""
        Dim LocalKernelMD5 As String = GetMD5(Application.StartupPath & "\Downloads\" & KernelFilename)
        Try
            RemoteKernelMD5 = KernelDownload.DownloadString(New Uri(KernelURI & ".md5")).ToUpper
        Catch
            RemoteKernelMD5 = "nomd5"
            Debug.WriteLine("Skipping MD5 check no remote file found")
        End Try

        Debug.WriteLine("Local Kernel MD5: " & LocalKernelMD5)
        Debug.WriteLine("Remote Kernel MD5: " & RemoteKernelMD5)

        If LocalKernelMD5 = RemoteKernelMD5 Or remotekernelmd5 = "nomd5" Then
            PictureBox2.Visible = False
            PictureBox4.Visible = True
            txtRecovery.ForeColor = Color.White
            barTotal.Value = 3
            pnlKernel.Visible = False
            pnlRecovery.Visible = True
            Threading.Thread.Sleep(2000)
            Functions.InstallROM(KernelFilename, ROMFilename)
        Else
            MsgBox("Kernel checksums do not match", MsgBoxStyle.Critical, "Checksum Mismatch")
        End If
    End Sub

    Sub DownloadKernel()
        pnlROM.Visible = False
        pnlKernel.Visible = True
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        txtKernel.ForeColor = Color.White
        barTotal.Value = 1

        AddHandler KernelDownload.DownloadProgressChanged, AddressOf KernelDownloadProgressChanged
        AddHandler KernelDownload.DownloadFileCompleted, AddressOf KernelDownloadCompleted
        lblKernelDownloadName.Text = "Downloading Kernel: " & KernelFilename.Replace(".zip", "")
        KernelDownload.DownloadFileAsync(New Uri(KernelURI), Application.StartupPath & "\Downloads\" & KernelFilename)
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        sender.forecolor = Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        sender.forecolor = Color.DimGray
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MsgBox("Help coming soon" & vbNewLine & vbNewLine & "Cyanlabs ROM Kitchen and Cyanlabs ROM Kitchen Helper Application are created by Cyanlabs." & vbNewLine & vbNewLine & "Cyanlabs ROM Kitchen and Cyanlabs ROM Kitchen Helper Application were created to make it easier to install a ROM and Kernel" & vbNewLine & vbNewLine & "Only for the Xperia Play currently however it will be expanding to more devices soon.", MsgBoxStyle.Information, "Help and About")
    End Sub
End Class
