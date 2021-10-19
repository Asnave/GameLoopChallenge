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

            ConsoleKeyInfo Input = Console.ReadKey(intercept:true);
            

            if(Input.Key == ConsoleKey.W)
            {
                y -= 1;
                RangeCheck();
            }
            else if(Input.Key == ConsoleKey.S)
            {
                y += 1;
                RangeCheck();
            }
            else if (Input.Key == ConsoleKey.A)
            {
                x -= 1;
                RangeCheck();
            }
            else if (Input.Key == ConsoleKey.D)
            {
                x += 1;
               RangeCheck();
            }
            else if (Input.Key == ConsoleKey.Escape)
            {
                gameOver = true;
            }

        }

        static void RangeCheck()
        {
            if (y < 1)
            {
                y = 0;
            }

            if (x < 1)
            {
                x = 0;
            }

            // whats the max x???
           if (x >= 120)
            {
                x = 119;
            }

        }
        static void PlayerDraw()
        {

                Console.Clear();
                Console.SetCursorPosition(x,y);
                Console.Write(value: "*");
               
            

        }
        

        
    }
}
