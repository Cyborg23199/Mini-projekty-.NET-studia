using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2.Modele;

namespace Lab_2.Widok.Interfejsy
{
    public interface IProwadzacyView
    {
        string Imie { get; }
        string Nazwisko { get; }
        Tytul WybranyTytul { get; }

        event Action OnDodajProwadzacegoClick;
    }
}
