using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace PR7_Шаповалова.Classes
{
    public class Geo_fig
    {
        public int centerX {  get; set; }
        public int centerY { get; set; }
        public Geo_fig(int centerX, int centerY)
        {
            this.centerX = centerX;
            this.centerY = centerY;
        }
        public virtual void Ris(Figure g)
        {

        }

    }
}
