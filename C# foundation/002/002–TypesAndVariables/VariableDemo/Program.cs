namespace VariableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ned Stark";
            string age = "8";
            string job = "swordsmanship";
            Console.WriteLine("My name is " + name + ".");
            Console.WriteLine("I started " + job + " when I was " + age + ".");
            Console.WriteLine("As a " + age + " years old boy, I knew nothing about " + job + ".");
            Console.WriteLine("But if " + name + " could start " + job + " from his " + age + ", you can do so.");
            Console.WriteLine("I want to help you be a " + job + " by teaching you everything I know.");
        }
    }
}