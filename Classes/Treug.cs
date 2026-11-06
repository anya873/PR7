using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;

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
        public void Ris(Canvas canvas)
        {
            double p = (st1 * st1 + st2 * st2 - st3 * st3) / (2.0 * st1);
            double h = Math.Sqrt(st2 * st2 - p * p);

            double leftX = centerX - st1 / 2.0;
            double leftY = centerY + h / 2.0;

            double rightX = centerX + st1 / 2.0;
            double rightY = centerY + h / 2.0;

            double topX = leftX + p;
            double topY = leftY - h;

            DrawLine(canvas, leftX, leftY, rightX, rightY);
            DrawLine(canvas, rightX, rightY, topX, topY);
            DrawLine(canvas, topX, topY, leftX, leftY);
        }
        private void DrawLine(Canvas canvas, double x1, double y1, double x2, double y2)
        {
            Line line = new Line();
            line.X1 = x1;
            line.Y1 = y1;
            line.X2 = x2;
            line.Y2 = y2;
            line.Stroke = Brushes.Red;
            line.StrokeThickness = 2;

            canvas.Children.Add(line);
        }
    }
}
