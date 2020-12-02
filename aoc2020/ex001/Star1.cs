using System;
using System.IO;
using System.Collections.Generic;
using AOC.Utils;

namespace ex001
{
  public class Star1
  {
    public static void Run()
    {
      int expectedSum = 2020;
      string filePath = "/Users/joseppenalba/dev/katas/adventofcode/aoc2020/ex001/input.webarchive";
      int[] inputdata = DataFromFile.GetLines<int>(filePath);
      (int, int) operands = DataFinder.FindSum2(inputdata, expectedSum);

      if (operands.Item1 + operands.Item2 == expectedSum)
      {
        Console.WriteLine($"{operands.Item1} + {operands.Item2} = {expectedSum}");
        int productResult = operands.Item1 * operands.Item2;
        Console.WriteLine($"{operands.Item1} * {operands.Item2} = {productResult}");
      }
      else
      {
        Console.WriteLine("No se encuentra la combinación");
      }
    }
  }
}
