namespace EventStatusApp
{
    partial class EventStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventStatusForm));
            this.lbOverview = new System.Windows.Forms.ListBox();
            this.CHECK = new System.Windows.Forms.GroupBox();
            this.btnCamp = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnTotalVisitors = new System.Windows.Forms.Button();
            this.btnMoneySpent = new System.Windows.Forms.Button();
            this.btnCurrentStatus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.lb13 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.lb12 = new System.Windows.Forms.Label();
            this.CHECK.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOverview
            // 
            this.lbOverview.BackColor = System.Drawing.Color.White;
            this.lbOverview.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOverview.FormattingEnabled = true;
            this.lbOverview.ItemHeight = 21;
            this.lbOverview.Location = new System.Drawing.Point(292, 90);
            this.lbOverview.Name = "lbOverview";
            this.lbOverview.Size = new System.Drawing.Size(381, 340);
            this.lbOverview.TabIndex = 0;
            // 
            // CHECK
            // 
            this.CHECK.BackColor = System.Drawing.Color.White;
            this.CHECK.Controls.Add(this.btnCamp);
            this.CHECK.Controls.Add(this.btnBalance);
            this.CHECK.Controls.Add(this.btnTotalVisitors);
            this.CHECK.Controls.Add(this.btnMoneySpent);
            this.CHECK.Controls.Add(this.btnCurrentStatus);
            this.CHECK.Location = new System.Drawing.Point(10, 110);
            this.CHECK.Name = "CHECK";
            this.CHECK.Size = new System.Drawing.Size(265, 323);
            this.CHECK.TabIndex = 1;
            this.CHECK.TabStop = false;
            this.CHECK.Text = "CHECK";
            // 
            // btnCamp
            // 
            this.btnCamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnCamp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamp.Location = new System.Drawing.Point(60, 262);
            this.btnCamp.Name = "btnCamp";
            this.btnCamp.Size = new System.Drawing.Size(161, 56);
            this.btnCamp.TabIndex = 5;
            this.btnCamp.Text = "Camping Status";
            this.btnCamp.UseVisualStyleBackColor = false;
            this.btnCamp.Click += new System.EventHandler(this.btnCamp_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnBalance.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.Location = new System.Drawing.Point(60, 141);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(161, 56);
            this.btnBalance.TabIndex = 3;
            this.btnBalance.Text = "Total Balance of Visitors";
            this.btnBalance.UseVisualStyleBackColor = false;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnTotalVisitors
            // 
            this.btnTotalVisitors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnTotalVisitors.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTotalVisitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalVisitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalVisitors.Location = new System.Drawing.Point(60, 82);
            this.btnTotalVisitors.Name = "btnTotalVisitors";
            this.btnTotalVisitors.Size = new System.Drawing.Size(161, 56);
            this.btnTotalVisitors.TabIndex = 2;
            this.btnTotalVisitors.Text = "Total Visitors\r\n";
            this.btnTotalVisitors.UseVisualStyleBackColor = false;
            this.btnTotalVisitors.Click += new System.EventHandler(this.btnTotalVisitors_Click);
            // 
            // btnMoneySpent
            // 
            this.btnMoneySpent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnMoneySpent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMoneySpent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoneySpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoneySpent.Location = new System.Drawing.Point(60, 200);
            this.btnMoneySpent.Name = "btnMoneySpent";
            this.btnMoneySpent.Size = new System.Drawing.Size(161, 56);
            this.btnMoneySpent.TabIndex = 1;
            this.btnMoneySpent.Text = "Total Spent Money";
            this.btnMoneySpent.UseVisualStyleBackColor = false;
            this.btnMoneySpent.Click += new System.EventHandler(this.btnMoneySpent_Click);
            // 
            // btnCurrentStatus
            // 
            this.btnCurrentStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnCurrentStatus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCurrentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentStatus.Location = new System.Drawing.Point(60, 23);
            this.btnCurrentStatus.Name = "btnCurrentStatus";
            this.btnCurrentStatus.Size = new System.Drawing.Size(161, 56);
            this.btnCurrentStatus.TabIndex = 0;
            this.btnCurrentStatus.Text = "CurrentStatusOverall";
            this.btnCurrentStatus.UseVisualStyleBackColor = false;
            this.btnCurrentStatus.Click += new System.EventHandler(this.btnCurrentStatus_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 41);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(639, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Status Application";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbMap
            // 
            this.pbMap.Image = ((System.Drawing.Image)(resources.GetObject("pbMap.Image")));
            this.pbMap.Location = new System.Drawing.Point(281, 72);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(395, 393);
            this.pbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMap.TabIndex = 3;
            this.pbMap.TabStop = false;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.Color.Lime;
            this.lb2.Location = new System.Drawing.Point(502, 144);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(13, 13);
            this.lb2.TabIndex = 4;
            this.lb2.Text = "1";
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.BackColor = System.Drawing.Color.Lime;
            this.lb6.Location = new System.Drawing.Point(448, 164);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(13, 13);
            this.lb6.TabIndex = 5;
            this.lb6.Text = "5";
            // 
            // lb10
            // 
            this.lb10.AutoSize = true;
            this.lb10.BackColor = System.Drawing.Color.Lime;
            this.lb10.Location = new System.Drawing.Point(486, 192);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(13, 13);
            this.lb10.TabIndex = 6;
            this.lb10.Text = "9";
            // 
            // lb13
            // 
            this.lb13.AutoSize = true;
            this.lb13.BackColor = System.Drawing.Color.Lime;
            this.lb13.Location = new System.Drawing.Point(527, 192);
            this.lb13.Name = "lb13";
            this.lb13.Size = new System.Drawing.Size(19, 13);
            this.lb13.TabIndex = 7;
            this.lb13.Text = "12";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.BackColor = System.Drawing.Color.Lime;
            this.lb3.Location = new System.Drawing.Point(428, 214);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(13, 13);
            this.lb3.TabIndex = 8;
            this.lb3.Text = "2";
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.BackColor = System.Drawing.Color.Lime;
            this.lb7.Location = new System.Drawing.Point(463, 251);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(13, 13);
            this.lb7.TabIndex = 9;
            this.lb7.Text = "6";
            // 
            // lb9
            // 
            this.lb9.AutoSize = true;
            this.lb9.BackColor = System.Drawing.Color.Lime;
            this.lb9.Location = new System.Drawing.Point(514, 251);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(13, 13);
            this.lb9.TabIndex = 10;
            this.lb9.Text = "8";
            // 
            // lb11
            // 
            this.lb11.AutoSize = true;
            this.lb11.BackColor = System.Drawing.Color.Lime;
            this.lb11.Location = new System.Drawing.Point(400, 273);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(19, 13);
            this.lb11.TabIndex = 11;
            this.lb11.Text = "10";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.BackColor = System.Drawing.Color.Lime;
            this.lb4.Location = new System.Drawing.Point(457, 294);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(13, 13);
            this.lb4.TabIndex = 12;
            this.lb4.Text = "3";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.BackColor = System.Drawing.Color.Lime;
            this.lb5.Location = new System.Drawing.Point(514, 310);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(13, 13);
            this.lb5.TabIndex = 13;
            this.lb5.Text = "4";
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.BackColor = System.Drawing.Color.Lime;
            this.lb8.Location = new System.Drawing.Point(394, 332);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(13, 13);
            this.lb8.TabIndex = 14;
            this.lb8.Text = "7";
            // 
            // lb12
            // 
            this.lb12.AutoSize = true;
            this.lb12.BackColor = System.Drawing.Color.Lime;
            this.lb12.Location = new System.Drawing.Point(463, 353);
            this.lb12.Name = "lb12";
            this.lb12.Size = new System.Drawing.Size(19, 13);
            this.lb12.TabIndex = 15;
            this.lb12.Text = "11";
            // 
            // EventStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 467);
            this.Controls.Add(this.lb12);
            this.Controls.Add(this.lb8);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb11);
            this.Controls.Add(this.lb9);
            this.Controls.Add(this.lb7);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb13);
            this.Controls.Add(this.lb10);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.pbMap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CHECK);
            this.Controls.Add(this.lbOverview);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventStatusApplication";
            this.CHECK.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOverview;
        private System.Windows.Forms.GroupBox CHECK;
        private System.Windows.Forms.Button btnCamp;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnTotalVisitors;
        private System.Windows.Forms.Button btnMoneySpent;
        private System.Windows.Forms.Button btnCurrentStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label lb13;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb12;
        private System.Windows.Forms.Label lb4;
    }
}

