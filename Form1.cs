using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ncEdit
{
    public partial class Form1 : Form
    {

        private string ncFileName = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_OpenFile_Click(object sender, EventArgs e)
        {

            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "nc files (*.nc)|*.nc|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((openFileDialog1.OpenFile()) !=null)
                {
                    ncFileName = openFileDialog1.FileName;  //saves file path
                    original_code.Text = File.ReadAllText(ncFileName);  //displays original code in Text box
                }
            }
        }

        private void Btn_ConvertNC_Click(object sender, EventArgs e)
        {
            List<string> convertList = File.ReadAllLines(ncFileName).ToList();  //converts original code to List

            /// Get material condition if it is there
            var material = "";
            var materialLocation = convertList.FindIndex(str => str.Contains("M102"));
            if (materialLocation != -1)
            {
                material = convertList[materialLocation];
            }

            int convertLength = convertList.Count;  //gets number of items in List
            convertList.RemoveAt(convertLength - 1);  //deletes last row of list (%)
            convertList.RemoveAt(convertLength - 2);  //deletes second last row of list (G50)
            convertList.RemoveAt(1);  // remove coordinate line
            
            /// Remove M100 everywhere it might be
            while (convertList.Contains("M100"))
            {
                convertList.Remove("M100");
            }

            /// If there is a material designation, insert it into the begining
            if (material != "")
            {
                convertList.Insert(1, material);  // insert material in beginning
            }


            convertList[2] = "G90G92X120.8661Y61.0236Z3.937";  //changes from delta origin to F1 origin
            convertList.Insert(3, "M100"); //Adds M100 laser on command after origin is set and befor offsets

            convertList.Add("G93 X0.0Y0.0Z0.0");
            convertList.Add("/G130");  //append go home on end of list
            convertList.Add("/M707");  //append shuttle command on end
            convertList.Add("G50");  //append G50 on end

            // To use E3 and E4, find G00 X0.0005 Y0.0005 and insert before or after
            
            converted_code.Lines = convertList.ToArray();  //display new code in text box

            string AddSuffix(string ncFileName, string suffix)
            {
                string fDir = Path.GetDirectoryName(ncFileName);
                string fName = Path.GetFileNameWithoutExtension(ncFileName);
                string fExt = Path.GetExtension(ncFileName);
                return Path.Combine(fDir, String.Concat(fName, suffix, fExt));
            }

            string newFileName = AddSuffix(ncFileName, String.Format("{0}", "F1")); //append (F1) to file name

            TextWriter tw = new StreamWriter(newFileName);

            foreach (String s in convertList)
                tw.WriteLine(s);
            tw.Close();
            int fileSize = newFileName.Length;
            tb_fileSize.Text = fileSize.ToString();

        }

        private void MaterialSize();
    }
}
