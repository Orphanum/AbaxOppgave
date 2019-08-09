using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbaxOppgave;

namespace AbaxOppgave.Vehicles
{
    class Boat : Vehicle
    {
        readonly int TopSpeed;
        readonly int Tonnage;

        public Boat(string number, int effectInKW, int topSpeedInKnots, int tonnageInKg)
            : base(number, effectInKW)
        {

            TopSpeed = topSpeedInKnots;
            Tonnage = tonnageInKg;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Toppfart: " + TopSpeed + " knop");
            Console.WriteLine("Bruttotonnasje: " + Tonnage + "kg");
        }
    }   
}
