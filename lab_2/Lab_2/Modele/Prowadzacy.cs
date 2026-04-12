using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Modele
{

    public enum Tytul { brak, inz, mgr, dr, lic, prof }
    public class Prowadzacy
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public Tytul Tytul { get; set; }

        public override string ToString()
        {
            if (Tytul == Tytul.brak)
            {
                return $"{Imie} {Nazwisko}";
            } 
            else
            {
                return $"{Tytul} {Imie} {Nazwisko}";
            }
        }
    }
}
