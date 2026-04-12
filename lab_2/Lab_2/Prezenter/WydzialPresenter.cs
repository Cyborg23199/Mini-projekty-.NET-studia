using Lab_2.Modele;
using Lab_2.Widok.Interfejsy;
using Lab_2.Repozytoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Prezenter
{
    public class WydzialPresenter
    {
        private readonly IWydzialView _view;
        private readonly RepozytoriumWydzialow _repo;

        public WydzialPresenter(IWydzialView view)
        {
            _view = view;
            _repo = RepozytoriumWydzialow.Instance;

            _view.OnDodajWydzialClick += ObsluzDodawanieWydzialu;
        }

        private void ObsluzDodawanieWydzialu()
        {

            string nazwa = _view.Nazwa;
            string miejscowosc = _view.Miejscowosc;
            string ulica = _view.Ulica;
            string nrBudynku = _view.NumerBudynku;
            string kod1 = _view.KodPocztowy1;
            string kod2 = _view.KodPocztowy2;

            if (string.IsNullOrWhiteSpace(nazwa) ||
                string.IsNullOrWhiteSpace(miejscowosc) ||
                string.IsNullOrWhiteSpace(ulica) ||
                string.IsNullOrWhiteSpace(nrBudynku) ||
                string.IsNullOrWhiteSpace(kod1) ||
                string.IsNullOrWhiteSpace(kod2))
            {
                MessageBox.Show("Wszystkie pola adresu oraz nazwa wydziału muszą być wypełnione!",
                                "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (kod1.Length != 2 || kod2.Length != 3)
            {
                MessageBox.Show("Niepoprawny format kodu pocztowego (powinno być 00-000)!",
                                "Błąd formatu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_repo.CzyIstnieje(_view.Nazwa))
            {
                MessageBox.Show("Taki wydział już istnieje!", "Informacja",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var nowyAdres = new Adres
            {
                Miejscowosc = _view.Miejscowosc,
                KodPocztowy = _view.KodPocztowy1 + "-" + _view.KodPocztowy2,
                Ulica = _view.Ulica,
                NumerBudynku = _view.NumerBudynku
            };

            var nowyWydzial = new Wydzial
            {
                Nazwa = _view.Nazwa,
                AdresWydzialu = nowyAdres
            };

            _repo.Dodaj(nowyWydzial);
        }
    }
}
