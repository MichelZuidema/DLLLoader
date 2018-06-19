using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLLLoader
{
    public partial class Form1 : Form
    {
        public string ProcessName;
        public string DLLPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GetPathOfDLL()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Multiselect = false;

            if(OFD.ShowDialog() == DialogResult.OK)
            {
                string DLLFilePath = OFD.FileName;
                DLLPath = DLLFilePath;
                txtDLLPath.Text = DLLPath;
            }
        }

        private void GetProcessName()
        {
            ProcessName = txtProcessName.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetPathOfDLL();
        }

        private bool ProcessNameValid()
        {
            if (txtProcessName.Text == "'Process Name'")
            {
                return false;
            } else if(txtProcessName.Text == "")
            {
                return false;
            }

            return true;
        }

        private bool DLLPathValid()
        {
            if (txtDLLPath.Text == "Please Specify DLL Path")
            {
                return false;
            }
            else if (txtDLLPath.Text == "")
            {
                return false;
            } else if(!File.Exists(DLLPath))
            {
                return false;
            }

            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(this.ProcessNameValid() == true)
            {
                if(this.DLLPathValid() == true)
                {
                    Form2 form2 = new Form2();

                    this.Hide();
                    form2.Show();

                    GetProcessName();
                    form2.GetDataFromForm(ProcessName, DLLPath);
                } else
                {
                    MessageBox.Show("DLL Path Invalid", "Failed");
                }
            } else
            {
                MessageBox.Show("Process Name Invalid", "Failed");
            }
        }
    }
}
