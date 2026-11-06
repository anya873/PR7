using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PR7_Шаповалова.Classes
{
    public class Okr : Geo_fig
    {
        public int diametr { get; set; }
        public Okr(int centerX, int centerY, int diametr):base(centerX,centerY)
        {
            this.diametr = diametr;
        }
        public void Ris(Canvas canvas)
        {
            Ellipse circle = new Ellipse();
            circle.Width = diametr;
            circle.Height = diametr;
            circle.Stroke = Brushes.Blue;
            circle.StrokeThickness = 2;

            Canvas.SetLeft(circle, centerX - diametr / 2);
            Canvas.SetTop(circle, centerY - diametr / 2);

            canvas.Children.Add(circle);
        }
    }
}
