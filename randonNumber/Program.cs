using System;

namespace randonNumber
{
    class Program
    {
        private static int sccisors;
        private static int paper;

        static void Main(string[] args)
        {


            int Rock = 1;
            int Paper = 2;
            int scissors = 3;
            Random ranNum = new Random();
            int hidenNumber = ranNum.Next(3);
            int matchNumber;


            Console.WriteLine("Please choose: Number 1 for Rock, Number 2 for Paper and Number 3 for Scissors:");
            matchNumber = Convert.ToInt32(Console.ReadLine());
            if (matchNumber == Rock && hidenNumber == Rock)
            {
                Console.WriteLine("Rock and Rock is a tie");
            }
            else if (matchNumber == paper && hidenNumber == sccisors)
            {


                Console.WriteLine("Scissors wins vs paper");
            }
            else if ( matchNumber == Rock && hidenNumber == scissors)
            {

                Console.WriteLine("Paper wins againt rock");
            }

            else { 

            Console.WriteLine("You are the winner" + hidenNumber);
        }



        }
    }
}
