namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox_prowadzacy.DataSource = ListaProwadzacych.Instance.lista_prowadzacych;
            listBox_sale.DataSource = ListaSal.Instance.lista_sal;
            comboBox_Tytul.DataSource = Enum.GetValues(typeof(Tytul));
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
