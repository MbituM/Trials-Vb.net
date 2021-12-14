Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim liked, unliked As String
        liked = "i like" + vbCr + vbCr

        unliked = vbCr + "i don't like" + vbCr

        If chkfood.Text = True Then
            liked = liked + " i like food"
        Else
            unliked = unliked + "i don't like food"
        End If


    End Sub
End Class
