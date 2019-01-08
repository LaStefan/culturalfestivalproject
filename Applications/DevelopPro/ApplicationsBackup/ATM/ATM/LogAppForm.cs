using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ATM
{
    public partial class LogAppForm : Form
    {
        public LogAppForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamReader sr = null;
            string filename;
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if(ofd.ShowDialog()==DialogResult.OK)
                {
                    filename = ofd.FileName;
                    fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    //String s = sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                       String s = sr.ReadLine();
                        listBox1.Items.Add(s);
                    }
                }
                
            }
            catch(IOException)
            {
                MessageBox.Show("Error reading file log!");
            }
            finally
            {
                if (sr != null) { sr.Close(); }
                if (fs != null) { fs.Close(); }
            }
        }
    }
}
