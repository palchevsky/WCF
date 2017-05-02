using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFClient.ServiceReference1;

namespace WCFClient
{
    public partial class MainForm : Form
    {
        private string path;
        private DiskInfoClient proxy;

        public MainForm()
        {
            proxy = new DiskInfoClient();
            InitializeComponent();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderDialog.SelectedPath;
            }

            string[] results = proxy.GetDiskInfo(path);
            List<string> listOfResulst = new List<string>();

            if (lbContents.Items != null)
            { lbContents.Items.Clear(); }

            if (results != null)
            {
                foreach (var result in results)
                {
                    lbContents.Items.Add(result);
                }
            }
        }
    }
}
