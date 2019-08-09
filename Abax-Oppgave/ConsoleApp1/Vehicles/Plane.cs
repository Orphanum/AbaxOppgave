using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxOppgave.Vehicles
{
    class Plane : Vehicle
    {
        readonly int Wingspan;
        readonly int Load;
        readonly int Weight;
        readonly string Type;

        public Plane(string number, int effectInKW, int wingspanInMeters, int loadCapacityInTon, int weightInTon, string type)
            : base(number, effectInKW)
        {
            Wingspan = wingspanInMeters;
            Load = loadCapacityInTon;
            Weight = weightInTon;
            Type = type;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Vingespenn: " + Wingspan + " meter");
            Console.WriteLine("Lasteevne: " + Load + " tonn");
            Console.WriteLine("Vekt: " + Weight + " tonn");
            Console.WriteLine("Flytype: " + Type);
            
        }

        public void StartFly()
        {
            Console.WriteLine("Fly med kjenningsnummer: " + Number + " tar av");
        }
    }
}
