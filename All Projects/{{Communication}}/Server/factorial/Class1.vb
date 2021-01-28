Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Threading

Public Class Class1
    Public Event messagereceived(sender As Class1, txt As String)
    Public serverip As IPAddress = IPAddress.Parse("192.168.0.120")
    Public serverport As Integer = 64555
    Public server As TcpListener
    Public islisenting As Boolean = True
    Private commthrade As Thread
    'clients 
    Private clients As TcpClient
    Private clientdata As StreamReader


    Public Sub New()
        server = New TcpListener(serverip, serverport)
        server.Start()
        commthrade = New Thread(AddressOf listening)
        commthrade.Start()


    End Sub
    Sub listening()
        ' create listener loop
        Do Until islisenting = False
            ' accrept incoming connections
            If server.Pending = True Then
                clients = server.AcceptTcpClient
                clientdata = New StreamReader(clients.GetStream())


            End If
            ' Raise Event
            Try
                RaiseEvent messagereceived(Me, clientdata.ReadLine())
            Catch ex As Exception
            End Try
            Thread.Sleep(100)
        Loop
    End Sub
End Class
