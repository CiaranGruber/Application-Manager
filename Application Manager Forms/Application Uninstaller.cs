using AppInstallerCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationManagerForms
{
    public partial class ApplicationUninstaller : Form
    {
        public ApplicationUninstaller()
        {
            InitializeComponent();
        }

        private void ApplicationUninstaller_Load(object sender, EventArgs e)
        {
            Height -= 66;
            Txt_InstallLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        }

        private void Btn_Uninstall_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Txt_InstallLocation.Text))
            {
                MessageBox.Show("Install Location does not exist");
            }
            else if (!ChBox_SaveData.Checked)
            {
                Uninstaller.UninstallApp(Txt_ShortcutName.Text, Txt_InstallLocation.Text);
            }
            else if (Directory.Exists(Txt_SaveLocation.Text) || (!Directory.Exists(Txt_SaveLocation.Text) && 
                MessageBox.Show("Save Folder does not exist so installer will need to create one. Continue?", "Uninstall", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                Uninstaller.MoveApp(Txt_ShortcutName.Text, Txt_InstallLocation.Text, Txt_SaveLocation.Text);
            }
        }

        private void ChBox_SaveData_CheckedChanged(object sender, EventArgs e)
        {
            Pnl_SaveLocation.Visible = ChBox_SaveData.Checked;
            Height += ChBox_SaveData.Checked ? 66 : -66;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_SaveLocationBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileExplorer = new FolderBrowserDialog();
            fileExplorer.Description = "Choose Location to Install To";
            fileExplorer.SelectedPath = Txt_SaveLocation.Text;
            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                Txt_SaveLocation.Text = fileExplorer.SelectedPath;
            }
        }

        private void Btn_InstallLocationBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileExplorer = new FolderBrowserDialog();
            fileExplorer.Description = "Choose Location to Install To";
            fileExplorer.SelectedPath = Txt_InstallLocation.Text;
            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                Txt_InstallLocation.Text = fileExplorer.SelectedPath;
            }
        }
    }
}
