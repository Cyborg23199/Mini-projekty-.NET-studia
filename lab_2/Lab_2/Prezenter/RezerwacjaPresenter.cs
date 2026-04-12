using Lab_2.Modele;
using Lab_2.Widok.Interfejsy;
using Lab_2.Repozytoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2.Prezenter
{
    public class RezerwacjaPresenter
    {
        private readonly IRezerwacjaView _view;
        private readonly RepozytoriumRezerwacji _repoRez;
        private readonly RepozytoriumSal _repoSal;
        private readonly RepozytoriumProwadzacych _repoProw;

        public RezerwacjaPresenter(IRezerwacjaView view)
        {
            _view = view;
            _repoRez = RepozytoriumRezerwacji.Instance;
            _repoSal = RepozytoriumSal.Instance;
            _repoProw = RepozytoriumProwadzacych.Instance;

            _view.UstawListeSal(_repoSal.lista_sal);
            _view.UstawListeProwadzacych(_repoProw.lista_prowadzacych);

            _view.OnDodajRezerwacjeClick += ObsluzDodawanie;
        }

        private void ObsluzDodawanie()
        {

            if (_view.WybranyProwadzacy == null || _view.WybranaSala == null)
            {
                MessageBox.Show("Podaj sale i prowadzacego!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_view.DataStart >= _view.DataKoniec)
            {
                MessageBox.Show("Data zakończenia musi być późniejsza niż rozpoczęcia!");
                return;
            }

            DateTime dzien = _view.WybranyDzien;
            DateTime od = _view.DataStart;
            DateTime _do = _view.DataKoniec;

            DateTime pelnyStart = new DateTime(
                dzien.Year, dzien.Month, dzien.Day,
                od.Hour, od.Minute, 0
            );

            DateTime pelnyKoniec = new DateTime(
                dzien.Year, dzien.Month, dzien.Day, 
                _do.Hour, _do.Minute, 0);

            var nowaRezerwacja = new Rezerwacja
            {
                SalaRezerwacji = _view.WybranaSala,
                ProwadzacyRezerwacji = _view.WybranyProwadzacy,
                Start = pelnyStart,
                Koniec = pelnyKoniec
            };

            if (!_repoRez.CzyTerminZajety(nowaRezerwacja))
            {
                _repoRez.Dodaj(nowaRezerwacja);
                MessageBox.Show("Rezerwacja dodana pomyślnie!");
            }
            else
            {
                MessageBox.Show("Sala lub prowadzacy są już zajęte w tym terminie!");
            }
        }
    }
}
