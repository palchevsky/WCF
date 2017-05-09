using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFClient.ServiceReference1;

namespace WFClient
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //CallbackHandler.proxy.Login(tbLogin.Text);
            if (!tbLogin.Text.Equals(String.Empty))
            {
                MainForm.userName = tbLogin.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Input Name!");
            }
        }
    }
}
