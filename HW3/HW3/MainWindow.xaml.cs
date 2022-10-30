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

namespace HW3
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string num = textbox1.Text;
            char[] delimiterChars = { ' ', ',', '.' };
            string[] number = num.Split(delimiterChars);
            int sum = 0;
            foreach (var num1 in number)
            {
                if (num1 != null)
                {
                    for (int i = 0; i < number.Length; i++)
                    {
                        if (number[i] == num1)
                        {
                            sum++;
                            number[i] = null;
                        }
                    }
                    textbox2.Text += $"{num1}：{sum}";
                    textbox2.Text += $"\n";
                    sum = 0;
                }
            }
        }
    }
}

