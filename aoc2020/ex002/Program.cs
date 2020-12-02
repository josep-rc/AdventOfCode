using System;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            Star1.Run();
            Star2.Run();

            // Code validation example
            TobogganCode tc = new TobogganCode("4-5 x: xdxlfx");
            Console.WriteLine(tc);
            Predicate<TobogganCode> validator = Validator1;
            Console.WriteLine(tc.isValid(validator));
        }

        // Example validator
        static bool Validator1(TobogganCode item)
        {
            return true;
        }
    }

    // 4-5 x: xdxlfx
    public class TobogganCode
    {
        public int Num1 { get; init; }
        public int Num2 { get; init; }
        public char Letter { get; init; }
        public string Code { get; init; }

        public TobogganCode(string sourceLine)
        {
            var parts = sourceLine.Split(' ', '-', ':');
            Num1 = int.Parse(parts[0]);
            Num2 = int.Parse(parts[1]);
            Letter = parts[2][0];
            Code = parts[4];
        }

        public bool isValid(Predicate<TobogganCode> validator)
        {
            return validator(this);
        }

        public override string ToString()
        {
            return $"{Num1},{Num2}-{Letter}:{Code}";
        }
    }
}
