using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    public abstract class Agent
    {
        protected AgentState state;
        protected int maxHealth;
        protected int health;
        protected int attackDamage;
        protected float cooldownTime;
        protected int row, column;

        #region Properties
        /// <summary>
        /// Determines the state of the current Agent: Alive, Dead or Sleeping
        /// </summary>
        public AgentState State
        {
            get { return state; }
            set { state = value; }
        }

        /// <summary>
        /// Gets or sets the amount of health the Agent has. Cannot go above initial set maximum.
        /// If health is set below 0 then state automatically changes to AgentState.Dead
        /// </summary>
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value > maxHealth)
                    health = maxHealth;
                else if (value <= 0)
                {
                    health = 0;
                    state = AgentState.Dead;
                }
                else
                    health = value;
            }
        }

        /// <summary>
        /// Determines the attack damage of the Agent
        /// </summary>
        public int AttackDamage
        {
            get { return attackDamage; }
            set { attackDamage = value; }
        }

        /// <summary>
        /// Determines how long it takes for the Agent to be called again
        /// </summary>
        public float CooldownTime
        {
            get { return cooldownTime; }
            set 
            {
                if (value < 0)
                    cooldownTime = 0f;
                else
                    cooldownTime = value;
            }
        }

        /// <summary>
        /// Gets and Sets the Row that the Agent is on
        /// </summary>
        public int Row
        {
            get { return row; }
            set 
            {
                if (value < 0)
                    row = 0;
                else
                    row = value;
            }
        }

        /// <summary>
        /// Gets and Sets the Column that the Agent is on
        /// </summary>
        public int Column
        {
            get { return column; }
            set
            {
                if (value < 0)
                    column = 0;
                else
                    column = value;
            }
        }
        #endregion

        public Agent()
        {

        }

        public Agent(int maxHealth, int attackDamage, float cooldown, int row, int column)
        {
            state = AgentState.Alive;
            this.maxHealth = maxHealth;
            Health = maxHealth;
            AttackDamage = attackDamage;
            CooldownTime = cooldown;
            Row = row;
            Column = column;
        }

        /// <summary>
        /// Performs the main attacking action of the agent.
        /// </summary>
        public abstract void Attack()
        {
                      
        }

        /// <summary>
        /// Changes state to AgentState.Dead if the Agent is alive.
        /// </summary>
        public void Die()
        {
            if (state != AgentState.Dead)
                state = AgentState.Dead;
        }
    }
}
