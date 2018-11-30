namespace LoanApp
{
    partial class LoanAppForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanAppForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sideBar = new System.Windows.Forms.Panel();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelItem = new System.Windows.Forms.Panel();
            this.panelLoan = new System.Windows.Forms.Panel();
            this.productDataGV = new System.Windows.Forms.DataGridView();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbRFID = new System.Windows.Forms.Label();
            this.pbBlanckets = new System.Windows.Forms.PictureBox();
            this.pbBags = new System.Windows.Forms.PictureBox();
            this.pbFlashlight = new System.Windows.Forms.PictureBox();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.pbPhone = new System.Windows.Forms.PictureBox();
            this.pbUSB = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelItem.SuspendLayout();
            this.panelLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlanckets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlashlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUSB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.sideBar);
            this.panel1.Controls.Add(this.btnLoan);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 442);
            this.panel1.TabIndex = 0;
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.sideBar.Location = new System.Drawing.Point(6, 70);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(10, 45);
            this.sideBar.TabIndex = 4;
            // 
            // btnLoan
            // 
            this.btnLoan.FlatAppearance.BorderSize = 0;
            this.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.ForeColor = System.Drawing.Color.White;
            this.btnLoan.Location = new System.Drawing.Point(6, 291);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(113, 45);
            this.btnLoan.TabIndex = 2;
            this.btnLoan.Text = "Loan ";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(0, 184);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(119, 45);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse Item";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(6, 70);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(113, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(122, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 40);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(675, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(21, 26);
            this.button7.TabIndex = 1;
            this.button7.Text = "x";
            this.toolTip1.SetToolTip(this.button7, "Close");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "The European Cultural Event Loan Department ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Terms and conditions";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(732, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(368, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(228, 234);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 128);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(122, 410);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(702, 32);
            this.panel3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(556, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "All rights reserved......";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(623, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Available Items";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(657, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 150);
            this.label5.TabIndex = 10;
            this.label5.Text = ". Flashlight\r\n\r\n. USB Chargers\r\n\r\n. Sleeping bag\r\n\r\n. Telephone\r\n\r\n. Camera\r\n\r\n";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(122, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 0);
            this.panel4.TabIndex = 11;
            // 
            // panelItem
            // 
            this.panelItem.Controls.Add(this.panelLoan);
            this.panelItem.Controls.Add(this.pbBlanckets);
            this.panelItem.Controls.Add(this.pbBags);
            this.panelItem.Controls.Add(this.pbFlashlight);
            this.panelItem.Controls.Add(this.pbCamera);
            this.panelItem.Controls.Add(this.pbPhone);
            this.panelItem.Controls.Add(this.pbUSB);
            this.panelItem.Location = new System.Drawing.Point(122, 37);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(647, 377);
            this.panelItem.TabIndex = 12;
            this.panelItem.Visible = false;
            this.panelItem.Paint += new System.Windows.Forms.PaintEventHandler(this.panelItem_Paint);
            // 
            // panelLoan
            // 
            this.panelLoan.Controls.Add(this.productDataGV);
            this.panelLoan.Controls.Add(this.btnPayment);
            this.panelLoan.Controls.Add(this.btnClear);
            this.panelLoan.Controls.Add(this.btnExit);
            this.panelLoan.Controls.Add(this.btnRemove);
            this.panelLoan.Controls.Add(this.lbRFID);
            this.panelLoan.Location = new System.Drawing.Point(6, 0);
            this.panelLoan.Name = "panelLoan";
            this.panelLoan.Size = new System.Drawing.Size(696, 371);
            this.panelLoan.TabIndex = 6;
            this.panelLoan.Visible = false;
            // 
            // productDataGV
            // 
            this.productDataGV.BackgroundColor = System.Drawing.Color.White;
            this.productDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productQty,
            this.EndDate,
            this.productPrice});
            this.productDataGV.Location = new System.Drawing.Point(99, 27);
            this.productDataGV.Name = "productDataGV";
            this.productDataGV.Size = new System.Drawing.Size(564, 270);
            this.productDataGV.TabIndex = 18;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(532, 321);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(85, 35);
            this.btnPayment.TabIndex = 17;
            this.btnPayment.Text = "Scan";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(150, 321);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 35);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(66, 321);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 35);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(256, 321);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(77, 35);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "remove\r\n";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // lbRFID
            // 
            this.lbRFID.AutoSize = true;
            this.lbRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRFID.Location = new System.Drawing.Point(42, 28);
            this.lbRFID.Name = "lbRFID";
            this.lbRFID.Size = new System.Drawing.Size(51, 16);
            this.lbRFID.TabIndex = 12;
            this.lbRFID.Text = "RFID: ";
            this.lbRFID.Click += new System.EventHandler(this.lbRFID_Click);
            // 
            // pbBlanckets
            // 
            this.pbBlanckets.Image = ((System.Drawing.Image)(resources.GetObject("pbBlanckets.Image")));
            this.pbBlanckets.Location = new System.Drawing.Point(480, 197);
            this.pbBlanckets.Name = "pbBlanckets";
            this.pbBlanckets.Size = new System.Drawing.Size(210, 159);
            this.pbBlanckets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBlanckets.TabIndex = 5;
            this.pbBlanckets.TabStop = false;
            this.toolTip1.SetToolTip(this.pbBlanckets, "Blanket");
            // 
            // pbBags
            // 
            this.pbBags.Image = ((System.Drawing.Image)(resources.GetObject("pbBags.Image")));
            this.pbBags.Location = new System.Drawing.Point(480, 9);
            this.pbBags.Name = "pbBags";
            this.pbBags.Size = new System.Drawing.Size(210, 145);
            this.pbBags.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBags.TabIndex = 4;
            this.pbBags.TabStop = false;
            this.toolTip1.SetToolTip(this.pbBags, "Mattress");
            // 
            // pbFlashlight
            // 
            this.pbFlashlight.Image = ((System.Drawing.Image)(resources.GetObject("pbFlashlight.Image")));
            this.pbFlashlight.Location = new System.Drawing.Point(249, 9);
            this.pbFlashlight.Name = "pbFlashlight";
            this.pbFlashlight.Size = new System.Drawing.Size(208, 146);
            this.pbFlashlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFlashlight.TabIndex = 3;
            this.pbFlashlight.TabStop = false;
            this.toolTip1.SetToolTip(this.pbFlashlight, "Touch Light");
            // 
            // pbCamera
            // 
            this.pbCamera.Image = ((System.Drawing.Image)(resources.GetObject("pbCamera.Image")));
            this.pbCamera.Location = new System.Drawing.Point(24, 197);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(211, 159);
            this.pbCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCamera.TabIndex = 2;
            this.pbCamera.TabStop = false;
            this.toolTip1.SetToolTip(this.pbCamera, "Camera");
            // 
            // pbPhone
            // 
            this.pbPhone.Image = ((System.Drawing.Image)(resources.GetObject("pbPhone.Image")));
            this.pbPhone.Location = new System.Drawing.Point(249, 197);
            this.pbPhone.Name = "pbPhone";
            this.pbPhone.Size = new System.Drawing.Size(208, 159);
            this.pbPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhone.TabIndex = 1;
            this.pbPhone.TabStop = false;
            this.toolTip1.SetToolTip(this.pbPhone, "Mobile Phone");
            this.pbPhone.Click += new System.EventHandler(this.pbPhone_Click);
            // 
            // pbUSB
            // 
            this.pbUSB.Image = ((System.Drawing.Image)(resources.GetObject("pbUSB.Image")));
            this.pbUSB.Location = new System.Drawing.Point(24, 9);
            this.pbUSB.Name = "pbUSB";
            this.pbUSB.Size = new System.Drawing.Size(211, 145);
            this.pbUSB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUSB.TabIndex = 0;
            this.pbUSB.TabStop = false;
            this.toolTip1.SetToolTip(this.pbUSB, "Charger");
            // 
            // productID
            // 
            this.productID.HeaderText = "Prod ID";
            this.productID.Name = "productID";
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            // 
            // productQty
            // 
            this.productQty.HeaderText = "Start Date";
            this.productQty.Name = "productQty";
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Deposit";
            this.productPrice.Name = "productPrice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(824, 442);
            this.Controls.Add(this.panelItem);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelItem.ResumeLayout(false);
            this.panelLoan.ResumeLayout(false);
            this.panelLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlanckets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlashlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUSB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.PictureBox pbBags;
        private System.Windows.Forms.PictureBox pbFlashlight;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.PictureBox pbPhone;
        private System.Windows.Forms.PictureBox pbUSB;
        private System.Windows.Forms.PictureBox pbBlanckets;
        private System.Windows.Forms.Panel panelLoan;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView productDataGV;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lbRFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
    }
}

