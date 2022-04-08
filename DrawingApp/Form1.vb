Public Class Form1
    Private m_Previous As System.Nullable(Of Point) = Nothing
    Dim m_shapes As New Collection
    Dim c As Color
    Dim w As Integer
    Dim type As String


    Private Sub pictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        m_Previous = e.Location
        pictureBox1_MouseMove(sender, e)
    End Sub

    Private Sub pictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If m_Previous IsNot Nothing Then
            Dim d As Object

            If Type = "line" Then
                d = New Line(PictureBox1.Image, m_Previous, e.Location)
                d.Pen = New Pen(c, w)
            End If

            If Type = "rectangle" Then
                d = New rect(PictureBox1.Image, m_Previous, e.Location)
                d.fill = CheckBox2.Checked
                d.color1 = Button2.BackColor
                d.color2 = Button3.BackColor
                d.Pen = New Pen(c, w)
            End If

            If type = "circle" Then
                d = New circle(PictureBox1.Image, m_Previous, e.Location)
                d.pen = New Pen(c, w)
                d.w = TrackBar2.Value
                d.h = TrackBar3.Value
            End If

            If type = "arc" Then
                d = New arc(PictureBox1.Image, m_Previous, e.Location)
                d.pen = New Pen(c, w)
            End If

            If type = "square" Then
                d = New square(PictureBox1.Image, m_Previous, e.Location)
                d.pen = New Pen(c, w)

                d.w = TrackBar2.Value
                d.h = TrackBar3.Value

            End If

            If type = "pie" Then
                d = New pie(PictureBox1.Image, m_Previous, e.Location)
                d.pen = New Pen(c, w)
            End If

            If type = "fill" Then
                d = New fill(PictureBox1.Image, m_Previous, e.Location)
                d.pen = New Pen(c, w)
            End If

            If type = "ngon" Then
                d = New ngon(PictureBox1.Image, m_Previous, e.Location)
                d.pen = New Pen(c, w)
                d.radius = TrackBar5.Value
                d.sides = TrackBar4.Value
            End If

            If type = "picture" Then
                d = New PBox(PictureBox1.Image, m_Previous, e.Location)
                d.picture = PictureBox2.Image
                d.w = TrackBar2.Value
                d.h = TrackBar3.Value
            End If

            If type = "Line" Then
                d = New Line(PictureBox1.Image, m_Previous, e.Location)
                d.pen = New Pen(c, w)
                d.xspeed = xSpeedTrackBar.Value
            End If


            m_shapes.Add(d)
            PictureBox1.Invalidate()
            m_Previous = e.Location
        End If

    End Sub

    Private Sub pictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        m_Previous = Nothing
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If PictureBox1.Image Is Nothing Then
            Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Color.White)
            End Using
            PictureBox1.Image = bmp
        End If


    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        For Each s As Object In m_shapes
            s.Draw()
        Next
        If (CheckBox1.Checked) Then
            Refresh()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        c = ColorDialog1.Color
        Button1.BackColor = c


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ColorDialog1.ShowDialog()
        c = ColorDialog1.Color
        sender.BackColor = c


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ColorDialog1.ShowDialog()
        c = ColorDialog1.Color
        sender.BackColor = c
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        w = TrackBar1.Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        c = sender.backcolor
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        c = sender.backcolor
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        c = sender.backcolor
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        c = sender.backcolor
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        c = sender.backcolor
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        c = sender.backcolor
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        clear()
    End Sub

    Sub clear()
        Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        PictureBox1.Image = bmp
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        SaveFileDialog1.ShowDialog()
        PictureBox1.Image.Save(SaveFileDialog1.FileName)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Type = "pie"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Type = "rectangle"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Type = "arc"
    End Sub



    Private Sub Button16_Click(sender As Object, e As EventArgs)
        type = "square"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        type = "fill"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        type = "ngon"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs)
        type = "Line"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        type = "picture"
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox2.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        type = "Line"
    End Sub

    Private Sub xSpeedTrackBar_Scroll(sender As Object, e As EventArgs) Handles xSpeedTrackBar.Scroll

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        type = "square"
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        type = "circle"
    End Sub
End Class
