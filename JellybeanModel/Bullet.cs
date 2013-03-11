using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    public class Bullet
    {
		private float speed;
		private int damage;
		private Agent owner;
		
		/// <summary>
		/// Gets or sets the speed.
		/// </summary>
		/// <value>
		/// The speed.
		/// </value>
        public float Speed
        {
            get { return speed;}
            set
            {
				if (value < 0)
					speed = 0;
				else
					speed = value;
            }
        }
		
		/// <summary>
		/// Gets or sets the owner.
		/// </summary>
		/// <value>
		/// The owner.
		/// </value>
        public Agent Owner
        {
            get { return owner; }
            set { owner = value; }
        }
		
		/// <summary>
		/// Gets or sets the damage.
		/// </summary>
		/// <value>
		/// The damage.
		/// </value>
        public int Damage
        {
            get { return damage; }
            set
            {
				if (value < 0)
					damage = 0;
				else
					damage = value;
            }
        }
		
		/// <summary>
		/// Initializes a new instance of the <see cref="JellybeanModel.Bullet"/> class.
		/// </summary>
		/// <param name='speed'>
		/// Speed.
		/// </param>
		/// <param name='damage'>
		/// Damage.
		/// </param>
		/// <param name='owner'>
		/// Owner.
		/// </param>
		public Bullet(float speed, int damage, Agent owner) 
		{
			Speed = speed;
			Damage = damage;
			Owner = owner;
		}
    }
}
