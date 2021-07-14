using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Snake
{
    public partial class Form1 : Form
    {
        int mapNum = 0;
        ConnMongo conn;
        Map mapGame = new Map();
        int N = Source.N, M = Source.M;
        int size = Source.size;//size mỗi 1 ô tile 
        int score = 0;
        int dir = 2, num = 5;
        int counter = 0;
        bool keyDown = false;

        struct BuffSnake
        {
            public int countTime;
            public int buff;
        }
        BuffSnake[] buffList = new BuffSnake[5];

        bool rotateKey = false;


        int tileset = 0;
        int doubleClick = 0;
        MouseEventArgs save;        

        

        struct Snake{public int x; public int y; }
        Snake[] s = new Snake[100];
        
        struct Food{ public int x;public int y; }
        Food f = new Food();

        Food[] food = new Food[2];


        int[] listFood = new int[2];
        /// <summary>
        /// food = 0 => +10 điểm
        /// food = 1 => +5 điểm đảo phím 5s
        /// food = 2 => +5 điểm tăng tốc 10s
        /// food = 3 => +5 điểm giảm tốc 10s
        /// </summary>

        public Form1()
        {
            InitializeComponent(); 
        }

        private void randomFood()
        {
            Random rnd = new Random();
            if (food.Length == 1)
            {
                int x = rnd.Next(18);
                int y = rnd.Next(18);
                int foodNum = rnd.Next(4);

                for (int i = 1; i < num; i++)
                {
                    if (x == s[i].x && y == s[i].y)
                    {
                        //randomFood();
                        return;
                    }
                }

                foreach (Map.Block i in Map.Maps[mapNum].Block)
                {
                    if ((x == i.x) && (y == i.y))
                    {
                        //randomFood();
                        return;
                    }
                }

                foreach (Map.TeleGate item in Map.Maps[mapNum].TeleGate)
                {
                    if (item.TelePoint == null) continue;

                    foreach (var i in item.TelePoint)
                    {
                        if ((x == i.InX && y == i.InY) || (x == i.OutX && y == i.OutY))
                        {
                            //randomFood();
                            return;
                        }
                    }
                }



                Food[] tempFood = new Food[2];
                tempFood[0] = food[0];

                int[] tempListFood = new int[2];
                tempListFood[0] = listFood[0];

                food = new Food[2];
                food[0] = tempFood[0];
                listFood = new int[2];
                listFood[0] = tempListFood[0];

                food[1].x = x;
                food[1].y = y;
                listFood[1] = foodNum;
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    food[i].x = rnd.Next(18);
                    food[i].y = rnd.Next(18);
                    listFood[i] = rnd.Next(4);
                }
            }

        }            

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyDown) return;//check không cho user bấm liên tục trong 1 khoảng tg bằng tốc đô di chuyển 1 ô
                                ///check không cho chạy lùi

            if (rotateKey ==true) //đảo phím
            {
                if (dir == 3 && e.KeyCode == Keys.Up) return;
                if (dir == 2 && e.KeyCode == Keys.Right) return;
                if (dir == 1 && e.KeyCode == Keys.Left) return;
                if (dir == 0 && e.KeyCode == Keys.Down) return;

                keyDown = true;
                int oldDir = dir;
                if (e.KeyCode == Keys.Up) dir = 0;
                if (e.KeyCode == Keys.Down) dir = 3;
                if (e.KeyCode == Keys.Left) dir = 2;
                if (e.KeyCode == Keys.Right) dir = 1;
                if (oldDir == dir) return;
            }
            else
            {
                if (dir == 0 && e.KeyCode == Keys.Up) return;
                if (dir == 1 && e.KeyCode == Keys.Right) return;
                if (dir == 2 && e.KeyCode == Keys.Left) return;
                if (dir == 3 && e.KeyCode == Keys.Down) return;

                keyDown = true;
                int oldDir = dir;
                if (e.KeyCode == Keys.Up) dir = 3;
                if (e.KeyCode == Keys.Down) dir = 0;
                if (e.KeyCode == Keys.Left) dir = 1;
                if (e.KeyCode == Keys.Right) dir = 2;
                if (oldDir == dir) return;
            }  
      }



        private void Dead(string msg)
        {
            timer1.Enabled = false;
            DialogResult rs = MessageBox.Show($"{msg}","Play again?",MessageBoxButtons.OKCancel);
            if(rs == DialogResult.OK)
            { 
                score = 0;
                lblScore.Text = $"Sờ Co: {score}";
                dir = 2; num = 5;
                s = new Snake[100];
                randomFood();
                timer1.Enabled = true;
                timer1.Interval = 120;
                rotateKey = false;
            }
            else
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //1s = 1000 ms
            for (int i = 0; i < buffList.Length; i++)
            {
                if (buffList[i].countTime == 0) continue;
                buffList[i].countTime += timer1.Interval;
                if (buffList[i].buff == 1)
                {//đảo phím
                    if (rotateKey ==true) continue;                   

                    if (buffList[i].countTime >= 3000)
                    {
                        buffList[i].countTime = 0;
                        buffList[i].buff = 0;
                        rotateKey = false;
                        continue;
                    }

                }
                else if(buffList[i].buff == 2)
                {//tăng tốc              
                    if (buffList[i].countTime >= 6000)
                    {
                        buffList[i].countTime = 0;
                        buffList[i].buff = 0;
                        timer1.Interval += 20;
                        continue;
                    }

                }
                else if (buffList[i].buff == 3)
                {//giảm tốc                     
                    if (buffList[i].countTime >= 4000)
                    {
                        buffList[i].countTime = 0;
                        buffList[i].buff = 0;
                        timer1.Interval -= 50;
                        continue;
                    }
                }
            }


            
            string mess = "";
            foreach (var item in buffList)
            {

                mess += item.countTime + "|" + item.buff + "\r\n";
            }
            Console.WriteLine(mess);
            Console.WriteLine(timer1.Interval);
            if(food.Length < 2)
            {
                randomFood();
            }
            counter++;
            if (counter >= 1)
            {
                keyDown = false;
                counter = 0;
            }

            ///từ ĐUÔI tới CỔ rắn liên tục tiến lên theo đầu rắn (s[0])
            ///bởi từ cổ tới đuôi bắt đầu i=1 cho tới i= num
            ///muốn cho thân di chuyển phải gán phần sau cho phần trước
            ///tức là khi có 4 phần [0][1][2][3]
            ///[0] là đầu thì chúng ta bỏ ra 1 bên vì mình đang điều khiển đầu
            ///[1] muốn tiến lên phải đi qua vị trí của đầu từng đi nên phải gán vị trí của [0] cho [1]
            ///tương tự với các nút khác
            for (int i = num; i > 0; --i)
            {
                s[i].x = s[i - 1].x;
                s[i].y = s[i - 1].y;
            }


            if (dir == 0) s[0].y += 1;
            if (dir == 1) s[0].x -= 1;
            if (dir == 2) s[0].x += 1;
            if (dir == 3) s[0].y -= 1;



            for (int i = 0; i < food.Length; i++)
            {
                if ((s[0].x == food[i].x) && (s[0].y == food[i].y))
                {
                    if (listFood[i] == 0)
                    {
                        score += 10;
                        num++;
                    }
                    else if (listFood[i] == 1)
                    {
                        score += 5;
                        for (int z = 0; z < buffList.Length; z++)
                        {
                           if(buffList[z].buff == 1)
                            {
                                buffList[z].countTime = timer1.Interval;
                                buffList[z].buff = 1;
                                rotateKey = true;
                                break;
                            }
                            else if (buffList[z].countTime == 0)
                            {
                                buffList[z].countTime = timer1.Interval;
                                buffList[z].buff = 1;
                                rotateKey = true;
                                break;
                            }
                        }
                    }
                    else if (listFood[i] == 2)
                    {
                        score += 5;
                        for (int z = 0; z < buffList.Length; z++)
                        {
                            if (buffList[z].buff == 2)
                            {
                                buffList[z].countTime = timer1.Interval;
                                buffList[z].buff = 2;
                                break;
                            }else if (buffList[z].countTime == 0)
                            {
                                buffList[z].countTime = timer1.Interval;
                                buffList[z].buff = 2;
                                timer1.Interval -= 20;
                                break;
                            }
                        }
                        
                    }
                    else if (listFood[i] == 3)
                    {
                        score += 5;
                        for (int z = 0; z < buffList.Length; z++)
                        {
                            if (buffList[z].buff ==3)
                            {
                                buffList[z].countTime = timer1.Interval;
                                buffList[z].buff = 3;
                                break;
                            }
                            else if (buffList[z].countTime == 0)
                            {
                                buffList[z].countTime = timer1.Interval;
                                buffList[z].buff = 3;
                                timer1.Interval += 50;
                                break;
                            }
                        }                       
                    }

                    lblScore.Text = $"Sờ Co: {score}";                  


                    var foodList = food.ToList();
                    foodList.RemoveAt(i);
                    food = foodList.ToArray();

                    var lFood = listFood.ToList();
                    lFood.RemoveAt(i);
                    listFood = lFood.ToArray();

                    randomFood();
                }
            }





            


            ///xuyên tường
            if (s[0].x > N-1) s[0].x = 0;
            if (s[0].x < 0) s[0].x = N;
            if (s[0].y > M-1) s[0].y = 0;
            if (s[0].y < 0) s[0].y = M;
            ////xuyên tường



            /////không xuyên tường
            //if (s[0].x > N - 1 || s[0].x < 0 || s[0].y > M - 1|| s[0].y < 0)
            //{
            //    dead("joke over! you're dead");
            //    return;
            //}
            /////không xuyên tường


            foreach (Map.Block i in Map.Maps[mapNum].Block)
            {
                for (int j = 0; j < food.Length; j++)
                {
                    for (int z = 1; z < num; z++)
                    {
                        if (food[j].x == s[z].x && food[j].y == s[z].y)
                        {
                            randomFood();
                        }
                    }

                    if ((i.x == food[j].x) && (i.y == food[j].y))
                    {
                        randomFood();
                    }
                }

                if ((s[0].x == i.x) && (s[0].y == i.y))
                {
                    Dead("joke over! you're dead (đâm block)");
                    return;
                }
            }

            foreach (var item in Map.Maps[mapNum].TeleGate)
            {
                if (item.TelePoint == null) continue;

                foreach (var i in item.TelePoint)
                {
                    for (int j = 0; j < food.Length; j++)
                    {
                        if ( (food[j].x == i.InX && food[j].y == i.InY) ||
                            (food[j].x == i.OutX && food[j].y == i.OutY) )
                        {
                            randomFood();
                        }
                    }

                    if (s[0].x == i.InX && s[0].y == i.InY)
                    {
                        s[0].x = i.OutX;
                        s[0].y = i.OutY;
                    }else if (s[0].x == i.OutX && s[0].y == i.OutY)
                    {
                        s[0].x = i.InX;
                        s[0].y = i.InY;
                    }
                }
            }


            for (int i = 1; i < num; i++)
                if (s[0].x == s[i].x && s[0].y == s[i].y)
                {
                    Dead("joke over! you're dead");
                    return;
                }

            pictureBox1.Refresh();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void edit_Click(object sender, EventArgs e)
        {

            if(picEdit.Visible == false)
            {
                pictureBox1.Visible = false;
                timer1.Enabled = false;

                hScrollBar2.Maximum = Source.MAX_MAP;
                hScrollBar2.Value = 0;
                groupBox1.Enabled = true;
                groupBox1.Visible = true;
                picEdit.Visible = true;
                picEdit.Location = new Point(0, 0);
                picEdit.Size = new Size(pictureBox1.Width, pictureBox1.Height);
                picEdit.Refresh();
            }
            else
            {                
                pictureBox1.Visible = true;
                timer1.Enabled = true;
                pictureBox1.Refresh();

                groupBox1.Enabled = false;
                groupBox1.Visible = false;
                picEdit.Visible = false;
            }
           
        }


        private void picEdit_Click(object sender, EventArgs e)
        {
            MouseEventArgs e2 = (MouseEventArgs)e;
            
            if (radioButton1.Checked)
            {              
                Map.Block b = new Map.Block();
                b.x = (e2.X) / 40;
                b.y = (e2.Y) / 40;
                Map.Maps[mapNum].Block.Add(b);   
            }

            if (radioButton2.Checked)
            {
                if(checkBox1.Checked == false)
                {
                    Map.TeleGate tg = new Map.TeleGate();
                    tg.TileSet = Image.FromFile(mapGame.MapTele[hScrollBar1.Value]);
                    tg.DrawX = (e2.X) / 40;
                    tg.DrawY = (e2.Y) / 40;
                    Map.Maps[mapNum].TeleGate.Add(tg);
                }
                else
                {
                    doubleClick += 1;
                    if (doubleClick == 2)
                    {
                        Console.WriteLine($"x:{ (save.X) / 40} , y:{ (save.Y) / 40}||x:{ (e2.X) / 40} , y:{ (e2.Y) / 40}");
                        doubleClick = 0;
                        Map.Tele TelePoint = new Map.Tele();
                        TelePoint.InX = save.X / 40;
                        TelePoint.InY = save.Y / 40;
                        TelePoint.OutX = e2.X / 40;
                        TelePoint.OutY = e2.Y / 40;

                        Map.TeleGate tg = new Map.TeleGate();
                        tg.TelePoint = new List<Map.Tele>();
                        tg.TelePoint.Add(TelePoint);
                        Map.Maps[mapNum].TeleGate.Add(tg);
                        save = null;
                    }
                    else
                    {
                        save = e2;
                    }
                }
                
            }

            picEdit.Refresh();
            Map.SaveMap(mapNum);
        }


        private void picEdit_Paint(object sender, PaintEventArgs e)
        {
            mapGame.spawn(e, mapNum);

            Pen p = new Pen(Color.Black, 1.0f);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Point point = new Point(i * size, j * size);
                    Point point1 = new Point((i) * size, (j + 1) * size);
                    e.Graphics.DrawLine(p, point, point1);

                    Point point2 = new Point(i * size, j * size);
                    Point point3 = new Point((i + 1) * size, (j) * size);
                    e.Graphics.DrawLine(p, point2, point3);
                }
            }

            for (int i = 0; i < Map.Maps[mapNum].TeleGate.Count; i++)
            {
                if (Map.Maps[mapNum].TeleGate[i].TelePoint == null) continue;
                foreach (var item in Map.Maps[mapNum].TeleGate[i].TelePoint)
                {
                    Console.WriteLine($"x1: {item.InX} , y1: {item.InY}|| x2:{item.OutX} , y2: {item.OutY}");
                    Point point = new Point(item.InX * size, item.InY * size);
                    e.Graphics.DrawString($"T{i}", new Font("Arial", 10), Brushes.Blue, point);

                    Point point2 = new Point(item.OutX * size, item.OutY * size);
                    e.Graphics.DrawString($"T{i}", new Font("Arial", 10), Brushes.Blue, point2);
                }     
            }

            if(save != null)
            {
                Point pointp = new Point(save.X * size, save.Y * size);
                e.Graphics.DrawString($"T[P]", new Font("Arial", 10), Brushes.Blue, pointp);
            }          


        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Map.Maps[mapNum].Block.Clear();
            }
            else if (radioButton2.Checked == true)
            {
                Map.Maps[mapNum].TeleGate.Clear();
            }
            picEdit.Refresh();
            Map.SaveMap(mapNum);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            tileset = hScrollBar1.Value;
            Console.WriteLine(hScrollBar1.Value);
            picEditTile.Refresh();
            if (radioButton3.Checked)
            {
                Map.Maps[mapNum].BackGround = mapGame.MapBG[tileset];
                Map.SaveMap(mapNum);
            }

            picEdit.Refresh();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                hScrollBar1.Maximum = mapGame.TilesetSprite.Count;
                hScrollBar1.Value = 0;
                picEditTile.Refresh();
            }

            if (radioButton2.Checked)
            {
                hScrollBar1.Maximum = mapGame.MapTele.Count;
                hScrollBar1.Value = 0;
                picEditTile.Refresh();
                checkBox1.Visible = true;
                lblPoint.Visible = true;
            }
            if (radioButton3.Checked)
            {
                hScrollBar1.Maximum = mapGame.MapBG.Count;          
                hScrollBar1.Value = 0;             
            }
        }

        private void picEditTile_Paint(object sender, PaintEventArgs e)
        {
            if (radioButton1.Checked)
            {
                Image Tile = Image.FromFile(mapGame.TilesetSprite[hScrollBar1.Value]);
                Rectangle cropBg = new Rectangle(0, 0, Tile.Width, Tile.Height);
                e.Graphics.DrawImage(Tile, cropBg, 0, 0, Tile.Width, Tile.Height, GraphicsUnit.Pixel);
            }
            if (radioButton2.Checked)
            {
                Image Tile = Image.FromFile(mapGame.MapTele[hScrollBar1.Value]);
                Rectangle cropBg = new Rectangle(0, 0, Tile.Width, Tile.Height);
                e.Graphics.DrawImage(Tile, cropBg, 0, 0, Tile.Width, Tile.Height, GraphicsUnit.Pixel);
            }
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            mapNum = hScrollBar2.Value;
            picEdit.Refresh();
        }

        private void picBXH_MouseEnter(object sender, EventArgs e)
        {

            lblBXH.Visible = true;
        }

        private void picBXH_MouseLeave(object sender, EventArgs e)
        {
            lblBXH.Visible = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            mapGame.spawn(e, mapNum);
            for (int i = 0; i < num; i++)
            {
                Rectangle cropHead1 = new Rectangle(s[i].x * size, s[i].y * size, size, size);
                if (i == 0)
                {
                    e.Graphics.DrawImage(Source.Head[dir], cropHead1, 0, 0, 160, 160, GraphicsUnit.Pixel);
                }
                else
                {
                    e.Graphics.DrawImage(Source.snakeBody, cropHead1, 0, 0, 160, 160, GraphicsUnit.Pixel);
                }

            }

            for (int i = 0; i < food.Length; i++)
            {
                Rectangle cropFood = new Rectangle(food[i].x * size, food[i].y * size, size, size);
                e.Graphics.DrawImage(Source.food[listFood[i]], cropFood, 0, 0, size, size, GraphicsUnit.Pixel);
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Size = new Size(size * N, size * M);
            pictureBox1.Size = new Size(960,720);

            //random vị trí của food đầu tiên
            randomFood();
            this.Size = new Size(1280, 720);

            timer1.Start();
            mapGame.LoadMap();

            conn = new ConnMongo();
            lblBXH.Text = conn.LoadBXH();
            //conn.ImportBXH("Len", 300);
        }
    }
}
