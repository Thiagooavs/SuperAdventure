using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {

        public int ID {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Experience { get; set; }
        public int Gold { get; set; }
        public Item ItemReward {  get; set; }

        public Quest (int id, string name, string description, int experience, int gold, Item itemReward)
        {
            ID = id;
            Name = name;
            Description = description;
            Experience = experience;
            Gold = gold;
            ItemReward = itemReward;
        }
    }
}
