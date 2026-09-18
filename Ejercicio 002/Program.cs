
        // Encabezado
        Console.WriteLine("===============================================");
        Console.WriteLine(" EJERCICIO 2: TEMPERATURA DE UN MOTOR");
        Console.WriteLine("===============================================");
        Console.WriteLine("Un sensor mide diez veces la temperatura de un motor.");
        Console.WriteLine("Se calculara la temperatura promedio.");
        Console.WriteLine("===============================================");

        // Variable para acumular las temperaturas
        double suma = 0;

        // Variable para guardar cada temperatura
        double temperatura;

        // Ciclo para realizar las 10 mediciones
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese la temperatura " + i + " en °C: ");
            temperatura = Convert.ToDouble(Console.ReadLine());

            // Acumular la temperatura
            suma = suma + temperatura;
        }

        // Calcular el promedio
        double promedio = suma / 10;

        // Mostrar resultado
        Console.WriteLine();
        Console.WriteLine("===============================================");
        Console.WriteLine("Temperatura promedio: " + promedio + " °C");

        // Clasificar la temperatura
        if (promedio <= 70)
        {
            Console.WriteLine("TEMPERATURA NORMAL");
        }
        else
        {
            Console.WriteLine("ALERTA DE TEMPERATURA");
        }

        Console.WriteLine("===============================================");

        Console.WriteLine("Presione una tecla para finalizar...");
        Console.ReadKey();
   