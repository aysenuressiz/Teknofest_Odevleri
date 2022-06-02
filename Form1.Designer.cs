namespace teknofest_ödevleri
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "TOPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "SONUÇ:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(27, 28);
            this.textBox1.MaxLength = 20;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 98);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(197, 28);
            this.textBox2.MaxLength = 6;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 98);
            this.textBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "BÖL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "ÇARP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(181, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "ÇIKAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(86, 359);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 30);
            this.button5.TabIndex = 7;
            this.button5.Text = "TEMİZLE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(165, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 34);
            this.label2.TabIndex = 8;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(27, 260);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(270, 32);
            this.button6.TabIndex = 9;
            this.button6.Text = "FAKTORİYEL HESAPLA";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(27, 308);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(270, 32);
            this.button7.TabIndex = 10;
            this.button7.Text = "İSTENEN FAKTORİYELİ HESAPLA";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(634, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "**faktoriyel için 1 numaralı kutuyu kullanınız.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(693, 36);
            this.label4.TabIndex = 12;
            this.label4.Text = "**istenen faktoriyel: faktoriyel hesaplarken 4 kullanılmadı( örn: 5! = 5*3*2*1).";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(51, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 34);
            this.label5.TabIndex = 13;
            this.label5.Text = "1.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(224, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 34);
            this.label6.TabIndex = 14;
            this.label6.Text = "2.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(400, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(188, 30);
            this.button8.TabIndex = 15;
            this.button8.Text = "TAHMİN ETMEYE BAŞLA";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(319, 217);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(129, 30);
            this.button9.TabIndex = 17;
            this.button9.Text = "KONTROL ET";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(454, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 130);
            this.label8.TabIndex = 18;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(332, 120);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 98);
            this.textBox3.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(324, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 44);
            this.label7.TabIndex = 20;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(358, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 34);
            this.label9.TabIndex = 21;
            this.label9.Text = "3.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 41);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(637, 152);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(83, 37);
            this.button10.TabIndex = 23;
            this.button10.Text = "başla";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(637, 192);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(83, 37);
            this.button11.TabIndex = 24;
            this.button11.Text = "dur";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(319, 263);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "SONUÇLAR";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(392, 247);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "SONUÇLAR";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(605, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 147);
            this.label10.TabIndex = 26;
            this.label10.Text = "Silgiyi çalıştırmak için \"başla\", durdurmak için \"dur\" butonuna basınız.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 553);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label10;
    }
}

