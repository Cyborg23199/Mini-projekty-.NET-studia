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
    internal class RepozytoriumWydzialow
    {
        private static RepozytoriumWydzialow _instance;
        private const string SciezkaPliku = "wydzialy.json";

        public static RepozytoriumWydzialow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepozytoriumWydzialow();
                }
                return _instance;
            }
        }
        public BindingList<Wydzial> lista_wydzialow { get; private set; } = new BindingList<Wydzial>();

        private RepozytoriumWydzialow() {
            var wczytaneDane = FileService.WczytajDane<List<Wydzial>>(SciezkaPliku);
            lista_wydzialow = new BindingList<Wydzial>(wczytaneDane);
        }

        public bool CzyIstnieje(string nazwa)
        {
            return lista_wydzialow.Any(w => w.Nazwa.Equals(nazwa, StringComparison.OrdinalIgnoreCase));
        }
        public void Dodaj(Wydzial w)
        {
            if (w == null)
            {
                throw new ArgumentNullException(nameof(w), "Nie można dodać nieistniejącego obiektu wydzialu.");
            }

            lista_wydzialow.Add(w);
            FileService.ZapiszDane(SciezkaPliku, lista_wydzialow.ToList());
        }
    }
}
