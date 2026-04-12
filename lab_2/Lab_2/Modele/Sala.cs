using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Modele
{
    public enum TypSali { komputerowa, cwiczeniowa, wykladowa }
    public class Sala
    {
        public string Numer {  get; set; }
        public int Pojemnosc { get; set; }
        public Wydzial WydzialSali { get; set; }
        public TypSali Typ { get; set; }

        public override string ToString()
        {
            return $"{WydzialSali.Nazwa} {Numer} {Typ}";
        }
    }
}
