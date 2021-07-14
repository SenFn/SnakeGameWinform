namespace Snake_Final
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timer_game = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.picEditTile = new System.Windows.Forms.PictureBox();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pnl_pause = new System.Windows.Forms.Panel();
            this.btn_close_resume = new System.Windows.Forms.PictureBox();
            this.btn_exit2 = new System.Windows.Forms.Button();
            this.btn_newgame = new System.Windows.Forms.Button();
            this.btn_homescreen = new System.Windows.Forms.Button();
            this.btn_resume = new System.Windows.Forms.Button();
            this.picBXH = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.edit = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_scoreboard = new System.Windows.Forms.Label();
            this.timer_countdown = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_countdown = new System.Windows.Forms.Label();
            this.lblScoreMap = new System.Windows.Forms.Label();
            this.timer_loading = new System.Windows.Forms.Timer(this.components);
            this.pnl_gameover = new System.Windows.Forms.Panel();
            this.lbOK = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditTile)).BeginInit();
            this.pnl_pause.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close_resume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBXH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_gameover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_game
            // 
            this.timer_game.Enabled = true;
            this.timer_game.Interval = 120;
            this.timer_game.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblScore.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(841, 48);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(121, 38);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.hScrollBar2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPoint);
            this.groupBox1.Controls.Add(this.hScrollBar1);
            this.groupBox1.Controls.Add(this.picEditTile);
            this.groupBox1.Controls.Add(this.btnRemoveAll);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(728, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 361);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 305);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Point";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.LargeChange = 2;
            this.hScrollBar2.Location = new System.Drawing.Point(67, 29);
            this.hScrollBar2.Maximum = 1;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(80, 17);
            this.hScrollBar2.TabIndex = 8;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Map";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(21, 323);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(30, 13);
            this.lblPoint.TabIndex = 7;
            this.lblPoint.Text = "point";
            this.lblPoint.Visible = false;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 2;
            this.hScrollBar1.Location = new System.Drawing.Point(6, 180);
            this.hScrollBar1.Maximum = 1;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(80, 17);
            this.hScrollBar1.TabIndex = 5;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // picEditTile
            // 
            this.picEditTile.Location = new System.Drawing.Point(6, 68);
            this.picEditTile.Name = "picEditTile";
            this.picEditTile.Size = new System.Drawing.Size(173, 96);
            this.picEditTile.TabIndex = 4;
            this.picEditTile.TabStop = false;
            this.picEditTile.Paint += new System.Windows.Forms.PaintEventHandler(this.picEditTile_Paint);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(104, 263);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAll.TabIndex = 3;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(26, 266);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(82, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "background";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 243);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "TeleGate";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 219);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Block";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // pnl_pause
            // 
            this.pnl_pause.BackColor = System.Drawing.Color.Transparent;
            this.pnl_pause.BackgroundImage = global::Snake_Final.Properties.Resources.Settings1;
            this.pnl_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_pause.Controls.Add(this.btn_close_resume);
            this.pnl_pause.Controls.Add(this.btn_exit2);
            this.pnl_pause.Controls.Add(this.btn_newgame);
            this.pnl_pause.Controls.Add(this.btn_homescreen);
            this.pnl_pause.Controls.Add(this.btn_resume);
            this.pnl_pause.Location = new System.Drawing.Point(316, 102);
            this.pnl_pause.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_pause.Name = "pnl_pause";
            this.pnl_pause.Size = new System.Drawing.Size(338, 401);
            this.pnl_pause.TabIndex = 7;
            // 
            // btn_close_resume
            // 
            this.btn_close_resume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close_resume.Image = global::Snake_Final.Properties.Resources.btn_close;
            this.btn_close_resume.Location = new System.Drawing.Point(311, 2);
            this.btn_close_resume.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close_resume.Name = "btn_close_resume";
            this.btn_close_resume.Size = new System.Drawing.Size(26, 28);
            this.btn_close_resume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close_resume.TabIndex = 1;
            this.btn_close_resume.TabStop = false;
            this.btn_close_resume.Click += new System.EventHandler(this.btn_close_resume_Click);
            // 
            // btn_exit2
            // 
            this.btn_exit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_exit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit2.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_exit2.Location = new System.Drawing.Point(46, 295);
            this.btn_exit2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit2.Name = "btn_exit2";
            this.btn_exit2.Size = new System.Drawing.Size(249, 50);
            this.btn_exit2.TabIndex = 0;
            this.btn_exit2.Text = "EXIT TO DESKTOP";
            this.btn_exit2.UseVisualStyleBackColor = false;
            this.btn_exit2.Click += new System.EventHandler(this.btn_exit2_Click);
            // 
            // btn_newgame
            // 
            this.btn_newgame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(85)))));
            this.btn_newgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newgame.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newgame.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_newgame.Location = new System.Drawing.Point(46, 119);
            this.btn_newgame.Margin = new System.Windows.Forms.Padding(2);
            this.btn_newgame.Name = "btn_newgame";
            this.btn_newgame.Size = new System.Drawing.Size(249, 50);
            this.btn_newgame.TabIndex = 0;
            this.btn_newgame.Text = "NEW GAME";
            this.btn_newgame.UseVisualStyleBackColor = false;
            this.btn_newgame.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_homescreen
            // 
            this.btn_homescreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(85)))));
            this.btn_homescreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_homescreen.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_homescreen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_homescreen.Location = new System.Drawing.Point(46, 233);
            this.btn_homescreen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_homescreen.Name = "btn_homescreen";
            this.btn_homescreen.Size = new System.Drawing.Size(249, 50);
            this.btn_homescreen.TabIndex = 0;
            this.btn_homescreen.Text = "HOME SCREEN";
            this.btn_homescreen.UseVisualStyleBackColor = false;
            this.btn_homescreen.Click += new System.EventHandler(this.btn_settings2_Click);
            // 
            // btn_resume
            // 
            this.btn_resume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(85)))));
            this.btn_resume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resume.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resume.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_resume.Location = new System.Drawing.Point(46, 57);
            this.btn_resume.Margin = new System.Windows.Forms.Padding(2);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(249, 50);
            this.btn_resume.TabIndex = 0;
            this.btn_resume.Text = "RESUME";
            this.btn_resume.UseVisualStyleBackColor = false;
            this.btn_resume.Click += new System.EventHandler(this.btn_resume_Click);
            // 
            // picBXH
            // 
            this.picBXH.Image = ((System.Drawing.Image)(resources.GetObject("picBXH.Image")));
            this.picBXH.Location = new System.Drawing.Point(977, 0);
            this.picBXH.Name = "picBXH";
            this.picBXH.Size = new System.Drawing.Size(39, 26);
            this.picBXH.TabIndex = 6;
            this.picBXH.TabStop = false;
            // 
            // picEdit
            // 
            this.picEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picEdit.Location = new System.Drawing.Point(850, 472);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(100, 50);
            this.picEdit.TabIndex = 4;
            this.picEdit.TabStop = false;
            this.picEdit.Visible = false;
            this.picEdit.Click += new System.EventHandler(this.picEdit_Click);
            this.picEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.picEdit_Paint);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.edit.Location = new System.Drawing.Point(846, 440);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(100, 26);
            this.edit.TabIndex = 3;
            this.edit.TabStop = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1022, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 41);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 19.8F);
            this.label2.Location = new System.Drawing.Point(864, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "SCORE";
            // 
            // lb_scoreboard
            // 
            this.lb_scoreboard.BackColor = System.Drawing.Color.Transparent;
            this.lb_scoreboard.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_scoreboard.Location = new System.Drawing.Point(2, 48);
            this.lb_scoreboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_scoreboard.Name = "lb_scoreboard";
            this.lb_scoreboard.Size = new System.Drawing.Size(118, 228);
            this.lb_scoreboard.TabIndex = 10;
            this.lb_scoreboard.Text = "Scoreboard";
            this.lb_scoreboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_countdown
            // 
            this.timer_countdown.Enabled = true;
            this.timer_countdown.Interval = 1000;
            this.timer_countdown.Tick += new System.EventHandler(this.timer_countdown_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(120, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 585);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // lb_countdown
            // 
            this.lb_countdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(254)))), ((int)(((byte)(106)))));
            this.lb_countdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_countdown.Font = new System.Drawing.Font("Tw Cen MT", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_countdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(66)))), ((int)(((byte)(67)))));
            this.lb_countdown.Location = new System.Drawing.Point(120, 228);
            this.lb_countdown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_countdown.Name = "lb_countdown";
            this.lb_countdown.Size = new System.Drawing.Size(720, 112);
            this.lb_countdown.TabIndex = 1;
            this.lb_countdown.Text = "countdown";
            this.lb_countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreMap
            // 
            this.lblScoreMap.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreMap.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 19.8F);
            this.lblScoreMap.Location = new System.Drawing.Point(838, 86);
            this.lblScoreMap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScoreMap.Name = "lblScoreMap";
            this.lblScoreMap.Size = new System.Drawing.Size(124, 141);
            this.lblScoreMap.TabIndex = 11;
            this.lblScoreMap.Text = "label3";
            this.lblScoreMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_loading
            // 
            this.timer_loading.Interval = 15;
            // 
            // pnl_gameover
            // 
            this.pnl_gameover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(104)))), ((int)(((byte)(80)))));
            this.pnl_gameover.Controls.Add(this.lbOK);
            this.pnl_gameover.Controls.Add(this.label5);
            this.pnl_gameover.Controls.Add(this.label4);
            this.pnl_gameover.Controls.Add(this.textBox1);
            this.pnl_gameover.Controls.Add(this.label3);
            this.pnl_gameover.Controls.Add(this.pictureBox3);
            this.pnl_gameover.Location = new System.Drawing.Point(210, 154);
            this.pnl_gameover.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_gameover.Name = "pnl_gameover";
            this.pnl_gameover.Size = new System.Drawing.Size(540, 260);
            this.pnl_gameover.TabIndex = 12;
            // 
            // lbOK
            // 
            this.lbOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbOK.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 19.8F);
            this.lbOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbOK.Location = new System.Drawing.Point(372, 206);
            this.lbOK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOK.Name = "lbOK";
            this.lbOK.Size = new System.Drawing.Size(166, 32);
            this.lbOK.TabIndex = 3;
            this.lbOK.Text = "OK";
            this.lbOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbOK.Click += new System.EventHandler(this.lblOkBXH_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 19.8F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(412, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "New Game";
            this.label5.Click += new System.EventHandler(this.btn_newgame_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 19.8F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(236, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Home Screen";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(104)))), ((int)(((byte)(80)))));
            this.textBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 19.8F);
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(241, 136);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 36);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 19.8F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(223, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 116);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Snake_Final.Properties.Resources.gameover;
            this.pictureBox3.Location = new System.Drawing.Point(23, 25);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(195, 211);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake_Final.Properties.Resources.background_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.pnl_gameover);
            this.Controls.Add(this.pnl_pause);
            this.Controls.Add(this.lblScoreMap);
            this.Controls.Add(this.lb_countdown);
            this.Controls.Add(this.lb_scoreboard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBXH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picEdit);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditTile)).EndInit();
            this.pnl_pause.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close_resume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBXH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_gameover.ResumeLayout(false);
            this.pnl_gameover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_game;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox edit;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.PictureBox picEditTile;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox picBXH;
        private System.Windows.Forms.Panel pnl_pause;
        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.Button btn_newgame;
        private System.Windows.Forms.Button btn_exit2;
        private System.Windows.Forms.Button btn_homescreen;
        private System.Windows.Forms.PictureBox btn_close_resume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_scoreboard;
        private System.Windows.Forms.Timer timer_countdown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_countdown;
        private System.Windows.Forms.Label lblScoreMap;
        private System.Windows.Forms.Timer timer_loading;
        private System.Windows.Forms.Panel pnl_gameover;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbOK;
    }
}


