namespace Mouse_Uzerine_Gelince_Kayan_Button
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
            this.Btnyakala = new System.Windows.Forms.Button();
            this.LblAnlikpuan = new System.Windows.Forms.Label();
            this.Lblisim = new System.Windows.Forms.Label();
            this.Txbisimgir = new System.Windows.Forms.TextBox();
            this.Lblisimcikti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btnyakala
            // 
            this.Btnyakala.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btnyakala.Cursor = System.Windows.Forms.Cursors.No;
            this.Btnyakala.Location = new System.Drawing.Point(329, 137);
            this.Btnyakala.Name = "Btnyakala";
            this.Btnyakala.Size = new System.Drawing.Size(69, 68);
            this.Btnyakala.TabIndex = 0;
            this.Btnyakala.Text = "Yakala Beni";
            this.Btnyakala.UseVisualStyleBackColor = false;
            this.Btnyakala.Click += new System.EventHandler(this.Btnyakala_Click);
            this.Btnyakala.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btnyakala_MouseMove);
            // 
            // LblAnlikpuan
            // 
            this.LblAnlikpuan.AutoSize = true;
            this.LblAnlikpuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAnlikpuan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblAnlikpuan.Location = new System.Drawing.Point(547, 29);
            this.LblAnlikpuan.Name = "LblAnlikpuan";
            this.LblAnlikpuan.Size = new System.Drawing.Size(143, 13);
            this.LblAnlikpuan.TabIndex = 1;
            this.LblAnlikpuan.Text = "Anlık Toplam Puanınız 0";
            // 
            // Lblisim
            // 
            this.Lblisim.AutoSize = true;
            this.Lblisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblisim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lblisim.Location = new System.Drawing.Point(27, 29);
            this.Lblisim.Name = "Lblisim";
            this.Lblisim.Size = new System.Drawing.Size(134, 13);
            this.Lblisim.TabIndex = 2;
            this.Lblisim.Text = "Lütfen isminizi Giriniz :";
            // 
            // Txbisimgir
            // 
            this.Txbisimgir.Location = new System.Drawing.Point(165, 25);
            this.Txbisimgir.Name = "Txbisimgir";
            this.Txbisimgir.Size = new System.Drawing.Size(173, 20);
            this.Txbisimgir.TabIndex = 3;
            this.Txbisimgir.TextChanged += new System.EventHandler(this.Txbisimgir_TextChanged);
            // 
            // Lblisimcikti
            // 
            this.Lblisimcikti.AutoSize = true;
            this.Lblisimcikti.Font = new System.Drawing.Font("Ubuntu", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblisimcikti.ForeColor = System.Drawing.Color.Black;
            this.Lblisimcikti.Location = new System.Drawing.Point(24, 389);
            this.Lblisimcikti.Name = "Lblisimcikti";
            this.Lblisimcikti.Size = new System.Drawing.Size(29, 34);
            this.Lblisimcikti.TabIndex = 4;
            this.Lblisimcikti.Text = "..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(756, 461);
            this.Controls.Add(this.Lblisimcikti);
            this.Controls.Add(this.Txbisimgir);
            this.Controls.Add(this.Lblisim);
            this.Controls.Add(this.LblAnlikpuan);
            this.Controls.Add(this.Btnyakala);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnyakala;
        private System.Windows.Forms.Label LblAnlikpuan;
        private System.Windows.Forms.Label Lblisim;
        private System.Windows.Forms.TextBox Txbisimgir;
        private System.Windows.Forms.Label Lblisimcikti;
    }
}

