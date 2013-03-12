using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel.Enemy_Classes
{
    class FishOnLand : AbstractEnemy
    {
        public FishOnLand()
        {
            state = AgentState.Alive;
            maxHealth = 2;
            AttackDamage = 0;
            Speed = 0;
            TileProgression = 0;
            Health = maxHealth;
            Reward = 10;
            Row = 0;
            Column = 0;
        }

        public FishOnLand(int row, int column)
        {
            state = AgentState.Alive;
            maxHealth = 2;
            AttackDamage = 0;
            Speed = 0;
            TileProgression = 0;
            Health = maxHealth;
            Reward = 10;
            Row = row;
            Column = column;
        }
    }
}
