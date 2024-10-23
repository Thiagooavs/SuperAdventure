using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public List<InventoryItems> Inventory {  get; set; }
        public List<PlayerQuest> Quest { get; set; }  
        
        
        

      
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        public Player( int currenthitpoints, int maximunhitpoints, int gold, int experiencepoints, int levels) : base( currenthitpoints, maximunhitpoints) 
        {
            Gold = gold;
            ExperiencePoints = experiencepoints;
            Level = levels;
            Inventory = new List<InventoryItems>();
            Quest = new List<PlayerQuest>();

        }

    }
}
