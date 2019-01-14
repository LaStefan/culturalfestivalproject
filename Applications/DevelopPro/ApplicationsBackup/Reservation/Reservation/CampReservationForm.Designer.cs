namespace Reservation
{
    partial class CampReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampReservationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbShow = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.rb12 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb11 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb9 = new System.Windows.Forms.RadioButton();
            this.ckNight1 = new System.Windows.Forms.CheckBox();
            this.ckNight2 = new System.Windows.Forms.CheckBox();
            this.ckNight3 = new System.Windows.Forms.CheckBox();
            this.btClear = new System.Windows.Forms.Button();
            this.lbshowCus = new System.Windows.Forms.ListBox();
            this.btClear2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "The European Cultural Event\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(600, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "RFID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 34);
            this.panel1.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(869, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 22);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbShow
            // 
            this.lbShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShow.FormattingEnabled = true;
            this.lbShow.HorizontalScrollbar = true;
            this.lbShow.ItemHeight = 16;
            this.lbShow.Location = new System.Drawing.Point(284, 125);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(310, 260);
            this.lbShow.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 52);
            this.label3.TabIndex = 28;
            this.label3.Text = "Camping sites:\r\n- for 2 persons, 1-4, 10€\r\n- for 4 persons, 5-8, 15€\r\n-for 6 pers" +
    "ons, 9-12, 20€";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(296, 395);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(298, 38);
            this.btnPay.TabIndex = 29;
            this.btnPay.Text = "Make a reservation";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.BackColor = System.Drawing.Color.Lime;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(752, 125);
            this.rb1.Name = "rb1";
            this.rb1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb1.Size = new System.Drawing.Size(32, 17);
            this.rb1.TabIndex = 35;
            this.rb1.TabStop = true;
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = false;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.BackColor = System.Drawing.Color.Lime;
            this.rb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb5.Location = new System.Drawing.Point(703, 146);
            this.rb5.Name = "rb5";
            this.rb5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb5.Size = new System.Drawing.Size(32, 17);
            this.rb5.TabIndex = 36;
            this.rb5.TabStop = true;
            this.rb5.Text = "5";
            this.rb5.UseVisualStyleBackColor = false;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.BackColor = System.Drawing.Color.Lime;
            this.rb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.Location = new System.Drawing.Point(692, 198);
            this.rb2.Name = "rb2";
            this.rb2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb2.Size = new System.Drawing.Size(32, 17);
            this.rb2.TabIndex = 37;
            this.rb2.TabStop = true;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = false;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.BackColor = System.Drawing.Color.Lime;
            this.rb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb10.Location = new System.Drawing.Point(662, 245);
            this.rb10.Name = "rb10";
            this.rb10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb10.Size = new System.Drawing.Size(39, 17);
            this.rb10.TabIndex = 38;
            this.rb10.TabStop = true;
            this.rb10.Text = "10";
            this.rb10.UseVisualStyleBackColor = false;
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.BackColor = System.Drawing.Color.Lime;
            this.rb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb7.Location = new System.Drawing.Point(662, 309);
            this.rb7.Name = "rb7";
            this.rb7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb7.Size = new System.Drawing.Size(32, 17);
            this.rb7.TabIndex = 39;
            this.rb7.TabStop = true;
            this.rb7.Text = "7";
            this.rb7.UseVisualStyleBackColor = false;
            // 
            // rb12
            // 
            this.rb12.AutoSize = true;
            this.rb12.BackColor = System.Drawing.Color.Lime;
            this.rb12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb12.Location = new System.Drawing.Point(794, 172);
            this.rb12.Name = "rb12";
            this.rb12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb12.Size = new System.Drawing.Size(39, 17);
            this.rb12.TabIndex = 40;
            this.rb12.TabStop = true;
            this.rb12.Text = "12";
            this.rb12.UseVisualStyleBackColor = false;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.BackColor = System.Drawing.Color.Lime;
            this.rb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb8.Location = new System.Drawing.Point(781, 229);
            this.rb8.Name = "rb8";
            this.rb8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb8.Size = new System.Drawing.Size(32, 17);
            this.rb8.TabIndex = 41;
            this.rb8.TabStop = true;
            this.rb8.Text = "8";
            this.rb8.UseVisualStyleBackColor = false;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.BackColor = System.Drawing.Color.Lime;
            this.rb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb4.Location = new System.Drawing.Point(774, 282);
            this.rb4.Name = "rb4";
            this.rb4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb4.Size = new System.Drawing.Size(32, 17);
            this.rb4.TabIndex = 42;
            this.rb4.TabStop = true;
            this.rb4.Text = "4";
            this.rb4.UseVisualStyleBackColor = false;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.BackColor = System.Drawing.Color.Lime;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.Location = new System.Drawing.Point(718, 282);
            this.rb3.Name = "rb3";
            this.rb3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb3.Size = new System.Drawing.Size(32, 17);
            this.rb3.TabIndex = 43;
            this.rb3.TabStop = true;
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = false;
            // 
            // rb11
            // 
            this.rb11.AutoSize = true;
            this.rb11.BackColor = System.Drawing.Color.Lime;
            this.rb11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb11.Location = new System.Drawing.Point(725, 329);
            this.rb11.Name = "rb11";
            this.rb11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb11.Size = new System.Drawing.Size(39, 17);
            this.rb11.TabIndex = 44;
            this.rb11.TabStop = true;
            this.rb11.Text = "11";
            this.rb11.UseVisualStyleBackColor = false;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.BackColor = System.Drawing.Color.Lime;
            this.rb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb6.Location = new System.Drawing.Point(736, 229);
            this.rb6.Name = "rb6";
            this.rb6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb6.Size = new System.Drawing.Size(32, 17);
            this.rb6.TabIndex = 45;
            this.rb6.TabStop = true;
            this.rb6.Text = "6";
            this.rb6.UseVisualStyleBackColor = false;
            // 
            // rb9
            // 
            this.rb9.AutoSize = true;
            this.rb9.BackColor = System.Drawing.Color.Lime;
            this.rb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb9.Location = new System.Drawing.Point(749, 172);
            this.rb9.Name = "rb9";
            this.rb9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb9.Size = new System.Drawing.Size(32, 17);
            this.rb9.TabIndex = 46;
            this.rb9.TabStop = true;
            this.rb9.Text = "9";
            this.rb9.UseVisualStyleBackColor = false;
            // 
            // ckNight1
            // 
            this.ckNight1.AutoSize = true;
            this.ckNight1.Location = new System.Drawing.Point(455, 52);
            this.ckNight1.Name = "ckNight1";
            this.ckNight1.Size = new System.Drawing.Size(125, 17);
            this.ckNight1.TabIndex = 51;
            this.ckNight1.Text = "From 18/12 to 19/12";
            this.ckNight1.UseVisualStyleBackColor = true;
            // 
            // ckNight2
            // 
            this.ckNight2.AutoSize = true;
            this.ckNight2.Location = new System.Drawing.Point(454, 75);
            this.ckNight2.Name = "ckNight2";
            this.ckNight2.Size = new System.Drawing.Size(125, 17);
            this.ckNight2.TabIndex = 52;
            this.ckNight2.Text = "From 19/12 to 20/12";
            this.ckNight2.UseVisualStyleBackColor = true;
            // 
            // ckNight3
            // 
            this.ckNight3.AutoSize = true;
            this.ckNight3.Location = new System.Drawing.Point(454, 98);
            this.ckNight3.Name = "ckNight3";
            this.ckNight3.Size = new System.Drawing.Size(125, 17);
            this.ckNight3.TabIndex = 53;
            this.ckNight3.Text = "From 18/12 to 20/12";
            this.ckNight3.UseVisualStyleBackColor = true;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(543, 362);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(51, 23);
            this.btClear.TabIndex = 54;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // lbshowCus
            // 
            this.lbshowCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbshowCus.FormattingEnabled = true;
            this.lbshowCus.ItemHeight = 16;
            this.lbshowCus.Location = new System.Drawing.Point(12, 188);
            this.lbshowCus.Name = "lbshowCus";
            this.lbshowCus.Size = new System.Drawing.Size(263, 212);
            this.lbshowCus.TabIndex = 55;
            // 
            // btClear2
            // 
            this.btClear2.Location = new System.Drawing.Point(224, 377);
            this.btClear2.Name = "btClear2";
            this.btClear2.Size = new System.Drawing.Size(51, 23);
            this.btClear2.TabIndex = 56;
            this.btClear2.Text = "Clear";
            this.btClear2.UseVisualStyleBackColor = true;
            this.btClear2.Click += new System.EventHandler(this.btClear2_Click);
            // 
            // CampReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(899, 480);
            this.Controls.Add(this.btClear2);
            this.Controls.Add(this.lbshowCus);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.ckNight3);
            this.Controls.Add(this.ckNight2);
            this.Controls.Add(this.ckNight1);
            this.Controls.Add(this.rb9);
            this.Controls.Add(this.rb6);
            this.Controls.Add(this.rb11);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb4);
            this.Controls.Add(this.rb8);
            this.Controls.Add(this.rb12);
            this.Controls.Add(this.rb7);
            this.Controls.Add(this.rb10);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb5);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbShow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CampReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb12;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb11;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb9;
        private System.Windows.Forms.CheckBox ckNight1;
        private System.Windows.Forms.CheckBox ckNight2;
        private System.Windows.Forms.CheckBox ckNight3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ListBox lbshowCus;
        private System.Windows.Forms.Button btClear2;
    }
}

