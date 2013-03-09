using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{   
    /// <summary>
    ///Name class the same as the Enemy name and Inherit 'AbstractEnemy'
    /// </summary>
    public class BasicEnemy : AbstractEnemy
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
        public BasicEnemy()
        {
            State = AgentState.Alive;
            AttackDamage = 5;
            Speed = 0.5f;
            TileProgression = 0;
            Health = 5;
            Reward = 10;
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
        public BasicEnemy(int row, int column)
        {
            State = AgentState.Alive;
            AttackDamage = 5;
            Speed = 0.5f;
            TileProgression = 0;
            Health = 5;
            Reward = 10;

            Row = row;
            Column = column;
        }

        /// <summary>
        /// Performs the main action of the Enemy when it reaches its target
        /// </summary>
        /// <param name="target">Target is the Turret that will be Attacked</param>
        public override void Attack(AbstractTurret target)
        {
            if (state != AgentState.Dead)
                target.Health -= attackDamage;
        }

    }
}
