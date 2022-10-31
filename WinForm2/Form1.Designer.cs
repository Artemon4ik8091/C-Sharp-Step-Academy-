namespace WinForm2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.темаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Theme_light = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Theme_dark = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.темаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // темаToolStripMenuItem
            // 
            this.темаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Theme_light,
            this.mi_Theme_dark});
            this.темаToolStripMenuItem.Name = "темаToolStripMenuItem";
            this.темаToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.темаToolStripMenuItem.Text = "Тема";
            // 
            // mi_Theme_light
            // 
            this.mi_Theme_light.Checked = true;
            this.mi_Theme_light.CheckOnClick = true;
            this.mi_Theme_light.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_Theme_light.Name = "mi_Theme_light";
            this.mi_Theme_light.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.mi_Theme_light.Size = new System.Drawing.Size(183, 22);
            this.mi_Theme_light.Text = "Светлая тема";
            this.mi_Theme_light.Click += new System.EventHandler(this.mi_Theme_light_Click);
            // 
            // mi_Theme_dark
            // 
            this.mi_Theme_dark.CheckOnClick = true;
            this.mi_Theme_dark.Name = "mi_Theme_dark";
            this.mi_Theme_dark.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.mi_Theme_dark.Size = new System.Drawing.Size(183, 22);
            this.mi_Theme_dark.Text = "Тёмная тема";
            this.mi_Theme_dark.Click += new System.EventHandler(this.mi_Theme_dark_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem темаToolStripMenuItem;
        private ToolStripMenuItem mi_Theme_light;
        private ToolStripMenuItem mi_Theme_dark;
    }
}