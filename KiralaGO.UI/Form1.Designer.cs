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
            cbArabalar = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGunSayisi);
            groupBox1.Controls.Add(cbArabalar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(45, 32);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(377, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Araç Kiralama Bilgileri";
            // 
            // txtGunSayisi
            // 
            txtGunSayisi.Location = new Point(142, 105);
            txtGunSayisi.Name = "txtGunSayisi";
            txtGunSayisi.Size = new Size(189, 34);
            txtGunSayisi.TabIndex = 3;
            // 
            // cbArabalar
            // 
            cbArabalar.FormattingEnabled = true;
            cbArabalar.Location = new Point(142, 56);
            cbArabalar.Name = "cbArabalar";
            cbArabalar.Size = new Size(189, 36);
            cbArabalar.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 59);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 0;
            label2.Text = "Araba :";
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
            pictureBox1.Location = new Point(450, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(834, 555);
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
        private ComboBox cbArabalar;
        private Label label2;
        private Label label1;
        private TextBox txtGunSayisi;
        private PictureBox pictureBox1;
    }
}
