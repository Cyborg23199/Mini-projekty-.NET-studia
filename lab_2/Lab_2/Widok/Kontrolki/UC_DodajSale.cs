using Lab_2.Modele;
using Lab_2.Serwis;
using Lab_2.Widok.Interfejsy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_2.Widok.Kontrolki
{
    public partial class UC_DodajSale : UserControl, ISalaView
    {
        public UC_DodajSale()
        {
            InitializeComponent();

            comboBox_typSali.DataSource = Enum.GetValues(typeof(TypSali));


            textBox_numerSali.KeyPress += Walidacja.tylkoCyfry_KeyPress;
            button_dodajSale.Click += (s, e) => OnDodajSaleClick?.Invoke();
        }

        public string Numer => textBox_numerSali.Text;
        public int Pojemnosc => (int)numericUpDown_liczbaMiejsc.Value;
        public TypSali Typ => (TypSali)comboBox_typSali.SelectedItem;
        public Wydzial WydzialSali => (Wydzial)comboBox_wydzial.SelectedItem;

        public void UstawListeWydzialow(BindingList<Wydzial> wydzialy)
        {
            comboBox_wydzial.DataSource = null;
            comboBox_wydzial.DataSource = wydzialy;
            comboBox_wydzial.DisplayMember = "Nazwa";
            comboBox_wydzial.ValueMember = "Nazwa";
        }

        public event Action OnDodajSaleClick;
    }
}
