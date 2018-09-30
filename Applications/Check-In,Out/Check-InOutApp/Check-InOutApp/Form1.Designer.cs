namespace Check_InOutApp
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
            this.lbPersons = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnIN = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnCode = new System.Windows.Forms.Button();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.pbQr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQr)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPersons
            // 
            this.lbPersons.FormattingEnabled = true;
            this.lbPersons.Location = new System.Drawing.Point(330, 45);
            this.lbPersons.Name = "lbPersons";
            this.lbPersons.Size = new System.Drawing.Size(179, 147);
            this.lbPersons.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(277, 278);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 20);
            this.textBox2.TabIndex = 2;
            // 
            // btnIN
            // 
            this.btnIN.BackColor = System.Drawing.Color.Red;
            this.btnIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIN.Location = new System.Drawing.Point(277, 304);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(122, 37);
            this.btnIN.TabIndex = 3;
            this.btnIN.Text = "Check-IN";
            this.btnIN.UseVisualStyleBackColor = false;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.Blue;
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(405, 304);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(122, 37);
            this.btnOut.TabIndex = 4;
            this.btnOut.Text = "Check-OUT";
            this.btnOut.UseVisualStyleBackColor = false;
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(78, 304);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(155, 27);
            this.btnCode.TabIndex = 7;
            this.btnCode.Text = "GenerateCode";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(50, 278);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(202, 20);
            this.tbCode.TabIndex = 8;
            // 
            // pbQr
            // 
            this.pbQr.BackColor = System.Drawing.SystemColors.Window;
            this.pbQr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbQr.Location = new System.Drawing.Point(55, 35);
            this.pbQr.Name = "pbQr";
            this.pbQr.Size = new System.Drawing.Size(197, 192);
            this.pbQr.TabIndex = 9;
            this.pbQr.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(539, 353);
            this.Controls.Add(this.pbQr);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbPersons);
            this.Name = "Form1";
            this.Text = "Check-IN/OUT Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.pbQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPersons;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.PictureBox pbQr;
    }
}

