using System;
using AOC.Utils;

namespace ex002
{
    public class Star1
    {
        public static void Run()
        {
            string filePath = "/Users/joseppenalba/dev/katas/adventofcode/aoc2020/ex002/input.webarchive";
            string[] inputdata = DataFromFile.GetLines<string>(filePath);
            Predicate<TobogganCode> validator = ValidatorStar1;
            int validCounter = 0;
            TobogganCode tcode;
            foreach (string line in inputdata)
            {
                tcode = new TobogganCode(line);
                if (tcode.isValid(ValidatorStar1)) validCounter++;
            }
            Console.WriteLine("Num. Star1 valid codes: " + validCounter);
        }

        static bool ValidatorStar1(TobogganCode item)
        {
            int letterTimes = 0;
            bool validCode = false;
            foreach (char c in item.Code)
            {
                if (c == item.Letter) letterTimes++;
            }
            if (letterTimes >= item.Num1 && letterTimes <= item.Num2) validCode = true;

            return validCode;
        }
    }
}
