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
    public class ProwadzacyPresenter
    {
        private readonly IProwadzacyView _view;
        private readonly RepozytoriumProwadzacych _repo;

        public ProwadzacyPresenter(IProwadzacyView view)
        {
            _view = view;
            _repo = RepozytoriumProwadzacych.Instance;

            _view.OnDodajProwadzacegoClick += ObsluzDodawanie;
        }

        private void ObsluzDodawanie()
        {
            if (string.IsNullOrWhiteSpace(_view.Imie) || string.IsNullOrWhiteSpace(_view.Nazwisko))
            {
                MessageBox.Show("Imię i nazwisko muszą być wypełnione!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_repo.CzyIstnieje(_view.Imie, _view.Nazwisko))
            {
                MessageBox.Show("Ten prowadzący już figuruje w systemie.", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var nowyProwadzacy = new Prowadzacy
            {
                Imie = _view.Imie,
                Nazwisko = _view.Nazwisko,
                Tytul = _view.WybranyTytul
            };

            _repo.Dodaj(nowyProwadzacy);
        }
    }
}
