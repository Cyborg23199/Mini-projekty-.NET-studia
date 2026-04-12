using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Modele
{
    public class Wydzial
    {
        public string Nazwa {  get; set; }

        public Adres AdresWydzialu { get; set; }

        public override string ToString()
        {
            return $"{Nazwa}";
        }
    }
}
