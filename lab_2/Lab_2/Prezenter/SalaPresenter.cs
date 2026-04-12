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
    internal class SalaPresenter
    {
        private readonly ISalaView _view;
        private readonly RepozytoriumSal _repoSal;
        private readonly RepozytoriumWydzialow _repoWydzialow;

        public SalaPresenter(ISalaView view)
        {
            _view = view;
            _repoSal = RepozytoriumSal.Instance;
            _repoWydzialow = RepozytoriumWydzialow.Instance;

            OdswiezWydzialy();

            _view.OnDodajSaleClick += ObsluzDodawanie;
        }

        private void OdswiezWydzialy()
        {
            _view.UstawListeWydzialow(_repoWydzialow.lista_wydzialow);
        }

        private void ObsluzDodawanie()
        {
            if (string.IsNullOrWhiteSpace(_view.Numer) || _view.WydzialSali == null)
            {
                MessageBox.Show("Podaj numer sali i wybierz wydział!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_repoSal.CzyIstnieje(_view.Numer, _view.WydzialSali))
            {
                MessageBox.Show("Ta sala już istnieje na wybranym wydziale.", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var nowaSala = new Sala
            {
                Numer = _view.Numer,
                Pojemnosc = _view.Pojemnosc,
                WydzialSali = _view.WydzialSali, 
                Typ = _view.Typ
            };

            _repoSal.Dodaj(nowaSala);
        }
    }
}
