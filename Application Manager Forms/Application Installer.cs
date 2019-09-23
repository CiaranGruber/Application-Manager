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
using AppInstallerCode;

namespace ApplicationManagerForms
{
    public partial class ApplicationInstaller : Form
    {
        private bool InstallLocationModified;

        public ApplicationInstaller()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void ApplicationInstaller_Load(object sender, EventArgs e)
        {
            InstallLocationModified = false;
            ChangeInstallText();
        }

        private void ChBox_InstallAdmin_CheckedChanged(object sender, EventArgs e)
        {
            InstallLocationModified = false;
            ChangeInstallText();
        }

        private void ChBox_HasFolder_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_ExecutableName.Text = ChBox_HasFolder.Checked ? "Executable Path (from program location)" : "Executable Name";
            ChangeInstallText();
        }

        private void Txt_InstallLocation_TextChanged(object sender, EventArgs e)
        {
            InstallLocationModified = true;
        }

        private void Txt_ExecutableName_TextChanged(object sender, EventArgs e)
        {
            ChangeInstallText();
        }

        private void Txt_ProgramLocation_TextChanged(object sender, EventArgs e)
        {
            ChangeInstallText();
        }

        private void ChangeInstallText()
        {
            if (!InstallLocationModified)
            {
                if (ChBox_InstallAdmin.Checked)
                {
                    Txt_InstallLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                }
                else
                {
                    Txt_InstallLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                }
                if (ChBox_HasFolder.Checked)
                {
                    Txt_InstallLocation.Text = Path.Combine(Txt_InstallLocation.Text, Path.GetFileName(Txt_ProgramLocation.Text));
                }
                else
                {
                    Txt_InstallLocation.Text = Path.Combine(Txt_InstallLocation.Text, Path.GetFileNameWithoutExtension(Txt_ExecutableName.Text));
                }
                InstallLocationModified = false;
            }
        }

        private void Btn_Install_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(Txt_InstallLocation.Text, Txt_ExecutableName.Text)))
            {
                MessageBox.Show("Application already exists at selected location");
            }
            else if (!File.Exists(Path.Combine(Txt_ProgramLocation.Text, Txt_ExecutableName.Text)))
            {
                MessageBox.Show("Executable located at \"" + Path.Combine(Txt_ProgramLocation.Text, Txt_ExecutableName.Text) + "\" does not exist");
            }
            else if (!Directory.Exists(Txt_ProgramLocation.Text))
            {
                MessageBox.Show("Program folder directory does not exist");

            }
            else if (Directory.Exists(Txt_InstallLocation.Text) || (!Directory.Exists(Txt_InstallLocation.Text) &&
                    MessageBox.Show("Install Folder does not exist so installer will need to create one. Continue?", "Unknown Folder", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                Installer.InstallApp(Txt_ExecutableName.Text, Txt_ShortcutName.Text, Txt_ProgramLocation.Text, Txt_InstallLocation.Text, ChBox_HasFolder.Checked, ChBox_CreateDesktopShortcut.Checked, ChBox_InstallAdmin.Checked);
                MessageBox.Show("Application successfully installed");
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_ExecutableNameBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileExplorer = new OpenFileDialog();
            fileExplorer.Title = "Choose Executable";
            fileExplorer.Multiselect = false;
            fileExplorer.InitialDirectory = Path.Combine(Txt_ProgramLocation.Text, Txt_ExecutableName.Text);
            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                Txt_ExecutableName.Text = fileExplorer.SafeFileName;
            }
        }

        private void Btn_ProgramLocationBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileExplorer = new FolderBrowserDialog();
            fileExplorer.Description = "Choose folder containing the of the program";
            fileExplorer.SelectedPath = Path.Combine(Txt_ProgramLocation.Text, Txt_ExecutableName.Text);
            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                Txt_ProgramLocation.Text = fileExplorer.SelectedPath;
            }
        }

        private void Btn_InstallLocationBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileExplorer = new FolderBrowserDialog();
            fileExplorer.Description = "Choose Location to Install To";
            fileExplorer.SelectedPath = Path.Combine(Txt_ProgramLocation.Text, Txt_ExecutableName.Text);
            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                Txt_InstallLocation.Text = fileExplorer.SelectedPath;
            }
        }
    }
}
