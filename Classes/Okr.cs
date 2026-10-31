using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR7_Шаповалова.Classes
{
    public class Okr : Geo_fig
    {
        public int diametr { get; set; }
        public Okr(int centerX, int centerY, int diametr):base(centerX,centerY)
        {
            this.diametr = diametr;
        }
            
    }
}
