using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingContest.IO
{
    internal class ReadWriter
    {
        private const string inputFileTemplate = "data/level{0}/level{0}-{1}.txt";
        private const string outputFileTemplate = "data/level{0}/level{0}-{1}.solution.txt";

        public static List<string> ReadFile(int level, int subLevel)
        {
            var filePath = string.Format(inputFileTemplate, level, subLevel);
            return File.ReadAllLines(filePath).ToList();
        }

        public static void WriteFile(int level, int subLevel, string output)
        {
            var filePath = string.Format(outputFileTemplate, level, subLevel);
            File.WriteAllText(filePath, output);
        }
    }
}
