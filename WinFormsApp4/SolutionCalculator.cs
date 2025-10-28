using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp4
{
    public class SolutionCalculator
    {
        public double Pojemnosc { get; set; }
        public double Procent { get; set; }
        public int LiczbaNaczyn { get; set; }

        public SolutionCalculator(double pojemnosc, double procent, int liczbaNaczyn)
        {
            Pojemnosc = pojemnosc;
            Procent = procent;
            LiczbaNaczyn = liczbaNaczyn;
        }

        public double ObliczLacznaObjetosc()
        {
            return Pojemnosc * LiczbaNaczyn;
        }

        public double ObliczCzystaSubstancje()
        {
            return ObliczLacznaObjetosc() * (Procent / 100.0);
        }
    }
}
