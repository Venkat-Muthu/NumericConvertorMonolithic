using System;
using System.Collections.Generic;

namespace NumericConvertorMonolithic
{
    public class MyNumeralsConvertor
    {
        private readonly Dictionary<char, int> _romanToIntMap = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        private readonly Dictionary<char, int> _romanRepeatable = new Dictionary<char, int>
        {
            {'I', 1},
            {'X', 10},
            {'C', 100},
            {'M', 1000},
        };
        public int RomanToInt(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;

            var romanLength = s.Length;

            char prevLetter = '\0';
            int prevNumber = int.MaxValue;
            int index = 0;
            var sum = 0;

            while (index < romanLength)
            {
                var currLetter = s[index];
                if (_romanToIntMap.ContainsKey(currLetter))
                {
                    var currNumber = _romanToIntMap[currLetter];

                    if (index > 2 && currLetter == prevLetter)
                    {
                        if (!_romanRepeatable.ContainsKey(currLetter))
                        {
                            throw new ArgumentException($"{currLetter} can't repeat more than once.");
                        }
                        var revIndex = index - 1;
                        while (revIndex >= 0 && currLetter == s[revIndex])
                        {
                            revIndex--;
                        }

                        if (index - revIndex > 3)
                        {
                            throw new ArgumentException($"{currLetter} can't repeat more than trice.");
                        }
                    }

                    if (currLetter == prevLetter)
                    {
                        if (!_romanRepeatable.ContainsKey(currLetter))
                        {
                            throw new ArgumentException($"{currLetter} can't repeat more than once.");
                        }
                    }

                    if (index > 0 && prevNumber < currNumber)
                    {
                        if (index > 1)
                        {
                            if (s[index - 2] == s[index - 1])
                            {
                                throw new ArgumentException($"{currLetter} Two subtraction is not allowed.");
                            }
                        }
                        var number = currNumber / prevNumber;
                        if (!(number == 5 || number == 10))
                        {
                            throw new ArgumentException($"Letter : {currLetter} not in correct order");
                        }

                        sum -= 2 * prevNumber;
                    }
                    sum += currNumber;

                    prevLetter = currLetter;
                    prevNumber = currNumber;
                    index++;
                }
                else
                {
                    return 0;
                }
            }

            return sum;
        }
    }
}