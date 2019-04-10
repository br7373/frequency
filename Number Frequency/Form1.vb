Public Class Form1
    Private Sub btnPress_Click(sender As Object, e As EventArgs) Handles btnPress.Click
        Dim warray() As Integer = {4, 3, 2, 1, 4, 4, 3, 2, 1, 6, 7, 8, 8, 8, 7, 7, 5, 5, 5, 0}
        Dim zero As Byte
        Dim one As Byte
        Dim two As Byte
        Dim three As Byte
        Dim four As Byte
        Dim five As Byte
        Dim six As Byte
        Dim seven As Byte
        Dim eight As Byte

        Array.Sort(warray)

        lstFreq.Items.Add("Digit" & vbTab & "Frequency")

        For i As Byte = 0 To 19
            If warray(i) = 0 Then
                zero += 1
            ElseIf warray(i) = 1 Then
                one += 1
            ElseIf warray(i) = 2 Then
                two += 1
            ElseIf warray(i) = 3 Then
                three += 1
            ElseIf warray(i) = 4 Then
                four += 1
            ElseIf warray(i) = 5 Then
                five += 1
            ElseIf warray(i) = 6 Then
                six += 1
            ElseIf warray(i) = 7 Then
                seven += 1
            ElseIf warray(i) = 8 Then
                eight += 1
            End If
        Next

        lstFreq.Items.Add("0" & vbTab & zero)
        lstFreq.Items.Add("1" & vbTab & one)
        lstFreq.Items.Add("2" & vbTab & two)
        lstFreq.Items.Add("3" & vbTab & three)
        lstFreq.Items.Add("4" & vbTab & four)
        lstFreq.Items.Add("5" & vbTab & five)
        lstFreq.Items.Add("6" & vbTab & six)
        lstFreq.Items.Add("7" & vbTab & seven)
        lstFreq.Items.Add("8" & vbTab & eight)
    End Sub
End Class
