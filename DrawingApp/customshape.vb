Public Class customshape
    Public Property xSpeed As Integer
    Public Property ySpeed As Integer
    Public Property Picture As Image

    Public Property w As Integer
    Public Property h As Integer
    Public Property Pen As Pen
    Dim m_image As Image
    Dim m_a As Point

    Dim xOffset As Integer
    Dim yOffset As Integer

    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a

    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            xOffset += xSpeed
            yOffset += ySpeed

            g.DrawRectangle(Pen, m_a.X + xOffset, m_a.Y + yOffset, w + xOffset, h + yOffset)
            g.DrawArc(Pen, m_a.X + xOffset, m_a.Y + yOffset, 100 + xOffset, 100 + yOffset, 0 + xOffset, 90 + yOffset)
            g.DrawImage(Picture, m_a.X + xOffset, m_a.Y + yOffset, w + xOffset, h + yOffset)
        End Using

    End Sub

End Class
