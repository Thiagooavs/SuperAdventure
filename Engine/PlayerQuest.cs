using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class PlayerQuest
    {
        public Quest Details { get; set; }
        public bool QuestSolve { get; set; }
        public PlayerQuest(Quest details ) 
        {
            Details = details;
            QuestSolve = false;
        }
    }
}
