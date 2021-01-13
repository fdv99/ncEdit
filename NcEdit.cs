﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ncEdit
{
    public partial class NcEdit : Form
    {
        private string ncFileName = string.Empty;
        List<string> convertList = new List<string>();
        string material = "";
        double xOffset = 0.0;
        double yOffset = 0.0;
        string materialSize = "";

        public NcEdit()
        {
            InitializeComponent();
        }

        private void Btn_OpenFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "nc files (*.nc)|*.nc|All files (*.*)|*.*"
            };
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((openFileDialog1.OpenFile()) != null)
                {
                    ncFileName = openFileDialog1.FileName;  //saves file path
                    original_code.Text = File.ReadAllText(ncFileName);  //displays original code in Text box
                    convertList.Clear();
                    convertList = File.ReadAllLines(ncFileName).ToList();
                    material = MaterialData.GetMaterial(convertList);
                }
            }
        }

        private void RemoveItems()
        {
            // Remove the G93 offset line
            var offsetLocation = convertList.FindIndex(str => str.Contains("G93"));
            convertList.RemoveAt(offsetLocation);

            // Remove the G90 G92 line
            convertList.RemoveAt(convertList.FindIndex(str => str.Contains("G92")));
            convertList.RemoveAt(convertList.Count - 1);  //deletes last row of list (%)
            convertList.RemoveAt(convertList.Count - 1);  //deletes second last row of list (G50)

            /// Remove M100 everywhere it might be
            while (convertList.Contains("M100"))
            {
                convertList.Remove("M100");
            }
        }

        private void Btn_ConvertNC_Click(object sender, EventArgs e)
        {
            RemoveItems();
            Double.TryParse(txtBoxXOffset.Text, out xOffset);
            Double.TryParse(txtBoxYOffset.Text, out yOffset);
            materialSize = MaterialData.GetMaterialSize(convertList, xOffset, yOffset);
            PlaceComments(materialSize);

            // Add ending sequence
            convertList.Add("/G130");  //append go home on end of list
            convertList.Add("/M707");  //append shuttle command on end
            convertList.Add("G50");  //append G50 on end

            convertList.Insert(10, $"G93 X{xOffset:0.0###}Y{yOffset:0.0###}");
            convertList.Insert(10, "M100"); //Adds M100 laser on command after origin is set and befor offsets
            convertList.Insert(10, "G90G92X120.8661Y61.0236Z3.937");  //changes from delta origin to F1 origin

            /// If there is a material designation, insert it into the begining
            if (material != "")
            {
                convertList.Insert(10, material);  // insert material in beginning
            }

            converted_code.Lines = convertList.ToArray();  //display new code in text box

            SaveNcFile(ncFileName);
        }

        private void PlaceComments(string materialSize)
        {
            convertList.Insert(1, "(PZ/ 0.000X   0.000)");
            convertList.Insert(1, "(CR/Y2009M08D10)");
            convertList.Insert(1, "(TT/  H  M  S)");
            convertList.Insert(1, "(CS/                       )");
            convertList.Insert(1, "(CL/ 7.087   27.756   69.095   89.764)");
            convertList.Insert(1, materialSize);
            convertList.Insert(1, "(MA/ CRS0.075)");
            convertList.Insert(1, "(MN/ 237)");
            convertList.Insert(1, "(MC/ F1 - 3015NT   )");
        }

        private void SaveNcFile(string fileName)
        {
            string AddSuffix(string ncFileName, string suffix)
            {
                string fDir = Path.GetDirectoryName(fileName);
                string fName = Path.GetFileNameWithoutExtension(fileName);
                string fExt = Path.GetExtension(ncFileName);
                return Path.Combine(fDir, String.Concat(fName, suffix, fExt));
            }

            string newFileName = AddSuffix(fileName, String.Format("{0}", "F1")); //append (F1) to file name

            TextWriter tw = new StreamWriter(newFileName);

            foreach (String s in convertList)
                tw.WriteLine(s);
            tw.Close();
            int fileSize = newFileName.Length;
            tb_fileSize.Text = fileSize.ToString();
        }
    }
}
