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
        private string filetext = string.Empty;
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
                    ncFileName = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(ncFileName);
                    original_code.Text = filetext;
                }
            }
        }

        private void btn_ConvertNC_Click(object sender, EventArgs e)
        {

            List<string> convertList = File.ReadAllLines(ncFileName).ToList();
            int convertLength = convertList.Count;
            convertList.RemoveAt(convertLength - 1);
            convertList.RemoveAt(convertLength - 2);
            convertList.Add("G00X120.8661Y61.0236Z3.937");
            convertList.Add("M707");
            convertList.Add("G50");
            converted_code.Lines = convertList.ToArray();

            string AddSuffix(string filename, string suffix)
            {
                string fDir = Path.GetDirectoryName(ncFileName);
                string fName = Path.GetFileNameWithoutExtension(ncFileName);
                string fExt = Path.GetExtension(ncFileName);
                return Path.Combine(fDir, String.Concat(fName, suffix, fExt));
            }

            string newFileName = AddSuffix(ncFileName, String.Format("({0})", "F1"));

            converted_code.SaveFile(newFileName, RichTextBoxStreamType.RichText);



        }
    }
}
