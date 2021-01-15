using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncEdit
{
    public class AddRemove
    {
        public static void RemoveItems(List<string> convertList)
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

        public static void AddItems(List<string> convertList, double xOffset, double yOffset)
        {
            convertList.Add("/G130");  //append go home on end of list
            convertList.Add("/M707");  //append shuttle command on end
            convertList.Add("G50");  //append G50 on end

            convertList.Insert(10, $"G93 X{xOffset:0.0###}Y{yOffset:0.0###}");
            convertList.Insert(10, "M100"); //Adds M100 laser on command after origin is set and befor offsets
            convertList.Insert(10, "G90G92X120.8661Y61.0236Z3.937");  //changes from delta origin to F1 origin
        }
    }
}
