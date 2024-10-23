using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descripition { get; set; }


        public Item ItemRequiredToEnter { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToWest { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }

        public Location(int id, string name, string description, Item itemrequired = null, Quest questAvailible = null, Monster monsterliving = null) 
        { 
            ID = id;
            Name = name;    
            Descripition = description;
            ItemRequiredToEnter = itemrequired;
            QuestAvailableHere = questAvailible;
            MonsterLivingHere = monsterliving;
               
        }
    }

    
}
