Public Class Form1

   



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
     
        Dim myurl As String
        Dim winhttpreq As Object
        myurl = "http://192.168.0.104:8090/SendSMS?username=test&pass=1111&phone&00218944506368&message=hello"
        winhttpreq = CreateObject("WinHttp.WinHttpRequest.5.1", )
        winhttpreq.open("POST", myurl, False)
        winhttpreq.send()
    End Sub
End Class
