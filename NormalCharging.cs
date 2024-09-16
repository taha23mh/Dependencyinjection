using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class NormalCharging : ICharger
    {
        public int Voltage { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }

        public NormalCharging(int voltage, string color, string model)
        {
            Voltage = voltage;
            Color = color;
            Model = model;
        }
    }
}
