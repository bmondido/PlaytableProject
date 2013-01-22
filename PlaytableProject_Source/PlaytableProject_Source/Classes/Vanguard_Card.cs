using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaytableProject_Source.Classes
{

    class Vanguard_Card
    {
        public string name { get; }
        public int power { get; }
        public string critcal  { get; }
        public Nation nation { get; }
        public Clan clan { get; }
        public Race race { get; }
        public Unit_Type uType { get; }
        public string box_Set { get; }
        public int card_Number { get; }
        public int grade { get; }
        public Skill skill { get; }
        public string flavor_Text { get; }
        public string rule_Text { get; }
        public Trigger_Type tType { get; }
        public Rarity rarity { get; }
    }
}
