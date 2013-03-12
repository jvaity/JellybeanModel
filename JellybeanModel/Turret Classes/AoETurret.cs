using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
  public class AoETurret : AbstractTurret {
	
		public AoETurret ()
		{
			AttackDamage = 1;
			CurrentAmmo = 4;
			State = AgentState.Alive;
			CooldownTime = 5f;
			Health = 2;
			FireRate = 5f;
			BulletSpeed = 0.0f;
			cost = 20;
			
			Row = 0;
			Column = 0;
			areaOfEffect = AreaOfEffect.Circular;
			turretState = TurretState.NotActive;	
		}
		
		public AoETurret (int row, int column) {
		
			AttackDamage = 1;
			CurrentAmmo = 4;
			State = AgentState.Alive;
			CooldownTime = 5f;
			Health = 2;
			FireRate = 5f;
			BulletSpeed = 0.0f;
			cost = 20;
			
			Row = row;
			Column = column;
			areaOfEffect = AreaOfEffect.Circular;
			turretState = TurretState.NotActive;
		}
		
		public override void Attack() {
			currentAmmo--;
		}
	}
}
