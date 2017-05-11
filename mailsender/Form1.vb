Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Net
Imports System.Net.Mail

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim message As New MailMessage
            Dim s As String
            Dim client As New SmtpClient
            message.From = New MailAddress(TextBox1.Text)
            message.Subject = TextBox2.Text
            message.Body = TextBox3.Text
            'For Each s In TextBox1.Text.Split(New Char() {';'c})
            message.To.Add(TextBox1.Text)
            'Next

            client.Credentials = New NetworkCredential(TextBox4.Text, TextBox5.Text)
            client.Host = "smtp.gmail.com"
            client.Port = 587
            client.EnableSsl = True
            client.Send(message)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        



    End Sub
End Class
