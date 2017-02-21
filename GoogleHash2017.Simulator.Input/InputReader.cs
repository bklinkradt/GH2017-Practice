using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GoogleHash2017.Simulator.Inputs
{
    public class InputReader
    {
        #region Instance Methods

        #region Helper Methods

        public InputReaderResult ParseFromFile(
            string fileName)
        {
            var inputFileContents = ReadLinesFromFile(fileName);
            return Parse(inputFileContents.ToList());
        }

        private IEnumerable<string> ReadLinesFromFile(
            string fileName)
        {
            using (StreamReader reader = File.OpenText(fileName))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

        #endregion

        public InputReaderResult Parse(
            string inputContents)
        {
            return Parse(Regex.Split(inputContents, "\r\n|\r|\n"));
        }

        public InputReaderResult Parse(
            IList<string> inputContents)
        {
            var returnResult = new InputReaderResult();

            //SingleLinkChunkExample.Instance.ParseChunk(returnResult, new List<string> { inputContents[0] });
            //MultiLineChunkExample.Instance.ParseChunk(returnResult, new List<string> { inputContents[1], inputContents[2] });

            //returnResult.ExampleNo = Convert.ToInt32(inputContents[3]);
            //for (int i = 4; i < 4 + (returnResult.ExampleNo * 2); i += 2)
            //{
            //    MultiSectionChunkExample.Instance.ParseChunk(returnResult, new List<string> { inputContents[i], inputContents[i+1] });
            //}

            return returnResult;
        }

        #endregion
    }
}
