using System;

namespace GuessRanAndSub
{
    class Program
    {
        public static void getAnswer(int number, int favRanNum, int tooHigh, int tooLow)
        {
            if (number >= tooHigh)
                Console.WriteLine("You guessed the number too high");
            else if (number <= tooLow)
                Console.WriteLine("You guessed the number too Low");
            else 
                {
                if (number == favRanNum)
                    Console.WriteLine("You guessed the correct number");
                else
                    Console.WriteLine("Never mind");
                }

            


        }

        static void Main(string[] args)
        {
            //enum subject {c, java, python}

            var rNum = new Random();
            var favRanNum = rNum.Next(1, 1000);

            var tooHigh = favRanNum + 50;
            var tooLow = favRanNum - 50;
            //Console.WriteLine($"*** picked number {favRanNum}");

            Console.WriteLine("Please try to guess my favorite number between 1 to 1000");
            var number = int.Parse(Console.ReadLine());

            getAnswer(number, favRanNum, tooHigh, tooLow);




            Console.WriteLine($"The following are the school subjects --  c, java, c++, c#, python");

            Console.WriteLine("Please enter your favorite school subject");
            var favSub = Console.ReadLine();

            

            switch (favSub)
                {
                case "c":
                    Console.WriteLine($"You chose {favSub}. COOL ");
                    break;
            
                case "java":
                    Console.WriteLine($"You chose {favSub}.  FANTASTIC ");
                    break;

                case "c++":
                    Console.WriteLine($"You chose {favSub}.  AWESOME");
                    break;

                case "c#":
                    Console.WriteLine($"You chose {favSub}.  ENJOY");
                    break;

                case "python":
                    Console.WriteLine($"You chose {favSub}. GOOD");
                    break;

                default:
                    Console.WriteLine($"{favSub} is not in the subject List ");
                    break;

                }



        }


    }
}
