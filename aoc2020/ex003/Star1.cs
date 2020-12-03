using System;
using AOC.Utils;

namespace ex003
{
    public static class Star1
    {
        public static void Run()
        {
            const string filePath = "/Users/joseppenalba/dev/katas/adventofcode/aoc2020/ex003/input.txt";
            var inputdata = DataFromFile.GetLines<string>(filePath);

            var jumpX = 3;
            var jumpY = 1;
            var currentX = 0;
            var numTrees = 0;
            

            for(var i = jumpY; i<inputdata.Length; i = i+jumpY)
            {
                currentX += jumpX;

                while (currentX >= inputdata[i].Length)
                {
                    inputdata[i] += inputdata[i];
                }
                
                if (inputdata[i][currentX] == '#') numTrees++;
            }
            
            
            Console.WriteLine("Star1: " + numTrees);
        }
    }
}