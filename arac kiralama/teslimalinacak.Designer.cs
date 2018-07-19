namespace arac_kiralama
{
    partial class teslimalinacak
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.plaka = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.resim = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.teslims = new System.Windows.Forms.Label();
            this.aracadi = new System.Windows.Forms.Label();
            this.musadi = new System.Windows.Forms.Label();
            this.mustel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.plaka);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 34);
            this.panel1.TabIndex = 3;
            // 
            // plaka
            // 
            this.plaka.AutoSize = true;
            this.plaka.BackColor = System.Drawing.Color.White;
            this.plaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plaka.Location = new System.Drawing.Point(26, 6);
            this.plaka.Name = "plaka";
            this.plaka.Size = new System.Drawing.Size(118, 24);
            this.plaka.TabIndex = 1;
            this.plaka.Text = "57 ADF 123";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 32);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TR";
            // 
            // resim
            // 
            this.resim.Image = global::arac_kiralama.Properties.Resources.N;
            this.resim.Location = new System.Drawing.Point(1, 2);
            this.resim.Name = "resim";
            this.resim.Size = new System.Drawing.Size(144, 80);
            this.resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resim.TabIndex = 2;
            this.resim.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 10);
            this.panel3.TabIndex = 4;
            // 
            // teslims
            // 
            this.teslims.AutoSize = true;
            this.teslims.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslims.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.teslims.Location = new System.Drawing.Point(223, 83);
            this.teslims.Name = "teslims";
            this.teslims.Size = new System.Drawing.Size(101, 37);
            this.teslims.TabIndex = 5;
            this.teslims.Text = "13:33";
            // 
            // aracadi
            // 
            this.aracadi.AutoSize = true;
            this.aracadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracadi.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.aracadi.Location = new System.Drawing.Point(153, 5);
            this.aracadi.Name = "aracadi";
            this.aracadi.Size = new System.Drawing.Size(101, 24);
            this.aracadi.TabIndex = 6;
            this.aracadi.Text = "Fiat Linea";
            // 
            // musadi
            // 
            this.musadi.AutoSize = true;
            this.musadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musadi.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.musadi.Location = new System.Drawing.Point(151, 35);
            this.musadi.Name = "musadi";
            this.musadi.Size = new System.Drawing.Size(167, 18);
            this.musadi.TabIndex = 7;
            this.musadi.Text = "Onur Rahmi Ozdemir";
            // 
            // mustel
            // 
            this.mustel.AutoSize = true;
            this.mustel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mustel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.mustel.Location = new System.Drawing.Point(154, 62);
            this.mustel.Name = "mustel";
            this.mustel.Size = new System.Drawing.Size(122, 18);
            this.mustel.TabIndex = 8;
            this.mustel.Text = "0543 756 43 53";
            // 
            // teslimalinacak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.Controls.Add(this.mustel);
            this.Controls.Add(this.musadi);
            this.Controls.Add(this.aracadi);
            this.Controls.Add(this.teslims);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resim);
            this.Name = "teslimalinacak";
            this.Size = new System.Drawing.Size(323, 131);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label plaka;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox resim;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label teslims;
        private System.Windows.Forms.Label aracadi;
        private System.Windows.Forms.Label musadi;
        private System.Windows.Forms.Label mustel;
    }
}
