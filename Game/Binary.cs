using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Drawing;

namespace Snake_Final
{
    public class Binary
    {

        public static string PATH_TILE = "./images/tile/";
        public static string PATH_SNAKE = "./images/characters/";
        public static string PATH_BACKGROUND = "./images/background/";
        public static string PATH_FOOD = "./images/food/";
        public static string PATH_TELE = "./images/tele/";

        public List<string> TilesetSprite = new List<string>();
        public List<string> MapBG = new List<string>();
        public List<string> MapTele = new List<string>();
        public List<string> Snake = new List<string>();
        public List<string> Food = new List<string>();

        public static string PATH_TILE_SAVE = "./HashImage/tile/";
        public static string PATH_SNAKE_SAVE = "./HashImage/characters/";
        public static string PATH_BACKGROUND_SAVE = "./HashImage/background/";
        public static string PATH_FOOD_SAVE = "./HashImage/food/";
        public static string PATH_TELE_SAVE = "./HashImage/tele/";


        public void load()
        {
            foreach (string file in Directory.EnumerateFiles(PATH_TILE, "*.png"))
            {
                string name = Path.GetFileName(file).ToString().Substring(0, Path.GetFileName(file).ToString().LastIndexOf(".png"));
                TilesetSprite.Add(name);
            }
            Console.WriteLine($"Tileset Loaded {TilesetSprite.Count} Sprites");

            foreach (string file in Directory.EnumerateFiles(PATH_BACKGROUND, "*.png"))
            {
                string name = Path.GetFileName(file).ToString().Substring(0, Path.GetFileName(file).ToString().LastIndexOf(".png"));
                MapBG.Add(name);
            }
            Console.WriteLine($"Background Loaded {MapBG.Count}");

            foreach (string file in Directory.EnumerateFiles(PATH_TELE, "*.png"))
            {
                string name = Path.GetFileName(file).ToString().Substring(0, Path.GetFileName(file).ToString().LastIndexOf(".png"));
                MapTele.Add(name);
            }
            Console.WriteLine($"Telegate Loaded {MapTele.Count} Tiles");

            foreach (string file in Directory.EnumerateFiles(PATH_FOOD, "*.png"))
            {
                string name = Path.GetFileName(file).ToString().Substring(0, Path.GetFileName(file).ToString().LastIndexOf(".png"));
                Food.Add(name);
            }
            Console.WriteLine($"Food Loaded {Food.Count} Tiles");

            foreach (string file in Directory.EnumerateFiles(PATH_SNAKE, "*.png"))
            {
                string name = Path.GetFileName(file).ToString().Substring(0, Path.GetFileName(file).ToString().LastIndexOf(".png"));
                Snake.Add(name);
            }
            Console.WriteLine($"Snake Loaded {Snake.Count} Tiles");
        }

        private void setup()
        {
            foreach (var item in MapBG)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open(PATH_BACKGROUND_SAVE + item + ".Snake", FileMode.OpenOrCreate);
                bf.Serialize(fs, Image.FromFile(PATH_BACKGROUND + item + ".png"));
                fs.Close();
            }

            foreach (var item in TilesetSprite)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open(PATH_TILE_SAVE + item + ".Snake", FileMode.OpenOrCreate);
                bf.Serialize(fs, Image.FromFile(PATH_TILE + item + ".png"));
                fs.Close();
            }

            foreach (var item in MapTele)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open(PATH_TELE_SAVE + item + ".Snake", FileMode.OpenOrCreate);
                bf.Serialize(fs, Image.FromFile(PATH_TELE + item + ".png"));
                fs.Close();
            }

            foreach (var item in Snake)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open(PATH_SNAKE_SAVE + item + ".Snake", FileMode.OpenOrCreate);
                bf.Serialize(fs, Image.FromFile(PATH_SNAKE + item + ".png"));
                fs.Close();
            }

            foreach (var item in Food)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open(PATH_FOOD_SAVE + item + ".Snake", FileMode.OpenOrCreate);
                bf.Serialize(fs, Image.FromFile(PATH_FOOD + item + ".png"));
                fs.Close();

            }
        }

        private void Show()
        {
            foreach (string file in Directory.EnumerateFiles(PATH_TILE_SAVE, "*.Snake"))
            {
                string name = Path.GetFileName(file);
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open(PATH_TILE_SAVE + name, FileMode.OpenOrCreate);
                Image img = (Image)bf.Deserialize(fs);
                fs.Close();

                img.Save(PATH_TILE_SAVE + name + ".png");
            }
            Console.WriteLine($"Tileset Loaded {TilesetSprite.Count} Sprites");

            foreach (string file in Directory.EnumerateFiles(PATH_BACKGROUND_SAVE, "*.Snake"))
            {
                string name = Path.GetFileName(file);
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open(PATH_BACKGROUND_SAVE + name, FileMode.OpenOrCreate);
                Image img = (Image)bf.Deserialize(fs);
                fs.Close();

                img.Save(PATH_BACKGROUND_SAVE + name + ".png");
            }
            Console.WriteLine($"Background Loaded {MapBG.Count}");

            foreach (string file in Directory.EnumerateFiles(PATH_TELE_SAVE, "*.Snake"))
            {
                string name = Path.GetFileName(file);
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open(PATH_TELE_SAVE + name, FileMode.OpenOrCreate);
                Image img = (Image)bf.Deserialize(fs);
                fs.Close();

                img.Save(PATH_TELE_SAVE + name + ".png");
            }
            Console.WriteLine($"Telegate Loaded {MapTele.Count} Tiles");

            foreach (string file in Directory.EnumerateFiles(PATH_FOOD_SAVE, "*.Snake"))
            {
                string name = Path.GetFileName(file);
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open(PATH_FOOD_SAVE + name, FileMode.OpenOrCreate);
                Image img = (Image)bf.Deserialize(fs);
                fs.Close();

                img.Save(PATH_FOOD_SAVE + name + ".png");
            }
            Console.WriteLine($"Food Loaded {Food.Count} Tiles");

            foreach (string file in Directory.EnumerateFiles(PATH_SNAKE_SAVE, "*.Snake"))
            {
                string name = Path.GetFileName(file);
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open(PATH_SNAKE_SAVE + name, FileMode.OpenOrCreate);
                Image img = (Image)bf.Deserialize(fs);
                fs.Close();

                img.Save(PATH_SNAKE_SAVE + name + ".png");
            }
            Console.WriteLine($"Snake Loaded {Snake.Count} Tiles");
        }
        public static Image ConvertImage(string Path)
        {
            Image img;
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open(Path, FileMode.OpenOrCreate);
            img = (Image)bf.Deserialize(fs);
            fs.Close();

            return img;
        }

    }
}
