using assiment;

namespace assiment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lintA, lintB, lintC;


            Console.WriteLine("Enter value for a");
            lintA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for b");
            lintB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for c");
            lintC = Convert.ToInt32(Console.ReadLine());


            int lintSum =SimpleCode.Add(lintA,lintB);
            lintSum = SimpleCode.Add(lintSum,lintC);
            int lintSub = SimpleCode.Subtraction(lintA, lintB);
            int lintMultiply = SimpleCode.Multiply(lintA, lintB);
            float lintDiv = SimpleCode.Division(lintA, lintB);
            Console.WriteLine("Addition=" + lintSum);
            Console.WriteLine("Substaction=" + lintSub);
            Console.WriteLine("multiplication=" + lintMultiply);
            Console.WriteLine("Division=" + lintDiv);
            
        }
    }
}
