using System.Diagnostics.Eventing.Reader;
using System.Text.Json;

namespace Lab1_czwartek1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            listBox_listaStudentow.DataSource = DziennikStudentow.Instance.ListaStudentow;
            comboBox_rok.DataSource = Enum.GetValues(typeof(RokStudiow));
            btnDodaj.Enabled = false;
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student
                {
                    Imie = textBox_imie.Text,
                    Nazwisko = textBox_nazwisko.Text,
                    DataUrodzenia = dateTimePicker1.Value,
                    RokStudiow = (RokStudiow)comboBox_rok.SelectedItem,
                    AdresZamieszkania = new Adres
                    {
                        Miejscowosc = textBox_miasto.Text,
                        KodPocztowy = textBox_kod1.Text + "-" + textBox_kod2.Text,
                        Ulica = textBox_ulica.Text,
                        NumerBudynku = textBox_numerBudynku.Text,
                        NumerMieszkania = textBox_numerMieszkania.Text
                    }
                };

                DziennikStudentow.Instance.Dodaj(s);

                WyczyscFormularz();

                MessageBox.Show("Student zosta³ dodany pomyœlnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"B³¹d podczas dodawania: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WyczyscFormularz()
        {
            textBox_imie.Clear();
            textBox_nazwisko.Clear();
            textBox_miasto.Clear();
            textBox_ulica.Clear();
            textBox_numerBudynku.Clear();
            textBox_kod1.Clear();
            textBox_kod2.Clear();
            textBox_numerMieszkania.Clear();
            checkBox_mieszkanie.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            comboBox_rok.SelectedIndex = 0;
            errorProvider1.Clear();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pliki JSON (*.json)|*.json";
            sfd.Title = "Zapisz listê studentów";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var opcje = new JsonSerializerOptions { WriteIndented = true };

                    string jsonString = JsonSerializer.Serialize(DziennikStudentow.Instance.ListaStudentow, opcje);

                    File.WriteAllText(sfd.FileName, jsonString);

                    MessageBox.Show("Lista zosta³a zapisana pomyœlnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"B³¹d podczas zapisu: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (listBox_listaStudentow.SelectedItem is Student wybranyStudent)
            {
                var wynik = MessageBox.Show($"Czy na pewno chcesz usun¹æ studenta {wybranyStudent.Imie} {wybranyStudent.Nazwisko}?",
                                             "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (wynik == DialogResult.Yes)
                {
                    DziennikStudentow.Instance.ListaStudentow.Remove(wybranyStudent);

                    WyczyscFormularz();
                }
            }
            else
            {
                MessageBox.Show("Najpierw zaznacz studenta na liœcie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_Litery_KeyPress(object sender, KeyPressEventArgs e)
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

        private void listBox_listaStudentow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_listaStudentow.SelectedItem is Student s)
            {
                textBox_imie.Text = s.Imie;
                textBox_nazwisko.Text = s.Nazwisko;
                dateTimePicker1.Value = s.DataUrodzenia;
                comboBox_rok.SelectedItem = s.RokStudiow;

                if (s.AdresZamieszkania != null)
                {
                    textBox_miasto.Text = s.AdresZamieszkania.Miejscowosc;
                    textBox_ulica.Text = s.AdresZamieszkania.Ulica;
                    textBox_numerBudynku.Text = s.AdresZamieszkania.NumerBudynku;

                    if (!string.IsNullOrEmpty(s.AdresZamieszkania.KodPocztowy) && s.AdresZamieszkania.KodPocztowy.Contains("-"))
                    {
                        string[] czesciKodu = s.AdresZamieszkania.KodPocztowy.Split('-');
                        textBox_kod1.Text = czesciKodu[0];
                        textBox_kod2.Text = czesciKodu[1];
                    }

                    if (!string.IsNullOrEmpty(s.AdresZamieszkania.NumerMieszkania))
                    {
                        checkBox_mieszkanie.Checked = true;
                        textBox_numerMieszkania.Text = s.AdresZamieszkania.NumerMieszkania;
                        textBox_numerMieszkania.Enabled = true;
                    }
                    else
                    {
                        checkBox_mieszkanie.Checked = false;
                        textBox_numerMieszkania.Text = "";
                        textBox_numerMieszkania.Enabled = false;
                    }
                }
            }
        }

        private void textBox_kod1_TextChanged(object sender, EventArgs e)
        {
            if (textBox_kod1.Text.Length == 2)
            {
                textBox_kod2.Focus();
            }

            btnDodaj.Enabled = CzyCaloscJestPoprawna();
        }

        private void textBox_kod2_TextChanged(object sender, EventArgs e)
        {
            btnDodaj.Enabled = CzyCaloscJestPoprawna();
        }

        private void textBox_kod_Leave(object sender, EventArgs e)
        {
            if (this.ActiveControl == textBox_kod1 || this.ActiveControl == textBox_kod2)
            {
                return;
            }

            bool kodOk = textBox_kod1.Text.Length == 2 && textBox_kod2.Text.Length == 3;

            if (!kodOk && (!string.IsNullOrWhiteSpace(textBox_kod1.Text) || !string.IsNullOrWhiteSpace(textBox_kod2.Text)))
            {
                errorProvider1.SetError(textBox_kod2, "Kod pocztowy musi mieæ format XX-XXX");
            }
            else
            {
                errorProvider1.SetError(textBox_kod2, "");
            }
        }

        private void WalidujFormularz_TextChanged(object sender, EventArgs e)
        {
            if (sender is Control kontrolka)
            {
                PokazBladDlaKontrolki(kontrolka);
            }

            btnDodaj.Enabled = CzyCaloscJestPoprawna();
        }

        private void PokazBladDlaKontrolki(Control c)
        {
            if (c == textBox_numerMieszkania)
            {
                bool mieszkanieOk = true;
                if (checkBox_mieszkanie.Checked)
                {
                    mieszkanieOk = !string.IsNullOrWhiteSpace(textBox_numerMieszkania.Text);
                    if (!mieszkanieOk)
                        errorProvider1.SetError(textBox_numerMieszkania, "Podaj numer mieszkania!");
                    else
                        errorProvider1.SetError(textBox_numerMieszkania, "");
                }
            }
            else if (c == textBox_imie)
            {
                if (string.IsNullOrWhiteSpace(textBox_imie.Text))
                    errorProvider1.SetError(textBox_imie, "Imiê nie mo¿e byæ puste!");
                else
                    errorProvider1.SetError(textBox_imie, "");
            }
            else if (c == textBox_ulica)
            {
                if (string.IsNullOrWhiteSpace(textBox_ulica.Text))
                    errorProvider1.SetError(textBox_ulica, "Ulica nie mo¿e byæ pusta!");
                else
                    errorProvider1.SetError(textBox_ulica, "");
            }
            else if (c == textBox_miasto)
            {
                if (string.IsNullOrWhiteSpace(textBox_miasto.Text))
                    errorProvider1.SetError(textBox_miasto, "Miasto nie mo¿e byæ puste!");
                else
                    errorProvider1.SetError(textBox_miasto, "");
            }
            else if (c == textBox_numerBudynku)
            {
                if (string.IsNullOrWhiteSpace(textBox_numerBudynku.Text))
                    errorProvider1.SetError(textBox_numerBudynku, "Miasto nie mo¿e byæ puste!");
                else
                    errorProvider1.SetError(textBox_numerBudynku, "");
            }
            else if (c == textBox_nazwisko)
            {
                if (string.IsNullOrWhiteSpace(textBox_nazwisko.Text))
                    errorProvider1.SetError(textBox_nazwisko, "Nazwisko nie mo¿e byæ puste!");
                else
                    errorProvider1.SetError(textBox_nazwisko, "");
            }

        }

        private bool CzyCaloscJestPoprawna()
        {
            bool kodOk = textBox_kod1.Text.Length == 2 && textBox_kod2.Text.Length == 3;
            bool mieszkanieOk = true;
            if (checkBox_mieszkanie.Checked)
            {
                mieszkanieOk = !string.IsNullOrWhiteSpace(textBox_numerMieszkania.Text);
            }

            return !string.IsNullOrWhiteSpace(textBox_imie.Text)
                                    && !string.IsNullOrWhiteSpace(textBox_nazwisko.Text)
                                    && !string.IsNullOrWhiteSpace(textBox_miasto.Text)
                                    && !string.IsNullOrWhiteSpace(textBox_ulica.Text)
                                    && !string.IsNullOrWhiteSpace(textBox_numerBudynku.Text)
                                    && kodOk
                                    && mieszkanieOk;
        }

        private void checkBox_mieszkanie_CheckedChanged(object sender, EventArgs e)
        {

            textBox_numerMieszkania.Enabled = checkBox_mieszkanie.Checked;

            if (!checkBox_mieszkanie.Checked)
            {
                textBox_numerMieszkania.Clear();
                errorProvider1.SetError(textBox_numerMieszkania, "");
            }

            btnDodaj.Enabled = CzyCaloscJestPoprawna();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (listBox_listaStudentow.SelectedItem is Student wybranyStudent)
            {
                wybranyStudent.Imie = textBox_imie.Text;
                wybranyStudent.Nazwisko = textBox_nazwisko.Text;
                wybranyStudent.RokStudiow = (RokStudiow)comboBox_rok.SelectedItem;

                if (wybranyStudent.AdresZamieszkania != null)
                {
                    wybranyStudent.AdresZamieszkania.Miejscowosc = textBox_miasto.Text;
                    wybranyStudent.AdresZamieszkania.Ulica = textBox_ulica.Text;
                    wybranyStudent.AdresZamieszkania.NumerBudynku = textBox_numerBudynku.Text;
                    wybranyStudent.AdresZamieszkania.KodPocztowy = $"{textBox_kod1.Text}-{textBox_kod2.Text}";
                    wybranyStudent.AdresZamieszkania.NumerMieszkania = checkBox_mieszkanie.Checked ? textBox_numerMieszkania.Text : null;
                }

                int index = listBox_listaStudentow.SelectedIndex;
                DziennikStudentow.Instance.ListaStudentow[index] = wybranyStudent;

                MessageBox.Show("Dane studenta zosta³y zaktualizowane!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Najpierw zaznacz studenta, którego chcesz edytowaæ!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki JSON (*.json)|*.json";
            ofd.Title = "Wybierz plik z list¹ studentów";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = File.ReadAllText(ofd.FileName);

                    var wczytaniStudenci = JsonSerializer.Deserialize<List<Student>>(jsonString);

                    if (wczytaniStudenci != null)
                    {
                        DziennikStudentow.Instance.ListaStudentow.Clear();
                        foreach (var s in wczytaniStudenci)
                        {
                            DziennikStudentow.Instance.Dodaj(s);
                        }

                        MessageBox.Show("Lista zosta³a wczytana!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"B³¹d podczas wczytywania: {ex.Message}\nUpewnij siê, ¿e plik ma poprawny format.",
                                    "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

