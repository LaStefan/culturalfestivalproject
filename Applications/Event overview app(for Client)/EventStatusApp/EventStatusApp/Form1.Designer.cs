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
            this.lbOverview = new System.Windows.Forms.ListBox();
            this.CHECK = new System.Windows.Forms.GroupBox();
            this.btnCurrentStatus = new System.Windows.Forms.Button();
            this.btnMoneySpent = new System.Windows.Forms.Button();
            this.btnTotalVisitors = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnVisitor = new System.Windows.Forms.Button();
            this.btnCamp = new System.Windows.Forms.Button();
            this.CHECK.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOverview
            // 
            this.lbOverview.BackColor = System.Drawing.Color.SeaShell;
            this.lbOverview.FormattingEnabled = true;
            this.lbOverview.Location = new System.Drawing.Point(305, 12);
            this.lbOverview.Name = "lbOverview";
            this.lbOverview.Size = new System.Drawing.Size(279, 342);
            this.lbOverview.TabIndex = 0;
            // 
            // CHECK
            // 
            this.CHECK.BackColor = System.Drawing.SystemColors.Highlight;
            this.CHECK.Controls.Add(this.btnCamp);
            this.CHECK.Controls.Add(this.btnVisitor);
            this.CHECK.Controls.Add(this.btnBalance);
            this.CHECK.Controls.Add(this.btnTotalVisitors);
            this.CHECK.Controls.Add(this.btnMoneySpent);
            this.CHECK.Controls.Add(this.btnCurrentStatus);
            this.CHECK.Location = new System.Drawing.Point(13, 13);
            this.CHECK.Name = "CHECK";
            this.CHECK.Size = new System.Drawing.Size(286, 339);
            this.CHECK.TabIndex = 1;
            this.CHECK.TabStop = false;
            this.CHECK.Text = "CHECK";
            // 
            // btnCurrentStatus
            // 
            this.btnCurrentStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCurrentStatus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCurrentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentStatus.Location = new System.Drawing.Point(53, 64);
            this.btnCurrentStatus.Name = "btnCurrentStatus";
            this.btnCurrentStatus.Size = new System.Drawing.Size(161, 30);
            this.btnCurrentStatus.TabIndex = 0;
            this.btnCurrentStatus.Text = "CurrentStatusOverall";
            this.btnCurrentStatus.UseVisualStyleBackColor = false;
            // 
            // btnMoneySpent
            // 
            this.btnMoneySpent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMoneySpent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMoneySpent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoneySpent.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoneySpent.Location = new System.Drawing.Point(53, 170);
            this.btnMoneySpent.Name = "btnMoneySpent";
            this.btnMoneySpent.Size = new System.Drawing.Size(161, 30);
            this.btnMoneySpent.TabIndex = 1;
            this.btnMoneySpent.Text = "Total Spent Money";
            this.btnMoneySpent.UseVisualStyleBackColor = false;
            // 
            // btnTotalVisitors
            // 
            this.btnTotalVisitors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTotalVisitors.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTotalVisitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalVisitors.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalVisitors.Location = new System.Drawing.Point(53, 100);
            this.btnTotalVisitors.Name = "btnTotalVisitors";
            this.btnTotalVisitors.Size = new System.Drawing.Size(161, 28);
            this.btnTotalVisitors.TabIndex = 2;
            this.btnTotalVisitors.Text = "Total Visitors\r\n";
            this.btnTotalVisitors.UseVisualStyleBackColor = false;
            // 
            // btnBalance
            // 
            this.btnBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBalance.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalance.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.Location = new System.Drawing.Point(53, 134);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(161, 30);
            this.btnBalance.TabIndex = 3;
            this.btnBalance.Text = "Total Balance of Visitors";
            this.btnBalance.UseVisualStyleBackColor = false;
            // 
            // btnVisitor
            // 
            this.btnVisitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVisitor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVisitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitor.Location = new System.Drawing.Point(53, 206);
            this.btnVisitor.Name = "btnVisitor";
            this.btnVisitor.Size = new System.Drawing.Size(161, 30);
            this.btnVisitor.TabIndex = 4;
            this.btnVisitor.Text = "Visitor Status";
            this.btnVisitor.UseVisualStyleBackColor = false;
            // 
            // btnCamp
            // 
            this.btnCamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCamp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamp.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamp.Location = new System.Drawing.Point(53, 242);
            this.btnCamp.Name = "btnCamp";
            this.btnCamp.Size = new System.Drawing.Size(161, 29);
            this.btnCamp.TabIndex = 5;
            this.btnCamp.Text = "Camping Status";
            this.btnCamp.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(594, 364);
            this.Controls.Add(this.CHECK);
            this.Controls.Add(this.lbOverview);
            this.Name = "Form1";
            this.Text = "EventStatusApplication";
            this.CHECK.ResumeLayout(false);
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
    }
}

