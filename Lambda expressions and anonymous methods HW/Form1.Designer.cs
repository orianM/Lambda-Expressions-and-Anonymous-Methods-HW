
namespace Lambda_expressions_and_anonymous_methods_HW
{
    partial class frmMain
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
            this.mnsChoosePanel = new System.Windows.Forms.MenuStrip();
            this.greetingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mnsChoosePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsChoosePanel
            // 
            this.mnsChoosePanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greetingsToolStripMenuItem,
            this.addToolStripMenuItem});
            this.mnsChoosePanel.Location = new System.Drawing.Point(0, 0);
            this.mnsChoosePanel.Name = "mnsChoosePanel";
            this.mnsChoosePanel.Size = new System.Drawing.Size(800, 24);
            this.mnsChoosePanel.TabIndex = 0;
            this.mnsChoosePanel.Text = "menuStrip1";
            // 
            // greetingsToolStripMenuItem
            // 
            this.greetingsToolStripMenuItem.Name = "greetingsToolStripMenuItem";
            this.greetingsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.greetingsToolStripMenuItem.Text = "Greetings";
            this.greetingsToolStripMenuItem.Click += new System.EventHandler(this.greetingsToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.addToolStripMenuItem.Text = "Calculator";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 426);
            this.panel1.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnsChoosePanel);
            this.MainMenuStrip = this.mnsChoosePanel;
            this.Name = "frmMain";
            this.Text = "Lambda Expressions & Anonymous Methods HW";
            this.mnsChoosePanel.ResumeLayout(false);
            this.mnsChoosePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsChoosePanel;
        private System.Windows.Forms.ToolStripMenuItem greetingsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}

