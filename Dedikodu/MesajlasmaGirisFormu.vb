Imports System.Windows.Forms
Imports System.Net
Public Class MesajlasmaGirisFormu
    Public Tara As Boolean = True
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If IPAdresimizComboBox.SelectedIndex > -1 Then
            If TakmaAdimizTextBox.Text.Trim.Length >= 3 Then
                If MesajlasilacakPCComboBox.Text.Trim.Length > 0 Then
                    Dim IPAdresimiz, BilgisayarAdimiz, MesajlasilacakPCIPAdresi, MesajlasilacakPC, TakmaAdimiz As String
                    IPAdresimiz = IPAdresimizComboBox.SelectedItem.ToString
                    BilgisayarAdimiz = Dns.GetHostName
                    TakmaAdimiz = TakmaAdimizTextBox.Text.Trim
                    MesajlasilacakPC = MesajlasilacakPCComboBox.Text.Trim
                    Dim PCIPAdresleri() As IPAddress = Dns.GetHostByName(MesajlasilacakPC).AddressList
                    Dim IPUcBolum As String = IPAdresimiz.Substring(0, IPAdresimiz.LastIndexOf("."))
                    MesajlasilacakPCIPAdresi = String.Empty
                    For Each Adres As IPAddress In PCIPAdresleri
                        If Adres.ToString.StartsWith(IPUcBolum) Then
                            MesajlasilacakPCIPAdresi = Adres.ToString
                        End If
                    Next
                    If Not String.IsNullOrEmpty(MesajlasilacakPCIPAdresi) Then
                        MesajAnaFormu.IPAdresimiz = IPAdresimiz
                        MesajAnaFormu.TakmaAdimiz = TakmaAdimiz
                        MesajAnaFormu.BilgisayarAdimiz = BilgisayarAdimiz
                        MesajAnaFormu.MesajlasilacakPCIPAdresi = MesajlasilacakPCIPAdresi

                        Me.DialogResult = System.Windows.Forms.DialogResult.OK
                        MesajAnaFormu.Show()
                        'PROJECT menüsünden Dedikodu Properties seçeneğinde açılan formdan Starup Form seçeneğini MesajlasmaGirisFormu
                        'Shutdown Mode özelliğini When Last Form Closes olarak değiştirdik
                        Me.Close()
                    Else
                        MsgBox("Bu program ile sadece aynı IP Bloğunda bulunduğunuz bilgisayarlar ile mesajlaşa bilirsiniz.")
                    End If
                Else
                    MsgBox("Mesajlaşılma yapacağınız Bilgisayarı seçiniz.")
                End If
            Else
                MsgBox("Mesajlaşmada kullanacağınız Takma Adınız en az 3 karakter olmalıdır.")
            End If
        Else
            MsgBox("Bilgisayarınız üzerinde mesajlaşılma yapılacak IP Adresinizi seçiniz.")
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub MesajlasmaGirisFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MesajlasilacakPCleriGetir(Tara)
        IPAdreslerimiGetir()
    End Sub
    Private Sub MesajlasilacakPCleriGetir(Optional TaramaYap As Boolean = True)
        If TaramaYap Then
            Dim Bilgisayarlar() As NetworkComputer = NetworkComputer.GetLocalNetwork
            MesajlasilacakPCComboBox.Items.Clear()
            For Each Bilgisayar As NetworkComputer In Bilgisayarlar
                MesajlasilacakPCComboBox.Items.Add(Bilgisayar.Name)
            Next
        End If
    End Sub
    Private Sub IPAdreslerimiGetir()
        'Dns nesnesini kullanmak için yukarıda Imports System.Net NameSpace'ini deklere ettik
        Dim BilgisayarAdi As String = Dns.GetHostName
        Dim IPAdreslerimiz() As IPAddress = Dns.GetHostByName(BilgisayarAdi).AddressList
        IPAdresimizComboBox.Items.Clear()
        IPAdresimizComboBox.DropDownStyle = ComboBoxStyle.DropDownList

        LabelBilgisayarAdimiz.Text = BilgisayarAdi
        For Each IPAdres As IPAddress In IPAdreslerimiz
            IPAdresimizComboBox.Items.Add(IPAdres)
        Next
        If IPAdresimizComboBox.Items.Count = 1 Then
            IPAdresimizComboBox.SelectedIndex = 0
        End If
    End Sub
End Class
