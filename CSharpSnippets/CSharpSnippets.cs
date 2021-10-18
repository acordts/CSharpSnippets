using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSnippets
{
    class CSharpSnippets
    {
        static void Main(string[] args)
        {
            var x = CalcNrs(3);
        }

        /// <summary>
        /// create List<string> including all numbers with leading char
        /// </summary>
        /// <param name="extLength">amount of digits</param>
        /// <param name="paddingChar">char to fill up with</param>
        /// <returns></returns>
        static IEnumerable<string> CalcNrs(int extLength, char paddingChar = '0')
        {
            var l = new List<string>();
            for (var extensionIndex = 1; extensionIndex <= extLength; extensionIndex++)
            {
                l.AddRange(Enumerable.Range(0, (int)Math.Pow(10, extensionIndex)).ToList()
                        .Select(value => value.ToString().PadLeft(extensionIndex, paddingChar)));
            }

            return l;
        }
    }
}
