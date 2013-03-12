using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
	public class BurstTurret : AbstractTurret{
	
		public BurstTurret ()
		{
			AttackDamage = 0;
            maximumAmmo = 1;
            CurrentAmmo = maximumAmmo;
			State = AgentState.Alive;
			CooldownTime = 2f;
			Health = 2;
			FireRate = 0f;
			BulletSpeed = 2.0f;
			cost = 20;
			
			Row = 0;
			Column = 0;
			areaOfEffect = AreaOfEffect.Straight;
			turretState = TurretState.NotActive;	
		}
		
		public BurstTurret (int row, int column) {
		
			AttackDamage = 0;
			CurrentAmmo = 1;
			State = AgentState.Alive;
			CooldownTime = 2f;
			Health = 2;
			FireRate = 0f;
			BulletSpeed = 2.0f;
			cost = 20;
			
			Row = row;
			Column = column;
			areaOfEffect = AreaOfEffect.Straight;
			turretState = TurretState.NotActive;
		}
	}
}
