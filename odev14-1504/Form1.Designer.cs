namespace odev14_1504
{
    partial class Form1
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
            this.bynode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsayi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntodeme = new System.Windows.Forms.Button();
            this.ratek = new System.Windows.Forms.RadioButton();
            this.ratakit1 = new System.Windows.Forms.RadioButton();
            this.ratasit2 = new System.Windows.Forms.RadioButton();
            this.ratasit3 = new System.Windows.Forms.RadioButton();
            this.ratasit4 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bynode
            // 
            this.bynode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bynode.Location = new System.Drawing.Point(32, 798);
            this.bynode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bynode.Name = "bynode";
            this.bynode.Size = new System.Drawing.Size(559, 73);
            this.bynode.TabIndex = 0;
            this.bynode.Text = "ödem yap";
            this.bynode.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "toplama tutar";
            // 
            // txtsayi
            // 
            this.txtsayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsayi.Location = new System.Drawing.Point(167, 9);
            this.txtsayi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtsayi.Name = "txtsayi";
            this.txtsayi.Size = new System.Drawing.Size(132, 29);
            this.txtsayi.TabIndex = 2;
            this.txtsayi.Text = "100";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ratasit4);
            this.groupBox1.Controls.Add(this.ratasit3);
            this.groupBox1.Controls.Add(this.ratasit2);
            this.groupBox1.Controls.Add(this.ratakit1);
            this.groupBox1.Controls.Add(this.ratek);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 383);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ödeme şekli";
            // 
            // bntodeme
            // 
            this.bntodeme.Location = new System.Drawing.Point(72, 425);
            this.bntodeme.Name = "bntodeme";
            this.bntodeme.Size = new System.Drawing.Size(296, 33);
            this.bntodeme.TabIndex = 4;
            this.bntodeme.Text = "ödeme yap";
            this.bntodeme.UseVisualStyleBackColor = true;
            this.bntodeme.Click += new System.EventHandler(this.button1_Click);
            // 
            // ratek
            // 
            this.ratek.AutoSize = true;
            this.ratek.Location = new System.Drawing.Point(6, 30);
            this.ratek.Name = "ratek";
            this.ratek.Size = new System.Drawing.Size(130, 29);
            this.ratek.TabIndex = 0;
            this.ratek.TabStop = true;
            this.ratek.Text = "tek çekim";
            this.ratek.UseVisualStyleBackColor = true;
            // 
            // ratakit1
            // 
            this.ratakit1.AutoSize = true;
            this.ratakit1.Location = new System.Drawing.Point(6, 65);
            this.ratakit1.Name = "ratakit1";
            this.ratakit1.Size = new System.Drawing.Size(253, 29);
            this.ratakit1.TabIndex = 1;
            this.ratakit1.TabStop = true;
            this.ratakit1.Text = "2taksit ( ½ 5 ek fiyat)";
            this.ratakit1.UseVisualStyleBackColor = true;
            // 
            // ratasit2
            // 
            this.ratasit2.AutoSize = true;
            this.ratasit2.Location = new System.Drawing.Point(6, 100);
            this.ratasit2.Name = "ratasit2";
            this.ratasit2.Size = new System.Drawing.Size(260, 29);
            this.ratasit2.TabIndex = 2;
            this.ratasit2.TabStop = true;
            this.ratasit2.Text = "3 taksit ( ½ 5 ek fiyat)";
            this.ratasit2.UseVisualStyleBackColor = true;
            // 
            // ratasit3
            // 
            this.ratasit3.AutoSize = true;
            this.ratasit3.Location = new System.Drawing.Point(6, 135);
            this.ratasit3.Name = "ratasit3";
            this.ratasit3.Size = new System.Drawing.Size(285, 29);
            this.ratasit3.TabIndex = 3;
            this.ratasit3.TabStop = true;
            this.ratasit3.Text = "4 tasksit ( ½ 10) ek fiyat";
            this.ratasit3.UseVisualStyleBackColor = true;
            this.ratasit3.CheckedChanged += new System.EventHandler(this.ratasit3_CheckedChanged);
            // 
            // ratasit4
            // 
            this.ratasit4.AutoSize = true;
            this.ratasit4.Location = new System.Drawing.Point(6, 170);
            this.ratasit4.Name = "ratasit4";
            this.ratasit4.Size = new System.Drawing.Size(273, 29);
            this.ratasit4.TabIndex = 4;
            this.ratasit4.TabStop = true;
            this.ratasit4.Text = "5 taksit ( ½ 10 ek fiyat)";
            this.ratasit4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 865);
            this.Controls.Add(this.bntodeme);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtsayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bynode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bynode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsayi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntodeme;
        private System.Windows.Forms.RadioButton ratasit4;
        private System.Windows.Forms.RadioButton ratasit3;
        private System.Windows.Forms.RadioButton ratasit2;
        private System.Windows.Forms.RadioButton ratakit1;
        private System.Windows.Forms.RadioButton ratek;
    }
}

