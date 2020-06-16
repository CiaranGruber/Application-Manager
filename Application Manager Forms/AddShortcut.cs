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
    public partial class AddShortcut : Form
    {
        public string ShortcutName { get; set; }
        private List<string> ExistingShortcuts { get; set; }

        public AddShortcut(List<string> existingShortcuts)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            ExistingShortcuts = existingShortcuts;
        }

        private void Btn_AddShortcut_Click(object sender, EventArgs e)
        {
            if (ExistingShortcuts.Contains(Txt_ShortcutName.Text))
            {
                MessageBox.Show("Shortcut already exists");
            }
            else
            {
                DialogResult = DialogResult.OK;
                ShortcutName = Txt_ShortcutName.Text;
                Close();
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
