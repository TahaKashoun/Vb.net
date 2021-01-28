Imports System.Security.Cryptography
Imports System.Text.Encoding
Imports System.Net

Public Class Form1

    Dim has As String = "Pass123"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txt() As Byte = UTF8.GetBytes(TextBox1.Text)
        Dim md5 As New MD5CryptoServiceProvider
        Dim keymd5() As Byte = md5.ComputeHash(UTF8.GetBytes(has))
        Dim trip As New TripleDESCryptoServiceProvider
        trip.Mode = CipherMode.ECB
        trip.Key = keymd5
        trip.Padding = PaddingMode.PKCS7
        Dim trans As ICryptoTransform = trip.CreateEncryptor
        Dim result() As Byte = trans.TransformFinalBlock(txt, 0, txt.Length)
        TextBox2.Text = System.Convert.ToBase64String(result, 0, result.Length)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim txt() As Byte = System.Convert.FromBase64String(TextBox2.Text)
        Dim md5 As New MD5CryptoServiceProvider
        Dim keymd5() As Byte = md5.ComputeHash(UTF8.GetBytes(has))
        Dim trip As New TripleDESCryptoServiceProvider
        trip.Mode = CipherMode.ECB
        trip.Key = keymd5
        trip.Padding = PaddingMode.PKCS7
        Dim trans As ICryptoTransform = trip.CreateDecryptor
        Dim result() As Byte = trans.TransformFinalBlock(txt, 0, txt.Length)
        TextBox3.Text = UTF8.GetString(result)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        TextBox1.Focus()

    End Sub



End Class
