using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel.Enemy_Classes
{
    class TickingBomb : AbstractEnemy
    {
        public TickingBomb()
        {
            State = AgentState.Alive;
            maxHealth = 3;
            AttackDamage = 0;
            Speed = 3;
            TileProgression = 0;
            Health = maxHealth;
            Reward = 40;
            Row = 0;
            Column = 0;
        }

        public TickingBomb(int row, int column)
        {
            State = AgentState.Alive;
            maxHealth = 3;
            AttackDamage = 0;
            Speed = 3;
            TileProgression = 0;
            Health = maxHealth;
            Reward = 40;
            Row = row;
            Column = column;
        }
    }
}
