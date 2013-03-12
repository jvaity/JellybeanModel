using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel.Improv_Classes
{
    class NaturalDisasterImprov : AbstractImprov
    {

        public bool[,] affectedTiles;

        public NaturalDisasterImprov() 
        {
            name = "Natural Disaster";
            description = "Randomly kills Turrets and Enemies on the stage";
            ScoreMultiplier = 1;
            inUse = false;
            AffectedType = AgentType.All;

            affectedTiles = new bool[MAXIMUM_ROW_LENGTH, MAXIMUM_COLUMN_LENGTH];
        }

        const int MAXIMUM_ROW_LENGTH = 8;
        const int MAXIMUM_COLUMN_LENGTH = 5;

        const int DISASTER_MINIMUM_LIMIT = 2;
        const int DISASTER_MAXIMUM_LIMIT = 8;

        public override void ApplyEffect(List<Agent> affectedAgents)
        {
            if (!inUse)
            {
                Random random = new Random();

                //Randomly decides the amount of disasters for each tile
                int disasterAmount = random.Next(DISASTER_MINIMUM_LIMIT, DISASTER_MAXIMUM_LIMIT + 1);

                //Randomly chooses affected tiles and kills agents if they are present on that tile
                for (int i = 0; i < disasterAmount; i++)
                {
                    int randX = random.Next(MAXIMUM_ROW_LENGTH);
                    int randY = random.Next(MAXIMUM_COLUMN_LENGTH);
                    affectedTiles[random.Next(randX + 1), random.Next(randY + 1)] = true;

                    foreach (Agent a in affectedAgents)
                    {
                        if (a.Row == randX && a.Column == randY)
                            a.Die();
                    }
                }

                inUse = true;
            }
        }
    }
}
