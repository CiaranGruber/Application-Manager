namespace ApplicationManagerForms
{
    partial class ChooseExecutables
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
            System.Windows.Forms.Label Lbl_ShortcutName;
            System.Windows.Forms.Panel Pnl_Buttons;
            System.Windows.Forms.FlowLayoutPanel Flp_Options;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseExecutables));
            this.Btn_RemoveExecutable = new System.Windows.Forms.Button();
            this.Btn_AddExecutable = new System.Windows.Forms.Button();
            this.ChBox_OnDesktop = new System.Windows.Forms.CheckBox();
            this.Pnl_ShortcutName = new System.Windows.Forms.Panel();
            this.Txt_ShortcutName = new System.Windows.Forms.TextBox();
            this.Pnl_RelativeLocation = new System.Windows.Forms.Panel();
            this.Pnl_ExecutableLocation = new System.Windows.Forms.Panel();
            this.Txt_ExecutablePath = new System.Windows.Forms.TextBox();
            this.Btn_ExecutablePathBrowse = new System.Windows.Forms.Button();
            this.Lbl_ExecutablePath = new System.Windows.Forms.Label();
            Lbl_Title = new System.Windows.Forms.Label();
            Lbl_ShortcutName = new System.Windows.Forms.Label();
            Pnl_Buttons = new System.Windows.Forms.Panel();
            Flp_Options = new System.Windows.Forms.FlowLayoutPanel();
            Pnl_Buttons.SuspendLayout();
            Flp_Options.SuspendLayout();
            this.Pnl_ShortcutName.SuspendLayout();
            this.Pnl_RelativeLocation.SuspendLayout();
            this.Pnl_ExecutableLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            Lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            Lbl_Title.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Lbl_Title.Location = new System.Drawing.Point(50, 50);
            Lbl_Title.Name = "Lbl_Title";
            Lbl_Title.Size = new System.Drawing.Size(682, 80);
            Lbl_Title.TabIndex = 2;
            Lbl_Title.Text = "Application Executables";
            Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_ShortcutName
            // 
            Lbl_ShortcutName.Dock = System.Windows.Forms.DockStyle.Fill;
            Lbl_ShortcutName.Location = new System.Drawing.Point(0, 0);
            Lbl_ShortcutName.Name = "Lbl_ShortcutName";
            Lbl_ShortcutName.Size = new System.Drawing.Size(682, 44);
            Lbl_ShortcutName.TabIndex = 2;
            Lbl_ShortcutName.Text = "Shortcut Name";
            Lbl_ShortcutName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Buttons
            // 
            Pnl_Buttons.Controls.Add(this.Btn_RemoveExecutable);
            Pnl_Buttons.Controls.Add(this.Btn_AddExecutable);
            Pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            Pnl_Buttons.Location = new System.Drawing.Point(50, 333);
            Pnl_Buttons.Name = "Pnl_Buttons";
            Pnl_Buttons.Size = new System.Drawing.Size(682, 50);
            Pnl_Buttons.TabIndex = 16;
            // 
            // Btn_RemoveExecutable
            // 
            this.Btn_RemoveExecutable.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_RemoveExecutable.Location = new System.Drawing.Point(482, 0);
            this.Btn_RemoveExecutable.Name = "Btn_RemoveExecutable";
            this.Btn_RemoveExecutable.Size = new System.Drawing.Size(200, 50);
            this.Btn_RemoveExecutable.TabIndex = 1;
            this.Btn_RemoveExecutable.Text = "Cancel/Remove";
            this.Btn_RemoveExecutable.UseVisualStyleBackColor = true;
            this.Btn_RemoveExecutable.Click += new System.EventHandler(this.Btn_RemoveExecutable_Click);
            // 
            // Btn_AddExecutable
            // 
            this.Btn_AddExecutable.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_AddExecutable.Location = new System.Drawing.Point(0, 0);
            this.Btn_AddExecutable.Name = "Btn_AddExecutable";
            this.Btn_AddExecutable.Size = new System.Drawing.Size(200, 50);
            this.Btn_AddExecutable.TabIndex = 0;
            this.Btn_AddExecutable.Text = "Add/Change";
            this.Btn_AddExecutable.UseVisualStyleBackColor = true;
            this.Btn_AddExecutable.Click += new System.EventHandler(this.Btn_AddExecutable_Click);
            // 
            // Flp_Options
            // 
            Flp_Options.Controls.Add(this.ChBox_OnDesktop);
            Flp_Options.Dock = System.Windows.Forms.DockStyle.Bottom;
            Flp_Options.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            Flp_Options.Location = new System.Drawing.Point(50, 288);
            Flp_Options.Name = "Flp_Options";
            Flp_Options.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            Flp_Options.Size = new System.Drawing.Size(682, 45);
            Flp_Options.TabIndex = 17;
            // 
            // ChBox_OnDesktop
            // 
            this.ChBox_OnDesktop.AutoSize = true;
            this.ChBox_OnDesktop.Location = new System.Drawing.Point(3, 13);
            this.ChBox_OnDesktop.Name = "ChBox_OnDesktop";
            this.ChBox_OnDesktop.Size = new System.Drawing.Size(105, 21);
            this.ChBox_OnDesktop.TabIndex = 0;
            this.ChBox_OnDesktop.Text = "On Desktop";
            this.ChBox_OnDesktop.UseVisualStyleBackColor = true;
            // 
            // Pnl_ShortcutName
            // 
            this.Pnl_ShortcutName.Controls.Add(Lbl_ShortcutName);
            this.Pnl_ShortcutName.Controls.Add(this.Txt_ShortcutName);
            this.Pnl_ShortcutName.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_ShortcutName.Location = new System.Drawing.Point(50, 130);
            this.Pnl_ShortcutName.Name = "Pnl_ShortcutName";
            this.Pnl_ShortcutName.Size = new System.Drawing.Size(682, 66);
            this.Pnl_ShortcutName.TabIndex = 14;
            // 
            // Txt_ShortcutName
            // 
            this.Txt_ShortcutName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Txt_ShortcutName.Location = new System.Drawing.Point(0, 44);
            this.Txt_ShortcutName.Name = "Txt_ShortcutName";
            this.Txt_ShortcutName.Size = new System.Drawing.Size(682, 22);
            this.Txt_ShortcutName.TabIndex = 1;
            this.Txt_ShortcutName.TextChanged += new System.EventHandler(this.Txt_ShortcutName_TextChanged);
            // 
            // Pnl_RelativeLocation
            // 
            this.Pnl_RelativeLocation.Controls.Add(this.Pnl_ExecutableLocation);
            this.Pnl_RelativeLocation.Controls.Add(this.Lbl_ExecutablePath);
            this.Pnl_RelativeLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_RelativeLocation.Location = new System.Drawing.Point(50, 196);
            this.Pnl_RelativeLocation.Name = "Pnl_RelativeLocation";
            this.Pnl_RelativeLocation.Size = new System.Drawing.Size(682, 70);
            this.Pnl_RelativeLocation.TabIndex = 15;
            // 
            // Pnl_ExecutableLocation
            // 
            this.Pnl_ExecutableLocation.Controls.Add(this.Txt_ExecutablePath);
            this.Pnl_ExecutableLocation.Controls.Add(this.Btn_ExecutablePathBrowse);
            this.Pnl_ExecutableLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_ExecutableLocation.Location = new System.Drawing.Point(0, 45);
            this.Pnl_ExecutableLocation.Name = "Pnl_ExecutableLocation";
            this.Pnl_ExecutableLocation.Size = new System.Drawing.Size(682, 25);
            this.Pnl_ExecutableLocation.TabIndex = 24;
            // 
            // Txt_ExecutablePath
            // 
            this.Txt_ExecutablePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_ExecutablePath.Location = new System.Drawing.Point(0, 0);
            this.Txt_ExecutablePath.Name = "Txt_ExecutablePath";
            this.Txt_ExecutablePath.Size = new System.Drawing.Size(554, 22);
            this.Txt_ExecutablePath.TabIndex = 22;
            this.Txt_ExecutablePath.TextChanged += new System.EventHandler(this.Txt_ExecutablePath_TextChanged);
            // 
            // Btn_ExecutablePathBrowse
            // 
            this.Btn_ExecutablePathBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_ExecutablePathBrowse.Location = new System.Drawing.Point(554, 0);
            this.Btn_ExecutablePathBrowse.Name = "Btn_ExecutablePathBrowse";
            this.Btn_ExecutablePathBrowse.Size = new System.Drawing.Size(128, 25);
            this.Btn_ExecutablePathBrowse.TabIndex = 23;
            this.Btn_ExecutablePathBrowse.Text = "Browse";
            this.Btn_ExecutablePathBrowse.UseVisualStyleBackColor = true;
            this.Btn_ExecutablePathBrowse.Click += new System.EventHandler(this.Btn_ExecutableNameBrowse_Click);
            // 
            // Lbl_ExecutablePath
            // 
            this.Lbl_ExecutablePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_ExecutablePath.Location = new System.Drawing.Point(0, 0);
            this.Lbl_ExecutablePath.Name = "Lbl_ExecutablePath";
            this.Lbl_ExecutablePath.Size = new System.Drawing.Size(682, 45);
            this.Lbl_ExecutablePath.TabIndex = 21;
            this.Lbl_ExecutablePath.Text = "Executable Path";
            this.Lbl_ExecutablePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseExecutables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 433);
            this.Controls.Add(Flp_Options);
            this.Controls.Add(Pnl_Buttons);
            this.Controls.Add(this.Pnl_RelativeLocation);
            this.Controls.Add(this.Pnl_ShortcutName);
            this.Controls.Add(Lbl_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseExecutables";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Text = "Executables";
            Pnl_Buttons.ResumeLayout(false);
            Flp_Options.ResumeLayout(false);
            Flp_Options.PerformLayout();
            this.Pnl_ShortcutName.ResumeLayout(false);
            this.Pnl_ShortcutName.PerformLayout();
            this.Pnl_RelativeLocation.ResumeLayout(false);
            this.Pnl_ExecutableLocation.ResumeLayout(false);
            this.Pnl_ExecutableLocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_ShortcutName;
        private System.Windows.Forms.TextBox Txt_ShortcutName;
        private System.Windows.Forms.Panel Pnl_RelativeLocation;
        private System.Windows.Forms.Label Lbl_ExecutablePath;
        private System.Windows.Forms.TextBox Txt_ExecutablePath;
        private System.Windows.Forms.Panel Pnl_ExecutableLocation;
        private System.Windows.Forms.Button Btn_ExecutablePathBrowse;
        private System.Windows.Forms.Button Btn_RemoveExecutable;
        private System.Windows.Forms.Button Btn_AddExecutable;
        private System.Windows.Forms.CheckBox ChBox_OnDesktop;
    }
}