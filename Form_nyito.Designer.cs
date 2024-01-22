namespace _2024_jan_21_autok_kortea
{
    partial class Form_nyito
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.autokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törölToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_autok = new System.Windows.Forms.ListBox();
            this.panel_marka = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // autokToolStripMenuItem
            // 
            this.autokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módosítToolStripMenuItem,
            this.törölToolStripMenuItem});
            this.autokToolStripMenuItem.Name = "autokToolStripMenuItem";
            this.autokToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.autokToolStripMenuItem.Text = "Autok";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // módosítToolStripMenuItem
            // 
            this.módosítToolStripMenuItem.Name = "módosítToolStripMenuItem";
            this.módosítToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.módosítToolStripMenuItem.Text = "Módosít";
            this.módosítToolStripMenuItem.Click += new System.EventHandler(this.módosítToolStripMenuItem_Click);
            // 
            // törölToolStripMenuItem
            // 
            this.törölToolStripMenuItem.Name = "törölToolStripMenuItem";
            this.törölToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.törölToolStripMenuItem.Text = "Töröl";
            this.törölToolStripMenuItem.Click += new System.EventHandler(this.törölToolStripMenuItem_Click);
            // 
            // listBox_autok
            // 
            this.listBox_autok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_autok.FormattingEnabled = true;
            this.listBox_autok.ItemHeight = 16;
            this.listBox_autok.Location = new System.Drawing.Point(0, 28);
            this.listBox_autok.Name = "listBox_autok";
            this.listBox_autok.Size = new System.Drawing.Size(323, 542);
            this.listBox_autok.TabIndex = 1;
            // 
            // panel_marka
            // 
            this.panel_marka.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_marka.Location = new System.Drawing.Point(767, 28);
            this.panel_marka.Name = "panel_marka";
            this.panel_marka.Size = new System.Drawing.Size(200, 542);
            this.panel_marka.TabIndex = 2;
            // 
            // Form_nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 570);
            this.Controls.Add(this.panel_marka);
            this.Controls.Add(this.listBox_autok);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_nyito";
            this.Text = "Autók listája";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem autokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosítToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törölToolStripMenuItem;
        public System.Windows.Forms.ListBox listBox_autok;
        private System.Windows.Forms.Panel panel_marka;
    }
}

