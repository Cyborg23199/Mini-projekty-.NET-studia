using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_2.Widok.Interfejsy;
using Lab_2.Serwis;
using Lab_2.Modele;

namespace Lab_2.Widok.Kontrolki
{
    public partial class UC_DodajProwadzacego : UserControl, IProwadzacyView
    {
        public UC_DodajProwadzacego()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(370, 275);

            comboBox_tytul.DataSource = Enum.GetValues(typeof(Tytul));

            textBox_imie.KeyPress += Walidacja.tylkoLitery_KeyPress;
            textBox_nazwisko.KeyPress += Walidacja.tylkoLitery_KeyPress;

            // Podpięcie zdarzenia przycisku
            button_dodajProwadzacego.Click += (s, e) => OnDodajProwadzacegoClick?.Invoke();
        }

        public string Imie => textBox_imie.Text;
        public string Nazwisko => textBox_nazwisko.Text;
        public Tytul WybranyTytul => (Tytul)comboBox_tytul.SelectedItem;

        public event Action OnDodajProwadzacegoClick;
    }
}
