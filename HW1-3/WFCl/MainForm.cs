using System;
using System.Windows.Forms;
using WFCl.ServiceReference1;

namespace WFCl
{
    public partial class MainForm : Form
    {
        private ConverterClient proxy;

        public MainForm()
        {
            InitializeComponent();
            proxy = new ConverterClient();
        }

        private void tbMeters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btConvert1_Click(object sender, EventArgs e)
        {
            try
            {
                var something = proxy.LinearMeasure(Convert.ToDouble(tbMeters.Text));
                lbFeetNum.Text = something.Ft.ToString();
                lbInchNum.Text = something.Inch.ToString();
                lbYardNum.Text = something.Yard.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btConvert2_Click(object sender, EventArgs e)
        {
            try
            {
                var something = proxy.CelsiusToFahrenheit(Convert.ToDouble(tbCelsius.Text));
                tbFahrenheit.Text = something.Fahrenheit.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btConvert3_Click(object sender, EventArgs e)
        {
            try
            {
                var something = proxy.FahrenheitToCelsius(Convert.ToDouble(tbFahrenheit.Text));
                tbCelsius.Text = something.Celsius.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
