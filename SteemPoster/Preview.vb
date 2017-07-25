Imports System.IO
Imports System.Net
Imports System.Text

Public Class Preview
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim request As System.Net.WebRequest = System.Net.WebRequest.Create("https://moisescardona.me/steem/postToSteem/")
            request.Method = "POST"
            Dim postData As String = "title=" + Form1.Title.Text + "&body=" + Form1.Body.Text + "&author=" + Form1.AccountName.Text + "&permlink=" + Form1.Permalink.Text + "&tags=" + Form1.Tags.Text + "&pk=" + Form1.PK.Text
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()
            If responseFromServer = "ok" Then
                MessageBox.Show("Your post has been posted successfully.")
            Else
                MessageBox.Show("An error occured while posting your post")
            End If
        Catch ex As Exception
            MessageBox.Show("An error has occurred.")
        End Try
    End Sub
End Class