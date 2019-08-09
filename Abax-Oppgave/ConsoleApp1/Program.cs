using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbaxOppgave
{
    class Program
    {

        static void Main(string[] args)
        {
            var car1 = new Vehicles.Car("NF123456", 147, 200, "Grønn", "Lett Kjøretøy");
            var car2 = new Vehicles.Car("NF654321", 150, 195, "Blå", "Lett Kjøretøy");
            var boat = new Vehicles.Boat("ABC123", 100, 30, 500);
            var plane = new Vehicles.Plane("LN1234", 1000, 30, 2, 10, "Jetfly");

            car1.Show();
            Console.WriteLine("");
            car2.Show();
            Console.WriteLine("");
            car1.StartBil();
            Console.WriteLine("");
            car2.StartBil();
            Console.WriteLine("");
            Sammenligne(car1, car2);
            Console.WriteLine("");
            plane.Show();
            Console.WriteLine("");
            plane.StartFly();
            Console.WriteLine("");
            boat.Show();

            Input();
        }
        public static void Sammenligne(Vehicle args1, Vehicle args2)
        {
            if (args1.Number == args2.Number)
            {
                Console.WriteLine("Dette er samme kjøretøy");
            }
            else Console.WriteLine("Dette er ikke samme kjøretøy");
        }

        static string Input()
        {
            Console.WriteLine();
            Console.Write("Kommando: ");
            return Console.ReadLine().ToUpper();
        }

    }
}
