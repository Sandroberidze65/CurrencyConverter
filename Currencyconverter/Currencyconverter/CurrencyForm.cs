using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Currencyconverter.Currencyconveter;

namespace Currencyconverter
{
    public partial class CurrencyForm : Form
    {
        string[] CurrencyValues = new string[]
        {
            "AED", "AMD", "AUD", "AZN", "BGN", "BYR", "CAD", "CHF", "CNY", "CZK", "DKK", "EEK", "USD", "UZS",
            "EGP", "EUR", "GBP", "HKD", "HUF", "ILS", "INR", "IRR", "ISK", "JPY", "KGS", "KWD", "TRY", "UAH",
            "KZT", "LTL", "LVL", "MDL", "NOK", "NZD", "PLN", "RON", "RSD", "RUB", "SEK", "SGD", "TJS", "TMT"
        };

        decimal FromCurrency = 0;
        decimal ToCurrency = 0;
        NBGCurrencyPortClient client;

        public CurrencyForm()
        {
            InitializeComponent();
        }

        private void CurrencyForm_Load(object sender, EventArgs e)
        {
            client = new NBGCurrencyPortClient();

            foreach (var each in CurrencyValues)
            {
                comboBox_from.Items.Add(each);
                comboBox_To.Items.Add(each);
            }

            comboBox_from.SelectedText = "USD";
            comboBox_To.SelectedText = "USD";
        }

        private void comboBox_from_SelectedValueChanged(object sender, EventArgs e)
        {
            action();

        }

        private void action()
        {
            FromCurrency = CurrencyHandler(comboBox_from.Text);
            ToCurrency = CurrencyHandler(comboBox_To.Text);

            if (decimal.TryParse(textBox_from.Text, out decimal money))
                textBox_to.Text = (money * FromCurrency / ToCurrency).ToString();
            else
                MessageBox.Show("Invalid value!");
            this.chart_statistic.Series.Clear();
            Series series = this.chart_statistic.Series.Add("GeL");

            valueNew(series);
        }

        private void valueNew(Series series)
        {
            var CurrentFrom = client.GetCurrency(comboBox_from.Text);
            var CurrentTo = client.GetCurrency(comboBox_To.Text);


            series.Points.AddXY(client.GetCurrencyDescription(comboBox_from.Text), decimal.Parse(CurrentFrom));
            series.Points.AddXY(client.GetCurrencyDescription(comboBox_To.Text), decimal.Parse(CurrentTo));
        }


        private decimal CurrencyHandler(string value)
        {
            var rateResponse = client.GetCurrency(value);
            var infoResponse = client.GetCurrencyDescription(value).Split()[0];

            if (decimal.TryParse(rateResponse, out decimal rate)
                && int.TryParse(infoResponse, out int info))
            {
                return rate / info;
            }
            MessageBox.Show("Invalid value");
            return default(decimal);
        }

        private void textBox_from_TextChanged(object sender, EventArgs e)
        {
            if (textBox_from.Text!="")
            {
             action();
            }
        }
    }
}
