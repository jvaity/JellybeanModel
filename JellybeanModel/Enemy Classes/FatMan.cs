using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel.Enemy_Classes
{
    class FatMan : AbstractEnemy
    {
        /// <summary>
        /// Constructor sets position to default (0,0)
        /// Provide all properties required of the Enemy:
        /// AgentState State
        /// int AttackDamage
        /// float Speed
        /// float TileProgression
        /// int Health
        /// int Reward
        /// int Row
        /// int Column
        /// </summary>

        public FatMan()
        {
            State = AgentState.Alive;
            maxHealth = 6;
            AttackDamage = 0;
            Speed = 3;
            TileProgression = 0;
            Health = maxHealth;
            Reward = 50;
            Row = 0;
            Column = 0;
        }

        /// <summary>
        /// Provide all properties required of the Enemy:
        /// AgentState State
        /// int AttackDamage
        /// float Speed
        /// float TileProgression
        /// int Health
        /// int Reward
        /// </summary>
        public FatMan(int row, int column)
        {
            State = AgentState.Alive;
            maxHealth = 6;
            AttackDamage = 0;
            Speed = 3;
            TileProgression = 0;
            Health = maxHealth;
            Reward = 50;
            Row = row;
            Column = column;
        }

        /// <summary>
        /// Performs the main action of the Enemy when it reaches its target
        /// </summary>
        /// <param name="target">Target is the Turret that will be Attacked</param>
        public void Attack(Agent target)
        {
            if (state != AgentState.Dead)
            {
                target.Die();
            }
        }
    }
}
