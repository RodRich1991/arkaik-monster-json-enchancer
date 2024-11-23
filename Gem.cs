using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkaik_Monster_Json_Enchancer
{
    public class Gem
    {
        public Header Header { get; set; }
        public List<GemEntry> Body { get; set; }
    }

    public class Header
    {
        public string Type { get; set; }     // Tipo do banco de dados
        public int Version { get; set; }    // Versão do banco de dados
    }

    public class GemEntry
    {
        public int Gem { get; set; }              // Identificador da gem
        public string Desc { get; set; }          // Descrição (nome da gem)
        public int Monster { get; set; }          // Identificador do monstro associado
        public bool AnnounceDrop { get; set; }    // Indica se o drop será anunciado
        public int Chance { get; set; }           // Chance de drop (em base percentual)
        public string Script { get; set; }        // Script associado à gem
        public string? EquipScript { get; set; }
        public string? UnEquipScript { get; set; }
    }
}
