namespace VariableDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Alex";

            int age = 50;

            short maxShortnumber = short.MaxValue;
            int maxIntnumber = int.MaxValue;
            long maxLongNumber = long.MaxValue;

            float floatNumber = 5500.5f;
            decimal decimalNumber = 5.63M;
            double doubleNumber = 6.32;

            bool isMarried = false;


            Console.WriteLine("Max Short value: " + maxShortnumber);
            Console.WriteLine("Max int Value :" + maxIntnumber);
            Console.WriteLine("Max Long value: " + maxLongNumber);

            Console.WriteLine(floatNumber);
            Console.WriteLine(doubleNumber);
            Console.WriteLine(decimalNumber);
        }
    }
}