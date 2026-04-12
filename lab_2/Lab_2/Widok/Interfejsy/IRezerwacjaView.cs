using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2.Modele;
using System.ComponentModel;

namespace Lab_2.Widok.Interfejsy
{
    public interface IRezerwacjaView
    {
        Sala WybranaSala { get; }
        Prowadzacy WybranyProwadzacy { get; }
        DateTime DataStart { get; }
        DateTime DataKoniec { get; }
        DateTime WybranyDzien { get; }

        void UstawListeSal(BindingList<Sala> sale);
        void UstawListeProwadzacych(BindingList<Prowadzacy> prowadzacy);

        event Action OnDodajRezerwacjeClick;
    }
}
