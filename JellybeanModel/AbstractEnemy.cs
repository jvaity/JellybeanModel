using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    public abstract class AbstractEnemy : Agent
    {
        protected float tileProgression;
        protected float speed;

        protected int reward;

        #region Properties
        /// <summary>
        /// As number approaches 1 the Enemy moves closer and closer towards next tile.
        /// When enemy is over 1 then progression resets to 0 and moves to next Column
        /// </summary>
        public float TileProgression
        {
            get
            {
                return tileProgression;
            }
            set
            {
                int truncatedValue = Math.Abs((int)value);
                if (value > 1)
                {
                    Column += truncatedValue;  //Consider changing to -= if column direction is represented differently
                    tileProgression = value - truncatedValue;
                }
                else if (value < 0)
                {
                    Column -= truncatedValue; //Consider changing to += if column direction is represented differently
                    tileProgression = 1 - value - truncatedValue;
                }
                else
                    tileProgression = value;
            }
        }

        public int Reward
        {
            get
            {
                return reward;
            }
            set
            {
                if (value < 0)
                    reward = 0;
                else
                    reward = value;
            }
        }

        public float Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        #endregion

        public AbstractEnemy()
        {

        }

        public AbstractEnemy(float tileProgression, float speed, int maxHealth, int attackDamage, float cooldown, int row, int column) : base(maxHealth, attackDamage, cooldown, row, column)
        {
            TileProgression = tileProgression;
            Speed = speed;
        }

        public void Move()
        {
            tileProgression += speed;
        }

        /// <summary>
        /// Performs the main attacking action of the agent.
        /// </summary>
        public override void Attack(List<Agent> potentialTargets)
        {
            foreach (Agent t in potentialTargets)
            {
                t.Health -= attackDamage;
            }

        }
    }

}
