using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public interface ICharger
    {
        public int Voltage { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
    }
}
