using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature
    {
        public int CurrentHitPoints { get; set; }
        public int MaximunHitPoints { get; set; }

        public LivingCreature( int currenthitpoints, int maximunhitpoints) 
        {
            CurrentHitPoints = currenthitpoints;
            MaximunHitPoints = maximunhitpoints;
        } 
    }
}
