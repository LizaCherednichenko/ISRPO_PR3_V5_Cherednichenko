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

namespace ISRPO_PR3_V5_Cherednichenko
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            X.Text = "";
            Y.Text = "";
            Z.Text = "";
            Itog.Text = "Ст. гр. 402 ИСП Чередниченко Е.К.";
        }

        private void Schet_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += Environment.NewLine + "Практическая работа 3 Вариант 5";
            //Считывание значения R
            double x = double.Parse(X.Text);
            //Вывод значения R в окно
            Itog.Text += Environment.NewLine + "R = " + x.ToString();
            //Считывание значения r
            double y = double.Parse(Y.Text);
            //Вывод значения r в окно
            Itog.Text += Environment.NewLine + "r = " + y.ToString();
            //Считывание знгачения l
            double z = double.Parse(Z.Text);
            //Вывод значения l в окно
            Itog.Text += Environment.NewLine + "l = " + z.ToString();

            //Вычисляем арифмитическое выражение
            double a = Math.PI * (x + y) * z;
            double b = Math.PI * x * x;
            double c = Math.PI * y * y;
            double s = a + b + c;
            //Выводим результат в окно
            Itog.Text += Environment.NewLine + "Результат S = " + s.ToString();
        }
    }
}
