using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    class ustawienia
    {
       public static Color  czytaj()
        {
            Properties.Settings ustwienia = Properties.Settings.Default;
            Color kolor = new Color()
            {
                A = ustwienia.A,
                B = ustwienia.B,
                G = ustwienia.G,
                R = ustwienia.R
            };
            return kolor;
        }
        public  static Point odczytaj_pozycje()
        {
            Properties.Settings ustwienia = Properties.Settings.Default;

            Point point = new Point() { X=ustwienia.X,Y=ustwienia.Y};
            return point;
        }
        public static void zapisz_pozycje(Point p)
        {
            Properties.Settings ustwienia = Properties.Settings.Default;
            ustwienia.X = p.X;
            ustwienia.Y = p.Y;
            ustwienia.Save();
        }

        public static void zapisz(Color kolor)
        {
            Properties.Settings ustawienia = Properties.Settings.Default;
            ustawienia.A = kolor.A;
            ustawienia.B = kolor.B;
            ustawienia.G = kolor.G;
            ustawienia.R = kolor.R;
            ustawienia.Save();
        }
    }
}
