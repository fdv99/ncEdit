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
            string convertText = filetext;
            convertText.Replace("G90 G92X120.0787Y60.2362Z7.874", "G00G92X120.8661Y61.024Z3.937");
            converted_code.Text = convertText;
        }
    }
}
