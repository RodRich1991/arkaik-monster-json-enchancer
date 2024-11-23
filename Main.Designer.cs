namespace Arkaik_Monster_Json_Enchancer
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Arquivos = new GroupBox();
            Btn_MonstersFolder = new Button();
            Txb_MonstersFolder = new TextBox();
            Lbl_MonstersFolder = new Label();
            Btn_MapsFile = new Button();
            Txb_MapsFile = new TextBox();
            Lbl_MapsFile = new Label();
            Btn_GemFile = new Button();
            Txb_GemFile = new TextBox();
            Lbl_GemFile = new Label();
            Btn_MonsterJson = new Button();
            Txb_MonsterPath = new TextBox();
            Lbl_MonsterPath = new Label();
            Btn_Start = new Button();
            Btn_Save = new Button();
            Tt_monster = new ToolTip(components);
            Arquivos.SuspendLayout();
            SuspendLayout();
            // 
            // Arquivos
            // 
            Arquivos.Controls.Add(Btn_MonstersFolder);
            Arquivos.Controls.Add(Txb_MonstersFolder);
            Arquivos.Controls.Add(Lbl_MonstersFolder);
            Arquivos.Controls.Add(Btn_MapsFile);
            Arquivos.Controls.Add(Txb_MapsFile);
            Arquivos.Controls.Add(Lbl_MapsFile);
            Arquivos.Controls.Add(Btn_GemFile);
            Arquivos.Controls.Add(Txb_GemFile);
            Arquivos.Controls.Add(Lbl_GemFile);
            Arquivos.Controls.Add(Btn_MonsterJson);
            Arquivos.Controls.Add(Txb_MonsterPath);
            Arquivos.Controls.Add(Lbl_MonsterPath);
            Arquivos.Location = new Point(12, 12);
            Arquivos.Name = "Arquivos";
            Arquivos.Size = new Size(864, 221);
            Arquivos.TabIndex = 0;
            Arquivos.TabStop = false;
            Arquivos.Text = "Arquivos";
            // 
            // Btn_MonstersFolder
            // 
            Btn_MonstersFolder.BackgroundImage = Properties.Resources.folder_icon;
            Btn_MonstersFolder.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_MonstersFolder.Location = new Point(793, 178);
            Btn_MonstersFolder.Name = "Btn_MonstersFolder";
            Btn_MonstersFolder.Size = new Size(27, 27);
            Btn_MonstersFolder.TabIndex = 11;
            Tt_monster.SetToolTip(Btn_MonstersFolder, "Procure pela pasta ROZERO-SERVER-GH\\script\\monsters");
            Btn_MonstersFolder.UseVisualStyleBackColor = true;
            Btn_MonstersFolder.Click += Btn_MonstersFolder_Click;
            // 
            // Txb_MonstersFolder
            // 
            Txb_MonstersFolder.Location = new Point(11, 178);
            Txb_MonstersFolder.Name = "Txb_MonstersFolder";
            Txb_MonstersFolder.ReadOnly = true;
            Txb_MonstersFolder.Size = new Size(776, 23);
            Txb_MonstersFolder.TabIndex = 10;
            // 
            // Lbl_MonstersFolder
            // 
            Lbl_MonstersFolder.AutoSize = true;
            Lbl_MonstersFolder.Location = new Point(11, 160);
            Lbl_MonstersFolder.Name = "Lbl_MonstersFolder";
            Lbl_MonstersFolder.Size = new Size(172, 15);
            Lbl_MonstersFolder.TabIndex = 9;
            Lbl_MonstersFolder.Text = "Monster Summon Script Folder";
            Tt_monster.SetToolTip(Lbl_MonstersFolder, "Procure pela pasta ROZERO-SERVER-GH\\script\\monsters");
            // 
            // Btn_MapsFile
            // 
            Btn_MapsFile.BackgroundImage = Properties.Resources.folder_icon;
            Btn_MapsFile.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_MapsFile.Location = new Point(793, 90);
            Btn_MapsFile.Name = "Btn_MapsFile";
            Btn_MapsFile.Size = new Size(27, 27);
            Btn_MapsFile.TabIndex = 8;
            Tt_monster.SetToolTip(Btn_MapsFile, "Procure pelo arquivo ROZERO-CLIENT-GH\\GameBO\\JsonDatabase\\Maps.json");
            Btn_MapsFile.UseVisualStyleBackColor = true;
            Btn_MapsFile.Click += Btn_MapsFile_Click;
            // 
            // Txb_MapsFile
            // 
            Txb_MapsFile.Location = new Point(11, 90);
            Txb_MapsFile.Name = "Txb_MapsFile";
            Txb_MapsFile.ReadOnly = true;
            Txb_MapsFile.Size = new Size(776, 23);
            Txb_MapsFile.TabIndex = 7;
            // 
            // Lbl_MapsFile
            // 
            Lbl_MapsFile.AutoSize = true;
            Lbl_MapsFile.Location = new Point(11, 72);
            Lbl_MapsFile.Name = "Lbl_MapsFile";
            Lbl_MapsFile.Size = new Size(86, 15);
            Lbl_MapsFile.TabIndex = 6;
            Lbl_MapsFile.Text = "Maps JSON file";
            Tt_monster.SetToolTip(Lbl_MapsFile, "Procure pelo arquivo ROZERO-CLIENT-GH\\GameBO\\JsonDatabase\\Maps.json");
            // 
            // Btn_GemFile
            // 
            Btn_GemFile.BackgroundImage = Properties.Resources.folder_icon;
            Btn_GemFile.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_GemFile.Location = new Point(793, 134);
            Btn_GemFile.Name = "Btn_GemFile";
            Btn_GemFile.Size = new Size(27, 27);
            Btn_GemFile.TabIndex = 5;
            Tt_monster.SetToolTip(Btn_GemFile, "Procure pelo arquivo ROZERO-SERVER-GH\\db\\gems_rozero.yml");
            Btn_GemFile.UseVisualStyleBackColor = true;
            Btn_GemFile.Click += Btn_GemFile_Click;
            // 
            // Txb_GemFile
            // 
            Txb_GemFile.Location = new Point(11, 134);
            Txb_GemFile.Name = "Txb_GemFile";
            Txb_GemFile.ReadOnly = true;
            Txb_GemFile.Size = new Size(776, 23);
            Txb_GemFile.TabIndex = 4;
            // 
            // Lbl_GemFile
            // 
            Lbl_GemFile.AutoSize = true;
            Lbl_GemFile.Location = new Point(11, 116);
            Lbl_GemFile.Name = "Lbl_GemFile";
            Lbl_GemFile.Size = new Size(78, 15);
            Lbl_GemFile.TabIndex = 3;
            Lbl_GemFile.Text = "Gem YML file";
            Tt_monster.SetToolTip(Lbl_GemFile, "Procure pelo arquivo ROZERO-SERVER-GH\\db\\gems_rozero.yml");
            // 
            // Btn_MonsterJson
            // 
            Btn_MonsterJson.BackgroundImage = Properties.Resources.folder_icon;
            Btn_MonsterJson.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_MonsterJson.Location = new Point(793, 46);
            Btn_MonsterJson.Name = "Btn_MonsterJson";
            Btn_MonsterJson.Size = new Size(27, 27);
            Btn_MonsterJson.TabIndex = 2;
            Tt_monster.SetToolTip(Btn_MonsterJson, "Procure pelo arquivo ROZERO-CLIENT-GH\\GameBO\\JsonDatabase\\Monsers.json");
            Btn_MonsterJson.UseVisualStyleBackColor = true;
            Btn_MonsterJson.Click += Btn_MonstersFile_Click;
            // 
            // Txb_MonsterPath
            // 
            Txb_MonsterPath.Location = new Point(11, 46);
            Txb_MonsterPath.Name = "Txb_MonsterPath";
            Txb_MonsterPath.ReadOnly = true;
            Txb_MonsterPath.Size = new Size(776, 23);
            Txb_MonsterPath.TabIndex = 1;
            // 
            // Lbl_MonsterPath
            // 
            Lbl_MonsterPath.AutoSize = true;
            Lbl_MonsterPath.Location = new Point(11, 28);
            Lbl_MonsterPath.Name = "Lbl_MonsterPath";
            Lbl_MonsterPath.Size = new Size(101, 15);
            Lbl_MonsterPath.TabIndex = 0;
            Lbl_MonsterPath.Text = "Monster JSON file";
            Tt_monster.SetToolTip(Lbl_MonsterPath, "Procure pelo arquivo ROZERO-CLIENT-GH\\GameBO\\JsonDatabase\\Monsers.json");
            // 
            // Btn_Start
            // 
            Btn_Start.Enabled = false;
            Btn_Start.Image = Properties.Resources.play_20;
            Btn_Start.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Start.Location = new Point(34, 250);
            Btn_Start.Name = "Btn_Start";
            Btn_Start.Size = new Size(100, 44);
            Btn_Start.TabIndex = 1;
            Btn_Start.Text = "Start";
            Btn_Start.UseVisualStyleBackColor = true;
            Btn_Start.Click += Btn_Start_Click;
            // 
            // Btn_Save
            // 
            Btn_Save.Enabled = false;
            Btn_Save.Image = Properties.Resources.Save_icon_20png;
            Btn_Save.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Save.Location = new Point(734, 250);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(98, 44);
            Btn_Save.TabIndex = 2;
            Btn_Save.Text = "Save";
            Btn_Save.UseVisualStyleBackColor = true;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(888, 306);
            Controls.Add(Btn_Save);
            Controls.Add(Btn_Start);
            Controls.Add(Arquivos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            Text = "Arkaik Monster JSON Enchancer";
            Arquivos.ResumeLayout(false);
            Arquivos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Arquivos;
        private Label Lbl_MonsterPath;
        private TextBox Txb_MonsterPath;
        private Button Btn_MonsterJson;
        private Button Btn_GemFile;
        private TextBox Txb_GemFile;
        public Label Lbl_GemFile;
        private Button Btn_MapsFile;
        private TextBox Txb_MapsFile;
        public Label Lbl_MapsFile;
        private Button Btn_MonstersFolder;
        private TextBox Txb_MonstersFolder;
        public Label Lbl_MonstersFolder;
        private Button Btn_Start;
        private Button Btn_Save;
        private ToolTip Tt_monster;
    }
}
