using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GoogleHash2017.Simulator.Utilities
{
    public static class ExportDataUtility
    {
        public static void Export(
            string targetFileName,
            IList<string> lines)
        {
            var csv = new StringBuilder();

            foreach (var item in lines)
                csv.AppendLine(item);

            //after your loop
            Export(targetFileName, csv.ToString());
        }

        public static void Export(
            string targetFileName,
            string content)
        {
            File.WriteAllText(targetFileName, content);
        }
    }
}

