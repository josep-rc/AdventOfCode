using System;
using AOC.Utils;

namespace ex002
{
    public static class Star2
    {
        public static void Run()
        {
            string filePath = "/Users/joseppenalba/dev/katas/adventofcode/aoc2020/ex002/input.webarchive";
            string[] inputdata = DataFromFile.GetLines<string>(filePath);
            Predicate<TobogganCode> validator = ValidatorStar2;
            int validCounter = 0;
            TobogganCode tcode;

            foreach (string line in inputdata)
            {
                tcode = new TobogganCode(line);
                if (tcode.isValid(ValidatorStar2)) validCounter++;
            }
            Console.WriteLine("Num. Star2 valid codes: " + validCounter);
        }

        static bool ValidatorStar2(TobogganCode item)
        {
            bool pos1IsCharacter;
            bool pos2IsCharacter;

            pos1IsCharacter = item.Code[item.Num1 - 1] == item.Letter;
            pos2IsCharacter = item.Code[item.Num2 - 1] == item.Letter;

            return pos1IsCharacter ^ pos2IsCharacter;
        }
    }
}
