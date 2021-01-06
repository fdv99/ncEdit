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
        List<string> convertList = new List<string>();
        string material = "";
        double xOffset = 0.0;
        double yOffset = 0.0;
        string materialSize = "";

        public Form1()
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
                    convertList = File.ReadAllLines(ncFileName).ToList();
                    GetMaterial();
                }
            }
        }


        public string GetMaterial()
        {
            /// Get material condition if it is there

            var materialLocation = convertList.FindIndex(str => str.Contains("M102"));
            if (materialLocation != -1)
            {
                material = convertList[materialLocation];
                convertList.RemoveAt(materialLocation);
            }

            return material;
        }

        private void RemoveItems()
        {
            // Remove the G93 offset line
            var offsetLocation = convertList.FindIndex(str => str.Contains("G93"));
            convertList.RemoveAt(offsetLocation);

            // Remove the G90 G92 line
            convertList.RemoveAt(convertList.FindIndex(str => str.Contains("G92")));

            //int convertLength = convertList.Count;  //gets number of items in List
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
            Console.WriteLine(convertList);
            MaterialSize();
            Double.TryParse(txtBoxXOffset.Text, out xOffset);
            Double.TryParse(txtBoxYOffset.Text, out yOffset);
            

            /// If there is a material designation, insert it into the begining
            if (material != "")
            {
                convertList.Insert(2, material);  // insert material in beginning
            }
            
            convertList[3] = "G90G92X120.8661Y61.0236Z3.937";  //changes from delta origin to F1 origin
            convertList.Insert(4, "M100"); //Adds M100 laser on command after origin is set and befor offsets

            convertList.Insert(5, $"G93 X{xOffset:0.0###}Y{yOffset:0.0###}");
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

        private void MaterialSize()
        {

            // Bobcad files have varying coordinate lengths. Y0.6, X5.9757, Y21.5, Y38.0475
            // How can we get 
            double xMax = 0.0;
            double yMax = 0.0;
            string xValue = "";
            string yValue = "";

            foreach (string item in convertList)
            {

                string[] lineItems = item.Split(' ');
                Console.WriteLine(lineItems);
                
                if (lineItems.Length >= 3)
                {
                    if (lineItems[1].Contains('X'))
                    {
                        xValue = lineItems[1];

                        // Remove the X from the start
                        xValue = xValue.Substring(1);
                        if (Double.Parse(xValue) > xMax)
                        {
                            xMax = Double.Parse(xValue);
                        }

                    }

                    if (lineItems[2].Contains('Y'))
                    {
                        yValue = lineItems[2];

                        // Remove the Y from the start
                        yValue = yValue.Substring(1);
                        if (Double.Parse(yValue) > yMax)
                        {
                            yMax = Double.Parse(yValue);
                        }

                    }
                }
            }

            Console.WriteLine($"X{xMax} Y{yMax}");
            materialSize = $"(WK/   0.000T {xMax}X  {yMax})";
            convertList.Insert(1, materialSize);
        }
    }
}
