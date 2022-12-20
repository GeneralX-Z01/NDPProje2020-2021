namespace NDP_proje_
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zaman_label = new System.Windows.Forms.Label();
            this.islem_panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bilgiler_panel1 = new System.Windows.Forms.Panel();
            this.vitaminC_label5 = new System.Windows.Forms.Label();
            this.vitaminA_label4 = new System.Windows.Forms.Label();
            this.pure_agirlik_label3 = new System.Windows.Forms.Label();
            this.agirlik_label2 = new System.Windows.Forms.Label();
            this.isim_label1 = new System.Windows.Forms.Label();
            this.narenciye_button1 = new System.Windows.Forms.Button();
            this.kati_button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toplamPure_label8 = new System.Windows.Forms.Label();
            this.toplamA_label6 = new System.Windows.Forms.Label();
            this.toplamC_label7 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.basla_button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.islem_panel1.SuspendLayout();
            this.bilgiler_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zaman_label
            // 
            this.zaman_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zaman_label.Location = new System.Drawing.Point(520, 6);
            this.zaman_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zaman_label.Name = "zaman_label";
            this.zaman_label.Size = new System.Drawing.Size(121, 44);
            this.zaman_label.TabIndex = 0;
            this.zaman_label.Text = "01:00";
            // 
            // islem_panel1
            // 
            this.islem_panel1.Controls.Add(this.label4);
            this.islem_panel1.Controls.Add(this.bilgiler_panel1);
            this.islem_panel1.Controls.Add(this.narenciye_button1);
            this.islem_panel1.Controls.Add(this.kati_button1);
            this.islem_panel1.Controls.Add(this.pictureBox1);
            this.islem_panel1.Controls.Add(this.zaman_label);
            this.islem_panel1.Location = new System.Drawing.Point(8, 5);
            this.islem_panel1.Margin = new System.Windows.Forms.Padding(4);
            this.islem_panel1.Name = "islem_panel1";
            this.islem_panel1.Size = new System.Drawing.Size(653, 233);
            this.islem_panel1.TabIndex = 1;
            this.islem_panel1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(247, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zaman Sayaç  -";
            // 
            // bilgiler_panel1
            // 
            this.bilgiler_panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.bilgiler_panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bilgiler_panel1.Controls.Add(this.vitaminC_label5);
            this.bilgiler_panel1.Controls.Add(this.vitaminA_label4);
            this.bilgiler_panel1.Controls.Add(this.pure_agirlik_label3);
            this.bilgiler_panel1.Controls.Add(this.agirlik_label2);
            this.bilgiler_panel1.Controls.Add(this.isim_label1);
            this.bilgiler_panel1.Location = new System.Drawing.Point(247, 58);
            this.bilgiler_panel1.Margin = new System.Windows.Forms.Padding(4);
            this.bilgiler_panel1.Name = "bilgiler_panel1";
            this.bilgiler_panel1.Size = new System.Drawing.Size(260, 160);
            this.bilgiler_panel1.TabIndex = 3;
            // 
            // vitaminC_label5
            // 
            this.vitaminC_label5.AutoSize = true;
            this.vitaminC_label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vitaminC_label5.Location = new System.Drawing.Point(13, 127);
            this.vitaminC_label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vitaminC_label5.Name = "vitaminC_label5";
            this.vitaminC_label5.Size = new System.Drawing.Size(53, 20);
            this.vitaminC_label5.TabIndex = 4;
            this.vitaminC_label5.Text = "label5";
            // 
            // vitaminA_label4
            // 
            this.vitaminA_label4.AutoSize = true;
            this.vitaminA_label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vitaminA_label4.Location = new System.Drawing.Point(13, 100);
            this.vitaminA_label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vitaminA_label4.Name = "vitaminA_label4";
            this.vitaminA_label4.Size = new System.Drawing.Size(53, 20);
            this.vitaminA_label4.TabIndex = 3;
            this.vitaminA_label4.Text = "label4";
            // 
            // pure_agirlik_label3
            // 
            this.pure_agirlik_label3.AutoSize = true;
            this.pure_agirlik_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pure_agirlik_label3.Location = new System.Drawing.Point(12, 71);
            this.pure_agirlik_label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pure_agirlik_label3.Name = "pure_agirlik_label3";
            this.pure_agirlik_label3.Size = new System.Drawing.Size(53, 20);
            this.pure_agirlik_label3.TabIndex = 2;
            this.pure_agirlik_label3.Text = "label3";
            // 
            // agirlik_label2
            // 
            this.agirlik_label2.AutoSize = true;
            this.agirlik_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.agirlik_label2.Location = new System.Drawing.Point(12, 44);
            this.agirlik_label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agirlik_label2.Name = "agirlik_label2";
            this.agirlik_label2.Size = new System.Drawing.Size(53, 20);
            this.agirlik_label2.TabIndex = 1;
            this.agirlik_label2.Text = "label2";
            // 
            // isim_label1
            // 
            this.isim_label1.AutoSize = true;
            this.isim_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim_label1.Location = new System.Drawing.Point(12, 5);
            this.isim_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isim_label1.Name = "isim_label1";
            this.isim_label1.Size = new System.Drawing.Size(59, 20);
            this.isim_label1.TabIndex = 0;
            this.isim_label1.Text = "label1";
            // 
            // narenciye_button1
            // 
            this.narenciye_button1.BackColor = System.Drawing.Color.SandyBrown;
            this.narenciye_button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.narenciye_button1.Location = new System.Drawing.Point(516, 148);
            this.narenciye_button1.Margin = new System.Windows.Forms.Padding(0);
            this.narenciye_button1.Name = "narenciye_button1";
            this.narenciye_button1.Size = new System.Drawing.Size(125, 73);
            this.narenciye_button1.TabIndex = 0;
            this.narenciye_button1.Text = "Narenciye Sıkacağı";
            this.narenciye_button1.UseVisualStyleBackColor = false;
            this.narenciye_button1.Click += new System.EventHandler(this.narenciye_button1_Click);
            // 
            // kati_button1
            // 
            this.kati_button1.BackColor = System.Drawing.Color.SandyBrown;
            this.kati_button1.Location = new System.Drawing.Point(516, 59);
            this.kati_button1.Margin = new System.Windows.Forms.Padding(4);
            this.kati_button1.Name = "kati_button1";
            this.kati_button1.Size = new System.Drawing.Size(125, 74);
            this.kati_button1.TabIndex = 2;
            this.kati_button1.Text = "Katı Meyve Sıkacağı";
            this.kati_button1.UseVisualStyleBackColor = false;
            this.kati_button1.Click += new System.EventHandler(this.kati_button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 215);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // toplamPure_label8
            // 
            this.toplamPure_label8.AutoSize = true;
            this.toplamPure_label8.BackColor = System.Drawing.Color.Transparent;
            this.toplamPure_label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamPure_label8.Location = new System.Drawing.Point(33, 53);
            this.toplamPure_label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toplamPure_label8.Name = "toplamPure_label8";
            this.toplamPure_label8.Size = new System.Drawing.Size(56, 29);
            this.toplamPure_label8.TabIndex = 8;
            this.toplamPure_label8.Text = "0 gr";
            // 
            // toplamA_label6
            // 
            this.toplamA_label6.AutoSize = true;
            this.toplamA_label6.BackColor = System.Drawing.Color.Transparent;
            this.toplamA_label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamA_label6.Location = new System.Drawing.Point(25, 58);
            this.toplamA_label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toplamA_label6.Name = "toplamA_label6";
            this.toplamA_label6.Size = new System.Drawing.Size(54, 29);
            this.toplamA_label6.TabIndex = 6;
            this.toplamA_label6.Text = "0 iu";
            // 
            // toplamC_label7
            // 
            this.toplamC_label7.AutoSize = true;
            this.toplamC_label7.BackColor = System.Drawing.Color.Transparent;
            this.toplamC_label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamC_label7.Location = new System.Drawing.Point(24, 53);
            this.toplamC_label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toplamC_label7.Name = "toplamC_label7";
            this.toplamC_label7.Size = new System.Drawing.Size(70, 29);
            this.toplamC_label7.TabIndex = 7;
            this.toplamC_label7.Text = "0 mg";
            this.toplamC_label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpg");
            this.imageList1.Images.SetKeyName(1, "2.jpg");
            this.imageList1.Images.SetKeyName(2, "3.jpg");
            this.imageList1.Images.SetKeyName(3, "4.jpg");
            this.imageList1.Images.SetKeyName(4, "5.jpg");
            this.imageList1.Images.SetKeyName(5, "6.jpg");
            // 
            // basla_button1
            // 
            this.basla_button1.BackColor = System.Drawing.Color.SandyBrown;
            this.basla_button1.Location = new System.Drawing.Point(275, 177);
            this.basla_button1.Margin = new System.Windows.Forms.Padding(4);
            this.basla_button1.Name = "basla_button1";
            this.basla_button1.Size = new System.Drawing.Size(109, 47);
            this.basla_button1.TabIndex = 2;
            this.basla_button1.Text = "Başla";
            this.basla_button1.UseVisualStyleBackColor = false;
            this.basla_button1.Click += new System.EventHandler(this.basla_button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(8, 233);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 162);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PeachPuff;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.toplamA_label6);
            this.panel4.Location = new System.Drawing.Point(9, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 141);
            this.panel4.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vitamin A";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.toplamC_label7);
            this.panel3.Location = new System.Drawing.Point(233, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 141);
            this.panel3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vitamin C";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.toplamPure_label8);
            this.panel2.Location = new System.Drawing.Point(453, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 141);
            this.panel2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Püre/Sıvı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(669, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.islem_panel1);
            this.Controls.Add(this.basla_button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Meyve Sıkma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.islem_panel1.ResumeLayout(false);
            this.islem_panel1.PerformLayout();
            this.bilgiler_panel1.ResumeLayout(false);
            this.bilgiler_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label zaman_label;
        private System.Windows.Forms.Panel islem_panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button basla_button1;
        private System.Windows.Forms.Button narenciye_button1;
        private System.Windows.Forms.Button kati_button1;
        private System.Windows.Forms.Panel bilgiler_panel1;
        private System.Windows.Forms.Label agirlik_label2;
        private System.Windows.Forms.Label isim_label1;
        private System.Windows.Forms.Label vitaminC_label5;
        private System.Windows.Forms.Label vitaminA_label4;
        private System.Windows.Forms.Label pure_agirlik_label3;
        private System.Windows.Forms.Label toplamPure_label8;
        private System.Windows.Forms.Label toplamA_label6;
        private System.Windows.Forms.Label toplamC_label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

