using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    public class StarkidImprov : AbstractImprov
    {
        private List<AbstractEnemy> affectedEnemies;

        public StarkidImprov()
        {
            name = "You're a Star Kid!";
            description = "Multiples revenue while the crowd cheers you on";
            ScoreMultiplier = 1;
            inUse = false;
            AffectedType = AgentType.Enemy;

            affectedEnemies = new List<AbstractEnemy>();
        }

        public override void ApplyEffect(List<AbstractEnemy> affectedEnemies)
        {
            if (!inUse)
            {
                inUse = true;

                this.affectedEnemies = affectedEnemies;

                foreach (AbstractEnemy a in affectedEnemies)
                {
                    a.Reward *= 2;
                }
            }            
        }

        public void RemoveEffect()
        {
            try
            {
                foreach (AbstractEnemy a in affectedEnemies)
                {
                    a.Reward /= 2;
                }
            }
            catch (NullReferenceException e)
            {
                //Here just in case list gets modified during call. Not sure if possible on Unity
            }

        }

    }
}
