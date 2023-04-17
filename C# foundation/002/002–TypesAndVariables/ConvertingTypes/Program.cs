namespace ConvertingTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 2;
            string numberInString = "5";
            int number2 = 5;

            int convertedNumber = Convert.ToInt32(numberInString);

            Console.WriteLine(number1 + numberInString);
            Console.WriteLine(number1 + convertedNumber);
            Console.WriteLine(number1 + number2);
        }
    }
}