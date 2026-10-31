using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR7_Шаповалова.Classes
{
    public class Treug:Geo_fig
    {
        public int st1 { get; set; }
        public int st2 { get; set; }
        public int st3 { get; set; }
        public Treug(int centerX, int centerY, int st1, int st2, int st3):base(centerX,centerY)
        {
            this.st1 = st1;
            this.st2 = st2;
            this.st3 = st3;
        }
    }
}
