using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class ListaProwadzacych
    {
        private static ListaProwadzacych _instance;

        public static ListaProwadzacych Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListaProwadzacych();
                }
                return _instance;
            }
        }
        public BindingList<Prowadzacy> lista_prowadzacych { get; } = new BindingList<Prowadzacy>();

        private ListaProwadzacych() { }

        public void Dodaj(Prowadzacy s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s), "Nie można dodać nieistniejącego obiektu prowadzacego.");
            }

            lista_prowadzacych.Add(s);
        }

        public void Usun(Prowadzacy s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s), "Nie wskazano prowadzacego do usunięcia.");
            }

            if (!lista_prowadzacych.Contains(s))
            {
                throw new InvalidOperationException("Próba usunięcia prowadzacego, którego nie ma na liście.");
            }

            lista_prowadzacych.Remove(s);
        }
    }
}
