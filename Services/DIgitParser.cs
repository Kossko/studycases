using StudyCases.Interfaces;
using StudyCases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyCases.Services
{
    public class DigitParser : IDigitParser
    {
        const int _linesHeight = 3;
        const int _digitWidth = 3;


        private static List<string[]> _dictionary = DigitsDictionary.Dictionary;

        public List<int> GetResults(List<string> lines)
        {
            List<int> result = new List<int>();

            foreach (var asciiDigit in GetAsciiDigits(lines))
            {
                var machedDigit = _dictionary.Find(digit => digit.SequenceEqual(asciiDigit));

                if (machedDigit != null)
                {
                    result.Add(_dictionary.IndexOf(machedDigit));
                }
                else
                {
                    result.Add(-1);
                }
            }

            return result;
        }

        private IEnumerable<string[]> GetAsciiDigits(List<string> lines)
        {
            var sequence = 0;
            var linesLength = lines[1].Length;
            while (sequence < linesLength / _digitWidth)
            {
                var result = new string[_linesHeight];

                for (var i = 0; i <= _linesHeight - 1; i++)
                {
                    result[i] = lines[i].Substring(sequence * _digitWidth, _digitWidth);
                }
                yield return result;
                sequence += 1;
            }
        }
    }
}
