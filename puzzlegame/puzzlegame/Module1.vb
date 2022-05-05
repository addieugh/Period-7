Module Module1
    Sub EmptySpotChecker(ByRef butt1 As Button, ByRef butt2 As Button)
        If butt2.Text = "" Then
            butt2.Text = butt1.Text
            butt1.Text = ""
        End If
    End Sub
    Sub SolutionChecker()
        If Form1.Button1.Text = "1" And Form1.Button2.Text = "2" And Form1.Button3.Text = "3" And Form1.Button4.Text = "4" And Form1.Button5.Text = "5" And Form1.Button6.Text = "6" And Form1.Button7.Text = "7" And Form1.Button8.Text = "8" And Form1.Button9.Text = "9" And Form1.Button10.Text = "10" And Form1.Button11.Text = "11" And Form1.Button12.Text = "12" And Form1.Button13.Text = "13" And Form1.Button14.Text = "14" And Form1.Button15.Text = "15" Then
            MessageBox.Show(" slay you win ", "shuffle game", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        Form1.counter = Form1.counter + 1
        Form1.TextBox1.Text = " number of clicks " & Form1.counter
    End Sub
    Sub shuffle()
        Dim a(15), i, j, RN As Integer
        Dim flag As Boolean

        flag = False

        i = 1
        a(j) = 1

        Do While i <= 15
            Randomize()
            RN = CInt(Int(15 * Rnd()) + 1)
            For j = 1 To i
                If (a(j) = RN) Then
                    flag = True
                    Exit For
                End If
            Next
            If flag = True Then
                flag = False
            Else
                a(i) = RN
                i = i + 1
            End If

        Loop
        Form1.Button1.Text = a(1)
        Form1.Button2.Text = a(2)
        Form1.Button3.Text = a(3)
        Form1.Button4.Text = a(4)
        Form1.Button5.Text = a(5)
        Form1.Button6.Text = a(6)
        Form1.Button7.Text = a(7)
        Form1.Button8.Text = a(8)
        Form1.Button9.Text = a(9)
        Form1.Button10.Text = a(10)
        Form1.Button11.Text = a(11)
        Form1.Button12.Text = a(12)
        Form1.Button13.Text = a(13)
        Form1.Button14.Text = a(14)
        Form1.Button15.Text = a(15)
        Form1.Button16.Text = ""
    End Sub
    '15:46 stop time
End Module
