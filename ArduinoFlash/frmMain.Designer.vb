<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.lblLblFile = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSelectFile = New System.Windows.Forms.Button()
        Me.dudCom = New System.Windows.Forms.DomainUpDown()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.txbLog = New System.Windows.Forms.TextBox()
        Me.btnFlash = New System.Windows.Forms.Button()
        Me.lblCPU = New System.Windows.Forms.Label()
        Me.dudCPU = New System.Windows.Forms.DomainUpDown()
        Me.chbDCMF = New System.Windows.Forms.CheckBox()
        Me.chbOFD = New System.Windows.Forms.CheckBox()
        Me.tlpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.AutoSize = True
        Me.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpMain.ColumnCount = 3
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.Controls.Add(Me.lblLblFile, 0, 0)
        Me.tlpMain.Controls.Add(Me.Label2, 0, 1)
        Me.tlpMain.Controls.Add(Me.btnSelectFile, 2, 0)
        Me.tlpMain.Controls.Add(Me.dudCom, 1, 1)
        Me.tlpMain.Controls.Add(Me.lblFile, 1, 0)
        Me.tlpMain.Controls.Add(Me.txbLog, 1, 6)
        Me.tlpMain.Controls.Add(Me.btnFlash, 1, 5)
        Me.tlpMain.Controls.Add(Me.lblCPU, 0, 2)
        Me.tlpMain.Controls.Add(Me.dudCPU, 1, 2)
        Me.tlpMain.Controls.Add(Me.chbDCMF, 1, 3)
        Me.tlpMain.Controls.Add(Me.chbOFD, 1, 4)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 7
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Size = New System.Drawing.Size(624, 441)
        Me.tlpMain.TabIndex = 0
        '
        'lblLblFile
        '
        Me.lblLblFile.AutoSize = True
        Me.lblLblFile.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblLblFile.Location = New System.Drawing.Point(18, 0)
        Me.lblLblFile.Name = "lblLblFile"
        Me.lblLblFile.Size = New System.Drawing.Size(32, 29)
        Me.lblLblFile.TabIndex = 0
        Me.lblLblFile.Text = "FILE:"
        Me.lblLblFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Location = New System.Drawing.Point(3, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PORTA:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSelectFile
        '
        Me.btnSelectFile.AutoSize = True
        Me.btnSelectFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSelectFile.Location = New System.Drawing.Point(595, 3)
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.Size = New System.Drawing.Size(26, 23)
        Me.btnSelectFile.TabIndex = 2
        Me.btnSelectFile.Text = "..."
        Me.btnSelectFile.UseVisualStyleBackColor = True
        '
        'dudCom
        '
        Me.dudCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dudCom.Dock = System.Windows.Forms.DockStyle.Top
        Me.dudCom.Location = New System.Drawing.Point(56, 32)
        Me.dudCom.Name = "dudCom"
        Me.dudCom.ReadOnly = True
        Me.dudCom.Size = New System.Drawing.Size(533, 20)
        Me.dudCom.TabIndex = 4
        Me.dudCom.Text = "NESSUNA PORTA PRESENTE"
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFile.Location = New System.Drawing.Point(56, 0)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(533, 29)
        Me.lblFile.TabIndex = 5
        Me.lblFile.Text = "NESSUN FILE SELEZIONATO"
        Me.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txbLog
        '
        Me.txbLog.BackColor = System.Drawing.SystemColors.Window
        Me.txbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txbLog.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbLog.Location = New System.Drawing.Point(56, 159)
        Me.txbLog.Multiline = True
        Me.txbLog.Name = "txbLog"
        Me.txbLog.ReadOnly = True
        Me.txbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txbLog.Size = New System.Drawing.Size(533, 279)
        Me.txbLog.TabIndex = 6
        '
        'btnFlash
        '
        Me.btnFlash.AutoSize = True
        Me.btnFlash.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFlash.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFlash.Location = New System.Drawing.Point(56, 130)
        Me.btnFlash.Name = "btnFlash"
        Me.btnFlash.Size = New System.Drawing.Size(533, 23)
        Me.btnFlash.TabIndex = 7
        Me.btnFlash.Text = "FLASH"
        Me.btnFlash.UseVisualStyleBackColor = True
        '
        'lblCPU
        '
        Me.lblCPU.AutoSize = True
        Me.lblCPU.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblCPU.Location = New System.Drawing.Point(18, 55)
        Me.lblCPU.Name = "lblCPU"
        Me.lblCPU.Size = New System.Drawing.Size(32, 26)
        Me.lblCPU.TabIndex = 8
        Me.lblCPU.Text = "CPU:"
        Me.lblCPU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dudCPU
        '
        Me.dudCPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dudCPU.Dock = System.Windows.Forms.DockStyle.Top
        Me.dudCPU.Location = New System.Drawing.Point(56, 58)
        Me.dudCPU.Name = "dudCPU"
        Me.dudCPU.ReadOnly = True
        Me.dudCPU.Size = New System.Drawing.Size(533, 20)
        Me.dudCPU.TabIndex = 9
        Me.dudCPU.Text = "SELEZIONA LA CPU"
        '
        'chbDCMF
        '
        Me.chbDCMF.AutoSize = True
        Me.chbDCMF.Checked = True
        Me.chbDCMF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbDCMF.Location = New System.Drawing.Point(56, 84)
        Me.chbDCMF.Name = "chbDCMF"
        Me.chbDCMF.Size = New System.Drawing.Size(298, 17)
        Me.chbDCMF.TabIndex = 10
        Me.chbDCMF.Text = "Disabilita la cancellazione automatica per la memoria flash"
        Me.chbDCMF.UseVisualStyleBackColor = True
        '
        'chbOFD
        '
        Me.chbOFD.AutoSize = True
        Me.chbOFD.Location = New System.Drawing.Point(56, 107)
        Me.chbOFD.Name = "chbOFD"
        Me.chbOFD.Size = New System.Drawing.Size(135, 17)
        Me.chbOFD.TabIndex = 11
        Me.chbOFD.Text = "Output flash dettagliato"
        Me.chbOFD.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.tlpMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arduino Flash"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents lblLblFile As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSelectFile As Button
    Friend WithEvents dudCom As DomainUpDown
    Friend WithEvents lblFile As Label
    Friend WithEvents txbLog As TextBox
    Friend WithEvents btnFlash As Button
    Friend WithEvents lblCPU As Label
    Friend WithEvents dudCPU As DomainUpDown
    Friend WithEvents chbDCMF As CheckBox
    Friend WithEvents chbOFD As CheckBox
End Class
