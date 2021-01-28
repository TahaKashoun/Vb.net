Imports System.Net.Sockets
Imports System.Net
Imports System.IO

Public Class Class1
    Public client As TcpClient
    Public datastream As StreamWriter
    Public Sub New(host As String, port As Integer)
        client = New TcpClient(host, port)
        datastream = New StreamWriter(client.GetStream)

    End Sub
    Sub send(data As String)
        datastream.WriteLine(data)
        datastream.Flush()
    End Sub
End Class
