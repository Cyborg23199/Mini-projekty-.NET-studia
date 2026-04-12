using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Modele
{
    public class Rezerwacja
    {
        public Sala SalaRezerwacji { get; set; }
        public Prowadzacy ProwadzacyRezerwacji { get; set; }
        public DateTime Start { get; set; }
        public DateTime Koniec { get; set; }

        public override string ToString()
        {
            return $"{Start.ToShortDateString()} {Start:HH:mm}-{Koniec:HH:mm} - {SalaRezerwacji.WydzialSali.Nazwa} {SalaRezerwacji.Numer} {SalaRezerwacji.Typ} - {ProwadzacyRezerwacji.Tytul} {ProwadzacyRezerwacji.Imie} {ProwadzacyRezerwacji.Nazwisko}";
        }
    }
}
