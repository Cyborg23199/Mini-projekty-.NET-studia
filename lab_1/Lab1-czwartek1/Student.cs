using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_czwartek1
{
    internal enum RokStudiow { I, II, III }

    internal class Student
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Guid Id { get; init; } = Guid.NewGuid();
        public DateTime DataUrodzenia { get; init; }
        public Adres AdresZamieszkania { get; set; }
        public RokStudiow RokStudiow { get; set; }

        public override string ToString() => $"{Imie} {Nazwisko} (ID: {Id})";
    }
}
