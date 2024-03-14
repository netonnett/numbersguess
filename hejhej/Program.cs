namespace hejhej
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int tal1 = rand.Next(1, 21);
            

            Console.WriteLine("Guess the number ((:");
            string guessednum = Console.ReadLine();
            int guesseint = int.Parse(guessednum);

            for (int i = 0; i < 2 && guesseint != tal1; i++)
            {
               
                if (guesseint < tal1)
                {
                    Console.WriteLine("guess higher (:");
                }
                else if (guesseint > tal1)
                {
                    Console.WriteLine("guess lower ):");
                }

                else if (guesseint == tal1)
                {
                    Console.WriteLine("you guessed correct!");
                }


                guessednum = Console.ReadLine();
                guesseint = int.Parse(guessednum);


            }

            if (guesseint != tal1)
            {
                Console.WriteLine("du gissade fel )): talet var: " + tal1);
            }

            if(guesseint == tal1)
            {
                Console.WriteLine("you guessed correct! ((:");
            }
        }
    }
}