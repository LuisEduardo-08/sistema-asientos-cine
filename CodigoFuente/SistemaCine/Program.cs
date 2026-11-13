using System;

class Program
{
    // Aquí se guarda la sala del cine: 5 filas (A a E) con 8 asientos cada una.
    // L quiere decir libre y X quiere decir ocupado.
    static char[,] sala = new char[5, 8];

    static void Main()
    {
        LlenarSala();

        string opcion = "";

        // El menú se sigue mostrando hasta que el usuario escoja 6 para salir.
        while (opcion != "6")
        {
            MostrarMenu();
            opcion = Console.ReadLine();
            Console.WriteLine();

            // Según el número que escribió, hacemos lo que corresponde.
            switch (opcion)
            {
                // Estas opciones se van a agregar despues.
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    Console.WriteLine("Esta opción todavía no está lista.");
                    break;
                case "6":
                    Console.WriteLine("Gracias por usar el sistema.");
                    break;
                default:
                    Console.WriteLine("Dato no válido, intenta de nuevo.");
                    break;
            }

            Console.WriteLine();
        }
    }

    // Deja todos los asientos libres (L) al abrir el programa.
    static void LlenarSala()
    {
        for (int fila = 0; fila < 5; fila++)
        {
            for (int columna = 0; columna < 8; columna++)
            {
                sala[fila, columna] = 'L';
            }
        }
    }

    // Muestra el menú en pantalla.
    static void MostrarMenu()
    {
        Console.WriteLine("========== CINE ==========");
        Console.WriteLine("1. Mostrar sala");
        Console.WriteLine("2. Reservar asiento");
        Console.WriteLine("3. Liberar asiento");
        Console.WriteLine("4. Consultar disponibilidad");
        Console.WriteLine("5. Ver estadísticas");
        Console.WriteLine("6. Salir");
        Console.WriteLine("==========================");
        Console.Write("Elige una opción: ");
    }
}