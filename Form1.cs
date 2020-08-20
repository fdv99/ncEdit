using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ncEdit
{
    public partial class Form1 : Form
    {

        private List<string> fileList = new List<string>();
        private string ncFileName = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            Stream myStream;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "nc files (*.nc)|*.nc|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) !=null)
                {
                    ncFileName = openFileDialog1.FileName;  //saves file path
                    original_code.Text = File.ReadAllText(ncFileName);  //displays original code in Text box
                }
            }
        }

        private void btn_ConvertNC_Click(object sender, EventArgs e)
        {

            List<string> convertList = File.ReadAllLines(ncFileName).ToList();  //converts original code to List
            int convertLength = convertList.Count;  //gets number of items in List
            convertList.RemoveAt(convertLength - 1);  //deletes last row of list (%)
            convertList.RemoveAt(convertLength - 2);  //deletes second last row of list (G50)
            convertList.Add("G00X120.8661Y61.0236Z3.937");  //append go home on end of list
            convertList.Add("M707");  //append shuttle command on end
            convertList.Add("G50");  //append G50 on end
            converted_code.Lines = convertList.ToArray();  //display new code in text box

            string AddSuffix(string filename, string suffix)
            {
                string fDir = Path.GetDirectoryName(ncFileName);
                string fName = Path.GetFileNameWithoutExtension(ncFileName);
                string fExt = Path.GetExtension(ncFileName);
                return Path.Combine(fDir, String.Concat(fName, suffix, fExt));
            }

            string newFileName = AddSuffix(ncFileName, String.Format("({0})", "F1")); //append (F1) to file name

            converted_code.SaveFile(newFileName, RichTextBoxStreamType.RichText);  //save new file



        }
    }
}
