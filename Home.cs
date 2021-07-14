using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; //khai báo thư viện âm thanh
using System.Windows.Input;
using System.Runtime.InteropServices;

namespace Snake_Final
{
    public partial class Home : Form   {

        
        public int togglemusic, toggleaudiofx;        
        public string escape, up, down, left, right;
        bool keyDown = false;
        public SoundPlayer music, audiofx;  // khai báo tên cho kiểu âm thanh: music:nhạc nền ; audiofx: âm thanh hiệu ứng
        public string theme ="./Audio/menu.wav";      //gán đường dẫn cho âm thanh theme  
        public string click1 = "./Audio/click1.wav";
        public string click2 = "./Audio/click2.wav";
        public string upbeat = "./Audio/upbeat.wav";

        public Home()
        {
            InitializeComponent();
            CenterScreen();

        }

        private void CenterScreen()
        {
            // Get the Width and Height of the form
            int frm_width = this.Width;
            int frm_height = this.Height;

            //Get the Width and Height (resolution) 
            //     of the screen
            System.Windows.Forms.Screen src = System.Windows.Forms.Screen.PrimaryScreen;
            int src_height = src.Bounds.Height;
            int src_width = src.Bounds.Width;

            //put the form in the center
            this.Left = (src_width - frm_width) / 2;
            this.Top = (src_height - frm_height) / 2;
        }


        private void Home_Load(object sender, EventArgs e)
        {
            
            pnl_settings.Visible = false;
            pnl_loading.Visible = false;
            settingreload();            
            winmedia_sound.Visible = false;
            pnl_credits.Visible = false;
            test();
            
        }

        private void music_play(string path)
        {
            var a = Gamesettings.Default.togglemusic;
            if (a == 1)
            {
                winmedia_sound.URL = path;
                winmedia_sound.Ctlcontrols.play();
                winmedia_sound.settings.setMode("loop", true);
            }    
        }

        public void audiofx_play(string path)
        {
            var b = Gamesettings.Default.toggleaudiofx;
            if (b == 1)
            {
                audiofx = new SoundPlayer();
                audiofx.SoundLocation = path.ToString();
                audiofx.Play();
            }
        }


        private void settingreload()
        {
            music_play(theme);
            var escape = Gamesettings.Default.escape;
            var up = Gamesettings.Default.up;
            var down = Gamesettings.Default.down;
            var left = Gamesettings.Default.left;
            var right = Gamesettings.Default.right;
            btn_key_escape.Text = escape;
            btn_key_up.Text = up;
            btn_key_down.Text = down;
            btn_key_left.Text = left;
            btn_key_right.Text = right;            
            var togglemusic = Gamesettings.Default.togglemusic;
            var toggleaudiofx = Gamesettings.Default.toggleaudiofx;
            pnl_settings.Visible = false;
            pnl_loading.Visible = false;
            if (togglemusic==0)
            {
                btn_music_on.BackColor = Color.FromArgb(66, 71, 83);
                btn_music_off.BackColor = Color.FromArgb(255, 70, 85);
                winmedia_sound.Ctlcontrols.stop();
            }
            if (togglemusic==1)
            {
                btn_music_on.BackColor = Color.FromArgb(255, 70, 85);
                btn_music_off.BackColor = Color.FromArgb(66, 71, 83);
            }
            if (toggleaudiofx==1)
            {
                btn_audiofx_on.BackColor = Color.FromArgb(255, 70, 85);
                btn_audiofx_off.BackColor = Color.FromArgb(43, 48, 62);
            }
            if (toggleaudiofx==0)
            {
                btn_audiofx_on.BackColor = Color.FromArgb(43, 48, 62);
                btn_audiofx_off.BackColor = Color.FromArgb(255, 70, 85);
            }
            
        }
        private void ptbx_settings_Click(object sender, EventArgs e)
        {
            if (pnl_settings.Visible == false)
            {
                pnl_settings.Visible = true;
            }
            audiofx_play(click2);
        }


        private void ptbx_play_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            timer_loading.Start();
            pnl_loading.Visible = true;
            audiofx_play(upbeat);
            
        }       

        private void ptbx_credits_Click(object sender, EventArgs e)
        {
            pnl_credits.Visible = true;
            audiofx_play(click1);
        }              

        private void btn_key_escape_Click(object sender, EventArgs e)
        {
            keyDown = true;
            btn_key_escape.Text = "Press to change";
            audiofx_play(click1);
        }       

        private void btn_key_escape_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyDown)
            {
                btn_key_escape.Text = e.KeyCode.ToString();
                pnl_settings.Focus();
                keyDown = false;
                Gamesettings.Default.escape = btn_key_escape.Text;                
                Gamesettings.Default.Save();
            }
        }

        private void btn_key_up_Click(object sender, EventArgs e)
        {
            keyDown = true;
            btn_key_up.Text = "Press to change";
            audiofx_play(click1);
        }

        private void btn_key_up_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyDown)
            {
                btn_key_up.Text = e.KeyCode.ToString();
                pnl_settings.Focus();
                keyDown = false;                
                Gamesettings.Default.up = btn_key_up.Text;                
                Gamesettings.Default.Save();
            }
        }

        private void btn_key_down_Click(object sender, EventArgs e)
        {
            keyDown = true;
            btn_key_down.Text = "Press to change";
            audiofx_play(click1);
        }

        private void btn_key_down_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyDown)
            {
                btn_key_down.Text = e.KeyCode.ToString();
                pnl_settings.Focus();
                keyDown = false;                
                Gamesettings.Default.down = btn_key_down.Text;                
                Gamesettings.Default.Save();
            }
        }

        private void btn_key_left_Click(object sender, EventArgs e)
        {
            keyDown = true;
            btn_key_left.Text = "Press to change";
            audiofx_play(click1);
        }

        private void btn_key_left_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyDown)
            {
                btn_key_left.Text = e.KeyCode.ToString();
                pnl_settings.Focus();
                keyDown = false;                
                Gamesettings.Default.left = btn_key_left.Text;                
                Gamesettings.Default.Save();
            }
        }

        private void btn_key_right_Click(object sender, EventArgs e)
        {
            keyDown = true;
            btn_key_right.Text = "Press to change";
            audiofx_play(click1);
        }

        private void btn_key_right_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyDown)
            {
                btn_key_right.Text = e.KeyCode.ToString();
                pnl_settings.Focus();
                keyDown = false;                
                Gamesettings.Default.right = btn_key_right.Text;
                Gamesettings.Default.Save();
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            audiofx_play(click1);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbx_setting_close_Click(object sender, EventArgs e)
        {
            settingreload();
            audiofx_play(click2);

        }

        private void btn_key_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
                
            }
        }
        

        private void timer_processbar_Tick(object sender, EventArgs e)
        {
            processbar_loading.Width += 10;
            if (processbar_loading.Width == 1000)
            {
                Game game = new Game();
                timer_loading.Stop();            
                game.Show();                
                this.Hide();
                winmedia_sound.Ctlcontrols.stop();
            }      
        }

        private void btn_music_on_Click(object sender, EventArgs e)
        {            
            togglemusic = 1;
            Gamesettings.Default.togglemusic = 1;
            Gamesettings.Default.Save();
            btn_music_on.BackColor = Color.FromArgb(255, 70, 85);
            btn_music_off.BackColor = Color.FromArgb(66, 71, 83);
            audiofx_play(click1);
        }

        private void btn_music_off_Click(object sender, EventArgs e)
        {
            togglemusic = 0;
            Gamesettings.Default.togglemusic = 0;
            Gamesettings.Default.Save();
            btn_music_on.BackColor = Color.FromArgb(66, 71, 83);
            btn_music_off.BackColor = Color.FromArgb(255, 70, 85);
            audiofx_play(click1);
        }

        private void btn_audiofx_on_Click(object sender, EventArgs e)
        {
            toggleaudiofx = 1;
            Gamesettings.Default.toggleaudiofx = 1;
            Gamesettings.Default.Save();
            btn_audiofx_on.BackColor = Color.FromArgb(255, 70, 85);
            btn_audiofx_off.BackColor = Color.FromArgb(43, 48, 62);
            audiofx_play(click1);
        }

        private void btn_audiofx_off_Click(object sender, EventArgs e)
        {               
            toggleaudiofx = 0;
            Gamesettings.Default.toggleaudiofx = 0;
            Gamesettings.Default.Save();
            btn_audiofx_on.BackColor = Color.FromArgb(43, 48, 62);
            btn_audiofx_off.BackColor = Color.FromArgb(255, 70, 85);
            audiofx_play(click1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnl_credits.Visible = false;
            audiofx_play(click1);
        }

        /// <summary>
        /// borderless form move
        /// </summary>
        private bool mouseDown;
        private Point lastLocation;

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        /// <summary>
        /// borderless form move
        /// </summary>

        private void test()
        {
            int a = Gamesettings.Default.togglemusic;
            int b = Gamesettings.Default.toggleaudiofx;
            Console.WriteLine("music" + a);
            Console.WriteLine("audio" + b);
        }
    }
}
