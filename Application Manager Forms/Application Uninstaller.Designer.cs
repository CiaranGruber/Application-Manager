namespace ApplicationManagerForms
{
    partial class ApplicationUninstaller
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
            System.Windows.Forms.Panel Pnl_Buttons;
            System.Windows.Forms.FlowLayoutPanel Flp_Options;
            System.Windows.Forms.Label Lbl_SaveLocation;
            System.Windows.Forms.Label Lbl_InstallLocation;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationUninstaller));
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Uninstall = new System.Windows.Forms.Button();
            this.ChBox_SaveData = new System.Windows.Forms.CheckBox();
            this.Pnl_SaveLocation = new System.Windows.Forms.Panel();
            this.Pnl_SaveLocationSelect = new System.Windows.Forms.Panel();
            this.Txt_SaveLocation = new System.Windows.Forms.TextBox();
            this.Btn_SaveLocationBrowse = new System.Windows.Forms.Button();
            this.Pnl_InstallLocation = new System.Windows.Forms.Panel();
            this.Pnl_InstallLocationSelect = new System.Windows.Forms.Panel();
            this.Txt_InstallLocation = new System.Windows.Forms.TextBox();
            this.Btn_InstallLocationBrowse = new System.Windows.Forms.Button();
            this.Pnl_ExecutablesSelector = new System.Windows.Forms.Panel();
            this.Pnl_Executables = new System.Windows.Forms.Panel();
            this.Pnl_ExecutablesHeader = new System.Windows.Forms.Panel();
            this.Lbl_ShortcutName = new System.Windows.Forms.Label();
            this.Pnl_AddExecutable = new System.Windows.Forms.Panel();
            this.Btn_AddShortcut = new System.Windows.Forms.Button();
            Lbl_Title = new System.Windows.Forms.Label();
            Pnl_Buttons = new System.Windows.Forms.Panel();
            Flp_Options = new System.Windows.Forms.FlowLayoutPanel();
            Lbl_SaveLocation = new System.Windows.Forms.Label();
            Lbl_InstallLocation = new System.Windows.Forms.Label();
            Pnl_Buttons.SuspendLayout();
            Flp_Options.SuspendLayout();
            this.Pnl_SaveLocation.SuspendLayout();
            this.Pnl_SaveLocationSelect.SuspendLayout();
            this.Pnl_InstallLocation.SuspendLayout();
            this.Pnl_InstallLocationSelect.SuspendLayout();
            this.Pnl_ExecutablesSelector.SuspendLayout();
            this.Pnl_ExecutablesHeader.SuspendLayout();
            this.Pnl_AddExecutable.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            Lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            Lbl_Title.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Lbl_Title.Location = new System.Drawing.Point(50, 50);
            Lbl_Title.Name = "Lbl_Title";
            Lbl_Title.Size = new System.Drawing.Size(682, 80);
            Lbl_Title.TabIndex = 1;
            Lbl_Title.Text = "Application Uninstaller";
            Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.Controls.Add(this.Btn_Back);
            Pnl_Buttons.Controls.Add(this.Btn_Uninstall);
            Pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            Pnl_Buttons.Location = new System.Drawing.Point(50, 481);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Size = new System.Drawing.Size(682, 50);
            Pnl_Buttons.TabIndex = 16;
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
            // Btn_Uninstall
            // 
            this.Btn_Uninstall.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Uninstall.Location = new System.Drawing.Point(0, 0);
            this.Btn_Uninstall.Name = "Btn_Uninstall";
            this.Btn_Uninstall.Size = new System.Drawing.Size(200, 50);
            this.Btn_Uninstall.TabIndex = 0;
            this.Btn_Uninstall.Text = "Uninstall";
            this.Btn_Uninstall.UseVisualStyleBackColor = true;
            this.Btn_Uninstall.Click += new System.EventHandler(this.Btn_Uninstall_Click);
            // 
            // Flp_Options
            // 
            Flp_Options.Controls.Add(this.ChBox_SaveData);
            Flp_Options.Dock = System.Windows.Forms.DockStyle.Bottom;
            Flp_Options.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            Flp_Options.Location = new System.Drawing.Point(50, 436);
            Flp_Options.Name = "Flp_Options";
            Flp_Options.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            Flp_Options.Size = new System.Drawing.Size(682, 45);
            Flp_Options.TabIndex = 20;
            // 
            // ChBox_SaveData
            // 
            this.ChBox_SaveData.AutoSize = true;
            this.ChBox_SaveData.Location = new System.Drawing.Point(3, 13);
            this.ChBox_SaveData.Name = "ChBox_SaveData";
            this.ChBox_SaveData.Size = new System.Drawing.Size(214, 21);
            this.ChBox_SaveData.TabIndex = 20;
            this.ChBox_SaveData.Text = "Save data to specific location";
            this.ChBox_SaveData.UseVisualStyleBackColor = true;
            // 
            // Lbl_SaveLocation
            // 
            Lbl_SaveLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            Lbl_SaveLocation.Location = new System.Drawing.Point(0, 0);
            Lbl_SaveLocation.Name = "Lbl_SaveLocation";
            Lbl_SaveLocation.Size = new System.Drawing.Size(682, 41);
            Lbl_SaveLocation.TabIndex = 20;
            Lbl_SaveLocation.Text = "Save Location";
            Lbl_SaveLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_InstallLocation
            // 
            Lbl_InstallLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            Lbl_InstallLocation.Location = new System.Drawing.Point(0, 0);
            Lbl_InstallLocation.Name = "Lbl_InstallLocation";
            Lbl_InstallLocation.Size = new System.Drawing.Size(682, 41);
            Lbl_InstallLocation.TabIndex = 21;
            Lbl_InstallLocation.Text = "Installation Location";
            Lbl_InstallLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_SaveLocation
            // 
            this.Pnl_SaveLocation.Controls.Add(Lbl_SaveLocation);
            this.Pnl_SaveLocation.Controls.Add(this.Pnl_SaveLocationSelect);
            this.Pnl_SaveLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_SaveLocation.Location = new System.Drawing.Point(50, 370);
            this.Pnl_SaveLocation.Name = "Pnl_SaveLocation";
            this.Pnl_SaveLocation.Size = new System.Drawing.Size(682, 66);
            this.Pnl_SaveLocation.TabIndex = 21;
            this.Pnl_SaveLocation.Visible = false;
            // 
            // Pnl_SaveLocationSelect
            // 
            this.Pnl_SaveLocationSelect.Controls.Add(this.Txt_SaveLocation);
            this.Pnl_SaveLocationSelect.Controls.Add(this.Btn_SaveLocationBrowse);
            this.Pnl_SaveLocationSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_SaveLocationSelect.Location = new System.Drawing.Point(0, 41);
            this.Pnl_SaveLocationSelect.Name = "Pnl_SaveLocationSelect";
            this.Pnl_SaveLocationSelect.Size = new System.Drawing.Size(682, 25);
            this.Pnl_SaveLocationSelect.TabIndex = 19;
            // 
            // Txt_SaveLocation
            // 
            this.Txt_SaveLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_SaveLocation.Location = new System.Drawing.Point(0, 0);
            this.Txt_SaveLocation.Name = "Txt_SaveLocation";
            this.Txt_SaveLocation.Size = new System.Drawing.Size(582, 22);
            this.Txt_SaveLocation.TabIndex = 17;
            // 
            // Btn_SaveLocationBrowse
            // 
            this.Btn_SaveLocationBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_SaveLocationBrowse.Location = new System.Drawing.Point(582, 0);
            this.Btn_SaveLocationBrowse.Name = "Btn_SaveLocationBrowse";
            this.Btn_SaveLocationBrowse.Size = new System.Drawing.Size(100, 25);
            this.Btn_SaveLocationBrowse.TabIndex = 16;
            this.Btn_SaveLocationBrowse.Text = "Browse";
            this.Btn_SaveLocationBrowse.UseVisualStyleBackColor = true;
            this.Btn_SaveLocationBrowse.Click += new System.EventHandler(this.Btn_SaveLocationBrowse_Click);
            // 
            // Pnl_InstallLocation
            // 
            this.Pnl_InstallLocation.Controls.Add(Lbl_InstallLocation);
            this.Pnl_InstallLocation.Controls.Add(this.Pnl_InstallLocationSelect);
            this.Pnl_InstallLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_InstallLocation.Location = new System.Drawing.Point(50, 304);
            this.Pnl_InstallLocation.Name = "Pnl_InstallLocation";
            this.Pnl_InstallLocation.Size = new System.Drawing.Size(682, 66);
            this.Pnl_InstallLocation.TabIndex = 22;
            // 
            // Pnl_InstallLocationSelect
            // 
            this.Pnl_InstallLocationSelect.Controls.Add(this.Txt_InstallLocation);
            this.Pnl_InstallLocationSelect.Controls.Add(this.Btn_InstallLocationBrowse);
            this.Pnl_InstallLocationSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_InstallLocationSelect.Location = new System.Drawing.Point(0, 41);
            this.Pnl_InstallLocationSelect.Name = "Pnl_InstallLocationSelect";
            this.Pnl_InstallLocationSelect.Size = new System.Drawing.Size(682, 25);
            this.Pnl_InstallLocationSelect.TabIndex = 20;
            // 
            // Txt_InstallLocation
            // 
            this.Txt_InstallLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_InstallLocation.Location = new System.Drawing.Point(0, 0);
            this.Txt_InstallLocation.Name = "Txt_InstallLocation";
            this.Txt_InstallLocation.Size = new System.Drawing.Size(582, 22);
            this.Txt_InstallLocation.TabIndex = 17;
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
            this.Pnl_ExecutablesSelector.TabIndex = 28;
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
            // Pnl_ExecutablesHeader
            // 
            this.Pnl_ExecutablesHeader.Controls.Add(this.Lbl_ShortcutName);
            this.Pnl_ExecutablesHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_ExecutablesHeader.Location = new System.Drawing.Point(0, 0);
            this.Pnl_ExecutablesHeader.Name = "Pnl_ExecutablesHeader";
            this.Pnl_ExecutablesHeader.Size = new System.Drawing.Size(682, 50);
            this.Pnl_ExecutablesHeader.TabIndex = 25;
            // 
            // Lbl_ShortcutName
            // 
            this.Lbl_ShortcutName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_ShortcutName.Location = new System.Drawing.Point(0, 0);
            this.Lbl_ShortcutName.Name = "Lbl_ShortcutName";
            this.Lbl_ShortcutName.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Lbl_ShortcutName.Size = new System.Drawing.Size(682, 50);
            this.Lbl_ShortcutName.TabIndex = 28;
            this.Lbl_ShortcutName.Text = "Shortcuts";
            this.Lbl_ShortcutName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_AddExecutable
            // 
            this.Pnl_AddExecutable.Controls.Add(this.Btn_AddShortcut);
            this.Pnl_AddExecutable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_AddExecutable.Location = new System.Drawing.Point(0, 114);
            this.Pnl_AddExecutable.Name = "Pnl_AddExecutable";
            this.Pnl_AddExecutable.Size = new System.Drawing.Size(682, 50);
            this.Pnl_AddExecutable.TabIndex = 19;
            // 
            // Btn_AddShortcut
            // 
            this.Btn_AddShortcut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_AddShortcut.Location = new System.Drawing.Point(0, 0);
            this.Btn_AddShortcut.Name = "Btn_AddShortcut";
            this.Btn_AddShortcut.Size = new System.Drawing.Size(682, 50);
            this.Btn_AddShortcut.TabIndex = 3;
            this.Btn_AddShortcut.Text = "Add Shortcut";
            this.Btn_AddShortcut.UseVisualStyleBackColor = true;
            this.Btn_AddShortcut.Click += new System.EventHandler(this.Btn_AddShortcut_Click);
            // 
            // ApplicationUninstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 581);
            this.Controls.Add(this.Pnl_ExecutablesSelector);
            this.Controls.Add(this.Pnl_InstallLocation);
            this.Controls.Add(this.Pnl_SaveLocation);
            this.Controls.Add(Flp_Options);
            this.Controls.Add(Pnl_Buttons);
            this.Controls.Add(Lbl_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicationUninstaller";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Uninstaller";
            this.Load += new System.EventHandler(this.ApplicationUninstaller_Load);
            Pnl_Buttons.ResumeLayout(false);
            Flp_Options.ResumeLayout(false);
            Flp_Options.PerformLayout();
            this.Pnl_SaveLocation.ResumeLayout(false);
            this.Pnl_SaveLocationSelect.ResumeLayout(false);
            this.Pnl_SaveLocationSelect.PerformLayout();
            this.Pnl_InstallLocation.ResumeLayout(false);
            this.Pnl_InstallLocationSelect.ResumeLayout(false);
            this.Pnl_InstallLocationSelect.PerformLayout();
            this.Pnl_ExecutablesSelector.ResumeLayout(false);
            this.Pnl_ExecutablesHeader.ResumeLayout(false);
            this.Pnl_AddExecutable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Uninstall;
        private System.Windows.Forms.CheckBox ChBox_SaveData;
        private System.Windows.Forms.Panel Pnl_SaveLocation;
        private System.Windows.Forms.Panel Pnl_SaveLocationSelect;
        private System.Windows.Forms.TextBox Txt_SaveLocation;
        private System.Windows.Forms.Button Btn_SaveLocationBrowse;
        private System.Windows.Forms.Panel Pnl_InstallLocation;
        private System.Windows.Forms.Panel Pnl_InstallLocationSelect;
        private System.Windows.Forms.TextBox Txt_InstallLocation;
        private System.Windows.Forms.Button Btn_InstallLocationBrowse;
        private System.Windows.Forms.Panel Pnl_ExecutablesSelector;
        private System.Windows.Forms.Panel Pnl_Executables;
        private System.Windows.Forms.Panel Pnl_ExecutablesHeader;
        private System.Windows.Forms.Label Lbl_ShortcutName;
        private System.Windows.Forms.Panel Pnl_AddExecutable;
        private System.Windows.Forms.Button Btn_AddShortcut;
    }
}