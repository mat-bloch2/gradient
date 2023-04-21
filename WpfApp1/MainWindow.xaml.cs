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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Color kolor = ustawienia.czytaj();
            ekran.Fill = new SolidColorBrush(kolor);
            R.Value = kolor.R; 
            G.Value = kolor.G;
            B.Value = kolor.B;
            wyświetle_wartości();
            okno.WindowStartupLocation = WindowStartupLocation.Manual;
            Point p = ustawienia.odczytaj_pozycje();
            okno.Top = p.X;
            okno.Left = p.Y;

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color kolor = new Color()
            {
                A = 255, 
                G = (byte)this.G.Value,
                B = (byte)this.B.Value,
                R = (byte)this.R.Value };
            (ekran.Fill as SolidColorBrush).Color = kolor;
            wyświetle_wartości();
        }
       void  wyświetle_wartości()
        {
            TB.Text = ((int)this.B.Value).ToString();
            TG.Text = ((int)this.G.Value).ToString();
            TR.Text = ((int)this.R.Value).ToString();
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ustawienia.zapisz((ekran.Fill as SolidColorBrush).Color);
            Point p= new Point(){ X=okno.Top,Y=okno.Left};
            ustawienia.zapisz_pozycje(p);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }
    }
}
