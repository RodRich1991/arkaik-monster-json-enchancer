using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkaik_Monster_Json_Enchancer
{
    public class MapData
    {
        public string Map { get; set; }
        public List<string> Name { get; set; }
        public BGMData BGM { get; set; }
        public FlagsData Flags { get; set; }
        public CollectionData Collection { get; set; }
        public List<SmartCamData> SmartCam { get; set; }
        public List<MobSpawn>? Mobs { get; set; }

        public void SetMobs(List<MonsterSpawn> spawns)
        {
            Mobs = spawns?
                .Where(spawn => spawn.Map == Map)
                .GroupBy(spawn => spawn.Id)
                .Select(group => new MobSpawn
                {
                    Id = group.Key,
                    Qty = group.Sum(spawn => spawn.Qty) 
                })
                .ToList();
        }
    }

    public class BGMData
    {
        public string Day { get; set; }
        public string Afternoon { get; set; }
        public string Night { get; set; }
    }

    public class FlagsData
    {
        public bool? Indoor { get; set; }
        public bool? NoNight { get; set; }
        public bool? NoRain { get; set; }
        public bool? City { get; set; }
        public bool? NoSnow { get; set; }
        public bool? Blind { get; set; }
    }

    public class CollectionData
    {
        public List<string> Effect { get; set; }
        public List<int> Items { get; set; }
    }

    public class SmartCamData
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Check { get; set; }
    }

    public class MobSpawn
    {
        public int Id { get; set; }
        public int Qty { get; set; }
    }
}
