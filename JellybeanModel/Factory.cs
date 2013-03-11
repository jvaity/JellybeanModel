using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    public class Factory
    {
		private static Factory instance;
			
		private Factory() {}
		
		/// <summary>
		/// Gets the instance.
		/// </summary>
		/// <value>
		/// The instance.
		/// </value>
		public static Factory Instance
		{
			get
			{
				if (instance == null)
					instance = new Factory();
				
				return instance;
			}
		}
		
		/// <summary>
		/// Creates the turret.
		/// </summary>
		/// <returns>
		/// The turret.
		/// </returns>
		/// <param name='type'>
		/// Turret Type.
		/// </param>
        public AbstractTurret CreateTurret(TurretType type)
        {
            //Switch statement returning turret depending on TurretType
			AbstractTurret temp = new BasicTurret();
			
			switch (type)
			{
				case TurretType.BasicTurret :
					temp = new BasicTurret();
					break;
//				case TurretType.BoxingGlove :
//					temp = new BoxingGlove();
//					break;
				case TurretType.BurstTurret :
					temp = new BurstTurret();
					break;
//				case TurretType.CopycatTurret :
//					temp = new CopycatTurret();
//					break;
				case TurretType.DepressionTurret :
					temp = new DepressionTurret();
					break;
//				case TurretType.LaserTurret :
//					temp = new LaserTurret();
//					break;
//				case TurretType.RandomTurret :
//					temp = new RandomTurret();
//					break;
//				case TurretType.TurretTurret :
//					temp = new TurretTurret();
//					break;
			}
			return temp;
        }
		
		/// <summary>
		/// Creates the enemy.
		/// </summary>
		/// <returns>
		/// The enemy.
		/// </returns>
		/// <param name='type'>
		/// Enemy Type.
		/// </param>
        public AbstractEnemy CreateEnemy(EnemyType type)
        {
            //Switch statement returning enemy depending on EnemyType
            AbstractEnemy temp = new BasicEnemy();

            switch (type)
            {
                case EnemyType.BasicEnemy :
                    temp = new BasicEnemy();
                    break;
                case EnemyType.SausageDog:
                    temp = new SausageDog();
                    break;
//                case EnemyType.BirdWithArms:
//                    temp = new BirdWithArms();
//                    break;
//                case EnemyType.FatGaint:
//                    temp = new FatGaint();
//                    break;
//                case EnemyType.FishOnLand:
//                    temp = new FishOnLand();
//                    break;
//                case EnemyType.FishWithLegs:
//                    temp = new FishWithLegs();
//                    break;
//                case EnemyType.Hydra:
//                    temp = new Hydra();
//					break;
//                case EnemyType.Kitten:
//                    temp = new Kitten();
//                    break;
//                case EnemyType.Moleman:
//                    temp = new Moleman();
//                    break;
//				case EnemyType.NiceEnemy:
//                    temp = new NiceEnemy();
//                    break;
//				case EnemyType.TimeBomb:
//                    temp = new TimeBomb();
//                    break;
            }

            return temp;
        }

    }
}
