using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Pr11v7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string sEx1 = "aa aba abba abbba abca abea";

            Regex regexEx1 = new Regex("a[b]+a|^aa");
            MatchCollection matchesEx1 = regexEx1.Matches(sEx1); //проверка совпдаений в выржаении s

            if (matchesEx1.Count > 0) //если есть совпадения, то..
            {
                object[] masEx1 = new object[matchesEx1.Count]; //создается массив 
                matchesEx1.CopyTo(masEx1, 0); //копирование в созданрный массив с первого эл-та
                lbEx1.ItemsSource = masEx1;
            }

            Regex regexEx2 = new Regex("a[a-f]+a");
            MatchCollection matchesEx2 = regexEx2.Matches(sEx1); 

            if (matchesEx2.Count > 0) 
            {
                object[] masEx2 = new object[matchesEx2.Count]; 
                matchesEx2.CopyTo(masEx2, 0); 
                lbEx2.ItemsSource = masEx2;
            }
        }

        private void mItAboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вариант 7. " +
                "Дана строка 'aa aba abba abbba abca abea'. Напишите регулярное выражение, " +
                "\r\nкоторое найдет строки aa, aba, abba, abbba, не захватив abca abea." +
                "\r\nНапишите регулярное выражение, которое найдет строки следующего вида: по " +
                "\r\nкраям стоят буквы 'a', а между ними - буква от a до f .",
                "Разработчик: Десятов.",
                MessageBoxButton.OK,
                MessageBoxImage.Asterisk);
        }

        private void mItExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
