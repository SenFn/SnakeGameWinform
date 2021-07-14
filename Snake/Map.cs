using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Map
    {
        public List<string> TilesetSprite = new List<string>();
        public List<string> MapBG = new List<string>();
        public List<string> MapTele = new List<string>();

        [Serializable]
        public struct MapStruct
        {
            public string Name;
            public string BackGround;
            public List<Block> Block;
            public List<TeleGate> TeleGate;
        }

        [Serializable]
        public struct Block { public int x; public int y; }

        [Serializable]
        public struct TeleGate {
            public List<Tele> TelePoint;
            public Image TileSet;
            public int DrawX;
            public int DrawY;
        }

        [Serializable]
        public struct Tele {
            public int InX;
            public int InY;
            public int OutX;
            public int OutY;
        }


        public static MapStruct[] Maps = new MapStruct[Source.MAX_MAP];
        

        public Map()
        {
            loadTilesets();
            loadBG();
            loadTele();
            CheckMaps();
            LoadMap();
        }

        public void loadTilesets()
        {

            List<string> nameFile = new List<string>();
            foreach (string file in Directory.EnumerateFiles(Source.PATH_TILE, "*.png"))
            {
                string name = Path.GetFileName(file);
                TilesetSprite.Add(Source.PATH_TILE + name);
            }
            Console.WriteLine($"Tileset Loaded {TilesetSprite.Count} Sprites");
        }

        public void loadBG()
        {

            List<string> nameFile = new List<string>();
            foreach (string file in Directory.EnumerateFiles(Source.PATH_BACKGROUND, "*.png"))
            {
                string name = Path.GetFileName(file);
                MapBG.Add(Source.PATH_BACKGROUND + name);
            }
            Console.WriteLine($"Background Loaded {MapBG.Count}");
        }

        public void loadTele()
        {

            List<string> nameFile = new List<string>();
            foreach (string file in Directory.EnumerateFiles(Source.PATH_TELE, "*.png"))
            {
                string name = Path.GetFileName(file);
                MapTele.Add(Source.PATH_TELE + name);
            }
            Console.WriteLine($"Telegate Loaded {MapTele.Count} Tiles");
        }

        public void spawn(System.Windows.Forms.PaintEventArgs e, int mapNum)
        {
            Rectangle cropBg = new Rectangle(-2, 0, Source.size * Source.N, Source.size * Source.M);
            e.Graphics.DrawImage(Image.FromFile(Maps[mapNum].BackGround), cropBg, 0, 0, 960, 720, GraphicsUnit.Pixel);


            for (int i = 0; i < Maps[mapNum].TeleGate.Count; i++)
            {
                if (Maps[mapNum].TeleGate[i].TileSet == null) continue;
                Rectangle cropTele = new Rectangle(Maps[mapNum].TeleGate[i].DrawX * Source.size, Maps[mapNum].TeleGate[i].DrawY * Source.size, Maps[mapNum].TeleGate[i].TileSet.Width, Maps[mapNum].TeleGate[i].TileSet.Height);
                e.Graphics.DrawImage(Maps[mapNum].TeleGate[i].TileSet, cropTele, 0, 0, Maps[mapNum].TeleGate[i].TileSet.Width, Maps[mapNum].TeleGate[i].TileSet.Height, GraphicsUnit.Pixel);                
            }

            for (int i = 0; i < Maps[mapNum].Block.Count; i++)
            {
                Rectangle crop = new Rectangle(Maps[mapNum].Block[i].x * Source.size, Maps[mapNum].Block[i].y * Source.size, Source.size, Source.size);
                e.Graphics.DrawImage(Source.block, crop, 0, 0, Source.size, Source.size, GraphicsUnit.Pixel);
            }

        }


        public void CheckMaps()
        {
            Console.WriteLine("Check Maps");

            Array.Resize(ref Maps, Source.MAX_MAP);

            for (int i = 0; i < Source.MAX_MAP; i++)
            {
                if (!File.Exists(Source.PATH_MAP + "map" + i + ".map"))
                {
                    Console.WriteLine("Map missing " + i);
                    ClearMap(i);
                    SaveMap(i);
                }
            }
        }

        public void ClearMap(int mapNum)
        {
            Maps[mapNum].BackGround = MapBG[0];
            Maps[mapNum].Name = "New Map";
            Maps[mapNum].Block = new List<Block>();
            Maps[mapNum].TeleGate = new List<TeleGate>();
            SaveMap(mapNum);
        }

        public static void SaveMap(int mapNum)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open(Source.PATH_MAP + "map" + mapNum + ".map", FileMode.OpenOrCreate);
            bf.Serialize(fs, (MapStruct)Maps[mapNum]);
            fs.Close();
        }

        public void LoadMap()
        {
            Console.WriteLine("Load Maps");

            for (int i = 0; i < Source.MAX_MAP; i++)
            {
                LoadMap(i);
            }

            Console.WriteLine("Maps Loaded");
        }

        public static void LoadMap(int mapNum)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open(Source.PATH_MAP + "map" + mapNum + ".map", FileMode.OpenOrCreate);
            Maps[mapNum] = (MapStruct)bf.Deserialize(fs);
            fs.Close();
        }

    }
}
