using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Source
    {
        public static string PATH_TILE = "./images/tile/";
        public static string PATH_MAP = "./images/map/";
        public static string PATH_BACKGROUND = "./images/background/";
        public static string PATH_FOOD = "./images/food/";
        public static string PATH_TELE = "./images/tele/";

        public const int N = 24;
        public const int M = 18;
        public const int size = 40;
        public const int MAX_MAP = 5;

        
        public static Image[] food = new Image[4]
        {
            Image.FromFile("./images/food/1.png"),
            Image.FromFile("./images/food/2.png"),
            Image.FromFile("./images/food/3.png"),
            Image.FromFile("./images/food/4.png")
        };

        public static Image block = Image.FromFile("./images/tile/block.png");



        public static Image snakeBody = Image.FromFile("./images/characters/body.png");
        public static Image[] Head = new Image[4]
        {
            Image.FromFile("./images/characters/h_down.png"),
            Image.FromFile("./images/characters/h_left.png"),
            Image.FromFile("./images/characters/h_right.png"),
            Image.FromFile("./images/characters/h_up.png")
        };

    }
}
