namespace Slotss
{
    partial class Form1
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
            this.pbSlot1 = new System.Windows.Forms.PictureBox();
            this.pbSlot2 = new System.Windows.Forms.PictureBox();
            this.pbSlot3 = new System.Windows.Forms.PictureBox();
            this.numCicluri = new System.Windows.Forms.NumericUpDown();
            this.btnTrage = new System.Windows.Forms.Button();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.lblCredite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCicluri)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSlot1
            // 
            this.pbSlot1.Location = new System.Drawing.Point(91, 92);
            this.pbSlot1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSlot1.Name = "pbSlot1";
            this.pbSlot1.Size = new System.Drawing.Size(115, 131);
            this.pbSlot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlot1.TabIndex = 0;
            this.pbSlot1.TabStop = false;
            this.pbSlot1.Click += new System.EventHandler(this.pSlot1_Click);
            // 
            // pbSlot2
            // 
            this.pbSlot2.Location = new System.Drawing.Point(211, 92);
            this.pbSlot2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSlot2.Name = "pbSlot2";
            this.pbSlot2.Size = new System.Drawing.Size(115, 131);
            this.pbSlot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlot2.TabIndex = 1;
            this.pbSlot2.TabStop = false;
            // 
            // pbSlot3
            // 
            this.pbSlot3.Location = new System.Drawing.Point(330, 92);
            this.pbSlot3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSlot3.Name = "pbSlot3";
            this.pbSlot3.Size = new System.Drawing.Size(122, 131);
            this.pbSlot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlot3.TabIndex = 2;
            this.pbSlot3.TabStop = false;
            // 
            // numCicluri
            // 
            this.numCicluri.AllowDrop = true;
            this.numCicluri.Location = new System.Drawing.Point(257, 265);
            this.numCicluri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numCicluri.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCicluri.Name = "numCicluri";
            this.numCicluri.Size = new System.Drawing.Size(8, 20);
            this.numCicluri.TabIndex = 3;
            this.numCicluri.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnTrage
            // 
            this.btnTrage.Location = new System.Drawing.Point(479, 208);
            this.btnTrage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrage.Name = "btnTrage";
            this.btnTrage.Size = new System.Drawing.Size(84, 131);
            this.btnTrage.TabIndex = 4;
            this.btnTrage.Text = "Trage!";
            this.btnTrage.UseVisualStyleBackColor = true;
            this.btnTrage.Click += new System.EventHandler(this.btnTrage_Click);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezultat.Location = new System.Drawing.Point(217, 259);
            this.lblRezultat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(36, 26);
            this.lblRezultat.TabIndex = 5;
            this.lblRezultat.Text = "---";
            // 
            // lblCredite
            // 
            this.lblCredite.AutoSize = true;
            this.lblCredite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredite.Location = new System.Drawing.Point(9, 20);
            this.lblCredite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCredite.Name = "lblCredite";
            this.lblCredite.Size = new System.Drawing.Size(122, 24);
            this.lblCredite.TabIndex = 6;
            this.lblCredite.Text = "Credite: 100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblCredite);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.btnTrage);
            this.Controls.Add(this.numCicluri);
            this.Controls.Add(this.pbSlot3);
            this.Controls.Add(this.pbSlot2);
            this.Controls.Add(this.pbSlot1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCicluri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSlot1;
        private System.Windows.Forms.PictureBox pbSlot2;
        private System.Windows.Forms.PictureBox pbSlot3;
        private System.Windows.Forms.NumericUpDown numCicluri;
        private System.Windows.Forms.Button btnTrage;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.Label lblCredite;
    }
}

