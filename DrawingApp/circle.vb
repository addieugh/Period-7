Public Class circle

    Public Property Pen As Pen
    Dim w As Integer
    Dim h As Integer

    Dim m_image As Image
    Dim m_a As Point



    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a

    End Sub
    Public Sub Draw(w As Integer, h As Integer)
        Using g As Graphics = Graphics.FromImage(m_image)

            g.DrawEllipse(Pen, m_a.X, m_a.Y, w, h)
        End Using

    End Sub
End Class
