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
    }
}
