namespace CheckInOutCamping
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
            this.pbQr = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lbShow = new System.Windows.Forms.ListBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbQr)).BeginInit();
            this.SuspendLayout();
            // 
            // pbQr
            // 
            this.pbQr.BackColor = System.Drawing.SystemColors.Window;
            this.pbQr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbQr.Location = new System.Drawing.Point(50, 33);
            this.pbQr.Name = "pbQr";
            this.pbQr.Size = new System.Drawing.Size(214, 200);
            this.pbQr.TabIndex = 0;
            this.pbQr.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(81, 288);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(147, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "GenerateCode";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(66, 252);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(183, 20);
            this.tbCode.TabIndex = 2;
            // 
            // lbShow
            // 
            this.lbShow.FormattingEnabled = true;
            this.lbShow.Location = new System.Drawing.Point(360, 51);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(198, 160);
            this.lbShow.TabIndex = 3;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(375, 252);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(162, 20);
            this.tbInput.TabIndex = 4;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.Red;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(338, 288);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(107, 44);
            this.btnCheckIn.TabIndex = 5;
            this.btnCheckIn.Text = "Check-IN";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Blue;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(468, 288);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(104, 44);
            this.btnCheckOut.TabIndex = 6;
            this.btnCheckOut.Text = "Check-OUT";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(603, 343);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbShow);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.pbQr);
            this.Name = "Form1";
            this.Text = "Check-IN/OUT Camping App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQr;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.ListBox lbShow;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
    }
}

