using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PR7_Шаповалова.Classes
{
    public class Geo_fig
    {
        public int centerX {  get; set; }
        public int centerY { get; set; }
        public void Print()
        {
            Console.WriteLine(centerX + ";" + centerY);
        }

    }
}
