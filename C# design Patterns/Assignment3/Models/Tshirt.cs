using Assignment3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public  class Tshirt
    {
        public Color Color;
        public Size Size;
        public Fabric Fabric ;
        public decimal Price { get; set; }
        public Tshirt(Color color, Fabric fabric ,Size size)
        {
            Color = color;
            Fabric = fabric;
            Size = size;
        }

        
    }
}
