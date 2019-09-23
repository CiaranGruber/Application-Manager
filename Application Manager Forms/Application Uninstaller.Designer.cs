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
            System.Windows.Forms.Label Lbl_ShortcutName;
            System.Windows.Forms.Label Lbl_SaveLocation;
            System.Windows.Forms.Label Lbl_InstallLocation;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationUninstaller));
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Uninstall = new System.Windows.Forms.Button();
            this.Txt_ShortcutName = new System.Windows.Forms.TextBox();
            this.Pnl_ShortcutName = new System.Windows.Forms.Panel();
            this.Pnl_SaveLocation = new System.Windows.Forms.Panel();
            this.Pnl_SaveLocationSelect = new System.Windows.Forms.Panel();
            this.Txt_SaveLocation = new System.Windows.Forms.TextBox();
            this.Btn_SaveLocationBrowse = new System.Windows.Forms.Button();
            this.ChBox_SaveData = new System.Windows.Forms.CheckBox();
            this.Pnl_InstallLocationSelect = new System.Windows.Forms.Panel();
            this.Txt_InstallLocation = new System.Windows.Forms.TextBox();
            this.Btn_InstallLocationBrowse = new System.Windows.Forms.Button();
            this.Pnl_InstallLocation = new System.Windows.Forms.Panel();
            Lbl_Title = new System.Windows.Forms.Label();
            Pnl_Buttons = new System.Windows.Forms.Panel();
            Lbl_ShortcutName = new System.Windows.Forms.Label();
            Lbl_SaveLocation = new System.Windows.Forms.Label();
            Lbl_InstallLocation = new System.Windows.Forms.Label();
            Pnl_Buttons.SuspendLayout();
            this.Pnl_ShortcutName.SuspendLayout();
            this.Pnl_SaveLocation.SuspendLayout();
            this.Pnl_SaveLocationSelect.SuspendLayout();
            this.Pnl_InstallLocationSelect.SuspendLayout();
            this.Pnl_InstallLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            Lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            Lbl_Title.Font = new System.Drawing.Font("Monotxt_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Lbl_Title.Location = new System.Drawing.Point(50, 50);
            Lbl_Title.Name = "Lbl_Title";
            Lbl_Title.Size = new System.Drawing.Size(712, 80);
            Lbl_Title.TabIndex = 1;
            Lbl_Title.Text = "Application Uninstaller";
            Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.Controls.Add(this.Btn_Back);
            Pnl_Buttons.Controls.Add(this.Btn_Uninstall);
            Pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            Pnl_Buttons.Location = new System.Drawing.Point(50, 383);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Size = new System.Drawing.Size(712, 50);
            Pnl_Buttons.TabIndex = 16;
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
            // Btn_Uninstall
            // 
            this.Btn_Uninstall.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Uninstall.Location = new System.Drawing.Point(512, 0);
            this.Btn_Uninstall.Name = "Btn_Uninstall";
            this.Btn_Uninstall.Size = new System.Drawing.Size(200, 50);
            this.Btn_Uninstall.TabIndex = 0;
            this.Btn_Uninstall.Text = "Uninstall";
            this.Btn_Uninstall.UseVisualStyleBackColor = true;
            this.Btn_Uninstall.Click += new System.EventHandler(this.Btn_Uninstall_Click);
            // 
            // Lbl_ShortcutName
            // 
            Lbl_ShortcutName.Dock = System.Windows.Forms.DockStyle.Fill;
            Lbl_ShortcutName.Location = new System.Drawing.Point(0, 0);
            Lbl_ShortcutName.Name = "Lbl_ShortcutName";
            Lbl_ShortcutName.Size = new System.Drawing.Size(712, 44);
            Lbl_ShortcutName.TabIndex = 2;
            Lbl_ShortcutName.Text = "Shortcut Name";
            Lbl_ShortcutName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_SaveLocation
            // 
            Lbl_SaveLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            Lbl_SaveLocation.Location = new System.Drawing.Point(0, 0);
            Lbl_SaveLocation.Name = "Lbl_SaveLocation";
            Lbl_SaveLocation.Size = new System.Drawing.Size(712, 41);
            Lbl_SaveLocation.TabIndex = 20;
            Lbl_SaveLocation.Text = "Save Location";
            Lbl_SaveLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_InstallLocation
            // 
            Lbl_InstallLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            Lbl_InstallLocation.Location = new System.Drawing.Point(0, 0);
            Lbl_InstallLocation.Name = "Lbl_InstallLocation";
            Lbl_InstallLocation.Size = new System.Drawing.Size(712, 41);
            Lbl_InstallLocation.TabIndex = 21;
            Lbl_InstallLocation.Text = "Installation Location";
            Lbl_InstallLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_ShortcutName
            // 
            this.Txt_ShortcutName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Txt_ShortcutName.Location = new System.Drawing.Point(0, 44);
            this.Txt_ShortcutName.Name = "Txt_ShortcutName";
            this.Txt_ShortcutName.Size = new System.Drawing.Size(712, 22);
            this.Txt_ShortcutName.TabIndex = 1;
            // 
            // Pnl_ShortcutName
            // 
            this.Pnl_ShortcutName.Controls.Add(Lbl_ShortcutName);
            this.Pnl_ShortcutName.Controls.Add(this.Txt_ShortcutName);
            this.Pnl_ShortcutName.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_ShortcutName.Location = new System.Drawing.Point(50, 130);
            this.Pnl_ShortcutName.Name = "Pnl_ShortcutName";
            this.Pnl_ShortcutName.Size = new System.Drawing.Size(712, 66);
            this.Pnl_ShortcutName.TabIndex = 13;
            // 
            // Pnl_SaveLocation
            // 
            this.Pnl_SaveLocation.Controls.Add(Lbl_SaveLocation);
            this.Pnl_SaveLocation.Controls.Add(this.Pnl_SaveLocationSelect);
            this.Pnl_SaveLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_SaveLocation.Location = new System.Drawing.Point(50, 262);
            this.Pnl_SaveLocation.Name = "Pnl_SaveLocation";
            this.Pnl_SaveLocation.Size = new System.Drawing.Size(712, 66);
            this.Pnl_SaveLocation.TabIndex = 18;
            this.Pnl_SaveLocation.Visible = false;
            // 
            // Pnl_SaveLocationSelect
            // 
            this.Pnl_SaveLocationSelect.Controls.Add(this.Txt_SaveLocation);
            this.Pnl_SaveLocationSelect.Controls.Add(this.Btn_SaveLocationBrowse);
            this.Pnl_SaveLocationSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_SaveLocationSelect.Location = new System.Drawing.Point(0, 41);
            this.Pnl_SaveLocationSelect.Name = "Pnl_SaveLocationSelect";
            this.Pnl_SaveLocationSelect.Size = new System.Drawing.Size(712, 25);
            this.Pnl_SaveLocationSelect.TabIndex = 19;
            // 
            // Txt_SaveLocation
            // 
            this.Txt_SaveLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_SaveLocation.Location = new System.Drawing.Point(0, 0);
            this.Txt_SaveLocation.Name = "Txt_SaveLocation";
            this.Txt_SaveLocation.Size = new System.Drawing.Size(612, 22);
            this.Txt_SaveLocation.TabIndex = 17;
            // 
            // Btn_SaveLocationBrowse
            // 
            this.Btn_SaveLocationBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_SaveLocationBrowse.Location = new System.Drawing.Point(612, 0);
            this.Btn_SaveLocationBrowse.Name = "Btn_SaveLocationBrowse";
            this.Btn_SaveLocationBrowse.Size = new System.Drawing.Size(100, 25);
            this.Btn_SaveLocationBrowse.TabIndex = 16;
            this.Btn_SaveLocationBrowse.Text = "Browse";
            this.Btn_SaveLocationBrowse.UseVisualStyleBackColor = true;
            this.Btn_SaveLocationBrowse.Click += new System.EventHandler(this.Btn_SaveLocationBrowse_Click);
            // 
            // ChBox_SaveData
            // 
            this.ChBox_SaveData.AutoSize = true;
            this.ChBox_SaveData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChBox_SaveData.Location = new System.Drawing.Point(50, 328);
            this.ChBox_SaveData.Name = "ChBox_SaveData";
            this.ChBox_SaveData.Size = new System.Drawing.Size(712, 55);
            this.ChBox_SaveData.TabIndex = 19;
            this.ChBox_SaveData.Text = "Save data to specific location";
            this.ChBox_SaveData.UseVisualStyleBackColor = true;
            this.ChBox_SaveData.CheckedChanged += new System.EventHandler(this.ChBox_SaveData_CheckedChanged);
            // 
            // Pnl_InstallLocationSelect
            // 
            this.Pnl_InstallLocationSelect.Controls.Add(this.Txt_InstallLocation);
            this.Pnl_InstallLocationSelect.Controls.Add(this.Btn_InstallLocationBrowse);
            this.Pnl_InstallLocationSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_InstallLocationSelect.Location = new System.Drawing.Point(0, 41);
            this.Pnl_InstallLocationSelect.Name = "Pnl_InstallLocationSelect";
            this.Pnl_InstallLocationSelect.Size = new System.Drawing.Size(712, 25);
            this.Pnl_InstallLocationSelect.TabIndex = 20;
            // 
            // Txt_InstallLocation
            // 
            this.Txt_InstallLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_InstallLocation.Location = new System.Drawing.Point(0, 0);
            this.Txt_InstallLocation.Name = "Txt_InstallLocation";
            this.Txt_InstallLocation.Size = new System.Drawing.Size(612, 22);
            this.Txt_InstallLocation.TabIndex = 17;
            // 
            // Btn_InstallLocationBrowse
            // 
            this.Btn_InstallLocationBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_InstallLocationBrowse.Location = new System.Drawing.Point(612, 0);
            this.Btn_InstallLocationBrowse.Name = "Btn_InstallLocationBrowse";
            this.Btn_InstallLocationBrowse.Size = new System.Drawing.Size(100, 25);
            this.Btn_InstallLocationBrowse.TabIndex = 16;
            this.Btn_InstallLocationBrowse.Text = "Browse";
            this.Btn_InstallLocationBrowse.UseVisualStyleBackColor = true;
            this.Btn_InstallLocationBrowse.Click += new System.EventHandler(this.Btn_InstallLocationBrowse_Click);
            // 
            // Pnl_InstallLocation
            // 
            this.Pnl_InstallLocation.Controls.Add(Lbl_InstallLocation);
            this.Pnl_InstallLocation.Controls.Add(this.Pnl_InstallLocationSelect);
            this.Pnl_InstallLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_InstallLocation.Location = new System.Drawing.Point(50, 196);
            this.Pnl_InstallLocation.Name = "Pnl_InstallLocation";
            this.Pnl_InstallLocation.Size = new System.Drawing.Size(712, 66);
            this.Pnl_InstallLocation.TabIndex = 15;
            // 
            // ApplicationUninstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 483);
            this.Controls.Add(this.ChBox_SaveData);
            this.Controls.Add(this.Pnl_SaveLocation);
            this.Controls.Add(Pnl_Buttons);
            this.Controls.Add(this.Pnl_InstallLocation);
            this.Controls.Add(this.Pnl_ShortcutName);
            this.Controls.Add(Lbl_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicationUninstaller";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Uninstaller";
            this.Load += new System.EventHandler(this.ApplicationUninstaller_Load);
            Pnl_Buttons.ResumeLayout(false);
            this.Pnl_ShortcutName.ResumeLayout(false);
            this.Pnl_ShortcutName.PerformLayout();
            this.Pnl_SaveLocation.ResumeLayout(false);
            this.Pnl_SaveLocationSelect.ResumeLayout(false);
            this.Pnl_SaveLocationSelect.PerformLayout();
            this.Pnl_InstallLocationSelect.ResumeLayout(false);
            this.Pnl_InstallLocationSelect.PerformLayout();
            this.Pnl_InstallLocation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Uninstall;
        private System.Windows.Forms.TextBox Txt_ShortcutName;
        private System.Windows.Forms.Panel Pnl_ShortcutName;
        private System.Windows.Forms.Panel Pnl_SaveLocation;
        private System.Windows.Forms.CheckBox ChBox_SaveData;
        private System.Windows.Forms.Panel Pnl_SaveLocationSelect;
        private System.Windows.Forms.TextBox Txt_SaveLocation;
        private System.Windows.Forms.Button Btn_SaveLocationBrowse;
        private System.Windows.Forms.Panel Pnl_InstallLocationSelect;
        private System.Windows.Forms.TextBox Txt_InstallLocation;
        private System.Windows.Forms.Button Btn_InstallLocationBrowse;
        private System.Windows.Forms.Panel Pnl_InstallLocation;
    }
}