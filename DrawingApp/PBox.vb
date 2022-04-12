Public Class PBox
    Public Property Picture As Image
    Public Property w As Integer
    Public Property h As Integer
    Public Property xSpeed As Integer
    Public Property ySpeed As Integer
    Dim xOffset As Integer
    Dim yOffset As Integer
    Dim m_image As Image
    Dim m_a As Point



    Public Sub New(i As Image, a As Point, b As Point)

        m_image = i
        m_a = a

    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            xOffset += xSpeed
            yOffset += ySpeed

            g.DrawImage(Picture, m_a.X + xOffset, m_a.Y + yOffset, w + xOffset, h + yOffset)
        End Using



    End Sub
End Class
