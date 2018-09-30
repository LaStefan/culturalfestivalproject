namespace ATM
{
    partial class Form1
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
            this.btnDeposit = new System.Windows.Forms.Button();
            this.tbAccNum = new System.Windows.Forms.TextBox();
            this.lbShow = new System.Windows.Forms.ListBox();
            this.lbAccNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnShowLog = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbQr = new System.Windows.Forms.PictureBox();
            this.btnCode = new System.Windows.Forms.Button();
            this.tbCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQr)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.White;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeposit.Location = new System.Drawing.Point(8, 78);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(139, 33);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbAccNum
            // 
            this.tbAccNum.BackColor = System.Drawing.SystemColors.Window;
            this.tbAccNum.Location = new System.Drawing.Point(102, 12);
            this.tbAccNum.Name = "tbAccNum";
            this.tbAccNum.Size = new System.Drawing.Size(139, 20);
            this.tbAccNum.TabIndex = 4;
            // 
            // lbShow
            // 
            this.lbShow.FormattingEnabled = true;
            this.lbShow.Location = new System.Drawing.Point(297, 12);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(246, 316);
            this.lbShow.TabIndex = 0;
            // 
            // lbAccNum
            // 
            this.lbAccNum.AutoSize = true;
            this.lbAccNum.Location = new System.Drawing.Point(9, 15);
            this.lbAccNum.Name = "lbAccNum";
            this.lbAccNum.Size = new System.Drawing.Size(90, 13);
            this.lbAccNum.TabIndex = 5;
            this.lbAccNum.Text = "Account Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 7;
            // 
            // btnShowLog
            // 
            this.btnShowLog.BackColor = System.Drawing.Color.White;
            this.btnShowLog.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowLog.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowLog.Location = new System.Drawing.Point(153, 78);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(139, 33);
            this.btnShowLog.TabIndex = 8;
            this.btnShowLog.Text = "Show Log";
            this.btnShowLog.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(224, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pbQr
            // 
            this.pbQr.BackColor = System.Drawing.SystemColors.Window;
            this.pbQr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbQr.Location = new System.Drawing.Point(54, 128);
            this.pbQr.Name = "pbQr";
            this.pbQr.Size = new System.Drawing.Size(173, 151);
            this.pbQr.TabIndex = 10;
            this.pbQr.TabStop = false;
            // 
            // btnCode
            // 
            this.btnCode.BackColor = System.Drawing.Color.White;
            this.btnCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCode.Location = new System.Drawing.Point(67, 313);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(142, 23);
            this.btnCode.TabIndex = 11;
            this.btnCode.Text = "GenerateCode";
            this.btnCode.UseVisualStyleBackColor = false;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(67, 287);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(142, 20);
            this.tbCode.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(555, 348);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.pbQr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowLog);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAccNum);
            this.Controls.Add(this.tbAccNum);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lbShow);
            this.Name = "Form1";
            this.Text = "ATMProBank";
            ((System.ComponentModel.ISupportInitialize)(this.pbQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox tbAccNum;
        private System.Windows.Forms.ListBox lbShow;
        private System.Windows.Forms.Label lbAccNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnShowLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbQr;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.TextBox tbCode;
    }
}

