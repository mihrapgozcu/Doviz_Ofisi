namespace Doviz_Ofisi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblDolarAlis = new Label();
            label2 = new Label();
            lblDolarSatis = new Label();
            label4 = new Label();
            lblEuroSatis = new Label();
            lblEuroAlis = new Label();
            label7 = new Label();
            label8 = new Label();
            btnDolarAlis = new Button();
            label9 = new Label();
            groupBox1 = new GroupBox();
            btnSatisYap = new Button();
            label12 = new Label();
            txtKalan = new TextBox();
            txtTutar = new TextBox();
            label11 = new Label();
            txtMiktar = new TextBox();
            label10 = new Label();
            txtKur = new TextBox();
            btnDolarSatis = new Button();
            btnEuroAlis = new Button();
            btnEuroSatis = new Button();
            btnSatisYap2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDolarAlis
            // 
            lblDolarAlis.AutoSize = true;
            lblDolarAlis.BackColor = Color.Transparent;
            lblDolarAlis.ForeColor = Color.White;
            lblDolarAlis.Location = new Point(292, 33);
            lblDolarAlis.Name = "lblDolarAlis";
            lblDolarAlis.Size = new Size(105, 24);
            lblDolarAlis.TabIndex = 0;
            lblDolarAlis.Text = "Dolar Alış:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(444, 33);
            label2.Name = "label2";
            label2.Size = new Size(22, 24);
            label2.TabIndex = 1;
            label2.Text = "0";
            // 
            // lblDolarSatis
            // 
            lblDolarSatis.AutoSize = true;
            lblDolarSatis.BackColor = Color.Transparent;
            lblDolarSatis.ForeColor = Color.White;
            lblDolarSatis.Location = new Point(292, 91);
            lblDolarSatis.Name = "lblDolarSatis";
            lblDolarSatis.Size = new Size(114, 24);
            lblDolarSatis.TabIndex = 2;
            lblDolarSatis.Text = "Dolar Satış:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(444, 91);
            label4.Name = "label4";
            label4.Size = new Size(22, 24);
            label4.TabIndex = 3;
            label4.Text = "0";
            // 
            // lblEuroSatis
            // 
            lblEuroSatis.AutoSize = true;
            lblEuroSatis.BackColor = Color.Transparent;
            lblEuroSatis.ForeColor = Color.White;
            lblEuroSatis.Location = new Point(292, 205);
            lblEuroSatis.Name = "lblEuroSatis";
            lblEuroSatis.Size = new Size(108, 24);
            lblEuroSatis.TabIndex = 4;
            lblEuroSatis.Text = "Euro Satış:";
            lblEuroSatis.Click += label5_Click;
            // 
            // lblEuroAlis
            // 
            lblEuroAlis.AutoSize = true;
            lblEuroAlis.BackColor = Color.Transparent;
            lblEuroAlis.ForeColor = Color.White;
            lblEuroAlis.Location = new Point(292, 152);
            lblEuroAlis.Name = "lblEuroAlis";
            lblEuroAlis.Size = new Size(99, 24);
            lblEuroAlis.TabIndex = 5;
            lblEuroAlis.Text = "Euro Alış:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.White;
            label7.Location = new Point(444, 147);
            label7.Name = "label7";
            label7.Size = new Size(22, 24);
            label7.TabIndex = 6;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.White;
            label8.Location = new Point(444, 203);
            label8.Name = "label8";
            label8.Size = new Size(22, 24);
            label8.TabIndex = 7;
            label8.Text = "0";
            // 
            // btnDolarAlis
            // 
            btnDolarAlis.Location = new Point(544, 28);
            btnDolarAlis.Name = "btnDolarAlis";
            btnDolarAlis.Size = new Size(40, 29);
            btnDolarAlis.TabIndex = 8;
            btnDolarAlis.Text = "...";
            btnDolarAlis.UseVisualStyleBackColor = true;
            btnDolarAlis.Click += btnDolarAlis_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 36);
            label9.Name = "label9";
            label9.Size = new Size(50, 24);
            label9.TabIndex = 9;
            label9.Text = "Kur:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnSatisYap2);
            groupBox1.Controls.Add(btnSatisYap);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtKalan);
            groupBox1.Controls.Add(txtTutar);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtMiktar);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtKur);
            groupBox1.Controls.Add(label9);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(488, 267);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 291);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // btnSatisYap
            // 
            btnSatisYap.ForeColor = Color.Black;
            btnSatisYap.Location = new Point(17, 236);
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Size = new Size(158, 37);
            btnSatisYap.TabIndex = 17;
            btnSatisYap.Text = "İşlem 1";
            btnSatisYap.UseVisualStyleBackColor = true;
            btnSatisYap.Click += btnSatisYap_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 173);
            label12.Name = "label12";
            label12.Size = new Size(68, 24);
            label12.TabIndex = 16;
            label12.Text = "Kalan:";
            // 
            // txtKalan
            // 
            txtKalan.Location = new Point(100, 170);
            txtKalan.Name = "txtKalan";
            txtKalan.Size = new Size(247, 30);
            txtKalan.TabIndex = 15;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(100, 125);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(247, 30);
            txtTutar.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 128);
            label11.Name = "label11";
            label11.Size = new Size(65, 24);
            label11.TabIndex = 13;
            label11.Text = "Tutar:";
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(100, 80);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(247, 30);
            txtMiktar.TabIndex = 12;
            txtMiktar.TextChanged += txtMiktar_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 80);
            label10.Name = "label10";
            label10.Size = new Size(77, 24);
            label10.TabIndex = 11;
            label10.Text = "Miktar:";
            // 
            // txtKur
            // 
            txtKur.Location = new Point(100, 39);
            txtKur.Name = "txtKur";
            txtKur.Size = new Size(247, 30);
            txtKur.TabIndex = 10;
            txtKur.TextChanged += txtKur_TextChanged;
            // 
            // btnDolarSatis
            // 
            btnDolarSatis.Location = new Point(544, 89);
            btnDolarSatis.Name = "btnDolarSatis";
            btnDolarSatis.Size = new Size(40, 29);
            btnDolarSatis.TabIndex = 11;
            btnDolarSatis.Text = "...";
            btnDolarSatis.UseVisualStyleBackColor = true;
            btnDolarSatis.Click += btnDolarSatis_Click;
            // 
            // btnEuroAlis
            // 
            btnEuroAlis.Location = new Point(544, 147);
            btnEuroAlis.Name = "btnEuroAlis";
            btnEuroAlis.Size = new Size(40, 29);
            btnEuroAlis.TabIndex = 12;
            btnEuroAlis.Text = "...";
            btnEuroAlis.UseVisualStyleBackColor = true;
            btnEuroAlis.Click += btnEuroAlis_Click;
            // 
            // btnEuroSatis
            // 
            btnEuroSatis.Location = new Point(544, 203);
            btnEuroSatis.Name = "btnEuroSatis";
            btnEuroSatis.Size = new Size(40, 29);
            btnEuroSatis.TabIndex = 13;
            btnEuroSatis.Text = "...";
            btnEuroSatis.UseVisualStyleBackColor = true;
            btnEuroSatis.Click += button4_Click;
            // 
            // btnSatisYap2
            // 
            btnSatisYap2.ForeColor = Color.Black;
            btnSatisYap2.Location = new Point(189, 236);
            btnSatisYap2.Name = "btnSatisYap2";
            btnSatisYap2.Size = new Size(158, 37);
            btnSatisYap2.TabIndex = 18;
            btnSatisYap2.Text = "İşlem 2";
            btnSatisYap2.UseVisualStyleBackColor = true;
            btnSatisYap2.Click += btnSatisYap2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(929, 680);
            Controls.Add(btnEuroSatis);
            Controls.Add(btnEuroAlis);
            Controls.Add(btnDolarSatis);
            Controls.Add(groupBox1);
            Controls.Add(btnDolarAlis);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblEuroAlis);
            Controls.Add(lblEuroSatis);
            Controls.Add(label4);
            Controls.Add(lblDolarSatis);
            Controls.Add(label2);
            Controls.Add(lblDolarAlis);
            DoubleBuffered = true;
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "DÖVİZ BÜROSU";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDolarAlis;
        private Label label2;
        private Label lblDolarSatis;
        private Label label4;
        private Label lblEuroSatis;
        private Label lblEuroAlis;
        private Label label7;
        private Label label8;
        private Button btnDolarAlis;
        private Label label9;
        private GroupBox groupBox1;
        private Label label11;
        private TextBox txtMiktar;
        private Label label10;
        private TextBox txtKur;
        private Button btnDolarSatis;
        private Button btnEuroAlis;
        private Button btnEuroSatis;
        private Button btnSatisYap;
        private Label label12;
        private TextBox txtKalan;
        private TextBox txtTutar;
        private Button btnSatisYap2;
    }
}
