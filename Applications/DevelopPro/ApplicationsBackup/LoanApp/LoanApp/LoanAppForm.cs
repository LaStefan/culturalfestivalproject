using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevelopPro;
using Phidget22.Events;
using Phidget22;
using System.Collections;

namespace LoanApp
{
    public partial class LoanAppForm : Form
    {
        private Item product = new Item(0, "", 0, 0);
        private Item inventory = null;
        private RFID rfid = new RFID();
        private Database db = new Database();
        private List<Item> listOfProducts = new List<Item>();
        string chipNr = "";

        public LoanAppForm()
        {
            InitializeComponent();
            sideBar.Height = btnHome.Height;
            sideBar.Top = btnHome.Top;
            listVReturn.HideSelection = false;
            rfid.Open();
        }

        private void LoanAppForm_Load(object sender, EventArgs e)
        {


        }

        private void AddToListView(Item item)
        {
            // Define the list items
            string[] row = {item.LoanId.ToString(), item.LoanName, item.StartDate.ToString(), item.Deposit.ToString()};
            ListViewItem lvi = new ListViewItem(row);
            // Add the list items to the ListView
            listVReturn.Items.Add(lvi);
        }

        private void ShowInListView()
        {
            listVReturn.Items.Clear();
            List<Item> items = db.GetBorrowedProducts(chipNr);
            foreach (var item in items)
            {
                AddToListView(item);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnBrowse.Height;
            sideBar.Top = btnBrowse.Top;
            panelItem.Show();
            panelLoan.Hide();
            panelReturn.Hide();
            panelInventory.Hide();
            panelItem.Dock = DockStyle.Fill;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnHome.Height;
            sideBar.Top = btnHome.Top;
            panelItem.Visible = false;
            panelLoan.Visible = false;
            panelReturn.Visible = false;
            panelInventory.Visible = false;
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnLoan.Height;
            sideBar.Top = btnLoan.Top;
            panelLoan.Show();
            panelItem.Hide();
            panelReturn.Hide();
            panelInventory.Hide();
            panelLoan.Dock = DockStyle.Fill;
            productDataGV.Rows.Clear();
            productDataGV.Refresh();
            productDataGV.DataSource = null;
            successfullyBorrowed.Visible = false;
            foreach (Item p in db.listOfItems)
            {
                productDataGV.Rows.Add(p.LoanId.ToString(), p.LoanName, DateTime.Now, "€" + p.Deposit.ToString());
            }
            if(productDataGV.Rows.Count > 0)
            {
                rfid.Tag += TagAdd;
            }
            else
            {

                rfid.Tag -= TagAdd;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbPhone_Click(object sender, EventArgs e)
        {
            product = db.GetProduct("Mobile Phone");
            LoanForm lf = new LoanForm(product, db.listOfItems, this.db);
            lf.ShowDialog();
        }

        private void pbUSB_Click(object sender, EventArgs e)
        {
            product = db.GetProduct("Charger");
            LoanForm lf = new LoanForm(product, db.listOfItems, this.db);
            lf.ShowDialog();
        }

        private void pbFlashlight_Click(object sender, EventArgs e)
        {
            product = db.GetProduct("Touch Light");
            LoanForm lf = new LoanForm(product, db.listOfItems, this.db);
            lf.ShowDialog();
        }

        private void pbBags_Click(object sender, EventArgs e)
        {
            product = db.GetProduct("Mattress");
            LoanForm lf = new LoanForm(product, db.listOfItems, this.db);
            lf.ShowDialog();

        }

        private void pbCamera_Click(object sender, EventArgs e)
        {
            product = db.GetProduct("Camera");
            LoanForm lf = new LoanForm(product, db.listOfItems, this.db);
            lf.ShowDialog();
        }

        private void pbBlanckets_Click(object sender, EventArgs e)
        {
            product = db.GetProduct("Blanket");
            LoanForm lf = new LoanForm(product, db.listOfItems, this.db);
            lf.ShowDialog();
        }

        private void TagAdd(object sender, RFIDTagEventArgs e)
        {
            chipNr = e.Tag;
            Customer temp = db.GetCustomer(chipNr);
            PersonalDetails pd = new PersonalDetails(temp);
            if (!CheckForm(pd))
            {
                pd.Show();
            }           
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnReturn.Height;
            sideBar.Top = btnReturn.Top;
            panelLoan.Hide();
            panelItem.Hide();
            panelReturn.Show();
            panelInventory.Hide();
            panelReturn.Dock = DockStyle.Fill;
            rfid.Tag += TagAdd;
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnInventory.Height;
            sideBar.Top = btnInventory.Top;
            panelLoan.Hide();
            panelItem.Hide();
            panelReturn.Hide();
            panelInventory.Show();
            panelInventory.Dock = DockStyle.Fill;
            inventory = null;
            succAdded.Visible = false;
            numericUPInventory.Value = 0;
            pbLightIn.BorderStyle = BorderStyle.Fixed3D;
            pBcameraIn.BorderStyle = BorderStyle.None;
            pbPhoneIn.BorderStyle = BorderStyle.None;
            pbBlanketIn.BorderStyle = BorderStyle.None;
            pbmattressIn.BorderStyle = BorderStyle.None;
            pbChargerIn.BorderStyle = BorderStyle.None;
            pbLightIn.BorderStyle = BorderStyle.None;

        }

        private bool CheckForm(Form form)
        {
            form = Application.OpenForms[form.Text];
            if (form != null)
                return true;
            else
                return false;
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            productDataGV.Rows.Clear();
            db.listOfItems.Clear();
            productDataGV.Refresh();
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in productDataGV.SelectedRows)
            {
                productDataGV.Rows.RemoveAt(row.Index);
                var product = db.listOfItems.FirstOrDefault();
                if (product != null)
                    db.listOfItems.Remove(product);
                productDataGV.Refresh();
            }
        }

        private void btnChekout_Click(object sender, EventArgs e)
        {
            if (chipNr != "")
            {
                bool temp = false;
                db.LoanItem(db.listOfItems, chipNr,ref temp);
                productDataGV.Rows.Clear();
                db.listOfItems.Clear();
                chipNr = "";
                successfullyBorrowed.Visible = temp;
            }
            else
            {
                MessageBox.Show("Please first scan RFID tag");
            }
        }

        private void pbChargerIn_Click(object sender, EventArgs e)
        {
           inventory = db.GetProduct("Charger");

            pbChargerIn.BorderStyle = BorderStyle.Fixed3D;
            pBcameraIn.BorderStyle = BorderStyle.None;
            pbPhoneIn.BorderStyle = BorderStyle.None;
            pbBlanketIn.BorderStyle = BorderStyle.None;
            pbmattressIn.BorderStyle = BorderStyle.None;
            pbLightIn.BorderStyle = BorderStyle.None; 
            succAdded.Visible = false;
        }


        private void pBcameraIn_Click(object sender, EventArgs e)
        {
            inventory = db.GetProduct("Camera");

            pBcameraIn.BorderStyle = BorderStyle.Fixed3D;
            pbChargerIn.BorderStyle = BorderStyle.None;
            pbPhoneIn.BorderStyle = BorderStyle.None;
            pbBlanketIn.BorderStyle = BorderStyle.None;
            pbmattressIn.BorderStyle = BorderStyle.None;
            pbLightIn.BorderStyle = BorderStyle.None;
            succAdded.Visible = false;
        }

        private void pbPhoneIn_Click(object sender, EventArgs e)
        {
            inventory = db.GetProduct("Mobile Phone");

            pbPhoneIn.BorderStyle = BorderStyle.Fixed3D;
            pBcameraIn.BorderStyle = BorderStyle.None;
            pbChargerIn.BorderStyle = BorderStyle.None;
            pbBlanketIn.BorderStyle = BorderStyle.None;
            pbmattressIn.BorderStyle = BorderStyle.None;
            pbLightIn.BorderStyle = BorderStyle.None;
            succAdded.Visible = false;
        }

        private void pbBlanketIn_Click(object sender, EventArgs e)
        {
            inventory = db.GetProduct("Blanket");

            pbBlanketIn.BorderStyle = BorderStyle.Fixed3D;
            pBcameraIn.BorderStyle = BorderStyle.None;
            pbPhoneIn.BorderStyle = BorderStyle.None;
            pbChargerIn.BorderStyle = BorderStyle.None;
            pbmattressIn.BorderStyle = BorderStyle.None;
            pbLightIn.BorderStyle = BorderStyle.None;
            succAdded.Visible = false;
        }

        private void pbmattressIn_Click(object sender, EventArgs e)
        {
            inventory = db.GetProduct("Mattress");

            pbmattressIn.BorderStyle = BorderStyle.Fixed3D;
            pBcameraIn.BorderStyle = BorderStyle.None;
            pbPhoneIn.BorderStyle = BorderStyle.None;
            pbBlanketIn.BorderStyle = BorderStyle.None;
            pbChargerIn.BorderStyle = BorderStyle.None;
            pbLightIn.BorderStyle = BorderStyle.None;
            succAdded.Visible = false;
        }

        private void pbLightIn_Click(object sender, EventArgs e)
        {
            inventory = db.GetProduct("Touch Light");

            pbLightIn.BorderStyle = BorderStyle.Fixed3D;
            pBcameraIn.BorderStyle = BorderStyle.None;
            pbPhoneIn.BorderStyle = BorderStyle.None;
            pbBlanketIn.BorderStyle = BorderStyle.None;
            pbmattressIn.BorderStyle = BorderStyle.None;
            pbChargerIn.BorderStyle = BorderStyle.None;
            succAdded.Visible = false;

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int numericValue = Convert.ToInt32(numericUPInventory.Value);
            db.AddInventory(inventory,numericValue);
            inventory = null;
            succAdded.Visible = true;
            numericUPInventory.Value = 0;
            pbLightIn.BorderStyle = BorderStyle.Fixed3D;
            pBcameraIn.BorderStyle = BorderStyle.None;
            pbPhoneIn.BorderStyle = BorderStyle.None;
            pbBlanketIn.BorderStyle = BorderStyle.None;
            pbmattressIn.BorderStyle = BorderStyle.None;
            pbChargerIn.BorderStyle = BorderStyle.None;
            pbLightIn.BorderStyle = BorderStyle.None;
        }

        private void rBDamaged_CheckedChanged(object sender, EventArgs e)
        {
            tBReturnStatus.Visible = true;
            lBDamage.Visible = true;
        }

        private void rBUnDamaged_CheckedChanged(object sender, EventArgs e)
        {
            tBReturnStatus.Visible = false;
            lBDamage.Visible = false;
        }

        private void dGVReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbQuestion.Visible = true;
            rBDamaged.Visible = true;
            rBUnDamaged.Visible = true;
        }

        private void btnReturnItem_Click(object sender, EventArgs e)
        {
            bool damaged = false;

            if (rBUnDamaged.Checked == true)
            {
                damaged = false;
            }
            else if (rBDamaged.Checked == true)
            {
                damaged = true;
            }

            //Item tempItem = lbReturn.SelectedItem as Item;
            int index = listVReturn.SelectedIndices[0];
            List<Item> items;
            Item selectedItem = null;
            if (index >= 0)
            {
                items = db.GetBorrowedProducts(chipNr);
                selectedItem = items[index];
            }

            lbQuestion.Visible = false;
            rBDamaged.Visible = false;
            rBUnDamaged.Visible = false;
            tBReturnStatus.Visible = false;
            lBDamage.Visible = false;

            db.RefundBorrowedItem(selectedItem, chipNr, tBReturnStatus.Text, damaged);
            lbSuccReturned.Visible = true;
            this.tBReturnStatus.Clear();
            ShowInListView();


        }

        private void btnShowItems_Click(object sender, EventArgs e)
        {
            lbSuccReturned.Visible = false;

            listVReturn.Items.Clear();
            if (chipNr != "")
            {
                ShowInListView();
            }
            else
            {
                MessageBox.Show("Please first scan RFID tag!");
            }
        }

        private void listVReturn_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbQuestion.Visible = true;
            rBDamaged.Visible = true;
            rBUnDamaged.Visible = true;
            lbSuccReturned.Visible = false;
        }
    }
}
