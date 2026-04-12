using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Widok.Interfejsy
{
    public interface IWydzialView
    {
        string Nazwa { get; }
        string Miejscowosc { get; }
        string KodPocztowy1 { get; }
        string KodPocztowy2 { get; }
        string Ulica { get; }
        string NumerBudynku { get; }

        event Action OnDodajWydzialClick;

    }
}
