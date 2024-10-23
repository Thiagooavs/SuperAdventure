using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item
    {

        public int HealPoints { get; set; }

        public HealingPotion (int id, string name, string pluralname, int healPoints) : base(id, name, pluralname)
        {
            HealPoints = healPoints;
        }
    }
}
