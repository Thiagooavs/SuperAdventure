using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
   
        public int MinimunHitPoints { get; set; }
        public int MaximunHitPoints { get; set; }

        public Weapon( int id, string name, string pluralname, int maximunhitpoints, int minimunhitpoints ) : base(id, name, pluralname) 
        {
            MaximunHitPoints = maximunhitpoints;
            MinimunHitPoints= minimunhitpoints;

        }
    }
}
