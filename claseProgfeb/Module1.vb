Module Module1

    Sub Main()
        'Realizar un pequeño programa de consola que nos pida el nombre, sexo (M/F) y 
        'la edad de una persona y en base a su sexo deberá colocar el mensaje 
        'Tu nombre es : NOMBRE y eres del Sexo: MASCULINO/ FEMENINO, y Tienes la edad de: EDAD

        Dim nombre As String
        Dim sexo As String
        Dim edad As Integer

        Console.WriteLine("Cual es tu nombre :")
        nombre = Console.ReadLine()
        Console.WriteLine("Sexo :")
        sexo = Console.ReadLine()
        Console.WriteLine("Tu Edad :")
        edad = Console.ReadLine()

        If (sexo = "M") Then
            Console.WriteLine("Tu Nombre es : " & nombre)
            Console.WriteLine("Eres de sexo MASCULINO")
            Console.WriteLine("Tu edad es de :" & edad)


        ElseIf (sexo = "F") Then
            Console.WriteLine("Tu Nombre es : " & nombre)
            Console.WriteLine("Eres de sexo FEMENINO")
            Console.WriteLine("Tu edad es de :" & edad)

        Else
            Console.WriteLine("Error")


        End If
        Console.ReadLine()


    End Sub


End Module
