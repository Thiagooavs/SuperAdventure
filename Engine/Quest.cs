﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }


        public int ID {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Experience { get; set; }
        public int Gold { get; set; }
        public Item RewardItem {  get; set; }

        public Quest (int id, string name, string description, int experience, int gold )
        {
            ID = id;
            Name = name;
            Description = description;
            Experience = experience;
            Gold = gold;            
            QuestCompletionItems = new List<QuestCompletionItem> ();
        }
    }
}
