using System;

namespace LikesSystem
{

 
        private static void LikesSyste()
        {   

            Console.Write("Introdu numele: ");
            string abc = Console.ReadLine();
            abc.Replace(',' , ' ');
    

            string[] words = abc.Split(' ',',','/');

            
            if (words.Length<=1)
            {
                Console.Write("No one likes this");
            }

            else if (words.Length>1 && words.Length<2)
                {
                    Console.Write(words[0] + " likes this");
                }

            else if (words.Length == 2)
                {
                    Console.Write(words[0] + " and " + words[1] + " likes this");
                }

            else if (words.Length == 3)
            {
                Console.Write(words[0] + " , " + words[1] + " and " + words[2] + " likes this");
            }

            else if (words.Length > 3)
            {
                Console.Write(words[0] + " , " + words[1] +  " and " + (words.Length-2) + " others likes this");
            }

        }
}
