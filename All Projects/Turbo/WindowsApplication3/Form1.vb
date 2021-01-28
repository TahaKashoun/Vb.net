Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Text.RegularExpressions
Imports xNet

Public Class Form1
    Dim status As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim flag As Boolean = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(L0N3LY.api.smethod_0(Me.TextBox1.Text, TextBox2.Text)))) AndAlso Convert.ToBoolean(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(L0N3LY.smethod_3)))
        If flag Then
            runall()
        End If
    End Sub
    Sub runall()
        Dim a As New Thread(AddressOf Checkusername)
        a.Start()
    End Sub
    Private Function SwapUsername(username As String) As Boolean
        Using swap As New HttpRequest
            swap.AddHeader("User-Agent", "Instagram 20.6.4 Android (18/4.3; 480dpi; 1080x1812; HUAWEI; HUAWEI VNS-L31; HWVNS-H; hi6250; es_ES)")
            swap.AddHeader("Cookie", L0N3LY.api.string_13)
            swap.AddHeader("X-IG-Connection-Type", "WIFI")
            swap.AddHeader("X-IG-Capabilities", "3ToAAA==")
            swap.AddParam("gender", "1")
            swap.AddParam("_csrftoken", "missing")
            swap.AddParam("_uuid", Guid.NewGuid().ToString().ToUpper())
            swap.AddParam("_uid", "3")
            swap.AddParam("external_url", "www.example.com")
            swap.AddParam("username", username)
            swap.AddParam("email", L0N3LY.api.string_5)
            swap.AddParam("phone_number", "")
            swap.AddParam("biography", "WORKED !!! ")
            swap.AddParam("first_name", "Please help")
            Dim a As String = swap.Post("https://i.instagram.com/api/v1/accounts/edit_profile/").ToString
            MsgBox("Done !!")
            status = True
        End Using
        Return Nothing
    End Function
    Private Function Checkusername() As Boolean
        While status = False
            Try
                Dim webclient As WebClient = New WebClient
                webclient.Headers.Add("User-Agent", "Instagram 20.6.4 Android (18/4.3; 480dpi; 1080x1812; HUAWEI; HUAWEI VNS-L31; HWVNS-H; hi6250; es_ES)")
                webclient.Headers.Add("Cookie", L0N3LY.api.string_13)
                webclient.Proxy = Nothing
                Dim response As String = webclient.DownloadString("https://i.instagram.com/api/v1/feed/user/" + TextBox3.Text + "/username/")

                If response.Contains("{""items"": [], ""num_results"": 0, ""status"": ""ok""}") Then
                    SwapUsername(TextBox3.Text)
                Else
                    TextBox5.Text += 1
                End If
            Catch ex As Exception
            End Try
            Thread.Sleep(Me.TextBox4.Text)
        End While
        Return Nothing
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub
End Class
