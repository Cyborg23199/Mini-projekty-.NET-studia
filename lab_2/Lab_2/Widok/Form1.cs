using Lab_2.Modele;
using Lab_2.Repozytoria;
using Lab_2.Prezenter;
using Lab_2.Widok.Kontrolki;

namespace Lab_2
{
    public partial class Form1 : Form
    {

        private WydzialPresenter _wydzialPresenter;
        private SalaPresenter _salaPresenter;
        private ProwadzacyPresenter _prowadzacyPresenter;
        private RezerwacjaPresenter _rezerwacjaPresenter;
        public Form1()
        {
            InitializeComponent();

            listBox_prowadzacy.DataSource = RepozytoriumProwadzacych.Instance.lista_prowadzacych;
            listBox_sale.DataSource = RepozytoriumSal.Instance.lista_sal;
            listBox_rezerwacje.DataSource = RepozytoriumRezerwacji.Instance.lista_rezerwacji;
            listBox_wydzialy.DataSource = RepozytoriumWydzialow.Instance.lista_wydzialow;
            _wydzialPresenter = new WydzialPresenter(uC_DodajWydzial1);
            _salaPresenter = new SalaPresenter(uC_DodajSale1);
            _prowadzacyPresenter = new ProwadzacyPresenter(uC_DodajProwadzacego1);
            _rezerwacjaPresenter = new RezerwacjaPresenter(uC_Rezerwacja1);
        }
        private void tylkoLitery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        private void tylkoCyfry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
