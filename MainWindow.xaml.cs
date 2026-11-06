using PR7_Шаповалова.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR7_Шаповалова
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Okr circle = new Okr(150, 200, 100);
            Treug triangle = new Treug(400, 200, 120, 120, 120);

            circle.Ris(MyCanvas);
            triangle.Ris(MyCanvas);
        }

        private void okr_ris(object sender, RoutedEventArgs e)
        {
            MyCanvas.Children.Clear();

            try
            {
                int cx = int.Parse(X.Text);
                int cy = int.Parse(Y.Text);
                int diameter = int.Parse(d.Text);

                Okr circle = new Okr(cx, cy, diameter);
                circle.Ris(MyCanvas);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите целые числа");
            }
        }

        private void treug_ris(object sender, RoutedEventArgs e)
        {
            MyCanvas.Children.Clear();

            try
            {
                int tx = int.Parse(X1.Text);
                int ty = int.Parse(Y1.Text);
                int a = int.Parse(A.Text);
                int b = int.Parse(B.Text);
                int c = int.Parse(C.Text);

                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    MessageBox.Show("Такой треугольник не существует");
                    return;
                }

                Treug triangle = new Treug(tx, ty, a, b, c);
                triangle.Ris(MyCanvas);
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите целые числа");
            }
        }
    }
}
