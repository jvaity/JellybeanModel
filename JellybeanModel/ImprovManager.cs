using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JellybeanModel
{
    public class ImprovManager
    {
        private AbstractImprov[] activeImprovs;

        public AbstractImprov[] ActiveImprovs
        {
            get 
            {
                GenerateActiveImprovs();
                return ActiveImprovs; 
            }
        }

        public ImprovManager(int concurrentImprovs)
        {
            activeImprovs = new AbstractImprov[concurrentImprovs];
        }

        private void GenerateActiveImprovs () 
        {
            int improvAmount = Enum.GetValues(typeof(ImprovType)).Length;
            
            Random random = new Random();

            for (int i = 0; i < activeImprovs.Length; i++)
            {
                activeImprovs[i] = IntToImprov(random.Next(improvAmount));
            }
            
        }

        private AbstractImprov IntToImprov (int n)
        {
            switch (n)
            {
                case (int)ImprovType.NaturalDisaster :
                    return new NaturalDisasterImprov();
                case (int)ImprovType.SausageDog :
                    return new SausageDogImprov();
                case (int)ImprovType.Shuffle :
                    return new ShuffleImprov();
                case (int)ImprovType.Starkid :
                    return new StarkidImprov();
                case (int)ImprovType.Zombie :
                    return new ZombieImprov();
            }

            //Change default Impvrov if needed
            return new ShuffleImprov();
        }
    }
}
