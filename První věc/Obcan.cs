using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace První_věc
{
    class Obcan : Clovek
    {
        Regex rx = new Regex(@"\d{6}\/\d{4}");

        string RodneCislo
        {
            get { return RodneCislo; }
            set
            {
                if (rx.IsMatch(value))
                {
                    RodneCislo = value;
                }
                else
                {
                    Exception except = new FormatException("Toto není rodné číslo!");
                    throw except;
                }
            }
        }

        public Obcan()
        {            
            Jmeno = "Nezname";
            Prijmeni = "Nezname";
            RodneCislo = "111111/1111";
        }

        public Obcan(Clovek clovek, string RodneCisloo)
        {
            Jmeno = clovek.Jmeno;
            Prijmeni = clovek.Prijmeni;
            RodneCislo = RodneCisloo;
        }

        public override string ToString()
        {
            return $"Jmeno; {Jmeno}" +
                $"Prijmeni: {Prijmeni}" +
                $"Rodne cislo: {RodneCislo}";
        }
    }
}
