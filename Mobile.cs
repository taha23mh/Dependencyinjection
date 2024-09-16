using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class Mobile
    {
        public string Model { get; set; }
        private readonly ICharger _charger;
        public Mobile(ICharger charger)
        {
            _charger = charger;
        }
        public void DisplayChargerInfo()
        {
            Console.WriteLine($"ChargerModel:{_charger.Model},Voltage:{_charger.Voltage},color:{_charger.Color}");
        }
    }



}
