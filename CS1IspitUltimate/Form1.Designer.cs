namespace CS1IspitUltimate
{
    partial class Ispit
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
            this.tbIspis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSlova = new System.Windows.Forms.TextBox();
            this.tbReci = new System.Windows.Forms.TextBox();
            this.tbPasusi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbIspis
            // 
            this.tbIspis.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbIspis.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIspis.Location = new System.Drawing.Point(12, 12);
            this.tbIspis.Multiline = true;
            this.tbIspis.Name = "tbIspis";
            this.tbIspis.ReadOnly = true;
            this.tbIspis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbIspis.Size = new System.Drawing.Size(260, 149);
            this.tbIspis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(233, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "©2018 JR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(48, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj slova:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(48, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj reči:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(48, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Broj pasusa:";
            // 
            // tbSlova
            // 
            this.tbSlova.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSlova.Location = new System.Drawing.Point(161, 167);
            this.tbSlova.Name = "tbSlova";
            this.tbSlova.Size = new System.Drawing.Size(40, 23);
            this.tbSlova.TabIndex = 6;
            // 
            // tbReci
            // 
            this.tbReci.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbReci.Location = new System.Drawing.Point(161, 197);
            this.tbReci.Name = "tbReci";
            this.tbReci.Size = new System.Drawing.Size(40, 23);
            this.tbReci.TabIndex = 7;
            // 
            // tbPasusi
            // 
            this.tbPasusi.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPasusi.Location = new System.Drawing.Point(161, 229);
            this.tbPasusi.Name = "tbPasusi";
            this.tbPasusi.Size = new System.Drawing.Size(40, 23);
            this.tbPasusi.TabIndex = 8;
            // 
            // Ispit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbPasusi);
            this.Controls.Add(this.tbReci);
            this.Controls.Add(this.tbSlova);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIspis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ispit";
            this.Text = "Ispit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSlova;
        private System.Windows.Forms.TextBox tbReci;
        private System.Windows.Forms.TextBox tbPasusi;
    }
}

