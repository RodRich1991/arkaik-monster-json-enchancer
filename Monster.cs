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
        public int? Gem { get; set; }
        public List<string>? Maps { get; set; }

        public void SetGem(List<GemEntry> Gems)
        {
            Gem = Gems?.Find(gem => gem.Monster == Id)?.Gem;
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
}
