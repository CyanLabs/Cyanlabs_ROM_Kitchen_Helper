Imports Microsoft.Win32
Imports System.Net
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports RegawMOD.Android

Public Module Functions
    Dim android As AndroidController
    Dim device As Device
    Dim FastbootCMD As FastbootCommand
    Dim AdbCMD As AdbCommand

    Sub WriteRegistryHandler()
        Registry.CurrentUser.CreateSubKey("Software\Classes\cyanlabsromkitchen\Shell\Open\Command")
        Registry.CurrentUser.OpenSubKey("Software\Classes\cyanlabsromkitchen", True).SetValue("", "URL:cyanlabsromkitchen protocol")
        Registry.CurrentUser.OpenSubKey("Software\Classes\cyanlabsromkitchen", True).SetValue("URL Protocol", "")
        Registry.CurrentUser.OpenSubKey("Software\Classes\cyanlabsromkitchen\Shell\Open\Command", True).SetValue("", """" & Application.ExecutablePath & """ ""%1""")
    End Sub

    Sub DeleteRegistryHandler()
        Registry.CurrentUser.DeleteSubKeyTree("Software\Classes\cyanlabsromkitchen")
    End Sub

    Sub ROMDownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Form1.NsProgressBar1.Value = e.ProgressPercentage
        Dim recieved As Double = Format((e.BytesReceived / 1024) / 1024, "###,###,##0.00")
        Dim total As Double = Format((e.TotalBytesToReceive / 1024) / 1024, "###,###,##0.00")
        Form1.lblROMTotal.Text = String.Format("File Size: {0}MB", total)
        Form1.lblROMDownload.Text = String.Format("{0}% Complete", e.ProgressPercentage.ToString)
    End Sub
    Sub ROMDownloadCompleted(ByVal sender As Object, ByVal e As EventArgs)
            Form1.DownloadKernel()
    End Sub

    Sub KernelDownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Form1.NsProgressBar2.Value = e.ProgressPercentage
        Dim recieved As Double = Format((e.BytesReceived / 1024) / 1024, "###,###,##0.00")
        Dim total As Double = Format((e.TotalBytesToReceive / 1024) / 1024, "###,###,##0.00")
        Form1.lblKernelTotal.Text = String.Format("File Size: {0}MB", total)
        Form1.lblKernelDownload.Text = String.Format("{0}% Complete", e.ProgressPercentage.ToString)
    End Sub
    Sub KernelDownloadCompleted(ByVal sender As Object, ByVal e As EventArgs)
            Form1.VerifyROM()
    End Sub

    Function GetMD5(ByVal filePath As String)
        Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
        Dim f As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        f = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        md5.ComputeHash(f)
        f.Close()
        Dim hash As Byte() = md5.Hash
        Dim buff As StringBuilder = New StringBuilder
        Dim hashByte As Byte
        For Each hashByte In hash
            buff.Append(String.Format("{0:X2}", hashByte))
        Next
        Dim md5string As String
        md5string = buff.ToString()
        Return md5string
    End Function

    Sub FlashKernel(KernelFilename As String)
        android = AndroidController.Instance
        'android.WaitForDevice()
        If android.HasConnectedDevices Then
            device = android.GetConnectedDevice()
            Form1.lblDeviceInfo.Text = "Connected Device: " & device.SerialNumber
            If Not device.State = DeviceState.FASTBOOT Then device.RebootBootloader()
            If IsFastboot() = True Then
                FastbootCMD = Fastboot.FormFastbootCommand(device, "flash", "boot """ & Application.StartupPath & "\Downloads\" & KernelFilename & """")
                Dim fastbootresult As String = Fastboot.ExecuteFastbootCommand(FastbootCMD)
                Debug.WriteLine(fastbootresult)
                If fastbootresult.Contains("finished. total time: ") Then
                    Form1.LblFlashStatus.Text = KernelFilename & " has been flashed successfully"
                    Form1.PictureBox10.Image = My.Resources.android_success
                    Form1.PictureBox5.Visible = False
                    Form1.PictureBox6.Visible = True
                    Form1.txtFinished.ForeColor = Color.White
                    Form1.barTotal.Value = 5
                    Form1.pnlFlash.Visible = False
                    Form1.pnlFinished.Visible = True
                    device.FastbootReboot()
                Else
                    Form1.LblFlashStatus.Text = "An error occured while flashing " & KernelFilename
                    Form1.PictureBox10.Image = My.Resources.android_fail
                End If
            End If
            android.Dispose()
        End If
    End Sub
    Sub InstallROM(KernelFilename As String, ROMFilename As String)
        Form1.pnlRecovery.Visible = True
        android = AndroidController.Instance
        'android.WaitForDevice()
        If android.HasConnectedDevices Then
            device = android.GetConnectedDevice()
            Form1.lblDeviceInfo1.Text = "Connected Device: " & device.SerialNumber
            If device.State = DeviceState.FASTBOOT Then
                device.FastbootReboot()
            Else
                device.RebootRecovery()
            End If
            If IsRecovery() = True Then
                'Adb.ExecuteAdbCommand(Adb.FormAdbCommand("rm -rf /sdcard/CyanlabsRomKitchen/" & ROMFilename))
                If device.PushFile(Application.StartupPath & "\Downloads\" & ROMFilename, "/sdcard/CyanlabsRomKitchen/" & ROMFilename) Then
                    AdbCMD = Adb.FormAdbCommand("recovery --update_package=" & "/sdcard/CyanlabsRomKitche/" & ROMFilename)
                    If Adb.ExecuteAdbCommandReturnExitCode(AdbCMD) = 1 Then
                        Form1.LblFlashStatus1.Text = ROMFilename & " has been flashed successfully"
                        Form1.PictureBox3.Image = My.Resources.android_success
                    Else
                        Form1.LblFlashStatus1.Text = "An error occured while flashing " & ROMFilename
                        Form1.PictureBox3.Image = My.Resources.android_fail
                    End If
                End If
            End If

            android.Dispose()
        End If

        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = True
        Form1.txtFlash.ForeColor = Color.White
        Form1.barTotal.Value = 4
        Form1.pnlRecovery.Visible = False
        Form1.pnlFlash.Visible = True

        Functions.FlashKernel(KernelFilename)

    End Sub

    Function IsFastboot()
        Threading.Thread.Sleep(3000)
        android.WaitForDevice()
        Device = android.GetConnectedDevice()
        If Not Device.State = DeviceState.FASTBOOT Then
            Threading.Thread.Sleep(1000)
            IsFastboot()
        Else
            Return True
            Exit Function
        End If
        Return False
    End Function

    Function IsRecovery()
        Threading.Thread.Sleep(3000)
        android.WaitForDevice()
        device = android.GetConnectedDevice()
        If Not device.State = DeviceState.RECOVERY Then
            Threading.Thread.Sleep(1000)
            IsRecovery()
        Else
            Return True
            Exit Function
        End If
        Return False
    End Function
End Module
