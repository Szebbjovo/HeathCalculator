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

namespace homersekletKalkulator
{
    public class farenheitCalc//to celsius
    {
        public static double szamain1(double input1)
        {
            double a;

            a = (input1 -32) * 0.5555555;


            return a;
        }
    }


    public class celsiusCalc//to farenheit
    {
        public static double szamain2(double input2)
        {
            double b;

            // b = (input2 * 9) / 5 + 32;


            b = (input2 * 1.8) + 32;

            return b;
        }
    }

    public partial class MainWindow : Window
    {
        double CelsiusInput;
        double farenheitInput;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void homersekletCelsius_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            CelsiusInput = (double)homersekletCelsius.Value;

            var slider = sender as Slider;
            
            double value = (double)slider.Value;
            celsius.Text = value.ToString();

            CelsiusOutput.Text = string.Format("{0:0.00}" ,farenheitCalc.szamain1(CelsiusInput));
        }

        private void homersekletFarenheit_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            farenheitInput = (double)homersekletCelsius.Value;

            var slider = sender as Slider;

            double value = (double)slider.Value;
            farenheit.Text = value.ToString();

            FarenheitOutput.Text = string.Format("{0:0.00}", celsiusCalc.szamain2(farenheitInput));
        }
    }
}
