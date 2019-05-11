Imports Ejercicio58.Esposa
Imports Ejercicio58.Esposo
Imports Ejercicio59.Cliente
Imports Ejercicio59.Cuenta
Module Module1
    'oop
    Public Class Cuadrado
        Dim Lado As Double
        Public Sub Inicio(ByVal L As Double)
            Lado = L
        End Sub
        Public Function Area() As Double
            Return Lado * Lado
        End Function
        Public Function Perimetro() As Double
            Return 4 * Lado
        End Function
    End Class
    '----------------------------------------------------------------------
    Structure Triangulo
        Dim a, b, c, p, h As Double
        Sub TrianRec(ByVal d As Double, ByVal e As Double)
            a = d
            b = e
        End Sub
        Sub TrianNor(ByVal d As Double, ByVal e As Double, ByVal f As Double)
            a = d
            b = e
            c = f
        End Sub
        Function AreaTrianRec() As Double
            Return (a * b) / 2
        End Function
        Function AreaTrianNor() As Double
            p = (a + b + c) / 2
            Return Math.Sqrt(p * (p - a) * (p - b) * (p - c))
        End Function
        Function PeriTrianRec() As Double
            h = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))
            Return h + a + b
        End Function
        Function PeriTrianNor() As Double
            Return a + b + c
        End Function
    End Structure
    '=============================================================================
    Enum Colores
        Azul
        Rojo
        Verde
    End Enum

    Enum TipoCuenta
        Corriente
        Ahorro
    End Enum
    '================================================================================
    Sub Main()
        'Console.WriteLine(vbCrLf + "What is your name? ")
        'Dim name = Console.ReadLine()
        'Dim currentDate = DateTime.Now
        'Console.WriteLine($"{vbCrLf}Hello, {name}, on {currentDate:d} at {currentDate:t}")

        Console.WriteLine("1. Inicio 01,02,03 ")
        Console.WriteLine("2. if-then-else 10,13 ")
        Console.WriteLine("3. Case 14,15 ")
        Console.WriteLine("4. for 20,22 ")
        Console.WriteLine("5. while 25,26,27 ")
        Console.WriteLine("6. arrays 34,35,37 ")
        Console.WriteLine("7. procedure y functions 39,44,45,46,48 ")
        Console.WriteLine("8. Enumerations 51,52 ")
        Console.WriteLine("9. OOP 56 to 60 ")
        Dim opt, opt1 As Integer
        Console.WriteLine("Option: ")
        opt = Console.ReadLine()

        Select Case opt
            Case 1
                Console.WriteLine("1. 01 ")
                Console.WriteLine("2. 02 ")
                Console.WriteLine("3. 03 ")
                Console.WriteLine("Option: ")
                opt1 = Console.ReadLine()

                Select Case opt1
                    Case 1
                        Dim V, T, D As Integer

                        Console.WriteLine("1 Se desea calcular la distancia recorrida (m) por un móvil que tiene velocidad constante (m/s) durante un tiempo T (Sg), considerar que es un MRU (Movimiento Rectilíneo Uniforme)")
                        Console.WriteLine("Constant Velocity(m): ")
                        V = Console.ReadLine()
                        Console.WriteLine("Time(Sg): ")
                        T = Console.ReadLine()


                        D = V * T
                        Console.WriteLine("Result: ")
                        Console.Write(D)
                    Case 2
                        Dim n1, n2, n3 As Integer

                        Dim P As Double
                        Console.WriteLine("2 Se necesita obtener el promedio simple de un estudiante a partir de sus tres notas parciales.")

                        Console.WriteLine("Qualification 1: ")
                        n1 = Console.ReadLine()
                        Console.WriteLine("Qualification 2: ")
                        n2 = Console.ReadLine()
                        Console.WriteLine("Qualification 3: ")
                        n3 = Console.ReadLine()
                        P = (n1 + n2 + n3) / 3

                        Console.WriteLine("Result: ")
                        Console.Write(P)
                    Case 3
                        Console.WriteLine("3 Elaborar un algoritmo que solicite el número de respuestas correctas, incorrectas y en blanco, correspondientes a postulantes, y muestre su puntaje final considerando, que por cada respuesta correcta tendrá 4 puntos,respuestas incorrectas tendrá -1 y respuestas en blanco tendrá 0.")

                        Dim RI, RC, RB, PF, PRI, PRC As Integer
                        Console.WriteLine("Correct Answers: ")
                        RC = Console.ReadLine()
                        Console.WriteLine("Incorrect Answers: ")
                        RI = Console.ReadLine()
                        Console.WriteLine("Blanc Answers: ")
                        RB = Console.ReadLine()
                        PRC = RC * 4
                        PRI = RI * -1
                        PF = PRC + PRI
                        Console.WriteLine("Result: ")
                        Console.Write(PF)

                End Select



            Case 2
                Console.WriteLine("1. 10 ")
                Console.WriteLine("2. 13 ")
                Console.WriteLine("Option: ")
                opt1 = Console.ReadLine()
                Select Case opt1
                    Case 1
                        Console.WriteLine("Elabora un algoritmo que solicite la edad de 2 hermanos y muestre un mensaje indicando la edad del mayor y cuantos años de diferencia tiene con el menor. ")
                        Dim E1, E2, DE As Integer
                        Console.WriteLine("Age 1: ")
                        E1 = Console.ReadLine()
                        Console.WriteLine("Age 2: ")
                        E2 = Console.ReadLine()
                        If E1 > E2 Then
                            Console.WriteLine("The first Brother is older, for")
                            DE = E1 - E2
                        Else
                            Console.WriteLine("The Second Brother is older, for")
                            DE = E1 - E2
                        End If
                        Console.WriteLine(DE * -1)

                        Console.WriteLine("years")


                    Case 2
                        Console.WriteLine("Elabora un algoritmo que sirva para identificar el tipo de triangulo conociendo sus tres lados.")
                        Dim L1, L2, L3 As Integer
                        Dim TT As String

                        Console.WriteLine("L1")
                        L1 = Console.ReadLine()
                        Console.WriteLine("L2")
                        L2 = Console.ReadLine()
                        Console.WriteLine("L3")
                        L3 = Console.ReadLine()
                        If L1 < L2 Or L1 > L2 And L2 < L3 Or L3 > L2 And L3 < L1 Or L3 > L1 Then
                            TT = "Escaleno"
                            If L1 = L2 And L2 = L3 Then
                                TT = "Equilatero"
                            Else
                                TT = "Isosceles"
                            End If



                        End If
                        Console.WriteLine(TT)
                End Select

            Case 3
                Console.WriteLine("1. 14 ")
                Console.WriteLine("2. 15 ")
                Console.WriteLine("Option: ")
                opt1 = Console.ReadLine()
                Dim NE As Integer
                Dim ER As String
                Dim MV As Integer
                Dim TB As Double
                Select Case opt1
                    Case 1
                        Console.WriteLine("14 Elabore un algoritmo que permita ingresar un número entero (1 a 10), y muestre su equivalente en romano.")
                        Console.WriteLine("Write: ")
                        NE = Console.ReadLine()
                        Select Case NE
                            Case 1
                                ER = "I"
                            Case 2
                                ER = "II"
                            Case 3
                                ER = "III"
                            Case 4
                                ER = "IV"

                            Case 5
                                ER = "V"
                            Case 6
                                ER = "VI"
                            Case 7
                                ER = "VII"
                            Case 8
                                ER = "VIII"
                            Case 9
                                ER = "IX"
                            Case 10
                                ER = "x"


                        End Select
                        Console.WriteLine(ER)


                    Case 2
                        Console.WriteLine("15. Elabore un algoritmo que permita ingresar el monto de venta alcanzado por un promotor durante el mes, luego de calcular la bonificación que le corresponde sabiendo:")



                        Console.WriteLine("Write: ")
                        MV = Console.ReadLine()
                        Select Case MV
                            Case MV >= 0 And MV < 1000
                                Console.WriteLine("h: ")

                                TB = (0 * MV) / 100
                            Case MV >= 1000 And MV < 5000
                                Console.WriteLine("o: ")
                                TB = (3 * MV) / 100
                            Case MV >= 5000 And MV < 20000
                                Console.WriteLine("l: ")
                                TB = (5 * MV) / 100
                            Case MV >= 20000
                                Console.WriteLine("a: ")
                                TB = (8 * MV) / 100

                        End Select
                        Console.WriteLine("Result: ")
                        Console.WriteLine(TB)


                End Select

            Case 4

                Console.WriteLine("1. 20 ")
                Console.WriteLine("2. 22 ")

                Console.WriteLine("Option: ")
                opt1 = Console.ReadLine()
                Select Case opt1
                    Case 1
                        Console.WriteLine("20. Elaborar un algoritmo que permita mostrar el sueldo promedio de un grupo de empleados.")
                        Dim NE As Integer
                        Dim SP, SS, SE As Double
                        Console.WriteLine("Write  ")
                        NE = Console.ReadLine()
                        For K = 1 To NE
                            Console.WriteLine("Write  ")
                            SE = Console.ReadLine()
                            SS = SS + SE

                        Next
                        SP = SS / NE
                        Console.WriteLine("Result: ")
                        Console.WriteLine(SP)
                    Case 2
                        Console.WriteLine("Elaborar un algoritmo que solicite 2 número enteros y muestre su producto por el método de sumas sucesivas.")
                        Dim PN, SN, P As Integer
                        P = 0
                        Console.WriteLine("Write n1  ")
                        PN = Console.ReadLine()
                        Console.WriteLine("Write n2  ")
                        SN = Console.ReadLine()
                        For k = 1 To SN
                            P = P + PN
                        Next
                        Console.WriteLine("Result")
                        Console.WriteLine(P)
                End Select


            Case 5
                Console.WriteLine("1. 25 ")
                Console.WriteLine("2. 26 ")
                Console.WriteLine("3. 27 ")

                Console.WriteLine("Option: ")
                opt1 = Console.ReadLine()
                Select Case opt1
                    Case 1
                        Console.WriteLine("25. Elaborar un algoritmo que solicite ingresar letras hasta que este ingrese una vocal.")
                        Dim SEMAF As String
                        SEMAF = "V"
                        Dim L As String
                        Do While SEMAF = "V"
                            Console.WriteLine("Write  ")
                            L = Console.ReadLine()
                            Select Case L
                                Case "A"
                                    SEMAF = "R"
                                Case "a"
                                    SEMAF = "R"
                                Case "E"
                                    SEMAF = "R"
                                Case "e"
                                    SEMAF = "R"
                                Case "I"
                                    SEMAF = "R"
                                Case "i"
                                    SEMAF = "R"
                                Case "O"
                                    SEMAF = "R"
                                Case "o"
                                    SEMAF = "R"
                                Case "U"
                                    SEMAF = "R"
                                Case "u"
                                    SEMAF = "R"
                                Case Else
                                    SEMAF = "V"
                            End Select
                        Loop
                    Case 2
                        Console.WriteLine("26. Elabore un algoritmo que muestre los términos de la serie Fibonacci que sean menores a 100000.")
                        Dim A, B, C As Integer
                        A = 0
                        B = 1
                        C = A + B
                        Console.WriteLine(A)

                        Console.WriteLine(B)

                        Do While (C < 100000)
                            Console.WriteLine(C)

                            A = B
                            B = C
                            C = A + B

                        Loop
                    Case 3
                        Console.WriteLine("27. Elaborar un algoritmo que solicite 2 números enteros y un operador aritmético y luego debe de mostrar el resultado de la operación correspondiente.")
                        Dim N1, N2, R As Integer
                        Dim OP As String
                        Console.WriteLine("Write n1  ")
                        N1 = Console.ReadLine()
                        Console.WriteLine("Write n2  ")
                        N2 = Console.ReadLine()
                        Console.WriteLine("Write OP  ")
                        OP = Console.ReadLine()
                        Select Case OP
                            Case "+"
                                R = N1 + N2
                            Case "-"
                                R = N1 - N2
                            Case "*"
                                R = N1 * N2
                            Case "^"
                                R = N1 ^ N2
                            Case Else
                                R = 0
                        End Select
                        Console.WriteLine(R)

                End Select

            Case 6
                Console.WriteLine("1. 34 ")
                Console.WriteLine("2. 35 ")
                Console.WriteLine("3. 37 ")
                Console.WriteLine("Option: ")
                opt1 = Console.ReadLine()
                Select Case opt1
                    Case 1
                        Console.WriteLine("34.Se desea mostrar los cuatros primeros números positivos y el número del índice en donde es almacenado en el array unidimensional.")
                        Dim ArrayUnidimensional(3) As Integer
                        Dim X, Num As Integer
                        For X = 0 To 3
                            Num = X + 1
                            ArrayUnidimensional(X) = Num
                        Next
                        Console.WriteLine()
                        Console.WriteLine("Array Unidimensional 4")
                        Console.WriteLine()
                        For X = 0 To 3
                            Console.WriteLine("Indice [{0}{1}{2}", X, "] = ", ArrayUnidimensional(X))
                        Next
                        Console.ReadLine()
                    Case 2
                        Console.WriteLine("35.Se desea mostrar los dieciséis primeros números positivos y el número del índice en donde es almacenado en el array bidimensional.")
                        'Ejemplo de un Array Bidimensional

                        Dim ArrayBidimensional(3, 3) As Integer
                        Dim X, Y, Num As Integer
                        For X = 0 To 3
                            For Y = 0 To 3
                                Num = Y + 1
                                If X = 1 Then
                                    Num += 4
                                ElseIf X = 2 Then
                                    Num += 8
                                ElseIf X = 3 Then
                                    Num += 12
                                End If
                                ArrayBidimensional(X, Y) = Num
                            Next
                        Next
                        Console.WriteLine()
                        Console.WriteLine("Array Bidimensional 4 x 4")
                        Console.WriteLine()
                        For X = 0 To 3
                            For Y = 0 To 3
                                Console.WriteLine("Indice [{0}{1}{2}{3}{4}", X, "][", Y, "] = ",
                                ArrayBidimensional(X, Y))
                            Next
                        Next
                        Console.ReadLine()
                    Case 3
                        Console.WriteLine("37.Se desea mostrar los Nombres y Apellidos de 4 alumnos que están almacenados en un array bidimensional.")
                        'Este algoritmo muestra los Nombres y Apellidos almacenados
                        'en un Array Bidimensional

                        Dim NomApe(1, 3) As String
                        Dim X1, X2, Y As Integer
                        NomApe(0, 0) = "Joel"
                        NomApe(0, 1) = "Nahum"
                        NomApe(0, 2) = "Krizia"
                        NomApe(0, 3) = "Giselle"
                        NomApe(1, 0) = "Chuco"
                        NomApe(1, 1) = "Chuco"
                        NomApe(1, 2) = "Rupay"
                        NomApe(1, 3) = "Valverde"
                        Console.WriteLine("Los Nombres y Apellidos Son: ")
                        Console.WriteLine()
                        For X1 = 0 To 0
                            For Y = 0 To 3
                                Console.Write("{0}{1}", NomApe(X1, Y), " ")
                                For X2 = 1 To 1
                                    Console.WriteLine(NomApe(X2, Y))
                                Next
                            Next
                        Next
                        Console.ReadLine()
                End Select
            Case 7

                Console.WriteLine("1. 39 ")
                Console.WriteLine("2. 44")
                Console.WriteLine("3. 45 ")
                Console.WriteLine("4. 46 ")
                Console.WriteLine("5. 48 ")
                Console.WriteLine("Option: ")
                opt1 = Console.ReadLine()
                Select Case opt1
                    Case 1
                        Console.WriteLine("39.Se desea mostrar la edad y el sueldo de un empleado mediante un procedimiento externo.")
                        MostrarEmpleado(32, 25000.0)
                        Console.ReadLine()
                    Case 2
                        Console.WriteLine("44.Se desea mostrar la tabla de multiplicar de un número dado, especificando hasta que número quiere que se muestre, esto se realizará un procedimiento externo.")
                        Dim n, m As Integer
                        Console.Write("¿Que Tabla de Multiplicar Desea? : ")
                        n = CInt(Console.ReadLine)
                        Console.Write("¿Cuantos Números Desea Ver? : ")
                        m = CInt(Console.ReadLine)
                        Console.WriteLine()
                        TablaMult(n, m)
                        Console.ReadLine()
                    Case 3
                        Console.WriteLine("45.Se desea mostrar los divisores comunes de dos números enviados a un procedimiento.")
                        Dim a, b As Integer
                        Console.WriteLine("Divisores Comunes de Dos Números")
                        Console.WriteLine()
                        Console.Write("Ingrese Primer Número: ")
                        a = CInt(Console.ReadLine)
                        Console.Write("Ingrese Segundo Número: ")
                        b = CInt(Console.ReadLine)
                        Console.WriteLine()
                        Comunes(a, b)
                        Console.ReadLine()
                    Case 4
                        Console.WriteLine("46.Se desea saber si una fecha es correcta, esta fecha es ingresada por el usuario.")
                        Dim dia, mes, año As Integer
                        Console.Write("Ingrese el Día: ")
                        dia = CInt(Console.ReadLine)
                        Console.Write("Ingrese el Mes: ")
                        mes = CInt(Console.ReadLine)
                        Console.Write("Ingrese el Año: ")
                        año = CInt(Console.ReadLine)
                        Console.WriteLine()
                        FechaOk(dia, mes, año)
                        Console.ReadLine()

                    Case 5
                        Console.WriteLine("48. Se desea ingresar un número cualquiera y saber si es un número primo.")
                        Dim n As Integer
                        Console.Write("Ingrese el Número a Evaluar : ")
                        n = CInt(Console.ReadLine)
                        If EsPrimo(n) = True Then
                            Console.WriteLine("El Número SI es Primo")
                        Else
                            Console.WriteLine("El Número NO es Primo")
                        End If
                        Console.ReadLine()
                End Select
            Case 8
                Console.WriteLine("1. 51 ")
                Console.WriteLine("2. 52 ")
                Console.WriteLine("Option: ")
                opt1 = Console.ReadLine()
                Select Case opt1
                    Case 1
                        Console.WriteLine("51. Este ejercicio usamos una enumeración para cambiar de color a la letra de la aplicación.")

                        Dim Numero As Integer
                        Dim Color As String
                        Console.WriteLine("{0}{1}", Space(30), "ELEGIR COLOR")
                        Console.WriteLine()
                        Console.WriteLine("{0}{1}", Space(5), "[0] Color Azul")
                        Console.WriteLine("{0}{1}", Space(5), "[1] Color Rojo")
                        Console.WriteLine("{0}{1}", Space(5), "[2] Color Verde")
                        Console.WriteLine()
                        Console.Write("Ingrese el Número de Color ==> ")
                        Numero = CInt(Console.ReadLine)
                        If Numero < Colores.Azul Or Numero > Colores.Verde Then
                            Console.WriteLine("Color no Válido")
                            Exit Sub
                        End If
                        Console.WriteLine()
                        Console.Write("Usted Eligio el color ")
                        Select Case Numero
                            Case Colores.Azul
                                Console.ForegroundColor = ConsoleColor.Blue
                                Color = "Azul"
                            Case Colores.Rojo
                                Console.ForegroundColor = ConsoleColor.Red
                                Color = "Rojo"
                            Case Colores.Verde
                                Console.ForegroundColor = ConsoleColor.Green
                                Color = "Verde"
                        End Select
                        Console.WriteLine(Color)
                        Console.ForegroundColor = ConsoleColor.Gray
                        Console.WriteLine()
                    Case 2
                        Console.WriteLine("52. Esta aplicación nos mostrara que tipo de cuenta es asignada a un cliente usando una enumeración, teniendo en cuenta que debe de tener mas de 2500 soles en saldo para tener una cuenta corriente.")
                        Dim Cuenta As TipoCuenta
                        Dim Cliente As String
                        Dim Saldo As Integer
                        Console.Write("Ingrese el Nombre del Cliente: ")
                        Cliente = Console.ReadLine
                        Console.Write("Ingrese el saldo de su Cuenta: ")
                        Saldo = CInt(Console.ReadLine)
                        If Saldo < 2500 Then
                            Cuenta = TipoCuenta.Ahorro
                        Else
                            Cuenta = TipoCuenta.Corriente
                        End If
                        Console.WriteLine()
                        Console.WriteLine("{0}{1}", Space(10), "*** DETALLE DE CUENTA DELCLIETE ***")
                        Console.WriteLine()
                        Console.WriteLine("Cliente: {0}", Cliente)
                        Console.WriteLine("El tipo de cuenta del cliente es: {0}", Cuenta)
                        Console.WriteLine("El saldo de la cuenta del cliente es: {0}", Saldo)
                End Select

            Case 9
                Console.WriteLine("1. 56 ")
                Console.WriteLine("2. 57 ")
                Console.WriteLine("3. 58 ")
                Console.WriteLine("4. 59 ")
                Console.WriteLine("5. 60 ")
                Console.WriteLine("Option: ")
                opt1 = Console.ReadLine()
                Select Case opt1
                    Case 1
                        Console.WriteLine("56. Esta aplicación utiliza una clase para realizar una cierta tarea, como la de es halla el área y perímetro de un cuadrado, también este sería un claro ejemplo de polimorfismo, ya que es una forma diferente de programar, pero tenga en claro siempre la diferencia entre una clase y estructura, Las clases usan parámetros por referencia, mientras que las estructuras la usan por valor..")
                        Dim X As Cuadrado
                        Dim L As Double = 5.0
                        X = New Cuadrado
                        X.Inicio(L)
                        Console.WriteLine("El área del cuadrado es: {0}", X.Area)
                        Console.WriteLine("El perimetro del cuadrado es: {0}", X.Perimetro)
                        Console.ReadLine()
                    Case 2
                        Console.WriteLine("57. Esta aplicación utiliza una estructura, procedimientos (Sub y Function) para realizar una cierta tarea, como la de es hallar el área y perímetro de distintos tipos de triangulo.")
                        Dim Rec, Nor As Triangulo
                        Dim n, a, b, c As Double
                        Call Menu()
                        Console.Write("Elija una Opción ==> ")
                        n = CDbl(Console.ReadLine)
                        Console.WriteLine()
                        While n <> 3
                            Select Case n
                                Case 1
                                    Console.Write("Ingrese la altura: ")
                                    a = CDbl(Console.ReadLine)
                                    Console.Write("Ingrese la base: ")
                                    b = CDbl(Console.ReadLine)
                                    Rec.TrianRec(a, b)
                                    Console.WriteLine("El área del triangulo es: {0}", Rec.AreaTrianRec)
                                    Console.WriteLine("El paremitro del triangulo es: {0}",
                                    Rec.PeriTrianRec)
                                Case 2
                                    Console.Write("Ingrese el primer lado: ")
                                    a = CDbl(Console.ReadLine)
                                    Console.Write("Ingrese el segundo lado: ")
                                    b = CDbl(Console.ReadLine)
                                    Console.Write("Ingrese el tercer lado: ")
                                    c = CDbl(Console.ReadLine)
                                    Nor.TrianNor(a, b, c)
                                    Console.WriteLine("El área del triangulo es: {0}", Rec.AreaTrianNor)
                                    Console.WriteLine("El paremitro del triangulo es: {0}",
                                    Rec.PeriTrianNor)
                                Case Else
                                    Console.WriteLine("Opción no Válida")
                            End Select
                            Console.ReadLine()
                            Console.Clear()
                            Call Menu()
                            Console.Write("Elija una Opción ==> ")
                            n = CDbl(Console.ReadLine)
                            Console.WriteLine()
                        End While
                        Console.WriteLine("Fin del Programa")
                        Console.ReadLine()
                    Case 3
                        Console.WriteLine("58. Esta aplicación utiliza dos espacios de nombre, cada uno con sus clases y procedimientos, para esto primero añadiremos una clase llamada ClaseDatos y de ahí un módulo llamado Ejercicio58 en donde importaremos los espacios de nombres creados.")
                        Dim Mujer As New Esposa.Datos
                        Dim Marido As New Esposo.Datos
                        Console.WriteLine()
                        Mujer.Nombre("Giselle")
                        Mujer.Apellidos("Valverde")
                        Mujer.Edad(1985)
                        Console.WriteLine()
                        Marido.Nombre("Joel")
                        Marido.Apellidos("Chuco")
                        Marido.Edad(1984)

                    Case 4
                        Console.WriteLine("59. Esta aplicación utiliza dos espacios de nombre, cada uno con sus clases y procedimientos, para esto primero añadiremos una clase llamada ClaseBanco y de ahí un módulo llamado Ejercicio59 en donde importaremos los espacios de nombres creados.")
                        Dim Datos As Cliente.Datos
                        Dim DatoCuenta As Cuenta.Cuenta
                        Dim Nombre, Apellidos, Direccion As String
                        Dim Telefono, DNI As Integer
                        Dim Monto As Double
                        Datos = New Cliente.Datos
                        DatoCuenta = New Cuenta.Cuenta
                        Console.WriteLine()
                        Console.WriteLine("{0} Nueva Cuenta", Space(25))
                        Console.WriteLine()
                        Console.Write("Nombres del Cliente: ")
                        Nombre = CStr(Console.ReadLine)
                        Console.Write("Apellidos del Cliente: ")
                        Apellidos = CStr(Console.ReadLine)
                        Console.Write("Dirección del Cliente: ")
                        Direccion = CStr(Console.ReadLine)
                        Console.Write("Numero de DNI: ")
                        DNI = CInt(Console.ReadLine)
                        Console.Write("Numero Telefonico: ")
                        Telefono = CInt(Console.ReadLine)
                        Console.Write("Monto de Cuenta: ")
                        Monto = CDbl(Console.ReadLine)
                        Console.WriteLine()
                        Console.WriteLine("Presione ENTER para ver el Detalle de la Cuenta")
                        Console.ReadLine()
                        Console.Clear()
                        Console.WriteLine()
                        Console.WriteLine()
                        Console.WriteLine("{0}*** DETALLE DE CUENTA ***", Space(25))
                        Console.WriteLine()
                        Console.WriteLine()
                        Console.WriteLine("Cliente: {0}", Datos.Cliente(Nombre, Apellidos))
                        Console.WriteLine("Dirección: {0}", Datos.Direccion(Direccion))
                        Console.Write("DNI: {0}", Datos.DNI(DNI))
                        Console.WriteLine("{0}Teléfono: {1}", Space(10), Datos.Telefono(Telefono))
                        DatoCuenta.Saldo(Monto)
                        Console.WriteLine("Tipo de Cuenta: {0}", DatoCuenta.TipoCuenta())
                        Console.WriteLine("Saldo de Cuenta: {0}", DatoCuenta.Dinero)
                    Case 5
                        Console.WriteLine("60. Esta aplicación utiliza un modulo, es algo mas suave, después de ver espacios de nombres, clases, estructuras, y como despedida de las consolas de aplicación.")
                        Dim i, d As Integer
                        Dim salir As Integer
                        Dim s As Char
                        Do
                            Console.Clear()
                            Console.WriteLine()
                            Console.ForegroundColor = ConsoleColor.Blue
                            Console.WriteLine()
                            Console.WriteLine("{0}INSTITUTO SUPERIOR TECNOLÓGICO DE ZAPOPAN",
                            Space(30))
                            Console.WriteLine()
                            Console.WriteLine()
                            Console.WriteLine("{0}DEMOSTRATIVO DE UN ARREGLO UNIDIMENSIONAL", Space(29))
                            Console.WriteLine()
                            Console.WriteLine()
                            Console.WriteLine("{0}ESCRITO POR: donnadie",
                            Space(32))
                            Console.WriteLine()
                            Console.WriteLine()
                            Console.WriteLine()
                            Console.ForegroundColor = ConsoleColor.DarkGreen
                            Console.Write("Ingrese Número de datos del Arreglo: ")
                            d = CInt(Console.ReadLine)
                            Dim A(d - 1) As Integer
                            Console.WriteLine()
                            Console.WriteLine()
                            Console.WriteLine("Elementos Ingresados: ")
                            For i = 0 To d - 1
                                Console.Write("A [{0}] = ", i)
                                A(i) = CInt(Console.ReadLine)
                            Next
                            Console.WriteLine("Presione una tecla para ver la lista ingresada")
                            Console.ReadLine()
                            Console.Clear()
                            Console.WriteLine()
                            Console.WriteLine()
                            Console.WriteLine("Lista Ingresada")
                            Console.WriteLine()
                            For i = 0 To d - 1
                                Console.WriteLine("{0} ", A(i))
                            Next
                            Console.WriteLine()
                            Console.WriteLine()
                            Console.WriteLine("Presione S para salir, ")
                            Console.WriteLine("Presione C para continuar, ")
                            Console.WriteLine("(Continuar / Salir) ...")
                            s = CChar(Console.ReadLine)
                            If s = "s" Or s = "S" Then
                                salir = 1
                            End If
                        Loop While (salir <> 1)
                End Select
            Case Else
                Console.WriteLine("Incorrect option")
        End Select






        Console.Write(vbCrLf + "Press any key to exit... ")
        Console.ReadKey(True)
    End Sub
    '===================================================================================================================
    '===================================================================================================================

    'exersice 7 39
    Sub MostrarEmpleado(ByVal Edad As Integer, ByVal Salario As Double)
        Console.WriteLine("El Empleado Tiene {0}{1}", Edad, " años")
        Console.WriteLine("El Empleado Gana $ {0}", Salario)
    End Sub
    'exersice 7 44
    Sub TablaMult(ByVal n As Integer, ByVal m As Integer)
        Dim i As Integer
        Console.WriteLine("Tabla de Multiplicar del {0}", n)
        Console.WriteLine()
        For i = 1 To m
            Console.WriteLine("{0}{1}{2}{3}{4}", i, " x ", n, " = ", i * n)
        Next
    End Sub
    'exersice 7 45
    Sub Comunes(ByVal a As Integer, ByVal b As Integer)
        Dim i As Integer = 1
        While (i <= a And i <= b)
            If a Mod i = 0 AndAlso b Mod i = 0 Then
                Console.WriteLine(i)
            End If
            i = i + 1
        End While
    End Sub
    'exersice 7 46
    Sub FechaOk(ByVal dia As Integer, ByVal mes As Integer, ByVal año As Integer)
        Dim MaxDia As Integer
        Select Case mes
            Case 1, 3, 5, 7, 10, 12, 8
                MaxDia = 31
            Case 4, 6, 9, 11
                MaxDia = 30
            Case 2
                If año Mod 4 = 0 AndAlso año Mod 100 <> 0 Or año Mod 400 = 0 Then
                    MaxDia = 29
                Else
                    MaxDia = 28
                End If
            Case Else
                Console.WriteLine("Mes Incorrecto")
                Exit Sub
        End Select
        If dia > 0 And dia <= MaxDia And mes > 0 And mes < 13 And año > 0 Then
            Console.WriteLine("La Fecha Es Correcta")
        Else
            Console.WriteLine("La Fecha Es Incorrecta")
        End If
    End Sub
    'exersice 7 48
    Function EsPrimo(ByVal n As Integer) As Boolean
        Dim i As Integer
        i = n - 1
        While (i > 1)
            If n Mod i = 0 Then
                EsPrimo = False
                Exit Function
            End If
            i = i - 1
        End While
        EsPrimo = True
    End Function
    'exersice 9 57
    Sub Menu()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("{0} MENÚ DE OPCIONES", Space(25))
        Console.WriteLine()
        Console.WriteLine("{0} [1] Halla el área y el perímetro de un triangulo
rectangulo", Space(10))
        Console.WriteLine("{0} [2] Halla el área y el perímetro de un triangulo
normal", Space(10))
        Console.WriteLine("{0} [3] Salir", Space(10))
        Console.WriteLine()
    End Sub
End Module
