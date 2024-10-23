using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {

        public int ID {  get; set; }
        public string Name { get; set; }

        public int MaximunDamage {  get; set; }

        public int Experience { get; set; }
        public int Gold {  get; set; }

        public Monster(int iD, string name, int maximunDamage, int experience, int gold, int currenthitpoints, int maximunhitpoints) : base (currenthitpoints, maximunhitpoints)
        {
            ID = iD;
            Name = name;
            MaximunDamage = maximunDamage;
            Experience = experience;
            Gold = gold;
        }
    }
}
