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

namespace Zad_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = textBoxMass.Text;
            string[] arr = s.Split(' ');
            int[] myArr = Array.ConvertAll(arr, n => int.Parse(n));

            int summa = 0;

            for(int i = 0; i < myArr.Length; i++)
            {
                if (i%2 !=0)
                {
                    summa += myArr[i];
                }
            }


            textBoxTotal.Text = summa.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string s = textBoxMass.Text;
            string[] s1 = s.Split(' ');
            int[] myArr = Array.ConvertAll(s1, n => int.Parse(n));

            string a = textBoxA.Text;
            int b = Int32.Parse(a);

            int t = 0;
            for(int i = 0; i<myArr.Length; i++)
            {
                if(myArr[i]<b && myArr[i] % 5 == 0)
                {
                    t++;
                }
            }

            textBoxTotal.Text = t.ToString();

        }

        
    }
}
