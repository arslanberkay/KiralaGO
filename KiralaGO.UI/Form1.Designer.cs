namespace KiralaGO.UI
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
            groupBox1 = new GroupBox();
            txtGunSayisi = new TextBox();
            cbAraclar = new ComboBox();
            label2 = new Label();
            lblKiralikAracUcreti = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lstKiralikAracGecmisi = new ListBox();
            btnAracKirala = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGunSayisi);
            groupBox1.Controls.Add(cbAraclar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblKiralikAracUcreti);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 32);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(555, 206);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Araç Kiralama Bilgileri";
            // 
            // txtGunSayisi
            // 
            txtGunSayisi.Location = new Point(142, 105);
            txtGunSayisi.Name = "txtGunSayisi";
            txtGunSayisi.Size = new Size(398, 34);
            txtGunSayisi.TabIndex = 3;
            // 
            // cbAraclar
            // 
            cbAraclar.FormattingEnabled = true;
            cbAraclar.Location = new Point(142, 56);
            cbAraclar.Name = "cbAraclar";
            cbAraclar.Size = new Size(398, 36);
            cbAraclar.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 59);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 0;
            label2.Text = "Araç :";
            // 
            // lblKiralikAracUcreti
            // 
            lblKiralikAracUcreti.AutoSize = true;
            lblKiralikAracUcreti.Location = new Point(185, 151);
            lblKiralikAracUcreti.Name = "lblKiralikAracUcreti";
            lblKiralikAracUcreti.Size = new Size(0, 28);
            lblKiralikAracUcreti.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 151);
            label3.Name = "label3";
            label3.Size = new Size(154, 28);
            label3.TabIndex = 0;
            label3.Text = "Kiralama Ücreti :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 105);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 0;
            label1.Text = "Gün Sayısı :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(609, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lstKiralikAracGecmisi
            // 
            lstKiralikAracGecmisi.FormattingEnabled = true;
            lstKiralikAracGecmisi.ItemHeight = 28;
            lstKiralikAracGecmisi.Location = new Point(30, 318);
            lstKiralikAracGecmisi.Name = "lstKiralikAracGecmisi";
            lstKiralikAracGecmisi.Size = new Size(875, 172);
            lstKiralikAracGecmisi.TabIndex = 2;
            // 
            // btnAracKirala
            // 
            btnAracKirala.Location = new Point(717, 249);
            btnAracKirala.Name = "btnAracKirala";
            btnAracKirala.Size = new Size(188, 52);
            btnAracKirala.TabIndex = 3;
            btnAracKirala.Text = "Araç Kirala";
            btnAracKirala.UseVisualStyleBackColor = true;
            btnAracKirala.Click += btnAracKirala_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1030, 528);
            Controls.Add(btnAracKirala);
            Controls.Add(lstKiralikAracGecmisi);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbAraclar;
        private Label label2;
        private Label label1;
        private TextBox txtGunSayisi;
        private PictureBox pictureBox1;
        private ListBox lstKiralikAracGecmisi;
        private Button btnAracKirala;
        private Label lblKiralikAracUcreti;
        private Label label3;
    }
}
