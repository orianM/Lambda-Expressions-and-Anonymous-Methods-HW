
namespace Lambda_expressions_and_anonymous_methods_HW
{
    partial class GreetingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShalom = new System.Windows.Forms.Button();
            this.btnPrint2 = new System.Windows.Forms.Button();
            this.btnShalomName = new System.Windows.Forms.Button();
            this.btnWelcomeName = new System.Windows.Forms.Button();
            this.txtShalomName = new System.Windows.Forms.TextBox();
            this.txtWelcomeName = new System.Windows.Forms.TextBox();
            this.lblEnterName1 = new System.Windows.Forms.Label();
            this.lblEnterName2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShalom
            // 
            this.btnShalom.Location = new System.Drawing.Point(123, 86);
            this.btnShalom.Name = "btnShalom";
            this.btnShalom.Size = new System.Drawing.Size(75, 48);
            this.btnShalom.TabIndex = 1;
            this.btnShalom.Text = "Shalom";
            this.btnShalom.UseVisualStyleBackColor = true;
            this.btnShalom.Click += new System.EventHandler(this.btnShalom_Click);
            // 
            // btnPrint2
            // 
            this.btnPrint2.Location = new System.Drawing.Point(123, 140);
            this.btnPrint2.Name = "btnPrint2";
            this.btnPrint2.Size = new System.Drawing.Size(75, 48);
            this.btnPrint2.TabIndex = 2;
            this.btnPrint2.Text = "Print2";
            this.btnPrint2.UseVisualStyleBackColor = true;
            this.btnPrint2.Click += new System.EventHandler(this.btnPrint2_Click);
            // 
            // btnShalomName
            // 
            this.btnShalomName.Location = new System.Drawing.Point(123, 194);
            this.btnShalomName.Name = "btnShalomName";
            this.btnShalomName.Size = new System.Drawing.Size(75, 48);
            this.btnShalomName.TabIndex = 3;
            this.btnShalomName.Text = "Shalom";
            this.btnShalomName.UseVisualStyleBackColor = true;
            this.btnShalomName.Click += new System.EventHandler(this.btnShalomName_Click);
            // 
            // btnWelcomeName
            // 
            this.btnWelcomeName.Location = new System.Drawing.Point(123, 277);
            this.btnWelcomeName.Name = "btnWelcomeName";
            this.btnWelcomeName.Size = new System.Drawing.Size(75, 48);
            this.btnWelcomeName.TabIndex = 4;
            this.btnWelcomeName.Text = "Welcome";
            this.btnWelcomeName.UseVisualStyleBackColor = true;
            this.btnWelcomeName.Click += new System.EventHandler(this.btnWelcomeName_Click);
            // 
            // txtShalomName
            // 
            this.txtShalomName.Location = new System.Drawing.Point(123, 248);
            this.txtShalomName.Name = "txtShalomName";
            this.txtShalomName.Size = new System.Drawing.Size(75, 23);
            this.txtShalomName.TabIndex = 5;
            // 
            // txtWelcomeName
            // 
            this.txtWelcomeName.Location = new System.Drawing.Point(123, 331);
            this.txtWelcomeName.Name = "txtWelcomeName";
            this.txtWelcomeName.Size = new System.Drawing.Size(75, 23);
            this.txtWelcomeName.TabIndex = 6;
            // 
            // lblEnterName1
            // 
            this.lblEnterName1.AutoSize = true;
            this.lblEnterName1.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblEnterName1.Location = new System.Drawing.Point(50, 256);
            this.lblEnterName1.Name = "lblEnterName1";
            this.lblEnterName1.Size = new System.Drawing.Size(67, 15);
            this.lblEnterName1.TabIndex = 7;
            this.lblEnterName1.Text = "Enter name";
            // 
            // lblEnterName2
            // 
            this.lblEnterName2.AutoSize = true;
            this.lblEnterName2.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblEnterName2.Location = new System.Drawing.Point(50, 339);
            this.lblEnterName2.Name = "lblEnterName2";
            this.lblEnterName2.Size = new System.Drawing.Size(67, 15);
            this.lblEnterName2.TabIndex = 8;
            this.lblEnterName2.Text = "Enter name";
            // 
            // GreetingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lblEnterName2);
            this.Controls.Add(this.lblEnterName1);
            this.Controls.Add(this.txtWelcomeName);
            this.Controls.Add(this.txtShalomName);
            this.Controls.Add(this.btnWelcomeName);
            this.Controls.Add(this.btnShalomName);
            this.Controls.Add(this.btnPrint2);
            this.Controls.Add(this.btnShalom);
            this.Name = "GreetingsControl";
            this.Size = new System.Drawing.Size(774, 466);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShalom;
        private System.Windows.Forms.Button btnPrint2;
        private System.Windows.Forms.Button btnShalomName;
        private System.Windows.Forms.Button btnWelcomeName;
        private System.Windows.Forms.TextBox txtShalomName;
        private System.Windows.Forms.TextBox txtWelcomeName;
        private System.Windows.Forms.Label lblEnterName1;
        private System.Windows.Forms.Label lblEnterName2;
    }
}
