using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel.Enemy_Classes
{
    class Moleman : AbstractEnemy
    {
        public void Moleman()
        {
            state = AgentState.Alive;
            maxHealth = 2;
            AttackDamage = 2;
            Speed = 3;
            TileProgression = 0;
            Health = maxHealth;
            Reward = 40;
            Row = 0;
            Column = 0;
        }

        public void Moleman(int row, int column)
        {
            state = AgentState.Alive;
            maxHealth = 2;
            AttackDamage = 2;
            Speed = 3;
            TileProgression = 0;
            Health = maxHealth;
            Reward = 40;
            Row = row;
            Row = row;
        }
    }
}
