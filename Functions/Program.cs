using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm koostab funktsiooni, mis liidab kaks arvu
            //double - kümnendarv, mis on kiirem
            //decimal - kümnendarv, mis on aeglasem

            Console.WriteLine("Sisesta esimene arv:");
            int userNrOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv:");
            int userNrTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vali tehe (sisesta '+', '-', '*' või '/'");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(userNrOne, userNrTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNrOne, userNrTwo);
                    break;
                case '-':
                    SubtractTwoNumbers(userNrOne, userNrTwo);
                    break;
                case '*':
                    MultiplyTwoNumbers(userNrOne, userNrTwo);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }


        public static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }

        public static void MultiplyTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
        }

        public static void SubtractTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
        }
    }
}
