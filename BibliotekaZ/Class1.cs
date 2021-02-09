using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BibliotekaZ
{
    public class MojaBiblioteka
    {
        int x,y,wynik;

        public int X { set => x = value; }
        public int Y { set => y = value; }
        public int Wynik { get => wynik; }

        public void WykonajObliczenia(TextBox txt)
        {
            wynik = x + y;
            txt.AppendText(wynik.ToString());
        }

        public static void MojaMetodaStatyczna_ObliczR(double U, double I)
        {
            double R = U / I;
            MessageBox.Show("Rezystancja wynosi: " + R.ToString());
        }
    }
}
