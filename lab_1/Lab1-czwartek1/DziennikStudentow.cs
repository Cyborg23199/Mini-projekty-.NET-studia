using System.ComponentModel;

namespace Lab1_czwartek1
{    
    internal class DziennikStudentow
    {
        private static DziennikStudentow _instance;
        public static DziennikStudentow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DziennikStudentow();
                }
                return _instance;
            }
        }

        public BindingList<Student> ListaStudentow { get; } = new BindingList<Student>();

        private DziennikStudentow() { }

        public void Dodaj(Student s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s), "Nie można dodać nieistniejącego obiektu studenta.");
            }

            ListaStudentow.Add(s);
        }

        public void Usun(Student s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s), "Nie wskazano studenta do usunięcia.");
            }

            if (!ListaStudentow.Contains(s))
            {
                throw new InvalidOperationException("Próba usunięcia studenta, którego nie ma na liście.");
            }

            ListaStudentow.Remove(s);
        }
    }
}
