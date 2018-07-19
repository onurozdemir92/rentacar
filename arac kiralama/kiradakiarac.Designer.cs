namespace arac_kiralama
{
    partial class kiradakiarac
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
            this.aracadi = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.aracresmi = new System.Windows.Forms.PictureBox();
            this.musadi = new System.Windows.Forms.Label();
            this.mustel = new System.Windows.Forms.Label();
            this.teslimt = new System.Windows.Forms.Label();
            this.teslims = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracresmi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.plaka);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 34);
            this.panel1.TabIndex = 1;
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
            // aracadi
            // 
            this.aracadi.AutoSize = true;
            this.aracadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracadi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aracadi.Location = new System.Drawing.Point(150, 9);
            this.aracadi.Name = "aracadi";
            this.aracadi.Size = new System.Drawing.Size(91, 24);
            this.aracadi.TabIndex = 2;
            this.aracadi.Text = "Fiat Linea";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 10);
            this.panel3.TabIndex = 3;
            // 
            // aracresmi
            // 
            this.aracresmi.Image = global::arac_kiralama.Properties.Resources.N;
            this.aracresmi.Location = new System.Drawing.Point(0, 0);
            this.aracresmi.Name = "aracresmi";
            this.aracresmi.Size = new System.Drawing.Size(144, 80);
            this.aracresmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aracresmi.TabIndex = 0;
            this.aracresmi.TabStop = false;
            // 
            // musadi
            // 
            this.musadi.AutoSize = true;
            this.musadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musadi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.musadi.Location = new System.Drawing.Point(151, 35);
            this.musadi.Name = "musadi";
            this.musadi.Size = new System.Drawing.Size(149, 18);
            this.musadi.TabIndex = 4;
            this.musadi.Text = "Onur Rahmi Ozdemir";
            // 
            // mustel
            // 
            this.mustel.AutoSize = true;
            this.mustel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mustel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mustel.Location = new System.Drawing.Point(151, 62);
            this.mustel.Name = "mustel";
            this.mustel.Size = new System.Drawing.Size(108, 18);
            this.mustel.TabIndex = 5;
            this.mustel.Text = "0546 465 45 43";
            // 
            // teslimt
            // 
            this.teslimt.AutoSize = true;
            this.teslimt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslimt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.teslimt.Location = new System.Drawing.Point(151, 97);
            this.teslimt.Name = "teslimt";
            this.teslimt.Size = new System.Drawing.Size(80, 18);
            this.teslimt.TabIndex = 6;
            this.teslimt.Text = "12.21.3243";
            // 
            // teslims
            // 
            this.teslims.AutoSize = true;
            this.teslims.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslims.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.teslims.Location = new System.Drawing.Point(241, 88);
            this.teslims.Name = "teslims";
            this.teslims.Size = new System.Drawing.Size(82, 31);
            this.teslims.TabIndex = 7;
            this.teslims.Text = "12:21";
            // 
            // kiradakiarac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.teslims);
            this.Controls.Add(this.teslimt);
            this.Controls.Add(this.mustel);
            this.Controls.Add(this.musadi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.aracadi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.aracresmi);
            this.Name = "kiradakiarac";
            this.Size = new System.Drawing.Size(320, 132);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracresmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox aracresmi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label plaka;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aracadi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label musadi;
        private System.Windows.Forms.Label mustel;
        private System.Windows.Forms.Label teslimt;
        private System.Windows.Forms.Label teslims;
    }
}
