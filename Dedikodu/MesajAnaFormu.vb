Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Public Class MesajAnaFormu
    Public IPAdresimiz, BilgisayarAdimiz, MesajlasilacakPCIPAdresi, TakmaAdimiz As String
    Private TCPDinleme As TcpListener
    Private DinlemeKanali As Thread

    Private Sub MesajAnaFormu_InputLanguageChanging(sender As Object, e As InputLanguageChangingEventArgs) Handles Me.InputLanguageChanging
        TCPDinleme.Stop()
        DinlemeKanali.Abort()
    End Sub
    Private Sub MesajAnaFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TakmaAdLabel.Text = TakmaAdimiz
        IPAdresimizLabel.Text = String.Format("{0} ({1})", IPAdresimiz, BilgisayarAdimiz)
        DinlemeKanali = New Thread(AddressOf Dinle)
        DinlemeKanali.Priority = ThreadPriority.Normal
        DinlemeKanali.Start()
    End Sub

    Private Sub Dinle()
        Try
            Dim IP_Adresimiz As IPAddress = IPAddress.Parse(IPAdresimiz)
            TCPDinleme = New TcpListener(IP_Adresimiz, 15000)
            TCPDinleme.Start()
            Dim TCPistemci As TcpClient
            Dim GelenMesaj As String = String.Empty
            While True
                TCPistemci = TCPDinleme.AcceptTcpClient
                Dim Akar As NetworkStream = TCPistemci.GetStream
                If Akar.CanRead Then
                    Dim Okunan(TCPistemci.ReceiveBufferSize) As Byte
                    Akar.Read(Okunan, 0, Okunan.Length)
                    GelenMesaj = Encoding.UTF8.GetString(Okunan) & vbCrLf
                    SetText(GelenMesaj & vbCrLf)
                End If
            End While
        Catch ex As Exception
        End Try
    End Sub

    Delegate Sub SetTextCallBack([Text] As String)
    Private Sub SetText([Text] As String)
        If Me.MesajlarRichTextBox.InvokeRequired Then
            Dim D As New SetTextCallBack(AddressOf SetText)
            Me.Invoke(D, New Object() {[Text]})
        Else
            Me.MesajlarRichTextBox.Text &= [Text] & vbCrLf
        End If
    End Sub

    Private Sub MesajGonderButton_Click(sender As Object, e As EventArgs) Handles MesajGonderButton.Click
        Try
            Dim Mesaj As String = GidenMesajRichTextBox.Text.Trim
            Mesaj = String.Format("{0}: {1} ({2}){3}", TakmaAdimiz, Mesaj, BilgisayarAdimiz, vbCrLf)
            Dim ByteMesaj() As Byte = Encoding.UTF8.GetBytes(Mesaj)
            Dim TCPistemci As New TcpClient(MesajlasilacakPCIPAdresi, 15000)
            Dim Akar As NetworkStream = TCPistemci.GetStream
            If Akar.CanWrite Then
                Akar.Write(ByteMesaj, 0, ByteMesaj.Length)
            End If
            GidenMesajRichTextBox.Clear()
            GidenMesajRichTextBox.Focus()
            Dim Fontumuz As Font = GidenMesajRichTextBox.Font
            MesajlarRichTextBox.SelectionFont = Fontumuz
            MesajlarRichTextBox.Text &= Mesaj
        Catch ex As Exception
            DurumLabel.Text = "Hata Oluştu. Hata: " & ex.Message
        End Try
    End Sub

    Private Sub MesajlaşılacakBilgisayarıDeğiştirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MesajlaşılacakBilgisayarıDeğiştirToolStripMenuItem.Click
        MesajlasmaGirisFormu.ShowDialog(Me)
    End Sub
End Class
