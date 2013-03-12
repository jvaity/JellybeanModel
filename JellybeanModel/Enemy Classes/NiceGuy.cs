using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel.Enemy_Classes
{
    class NiceGuy : AbstractEnemy
    {
        public NiceGuy()
        {
            state = AgentState.Alive;
            maxHealth = 4;
            AttackDamage = 0;
            Speed = 2;
            TileProgression = 0;
            Health = maxHealth;
            Reward = 0;
            Row = 0;
            Column = 0;
        }

        public NiceGuy(int row, int column)
        {
            state = AgentState.Alive;
            maxHealth = 4;
            AttackDamage = 0;
            Speed = 2;
            TileProgression = 0;
            Health = maxHealth;
            Reward = 0;
            Row = row;
            Row = row;
        }

        public void Attack(Agent target)
        {
            if (state != AgentState.Dead)
                target.Health = target.Health;
        }
    }
}
