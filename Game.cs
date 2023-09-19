using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Sawyer_Moira
{
    internal class Game
    {
        // A property with an automatic getter, called MaxPlayer.
        public int MaxPlayers { get;  }

        // A property with an automatic getter, called CurrentPlayers .
        public int CurrentPlayers { get; set;  }

        // A constructor that takes the two int parameters, maxPlayers and currentPlayers.
        public Game(int maxP, int currentP)
        {
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }
        // A method called, KickPlayer thats in the body decrement CurrentPlayers by 1.
        public void KickPlayer()
        {
            CurrentPlayers--;
        }
        // A methoud that takes a Queue<Player> parameter.
        public void CheckQueue(Queue<Player> playerQueue)
        {
            // If CurrentPlayers is less than MaxPlayers, than it checks if the queue has elements in it.
            if (CurrentPlayers < MaxPlayers)
            {

                // If the queue has players in it, than it calls Dequeue on the queue and increment current players by 1.
                if (playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                else

                //  Prints, "No Players in the Queue!".
                {
                    Console.WriteLine("No players in the queue!");
                }
            }
        }
    }
}
