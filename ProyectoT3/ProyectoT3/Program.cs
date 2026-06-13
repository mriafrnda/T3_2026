using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enerespaldo;
using MONITOREO1;
using historialeventos;
using manauala;
using MAPA;
using System.Threading;

namespace ProyectoT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            eneres obj = new eneres();
            int opcion;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("=========================================");
                Console.WriteLine("         SISTEMA CONTRA INCENDIOS ");
                Console.WriteLine("=========================================");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("1. Iniciar monitoreo");
                Console.WriteLine("2. Historial de eventos");
                Console.WriteLine("3. Activar energía de respaldo");
                Console.WriteLine("4. Alarma manual");
                Console.WriteLine("5. Mapa de ubicación");
                Console.WriteLine("6. Salir");

                Console.Write("\nSeleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: SistemaContraIncendios.Ejecutar(); break;
                    case 2: hist.Mostrar(); break;
                    case 3: obj.respaldo(); break;
                    case 4: alarmaManual.manual(); break;
                    case 5: mapa_edificio.DibujarMapa(); break;
                    case 6: Console.WriteLine("Saliendo del sistema..."); Console.Clear(); break;
                    default: Console.Clear(); Console.WriteLine("Opción no válida. Por favor, elija una opción del 1 al 6."); break;
                }
            } while (opcion != 6);
        }
    }
}
