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
    public partial class UC_Rezerwacja : UserControl, IRezerwacjaView
    {
        public UC_Rezerwacja()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(370, 275);
            dateTimePicker_start.Format = DateTimePickerFormat.Custom;
            dateTimePicker_start.CustomFormat = "HH:mm";

            dateTimePicker_koniec.Format = DateTimePickerFormat.Custom;
            dateTimePicker_koniec.CustomFormat = "HH:mm";
            button_rezerwacja.Click += (s, e) => OnDodajRezerwacjeClick?.Invoke();
        }

        // Pobieranie wybranych obiektów
        public Sala WybranaSala => (Sala)comboBox_wyborSali.SelectedItem;
        public Prowadzacy WybranyProwadzacy => (Prowadzacy)comboBox_wyborProwadzacego.SelectedItem;
        public DateTime DataStart => dateTimePicker_start.Value;
        public DateTime DataKoniec => dateTimePicker_koniec.Value;
        public DateTime WybranyDzien => dateTimePicker_data.Value;

        public void UstawListeSal(BindingList<Sala> sale)
        {
            comboBox_wyborSali.DataSource = null;
            comboBox_wyborSali.DataSource = sale;
            comboBox_wyborSali.DisplayMember = "NumerSali";
        }

        public void UstawListeProwadzacych(BindingList<Prowadzacy> prowadzacy)
        {
            comboBox_wyborProwadzacego.DataSource = null;
            comboBox_wyborProwadzacego.DataSource = prowadzacy;
            comboBox_wyborProwadzacego.DisplayMember = "Nazwisko";
        }

        public event Action OnDodajRezerwacjeClick;
    }
}
