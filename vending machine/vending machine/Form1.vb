Public Class Form1

    Dim vend As New bank

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vend.addNickel()

        totallabel.Text = vend.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        vend.addDimes()

        totallabel.Text = vend.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        vend.addQuarters()

        totallabel.Text = vend.total.ToString("c2")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vend.restock()
    End Sub


    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If vend.buy(1) Then
            totallabel.Text = vend.total.ToString("c2")
            ListBox1.Items.Add("cream of chicken")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If vend.buy(2) Then
            totallabel.Text = vend.total.ToString("c2")
            ListBox1.Items.Add("chicken noodle")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If vend.buy(3) Then
            totallabel.Text = vend.total.ToString("c2")
            ListBox1.Items.Add("chunky")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If vend.buy(4) Then
            totallabel.Text = vend.total.ToString("c2")
            ListBox1.Items.Add("chunky2")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If vend.buy(5) Then
            totallabel.Text = vend.total.ToString("c2")
            ListBox1.Items.Add("tomato bisque")
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If vend.buy(7) Then
            totallabel.Text = vend.total.ToString("c2")
            ListBox1.Items.Add("tomato bisque2")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If vend.buy(7) Then
            totallabel.Text = vend.total.ToString("c2")
            ListBox1.Items.Add("spicy chunky")
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If vend.buy(9) Then
            totallabel.Text = vend.total.ToString("c2")
            ListBox1.Items.Add("chicken w rice")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If vend.buy(6) Then
            totallabel.Text = vend.total.ToString("c2")
            ListBox1.Items.Add("baked beans")
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        vend.coinreturn()
        totallabel.Text = vend.total.ToString("c2")
        Label2.Text = vend.coins.tostring("c2")
    End Sub
End Class
