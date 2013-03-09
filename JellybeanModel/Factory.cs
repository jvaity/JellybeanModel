using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    public static class Factory
    {
        public Factory() {
            
        }

        public Agent CreateTurret(TurretType type)
        {
            //Add switch statement returning turret depending on TurretType
            throw new NotImplementedException();
        }

        public Agent CreateEnemy(EnemyType type)
        {
            //Add switch statement returning enemy depending on EnemyType
            //throw new NotImplementedException();

            AbstractEnemy temp = new BasicEnemy();

            switch (type)
            {
                case EnemyType.BasicEnemy :
                    temp = new BasicEnemy();
                    break;
                case EnemyType.SausageDog:
                    temp = new SausageDog();
                    break;
                //case EnemyType.BasicEnemy:
                //    temp = new BasicEnemy();
                //    break;
                //case EnemyType.BasicEnemy:
                //    temp = new BasicEnemy();
                //    break;
                //case EnemyType.BasicEnemy:
                //    temp = new BasicEnemy();
                //    break;
                //case EnemyType.BasicEnemy:
                //    temp = new BasicEnemy();
                //    break;
                //case EnemyType.BasicEnemy:
                //    temp = new BasicEnemy();
                //case EnemyType.BasicEnemy:
                //    temp = new BasicEnemy();
                //    break;
                //case EnemyType.BasicEnemy:
                //    temp = new BasicEnemy();
                //    break;
            }

            return temp;
        }

    }
}
