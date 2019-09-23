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
            System.Windows.Forms.Label Lbl_InstallLocation;
            System.Windows.Forms.Panel Pnl_Buttons;
            System.Windows.Forms.Label Lbl_ShortcutName;
            System.Windows.Forms.Label Lbl_SaveLocation;
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Uninstall = new System.Windows.Forms.Button();
            this.Pnl_InstallLocation = new System.Windows.Forms.Panel();
            this.Txt_InstallLocation = new System.Windows.Forms.TextBox();
            this.Txt_ShortcutName = new System.Windows.Forms.TextBox();
            this.Pnl_ShortcutName = new System.Windows.Forms.Panel();
            this.Pnl_SaveLocation = new System.Windows.Forms.Panel();
            this.Txt_SaveLocation = new System.Windows.Forms.TextBox();
            this.ChBox_SaveData = new System.Windows.Forms.CheckBox();
            Lbl_Title = new System.Windows.Forms.Label();
            Lbl_InstallLocation = new System.Windows.Forms.Label();
            Pnl_Buttons = new System.Windows.Forms.Panel();
            Lbl_ShortcutName = new System.Windows.Forms.Label();
            Lbl_SaveLocation = new System.Windows.Forms.Label();
            Pnl_Buttons.SuspendLayout();
            this.Pnl_InstallLocation.SuspendLayout();
            this.Pnl_ShortcutName.SuspendLayout();
            this.Pnl_SaveLocation.SuspendLayout();
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
            // Lbl_InstallLocation
            // 
            Lbl_InstallLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            Lbl_InstallLocation.Location = new System.Drawing.Point(0, 0);
            Lbl_InstallLocation.Name = "Lbl_InstallLocation";
            Lbl_InstallLocation.Size = new System.Drawing.Size(712, 44);
            Lbl_InstallLocation.TabIndex = 2;
            Lbl_InstallLocation.Text = "Installation Location";
            Lbl_InstallLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            Lbl_SaveLocation.Size = new System.Drawing.Size(712, 44);
            Lbl_SaveLocation.TabIndex = 2;
            Lbl_SaveLocation.Text = "Save Location";
            Lbl_SaveLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_InstallLocation
            // 
            this.Pnl_InstallLocation.Controls.Add(Lbl_InstallLocation);
            this.Pnl_InstallLocation.Controls.Add(this.Txt_InstallLocation);
            this.Pnl_InstallLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_InstallLocation.Location = new System.Drawing.Point(50, 196);
            this.Pnl_InstallLocation.Name = "Pnl_InstallLocation";
            this.Pnl_InstallLocation.Size = new System.Drawing.Size(712, 66);
            this.Pnl_InstallLocation.TabIndex = 15;
            // 
            // Txt_InstallLocation
            // 
            this.Txt_InstallLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Txt_InstallLocation.Location = new System.Drawing.Point(0, 44);
            this.Txt_InstallLocation.Name = "Txt_InstallLocation";
            this.Txt_InstallLocation.Size = new System.Drawing.Size(712, 22);
            this.Txt_InstallLocation.TabIndex = 1;
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
            this.Pnl_SaveLocation.Controls.Add(this.Txt_SaveLocation);
            this.Pnl_SaveLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_SaveLocation.Location = new System.Drawing.Point(50, 262);
            this.Pnl_SaveLocation.Name = "Pnl_SaveLocation";
            this.Pnl_SaveLocation.Size = new System.Drawing.Size(712, 66);
            this.Pnl_SaveLocation.TabIndex = 18;
            this.Pnl_SaveLocation.Visible = false;
            // 
            // Txt_SaveLocation
            // 
            this.Txt_SaveLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Txt_SaveLocation.Location = new System.Drawing.Point(0, 44);
            this.Txt_SaveLocation.Name = "Txt_SaveLocation";
            this.Txt_SaveLocation.Size = new System.Drawing.Size(712, 22);
            this.Txt_SaveLocation.TabIndex = 1;
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
            this.Name = "ApplicationUninstaller";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Text = "Application Uninstaller";
            this.Load += new System.EventHandler(this.ApplicationUninstaller_Load);
            Pnl_Buttons.ResumeLayout(false);
            this.Pnl_InstallLocation.ResumeLayout(false);
            this.Pnl_InstallLocation.PerformLayout();
            this.Pnl_ShortcutName.ResumeLayout(false);
            this.Pnl_ShortcutName.PerformLayout();
            this.Pnl_SaveLocation.ResumeLayout(false);
            this.Pnl_SaveLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_InstallLocation;
        private System.Windows.Forms.TextBox Txt_InstallLocation;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Uninstall;
        private System.Windows.Forms.TextBox Txt_ShortcutName;
        private System.Windows.Forms.Panel Pnl_ShortcutName;
        private System.Windows.Forms.Panel Pnl_SaveLocation;
        private System.Windows.Forms.TextBox Txt_SaveLocation;
        private System.Windows.Forms.CheckBox ChBox_SaveData;
    }
}