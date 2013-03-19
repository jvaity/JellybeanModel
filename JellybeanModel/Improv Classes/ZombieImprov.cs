using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    class ZombieImprov : AbstractImprov
    {
        public ZombieImprov() 
        {
            name = "I'll Be Back!";
            description = "When enemies die they come back as zombies.";
            ScoreMultiplier = 3;
            inUse = true;
            AffectedType = AgentType.Enemy;
        }

        public override void ApplyEffect(List<AbstractEnemy> affectedEnemies)
        {
            if (inUse)
            {
                foreach (AbstractEnemy e in affectedEnemies)
                {
                    if (e.State == AgentState.Dead)
                    {
                        e.State = AgentState.Sleeping;
                    }
                }
            }
        }

        public void RemoveEffect(List<AbstractEnemy> affectedEnemies)
        {
            if (inUse)
            {
                foreach (AbstractEnemy e in affectedEnemies)
                {
                    if (e.State == AgentState.Sleeping)
                    {
                        e.Health += 2;
                        e.State = AgentState.Alive;
                    }
                }


                inUse = false;
            }
        }
        

    }
}
