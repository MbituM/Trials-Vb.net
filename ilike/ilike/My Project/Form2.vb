Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim choices As String

        If RadioButton1.Checked Then
            choices += "male" + vbCr
        ElseIf RadioButton2.Checked Then
            choices += "female" & vbCr
        End If
        If CheckBox1.Checked Then
            choices += "C#" & vbCr
        ElseIf CheckBox2.Checked Then
            choices += "VB" & vbCr
        ElseIf checkBox4.Checked Then
            choices += "python" & vbCr
        End If
        If RadioButton3.Checked Then
            choices += "0-10"
        ElseIf RadioButton4.Checked Then
            choices += "11-15"
        ElseIf RadioButton5.Checked Then
            choices += "16-25"
        ElseIf RadioButton6.Checked Then
            choices += "26-35"
        End If
        If CheckBox3.Checked Then
            choices += "Nairobi"

        ElseIf CheckBox6.Checked Then
            choices += "kiambu"
        ElseIf CheckBox7.Checked Then
            choices += "rongai"

            End If


    End Sub
End Class