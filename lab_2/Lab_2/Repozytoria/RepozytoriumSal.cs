using Lab_2.Modele;
using Lab_2.Serwis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Repozytoria
{
    internal class RepozytoriumSal
    {
        private static RepozytoriumSal _instance;
        private const string SciezkaPliku = "sale.json";

        public static RepozytoriumSal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepozytoriumSal();
                }
                return _instance;
            }
        }
        public BindingList<Sala> lista_sal { get; private set; } = new BindingList<Sala>();

        private RepozytoriumSal() {
            var wczytane = FileService.WczytajDane<List<Sala>>(SciezkaPliku);
            lista_sal = new BindingList<Sala>(wczytane);
        }

        public void Dodaj(Sala s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s), "Nie można dodać nieistniejącego obiektu sali.");
            }

            lista_sal.Add(s);
            FileService.ZapiszDane(SciezkaPliku, lista_sal.ToList());
        }

        public bool CzyIstnieje(string numer, Wydzial wydzial)
        {
            return lista_sal.Any(s => s.Numer.Equals(numer, StringComparison.OrdinalIgnoreCase)
                                 && s.WydzialSali == wydzial);
        }
    }
}
