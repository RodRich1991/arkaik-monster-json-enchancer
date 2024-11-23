using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkaik_Monster_Json_Enchancer
{
    internal class Monster
    {
        public int Id { get; set; }
        public int Card { get; set; }
        public List<string> Name { get; set; }
        public int Level { get; set; }
        public bool? MVP { get; set; }
        public MonsterGem? Gem { get; set; }
        public List<string>? Maps { get; set; }

        public void SetGem(List<GemEntry> Gems)
        {
           var gem = Gems?.Find(gem => gem.Monster == Id);
            if (gem != null)
                Gem = new MonsterGem { Id = gem.Gem, Chance = gem.Chance };
        }

        public void SetMaps(List<MonsterSpawn> spawns)
        {
            Maps = spawns?
                .Where(spawn => spawn.Id == Id)
                .Select(spawn => spawn.Map)
                .Distinct()
                .ToList();
        }
    }

    internal class MonsterGem
    {
        public int Id { get; set; }
        public int Chance { get; set; }
    }
}
