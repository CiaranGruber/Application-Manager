namespace ApplicationManagerForms
{
    partial class AddShortcut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label Lbl_Title;
            this.Pnl_Buttons = new System.Windows.Forms.Panel();
            this.Btn_AddShortcut = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Pnl_ShortcutName = new System.Windows.Forms.Panel();
            this.Txt_ShortcutName = new System.Windows.Forms.TextBox();
            Lbl_Title = new System.Windows.Forms.Label();
            this.Pnl_Buttons.SuspendLayout();
            this.Pnl_ShortcutName.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            Lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            Lbl_Title.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Lbl_Title.Location = new System.Drawing.Point(50, 50);
            Lbl_Title.Name = "Lbl_Title";
            Lbl_Title.Size = new System.Drawing.Size(282, 65);
            Lbl_Title.TabIndex = 4;
            Lbl_Title.Text = "Add Shortcut";
            Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Buttons
            // 
            this.Pnl_Buttons.Controls.Add(this.Btn_Cancel);
            this.Pnl_Buttons.Controls.Add(this.Btn_AddShortcut);
            this.Pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Buttons.Location = new System.Drawing.Point(50, 178);
            this.Pnl_Buttons.Name = "Pnl_Buttons";
            this.Pnl_Buttons.Size = new System.Drawing.Size(282, 25);
            this.Pnl_Buttons.TabIndex = 6;
            // 
            // Btn_AddShortcut
            // 
            this.Btn_AddShortcut.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_AddShortcut.Location = new System.Drawing.Point(0, 0);
            this.Btn_AddShortcut.Name = "Btn_AddShortcut";
            this.Btn_AddShortcut.Size = new System.Drawing.Size(100, 25);
            this.Btn_AddShortcut.TabIndex = 1;
            this.Btn_AddShortcut.Text = "Add";
            this.Btn_AddShortcut.UseVisualStyleBackColor = true;
            this.Btn_AddShortcut.Click += new System.EventHandler(this.Btn_AddShortcut_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Cancel.Location = new System.Drawing.Point(182, 0);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(100, 25);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Pnl_ShortcutName
            // 
            this.Pnl_ShortcutName.Controls.Add(this.Txt_ShortcutName);
            this.Pnl_ShortcutName.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_ShortcutName.Location = new System.Drawing.Point(50, 115);
            this.Pnl_ShortcutName.Name = "Pnl_ShortcutName";
            this.Pnl_ShortcutName.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.Pnl_ShortcutName.Size = new System.Drawing.Size(282, 42);
            this.Pnl_ShortcutName.TabIndex = 7;
            // 
            // Txt_ShortcutName
            // 
            this.Txt_ShortcutName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_ShortcutName.Location = new System.Drawing.Point(25, 10);
            this.Txt_ShortcutName.Name = "Txt_ShortcutName";
            this.Txt_ShortcutName.Size = new System.Drawing.Size(232, 22);
            this.Txt_ShortcutName.TabIndex = 0;
            // 
            // AddShortcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.Pnl_ShortcutName);
            this.Controls.Add(this.Pnl_Buttons);
            this.Controls.Add(Lbl_Title);
            this.Name = "AddShortcut";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Text = "AddShortcut";
            this.Pnl_Buttons.ResumeLayout(false);
            this.Pnl_ShortcutName.ResumeLayout(false);
            this.Pnl_ShortcutName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Buttons;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_AddShortcut;
        private System.Windows.Forms.Panel Pnl_ShortcutName;
        private System.Windows.Forms.TextBox Txt_ShortcutName;
    }
}