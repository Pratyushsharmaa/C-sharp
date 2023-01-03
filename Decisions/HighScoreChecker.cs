using System;

namespace HighscoreChecker
{
    class Program
    {
        static int highScore = 264;
        static string highscorePlayer = "Rohit Sharma";
        static void Main(string[] args)
        {
            

            
           // CheckHighScore(250,"Shaun");
            CheckHighScore(280, "Pratyush");
        }
        
       
       
        public static void CheckHighScore(int score, string playerName)
        {
            int highScore = 264;
            if (score > highScore)
            {
                highScore = score;
                highscorePlayer = playerName;
                Console.WriteLine("New highscore is: " + score + " by " + playerName);
                Console.Read();
            }
            else if (score<highScore)
            {
                Console.WriteLine("Record not broken, old highscore is " + highScore + " by " +  highscorePlayer);
                Console.Read();
            }
            else
            {
                Console.WriteLine("Invalid input");
                Console.Read();
            }
            
        }

    }
}
