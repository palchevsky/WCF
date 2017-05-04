using System;
using System.Windows.Forms;

namespace WFConverterClient
{
    public partial class ConverterMainForm : Form
    {
        private ConverterClient proxy;

        public ConverterMainForm()
        {
            proxy = new ConverterClient();
            InitializeComponent();
        }

        private void tbMeters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btConvert_Click(object sender, System.EventArgs e)
        {
            var something=proxy.LinearMeasure(Convert.ToDouble(tbMeters.Text));
            
        }

        private void btCelsius_Click(object sender, System.EventArgs e)
        {

        }

        private void btFahrenheit_Click(object sender, System.EventArgs e)
        {

        }
    }
}
