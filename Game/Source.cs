using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Final
{
    class Source
    {
        public static string PATH_TILE = "./images/tile/";
        public static string PATH_MAP = "./images/map/";
        public static string PATH_BACKGROUND = "./images/background/";
        public static string PATH_FOOD = "./images/food/";
        public static string PATH_TELE = "./images/tele/";

        public const int N = 18;
        public const int M = 15;
        public const int size = 40;
        public const int MAX_MAP = 5;

        
        public static Image[] food = new Image[4]
        {
            Binary.ConvertImage("./images/food/1.Snake"),
            Binary.ConvertImage("./images/food/2.Snake"),
            Binary.ConvertImage("./images/food/3.Snake"),
            Binary.ConvertImage("./images/food/4.Snake")
        };

        


        //public static Image snakeBody = Binary.ConvertImage("./images/characters/up.Snake");
        public static Image[] snakeBody = new Image[4]
        {
            Binary.ConvertImage("./images/characters/down.Snake"),
            Binary.ConvertImage("./images/characters/left.Snake"),
            Binary.ConvertImage("./images/characters/right.Snake"),
            Binary.ConvertImage("./images/characters/up.Snake")
        };

        public static Image[] Head = new Image[4]
        {
            Binary.ConvertImage("./images/characters/h_down.Snake"),
            Binary.ConvertImage("./images/characters/h_left.Snake"),
            Binary.ConvertImage("./images/characters/h_right.Snake"),
            Binary.ConvertImage("./images/characters/h_up.Snake")
        };

    }
}
