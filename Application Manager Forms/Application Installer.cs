using AppInstallerCode;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using FormUtilities;

namespace ApplicationManagerForms
{
    public partial class ApplicationInstaller : Form
    {
        private bool InstallLocationModified;
        private List<ExecutableData> Executables;

        public ApplicationInstaller()
        {
            Executables = new List<ExecutableData>();
            InitializeComponent();
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
                else if (Executables.Count > 0)
                {
                    Txt_InstallLocation.Text = Path.Combine(Txt_InstallLocation.Text, Executables[0].ShortcutName);
                }
            }
        }

        private bool ApplicationExists()
        {
            foreach (ExecutableData executableData in Executables)
            {
                if (File.Exists(Path.Combine(Txt_InstallLocation.Text, executableData.ExecutablePath)))
                {
                    return true;
                }
            }
            return false;
        }

        private bool AllExecutablesExist()
        {
            foreach (ExecutableData executableData in Executables)
            {
                if (!File.Exists(Path.Combine(Txt_ProgramLocation.Text, executableData.ExecutablePath)))
                {
                    return false;
                }
            }
            return true;
        }

        private void Btn_Install_Click(object sender, EventArgs e)
        {
            if (ApplicationExists())
            {
                MessageBox.Show("Application already exists at selected location");
            }
            else if (!AllExecutablesExist())
            {
                string nonExistentExecString = "";
                foreach (ExecutableData executableData in Executables)
                {
                    if (!File.Exists(Path.Combine(Txt_ProgramLocation.Text, executableData.ExecutablePath)))
                    {
                        nonExistentExecString += "\"" + executableData.ExecutablePath + "\", ";
                    }
                }
                nonExistentExecString = nonExistentExecString.Substring(0, nonExistentExecString.Length - 2);
                MessageBox.Show("Executables located at the locations (relative to Program Location)" + nonExistentExecString + " does not exist");
            }
            else if (!Directory.Exists(Txt_ProgramLocation.Text))
            {
                MessageBox.Show("Program folder directory does not exist");

            }
            else if (Directory.Exists(Txt_InstallLocation.Text) || (!Directory.Exists(Txt_InstallLocation.Text) &&
                    MessageBox.Show("Install Folder does not exist so installer will need to create one. Continue?", "Unknown Folder", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                Installer.InstallApp(Executables, Txt_ProgramLocation.Text, Txt_InstallLocation.Text, ChBox_HasFolder.Checked, ChBox_InstallAdmin.Checked);
                MessageBox.Show("Application successfully installed");
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_ProgramLocationBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileExplorer = new FolderBrowserDialog
            {
                Description = "Choose folder containing the of the program",
                SelectedPath = Txt_ProgramLocation.Text
            };
            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                Txt_ProgramLocation.Text = fileExplorer.SelectedPath;
            }
        }

        private void Btn_InstallLocationBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileExplorer = new FolderBrowserDialog
            {
                Description = "Choose Location to Install To",
                SelectedPath = Txt_InstallLocation.Text
            };
            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                Txt_InstallLocation.Text = fileExplorer.SelectedPath;
            }
        }

        private void Btn_AddExecutable_Click(object sender, EventArgs e)
        {
            ChooseExecutables executableChooser = new ChooseExecutables(Txt_ProgramLocation.Text, Executables);
            if (executableChooser.ShowDialog() == DialogResult.Yes)
            {
                ExecutableData executable = executableChooser.NewExecutable;
                Executables.Add(executable);

                Panel newPanel = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 25
                };
                Label shortcutLabel = new Label
                {
                    Text = executable.ShortcutName,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Left,
                    Width = 175,
                    AutoEllipsis = true
                };
                Label pathLabel = new Label
                {
                    Text = executable.ExecutablePath,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill,
                    AutoEllipsis = true
                };
                CheckBox onDesktop = new CheckBox
                {
                    Enabled = false,
                    Checked = executable.OnDesktop,
                    Dock = DockStyle.Right,
                    Width = 75
                };
                Button changeButton = new Button
                {
                    Text = "Change",
                    Name = Pnl_Executables.Controls.Count.ToString(),
                    Dock = DockStyle.Right,
                    Width = 100
                };
                changeButton.Click += ChangeButton_Click;

                newPanel.Controls.Add(pathLabel);
                newPanel.Controls.Add(shortcutLabel);
                newPanel.Controls.Add(onDesktop);
                newPanel.Controls.Add(changeButton);

                Pnl_Executables.Controls.Insert(0, newPanel);
            }
            ChangeInstallText();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            Button changeButton = (Button)sender;
            int index = Convert.ToInt32(changeButton.Name);
            int panelIndex = Pnl_Executables.Controls.Count - index - 1;
            ChooseExecutables executableChooser = new ChooseExecutables(Txt_ProgramLocation.Text, Executables, Executables[index]);
            executableChooser.ShowDialog();
            if (executableChooser.DialogResult == DialogResult.Yes)
            {
                ExecutableData executable = executableChooser.NewExecutable;
                Executables[index] = executable;
                Pnl_Executables.Controls[panelIndex].Controls[1].Text = executable.ShortcutName;
                Pnl_Executables.Controls[panelIndex].Controls[0].Text = executable.ExecutablePath;
                ((CheckBox) Pnl_Executables.Controls[panelIndex].Controls[2]).Checked = executable.OnDesktop;
            }
            else if (executableChooser.DialogResult == DialogResult.No)
            {
                Executables.RemoveAt(index);
                Pnl_Executables.Controls.RemoveAt(panelIndex);
            }
        }
    }
}
