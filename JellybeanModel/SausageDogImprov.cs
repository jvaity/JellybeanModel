using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    public class SausageDogImprov : AbstractImprov
    {
        public SausageDogImprov() 
        {
            name = "Sausage Dog Mode";
            description = "Turns all Enemies to Sausage Dogs. That is all.";
            ScoreMultiplier = 1;
            inUse = false;
            AffectedType = AgentType.Enemy;
        }

        /// <summary>
        /// Takes every agent passed in through the parameters and converts it to a 
        /// Sausage Dog type enemy
        /// </summary>
        /// <param name="affectedAgents">List of enemies currently in the game</param>
        public override void ApplyEffect(List<Agent> affectedAgents)
        {
            if (!inUse)
            {
                inUse = true;

                //Checks each agent in the list and replaces it with a sausage dog enemy
                for (int i = 0; i < affectedAgents.Count; i++)
                {
                    Agent tempEnemy = affectedAgents[i];

                    affectedAgents[i] = new SausageDog(tempEnemy.Health, tempEnemy.Row, tempEnemy.Column); //Consider adding tileProgression as param if used properly in Unity
                }
            }
        }
    
    }
}
