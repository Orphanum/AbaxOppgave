using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxOppgave
{
    abstract class Vehicle
    {
        public string Number;
        public int Effect;



        public Vehicle(string number, int effect)
        {
            Number = number;
            Effect = effect;
        }

        public virtual void Show()
        {
            Console.WriteLine("Nr: " + Number);
            Console.WriteLine("Effekt: " + Effect + "kw");
            
        }

        
        
    }
}
