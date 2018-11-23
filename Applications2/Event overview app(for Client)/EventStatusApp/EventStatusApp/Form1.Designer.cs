namespace EventStatusApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbOverview = new System.Windows.Forms.ListBox();
            this.CHECK = new System.Windows.Forms.GroupBox();
            this.btnCamp = new System.Windows.Forms.Button();
            this.btnVisitor = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnTotalVisitors = new System.Windows.Forms.Button();
            this.btnMoneySpent = new System.Windows.Forms.Button();
            this.btnCurrentStatus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CHECK.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOverview
            // 
            this.lbOverview.BackColor = System.Drawing.Color.White;
            this.lbOverview.FormattingEnabled = true;
            this.lbOverview.Location = new System.Drawing.Point(292, 90);
            this.lbOverview.Name = "lbOverview";
            this.lbOverview.Size = new System.Drawing.Size(381, 368);
            this.lbOverview.TabIndex = 0;
            // 
            // CHECK
            // 
            this.CHECK.BackColor = System.Drawing.Color.White;
            this.CHECK.Controls.Add(this.btnCamp);
            this.CHECK.Controls.Add(this.btnVisitor);
            this.CHECK.Controls.Add(this.btnBalance);
            this.CHECK.Controls.Add(this.btnTotalVisitors);
            this.CHECK.Controls.Add(this.btnMoneySpent);
            this.CHECK.Controls.Add(this.btnCurrentStatus);
            this.CHECK.Location = new System.Drawing.Point(12, 72);
            this.CHECK.Name = "CHECK";
            this.CHECK.Size = new System.Drawing.Size(274, 386);
            this.CHECK.TabIndex = 1;
            this.CHECK.TabStop = false;
            this.CHECK.Text = "CHECK";
            // 
            // btnCamp
            // 
            this.btnCamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnCamp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamp.Location = new System.Drawing.Point(60, 318);
            this.btnCamp.Name = "btnCamp";
            this.btnCamp.Size = new System.Drawing.Size(161, 56);
            this.btnCamp.TabIndex = 5;
            this.btnCamp.Text = "Camping Status";
            this.btnCamp.UseVisualStyleBackColor = false;
            // 
            // btnVisitor
            // 
            this.btnVisitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnVisitor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitor.Location = new System.Drawing.Point(60, 259);
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Size = new System.Drawing.Size(161, 56);
            this.btnVisitor.TabIndex = 4;
            this.btnVisitor.Text = "Visitor Status";
            this.btnVisitor.UseVisualStyleBackColor = false;
            // 
            // btnBalance
            // 
            this.btnBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnBalance.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.Location = new System.Drawing.Point(60, 141);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(161, 56);
            this.btnBalance.TabIndex = 3;
            this.btnBalance.Text = "Total Balance of Visitors";
            this.btnBalance.UseVisualStyleBackColor = false;
            // 
            // btnTotalVisitors
            // 
            this.btnTotalVisitors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnTotalVisitors.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTotalVisitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalVisitors.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalVisitors.Location = new System.Drawing.Point(60, 82);
            this.btnTotalVisitors.Name = "btnTotalVisitors";
            this.btnTotalVisitors.Size = new System.Drawing.Size(161, 56);
            this.btnTotalVisitors.TabIndex = 2;
            this.btnTotalVisitors.Text = "Total Visitors\r\n";
            this.btnTotalVisitors.UseVisualStyleBackColor = false;
            // 
            // btnMoneySpent
            // 
            this.btnMoneySpent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnMoneySpent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMoneySpent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoneySpent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoneySpent.Location = new System.Drawing.Point(60, 200);
            this.btnMoneySpent.Name = "btnMoneySpent";
            this.btnMoneySpent.Size = new System.Drawing.Size(161, 56);
            this.btnMoneySpent.TabIndex = 1;
            this.btnMoneySpent.Text = "Total Spent Money";
            this.btnMoneySpent.UseVisualStyleBackColor = false;
            // 
            // btnCurrentStatus
            // 
            this.btnCurrentStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnCurrentStatus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCurrentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentStatus.Location = new System.Drawing.Point(60, 23);
            this.btnCurrentStatus.Name = "btnCurrentStatus";
            this.btnCurrentStatus.Size = new System.Drawing.Size(161, 56);
            this.btnCurrentStatus.TabIndex = 0;
            this.btnCurrentStatus.Text = "CurrentStatusOverall";
            this.btnCurrentStatus.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 41);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(581, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Status Application";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CHECK);
            this.Controls.Add(this.lbOverview);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventStatusApplication";
            this.CHECK.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbOverview;
        private System.Windows.Forms.GroupBox CHECK;
        private System.Windows.Forms.Button btnCamp;
        private System.Windows.Forms.Button btnVisitor;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnTotalVisitors;
        private System.Windows.Forms.Button btnMoneySpent;
        private System.Windows.Forms.Button btnCurrentStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

