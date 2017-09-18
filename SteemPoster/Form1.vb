Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ErrorMessage As String = "The following fields are empty" & vbCrLf
        Dim ErrorOcurred As Boolean = False
        If String.IsNullOrEmpty(AccountName.Text) Then
            ErrorMessage += "-Account Name" & vbCrLf
            ErrorOcurred = True
        ElseIf String.IsNullOrEmpty(PK.Text) Then
            ErrorMessage += "-Private Posting Key" & vbCrLf
            ErrorOcurred = True
        ElseIf String.IsNullOrEmpty(Title.Text) Then
            ErrorMessage += "-Post Title" & vbCrLf
            ErrorOcurred = True
        ElseIf String.IsNullOrEmpty(Body.Text) Then
            ErrorMessage += "-Post Body" & vbCrLf
            ErrorOcurred = True
        ElseIf String.IsNullOrEmpty(Tags.Text) Then
            ErrorMessage += "-Post Tags" & vbCrLf
            ErrorOcurred = True
        ElseIf String.IsNullOrEmpty(Permalink.Text) Then
            ErrorMessage += "-Post Link" & vbCrLf
            ErrorOcurred = True
        End If
        If ErrorOcurred = True Then
            ErrorMessage += "Please fix the field(s) shown above in order to post to the Steem Network"
            MsgBox(ErrorMessage)
        Else
            If Remember.Checked Then
                My.Settings.Account = AccountName.Text
                My.Settings.PK = PK.Text
                My.Settings.Save()
            End If
            Try
                Dim request As System.Net.WebRequest = System.Net.WebRequest.Create("https://api.steem.place/PreviewPost/")
                request.Method = "POST"
                Dim postData As String = "body=" + HttpUtility.UrlEncode(Body.Text)
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
                Preview.WebBrowser1.DocumentText = responseFromServer
                Preview.ShowDialog()
            Catch ex As Exception
                MessageBox.Show("An error has occurred.")
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(My.Settings.Account) = False Then
            AccountName.Text = My.Settings.Account
            Remember.Checked = True
        End If
        If String.IsNullOrEmpty(My.Settings.PK) = False Then
            PK.Text = My.Settings.PK
            Remember.Checked = True
        End If
    End Sub

    Private Sub Remember_CheckedChanged(sender As Object, e As EventArgs) Handles Remember.CheckedChanged
        If Remember.Checked Then
            If String.IsNullOrEmpty(AccountName.Text) = False Then My.Settings.Account = AccountName.Text
            If String.IsNullOrEmpty(PK.Text) = False Then My.Settings.PK = PK.Text
            My.Settings.Save()
        Else
            My.Settings.Account = String.Empty
            My.Settings.PK = String.Empty
            My.Settings.Save()
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Process.Start("https://steemit.com/@moisesmcardona")
    End Sub
End Class
