using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPSample.Models
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public double CaclulateArea()
        {
            return Length * Breadth;
        }
    }
}
