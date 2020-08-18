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

namespace ncEdit
{
    public partial class Form1 : Form
    {
        private string filetext = string.Empty;
        private string tempText = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            Stream myStream;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) !=null)
                {
                    string strfilename = openFileDialog1.FileName;
                    filetext = File.ReadAllText(strfilename);
                    original_code.Text = filetext;
                }
            }
        }

        private void btn_ConvertNC_Click(object sender, EventArgs e)
        {
            //string convertText = filetext;
            filetext.Replace("E10", "hey");
            File.WriteAllText(@"C:\Users\V6-Engineering\Desktop\temp.nc", filetext);
            tempText = File.ReadAllText(@"C:\Users\V6-Engineering\Desktop\temp.nc");
            converted_code.Text = tempText;


        }
    }
}
