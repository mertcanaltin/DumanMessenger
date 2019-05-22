<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MesajAnaFormu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MesajAnaFormu))
        Me.StatusStripDedikodu = New System.Windows.Forms.StatusStrip()
        Me.AnaTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.BaslikTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TakmaAdLabel = New System.Windows.Forms.Label()
        Me.IPAdresimizLabel = New System.Windows.Forms.Label()
        Me.MesajlarRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.GonderimTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.GidenMesajRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DurumLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MesajGonderButton = New System.Windows.Forms.Button()
        Me.GirisDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MesajlaşılacakBilgisayarıDeğiştirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStripDedikodu.SuspendLayout()
        Me.AnaTableLayoutPanel.SuspendLayout()
        Me.BaslikTableLayoutPanel.SuspendLayout()
        Me.GonderimTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStripDedikodu
        '
        Me.StatusStripDedikodu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GirisDropDownButton, Me.DurumLabel})
        Me.StatusStripDedikodu.Location = New System.Drawing.Point(0, 492)
        Me.StatusStripDedikodu.Name = "StatusStripDedikodu"
        Me.StatusStripDedikodu.Size = New System.Drawing.Size(322, 22)
        Me.StatusStripDedikodu.TabIndex = 0
        Me.StatusStripDedikodu.Text = "StatusStrip1"
        '
        'AnaTableLayoutPanel
        '
        Me.AnaTableLayoutPanel.ColumnCount = 1
        Me.AnaTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AnaTableLayoutPanel.Controls.Add(Me.BaslikTableLayoutPanel, 0, 0)
        Me.AnaTableLayoutPanel.Controls.Add(Me.MesajlarRichTextBox, 0, 1)
        Me.AnaTableLayoutPanel.Controls.Add(Me.GonderimTableLayoutPanel, 0, 2)
        Me.AnaTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.AnaTableLayoutPanel.Name = "AnaTableLayoutPanel"
        Me.AnaTableLayoutPanel.RowCount = 3
        Me.AnaTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.AnaTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AnaTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.AnaTableLayoutPanel.Size = New System.Drawing.Size(322, 492)
        Me.AnaTableLayoutPanel.TabIndex = 1
        '
        'BaslikTableLayoutPanel
        '
        Me.BaslikTableLayoutPanel.ColumnCount = 1
        Me.BaslikTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BaslikTableLayoutPanel.Controls.Add(Me.TakmaAdLabel, 0, 0)
        Me.BaslikTableLayoutPanel.Controls.Add(Me.IPAdresimizLabel, 0, 1)
        Me.BaslikTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaslikTableLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.BaslikTableLayoutPanel.Name = "BaslikTableLayoutPanel"
        Me.BaslikTableLayoutPanel.RowCount = 2
        Me.BaslikTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BaslikTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BaslikTableLayoutPanel.Size = New System.Drawing.Size(316, 44)
        Me.BaslikTableLayoutPanel.TabIndex = 0
        '
        'TakmaAdLabel
        '
        Me.TakmaAdLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TakmaAdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TakmaAdLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.TakmaAdLabel.Location = New System.Drawing.Point(3, 0)
        Me.TakmaAdLabel.Name = "TakmaAdLabel"
        Me.TakmaAdLabel.Size = New System.Drawing.Size(310, 22)
        Me.TakmaAdLabel.TabIndex = 0
        Me.TakmaAdLabel.Text = "Takma Ad"
        Me.TakmaAdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IPAdresimizLabel
        '
        Me.IPAdresimizLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IPAdresimizLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.IPAdresimizLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.IPAdresimizLabel.Location = New System.Drawing.Point(3, 22)
        Me.IPAdresimizLabel.Name = "IPAdresimizLabel"
        Me.IPAdresimizLabel.Size = New System.Drawing.Size(310, 22)
        Me.IPAdresimizLabel.TabIndex = 1
        Me.IPAdresimizLabel.Text = "127.0.0.1 (BİLGİSAYAR ADI)"
        Me.IPAdresimizLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MesajlarRichTextBox
        '
        Me.MesajlarRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MesajlarRichTextBox.Location = New System.Drawing.Point(3, 53)
        Me.MesajlarRichTextBox.Name = "MesajlarRichTextBox"
        Me.MesajlarRichTextBox.ReadOnly = True
        Me.MesajlarRichTextBox.Size = New System.Drawing.Size(316, 361)
        Me.MesajlarRichTextBox.TabIndex = 1
        Me.MesajlarRichTextBox.TabStop = False
        Me.MesajlarRichTextBox.Text = ""
        '
        'GonderimTableLayoutPanel
        '
        Me.GonderimTableLayoutPanel.ColumnCount = 2
        Me.GonderimTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GonderimTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.GonderimTableLayoutPanel.Controls.Add(Me.GidenMesajRichTextBox, 0, 0)
        Me.GonderimTableLayoutPanel.Controls.Add(Me.MesajGonderButton, 1, 0)
        Me.GonderimTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GonderimTableLayoutPanel.Location = New System.Drawing.Point(3, 420)
        Me.GonderimTableLayoutPanel.Name = "GonderimTableLayoutPanel"
        Me.GonderimTableLayoutPanel.RowCount = 1
        Me.GonderimTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GonderimTableLayoutPanel.Size = New System.Drawing.Size(316, 69)
        Me.GonderimTableLayoutPanel.TabIndex = 2
        '
        'GidenMesajRichTextBox
        '
        Me.GidenMesajRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GidenMesajRichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GidenMesajRichTextBox.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GidenMesajRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.GidenMesajRichTextBox.Name = "GidenMesajRichTextBox"
        Me.GidenMesajRichTextBox.Size = New System.Drawing.Size(250, 63)
        Me.GidenMesajRichTextBox.TabIndex = 0
        Me.GidenMesajRichTextBox.Text = ""
        '
        'DurumLabel
        '
        Me.DurumLabel.Name = "DurumLabel"
        Me.DurumLabel.Size = New System.Drawing.Size(0, 17)
        '
        'MesajGonderButton
        '
        Me.MesajGonderButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MesajGonderButton.Image = Global.Dedikodu.My.Resources.Resources.MesajGonder
        Me.MesajGonderButton.Location = New System.Drawing.Point(259, 3)
        Me.MesajGonderButton.Name = "MesajGonderButton"
        Me.MesajGonderButton.Size = New System.Drawing.Size(54, 63)
        Me.MesajGonderButton.TabIndex = 1
        Me.MesajGonderButton.UseVisualStyleBackColor = True
        '
        'GirisDropDownButton
        '
        Me.GirisDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GirisDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MesajlaşılacakBilgisayarıDeğiştirToolStripMenuItem})
        Me.GirisDropDownButton.Image = Global.Dedikodu.My.Resources.Resources.Mesaj
        Me.GirisDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GirisDropDownButton.Name = "GirisDropDownButton"
        Me.GirisDropDownButton.Size = New System.Drawing.Size(29, 20)
        Me.GirisDropDownButton.Text = "ToolStripDropDownButton1"
        '
        'MesajlaşılacakBilgisayarıDeğiştirToolStripMenuItem
        '
        Me.MesajlaşılacakBilgisayarıDeğiştirToolStripMenuItem.Name = "MesajlaşılacakBilgisayarıDeğiştirToolStripMenuItem"
        Me.MesajlaşılacakBilgisayarıDeğiştirToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.MesajlaşılacakBilgisayarıDeğiştirToolStripMenuItem.Text = "Mesajlaşılacak Bilgisayarı Değiştir"
        '
        'MesajAnaFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 514)
        Me.Controls.Add(Me.AnaTableLayoutPanel)
        Me.Controls.Add(Me.StatusStripDedikodu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MesajAnaFormu"
        Me.Text = "Dedikodu Mesajlaşma Programı"
        Me.StatusStripDedikodu.ResumeLayout(False)
        Me.StatusStripDedikodu.PerformLayout()
        Me.AnaTableLayoutPanel.ResumeLayout(False)
        Me.BaslikTableLayoutPanel.ResumeLayout(False)
        Me.GonderimTableLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStripDedikodu As System.Windows.Forms.StatusStrip
    Friend WithEvents GirisDropDownButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents DurumLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AnaTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BaslikTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TakmaAdLabel As System.Windows.Forms.Label
    Friend WithEvents IPAdresimizLabel As System.Windows.Forms.Label
    Friend WithEvents MesajlarRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents GonderimTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GidenMesajRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents MesajGonderButton As System.Windows.Forms.Button
    Friend WithEvents MesajlaşılacakBilgisayarıDeğiştirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
