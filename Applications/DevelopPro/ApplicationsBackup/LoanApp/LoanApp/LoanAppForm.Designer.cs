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
            this.button2 = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.Panel();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelItem = new System.Windows.Forms.Panel();
            this.pbBlanckets = new System.Windows.Forms.PictureBox();
            this.pbBags = new System.Windows.Forms.PictureBox();
            this.pbFlashlight = new System.Windows.Forms.PictureBox();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.pbPhone = new System.Windows.Forms.PictureBox();
            this.pbUSB = new System.Windows.Forms.PictureBox();
            this.panelReturn = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnRefund = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelLoan = new System.Windows.Forms.Panel();
            this.panelInventory = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnChekout = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.productDataGV = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbRFID = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.prodId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlanckets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlashlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUSB)).BeginInit();
            this.panelReturn.SuspendLayout();
            this.panelLoan.SuspendLayout();
            this.panelInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.sideBar);
            this.panel1.Controls.Add(this.btnLoan);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 544);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 418);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "Inventory Replenishment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(12, 322);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(151, 55);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return Item";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.sideBar.Location = new System.Drawing.Point(8, 80);
            this.sideBar.Margin = new System.Windows.Forms.Padding(4);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(13, 55);
            this.sideBar.TabIndex = 4;
            // 
            // btnLoan
            // 
            this.btnLoan.FlatAppearance.BorderSize = 0;
            this.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoan.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.ForeColor = System.Drawing.Color.White;
            this.btnLoan.Location = new System.Drawing.Point(12, 246);
            this.btnLoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(151, 55);
            this.btnLoan.TabIndex = 2;
            this.btnLoan.Text = "Loan ";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(4, 162);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(159, 55);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse Item";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(12, 80);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(151, 55);
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
            this.panel2.Location = new System.Drawing.Point(163, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 49);
            this.panel2.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(900, 4);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 32);
            this.button7.TabIndex = 1;
            this.button7.Text = "x";
            this.toolTip1.SetToolTip(this.button7, "Close");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "The European Cultural Festival - Loan Department \r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Terms and conditions";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(473, 111);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 330);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 209);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(876, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Available Items";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(876, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 190);
            this.label5.TabIndex = 10;
            this.label5.Text = "• Flashlight\r\n\r\n• USB Chargers\r\n\r\n• Sleeping bag\r\n\r\n• Telephone\r\n\r\n• Camera\r\n\r\n";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(183, 49);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 0);
            this.panel4.TabIndex = 11;
            // 
            // panelItem
            // 
            this.panelItem.Controls.Add(this.panelReturn);
            this.panelItem.Controls.Add(this.pbBlanckets);
            this.panelItem.Controls.Add(this.pbBags);
            this.panelItem.Controls.Add(this.pbFlashlight);
            this.panelItem.Controls.Add(this.pbCamera);
            this.panelItem.Controls.Add(this.pbPhone);
            this.panelItem.Controls.Add(this.pbUSB);
            this.panelItem.Location = new System.Drawing.Point(171, 80);
            this.panelItem.Margin = new System.Windows.Forms.Padding(4);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(884, 449);
            this.panelItem.TabIndex = 12;
            this.panelItem.Visible = false;
            // 
            // pbBlanckets
            // 
            this.pbBlanckets.Image = ((System.Drawing.Image)(resources.GetObject("pbBlanckets.Image")));
            this.pbBlanckets.Location = new System.Drawing.Point(640, 242);
            this.pbBlanckets.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlanckets.Name = "pbBlanckets";
            this.pbBlanckets.Size = new System.Drawing.Size(280, 196);
            this.pbBlanckets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBlanckets.TabIndex = 5;
            this.pbBlanckets.TabStop = false;
            this.toolTip1.SetToolTip(this.pbBlanckets, "Blanket");
            this.pbBlanckets.Click += new System.EventHandler(this.pbBlanckets_Click);
            // 
            // pbBags
            // 
            this.pbBags.Image = ((System.Drawing.Image)(resources.GetObject("pbBags.Image")));
            this.pbBags.Location = new System.Drawing.Point(640, 11);
            this.pbBags.Margin = new System.Windows.Forms.Padding(4);
            this.pbBags.Name = "pbBags";
            this.pbBags.Size = new System.Drawing.Size(280, 178);
            this.pbBags.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBags.TabIndex = 4;
            this.pbBags.TabStop = false;
            this.toolTip1.SetToolTip(this.pbBags, "Mattress");
            this.pbBags.Click += new System.EventHandler(this.pbBags_Click);
            // 
            // pbFlashlight
            // 
            this.pbFlashlight.Image = ((System.Drawing.Image)(resources.GetObject("pbFlashlight.Image")));
            this.pbFlashlight.Location = new System.Drawing.Point(332, 11);
            this.pbFlashlight.Margin = new System.Windows.Forms.Padding(4);
            this.pbFlashlight.Name = "pbFlashlight";
            this.pbFlashlight.Size = new System.Drawing.Size(277, 180);
            this.pbFlashlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFlashlight.TabIndex = 3;
            this.pbFlashlight.TabStop = false;
            this.toolTip1.SetToolTip(this.pbFlashlight, "Touch Light");
            this.pbFlashlight.Click += new System.EventHandler(this.pbFlashlight_Click);
            // 
            // pbCamera
            // 
            this.pbCamera.Image = ((System.Drawing.Image)(resources.GetObject("pbCamera.Image")));
            this.pbCamera.Location = new System.Drawing.Point(32, 242);
            this.pbCamera.Margin = new System.Windows.Forms.Padding(4);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(281, 196);
            this.pbCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCamera.TabIndex = 2;
            this.pbCamera.TabStop = false;
            this.toolTip1.SetToolTip(this.pbCamera, "Camera");
            this.pbCamera.Click += new System.EventHandler(this.pbCamera_Click);
            // 
            // pbPhone
            // 
            this.pbPhone.Image = ((System.Drawing.Image)(resources.GetObject("pbPhone.Image")));
            this.pbPhone.Location = new System.Drawing.Point(332, 242);
            this.pbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.pbPhone.Name = "pbPhone";
            this.pbPhone.Size = new System.Drawing.Size(277, 196);
            this.pbPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhone.TabIndex = 1;
            this.pbPhone.TabStop = false;
            this.toolTip1.SetToolTip(this.pbPhone, "Mobile Phone");
            this.pbPhone.Click += new System.EventHandler(this.pbPhone_Click);
            // 
            // pbUSB
            // 
            this.pbUSB.Image = ((System.Drawing.Image)(resources.GetObject("pbUSB.Image")));
            this.pbUSB.Location = new System.Drawing.Point(32, 11);
            this.pbUSB.Margin = new System.Windows.Forms.Padding(4);
            this.pbUSB.Name = "pbUSB";
            this.pbUSB.Size = new System.Drawing.Size(281, 178);
            this.pbUSB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUSB.TabIndex = 0;
            this.pbUSB.TabStop = false;
            this.toolTip1.SetToolTip(this.pbUSB, "Charger");
            this.pbUSB.Click += new System.EventHandler(this.pbUSB_Click);
            // 
            // panelReturn
            // 
            this.panelReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReturn.Controls.Add(this.listView1);
            this.panelReturn.Controls.Add(this.btnCheck);
            this.panelReturn.Controls.Add(this.btnRefund);
            this.panelReturn.Controls.Add(this.listBox1);
            this.panelReturn.Controls.Add(this.label6);
            this.panelReturn.Location = new System.Drawing.Point(11, 11);
            this.panelReturn.Margin = new System.Windows.Forms.Padding(4);
            this.panelReturn.Name = "panelReturn";
            this.panelReturn.Size = new System.Drawing.Size(935, 496);
            this.panelReturn.TabIndex = 20;
            this.panelReturn.Visible = false;
            this.panelReturn.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReturn_Paint);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(117, 80);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 28);
            this.btnCheck.TabIndex = 22;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnRefund
            // 
            this.btnRefund.Location = new System.Drawing.Point(783, 287);
            this.btnRefund.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(100, 28);
            this.btnRefund.TabIndex = 21;
            this.btnRefund.Text = "Refund";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(243, 80);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(239, 84);
            this.listBox1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Return";
            // 
            // panelLoan
            // 
            this.panelLoan.Controls.Add(this.panelInventory);
            this.panelLoan.Controls.Add(this.btnChekout);
            this.panelLoan.Controls.Add(this.btnPayment);
            this.panelLoan.Controls.Add(this.productDataGV);
            this.panelLoan.Controls.Add(this.btnClear);
            this.panelLoan.Controls.Add(this.btnRemove);
            this.panelLoan.Controls.Add(this.lbRFID);
            this.panelLoan.Location = new System.Drawing.Point(171, 57);
            this.panelLoan.Margin = new System.Windows.Forms.Padding(4);
            this.panelLoan.Name = "panelLoan";
            this.panelLoan.Size = new System.Drawing.Size(943, 489);
            this.panelLoan.TabIndex = 6;
            this.panelLoan.Visible = false;
            this.panelLoan.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLoan_Paint);
            // 
            // panelInventory
            // 
            this.panelInventory.Controls.Add(this.label7);
            this.panelInventory.Controls.Add(this.button6);
            this.panelInventory.Controls.Add(this.button8);
            this.panelInventory.Controls.Add(this.button9);
            this.panelInventory.Controls.Add(this.button10);
            this.panelInventory.Location = new System.Drawing.Point(7, 325);
            this.panelInventory.Margin = new System.Windows.Forms.Padding(4);
            this.panelInventory.Name = "panelInventory";
            this.panelInventory.Size = new System.Drawing.Size(936, 495);
            this.panelInventory.TabIndex = 21;
            this.panelInventory.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Inventoryy";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(820, 427);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 43);
            this.button6.TabIndex = 19;
            this.button6.Text = "Checkout";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(687, 427);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(103, 43);
            this.button8.TabIndex = 17;
            this.button8.Text = "Scan";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(72, 427);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(103, 43);
            this.button9.TabIndex = 16;
            this.button9.Text = "Clear";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(203, 427);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(103, 43);
            this.button10.TabIndex = 13;
            this.button10.Text = "Remove\r\n";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // btnChekout
            // 
            this.btnChekout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnChekout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChekout.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChekout.ForeColor = System.Drawing.Color.White;
            this.btnChekout.Location = new System.Drawing.Point(820, 427);
            this.btnChekout.Margin = new System.Windows.Forms.Padding(4);
            this.btnChekout.Name = "btnChekout";
            this.btnChekout.Size = new System.Drawing.Size(103, 43);
            this.btnChekout.TabIndex = 19;
            this.btnChekout.Text = "Checkout";
            this.btnChekout.UseVisualStyleBackColor = false;
            this.btnChekout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayment.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(687, 427);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(103, 43);
            this.btnPayment.TabIndex = 17;
            this.btnPayment.Text = "Scan";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // productDataGV
            // 
            this.productDataGV.BackgroundColor = System.Drawing.Color.White;
            this.productDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productQty,
            this.Quantity,
            this.productPrice});
            this.productDataGV.Enabled = false;
            this.productDataGV.Location = new System.Drawing.Point(48, 76);
            this.productDataGV.Margin = new System.Windows.Forms.Padding(4);
            this.productDataGV.Name = "productDataGV";
            this.productDataGV.Size = new System.Drawing.Size(749, 332);
            this.productDataGV.TabIndex = 18;
            this.productDataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGV_CellContentClick);
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
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Deposit";
            this.productPrice.Name = "productPrice";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(72, 427);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 43);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(203, 427);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(103, 43);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove\r\n";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // lbRFID
            // 
            this.lbRFID.AutoSize = true;
            this.lbRFID.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRFID.Location = new System.Drawing.Point(56, 34);
            this.lbRFID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRFID.Name = "lbRFID";
            this.lbRFID.Size = new System.Drawing.Size(62, 19);
            this.lbRFID.TabIndex = 12;
            this.lbRFID.Text = "RFID: ";
            this.lbRFID.Click += new System.EventHandler(this.lbRFID_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prodId,
            this.columnHeader1});
            this.listView1.Location = new System.Drawing.Point(289, 259);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // prodId
            // 
            this.prodId.Text = "ProductId";
            // 
            // LoanAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1099, 544);
            this.Controls.Add(this.panelItem);
            this.Controls.Add(this.panelLoan);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoanAppForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlanckets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlashlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUSB)).EndInit();
            this.panelReturn.ResumeLayout(false);
            this.panelReturn.PerformLayout();
            this.panelLoan.ResumeLayout(false);
            this.panelLoan.PerformLayout();
            this.panelInventory.ResumeLayout(false);
            this.panelInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lbRFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.Button btnChekout;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelReturn;
        private System.Windows.Forms.Panel panelInventory;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader prodId;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

