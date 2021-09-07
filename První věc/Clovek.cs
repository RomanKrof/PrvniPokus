using System;
using System.Collections.Generic;
using System.Text;

namespace První_věc
{
    class Clovek
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }

        public Clovek()
        {
            Jmeno = "Nezname";
            Prijmeni = "Nezname";
        }

        public Clovek(string Jmenoo, string Prijmenii)
        {
            Jmeno = Jmenoo;
            Prijmeni = Prijmenii;
        }

        public override string ToString()
        {
            return $"Jmeno; {Jmeno}" +
                $"Prijmeni: {Prijmeni}";
        }
    }
}
