namespace SamiaLuck
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string num;
            Console.WriteLine("Please Enter a Number between 1 and 5 and find the lucky number");
            num = Console.ReadLine();

            if (num == "3")
            {
                Console.WriteLine("It's your lucky day!! You got the lucky number!!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }
    }
}
