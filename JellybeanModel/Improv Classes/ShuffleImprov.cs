using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel.Improv_Classes
{
    class ShuffleImprov : AbstractImprov
    {
        public ShuffleImprov() 
        {
            name = "Shuffle";
            description = "Shuffle all enemy positions";
            ScoreMultiplier = 2;
            inUse = false;
            AffectedType = AgentType.Enemy;
        }

        public override void  ApplyEffect(List<AbstractEnemy> affectedEnemies)
        {
            if (!inUse) 
            {
                //Add position information of enemies to list
                List<int[,]> positionList = new List<int[,]>();
                foreach (AbstractEnemy a in affectedEnemies)
                {
                    positionList.Add(new int[,] { {a.Row}, {a.Column} });
                }

                //Randomise position List and put into stack
                Random rand = new Random();
                Stack<int[,]> randomisedPositionStack = new Stack<int[,]>();
                while (positionList.Count > 0)
                {
                    //chooses a random element from the list and adds to stack
                    int randIndex = rand.Next(positionList.Count + 1);
                    randomisedPositionStack.Push(positionList[randIndex]);

                    //deletes element from list
                    positionList.RemoveAt(randIndex);
                }
                
                //Set enemies to the new randomised positions
                foreach (AbstractEnemy e in affectedEnemies)
                {
                    int[,] tempPos = randomisedPositionStack.Pop();

                    e.Row = tempPos[0, 0];
                    e.Column = tempPos[0, 1];
                }

                inUse = true;
            }
        }
    }
}
