using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;

namespace Arkaik_Monster_Json_Enchancer
{
    internal class ConverterService
    {
        public List<T> ExtractObjects<T>(string path)
        {
            if (string.IsNullOrEmpty(path))
                return null;

            string json = File.ReadAllText(path);
            try
            {
                return JsonSerializer.Deserialize<List<T>>(json);
            }
            catch
            {
                MessageBox.Show("Falha ao tentar ler os dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public List<GemEntry> ExtractObjectYaml(string path)
        {
            if (string.IsNullOrEmpty(path))
                return null;

            try
            {
                var deserializer = new DeserializerBuilder()
                .WithNamingConvention(PascalCaseNamingConvention.Instance) // Converte nomes de propriedades
                .Build();

                string ymlString = File.ReadAllText(path);
                // Desserializa o YAML em uma lista de objetos Monster
                Gem gemFile = deserializer.Deserialize<Gem>(ymlString);
                return gemFile.Body;
            }
            catch
            {
                MessageBox.Show("Falha ao tentar ler os dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public List<MonsterSpawn> ExtractMapSpawn(string path)
        {
            if (string.IsNullOrEmpty(path))
                return null;

            string spawnPattern = @"^(?<Map>[^,]+),\d+(?:,\d+)*\s+monster\s+(?<Name>[^,]+)\s+(?<Id>\d+),(?<Qty>\d+),(?<Delay>\d+)(?:,\d+)*,";
            var monsterSpawns = new List<MonsterSpawn>();

            try
            {
                foreach (string file in Directory.GetFiles(path, "*.txt"))
                {
                    Console.WriteLine($"Processando arquivo: {Path.GetFileName(file)}");

                    // Lê todas as linhas do arquivo
                    var linhas = File.ReadAllLines(file);

                    foreach (var linha in linhas)
                    {
                        // Ignora linhas que não correspondem ao formato
                        var match = Regex.Match(linha, spawnPattern);
                        if (!match.Success) continue;

                        // Extrai os dados
                        var monster = new MonsterSpawn
                        {
                            Map = match.Groups["Map"].Value,
                            Name = match.Groups["Name"].Value,
                            Id = int.Parse(match.Groups["Id"].Value),
                            Qty = int.Parse(match.Groups["Qty"].Value),
                            Delay = int.Parse(match.Groups["Delay"].Value)
                        };

                        // Adiciona aos resultados
                        monsterSpawns.Add(monster);
                    }
                }
                return monsterSpawns;
            }
            catch
            {
                MessageBox.Show("Falha ao tentar ler os dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
    }
}
