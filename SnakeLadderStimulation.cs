using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class SnakeLadderStimulation
    {
        /// <summary>
        /// This Method is For Players Check For Options
        /// </summary>
        public int No_Play = 1;
        public int Ladder = 2;
        public int Snake = 3;
        public int Win_position = 100;
        public int Position_check = 0;
        public void Snakes2()
        {
            int position = 0;
            Console.WriteLine("Player is at Start  Position: " + position);

            Random random = new Random();
            int droll = 0;
            while (true)
            {
                droll = random.Next(7);
                if (droll != 0) break;
            }
            Console.WriteLine("Number of dice : " + droll);

            while (position < Win_position)

            {
                Random ran = new Random();
                int option = 0;
                while (true)
                {
                    option = ran.Next(4);
                    if (option != 0) break;
                }
                Console.WriteLine("====OPTIONS======\nOption 1 : No Play\nOption 2 : Ladder \nOption 3 : Snake \n");
                Console.WriteLine("Option : " + option);

                switch (option)
                {

                    case 1:
                        Console.WriteLine("Player Stay  in the Same Position : " + position);
                        break;

                    case 2:
                        position += droll;
                        Console.WriteLine("Player moves Ahead by : " + position);
                        break;

                    case 3:
                        position -= droll;
                        if ((position - droll) < Position_check)
                        {
                            position = Position_check;
                        }
                        Console.WriteLine("Player moves Behind by : " + position);
                        break;
                    default:
                        Console.WriteLine("Enter the Correct Value");
                        break;
                }

            }

        }
    }
}

