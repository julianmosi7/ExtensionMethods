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
            var persons = new List<string>
            {
                "Julian", "S"
            };

            var numbers = new List<double>
            {
                6, 7, 8
            };

            var gen = new List<Person>()
            {
                new Person{Firstname = "Julian", Lastname = "Moshammer", Age = 17},
                new Person {Firstname = "Selina", Lastname = "Moshammer", Age = 16}
            };

            var personsToString = new List<Person>()
            {
                new Person{Firstname = "Wolfram", Lastname = "Moshammer", Age = 49},
                new Person{Firstname = "Manuela", Lastname = "Moshammer", Age = 49}
            };

            var person = new
            {
                Firstname = "Julian",
                Lastname = "Moshammer",
                Age = 17
            };

            var person2 = new
            {
                Firstname = "Selina",
                Lastname = "Moshammer",
                Age = 16
            };

            var stringcollection = new List<string>()
            {
                "Wissen ist für immer", "Julian", "Selina", "Grieskirchen", "HTL", "Banane"
            };

            //object[] p = new object[10];
            //p[0] = person;
            //p[1] = person2;
            //person.StoreObj(x => x)

            var personsResult = new List<string>();
            var numbersResult = new List<double>();
            var genResult = new List<Person>();
            var result = new List<string>();
            DateTime dateTime;
            string s = "Julian Moshammer";
            Console.WriteLine(s.LastTwoCharakters());

            Console.WriteLine(DateTime.Now.Yesterday());

            Console.WriteLine(5.Fact());

            Console.WriteLine(dateTime = new DateTime(2019, 5, 11));

            personsResult = persons.UseOnly(x => x.Length > 5);
            foreach (var item in personsResult)
            {
                Console.WriteLine(item);   
            }

            numbersResult = numbers.UseOnlyNumbers(x => x >= 7);
            foreach (var item in numbersResult)
            {
                Console.WriteLine(item);
            }

            genResult = gen.UseOnlyGenerics(x => x.Firstname == "Julian");
            foreach (var item in genResult)
            {
                Console.WriteLine(item);
            }

            result = personsToString.Transform(x => $"{x.Firstname} {x.Lastname} {x.Age}");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            stringcollection.SortData((x, y) => x.Length > y.Length ? 1:0);
            foreach (var item in stringcollection)
            {
                Console.WriteLine(item);
            }
        }

    }
}
