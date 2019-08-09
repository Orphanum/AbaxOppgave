using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxOppgave.Vehicles
{
    class Car : Vehicle
    {
        readonly int TopSpeed;
        readonly string Color;
        readonly string Type;

        public Car(string number, int effectInKW, int topSpeedInKmh, string color, string type)
            : base(number, effectInKW)
        {
            TopSpeed = topSpeedInKmh;
            Color = color;
            Type = type;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Toppfart: " + TopSpeed + "km/t");
            Console.WriteLine("Farge: " + Color);
            Console.WriteLine("Type: " + Type);
        }

        public void StartBil()
        {
            Console.WriteLine("Bil med reg.nr: " + Number + " har startet");
        }
    }
    
}

