using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AOC.Utils
{
    public static class DataFromFile
    {
        public static T[] GetLines<T>(string filePath)
        {
            IEnumerable<string> fileData = File.ReadLines(filePath);

            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.Int32:
                    return (T[])(object)DataToInteger(fileData);
            }
            return (T[])(object)fileData.ToArray();

            int[] DataToInteger(IEnumerable<string> data)
            {
                var dataSize = data.Count();
                int[] values = new int[dataSize];
                int i = 0;
                foreach (string s in data)
                {
                    values[i] = int.Parse(s);
                    i++;
                }
                return values;
            }
        }
    }
}
