using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime
            //programm küsib kasutajalt numbrit 1-3
            //kui kasutaja sisestab 1, siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja sisestab 2, siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta üks number 1-3:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber == 1)
            {
                NameBackwards(userName);
            }
            else if (userNumber == 2)
            {
                NameFirstLetter(userName);
            }
            else if (userNumber ==3)
            {
                NameLength(userName);
            }
            else
            {
                Console.WriteLine("Kena päeva!");
            }

        }

        public static void NameBackwards(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void NameFirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}.");
        }

        public static void NameLength(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }

}
}
