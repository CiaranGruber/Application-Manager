using AppInstallerCode;
using FormUtilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ApplicationManagerForms
{
    public partial class ApplicationUninstaller : Form
    {
        private List<string> Shortcuts;

        public ApplicationUninstaller()
        {
            InitializeComponent();
            Shortcuts = new List<string>();
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
                Uninstaller.UninstallApp(Shortcuts, Txt_InstallLocation.Text);
                MessageBox.Show("Application successfully uninstalled");
            }
            else if (Directory.Exists(Txt_SaveLocation.Text) || (!Directory.Exists(Txt_SaveLocation.Text) &&
                MessageBox.Show("Save Folder does not exist so installer will need to create one. Continue?", "Uninstall", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                Uninstaller.MoveApp(Shortcuts, Txt_InstallLocation.Text, Txt_SaveLocation.Text);
                MessageBox.Show("Application successfully saved to save location");
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
            FolderBrowserDialog fileExplorer = new FolderBrowserDialog
            {
                Description = "Choose location to save To",
                SelectedPath = Txt_SaveLocation.Text
            };
            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                Txt_SaveLocation.Text = fileExplorer.SelectedPath;
            }
        }

        private void Btn_InstallLocationBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileExplorer = new FolderBrowserDialog
            {
                Description = "Choose location of installation",
                SelectedPath = Txt_InstallLocation.Text
            };
            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                Txt_InstallLocation.Text = fileExplorer.SelectedPath;
            }
        }

        private void Btn_AddShortcut_Click(object sender, EventArgs e)
        {
            AddShortcut shortcutAdder = new AddShortcut(Shortcuts);
            shortcutAdder.ShowDialog();
            if (shortcutAdder.DialogResult == DialogResult.OK)
            {
                Shortcuts.Add(shortcutAdder.ShortcutName);

                Panel shortcutPanel = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 25
                };
                Label shortcutLabel = new Label
                {
                    Text = shortcutAdder.ShortcutName,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill,
                    AutoEllipsis = true
                };
                Button removeButton = new Button
                {
                    Text = "Remove",
                    Name = Pnl_Executables.Controls.Count.ToString(),
                    Dock = DockStyle.Right,
                    Width = 100
                };

                removeButton.Click += RemoveButton_Click;

                shortcutPanel.Controls.Add(shortcutLabel);
                shortcutPanel.Controls.Add(removeButton);

                Pnl_Executables.Controls.Insert(0, shortcutPanel);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Button changeButton = (Button)sender;
            int index = Convert.ToInt32(changeButton.Name);
            int panelIndex = Pnl_Executables.Controls.Count - index - 1;
            Shortcuts.RemoveAt(index);
            Pnl_Executables.Controls.RemoveAt(panelIndex);
        }
    }
}
