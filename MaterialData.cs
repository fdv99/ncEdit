using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ncEdit
{
    public static class MaterialData
    {
        public static string GetMaterial(List<string> convertList)
        {
            string output = "";
            var materialLocation = convertList.FindIndex(str => str.Contains("M102"));
            if (materialLocation != -1)
            {
                output = convertList[materialLocation];
                convertList.RemoveAt(materialLocation);
            }
            return output;
        }

        public static string GetMaterialSize(List<string> convertList, double xOffset, double yOffset)
        {
            double xMax = 0.0;
            double yMax = 0.0;

            // Loop through the list of NC code
            foreach (string item in convertList)
            {
                string[] lineItems = item.Split(' ');

                if (lineItems.Length >= 3)
                {
                    if (lineItems[1].Contains('X'))
                    {
                        string xValue = lineItems[1];

                        // Remove the X from the start
                        xValue = xValue.Substring(1);
                        if (Double.Parse(xValue) > xMax)
                        {
                            xMax = Double.Parse(xValue);
                        }
                    }

                    if (lineItems[2].Contains('Y'))
                    {
                        string yValue = lineItems[2];

                        // Remove the Y from the start
                        yValue = yValue.Substring(1);
                        if (Double.Parse(yValue) > yMax)
                        {
                            yMax = Double.Parse(yValue);
                        }
                    }
                }
            }

            xMax += xOffset + 0.25;
            yMax += yOffset + 0.25;

            if (xMax >= 120.0 | yMax >= 60.0)
            {
                MessageBox.Show($"Check Sheet Limits: X:{xMax:0.00} Y:{yMax:0.00}", "Warning!");
            }
            string output = $"(WK/   0.000T  { xMax:0.000}X  { yMax:0.000})";

            return output;

        }

    }
}
