<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MesajlasmaGirisFormu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IPAdresimizComboBox = New System.Windows.Forms.ComboBox()
        Me.TakmaAdimizTextBox = New System.Windows.Forms.TextBox()
        Me.MesajlasilacakPCComboBox = New System.Windows.Forms.ComboBox()
        Me.LabelBilgisayarAdimiz = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(15, 115)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(324, 41)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(156, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Mesajlaşmaya &Başla"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(165, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(156, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "&Vazgeç"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IP Adresinizi Seçiniz:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Takma Adınız:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mesajlaşılacak Bilgisayar:"
        '
        'IPAdresimizComboBox
        '
        Me.IPAdresimizComboBox.FormattingEnabled = True
        Me.IPAdresimizComboBox.Location = New System.Drawing.Point(144, 35)
        Me.IPAdresimizComboBox.Name = "IPAdresimizComboBox"
        Me.IPAdresimizComboBox.Size = New System.Drawing.Size(192, 21)
        Me.IPAdresimizComboBox.TabIndex = 4
        '
        'TakmaAdimizTextBox
        '
        Me.TakmaAdimizTextBox.Location = New System.Drawing.Point(144, 62)
        Me.TakmaAdimizTextBox.Name = "TakmaAdimizTextBox"
        Me.TakmaAdimizTextBox.Size = New System.Drawing.Size(192, 20)
        Me.TakmaAdimizTextBox.TabIndex = 5
        '
        'MesajlasilacakPCComboBox
        '
        Me.MesajlasilacakPCComboBox.FormattingEnabled = True
        Me.MesajlasilacakPCComboBox.Location = New System.Drawing.Point(144, 88)
        Me.MesajlasilacakPCComboBox.Name = "MesajlasilacakPCComboBox"
        Me.MesajlasilacakPCComboBox.Size = New System.Drawing.Size(192, 21)
        Me.MesajlasilacakPCComboBox.TabIndex = 6
        '
        'LabelBilgisayarAdimiz
        '
        Me.LabelBilgisayarAdimiz.Location = New System.Drawing.Point(15, 6)
        Me.LabelBilgisayarAdimiz.Name = "LabelBilgisayarAdimiz"
        Me.LabelBilgisayarAdimiz.Size = New System.Drawing.Size(321, 23)
        Me.LabelBilgisayarAdimiz.TabIndex = 7
        Me.LabelBilgisayarAdimiz.Text = "Bilgisayarımız"
        Me.LabelBilgisayarAdimiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MesajlasmaGirisFormu
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(351, 168)
        Me.Controls.Add(Me.LabelBilgisayarAdimiz)
        Me.Controls.Add(Me.MesajlasilacakPCComboBox)
        Me.Controls.Add(Me.TakmaAdimizTextBox)
        Me.Controls.Add(Me.IPAdresimizComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MesajlasmaGirisFormu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dedikodu Mesaj Programına Hoşgeldiniz"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IPAdresimizComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TakmaAdimizTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MesajlasilacakPCComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LabelBilgisayarAdimiz As System.Windows.Forms.Label

End Class
