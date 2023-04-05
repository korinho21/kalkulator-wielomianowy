using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace kalkulator_wielomianowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void WspolczynnikATextBox_TextChanged(Object sender, EventArgs e)
        {
            double value;
            if (Double.TryParse(WspolczynnikATextBox.Text, out value))
            {
                //Wartość jest poprawną liczbą rzeczywistą
            }
            else
            {
                //wartość nie jest poprawną liczbą rzeczywistą
            }

        }
        private void WspolczynnikBTextBox_TextChanged(Object sender, EventArgs e)
        {
            double value;
            if (Double.TryParse(WspolczynnikBTextBox.Text, out value))
            {
                //Wartość jest poprawną liczbą rzeczywistą
            }
            else
            {
                //wartość nie jest poprawną liczbą rzeczywistą
            }

        }
        private void WspolczynnikCTextBox_TextChanged(Object sender, EventArgs e)
        {
            double value;
            if (Double.TryParse(WspolczynnikCTextBox.Text, out value))
            {
                //Wartość jest poprawną liczbą rzeczywistą
            }
            else
            {
                //wartość nie jest poprawną liczbą rzeczywistą
            }

        }
        private void WspolczynnikDTextBox_TextChanged(Object sender, EventArgs e)
        {
            double value;
            if (Double.TryParse(WspolczynnikDTextBox.Text, out value))
            {
                //Wartość jest poprawną liczbą rzeczywistą
            }
            else
            {
                //wartość nie jest poprawną liczbą rzeczywistą
            }

        }
        private void WspolczynnikFTextBox_TextChanged(Object sender, EventArgs e)
        {
            double value;
            if (Double.TryParse(WspolczynnikFTextBox.Text, out value))
            {
                //Wartość jest poprawną liczbą rzeczywistą
            }
            else
            {
                //wartość nie jest poprawną liczbą rzeczywistą
            }

        }
        private void WspolczynnikGTextBox_TextChanged(Object sender, EventArgs e)
        {
            double value;
            if (Double.TryParse(WspolczynnikGTextBox.Text, out value))
            {
                //Wartość jest poprawną liczbą rzeczywistą
            }
            else
            {
                //wartość nie jest poprawną liczbą rzeczywistą
            }

        }


        //class Wielomian
        //{
        //    private double[] wspolczynniki;
        //    public Wielomian(params double[] wsp)
        //    {
        //        wspolczynniki = new double[11];
        //        for (int i = 0; i < wsp.Length && i < 11; i++)
        //        {
        //            wspolczynniki[i] = wsp[i];

        //        }

        //    }
        //    public double this[int i]
        //    {
        //        get
        //        {
        //            if (i >= 0 && i < 11)
        //            {
        //                return wspolczynniki[i];

        //            }
        //            else
        //            {
        //                throw new IndexOutOfRangeException("Indeks poza zakresem");


        //            }
        //            set
        //                {
        //                if (i >= 0 && i < 11)
        //                {
        //                    wspolczynniki[i] = value;
        //                }
        //                else
        //                {
        //                    throw new IndexOutOfRangeException("Indeks poza zakresem");

        //                }
        //            }



        //        }
        //    }


        //public static Wielomian operator+(kalkulator_wielomianowy a, kalkulator_wielomianowy b)
        //{
        //    Wielomian wynik = new Wielomian();
        //    wynik.WspolczynnikA = a.WspolczynnikA + b.WspolczynnikA;
        //    wynik.WspolczynnikB = a.WspolczynnikB + b.WspolczynnikB;
        //    wynik.WspolczynnikC = a.WspolczynnikC + b.WspolczynnikC;
        //    return wynik;

        //        }

        //        public static Wielomian operator -(kalkulator_wielomianowy a, kalkulator_wielomianowy b)
        //        {
        //            Wielomian wynik = new Wielomian();
        //            wynik.WspolczynnikA = a.WspolczynnikA - b.WspolczynnikA;
        //            wynik.WspolczynnikB = a.WspolczynnikB - b.WspolczynnikB;
        //           wynik.WspolczynnikC = a.WspolczynnikC - b.WspolczynnikC;
        //            return wynik;

        //        }

        //public static Wielomian operator *(Wielomian a, Wielomian b)
        //    {
        //        Wielomian wynik = new Wielomian();
        //        wynik.WspolczynnikA = a.WspolczynnikA * b.WspolczynnikA;
        //        wynik.WspolczynnikB = a.WspolczynnikA * b.WspolczynnikB + a.WspolczynnikB * b.WspolczynnikA;
        //        wynik.WspolczynnikC = a.WspolczynnikA * b.WspolczynnikC + a.WspolczynnikB * b.WspolczynnikB + a.WspolczynnikC * b.WspolczynnikA;
        //        wynik.WspolczynnikD = a.WspolczynnikB * b.WspolczynnikC + a.WspolczynnikC * b.WspolczynnikB;
        //        wynik.WspolczynnikE = a.WspolczynnikC * b.WspolczynnikC;
        //        return wynik;
        //    }
        //private override string Tostring()
        //{
        //    string wynik = "";
        //    for (int i = Stopien; i >= 0; i--)
        //    {
        //        if (Wspolczynniki[i] != 0)
        //        {
        //            if (i == Stopien)
        //            {
        //                wynik += $"{wspolczynniki[i]}x^{i}";

        //            }
        //            else if (i == 1)
        //            {
        //                wynik += $" + {wspolczynniki[i]}x";

        //            }
        //            else
        //            {
        //                wynik += $" + {wspolczynniki[i]}x^{i};

        //            }
        //        }
        //    }
        //    return wynik;
        //}
        //}
        private void ObliczDzialanie(ref string wyrazenie, int indeksOperatora, string operatorMatematyczny)
        {
            // Podzielenie wyrażenia na dwie części: przed i po operatorze
            string lewaCzesc = wyrazenie.Substring(0, indeksOperatora);
            string prawaCzesc = wyrazenie.Substring(indeksOperatora + 1);

            // Obliczenie wartości lewej i prawej części
            double lewaWartosc = Oblicz(lewaCzesc);
            double prawaWartosc = Oblicz(prawaCzesc);

            // Wykonanie działania
            double wynikDzialania = WykonajDzialanie(lewaWartosc, prawaWartosc, operatorMatematyczny);

            // Zastąpienie wyrażenia wynikiem działania
            wyrazenie = lewaCzesc + wynikDzialania + prawaCzesc;
        }

        private double WykonajDzialanie(double lewySkladnik, double prawySkladnik, string operatorMatematyczny)
        {
            double wynik = 0;

            switch (operatorMatematyczny)
            {
                case "+":
                    wynik = lewySkladnik + prawySkladnik;
                    break;
                case "-":
                    wynik = lewySkladnik - prawySkladnik;
                    break;
                case "*":
                    wynik = lewySkladnik * prawySkladnik;
                    break;
                case "/":
                    wynik = lewySkladnik / prawySkladnik;
                    break;
                default:
                    break;
            }

            return wynik;
        }
        public double Oblicz(string wyrazenie)
        {
            // Usunięcie białych znaków z wyrażenia
            wyrazenie = wyrazenie.Replace(" ", "");

            // Obliczenie wyrażenia w nawiasach
            while (wyrazenie.Contains("("))
            {
                int poczatek = wyrazenie.LastIndexOf("(");
                int koniec = wyrazenie.IndexOf(")", poczatek);

                string wyrazenieWewnatrzNawiasow = wyrazenie.Substring(poczatek + 1, koniec - poczatek - 1);
                double wynikWewnatrzNawiasow = Oblicz(wyrazenieWewnatrzNawiasow);

                wyrazenie = wyrazenie.Substring(0, poczatek) + wynikWewnatrzNawiasow + wyrazenie.Substring(koniec + 1);
            }

            // Obliczenie mnożenia i dzielenia
            while (wyrazenie.Contains("*") || wyrazenie.Contains("/"))
            {
                int indeksMnozenia = wyrazenie.IndexOf("*");
                int indeksDzielenia = wyrazenie.IndexOf("/");

                if (indeksMnozenia >= 0 && indeksDzielenia >= 0 && indeksMnozenia < indeksDzielenia || indeksMnozenia >= 0 && indeksDzielenia < 0)
                {
                    ObliczDzialanie(ref wyrazenie, indeksMnozenia, "*");
                }
                else if (indeksDzielenia >= 0 && indeksMnozenia >= 0 && indeksDzielenia < indeksMnozenia || indeksDzielenia >= 0 && indeksMnozenia < 0)
                {
                    ObliczDzialanie(ref wyrazenie, indeksDzielenia, "/");
                }
            }

            // Obliczenie dodawania i odejmowania
            while (wyrazenie.Contains("+") || wyrazenie.Contains("-"))
            {
                int indeksDodawania = wyrazenie.IndexOf("+");
                int indeksOdejmowania = wyrazenie.IndexOf("-");

                if (indeksDodawania >= 0 && indeksOdejmowania >= 0 && indeksDodawania < indeksOdejmowania || indeksDodawania >= 0 && indeksOdejmowania < 0)
                {
                    ObliczDzialanie(ref wyrazenie, indeksDodawania, "+");
                }
                else if (indeksOdejmowania >= 0 && indeksDodawania >= 0 && indeksOdejmowania < indeksDodawania || indeksOdejmowania >= 0 && indeksDodawania < 0)
                {
                    ObliczDzialanie(ref wyrazenie, indeksOdejmowania, "-");
                }




            }
            return double.Parse(wyrazenie);
        }
        private void ObliczButton1_Click(object sender, EventArgs e)
        {
            //Pobierz współczynniki wielomianu
            double a = double.Parse(WspolczynnikATextBox.Text);
            double b = double.Parse(WspolczynnikBTextBox.Text);
            double c = double.Parse(WspolczynnikCTextBox.Text);

            //Oblicz deltę i pierwiastki wielomianu
            double delta = b * b - 4 * a * c;
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

            //Wyświetl wyniki
            DeltaTextBox.Text = delta.ToString();
            X1TextBox.Text = x1.ToString();
            X2TextBox.Text = x2.ToString();
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            //Pobierz współczynniki drugiego wielomianu
            double d = double.Parse(WspolczynnikDTextBox.Text);
            double f = double.Parse(WspolczynnikGTextBox.Text);
            double g = double.Parse(WspolczynnikGTextBox.Text);

            //Pobierz współczynniki pierwszego wielomianu
            double a = double.Parse(WspolczynnikATextBox.Text);
            double b = double.Parse(WspolczynnikBTextBox.Text);
            double c = double.Parse(WspolczynnikCTextBox.Text);

            //Oblicz współczynniki sumy wielomianów
            double x = a + d;
            double y = b + f;
            double z = c + g;

            //Wyświetl wyniki
            WspolczynnikATextBox.Text = x.ToString();
            WspolczynnikBTextBox.Text = y.ToString();
            WspolczynnikCTextBox.Text = z.ToString();
        }

        private void OdejmijButton_Click(object sender, EventArgs e)
        {
            //Pobierz współczynniki drugiego wielomianu
            double d = double.Parse(WspolczynnikDTextBox.Text);
            double f = double.Parse(WspolczynnikGTextBox.Text);
            double g = double.Parse(WspolczynnikGTextBox.Text);

            //Pobierz współczynniki pierwszego wielomianu
            double a = double.Parse(WspolczynnikATextBox.Text);
            double b = double.Parse(WspolczynnikBTextBox.Text);
            double c = double.Parse(WspolczynnikCTextBox.Text);

            //Oblicz współczynniki różnicy wielomianów
            double x = a - d;
            double y = b - f;
            double z = c - g;

            //Wyświetl wyniki
            WspolczynnikATextBox.Text = x.ToString();
            WspolczynnikBTextBox.Text = y.ToString();
            WspolczynnikCTextBox.Text = z.ToString();

        }

        private void ObliczButton2_Click(object sender, EventArgs e)
        {
            //Pobiera działanie
            string dzialanie = DzialanieTextBox.Text;

            // Utwórz obiekt wyrażenia NCalc na podstawie działania użytkownika
            NCalc.Expression wyrazenie = new NCalc.Expression(dzialanie);


            // Sprawdź, czy wyrażenie jest poprawne i jeśli tak, oblicz wynik
            if (wyrazenie.HasErrors())
            {
                // Wyświetl komunikat o błędzie
                WynikTextBox.Text = "Błąd: nieprawidłowe wyrażenie";
            }
            else
            {
                // Oblicz wynik i wyświetl go
                double wynik = (double)wyrazenie.Evaluate();
                WynikTextBox.Text = "Wynik: " + wynik.ToString();
            }
        }
    }

}

