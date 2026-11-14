using System;

class Program
{
    // Aquí se guarda la sala del cine: 5 filas (A a E) con 8 asientos cada una.
    // L quiere decir libre y X quiere decir ocupado.
    static char[,] sala = new char[5, 8];

    // Las letras de fila y los números de asiento que sí existen.
    static string[] filas = { "A", "B", "C", "D", "E" };
    static string[] asientos = { "1", "2", "3", "4", "5", "6", "7", "8" };

    // Aquí guardamos el asiento que escogió el usuario.
    static int filaElegida;
    static int columnaElegida;

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
                case "1":
                    Console.WriteLine("Esta opción todavía no está lista.");
                    break;
                case "2":
                    ReservarAsiento();
                    break;
                case "3":
                    LiberarAsiento();
                    break;
                case "4":
                    ConsultarDisponibilidad();
                    break;
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

    // Le pide al usuario la fila y el asiento.
    static void PedirAsiento()
    {
        Console.Write("Fila (A a E): ");
        string letra = Console.ReadLine().ToUpper();
        Console.Write("Asiento (1 a 8): ");
        string numero = Console.ReadLine();

        // Si la fila o el asiento no existen, se los volvemos a pedir.
        while (Array.IndexOf(filas, letra) == -1 || Array.IndexOf(asientos, numero) == -1)
        {
            Console.WriteLine("Dato no válido, intenta de nuevo.");
            Console.Write("Fila (A a E): ");
            letra = Console.ReadLine().ToUpper();
            Console.Write("Asiento (1 a 8): ");
            numero = Console.ReadLine();
        }

        // Buscamos en qué lugar de la sala quedó.
        // Por ejemplo, B4 es la fila 1 y el asiento 3, porque se cuenta desde 0.
        filaElegida = Array.IndexOf(filas, letra);
        columnaElegida = Array.IndexOf(asientos, numero);
    }

    // Aparta un asiento: si está libre (L), lo marca como ocupado (X).
    static void ReservarAsiento()
    {
        Console.WriteLine("--- RESERVAR ASIENTO ---");
        PedirAsiento();

        if (sala[filaElegida, columnaElegida] == 'L')
        {
            sala[filaElegida, columnaElegida] = 'X';
            Console.WriteLine("Asiento reservado.");
        }
        else
        {
            Console.WriteLine("El asiento ya está ocupado.");
        }
    }

    // Desocupa un asiento: si está ocupado (X), lo deja libre (L).
    static void LiberarAsiento()
    {
        Console.WriteLine("--- LIBERAR ASIENTO ---");
        PedirAsiento();

        if (sala[filaElegida, columnaElegida] == 'X')
        {
            sala[filaElegida, columnaElegida] = 'L';
            Console.WriteLine("Asiento liberado.");
        }
        else
        {
            Console.WriteLine("El asiento ya está libre.");
        }
    }

    // Revisa un asiento: si tiene L está libre, si no, está ocupado.
    static void ConsultarDisponibilidad()
    {
        Console.WriteLine("--- CONSULTAR DISPONIBILIDAD ---");
        PedirAsiento();

        if (sala[filaElegida, columnaElegida] == 'L')
        {
            Console.WriteLine("El asiento está: Libre");
        }
        else
        {
            Console.WriteLine("El asiento está: Ocupado");
        }
    }
}