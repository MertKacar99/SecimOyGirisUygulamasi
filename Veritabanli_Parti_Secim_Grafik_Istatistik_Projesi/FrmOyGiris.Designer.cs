namespace Veritabanli_Parti_Secim_Grafik_Istatistik_Projesi
{
    partial class FrmOyGiris
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPartyA = new System.Windows.Forms.TextBox();
            this.txtPartyB = new System.Windows.Forms.TextBox();
            this.txtPartyC = new System.Windows.Forms.TextBox();
            this.txtPartyD = new System.Windows.Forms.TextBox();
            this.btnVote = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.graphic = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPartyE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLÇE AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "A PARTİ:";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(124, 22);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(381, 29);
            this.txtDistrict.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "B PARTİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "C PARTİ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "D PARTİ:";
            // 
            // txtPartyA
            // 
            this.txtPartyA.Location = new System.Drawing.Point(124, 76);
            this.txtPartyA.Name = "txtPartyA";
            this.txtPartyA.Size = new System.Drawing.Size(381, 29);
            this.txtPartyA.TabIndex = 1;
            // 
            // txtPartyB
            // 
            this.txtPartyB.Location = new System.Drawing.Point(124, 128);
            this.txtPartyB.Name = "txtPartyB";
            this.txtPartyB.Size = new System.Drawing.Size(381, 29);
            this.txtPartyB.TabIndex = 1;
            // 
            // txtPartyC
            // 
            this.txtPartyC.Location = new System.Drawing.Point(124, 174);
            this.txtPartyC.Name = "txtPartyC";
            this.txtPartyC.Size = new System.Drawing.Size(381, 29);
            this.txtPartyC.TabIndex = 1;
            // 
            // txtPartyD
            // 
            this.txtPartyD.Location = new System.Drawing.Point(124, 215);
            this.txtPartyD.Name = "txtPartyD";
            this.txtPartyD.Size = new System.Drawing.Size(381, 29);
            this.txtPartyD.TabIndex = 1;
            // 
            // btnVote
            // 
            this.btnVote.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVote.ForeColor = System.Drawing.Color.IndianRed;
            this.btnVote.Location = new System.Drawing.Point(124, 335);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(381, 44);
            this.btnVote.TabIndex = 2;
            this.btnVote.Text = "Oy Girişi Yap";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStatistics.ForeColor = System.Drawing.Color.IndianRed;
            this.btnStatistics.Location = new System.Drawing.Point(320, 385);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(185, 44);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Çıkış Yap";
            this.btnStatistics.UseVisualStyleBackColor = true;
            // 
            // graphic
            // 
            this.graphic.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.graphic.ForeColor = System.Drawing.Color.IndianRed;
            this.graphic.Location = new System.Drawing.Point(124, 385);
            this.graphic.Name = "graphic";
            this.graphic.Size = new System.Drawing.Size(190, 44);
            this.graphic.TabIndex = 2;
            this.graphic.Text = "GRAFİKLER";
            this.graphic.UseVisualStyleBackColor = true;
            this.graphic.Click += new System.EventHandler(this.graphic_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "E PARTİ:";
            // 
            // txtPartyE
            // 
            this.txtPartyE.Location = new System.Drawing.Point(124, 250);
            this.txtPartyE.Name = "txtPartyE";
            this.txtPartyE.Size = new System.Drawing.Size(381, 29);
            this.txtPartyE.TabIndex = 1;
            // 
            // FrmOyGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(671, 727);
            this.Controls.Add(this.graphic);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.txtPartyE);
            this.Controls.Add(this.txtPartyD);
            this.Controls.Add(this.txtPartyC);
            this.Controls.Add(this.txtPartyB);
            this.Controls.Add(this.txtPartyA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDistrict);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOyGiris";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmOyGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPartyA;
        private System.Windows.Forms.TextBox txtPartyB;
        private System.Windows.Forms.TextBox txtPartyC;
        private System.Windows.Forms.TextBox txtPartyD;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button graphic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPartyE;
    }
}

