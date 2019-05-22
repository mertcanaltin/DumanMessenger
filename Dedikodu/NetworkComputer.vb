Imports System.Net
Imports System.DirectoryServices
'System.DirectoryServices için PROJECT menüsünden Add Reference dedikten sonra açılan listeden
'Framework içerisinde System.DirectoryServices seçeneğini bulduk ve başına check işareti koyarak ekledik

Public Class NetworkComputer
    Private Elemandomain As String
    Private Elemanname As String
    Private Elemanaddresses As IPAddress() = Nothing
    Public ReadOnly Property Domain As String
        Get
            Return Elemandomain
        End Get
    End Property
    Public ReadOnly Property Name As String
        Get
            Return Elemanname
        End Get
    End Property
    Public ReadOnly Property Addresses As IPAddress()
        Get
            Return Elemanaddresses
        End Get
    End Property
    Private Sub New(ByVal domain As String, ByVal name As String)
        Elemandomain = domain
        Elemanname = name
        Try
            Elemanaddresses = Dns.GetHostAddresses(name)
        Catch
        End Try
    End Sub
    Public Shared Function GetLocalNetwork() As NetworkComputer()
        Dim list = New List(Of NetworkComputer)()
        Using root = New DirectoryEntry("WinNT:")
            For Each Eleman As DirectoryEntry In root.Children.OfType(Of DirectoryEntry)()
                Select Case Eleman.SchemaClassName
                    Case "Computer"
                        list.Add(New NetworkComputer("", Eleman.Name))
                    Case "Domain"
                        list.AddRange(Eleman.Children.OfType(Of DirectoryEntry)().Where(Function(ElemanEleman) (ElemanEleman.SchemaClassName = "Computer")).[Select](Function(ElemanEleman) New NetworkComputer(Eleman.Name, ElemanEleman.Name)))
                End Select
            Next
        End Using

        Return list.OrderBy(Function(Eleman) Eleman.Domain).ThenBy(Function(Eleman) Eleman.Name).ToArray()
    End Function
    End Class

