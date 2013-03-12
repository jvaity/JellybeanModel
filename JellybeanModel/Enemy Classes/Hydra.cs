using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel.Enemy_Classes
{
    class Hydra : AbstractEnemy
    {
        protected AbstractEnemy[] hydrray;

        public Hydra()
        {
            State = AgentState.Alive;
            maxHealth = 4;
            AttackDamage = 3;
            Speed = 3;
            TileProgression = 0;
            Health = maxHealth;
            Reward = 40;
            Row = 0;
            Column = 0;
            hydrray = new AbstractEnemy[7];
        }

        public Hydra(int row, int column)
        {
            State = AgentState.Alive;
            maxHealth = 4;
            AttackDamage = 3;
            Speed = 3;
            TileProgression = 0;
            Health = maxHealth;
            Reward = 40;
            Row = row;
            Column = column;
            hydrray = new AbstractEnemy[7];
        }

        public void Attack(Agent target)
        {
            if (state != AgentState.Dead)
                target.Health -= attackDamage;
        }

        public void Die(AbstractEnemy[] hydrray)
        {
            Console.WriteLine("I'm gonna die like a little bitch.");
            ///<summary>
            ///pass in an array storing all the hydra spawn. Max number for array is 7.
            ///When this is called, the array is passed in, and as the hydra who called the function dies, it creates 2
            ///new hydras at a smaller scale with stats divided by 2. 
        }
    }
}