using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    public interface Improv
    {
        int ScoreMultiplier
        {
            get;
            set;
        }

        string Description
        {
            get;
        }

        string Name
        {
            get;
        }

        int InUse
        {
            get;
            set;
        }

        void ApplyEffect(List<Agent> affectedAgents);

        void RemoveEffect();
    }
}
