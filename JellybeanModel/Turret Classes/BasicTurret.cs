using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
	public class BasicTurret : AbstractTurret {
		
		public BasicTurret () {
			
			AttackDamage = 1;
			CurrentAmmo = 4;
			State = AgentState.Alive;
			CooldownTime = 3f;
			Health = 2;
			FireRate = 3f;
			BulletSpeed = 2.0f;
			cost = 10;
			
			Row = 0;
			Column = 0;
			areaOfEffect = AreaOfEffect.Straight;
			turretState = TurretState.NotActive;
		}
		
		public BasicTurret (int row, int column) {
		
			AttackDamage = 1;
			CurrentAmmo = 4;
			State = AgentState.Alive;
			CooldownTime = 3f;
			Health = 2;
			FireRate = 3f;
			BulletSpeed = 2.0f;
			
			Row = row;
			Column = column;
			areaOfEffect = AreaOfEffect.Straight;
			turretState = TurretState.NotActive;
		}
		
		public override void Attack() {
			currentAmmo--;
		}
		
	}
}
