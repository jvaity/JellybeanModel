using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    public abstract class AbstractImprov : Improv
    {
        protected string name, description;
        protected int scoreMultiplier;
        protected bool inUse;
        protected List<Agent> affectedAgents;

        protected enum AgentType { None, All, Turret, Enemy }
        protected AgentType affectedType; 

        #region Properties
        public int ScoreMultiplier
        {
            get
            {
                return scoreMultiplier;
            }
            set
            {
                scoreMultiplier = value;
            }
        }

        public string Description
        {
            get { return description; }
        }

        public string Name
        {
            get { return name; }
        }

        public bool InUse
        {
            get { return inUse; }
        }

        public AgentType AffectedType
        {
            get
            {
                return affectedType;
            }
            set
            {
                affectedType = value;
            }
        }
        #endregion

        public AbstractImprov()
        {
            name = "Blank";
            description = "No Effect";
            ScoreMultiplier = 1;
            inUse = false;
            AffectedType = AgentType.None;
        }

        public AbstractImprov(string name, string description, int scoreMultiplier, AgentType affectedType)
        {
            this.name = name;
            this.description = description;
            this.ScoreMultiplier = scoreMultiplier;
            this.AffectedType = affectedType;

            inUse = false;
        }

        public virtual void ApplyEffect(List<Agent> affectedAgents)
        {
            if (!inUse)
            {
                inUse = true;
            }
        }

        public virtual void RemoveEffect()
        {
            if (inUse)
            {
                inUse = false;
            }
        }
    }
}
