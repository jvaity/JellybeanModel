using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    public class SausageDog : AbstractEnemy
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="health">Input current health of Enemy to Convert</param>
        /// <param name="row">Input row of Enemy to Convert</param>
        /// <param name="column">Input column of Enemy to Convert</param>
        public SausageDog(int health, int row, int column)
        {
            Health = health;
            Row = row;
            Column = column;

            State = AgentState.Alive;
            AttackDamage = 2;
            speed = 0.5f;
            TileProgression = 0;
            Reward = 10;
        }

    }
}
