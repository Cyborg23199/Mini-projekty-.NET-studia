using Lab_2.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Lab_2.Widok.Interfejsy
{
    public interface ISalaView
    {
        string Numer { get; }
        int Pojemnosc { get; }
        TypSali Typ { get; }
        Wydzial WydzialSali { get; }

        void UstawListeWydzialow(BindingList<Wydzial> wydzialy);

        event Action OnDodajSaleClick;
    }
}
