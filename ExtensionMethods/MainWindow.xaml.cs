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

namespace ExtensionMethods
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime dateTime;
            string s = "Julian Moshammer";
            Console.WriteLine(s.LastTwoCharakters());

            Console.WriteLine(DateTime.Now.Yesterday());

            Console.WriteLine(5.Fact());

            Console.WriteLine(dateTime = new DateTime(2019, 5, 11));

            Console.WriteLine()
        }

        public bool m(double d)
        {

        }
    }
}
