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
    internal class RepozytoriumProwadzacych
    {
        private static RepozytoriumProwadzacych _instance;
        private const string SciezkaPliku = "prowadzacy.json";

        public static RepozytoriumProwadzacych Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RepozytoriumProwadzacych();
                }
                return _instance;
            }
        }
        public BindingList<Prowadzacy> lista_prowadzacych { get; private set; } = new BindingList<Prowadzacy>();

        private RepozytoriumProwadzacych() {
            var wczytane = FileService.WczytajDane<List<Prowadzacy>>(SciezkaPliku);
            lista_prowadzacych = new BindingList<Prowadzacy>(wczytane);
        }

        public void Dodaj(Prowadzacy s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s), "Nie można dodać nieistniejącego obiektu prowadzacego.");
            }

            lista_prowadzacych.Add(s);
            FileService.ZapiszDane(SciezkaPliku, lista_prowadzacych.ToList());
        }

        public bool CzyIstnieje(string imie, string nazwisko)
        {
            return lista_prowadzacych.Any(p =>
                p.Imie.Equals(imie, StringComparison.OrdinalIgnoreCase) &&
                p.Nazwisko.Equals(nazwisko, StringComparison.OrdinalIgnoreCase));
        }

    }
}
