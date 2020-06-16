using System;
using System.Windows.Forms;

namespace ApplicationManagerForms
{
    public partial class ApplicationManager : Form
    {
        public ApplicationManager()
        {
            InitializeComponent();
        }

        private void Btn_Installer_Click(object sender, EventArgs e)
        {
            Hide();
            Form Installer = new ApplicationInstaller();
            Installer.ShowDialog();
            CenterToScreen();
            Show();
        }

        private void Btn_Uninstaller_Click(object sender, EventArgs e)
        {
            Hide();
            Form Uninstaller = new ApplicationUninstaller();
            Uninstaller.ShowDialog();
            CenterToScreen();
            Show();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
