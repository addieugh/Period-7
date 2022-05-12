Public Class bank
    Public Property nickels As Integer
    Public Property quarters As Integer
    Public Property dimes As Integer
    Public Property m_total As Decimal
    Public Property item As Integer
    Public Property soup1 As Integer
    Public Property soup2 As Integer
    Public Property soup3 As Integer
    Public Property soup4 As Integer
    Public Property soup5 As Integer
    Public Property soup6 As Integer
    Public Property soup7 As Integer
    Public Property soup8 As Integer
    Public Property soup9 As Integer
    Public Property p_total As Decimal

    Public ReadOnly Property total As Decimal
        Get
            Return m_total
        End Get
    End Property
    Public ReadOnly Property coins As Decimal
        Get
            Return nickels * 0.05 + quarters * 0.25 + dimes * 0.1
        End Get
    End Property

    Public Function buy(item As Decimal)
        If item = 1 Then
            If m_total < 1 Or soup1 = 0 Then
                Return False
            End If
            m_total = m_total - 1
            soup1 = soup1 - 1
            Return True
        End If
        If item = 2 Then
            If m_total < 1 Or soup2 = 0 Then
                Return False
            End If
            m_total = m_total - 1
            soup2 = soup2 - 1
            Return True
        End If
        If item = 3 Then
            If m_total < 1 Or soup3 = 0 Then
                Return False
            End If
            m_total = m_total - 1
            soup3 = soup3 - 1
            Return True
        End If
        If item = 4 Then
            If m_total < 1.5 Or soup4 = 0 Then
                Return False
            End If
            m_total = m_total - 1.5
            soup4 = soup4 - 1
            Return True
        End If
        If item = 5 Then
            If m_total < 1.5 Or soup5 = 0 Then
                Return False
            End If
            m_total = m_total - 1.5
            soup5 = soup5 - 1
            Return True
        End If
        If item = 6 Then
            If m_total < 1.5 Or soup6 = 0 Then
                Return False
            End If
            m_total = m_total - 1.5
            soup6 = soup6 - 1
            Return True
        End If
        If item = 7 Then
            If m_total < 2 Or soup7 = 0 Then
                Return False
            End If
            m_total = m_total - 2
            soup7 = soup7 - 1
            Return True
        End If
        If item = 8 Then
            If m_total < 2 Or soup8 = 0 Then
                Return False
            End If
            m_total = m_total - 2
            soup8 = soup8 - 1
            Return True
        End If
        If item = 9 Then
            If m_total < 2 Or soup9 = 0 Then
                Return False
            End If
            m_total = m_total - 2
            soup9 = soup9 - 1
            Return True
        End If
    End Function
    Public Sub coinreturn()
        While m_total >= 0.05
            If m_total >= 0.25 Then
                m_total = m_total - 0.25
                quarters = quarters - 1
            End If
            If m_total >= 0.1 Then
                m_total = m_total - 0.1
                dimes = dimes - 1
            End If
            If m_total >= 0.05 Then
                m_total = m_total - 0.05
                nickels = nickels - 1
            End If
        End While
        m_total = 0

    End Sub
    Public Sub addNickel()
        nickels = nickels + 1
        m_total = m_total + 0.05
    End Sub

    Public Sub addQuarters()
        quarters = quarters + 1
        m_total = m_total + 0.25
    End Sub

    Public Sub addDimes()
        dimes = dimes + 1
        m_total = m_total + 0.1
    End Sub
    Public Sub restock()
        soup1 = 10
        soup2 = 10
        soup3 = 10
        soup4 = 10
        soup5 = 10
        soup6 = 10
        soup7 = 10
        soup8 = 10
        soup9 = 10
    End Sub

End Class

