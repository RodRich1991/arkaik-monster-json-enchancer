
using System.Text.Json;

namespace Arkaik_Monster_Json_Enchancer
{
    public partial class Main : Form
    {
        private const string MONSTERS_FILE = "Monsters.json";
        private const string MAPS_FILE = "Maps.json";
        private ConverterService Service { get; set; }

        private bool MonsterIsValid { get; set; } = false;
        private bool MapsIsValid { get; set; } = false;
        private bool GemIsValid { get; set; } = false;
        private bool SpawnIsValid { get; set; } = false;
        private bool EnabledProcess { get; set; } = false;
        private bool EnabledSave { get; set; } = false;

        private List<Monster> Monsters { get; set; }
        private List<MapData> MapsData { get; set; }
        private List<GemEntry> Gems { get; set; }
        private List<MonsterSpawn> MonstersSpawn { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void ValidateState()
        {

            MonsterIsValid = Monsters?.Any() ?? false;
            MapsIsValid = MapsData?.Any() ?? false;
            GemIsValid = Gems?.Any() ?? false;
            SpawnIsValid = MonstersSpawn?.Any() ?? false;

            EnabledProcess = MonsterIsValid && MapsIsValid && GemIsValid && SpawnIsValid;

            Btn_Save.Enabled = EnabledSave && EnabledProcess;
            Btn_Start.Enabled = EnabledProcess && !EnabledSave;
        }

        private ConverterService Converter()
        {
            if (Service == null)
                Service = new ConverterService();

            return Service;
        }

        private void Btn_MonstersFile_Click(object sender, EventArgs e)
        {
            string monstersPath = PickFile(MONSTERS_FILE);
            Txb_MonsterPath.Text = monstersPath;
            Monsters = Converter().ExtractObjects<Monster>(monstersPath);
            ValidateState();
        }

        private void Btn_MapsFile_Click(object sender, EventArgs e)
        {
            string mapsPath = PickFile(MAPS_FILE);
            Txb_MapsFile.Text = mapsPath;
            MapsData = Converter().ExtractObjects<MapData>(mapsPath);
            ValidateState();
        }

        private void Btn_GemFile_Click(object sender, EventArgs e)
        {
            string gemsPath = PickFile("gems_rozero.yml");
            Txb_GemFile.Text = gemsPath;
            Gems = Converter().ExtractObjectYaml(gemsPath);
            ValidateState();
        }

        private void Btn_MonstersFolder_Click(object sender, EventArgs e)
        {
            string monstersFolderPath = PickFolder();
            Txb_MonstersFolder.Text = monstersFolderPath;
            MonstersSpawn = Converter().ExtractMapSpawn(monstersFolderPath);
            ValidateState();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Btn_Start.Enabled = false;
            Monsters.ForEach(monster =>
            {
                monster.SetGem(Gems);
                monster.SetMaps(MonstersSpawn);
            });
            MapsData.ForEach(map =>
            {
                map.SetMobs(MonstersSpawn);
            });
            EnabledSave = true;
            ValidateState();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (SaveJson("Monsters", Monsters) && SaveJson("Maps", MapsData))
            {
                MessageBox.Show("Arquivos exportados com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnabledSave = false;
            };
            ValidateState();
        }

        private bool SaveJson<T>(string name, List<T> list)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Arquivo JSON (*.json)|*.json", // Define o filtro de extensão do arquivo
                Title = $"Salvar {name} JSON",
                FileName = $"{name}.json" // Nome inicial do arquivo
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    string json = JsonSerializer.Serialize(list, new JsonSerializerOptions { 
                        WriteIndented = true,
                        Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
                    });
                    File.WriteAllText(filePath, json);
                    return true;
                } catch
                {
                    MessageBox.Show($"Falha ao tentar escrever {name}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private string PickFile(string fileName)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = $"{fileName}|{fileName}";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Verifica se o arquivo selecionado corresponde ao esperado
                string selectedFile = ofd.FileName;

                if (!Path.GetFileName(selectedFile).Equals(fileName, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Arquivo inválido! Selecione o arquivo '{fileName}'.", "Erro");
                    return null;
                }

                return selectedFile;
            }
            return null;
        }

        private string PickFolder()
        {
            var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            var selectedPath = fbd.SelectedPath;
            return result == DialogResult.OK && !string.IsNullOrWhiteSpace(selectedPath)
                ? selectedPath
                : null;
        }
    }
}
