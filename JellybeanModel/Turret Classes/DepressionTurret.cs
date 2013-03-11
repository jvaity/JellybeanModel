using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
	public class DepressionTurret : AbstractTurret {
	
		public DepressionTurret ()
		{
			AttackDamage = 0;
			CurrentAmmo = 3;
			State = AgentState.Alive;
			CooldownTime = 5f;
			Health = 2;
			FireRate = 5f;
			BulletSpeed = 0.0f;
			cost = 40;
			
			Row = 0;
			Column = 0;
			areaOfEffect = AreaOfEffect.Circular;
			turretState = TurretState.NotActive;	
		}
		
		public DepressionTurret (int row, int column) {
		
			AttackDamage = 0;
			CurrentAmmo = 3;
			State = AgentState.Alive;
			CooldownTime = 5f;
			Health = 2;
			FireRate = 5f;
			BulletSpeed = 0.0f;
			cost = 40;
			
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
