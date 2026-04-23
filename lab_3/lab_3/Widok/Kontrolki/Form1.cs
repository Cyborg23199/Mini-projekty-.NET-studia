using lab_3.Widok.Interfejsy;

namespace lab_3
{
    public partial class Form1 : Form, IWeatherView
    {
        public event EventHandler SearchClicked;

        public Form1()
        {
            InitializeComponent();
            PopulateCapitals();

            button_Search.Click += (s, e) => SearchClicked?.Invoke(this, EventArgs.Empty);

            comboBox_Capitals.SelectedIndexChanged += (s, e) => {
                textBox_City.Text = comboBox_Capitals.SelectedItem.ToString();
                SearchClicked?.Invoke(this, EventArgs.Empty);
            };
        }

        public string CityName => textBox_City.Text;

        public string Temperature
        {
            set => label_Temperature.Text = $"Temperatura: {value}";
        }

        public string Pressure
        {
            set => label_Pressure.Text = $"Ciœnienie: {value}";
        }

        public string Humidity
        {
            set => label_Humidity.Text = $"Wilgotnoœæ: {value}";
        }

        public string Description
        {
            set => label_Description.Text = $"Opis: {value}";
        }

        public string WeatherIcon
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                    pictureBox_Icon.Load(value);
            }
        }

        private void PopulateCapitals()
        {
            string[] capitals = {
                "Warszawa", "Berlin", "Praga", "Pary¿", "Londyn",
                "Rzym", "Madryt", "Wiedeñ", "Ateny", "Sztokholm",
                "Oslo", "Kopenhaga", "Helsinki", "Lizbona", "Dublin",
                "Budapeszt", "Bratys³awa", "Amsterdam", "Bruksela", "Praga"
            };

            comboBox_Capitals.Items.Clear();
            comboBox_Capitals.Items.AddRange(capitals);
            comboBox_Capitals.SelectedIndex = 0;
        }
    }
}
