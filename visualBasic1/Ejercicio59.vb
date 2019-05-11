Namespace Cliente
    Public Class Datos
        Public Function Cliente(ByVal Nombre As String, ByVal Apellidos As String) As String
            Return (Apellidos + ", " + Nombre)
        End Function
        Public Function Direccion(ByVal dir As String) As String
            Return dir
        End Function
        Public Function Telefono(ByVal telf As Integer) As String
            Return CStr(telf)
        End Function
        Public Function DNI(ByVal LE As Long) As String
            Return CStr(LE)
        End Function
    End Class
End Namespace
Namespace Cuenta
    Public Class Cuenta
        Public Dinero As Double
        Sub Saldo(ByVal Money As Double)
            Dinero = Money
        End Sub
        Public Function TipoCuenta() As String
            If Dinero < 2500 AndAlso Dinero > 0 Then
                Return ("Cuenta Ahorros")
            ElseIf Dinero >= 2500 Then
                Return ("Cuenta Credito")
            Else
                Return ("Error: No Existe Saldo Negativo")
            End If
        End Function
    End Class
End Namespace