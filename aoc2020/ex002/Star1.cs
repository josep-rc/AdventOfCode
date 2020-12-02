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

            int num1;
            int num2;
            char car;
            string code;
            string snum2;
            int minusPos;
            int spacePos;
            int validCounter = 0;
            bool validCode;
            int charTimes;
            foreach (string line in inputdata)
            {
                // Obtengo el código
                minusPos = line.IndexOf("-");
                num1 = int.Parse(line.Substring(0, minusPos));

                spacePos = line.IndexOf(" ", minusPos);
                snum2 = line.Substring(minusPos + 1, spacePos - minusPos);
                num2 = int.Parse(snum2);

                car = line.Substring(spacePos + 1, 1)[0];

                code = line.Substring(spacePos + 4);

                // Valido el código

                // Contamos las veces que aparece el caracter
                charTimes = 0;
                validCode = false;
                foreach (char c in code)
                {
                    if (c == car) charTimes++;
                }

                if (charTimes >= num1 && charTimes <= num2) validCode = true;


                if (validCode) validCounter++;


                //Console.WriteLine($"{num1}+{num2}+{car}+{code}+{charTimes}+{validCode}");
            }
            Console.WriteLine(validCounter);
        }
    }
}
