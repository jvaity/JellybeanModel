using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel.Enemy_Classes
{
    class FishWithLegs : AbstractEnemy
    {
        public FishWithLegs()
        {
            state = AgentState.Alive;
            maxHealth = 6;
            AttackDamage = 6;
            Speed = 2;
            TileProgression = 0;
            Health = maxHealth;
            Reward = 80;
            Row = 0;
            Column = 0;
        }

        public FishWithLegs(int row, int column)
        {
            state = AgentState.Alive;
            maxHealth = 6;
            AttackDamage = 6;
            Speed = 2;
            TileProgression = 0;
            Health = maxHealth;
            Reward = 80;
            Row = row;
            Column = column;
        }
    }
}
