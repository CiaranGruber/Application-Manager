using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationManagerForms
{
    public partial class ApplicationManager : Form
    {
        public ApplicationManager()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Btn_Installer_Click(object sender, EventArgs e)
        {
            Hide();
            Form Installer = new ApplicationInstaller();
            Installer.ShowDialog();
            Show();
        }

        private void Btn_Uninstaller_Click(object sender, EventArgs e)
        {
            Hide();
            Form Uninstaller = new ApplicationUninstaller();
            Uninstaller.ShowDialog();
            Show();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
