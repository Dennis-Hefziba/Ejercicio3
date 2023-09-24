Module Module1
    'Elabore un programa que de acuerdo con un monto de compra muestre el descuento
    'aplicado y total a pagar.
    Sub Main()

        Console.WriteLine("-----------------------------------------------------------")
        Console.WriteLine("Bienvenido al sistema de descuentos de la empresa Sony")
        Console.WriteLine("Monto de compra: 1000 = 30% de descuento" & vbCrLf & "Monto de compra: 500 = 20% de descuento" & vbCrLf &
                          "Monto de compra: 250 = 10% de descuento" & vbCrLf & "Otra cantidad = 5% de descuento")
        Console.WriteLine("-----------------------------------------------------------")


        Dim retorno As Boolean = True
        Do

            Console.WriteLine()
            Console.WriteLine("Por favor ingrese el monto de la compra: ")
            Dim compra As Double = Console.ReadLine()
            Dim descuento As Double
            Dim totalCompra As Double

            If (compra <= 0) Then
                Console.WriteLine("-----------------------------------------------------------")
                Console.WriteLine("Ingrese un numero mayor a cero")
                Console.WriteLine("-----------------------------------------------------------")

            ElseIf (compra >= 1000) Then
                Console.WriteLine("-----------------------------------------------------------")
                descuento = compra * 0.3
                totalCompra = compra - descuento
                Console.WriteLine("El descuento a aplicar es de: " + descuento.ToString)
                Console.WriteLine("El total a de la compra es de: " + totalCompra.ToString)
                Console.WriteLine("-----------------------------------------------------------")

            ElseIf (compra >= 500) Then
                Console.WriteLine("-----------------------------------------------------------")
                descuento = compra * 0.2
                totalCompra = compra - descuento
                Console.WriteLine("El descuento a aplicar es de: " + descuento.ToString)
                Console.WriteLine("El total a de la compra es de: " + totalCompra.ToString)
                Console.WriteLine("-----------------------------------------------------------")

            ElseIf (compra >= 250) Then
                Console.WriteLine("-----------------------------------------------------------")
                descuento = compra * 0.1
                totalCompra = compra - descuento
                Console.WriteLine("El descuento a aplicar es de: " + descuento.ToString)
                Console.WriteLine("El total a de la compra es de: " + totalCompra.ToString)
                Console.WriteLine("-----------------------------------------------------------")

            Else
                Console.WriteLine("-----------------------------------------------------------")
                descuento = compra * 0.05
                totalCompra = compra - descuento
                Console.WriteLine("El descuento a aplicar es de: " + descuento.ToString)
                Console.WriteLine("El total a de la compra es de: " + totalCompra.ToString)
                Console.WriteLine("-----------------------------------------------------------")

            End If

            Console.WriteLine("Si desea ingresar mas compras presione cualquier tecla " & vbCrLf & "de lo contrario presione S")
            'ConsoleKeyInfo = Console.ReadKey() para leer la letra sin importar si es min o mayus
            Dim respuesta As ConsoleKeyInfo = Console.ReadKey()

            If (respuesta.Key = ConsoleKey.S) Then
                Exit Do
            End If

        Loop While retorno = True

    End Sub

End Module
