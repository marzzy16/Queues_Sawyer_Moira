using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Sawyer_Moira
{
    internal class Player
    {
        // An automatic property called Health of integer type.
        public int Health { get; set; }

        // A property called GamerTag, with an automatic getter, of string type.
        public string GamerTag { get; }

        // a constructor that takes the int healthParam parameter and the string nameParam .
        public Player(int healthParam, string nameParam)

        {
            // Assigns the parameters to the corresponding properties in the constructor.
            Health = healthParam;
            GamerTag = nameParam;
        }

        // A public method called JoinGame, that takes two parameters.
        public void JoinGame(Game game, Queue<Player> queue)
        {

            // If the game's current players is equal to the max players, then it adds  'this' player to the queue.
            if (game.CurrentPlayers == game.MaxPlayers)
            {
                queue.Enqueue(this);
            }
            else
            {
                // Prints, "Joining Game".
                Console.WriteLine("Joining Game!");
            }
        }
        // Overrides the Totring method.
        public override string ToString()
        {
            // returns GamerTag.
            return GamerTag;
        }
    }
}
