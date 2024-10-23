using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LootItems
    {
        public Item Details { get; set; }
        public int PorcentRate { get; set; }
        public bool IsDefaultItem { get; set; } 

        public LootItems(Item details, int porcentrate, bool isdefaultitem) 
        {
            Details = details;
            PorcentRate = porcentrate;
            IsDefaultItem = isdefaultitem;
        }
    }
}
