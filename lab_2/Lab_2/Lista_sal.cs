using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class ListaSal
    {
        private static ListaSal _instance;

        public static ListaSal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListaSal();
                }
                return _instance;
            }
        }
        public BindingList<Sala> lista_sal { get; } = new BindingList<Sala>();

        private ListaSal() { }

        public void Dodaj(Sala s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s), "Nie można dodać nieistniejącego obiektu sali.");
            }

            lista_sal.Add(s);
        }

        public void Usun(Sala s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s), "Nie wskazano sali do usunięcia.");
            }

            if (!lista_sal.Contains(s))
            {
                throw new InvalidOperationException("Próba usunięcia sali, której nie ma na liście.");
            }

            lista_sal.Remove(s);
        }
    }
}
