namespace ApplicationManagerForms
{
    partial class ApplicationManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationManager));
            this.Pnl_Close = new System.Windows.Forms.Panel();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Pnl_Uninstaller = new System.Windows.Forms.Panel();
            this.Btn_Uninstaller = new System.Windows.Forms.Button();
            this.Pnl_Installer = new System.Windows.Forms.Panel();
            this.Btn_Installer = new System.Windows.Forms.Button();
            Lbl_Title = new System.Windows.Forms.Label();
            this.Pnl_Close.SuspendLayout();
            this.Pnl_Uninstaller.SuspendLayout();
            this.Pnl_Installer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            Lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Lbl_Title.Font = new System.Drawing.Font("Monotxt_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Lbl_Title.Location = new System.Drawing.Point(50, 35);
            Lbl_Title.Name = "Lbl_Title";
            Lbl_Title.Size = new System.Drawing.Size(532, 58);
            Lbl_Title.TabIndex = 12;
            Lbl_Title.Text = "Application Manager";
            Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Close
            // 
            this.Pnl_Close.Controls.Add(this.Btn_Close);
            this.Pnl_Close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Close.Location = new System.Drawing.Point(50, 233);
            this.Pnl_Close.Name = "Pnl_Close";
            this.Pnl_Close.Padding = new System.Windows.Forms.Padding(10);
            this.Pnl_Close.Size = new System.Drawing.Size(532, 70);
            this.Pnl_Close.TabIndex = 8;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Close.Location = new System.Drawing.Point(10, 10);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(512, 50);
            this.Btn_Close.TabIndex = 4;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Pnl_Uninstaller
            // 
            this.Pnl_Uninstaller.Controls.Add(this.Btn_Uninstaller);
            this.Pnl_Uninstaller.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Uninstaller.Location = new System.Drawing.Point(50, 163);
            this.Pnl_Uninstaller.Name = "Pnl_Uninstaller";
            this.Pnl_Uninstaller.Padding = new System.Windows.Forms.Padding(10);
            this.Pnl_Uninstaller.Size = new System.Drawing.Size(532, 70);
            this.Pnl_Uninstaller.TabIndex = 10;
            // 
            // Btn_Uninstaller
            // 
            this.Btn_Uninstaller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Uninstaller.Location = new System.Drawing.Point(10, 10);
            this.Btn_Uninstaller.Name = "Btn_Uninstaller";
            this.Btn_Uninstaller.Size = new System.Drawing.Size(512, 50);
            this.Btn_Uninstaller.TabIndex = 4;
            this.Btn_Uninstaller.Text = "Uninstaller";
            this.Btn_Uninstaller.UseVisualStyleBackColor = true;
            this.Btn_Uninstaller.Click += new System.EventHandler(this.Btn_Uninstaller_Click);
            // 
            // Pnl_Installer
            // 
            this.Pnl_Installer.Controls.Add(this.Btn_Installer);
            this.Pnl_Installer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Installer.Location = new System.Drawing.Point(50, 93);
            this.Pnl_Installer.Name = "Pnl_Installer";
            this.Pnl_Installer.Padding = new System.Windows.Forms.Padding(10);
            this.Pnl_Installer.Size = new System.Drawing.Size(532, 70);
            this.Pnl_Installer.TabIndex = 11;
            // 
            // Btn_Installer
            // 
            this.Btn_Installer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Installer.Location = new System.Drawing.Point(10, 10);
            this.Btn_Installer.Name = "Btn_Installer";
            this.Btn_Installer.Size = new System.Drawing.Size(512, 50);
            this.Btn_Installer.TabIndex = 4;
            this.Btn_Installer.Text = "Installer";
            this.Btn_Installer.UseVisualStyleBackColor = true;
            this.Btn_Installer.Click += new System.EventHandler(this.Btn_Installer_Click);
            // 
            // ApplicationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 353);
            this.Controls.Add(Lbl_Title);
            this.Controls.Add(this.Pnl_Installer);
            this.Controls.Add(this.Pnl_Uninstaller);
            this.Controls.Add(this.Pnl_Close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicationManager";
            this.Padding = new System.Windows.Forms.Padding(50, 35, 50, 50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Manager";
            this.Pnl_Close.ResumeLayout(false);
            this.Pnl_Uninstaller.ResumeLayout(false);
            this.Pnl_Installer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Close;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Panel Pnl_Uninstaller;
        private System.Windows.Forms.Button Btn_Uninstaller;
        private System.Windows.Forms.Panel Pnl_Installer;
        private System.Windows.Forms.Button Btn_Installer;
    }
}