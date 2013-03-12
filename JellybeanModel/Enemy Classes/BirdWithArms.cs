using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel.Enemy_Classes
{
    class BirdWithArms : AbstractEnemy
    {
        public BirdWithArms()
        {
            State = AgentState.Alive;
            maxHealth = 2;
            AttackDamage = 0;
            Speed = 1;
            TileProgression = 0;
            Health = maxHealth;
            Reward = 20;
            Row = 0;
            Column = 0;
        }

        public BirdWithArms(int row, int column)
        {
            State = AgentState.Alive;
            maxHealth = 2;
            AttackDamage = 0;
            Speed = 1;
            TileProgression = 0;
            Health = maxHealth;
            Reward = 20;
            Row = row;
            Column = column;
        }

        public void Attack(Agent target)
        {
            if (state != AgentState.Dead)
            {
                //When it reaches target, call die function to kill both off.
                target.Die();
                Die();
            }
        }
    }
}
