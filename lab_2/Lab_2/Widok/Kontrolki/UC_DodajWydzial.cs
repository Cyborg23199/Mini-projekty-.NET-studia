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

namespace Lab_2.Widok.Kontrolki
{
    public partial class UC_DodajWydzial : UserControl, IWydzialView
    {
        public UC_DodajWydzial()
        {
            InitializeComponent();

            var fixedSize = new Size(370, 275);
            this.MinimumSize = fixedSize;
            this.MaximumSize = fixedSize;
            this.Size = fixedSize;

            textBox_kodPocztowy1.MaxLength = 2;
            textBox_kodPocztowy2.MaxLength = 3;

            textBox_kodPocztowy1.TextChanged += TextBox_kodPocztowy1_TextChanged;

            textBox_nazwaWydzialu.KeyPress += Walidacja.tylkoLitery_KeyPress;
            textBox_miejscowosc.KeyPress += Walidacja.tylkoLitery_KeyPress;
            textBox_ulica.KeyPress += Walidacja.tylkoLitery_KeyPress;

            textBox_kodPocztowy1.KeyPress += Walidacja.tylkoCyfry_KeyPress;
            textBox_kodPocztowy2.KeyPress += Walidacja.tylkoCyfry_KeyPress;
            textBox_numerBudynku.KeyPress += Walidacja.tylkoCyfry_KeyPress;

            button_dodajWydzial.Click += (s, e) => OnDodajWydzialClick?.Invoke();
        }

        private void TextBox_kodPocztowy1_TextChanged(object? sender, EventArgs e)
        {
            if (textBox_kodPocztowy1.Text.Length == 2)
            {
                textBox_kodPocztowy2.Focus();
            }
        }

        public string Nazwa => textBox_nazwaWydzialu.Text;
        public string Miejscowosc => textBox_miejscowosc.Text;
        public string KodPocztowy1 => textBox_kodPocztowy1.Text;
        public string KodPocztowy2 => textBox_kodPocztowy2.Text;
        public string Ulica => textBox_ulica.Text;
        public string NumerBudynku => textBox_numerBudynku.Text;

        public event Action OnDodajWydzialClick;
    }
}
