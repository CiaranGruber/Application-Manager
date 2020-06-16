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
    public partial class ChooseExecutables : Form
    {
        private string ProgramLocation { get; set; }
        private List<ExecutableData> Executables { get; set; }
        public ExecutableData NewExecutable { get; set; }
        public bool ChangingExecutables { get; set; }
        private ExecutableData PrevExecutable { get; set; }
        private bool ExecNameChanged { get; set; }

        public ChooseExecutables(string programLocation, List<ExecutableData> executables)
        {
            InitializeComponent();
            ProgramLocation = programLocation;
            Executables = executables;
            Btn_AddExecutable.Text = "Add";
            Btn_RemoveExecutable.Text = "Cancel";
            DialogResult = DialogResult.Cancel;
            ChangingExecutables = false;
            ExecNameChanged = false;
        }

        public ChooseExecutables(string programLocation, List<ExecutableData> executables, ExecutableData prevExecutable)
        {
            InitializeComponent();
            ProgramLocation = programLocation;
            Executables = executables;
            Btn_AddExecutable.Text = "Change";
            Btn_RemoveExecutable.Text = "Remove";
            Txt_ShortcutName.Text = prevExecutable.ShortcutName;
            Txt_ExecutablePath.Text = prevExecutable.ExecutablePath;
            ChBox_OnDesktop.Checked = prevExecutable.OnDesktop;
            PrevExecutable = new ExecutableData(prevExecutable.ShortcutName, prevExecutable.ExecutablePath, prevExecutable.OnDesktop);
            DialogResult = DialogResult.Cancel;
            ChangingExecutables = true;
            ExecNameChanged = true;
        }

        private void Btn_ExecutableNameBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileExplorer = new OpenFileDialog
            {
                Title = "Choose Executable",
                Multiselect = false,
                InitialDirectory = Path.Combine(ProgramLocation, Txt_ExecutablePath.Text)
            };
            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                Txt_ExecutablePath.Text = fileExplorer.SafeFileName;
            }
        }

        private void Btn_AddExecutable_Click(object sender, EventArgs e)
        {
            bool execPathTaken = false;
            bool shortcutTaken = false;
            // If changing an executable
            if (ChangingExecutables)
            {
                // Executable path taken
                {
                    List<ExecutableData> sameExecPath = Executables.Where(x => x.ExecutablePath == Txt_ExecutablePath.Text).ToList();
                    if (sameExecPath.Count() > 1)
                    {
                        execPathTaken = true;
                    } else if (sameExecPath.Count() != 0 && sameExecPath[0].ExecutablePath != PrevExecutable.ExecutablePath)
                    {
                        execPathTaken = true;
                    }
                }
                // Shortcut taken
                {
                    List<ExecutableData> sameShortcut = Executables.Where(x => x.ShortcutName == Txt_ShortcutName.Text).ToList();
                    if (sameShortcut.Count() > 1)
                    {
                        shortcutTaken = true;
                    }
                    else if (sameShortcut.Count() != 0 && sameShortcut[0].ShortcutName != PrevExecutable.ShortcutName)
                    {
                        shortcutTaken = true;
                    }
                }
            }
            // If adding an executable
            else
            {
                if (Executables.Where(x => x.ExecutablePath == Txt_ExecutablePath.Text).Count() > 0)
                {
                    execPathTaken = true;
                }
                if (Executables.Where(x => x.ShortcutName == Txt_ShortcutName.Text).Count() > 0)
                {
                    shortcutTaken = true;
                }
            }
            if (!execPathTaken && !shortcutTaken)
            {
                NewExecutable = new ExecutableData(Txt_ShortcutName.Text, Txt_ExecutablePath.Text, ChBox_OnDesktop.Checked);
                DialogResult = DialogResult.Yes;
                Close();
            }
            // Show message to user that operation failed
            else
            {
                string message = "Executable cannot be " + (ChangingExecutables ? "changed" : "added") + " due to the following restrictions:";
                if (execPathTaken)
                {
                    message += "\n\t- Executable path already used";
                }
                if (shortcutTaken)
                {
                    message += "\n\t- Shortcut name already taken";
                }
                MessageBox.Show(message, "Failed to " + (ChangingExecutables ? "change" : "add"));
            }
        }

        private void Btn_RemoveExecutable_Click(object sender, EventArgs e)
        {
            DialogResult = ChangingExecutables ? DialogResult.No : DialogResult.Cancel;
            Close();
        }

        private void Txt_ShortcutName_TextChanged(object sender, EventArgs e)
        {
            ExecNameChanged = true;
        }

        private void Txt_ExecutablePath_TextChanged(object sender, EventArgs e)
        {
            if (!ExecNameChanged)
            {
                Txt_ShortcutName.Text = Path.GetFileNameWithoutExtension(Txt_ExecutablePath.Text);
            }
        }
    }
}
