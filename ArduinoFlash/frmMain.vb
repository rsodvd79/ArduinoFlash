Public Class frmMain
    Dim blnFile As Boolean = False
    Dim blnCom As Boolean = False
    Dim blnCpu As Boolean = False

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        blnFile = False
        blnCom = False
        blnCpu = False

        dudCom.Items.Clear()

        For Each sp As String In My.Computer.Ports.SerialPortNames
            dudCom.Items.Add(sp)

        Next

        If dudCom.Items.Count > 0 Then
            dudCom.SelectedIndex = 0

        End If

        dudCPU.Items.Clear()
        dudCPU.Items.Add("ATmega328P")
        dudCPU.SelectedIndex = 0

    End Sub

    Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click
        Dim frmX As New OpenFileDialog With {
            .Filter = "*.HEX|*.HEX",
            .Multiselect = False
        }

        If frmX.ShowDialog(Me) = DialogResult.OK Then
            lblFile.Text = frmX.FileName
            blnFile = True

        Else
            lblFile.Text = "NESSUN FILE SELEZIONATO"
            blnFile = False

        End If

    End Sub

    Private Sub btnFlash_Click(sender As Object, e As EventArgs) Handles btnFlash.Click

        If Not blnFile Then
            txbLog.Text = "File HEX non selezionato!"

        ElseIf Not blnCom Then
            txbLog.Text = "Porta non selezionata!"

        ElseIf Not blnCpu Then
            txbLog.Text = "CPU non selezionata!"

        Else
            txbLog.Text = String.Empty

            Dim strArg As String = $"-C ""{ My.Application.Info.DirectoryPath }\avr\etc\avrdude.conf"" -p { dudCPU.SelectedItem.ToString.ToLower } -c arduino -P { dudCom.SelectedItem.ToString } -b 115200 -U flash:w:""{ lblFile.Text }"":i"

            If chbOFD.Checked Then
                strArg &= " -v"

            End If

            If chbDCMF.Checked Then
                strArg &= " -D"

            End If

            Dim psiX As New ProcessStartInfo With {
                .FileName = My.Application.Info.DirectoryPath & "\avr\bin\avrdude.exe",
                .Arguments = strArg,
                .WorkingDirectory = My.Application.Info.DirectoryPath & "\avr\bin",
                .WindowStyle = ProcessWindowStyle.Hidden,
                .RedirectStandardError = True,
                .RedirectStandardOutput = True,
                .UseShellExecute = False,
                .CreateNoWindow = True
            }

            Dim prcX As New Process() With {
                .EnableRaisingEvents = True,
                .StartInfo = psiX
            }

            AddHandler prcX.ErrorDataReceived, AddressOf proc_OutputDataReceived
            AddHandler prcX.OutputDataReceived, AddressOf proc_OutputDataReceived

            prcX.Start()

            prcX.BeginErrorReadLine()
            prcX.BeginOutputReadLine()

        End If

    End Sub

    Delegate Sub UpdateTextBoxDelg(text As String)
    Public myDelegate As UpdateTextBoxDelg = New UpdateTextBoxDelg(AddressOf UpdateTextBox)
    Public Sub UpdateTextBox(text As String)
        txbLog.Text += text & Environment.NewLine
        txbLog.SelectionStart = txbLog.Text.Length
        txbLog.ScrollToCaret()

    End Sub

    Public Sub proc_OutputDataReceived(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        If InvokeRequired = True Then
            Invoke(myDelegate, e.Data)

        Else
            UpdateTextBox(e.Data)

        End If

    End Sub

    Private Sub dudCom_SelectedItemChanged(sender As Object, e As EventArgs) Handles dudCom.SelectedItemChanged
        blnCom = True

    End Sub

    Private Sub dudCPU_SelectedItemChanged(sender As Object, e As EventArgs) Handles dudCPU.SelectedItemChanged
        blnCpu = True

    End Sub
End Class
