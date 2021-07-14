namespace Snake_Final
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.ptbx_settings = new System.Windows.Forms.PictureBox();
            this.ptbx_credits = new System.Windows.Forms.PictureBox();
            this.ptbx_play = new System.Windows.Forms.PictureBox();
            this.pnl_settings = new System.Windows.Forms.Panel();
            this.btn_key_right = new System.Windows.Forms.Button();
            this.btn_key_left = new System.Windows.Forms.Button();
            this.btn_key_up = new System.Windows.Forms.Button();
            this.btn_key_down = new System.Windows.Forms.Button();
            this.btn_key_escape = new System.Windows.Forms.Button();
            this.btn_audiofx_off = new System.Windows.Forms.Button();
            this.btn_audiofx_on = new System.Windows.Forms.Button();
            this.btn_music_off = new System.Windows.Forms.Button();
            this.btn_music_on = new System.Windows.Forms.Button();
            this.ptbx_setting_close = new System.Windows.Forms.PictureBox();
            this.pnl_loading = new System.Windows.Forms.Panel();
            this.pnl_credits = new System.Windows.Forms.Panel();
            this.processbar_loading = new System.Windows.Forms.Panel();
            this.timer_loading = new System.Windows.Forms.Timer(this.components);
            this.winmedia_sound = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbx_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbx_credits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbx_play)).BeginInit();
            this.pnl_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbx_setting_close)).BeginInit();
            this.pnl_loading.SuspendLayout();
            this.pnl_credits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winmedia_sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbx_settings
            // 
            this.ptbx_settings.BackColor = System.Drawing.Color.Transparent;
            this.ptbx_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbx_settings.Image = global::Snake_Final.Properties.Resources.Setting;
            this.ptbx_settings.Location = new System.Drawing.Point(421, 691);
            this.ptbx_settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbx_settings.Name = "ptbx_settings";
            this.ptbx_settings.Size = new System.Drawing.Size(116, 20);
            this.ptbx_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbx_settings.TabIndex = 0;
            this.ptbx_settings.TabStop = false;
            this.ptbx_settings.Click += new System.EventHandler(this.ptbx_settings_Click);
            // 
            // ptbx_credits
            // 
            this.ptbx_credits.BackColor = System.Drawing.Color.Transparent;
            this.ptbx_credits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbx_credits.Image = global::Snake_Final.Properties.Resources.Credits;
            this.ptbx_credits.Location = new System.Drawing.Point(745, 691);
            this.ptbx_credits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbx_credits.Name = "ptbx_credits";
            this.ptbx_credits.Size = new System.Drawing.Size(95, 20);
            this.ptbx_credits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbx_credits.TabIndex = 1;
            this.ptbx_credits.TabStop = false;
            this.ptbx_credits.Click += new System.EventHandler(this.ptbx_credits_Click);
            // 
            // ptbx_play
            // 
            this.ptbx_play.BackColor = System.Drawing.Color.Transparent;
            this.ptbx_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbx_play.Image = global::Snake_Final.Properties.Resources.play___Copy;
            this.ptbx_play.Location = new System.Drawing.Point(560, 681);
            this.ptbx_play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbx_play.Name = "ptbx_play";
            this.ptbx_play.Size = new System.Drawing.Size(160, 32);
            this.ptbx_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbx_play.TabIndex = 3;
            this.ptbx_play.TabStop = false;
            this.ptbx_play.Click += new System.EventHandler(this.ptbx_play_Click);
            // 
            // pnl_settings
            // 
            this.pnl_settings.BackColor = System.Drawing.Color.Transparent;
            this.pnl_settings.BackgroundImage = global::Snake_Final.Properties.Resources.Settings;
            this.pnl_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_settings.Controls.Add(this.btn_key_right);
            this.pnl_settings.Controls.Add(this.btn_key_left);
            this.pnl_settings.Controls.Add(this.btn_key_up);
            this.pnl_settings.Controls.Add(this.btn_key_down);
            this.pnl_settings.Controls.Add(this.btn_key_escape);
            this.pnl_settings.Controls.Add(this.btn_audiofx_off);
            this.pnl_settings.Controls.Add(this.btn_audiofx_on);
            this.pnl_settings.Controls.Add(this.btn_music_off);
            this.pnl_settings.Controls.Add(this.btn_music_on);
            this.pnl_settings.Controls.Add(this.ptbx_setting_close);
            this.pnl_settings.Location = new System.Drawing.Point(320, 65);
            this.pnl_settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_settings.Name = "pnl_settings";
            this.pnl_settings.Size = new System.Drawing.Size(640, 576);
            this.pnl_settings.TabIndex = 4;
            // 
            // btn_key_right
            // 
            this.btn_key_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
            this.btn_key_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_key_right.Font = new System.Drawing.Font("Tw Cen MT", 8F, System.Drawing.FontStyle.Bold);
            this.btn_key_right.ForeColor = System.Drawing.Color.Transparent;
            this.btn_key_right.Location = new System.Drawing.Point(350, 431);
            this.btn_key_right.Name = "btn_key_right";
            this.btn_key_right.Size = new System.Drawing.Size(212, 34);
            this.btn_key_right.TabIndex = 1;
            this.btn_key_right.Text = "Escape";
            this.btn_key_right.UseVisualStyleBackColor = false;
            this.btn_key_right.Click += new System.EventHandler(this.btn_key_right_Click);
            this.btn_key_right.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_key_right_KeyDown);
            this.btn_key_right.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btn_key_PreviewKeyDown);
            // 
            // btn_key_left
            // 
            this.btn_key_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
            this.btn_key_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_key_left.Font = new System.Drawing.Font("Tw Cen MT", 8F, System.Drawing.FontStyle.Bold);
            this.btn_key_left.ForeColor = System.Drawing.Color.Transparent;
            this.btn_key_left.Location = new System.Drawing.Point(350, 398);
            this.btn_key_left.Name = "btn_key_left";
            this.btn_key_left.Size = new System.Drawing.Size(212, 34);
            this.btn_key_left.TabIndex = 1;
            this.btn_key_left.Text = "Escape";
            this.btn_key_left.UseVisualStyleBackColor = false;
            this.btn_key_left.Click += new System.EventHandler(this.btn_key_left_Click);
            this.btn_key_left.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_key_left_KeyDown);
            this.btn_key_left.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btn_key_PreviewKeyDown);
            // 
            // btn_key_up
            // 
            this.btn_key_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
            this.btn_key_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_key_up.Font = new System.Drawing.Font("Tw Cen MT", 8F, System.Drawing.FontStyle.Bold);
            this.btn_key_up.ForeColor = System.Drawing.Color.Transparent;
            this.btn_key_up.Location = new System.Drawing.Point(350, 334);
            this.btn_key_up.Name = "btn_key_up";
            this.btn_key_up.Size = new System.Drawing.Size(212, 34);
            this.btn_key_up.TabIndex = 1;
            this.btn_key_up.Text = "Escape";
            this.btn_key_up.UseVisualStyleBackColor = false;
            this.btn_key_up.Click += new System.EventHandler(this.btn_key_up_Click);
            this.btn_key_up.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_key_up_KeyDown);
            this.btn_key_up.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btn_key_PreviewKeyDown);
            // 
            // btn_key_down
            // 
            this.btn_key_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
            this.btn_key_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_key_down.Font = new System.Drawing.Font("Tw Cen MT", 8F, System.Drawing.FontStyle.Bold);
            this.btn_key_down.ForeColor = System.Drawing.Color.Transparent;
            this.btn_key_down.Location = new System.Drawing.Point(350, 367);
            this.btn_key_down.Name = "btn_key_down";
            this.btn_key_down.Size = new System.Drawing.Size(212, 34);
            this.btn_key_down.TabIndex = 1;
            this.btn_key_down.Text = "Escape";
            this.btn_key_down.UseVisualStyleBackColor = false;
            this.btn_key_down.Click += new System.EventHandler(this.btn_key_down_Click);
            this.btn_key_down.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_key_down_KeyDown);
            this.btn_key_down.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btn_key_PreviewKeyDown);
            // 
            // btn_key_escape
            // 
            this.btn_key_escape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
            this.btn_key_escape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_key_escape.Font = new System.Drawing.Font("Tw Cen MT", 8F, System.Drawing.FontStyle.Bold);
            this.btn_key_escape.ForeColor = System.Drawing.Color.Transparent;
            this.btn_key_escape.Location = new System.Drawing.Point(350, 303);
            this.btn_key_escape.Name = "btn_key_escape";
            this.btn_key_escape.Size = new System.Drawing.Size(212, 34);
            this.btn_key_escape.TabIndex = 1;
            this.btn_key_escape.Text = "Escape";
            this.btn_key_escape.UseVisualStyleBackColor = false;
            this.btn_key_escape.Click += new System.EventHandler(this.btn_key_escape_Click);
            this.btn_key_escape.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_key_escape_KeyDown);
            this.btn_key_escape.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btn_key_PreviewKeyDown);
            // 
            // btn_audiofx_off
            // 
            this.btn_audiofx_off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.btn_audiofx_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_audiofx_off.Font = new System.Drawing.Font("Tw Cen MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_audiofx_off.ForeColor = System.Drawing.Color.Transparent;
            this.btn_audiofx_off.Location = new System.Drawing.Point(461, 178);
            this.btn_audiofx_off.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_audiofx_off.Name = "btn_audiofx_off";
            this.btn_audiofx_off.Size = new System.Drawing.Size(101, 31);
            this.btn_audiofx_off.TabIndex = 1;
            this.btn_audiofx_off.Text = "OFF";
            this.btn_audiofx_off.UseVisualStyleBackColor = false;
            this.btn_audiofx_off.Click += new System.EventHandler(this.btn_audiofx_off_Click);
            // 
            // btn_audiofx_on
            // 
            this.btn_audiofx_on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.btn_audiofx_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_audiofx_on.Font = new System.Drawing.Font("Tw Cen MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_audiofx_on.ForeColor = System.Drawing.Color.Transparent;
            this.btn_audiofx_on.Location = new System.Drawing.Point(360, 178);
            this.btn_audiofx_on.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_audiofx_on.Name = "btn_audiofx_on";
            this.btn_audiofx_on.Size = new System.Drawing.Size(101, 31);
            this.btn_audiofx_on.TabIndex = 1;
            this.btn_audiofx_on.Text = "ON";
            this.btn_audiofx_on.UseVisualStyleBackColor = false;
            this.btn_audiofx_on.Click += new System.EventHandler(this.btn_audiofx_on_Click);
            // 
            // btn_music_off
            // 
            this.btn_music_off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
            this.btn_music_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_music_off.Font = new System.Drawing.Font("Tw Cen MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_music_off.ForeColor = System.Drawing.Color.Transparent;
            this.btn_music_off.Location = new System.Drawing.Point(461, 142);
            this.btn_music_off.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_music_off.Name = "btn_music_off";
            this.btn_music_off.Size = new System.Drawing.Size(101, 31);
            this.btn_music_off.TabIndex = 1;
            this.btn_music_off.Text = "OFF";
            this.btn_music_off.UseVisualStyleBackColor = false;
            this.btn_music_off.Click += new System.EventHandler(this.btn_music_off_Click);
            // 
            // btn_music_on
            // 
            this.btn_music_on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(83)))));
            this.btn_music_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_music_on.Font = new System.Drawing.Font("Tw Cen MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_music_on.ForeColor = System.Drawing.Color.Transparent;
            this.btn_music_on.Location = new System.Drawing.Point(360, 142);
            this.btn_music_on.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_music_on.Name = "btn_music_on";
            this.btn_music_on.Size = new System.Drawing.Size(101, 31);
            this.btn_music_on.TabIndex = 1;
            this.btn_music_on.Text = "ON";
            this.btn_music_on.UseVisualStyleBackColor = false;
            this.btn_music_on.Click += new System.EventHandler(this.btn_music_on_Click);
            // 
            // ptbx_setting_close
            // 
            this.ptbx_setting_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbx_setting_close.Image = global::Snake_Final.Properties.Resources.setting_close;
            this.ptbx_setting_close.Location = new System.Drawing.Point(231, 526);
            this.ptbx_setting_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbx_setting_close.Name = "ptbx_setting_close";
            this.ptbx_setting_close.Size = new System.Drawing.Size(160, 40);
            this.ptbx_setting_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbx_setting_close.TabIndex = 0;
            this.ptbx_setting_close.TabStop = false;
            this.ptbx_setting_close.Click += new System.EventHandler(this.ptbx_setting_close_Click);
            // 
            // pnl_loading
            // 
            this.pnl_loading.BackColor = System.Drawing.Color.Transparent;
            this.pnl_loading.BackgroundImage = global::Snake_Final.Properties.Resources.loadingscreen;
            this.pnl_loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_loading.Controls.Add(this.processbar_loading);
            this.pnl_loading.Location = new System.Drawing.Point(0, 0);
            this.pnl_loading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_loading.Name = "pnl_loading";
            this.pnl_loading.Size = new System.Drawing.Size(1280, 720);
            this.pnl_loading.TabIndex = 5;
            // 
            // pnl_credits
            // 
            this.pnl_credits.BackgroundImage = global::Snake_Final.Properties.Resources.infocredits;
            this.pnl_credits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_credits.Controls.Add(this.pictureBox1);
            this.pnl_credits.Location = new System.Drawing.Point(249, 143);
            this.pnl_credits.Name = "pnl_credits";
            this.pnl_credits.Size = new System.Drawing.Size(778, 453);
            this.pnl_credits.TabIndex = 1;
            // 
            // processbar_loading
            // 
            this.processbar_loading.BackColor = System.Drawing.Color.IndianRed;
            this.processbar_loading.Location = new System.Drawing.Point(0, 712);
            this.processbar_loading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processbar_loading.Name = "processbar_loading";
            this.processbar_loading.Size = new System.Drawing.Size(27, 8);
            this.processbar_loading.TabIndex = 0;
            // 
            // timer_loading
            // 
            this.timer_loading.Interval = 15;
            this.timer_loading.Tick += new System.EventHandler(this.timer_processbar_Tick);
            // 
            // winmedia_sound
            // 
            this.winmedia_sound.Enabled = true;
            this.winmedia_sound.Location = new System.Drawing.Point(-4, 0);
            this.winmedia_sound.Name = "winmedia_sound";
            this.winmedia_sound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("winmedia_sound.OcxState")));
            this.winmedia_sound.Size = new System.Drawing.Size(245, 48);
            this.winmedia_sound.TabIndex = 6;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Image = global::Snake_Final.Properties.Resources.btn_close;
            this.btn_exit.Location = new System.Drawing.Point(1217, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(35, 35);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 7;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Image = global::Snake_Final.Properties.Resources.btn_minimize;
            this.btn_minimize.Location = new System.Drawing.Point(1176, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(35, 35);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimize.TabIndex = 8;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Snake_Final.Properties.Resources.btn_close;
            this.pictureBox1.Location = new System.Drawing.Point(740, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake_Final.Properties.Resources.Theme;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnl_loading);
            this.Controls.Add(this.pnl_credits);
            this.Controls.Add(this.winmedia_sound);
            this.Controls.Add(this.ptbx_credits);
            this.Controls.Add(this.ptbx_settings);
            this.Controls.Add(this.ptbx_play);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pnl_settings);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Home_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbx_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbx_credits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbx_play)).EndInit();
            this.pnl_settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbx_setting_close)).EndInit();
            this.pnl_loading.ResumeLayout(false);
            this.pnl_credits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.winmedia_sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbx_settings;
        private System.Windows.Forms.PictureBox ptbx_credits;
        private System.Windows.Forms.PictureBox ptbx_play;
        private System.Windows.Forms.Panel pnl_settings;
        private System.Windows.Forms.PictureBox ptbx_setting_close;
        private System.Windows.Forms.Timer timer_loading;
        private System.Windows.Forms.Panel pnl_loading;
        private System.Windows.Forms.Panel processbar_loading;
        private System.Windows.Forms.Button btn_music_off;
        private System.Windows.Forms.Button btn_music_on;
        private System.Windows.Forms.Button btn_audiofx_off;
        private System.Windows.Forms.Button btn_audiofx_on;
        private AxWMPLib.AxWindowsMediaPlayer winmedia_sound;
        private System.Windows.Forms.Button btn_key_escape;
        private System.Windows.Forms.Button btn_key_right;
        private System.Windows.Forms.Button btn_key_left;
        private System.Windows.Forms.Button btn_key_up;
        private System.Windows.Forms.Button btn_key_down;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox btn_minimize;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnl_credits;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

