using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    public abstract class AbstractTurret : Agent
    {
        protected float fireRate;
		protected float bulletSpeed;
        protected int maximumAmmo;
        protected int currentAmmo;
        protected int cost;
        protected AreaOfEffect areaOfEffect;
		protected TurretState turretState;
		
        #region Properties
        public AreaOfEffect AreaOfEffect
        {
            get { return areaOfEffect; }
        }
		
		public TurretState TurretState 
		{
			set { turretState = value; }
			get { return turretState; }
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
		
		public float BulletSpeed 
		{
			get { return bulletSpeed; }
			set { 
				if (value < 0)
					bulletSpeed = 0f;
				else
					bulletSpeed = value;
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

		public AbstractTurret () 
		{
			
		}
		
        public AbstractTurret(int maxHealth, int attackDamage, float cooldown, int row, int column, float fireRate, int shotAmount, AreaOfEffect areaOfEffect, TurretState turretState) 
            : base(maxHealth, attackDamage, cooldown, row, column)
        {
            FireRate = fireRate;
            maximumAmmo = shotAmount;
            CurrentAmmo = shotAmount;
            Cost = cost;
            this.areaOfEffect = areaOfEffect;
			this.turretState = turretState;
        }
		
		public override void Attack (List<Agent> potentialTargets)
		{
			foreach (Agent a in potentialTargets) {
			
				a.Health -= AttackDamage;
			}
		}
		
		public Bullet Shoot() {
            CurrentAmmo--;
			return new Bullet(BulletSpeed, AttackDamage, this);
		}
    }
}
