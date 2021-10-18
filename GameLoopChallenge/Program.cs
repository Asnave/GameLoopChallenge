using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoopChallenge
{
    class Program
    {

        
        static bool gameOver = false;
        static int x;
        static int y;
        static void Main(string[] args)
        {
           while (gameOver == false)
            {

               
                Update();
                PlayerDraw();
              
                Console.ReadKey(true);
            }


        }
        
        static void Update()
        {

            ConsoleKeyInfo Input = Console.ReadKey(true);
            

            if(Input.Key == ConsoleKey.W)
            {
                y -= 1;
                Console.Write("W");
            }
            else if(Input.Key == ConsoleKey.S)
            {
                y += 1;
                Console.Write("S");
            }
            else if (Input.Key == ConsoleKey.A)
            {
                x -= 1;
                Console.Write("A");
            }
            else if (Input.Key == ConsoleKey.D)
            {
                x += 1;
                Console.Write("D");
            }
            else if (Input.Key == ConsoleKey.Escape)
            {
                
            }

        }

        static void PlayerDraw(char player = '*', int x = 0, int y = 0)
        {
            if (x >= 0 && y >= 0)
            {
               
                Console.SetCursorPosition(x, y);
                Console.Write(player);
               
            }

        }
        
        
    }
}
