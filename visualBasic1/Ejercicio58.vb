Namespace Esposa
    Public Class Datos
        Sub Nombre(ByVal nom As String)
            Console.WriteLine("El Nombre del esposa es: {0}", nom)
        End Sub
        Sub Apellidos(ByVal ape As String)
            Console.WriteLine("El Apellido del esposa es: {0}", ape)
        End Sub
        Sub Edad(ByVal AñoNac As Integer)
            Dim Edad As Integer
            Edad = Microsoft.VisualBasic.Year(Date.Now) - AñoNac
            Console.WriteLine("La edad de la esposa es: {0}", Edad)
        End Sub
    End Class
End Namespace

Namespace Esposo
    Public Class Datos
        Sub Nombre(ByVal nom As String)
            Console.WriteLine("El Nombre del esposo es: {0}", nom)
        End Sub
        Sub Apellidos(ByVal ape As String)
            Console.WriteLine("El Apellido del esposo es: {0}", ape)
        End Sub
        Sub Edad(ByVal AñoNac As Integer)
            Dim Edad As Integer
            Edad = Microsoft.VisualBasic.Year(Date.Now) - AñoNac
            Console.WriteLine("La edad de la esposo es: {0}", Edad)
        End Sub
    End Class
End Namespace
