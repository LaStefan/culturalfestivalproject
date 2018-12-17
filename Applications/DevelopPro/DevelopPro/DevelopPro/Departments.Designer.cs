namespace DevelopPro
{
    partial class Departments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLogin = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.assignRFID = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkInOut = new System.Windows.Forms.Button();
            this.campingReserve = new System.Windows.Forms.Button();
            this.campingInOut = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.eventStatus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.lbLogin);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 59);
            this.panel1.TabIndex = 7;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbLogin.Location = new System.Drawing.Point(264, 15);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(261, 108);
            this.lbLogin.TabIndex = 3;
            this.lbLogin.Text = "Please select a department\r\n\r\n\r\n\r\n";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(748, 13);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 33);
            this.button7.TabIndex = 2;
            this.button7.Text = "x";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // assignRFID
            // 
            this.assignRFID.Location = new System.Drawing.Point(68, 87);
            this.assignRFID.Name = "assignRFID";
            this.assignRFID.Size = new System.Drawing.Size(155, 80);
            this.assignRFID.TabIndex = 9;
            this.assignRFID.Text = "AssignRFID";
            this.assignRFID.UseVisualStyleBackColor = true;
            // 
            // btnLoan
            // 
            this.btnLoan.Location = new System.Drawing.Point(578, 87);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(155, 80);
            this.btnLoan.TabIndex = 10;
            this.btnLoan.Text = "Loan\r\n";
            this.btnLoan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 80);
            this.button1.TabIndex = 11;
            this.button1.Text = "Shop ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkInOut
            // 
            this.checkInOut.Location = new System.Drawing.Point(68, 200);
            this.checkInOut.Name = "checkInOut";
            this.checkInOut.Size = new System.Drawing.Size(155, 80);
            this.checkInOut.TabIndex = 12;
            this.checkInOut.Text = "Check In/Out";
            this.checkInOut.UseVisualStyleBackColor = true;
            // 
            // campingReserve
            // 
            this.campingReserve.Location = new System.Drawing.Point(68, 430);
            this.campingReserve.Name = "campingReserve";
            this.campingReserve.Size = new System.Drawing.Size(155, 80);
            this.campingReserve.TabIndex = 13;
            this.campingReserve.Text = "Camping Reservation";
            this.campingReserve.UseVisualStyleBackColor = true;
            // 
            // campingInOut
            // 
            this.campingInOut.Location = new System.Drawing.Point(68, 315);
            this.campingInOut.Name = "campingInOut";
            this.campingInOut.Size = new System.Drawing.Size(155, 80);
            this.campingInOut.TabIndex = 14;
            this.campingInOut.Text = "Camping Check In/Out";
            this.campingInOut.UseVisualStyleBackColor = true;
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(578, 315);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(155, 80);
            this.log.TabIndex = 15;
            this.log.Text = "Log";
            this.log.UseVisualStyleBackColor = true;
            // 
            // eventStatus
            // 
            this.eventStatus.Location = new System.Drawing.Point(578, 430);
            this.eventStatus.Name = "eventStatus";
            this.eventStatus.Size = new System.Drawing.Size(155, 80);
            this.eventStatus.TabIndex = 16;
            this.eventStatus.Text = "Event Status";
            this.eventStatus.UseVisualStyleBackColor = true;
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.eventStatus);
            this.Controls.Add(this.log);
            this.Controls.Add(this.campingInOut);
            this.Controls.Add(this.campingReserve);
            this.Controls.Add(this.checkInOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLoan);
            this.Controls.Add(this.assignRFID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Departments";
            this.Text = "Departments";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button assignRFID;
        public System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button checkInOut;
        private System.Windows.Forms.Button campingReserve;
        private System.Windows.Forms.Button campingInOut;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button eventStatus;
    }
}