using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    public interface Turret
    {
        #region Properties
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

        AreaOfEffect AreaOfEffect
        {
            get;
        }

        float CooldownTime
        {
            get;
            set;
        }

        int Cost
        {
            get;
        }

        float FireRate
        {
            get;
        }

        int ShotAmount
        {
            get;
            set;
        }

        int AttackDamage
        {
            get;
            set;
        }

        int Health
        {
            get;
            set;
        }
        #endregion

        void Attack(List<Agent> potentialTargets);

        void Die();
    }
}
