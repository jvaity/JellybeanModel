using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    public interface Enemy
    {
        #region Properties
        AgentState State
        {
            get;
            set;
        }

        int Row
        {
            get;
            set;
        }

        int Column
        {
            get;
            set;
        }

        float TileProgression
        {
            get;
            set;
        }

        int Health
        {
            get;
            set;
        }

        int Reward
        {
            get;
            set;
        }

        float Speed
        {
            get;
            set;
        }

        int AttackDamage
        {
            get;
            set;
        }
        #endregion

        void Move();

        void Attack(List<Agent> potentialTargets);

        void Die();
    }
}
