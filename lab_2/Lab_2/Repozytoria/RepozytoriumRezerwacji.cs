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
    internal class RepozytoriumRezerwacji
    {
        private static RepozytoriumRezerwacji _instance;
        private const string SciezkaPliku = "rezerwacje.json";

        public static RepozytoriumRezerwacji Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepozytoriumRezerwacji();
                }
                return _instance;
            }
        }
        public BindingList<Rezerwacja> lista_rezerwacji { get; private set; } = new BindingList<Rezerwacja>();

        private RepozytoriumRezerwacji() {
            var wczytane = FileService.WczytajDane<List<Rezerwacja>>(SciezkaPliku);
            lista_rezerwacji = new BindingList<Rezerwacja>(wczytane);
        }

        public void Dodaj(Rezerwacja r)
        {
            if (r == null)
            {
                throw new ArgumentNullException(nameof(r), "Nie można dodać nieistniejącego obiektu rezerwacji.");
            }

            lista_rezerwacji.Add(r);
            FileService.ZapiszDane(SciezkaPliku, lista_rezerwacji.ToList());
        }

        public bool CzyTerminZajety(Rezerwacja nowa)
        {

            if (nowa == null || nowa.SalaRezerwacji == null) return false;

            foreach (var istniejaca in lista_rezerwacji)
            {
                if (istniejaca.SalaRezerwacji == nowa.SalaRezerwacji || istniejaca.ProwadzacyRezerwacji == nowa.ProwadzacyRezerwacji)
                {
                    
                    if (nowa.Start < istniejaca.Koniec &&
                        nowa.Koniec > istniejaca.Start)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
