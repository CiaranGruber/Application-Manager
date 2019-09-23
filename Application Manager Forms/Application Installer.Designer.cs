namespace ApplicationManagerForms
{
    partial class ApplicationInstaller
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
            System.Windows.Forms.Panel Pnl_Buttons;
            System.Windows.Forms.Label Lbl_Title;
            System.Windows.Forms.Label Lbl_ShortcutName;
            System.Windows.Forms.FlowLayoutPanel Flp_Options;
            System.Windows.Forms.Label Lbl_ProgramLocation;
            System.Windows.Forms.Label Lbl_InstallLocation;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationInstaller));
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Install = new System.Windows.Forms.Button();
            this.ChBox_HasFolder = new System.Windows.Forms.CheckBox();
            this.ChBox_InstallAdmin = new System.Windows.Forms.CheckBox();
            this.ChBox_CreateDesktopShortcut = new System.Windows.Forms.CheckBox();
            this.Pnl_ExecutableName = new System.Windows.Forms.Panel();
            this.Lbl_ExecutableName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txt_ExecutableName = new System.Windows.Forms.TextBox();
            this.Btn_ExecutableNameBrowse = new System.Windows.Forms.Button();
            this.Pnl_ShortcutName = new System.Windows.Forms.Panel();
            this.Txt_ShortcutName = new System.Windows.Forms.TextBox();
            this.Pnl_ProgramLocation = new System.Windows.Forms.Panel();
            this.Pnl_ProgramLocationSelect = new System.Windows.Forms.Panel();
            this.Txt_ProgramLocation = new System.Windows.Forms.TextBox();
            this.Btn_ProgramLocationBrowse = new System.Windows.Forms.Button();
            this.Pnl_InstallLocation = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_InstallLocation = new System.Windows.Forms.TextBox();
            this.Btn_InstallLocationBrowse = new System.Windows.Forms.Button();
            Pnl_Buttons = new System.Windows.Forms.Panel();
            Lbl_Title = new System.Windows.Forms.Label();
            Lbl_ShortcutName = new System.Windows.Forms.Label();
            Flp_Options = new System.Windows.Forms.FlowLayoutPanel();
            Lbl_ProgramLocation = new System.Windows.Forms.Label();
            Lbl_InstallLocation = new System.Windows.Forms.Label();
            Pnl_Buttons.SuspendLayout();
            Flp_Options.SuspendLayout();
            this.Pnl_ExecutableName.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Pnl_ShortcutName.SuspendLayout();
            this.Pnl_ProgramLocation.SuspendLayout();
            this.Pnl_ProgramLocationSelect.SuspendLayout();
            this.Pnl_InstallLocation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.Controls.Add(this.Btn_Back);
            Pnl_Buttons.Controls.Add(this.Btn_Install);
            Pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            Pnl_Buttons.Location = new System.Drawing.Point(50, 442);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Size = new System.Drawing.Size(665, 50);
            Pnl_Buttons.TabIndex = 2;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Back.Location = new System.Drawing.Point(0, 0);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(200, 50);
            this.Btn_Back.TabIndex = 1;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_Install
            // 
            this.Btn_Install.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Install.Location = new System.Drawing.Point(465, 0);
            this.Btn_Install.Name = "Btn_Install";
            this.Btn_Install.Size = new System.Drawing.Size(200, 50);
            this.Btn_Install.TabIndex = 0;
            this.Btn_Install.Text = "Install";
            this.Btn_Install.UseVisualStyleBackColor = true;
            this.Btn_Install.Click += new System.EventHandler(this.Btn_Install_Click);
            // 
            // Lbl_Title
            // 
            Lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            Lbl_Title.Font = new System.Drawing.Font("Monotxt_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Lbl_Title.Location = new System.Drawing.Point(50, 50);
            Lbl_Title.Name = "Lbl_Title";
            Lbl_Title.Size = new System.Drawing.Size(665, 80);
            Lbl_Title.TabIndex = 0;
            Lbl_Title.Text = "Application Installer";
            Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_ShortcutName
            // 
            Lbl_ShortcutName.Dock = System.Windows.Forms.DockStyle.Fill;
            Lbl_ShortcutName.Location = new System.Drawing.Point(0, 0);
            Lbl_ShortcutName.Name = "Lbl_ShortcutName";
            Lbl_ShortcutName.Size = new System.Drawing.Size(665, 44);
            Lbl_ShortcutName.TabIndex = 2;
            Lbl_ShortcutName.Text = "Shortcut Name";
            Lbl_ShortcutName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Flp_Options
            // 
            Flp_Options.Controls.Add(this.ChBox_HasFolder);
            Flp_Options.Controls.Add(this.ChBox_InstallAdmin);
            Flp_Options.Controls.Add(this.ChBox_CreateDesktopShortcut);
            Flp_Options.Dock = System.Windows.Forms.DockStyle.Fill;
            Flp_Options.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            Flp_Options.Location = new System.Drawing.Point(50, 394);
            Flp_Options.Name = "Flp_Options";
            Flp_Options.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            Flp_Options.Size = new System.Drawing.Size(665, 48);
            Flp_Options.TabIndex = 15;
            // 
            // ChBox_HasFolder
            // 
            this.ChBox_HasFolder.AutoSize = true;
            this.ChBox_HasFolder.Location = new System.Drawing.Point(3, 13);
            this.ChBox_HasFolder.Name = "ChBox_HasFolder";
            this.ChBox_HasFolder.Size = new System.Drawing.Size(202, 21);
            this.ChBox_HasFolder.TabIndex = 0;
            this.ChBox_HasFolder.Text = "Contained in an App Folder";
            this.ChBox_HasFolder.UseVisualStyleBackColor = true;
            this.ChBox_HasFolder.CheckedChanged += new System.EventHandler(this.ChBox_HasFolder_CheckedChanged);
            // 
            // ChBox_InstallAdmin
            // 
            this.ChBox_InstallAdmin.AutoSize = true;
            this.ChBox_InstallAdmin.Location = new System.Drawing.Point(211, 13);
            this.ChBox_InstallAdmin.Name = "ChBox_InstallAdmin";
            this.ChBox_InstallAdmin.Size = new System.Drawing.Size(265, 21);
            this.ChBox_InstallAdmin.TabIndex = 1;
            this.ChBox_InstallAdmin.Text = "Install for all users? (Requires admin)";
            this.ChBox_InstallAdmin.UseVisualStyleBackColor = true;
            this.ChBox_InstallAdmin.CheckedChanged += new System.EventHandler(this.ChBox_InstallAdmin_CheckedChanged);
            // 
            // ChBox_CreateDesktopShortcut
            // 
            this.ChBox_CreateDesktopShortcut.AutoSize = true;
            this.ChBox_CreateDesktopShortcut.Location = new System.Drawing.Point(482, 13);
            this.ChBox_CreateDesktopShortcut.Name = "ChBox_CreateDesktopShortcut";
            this.ChBox_CreateDesktopShortcut.Size = new System.Drawing.Size(181, 21);
            this.ChBox_CreateDesktopShortcut.TabIndex = 2;
            this.ChBox_CreateDesktopShortcut.Text = "Create desktop shortcut";
            this.ChBox_CreateDesktopShortcut.UseVisualStyleBackColor = true;
            // 
            // Lbl_ProgramLocation
            // 
            Lbl_ProgramLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            Lbl_ProgramLocation.Location = new System.Drawing.Point(0, 0);
            Lbl_ProgramLocation.Name = "Lbl_ProgramLocation";
            Lbl_ProgramLocation.Size = new System.Drawing.Size(665, 41);
            Lbl_ProgramLocation.TabIndex = 19;
            Lbl_ProgramLocation.Text = "Program Location";
            Lbl_ProgramLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_InstallLocation
            // 
            Lbl_InstallLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            Lbl_InstallLocation.Location = new System.Drawing.Point(0, 0);
            Lbl_InstallLocation.Name = "Lbl_InstallLocation";
            Lbl_InstallLocation.Size = new System.Drawing.Size(665, 41);
            Lbl_InstallLocation.TabIndex = 20;
            Lbl_InstallLocation.Text = "Installation Location";
            Lbl_InstallLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_ExecutableName
            // 
            this.Pnl_ExecutableName.Controls.Add(this.Lbl_ExecutableName);
            this.Pnl_ExecutableName.Controls.Add(this.panel2);
            this.Pnl_ExecutableName.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_ExecutableName.Location = new System.Drawing.Point(50, 130);
            this.Pnl_ExecutableName.Name = "Pnl_ExecutableName";
            this.Pnl_ExecutableName.Size = new System.Drawing.Size(665, 66);
            this.Pnl_ExecutableName.TabIndex = 3;
            // 
            // Lbl_ExecutableName
            // 
            this.Lbl_ExecutableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_ExecutableName.Location = new System.Drawing.Point(0, 0);
            this.Lbl_ExecutableName.Name = "Lbl_ExecutableName";
            this.Lbl_ExecutableName.Size = new System.Drawing.Size(665, 41);
            this.Lbl_ExecutableName.TabIndex = 20;
            this.Lbl_ExecutableName.Text = "Executable Name";
            this.Lbl_ExecutableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Txt_ExecutableName);
            this.panel2.Controls.Add(this.Btn_ExecutableNameBrowse);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 25);
            this.panel2.TabIndex = 19;
            // 
            // Txt_ExecutableName
            // 
            this.Txt_ExecutableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_ExecutableName.Location = new System.Drawing.Point(0, 0);
            this.Txt_ExecutableName.Name = "Txt_ExecutableName";
            this.Txt_ExecutableName.Size = new System.Drawing.Size(565, 22);
            this.Txt_ExecutableName.TabIndex = 17;
            this.Txt_ExecutableName.TextChanged += new System.EventHandler(this.Txt_ExecutableName_TextChanged);
            // 
            // Btn_ExecutableNameBrowse
            // 
            this.Btn_ExecutableNameBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_ExecutableNameBrowse.Location = new System.Drawing.Point(565, 0);
            this.Btn_ExecutableNameBrowse.Name = "Btn_ExecutableNameBrowse";
            this.Btn_ExecutableNameBrowse.Size = new System.Drawing.Size(100, 25);
            this.Btn_ExecutableNameBrowse.TabIndex = 16;
            this.Btn_ExecutableNameBrowse.Text = "Browse";
            this.Btn_ExecutableNameBrowse.UseVisualStyleBackColor = true;
            this.Btn_ExecutableNameBrowse.Click += new System.EventHandler(this.Btn_ExecutableNameBrowse_Click);
            // 
            // Pnl_ShortcutName
            // 
            this.Pnl_ShortcutName.Controls.Add(Lbl_ShortcutName);
            this.Pnl_ShortcutName.Controls.Add(this.Txt_ShortcutName);
            this.Pnl_ShortcutName.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_ShortcutName.Location = new System.Drawing.Point(50, 196);
            this.Pnl_ShortcutName.Name = "Pnl_ShortcutName";
            this.Pnl_ShortcutName.Size = new System.Drawing.Size(665, 66);
            this.Pnl_ShortcutName.TabIndex = 12;
            // 
            // Txt_ShortcutName
            // 
            this.Txt_ShortcutName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Txt_ShortcutName.Location = new System.Drawing.Point(0, 44);
            this.Txt_ShortcutName.Name = "Txt_ShortcutName";
            this.Txt_ShortcutName.Size = new System.Drawing.Size(665, 22);
            this.Txt_ShortcutName.TabIndex = 1;
            // 
            // Pnl_ProgramLocation
            // 
            this.Pnl_ProgramLocation.Controls.Add(Lbl_ProgramLocation);
            this.Pnl_ProgramLocation.Controls.Add(this.Pnl_ProgramLocationSelect);
            this.Pnl_ProgramLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_ProgramLocation.Location = new System.Drawing.Point(50, 262);
            this.Pnl_ProgramLocation.Name = "Pnl_ProgramLocation";
            this.Pnl_ProgramLocation.Size = new System.Drawing.Size(665, 66);
            this.Pnl_ProgramLocation.TabIndex = 13;
            // 
            // Pnl_ProgramLocationSelect
            // 
            this.Pnl_ProgramLocationSelect.Controls.Add(this.Txt_ProgramLocation);
            this.Pnl_ProgramLocationSelect.Controls.Add(this.Btn_ProgramLocationBrowse);
            this.Pnl_ProgramLocationSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_ProgramLocationSelect.Location = new System.Drawing.Point(0, 41);
            this.Pnl_ProgramLocationSelect.Name = "Pnl_ProgramLocationSelect";
            this.Pnl_ProgramLocationSelect.Size = new System.Drawing.Size(665, 25);
            this.Pnl_ProgramLocationSelect.TabIndex = 18;
            // 
            // Txt_ProgramLocation
            // 
            this.Txt_ProgramLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_ProgramLocation.Location = new System.Drawing.Point(0, 0);
            this.Txt_ProgramLocation.Name = "Txt_ProgramLocation";
            this.Txt_ProgramLocation.Size = new System.Drawing.Size(565, 22);
            this.Txt_ProgramLocation.TabIndex = 17;
            this.Txt_ProgramLocation.TextChanged += new System.EventHandler(this.Txt_ProgramLocation_TextChanged);
            // 
            // Btn_ProgramLocationBrowse
            // 
            this.Btn_ProgramLocationBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_ProgramLocationBrowse.Location = new System.Drawing.Point(565, 0);
            this.Btn_ProgramLocationBrowse.Name = "Btn_ProgramLocationBrowse";
            this.Btn_ProgramLocationBrowse.Size = new System.Drawing.Size(100, 25);
            this.Btn_ProgramLocationBrowse.TabIndex = 16;
            this.Btn_ProgramLocationBrowse.Text = "Browse";
            this.Btn_ProgramLocationBrowse.UseVisualStyleBackColor = true;
            this.Btn_ProgramLocationBrowse.Click += new System.EventHandler(this.Btn_ProgramLocationBrowse_Click);
            // 
            // Pnl_InstallLocation
            // 
            this.Pnl_InstallLocation.Controls.Add(Lbl_InstallLocation);
            this.Pnl_InstallLocation.Controls.Add(this.panel1);
            this.Pnl_InstallLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_InstallLocation.Location = new System.Drawing.Point(50, 328);
            this.Pnl_InstallLocation.Name = "Pnl_InstallLocation";
            this.Pnl_InstallLocation.Size = new System.Drawing.Size(665, 66);
            this.Pnl_InstallLocation.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Txt_InstallLocation);
            this.panel1.Controls.Add(this.Btn_InstallLocationBrowse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 25);
            this.panel1.TabIndex = 19;
            // 
            // Txt_InstallLocation
            // 
            this.Txt_InstallLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_InstallLocation.Location = new System.Drawing.Point(0, 0);
            this.Txt_InstallLocation.Name = "Txt_InstallLocation";
            this.Txt_InstallLocation.Size = new System.Drawing.Size(565, 22);
            this.Txt_InstallLocation.TabIndex = 17;
            this.Txt_InstallLocation.TextChanged += new System.EventHandler(this.Txt_InstallLocation_TextChanged);
            // 
            // Btn_InstallLocationBrowse
            // 
            this.Btn_InstallLocationBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_InstallLocationBrowse.Location = new System.Drawing.Point(565, 0);
            this.Btn_InstallLocationBrowse.Name = "Btn_InstallLocationBrowse";
            this.Btn_InstallLocationBrowse.Size = new System.Drawing.Size(100, 25);
            this.Btn_InstallLocationBrowse.TabIndex = 16;
            this.Btn_InstallLocationBrowse.Text = "Browse";
            this.Btn_InstallLocationBrowse.UseVisualStyleBackColor = true;
            this.Btn_InstallLocationBrowse.Click += new System.EventHandler(this.Btn_InstallLocationBrowse_Click);
            // 
            // ApplicationInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 542);
            this.Controls.Add(Flp_Options);
            this.Controls.Add(this.Pnl_InstallLocation);
            this.Controls.Add(this.Pnl_ProgramLocation);
            this.Controls.Add(this.Pnl_ShortcutName);
            this.Controls.Add(this.Pnl_ExecutableName);
            this.Controls.Add(Pnl_Buttons);
            this.Controls.Add(Lbl_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicationInstaller";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Installer";
            this.Load += new System.EventHandler(this.ApplicationInstaller_Load);
            Pnl_Buttons.ResumeLayout(false);
            Flp_Options.ResumeLayout(false);
            Flp_Options.PerformLayout();
            this.Pnl_ExecutableName.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Pnl_ShortcutName.ResumeLayout(false);
            this.Pnl_ShortcutName.PerformLayout();
            this.Pnl_ProgramLocation.ResumeLayout(false);
            this.Pnl_ProgramLocationSelect.ResumeLayout(false);
            this.Pnl_ProgramLocationSelect.PerformLayout();
            this.Pnl_InstallLocation.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Install;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Panel Pnl_ExecutableName;
        private System.Windows.Forms.Panel Pnl_ShortcutName;
        private System.Windows.Forms.TextBox Txt_ShortcutName;
        private System.Windows.Forms.Panel Pnl_ProgramLocation;
        private System.Windows.Forms.Panel Pnl_InstallLocation;
        private System.Windows.Forms.CheckBox ChBox_HasFolder;
        private System.Windows.Forms.CheckBox ChBox_InstallAdmin;
        private System.Windows.Forms.CheckBox ChBox_CreateDesktopShortcut;
        private System.Windows.Forms.Label Lbl_ExecutableName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txt_ExecutableName;
        private System.Windows.Forms.Button Btn_ExecutableNameBrowse;
        private System.Windows.Forms.Panel Pnl_ProgramLocationSelect;
        private System.Windows.Forms.TextBox Txt_ProgramLocation;
        private System.Windows.Forms.Button Btn_ProgramLocationBrowse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_InstallLocation;
        private System.Windows.Forms.Button Btn_InstallLocationBrowse;
    }
}

