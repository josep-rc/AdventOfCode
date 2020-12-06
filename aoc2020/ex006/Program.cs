using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using AOC.Utils;

namespace ex006
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            const string filePath = "/Users/joseppenalba/dev/katas/adventofcode/aoc2020/ex006/input.txt";
            var fileData = DataFromFile.Get(filePath);
            // Split groups from data
            var groupsData = fileData.Split("\n\n");
            var counterStar1 = 0;
            var counterStar2 = 0;

            foreach (var group in groupsData)
            {
                var r1 = CountNotRepeatedCharacters(group);
                counterStar1 += r1;

                var r2 = CountEveryoneYes(group);
                counterStar2 += r2;
            }

            Console.WriteLine(counterStar1);
            Console.WriteLine(counterStar2);
        }
        private static int CountNotRepeatedCharacters(string group)
        {
            var response = "";
            foreach (var c in group)
            {
                if (Regex.IsMatch(c.ToString(), @"^[a-z]{1}$"))
                {
                    if (!response.Contains(c))
                    {
                        response += c;
                    }
                };
            }
            return response.Length;
        }
        private static int CountEveryoneYes(string @group)
        {
            var personResponse = group.Split("\n");
            var repeated = personResponse[0];
            var toErase = "";
            
            if (personResponse.Length > 1)
            {
                // For every line except the first
                for (var index = 1; index < personResponse.Length; index++)
                {
                    // We check that it has each character of the repeated ones
                    for (var i = 0; i < personResponse[0].Length; i++)
                    {
                        // If current character is not in repeated
                        if (!personResponse[index].Contains(repeated[i]))
                        {
                            // We put it to erase
                            toErase += repeated[i];
                        }
                    }
                }
            }

            // we delete the ones on the toErase list
            for (var i = 0; i < repeated.Length; i++)
            {
                if (toErase.Contains(repeated[i]))
                {
                    repeated = repeated.Remove(i, 1);
                    i--;
                }
            }
            return repeated.Length;
        }

    }
}