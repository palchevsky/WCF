using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFClient.ServiceReference1;

namespace WFClient
{
    [CallbackBehavior(
        ConcurrencyMode = ConcurrencyMode.Single,
        UseSynchronizationContext = false)]
    public partial class MainForm : Form, ServiceReference1.IDuplexSrvCallback
    {
        private SynchronizationContext _syncContext = null;
        private ServiceReference1.DuplexSrvClient _proxy = null;
        public static string userName = "";
        public static string receivedText = "";

        public MainForm()
        {
            InitializeComponent();
        }

        public void TextForUsers(string text)
        {
            throw new NotImplementedException();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.ShowDialog();
            _proxy.Login(userName);
            tbSendText.Enabled = true;
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            _proxy.Logout(userName);
        }

        private void btSendText_Click(object sender, EventArgs e)
        {
            _proxy.SendText(tbSendText.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _syncContext = SynchronizationContext.Current;
            _proxy = new DuplexSrvClient(new InstanceContext(this), "WSDualHttpBinding_IDuplexSrv");
            _proxy.Open();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _proxy.Close();
        }

        private void WriteMessage(string message)
        {
            string format = tbReceivedText.Text.Length > 0 ? "{0}\r\n{1} {2}" : "{0}{1} {2}";
            tbReceivedText.Text = String.Format(format, tbReceivedText.Text, DateTime.Now.ToShortTimeString(), message);
            tbReceivedText.SelectionStart = tbReceivedText.Text.Length - 1;
            tbReceivedText.ScrollToCaret();
        }

        public void NotifyUserLogin(string userName)
        {
            SendOrPostCallback callback =
                delegate (object state)
                {
                    string messageUser = state.ToString();
                    WriteMessage(String.Format("{0} has joined", messageUser));
                };
            _syncContext.Post(callback, userName);
        }

        public void NotifyUserOfMessage(string userName, string userMessage)
        {
            SendOrPostCallback callback =
                delegate (object state)
                {
                    WriteMessage(String.Format("{0}: {1}", userName, userMessage));
                };
            _syncContext.Post(callback, userName);
        }

        public void NotifyUserLogout(string userName)
        {
            SendOrPostCallback callback =
                delegate (object state)
                {
                    string messageUser = state.ToString();
                    WriteMessage(String.Format("{0} has logout", messageUser));
                };
            _syncContext.Post(callback, userName);
        }

    }
}
