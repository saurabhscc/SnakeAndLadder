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
         int Snake = 3;
        public void Snakes()
        {
            int position = 0;
            Console.WriteLine("Player is at position: " + position);
            Random random = new Random();
            int droll = 0;
            while (true)
            {
                droll = random.Next(7);
                if (droll != 0) break;
            }

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
                    Console.WriteLine("Player stays in the same position : " + position);
                    break;

                case 2:
                    position += droll;
                    Console.WriteLine("Player moves ahead by : " + position);
                    break;

                case 3:
                    position -= droll;
                    Console.WriteLine("Player moves behind by : " + position);
                    break;

            }

        }
    }
}

