using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    public abstract class AbstractTurret : Agent, Turret
    {
        protected float fireRate;
        protected int maximumAmmo;
        protected int currentAmmo;
        protected int cost;
        protected AreaOfEffect areaOfEffect;


        #region Properties
        public AreaOfEffect AreaOfEffect
        {
            get { return areaOfEffect; }
        }

        public int Cost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                    cost = 0;
                else
                    cost = value;
            }
        }

        public float FireRate
        {
            get { return fireRate; }
            set 
            {
                if (value < 0)
                    fireRate = 0f;
                else
                    fireRate = value;
            }
        }

        public int CurrentAmmo
        {
            get
            {
                return currentAmmo;
            }
            set
            {
                if (value < 0)
                {
                    currentAmmo = 0;
                    state = AgentState.Dead;
                }
                else if (value > maximumAmmo)
                    currentAmmo = maximumAmmo;
                else
                    currentAmmo = value;
            }
        }
        #endregion

        public AbstractTurret(int maxHealth, int attackDamage, float cooldown, int row, int column, float fireRate, int shotAmount, AreaOfEffect areaOfEffect) 
            : base(maxHealth, attackDamage, cooldown, row, column)
        {
            FireRate = fireRate;
            maximumAmmo = shotAmount;
            CurrentAmmo = shotAmount;
            Cost = cost;
            this.areaOfEffect = areaOfEffect;
        }

    }
}
