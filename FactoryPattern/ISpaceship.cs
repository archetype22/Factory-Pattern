using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface ISpaceship
    {
        public string Color { get; set; }
        public string Glow { get; set; }
        public void Fly();
    }
}
