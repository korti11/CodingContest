using CodingContest.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingContest.Level
{
    abstract class AbstractLevel
    {
        protected abstract int GetLevel();

        protected abstract int GetSubLevel();

        protected abstract string Run(List<string> input);

        public void Execute()
        {
            for (int i = 1; i <= GetSubLevel(); i++)
            {
                var input = ReadWriter.ReadFile(GetLevel(), i);
                var output = Run(input);
                ReadWriter.WriteFile(GetLevel(), i, output);
            }
        }
    }
}
