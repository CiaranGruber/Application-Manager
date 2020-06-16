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
            System.Windows.Forms.FlowLayoutPanel Flp_Options;
            System.Windows.Forms.Label Lbl_InstallLocation;
            System.Windows.Forms.Label Lbl_ProgramLocation;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationInstaller));
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Install = new System.Windows.Forms.Button();
            this.ChBox_HasFolder = new System.Windows.Forms.CheckBox();
            this.ChBox_InstallAdmin = new System.Windows.Forms.CheckBox();
            this.Pnl_InstallLocation = new System.Windows.Forms.Panel();
            this.Pnl_InstallLocationSelect = new System.Windows.Forms.Panel();
            this.Txt_InstallLocation = new System.Windows.Forms.TextBox();
            this.Btn_InstallLocationBrowse = new System.Windows.Forms.Button();
            this.Pnl_ProgramLocation = new System.Windows.Forms.Panel();
            this.Pnl_ProgramLocationSelect = new System.Windows.Forms.Panel();
            this.Txt_ProgramLocation = new System.Windows.Forms.TextBox();
            this.Btn_ProgramLocationBrowse = new System.Windows.Forms.Button();
            this.Btn_AddExecutable = new System.Windows.Forms.Button();
            this.Pnl_ExecutablesHeader = new System.Windows.Forms.Panel();
            this.Lbl_RelativeLocation = new System.Windows.Forms.Label();
            this.Lbl_ShortcutName = new System.Windows.Forms.Label();
            this.Lbl_OnDesktop = new System.Windows.Forms.Label();
            this.Pnl_PaddingPanel = new System.Windows.Forms.Panel();
            this.Pnl_AddExecutable = new System.Windows.Forms.Panel();
            this.Pnl_ExecutablesSelector = new System.Windows.Forms.Panel();
            this.Pnl_Executables = new System.Windows.Forms.Panel();
            Pnl_Buttons = new System.Windows.Forms.Panel();
            Lbl_Title = new System.Windows.Forms.Label();
            Flp_Options = new System.Windows.Forms.FlowLayoutPanel();
            Lbl_InstallLocation = new System.Windows.Forms.Label();
            Lbl_ProgramLocation = new System.Windows.Forms.Label();
            Pnl_Buttons.SuspendLayout();
            Flp_Options.SuspendLayout();
            this.Pnl_InstallLocation.SuspendLayout();
            this.Pnl_InstallLocationSelect.SuspendLayout();
            this.Pnl_ProgramLocation.SuspendLayout();
            this.Pnl_ProgramLocationSelect.SuspendLayout();
            this.Pnl_ExecutablesHeader.SuspendLayout();
            this.Pnl_AddExecutable.SuspendLayout();
            this.Pnl_ExecutablesSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.Controls.Add(this.Btn_Back);
            Pnl_Buttons.Controls.Add(this.Btn_Install);
            Pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            Pnl_Buttons.Location = new System.Drawing.Point(50, 481);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Size = new System.Drawing.Size(682, 50);
            Pnl_Buttons.TabIndex = 2;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Back.Location = new System.Drawing.Point(482, 0);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(200, 50);
            this.Btn_Back.TabIndex = 1;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_Install
            // 
            this.Btn_Install.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Install.Location = new System.Drawing.Point(0, 0);
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
            Lbl_Title.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Lbl_Title.Location = new System.Drawing.Point(50, 50);
            Lbl_Title.Name = "Lbl_Title";
            Lbl_Title.Size = new System.Drawing.Size(682, 80);
            Lbl_Title.TabIndex = 0;
            Lbl_Title.Text = "Application Installer";
            Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Flp_Options
            // 
            Flp_Options.Controls.Add(this.ChBox_HasFolder);
            Flp_Options.Controls.Add(this.ChBox_InstallAdmin);
            Flp_Options.Dock = System.Windows.Forms.DockStyle.Bottom;
            Flp_Options.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            Flp_Options.Location = new System.Drawing.Point(50, 436);
            Flp_Options.Name = "Flp_Options";
            Flp_Options.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            Flp_Options.Size = new System.Drawing.Size(682, 45);
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
            // Lbl_InstallLocation
            // 
            Lbl_InstallLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            Lbl_InstallLocation.Location = new System.Drawing.Point(0, 0);
            Lbl_InstallLocation.Name = "Lbl_InstallLocation";
            Lbl_InstallLocation.Size = new System.Drawing.Size(682, 41);
            Lbl_InstallLocation.TabIndex = 20;
            Lbl_InstallLocation.Text = "Installation Location";
            Lbl_InstallLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_ProgramLocation
            // 
            Lbl_ProgramLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            Lbl_ProgramLocation.Location = new System.Drawing.Point(0, 0);
            Lbl_ProgramLocation.Name = "Lbl_ProgramLocation";
            Lbl_ProgramLocation.Size = new System.Drawing.Size(682, 41);
            Lbl_ProgramLocation.TabIndex = 19;
            Lbl_ProgramLocation.Text = "Program Location";
            Lbl_ProgramLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_InstallLocation
            // 
            this.Pnl_InstallLocation.Controls.Add(Lbl_InstallLocation);
            this.Pnl_InstallLocation.Controls.Add(this.Pnl_InstallLocationSelect);
            this.Pnl_InstallLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_InstallLocation.Location = new System.Drawing.Point(50, 370);
            this.Pnl_InstallLocation.Name = "Pnl_InstallLocation";
            this.Pnl_InstallLocation.Size = new System.Drawing.Size(682, 66);
            this.Pnl_InstallLocation.TabIndex = 21;
            // 
            // Pnl_InstallLocationSelect
            // 
            this.Pnl_InstallLocationSelect.Controls.Add(this.Txt_InstallLocation);
            this.Pnl_InstallLocationSelect.Controls.Add(this.Btn_InstallLocationBrowse);
            this.Pnl_InstallLocationSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_InstallLocationSelect.Location = new System.Drawing.Point(0, 41);
            this.Pnl_InstallLocationSelect.Name = "Pnl_InstallLocationSelect";
            this.Pnl_InstallLocationSelect.Size = new System.Drawing.Size(682, 25);
            this.Pnl_InstallLocationSelect.TabIndex = 19;
            // 
            // Txt_InstallLocation
            // 
            this.Txt_InstallLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_InstallLocation.Location = new System.Drawing.Point(0, 0);
            this.Txt_InstallLocation.Name = "Txt_InstallLocation";
            this.Txt_InstallLocation.Size = new System.Drawing.Size(582, 22);
            this.Txt_InstallLocation.TabIndex = 17;
            this.Txt_InstallLocation.TextChanged += new System.EventHandler(this.Txt_InstallLocation_TextChanged);
            // 
            // Btn_InstallLocationBrowse
            // 
            this.Btn_InstallLocationBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_InstallLocationBrowse.Location = new System.Drawing.Point(582, 0);
            this.Btn_InstallLocationBrowse.Name = "Btn_InstallLocationBrowse";
            this.Btn_InstallLocationBrowse.Size = new System.Drawing.Size(100, 25);
            this.Btn_InstallLocationBrowse.TabIndex = 16;
            this.Btn_InstallLocationBrowse.Text = "Browse";
            this.Btn_InstallLocationBrowse.UseVisualStyleBackColor = true;
            this.Btn_InstallLocationBrowse.Click += new System.EventHandler(this.Btn_InstallLocationBrowse_Click);
            // 
            // Pnl_ProgramLocation
            // 
            this.Pnl_ProgramLocation.Controls.Add(Lbl_ProgramLocation);
            this.Pnl_ProgramLocation.Controls.Add(this.Pnl_ProgramLocationSelect);
            this.Pnl_ProgramLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_ProgramLocation.Location = new System.Drawing.Point(50, 304);
            this.Pnl_ProgramLocation.Name = "Pnl_ProgramLocation";
            this.Pnl_ProgramLocation.Size = new System.Drawing.Size(682, 66);
            this.Pnl_ProgramLocation.TabIndex = 22;
            // 
            // Pnl_ProgramLocationSelect
            // 
            this.Pnl_ProgramLocationSelect.Controls.Add(this.Txt_ProgramLocation);
            this.Pnl_ProgramLocationSelect.Controls.Add(this.Btn_ProgramLocationBrowse);
            this.Pnl_ProgramLocationSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_ProgramLocationSelect.Location = new System.Drawing.Point(0, 41);
            this.Pnl_ProgramLocationSelect.Name = "Pnl_ProgramLocationSelect";
            this.Pnl_ProgramLocationSelect.Size = new System.Drawing.Size(682, 25);
            this.Pnl_ProgramLocationSelect.TabIndex = 18;
            // 
            // Txt_ProgramLocation
            // 
            this.Txt_ProgramLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_ProgramLocation.Location = new System.Drawing.Point(0, 0);
            this.Txt_ProgramLocation.Name = "Txt_ProgramLocation";
            this.Txt_ProgramLocation.Size = new System.Drawing.Size(582, 22);
            this.Txt_ProgramLocation.TabIndex = 17;
            this.Txt_ProgramLocation.TextChanged += new System.EventHandler(this.Txt_ProgramLocation_TextChanged);
            // 
            // Btn_ProgramLocationBrowse
            // 
            this.Btn_ProgramLocationBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_ProgramLocationBrowse.Location = new System.Drawing.Point(582, 0);
            this.Btn_ProgramLocationBrowse.Name = "Btn_ProgramLocationBrowse";
            this.Btn_ProgramLocationBrowse.Size = new System.Drawing.Size(100, 25);
            this.Btn_ProgramLocationBrowse.TabIndex = 16;
            this.Btn_ProgramLocationBrowse.Text = "Browse";
            this.Btn_ProgramLocationBrowse.UseVisualStyleBackColor = true;
            this.Btn_ProgramLocationBrowse.Click += new System.EventHandler(this.Btn_ProgramLocationBrowse_Click);
            // 
            // Btn_AddExecutable
            // 
            this.Btn_AddExecutable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_AddExecutable.Location = new System.Drawing.Point(0, 0);
            this.Btn_AddExecutable.Name = "Btn_AddExecutable";
            this.Btn_AddExecutable.Size = new System.Drawing.Size(682, 50);
            this.Btn_AddExecutable.TabIndex = 3;
            this.Btn_AddExecutable.Text = "Add Executable";
            this.Btn_AddExecutable.UseVisualStyleBackColor = true;
            this.Btn_AddExecutable.Click += new System.EventHandler(this.Btn_AddExecutable_Click);
            // 
            // Pnl_ExecutablesHeader
            // 
            this.Pnl_ExecutablesHeader.Controls.Add(this.Lbl_RelativeLocation);
            this.Pnl_ExecutablesHeader.Controls.Add(this.Lbl_ShortcutName);
            this.Pnl_ExecutablesHeader.Controls.Add(this.Lbl_OnDesktop);
            this.Pnl_ExecutablesHeader.Controls.Add(this.Pnl_PaddingPanel);
            this.Pnl_ExecutablesHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_ExecutablesHeader.Location = new System.Drawing.Point(0, 0);
            this.Pnl_ExecutablesHeader.Name = "Pnl_ExecutablesHeader";
            this.Pnl_ExecutablesHeader.Size = new System.Drawing.Size(682, 50);
            this.Pnl_ExecutablesHeader.TabIndex = 25;
            // 
            // Lbl_RelativeLocation
            // 
            this.Lbl_RelativeLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_RelativeLocation.Location = new System.Drawing.Point(175, 0);
            this.Lbl_RelativeLocation.Name = "Lbl_RelativeLocation";
            this.Lbl_RelativeLocation.Size = new System.Drawing.Size(332, 50);
            this.Lbl_RelativeLocation.TabIndex = 29;
            this.Lbl_RelativeLocation.Text = "Relative Location";
            this.Lbl_RelativeLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_ShortcutName
            // 
            this.Lbl_ShortcutName.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lbl_ShortcutName.Location = new System.Drawing.Point(0, 0);
            this.Lbl_ShortcutName.Name = "Lbl_ShortcutName";
            this.Lbl_ShortcutName.Size = new System.Drawing.Size(175, 50);
            this.Lbl_ShortcutName.TabIndex = 28;
            this.Lbl_ShortcutName.Text = "Shortcut Name";
            this.Lbl_ShortcutName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_OnDesktop
            // 
            this.Lbl_OnDesktop.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lbl_OnDesktop.Location = new System.Drawing.Point(507, 0);
            this.Lbl_OnDesktop.Name = "Lbl_OnDesktop";
            this.Lbl_OnDesktop.Size = new System.Drawing.Size(75, 50);
            this.Lbl_OnDesktop.TabIndex = 27;
            this.Lbl_OnDesktop.Text = "On Desktop";
            this.Lbl_OnDesktop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_PaddingPanel
            // 
            this.Pnl_PaddingPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_PaddingPanel.Location = new System.Drawing.Point(582, 0);
            this.Pnl_PaddingPanel.Name = "Pnl_PaddingPanel";
            this.Pnl_PaddingPanel.Size = new System.Drawing.Size(100, 50);
            this.Pnl_PaddingPanel.TabIndex = 26;
            // 
            // Pnl_AddExecutable
            // 
            this.Pnl_AddExecutable.Controls.Add(this.Btn_AddExecutable);
            this.Pnl_AddExecutable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_AddExecutable.Location = new System.Drawing.Point(0, 114);
            this.Pnl_AddExecutable.Name = "Pnl_AddExecutable";
            this.Pnl_AddExecutable.Size = new System.Drawing.Size(682, 50);
            this.Pnl_AddExecutable.TabIndex = 19;
            // 
            // Pnl_ExecutablesSelector
            // 
            this.Pnl_ExecutablesSelector.Controls.Add(this.Pnl_Executables);
            this.Pnl_ExecutablesSelector.Controls.Add(this.Pnl_ExecutablesHeader);
            this.Pnl_ExecutablesSelector.Controls.Add(this.Pnl_AddExecutable);
            this.Pnl_ExecutablesSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_ExecutablesSelector.Location = new System.Drawing.Point(50, 130);
            this.Pnl_ExecutablesSelector.Name = "Pnl_ExecutablesSelector";
            this.Pnl_ExecutablesSelector.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Pnl_ExecutablesSelector.Size = new System.Drawing.Size(682, 174);
            this.Pnl_ExecutablesSelector.TabIndex = 27;
            // 
            // Pnl_Executables
            // 
            this.Pnl_Executables.AutoScroll = true;
            this.Pnl_Executables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Executables.Location = new System.Drawing.Point(0, 50);
            this.Pnl_Executables.Name = "Pnl_Executables";
            this.Pnl_Executables.Size = new System.Drawing.Size(682, 64);
            this.Pnl_Executables.TabIndex = 27;
            // 
            // ApplicationInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 581);
            this.Controls.Add(this.Pnl_ExecutablesSelector);
            this.Controls.Add(this.Pnl_ProgramLocation);
            this.Controls.Add(this.Pnl_InstallLocation);
            this.Controls.Add(Flp_Options);
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
            this.Pnl_InstallLocation.ResumeLayout(false);
            this.Pnl_InstallLocationSelect.ResumeLayout(false);
            this.Pnl_InstallLocationSelect.PerformLayout();
            this.Pnl_ProgramLocation.ResumeLayout(false);
            this.Pnl_ProgramLocationSelect.ResumeLayout(false);
            this.Pnl_ProgramLocationSelect.PerformLayout();
            this.Pnl_ExecutablesHeader.ResumeLayout(false);
            this.Pnl_AddExecutable.ResumeLayout(false);
            this.Pnl_ExecutablesSelector.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Install;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.CheckBox ChBox_HasFolder;
        private System.Windows.Forms.CheckBox ChBox_InstallAdmin;
        private System.Windows.Forms.Panel Pnl_InstallLocation;
        private System.Windows.Forms.Panel Pnl_InstallLocationSelect;
        private System.Windows.Forms.TextBox Txt_InstallLocation;
        private System.Windows.Forms.Button Btn_InstallLocationBrowse;
        private System.Windows.Forms.Panel Pnl_ProgramLocation;
        private System.Windows.Forms.Panel Pnl_ProgramLocationSelect;
        private System.Windows.Forms.TextBox Txt_ProgramLocation;
        private System.Windows.Forms.Button Btn_ProgramLocationBrowse;
        private System.Windows.Forms.Button Btn_AddExecutable;
        private System.Windows.Forms.Panel Pnl_ExecutablesHeader;
        private System.Windows.Forms.Label Lbl_RelativeLocation;
        private System.Windows.Forms.Label Lbl_ShortcutName;
        private System.Windows.Forms.Label Lbl_OnDesktop;
        private System.Windows.Forms.Panel Pnl_PaddingPanel;
        private System.Windows.Forms.Panel Pnl_AddExecutable;
        private System.Windows.Forms.Panel Pnl_ExecutablesSelector;
        private System.Windows.Forms.Panel Pnl_Executables;
    }
}

