using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LargeGameV2
{
    public class Score
    {
        public float x, y;
        public Bitmap[] S;
        public int iFrame = 0;

    }
    public class background
    {
        public float x, y;
        public Bitmap bb;
    }
    public class end
    {
        public float x, y;
        public Bitmap ee;
    }
    public class again
    {
        public float x, y;
        public Bitmap ag;
    }

    public class ladder
    {
        public float x, y;
        public Bitmap la;
    }
    public class elevator
    {
        public float x, y;
        public Bitmap el;
    }
    public class laser
    {
        public float x, y;
        public Bitmap ls;
    }
    public class end2
    {
        public float x, y;
        public Bitmap eee;
    }
    public class insta
    {
        public float x, y;
        public Bitmap it;
    }
    public class play
    {
        public float x, y;
        public Bitmap pl;
    }
    public class land
    {
        public float x, y;
        public Bitmap l;
    }
    public class elev
    {
        public float x, y;
        public Bitmap vv;
    }
    public class key
    {
        public float x, y;
        public Bitmap k;
    }
    public class alien
    {
        public int X, Y;
        public Bitmap img;
        public int Speed = 5;
    }
    public class Laserr
    {
        public float X, Y, W, H;
        public Color clr = Color.Yellow;
    }

    public class landd
    {
        public float x, y;
        public Bitmap ll;
    }
    public class mario
    {
        public float x, y;
        public Bitmap[] m;
        public Bitmap[] ml;
        public int iFrame = 0;
        public int speed = 10;
        public int dy = 1;
    }
    public class grass
    {
        public float x, y;
        public Bitmap[] g;
        public int iFrame = 0;

    }
    public class turtle
    {
        public float x, y;
        public Bitmap[] t;
        public int dy = 1;
        public int iFrame = 0;

    }
    public class button
    {
        public float x, y;
        public Bitmap b;

    }
    public class magnet
    {
        public float x, y;
        public Bitmap ma;

    }
    public class coin
    {
        public float x, y;
        public Bitmap c;

    }
    public class pipe
    {
        public float x, y;
        public Bitmap p;

    }
    public class exit
    {
        public float x, y;
        public Bitmap ex;

    }
    public class fire
    {
        public float x, y;
        public Bitmap f;


    }
    public class start
    {
        public float x, y;
        public Bitmap s;

    }
    public class marioo
    {
        public float x, y;
        public Bitmap ma;

    }
    public class enemy
    {
        public float x, y;
        public Bitmap e;

    }
    public class enemyy
    {
        public float x, y;
        public Bitmap ey;

    }
    public class one
    {
        public float x, y;
        public Bitmap o;



    }
    public class two
    {
        public float x, y;
        public Bitmap t;



    }

    public partial class Form1 : Form
    {
        Bitmap off;

        Timer tt = new Timer();

        bool isStart = false;

        List<background> background = new List<background>();

        List<start> start = new List<start>();

        List<end> end = new List<end>();

        List<end2> end2 = new List<end2>();

        List<land> land = new List<land>();

        List<landd> landd = new List<landd>();

        List<mario> mario = new List<mario>();

        List<grass> grass = new List<grass>();

        List<button> button = new List<button>();

        List<turtle> turtle = new List<turtle>();

        List<marioo> marioo = new List<marioo>();

        List<Score> Score = new List<Score>();

        List<coin> coin = new List<coin>();

        List<one> one = new List<one>();

        List<alien> alien = new List<alien>();

        List<Laserr> Laserr = new List<Laserr>();

        Laserr pnn;

        List<pipe> pipe = new List<pipe>();

        List<elevator> elevator = new List<elevator>();

        List<laser> laser = new List<laser>();

        List<fire> fire = new List<fire>();

        List<two> two = new List<two>();

        List<again> again = new List<again>();

        List<elev> elev = new List<elev>();

        List<ladder> ladder = new List<ladder>();

        List<magnet> magnet = new List<magnet>();

        List<insta> inst = new List<insta>();

        List<play> play = new List<play>();

        List<exit> exit = new List<exit>();

        List<key> key = new List<key>();

        int camerax = 0, cameray = 0;

        List<enemy> enemy = new List<enemy>();

        List<enemyy> enemyy = new List<enemyy>();

        int iButton = 0;

        int iAgain = 0;

        int iCoin = 0;

        int iWhich3 = 0;

        int YBorder;

        int counter = 0;

        int counter2 = 0;

        int counter3 = 0;

        int flagg = 0;

        int flaggl = 0;

        int score = 0;

        int timer = 50;
        
        int live = 3;
        
        int flags = 0;
        
        int flagst = 0;
        
        
       int flagspace = 0;
       
        int flaggg = 0;
        
        int flagend = 0;
        
        int flagdraw = 0;
        
        int flagup = 0;
        
        int flagdown = 0;
        
        int flagover = 0;
        
        int iRestart = 0;
        
        int flagwin = 0;
        
        int flagcreate = 0;
        
        int jump = 0;
        
        int firee = 0;
        
        int laserr = 0;
        
        int flagelv = 0;
        
        int flaglaser = 0;
        
        int marioloc = 0;
        
        int iAlien = 0;
        
        int flagu = 0;
        
        int iIn = 0;
        
        int iPly = 0;
        
        int flagge = 0;
        
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Load += Form1_Load1;
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
            this.MouseDown += Form1_MouseDown;
            tt.Tick += Tt_Tick;
           
            tt.Start();

        }

        private void Tt_Tick(object sender, EventArgs e)
        {
           

            for (int i = 0; i < coin.Count; i++)
            {
                this.Text = "mario y:" + mario[0].y + " / " + "coin y:" + coin[0].y + " / " + "coin x:" + coin[0].x + " / " + "coin x  camera:" + (coin[0].x + camerax) + " / " + "mario x: " + mario[0].x + " / " + "mario x  camera: " + (mario[0].x + camerax);
                if (mario[0].x == coin[i].x + camerax && mario[0].y + 20 == coin[i].y)
                {

                    coin.RemoveAt(i);
                    i--;
                    for (int k = 0; k < Score.Count; k++)
                    {

                        Score[k].iFrame++;
                    }

                    score++;
                    break;
                }
                if (mario[0].x == 430 && mario[0].y >= 710)
                {
                    coin.RemoveAt(i);
                    i--;
                    for (int k = 0; k < Score.Count; k++)
                    {

                        Score[k].iFrame++;
                    }

                    score++;
                    break;
                }


                if (mario[0].x > 580 && mario[0].y >= 710)
                {
                    coin.RemoveAt(i);
                    i--;
                    for (int k = 0; k < Score.Count; k++)
                    {

                        Score[k].iFrame++;
                    }

                    score++;
                    break;
                }

            }


            for (int i = 0; i < ladder.Count; i++)
            {
                if (mario[0].x == 310)
                {
                    flagup = 1;
                    flagdown = 1;
                    if (mario[0].y + 100 == ladder[i].y)
                    {
                        flagup = 0;
                    }
                }
                else
                {
                    flagdown = 0;
                    flagup = 0;
                }
            }
            for (int i = 0; i < magnet.Count; i++)
            {
                if (flagover != 1)
                {
                    if (mario[0].x == 580)
                    {
                        magnet.RemoveAt(0);
                    }
                }

            }
            for (int i = 0; i < enemy.Count; i++)
            {
                if (flagover != 1 && flagu==1)
                {
                    if (mario[0].x >120 && mario[0].x<170)
                    {
                        enemy.RemoveAt(i);
                       
                    }
                    flagu = 0;
                }

            }
            for (int i = 0; i < enemyy.Count; i++)
            {
                if (flagover != 1 && flagu == 1)
                {
                    if (mario[0].x > 870 && mario[0].x < 960)
                    {
                        enemyy.RemoveAt(i);
                       
                    }
                    flagu = 0;
                }

            }
           
            for (int i = 0; i < elev.Count; i++)
            {
                if (flagover != 1)
                {
                    if (mario[0].x == 1070)
                    {

                        elev[0].y = 300;
                        mario[0].y = 400;
                        flagelv = 1;
                    }
                    if (mario[0].x > 1200)
                    {

                       
                        flagelv = 0;
                        elev[0].y = 650;
                    }
                }

            }

            for (int i = 0; i < elevator.Count; i++)
            {
                if (mario[0].x == 630 || mario[0].x == 640 || mario[0].x == 650 || mario[0].x == 660)
                {

                    mario[0].y = elevator[i].y;


                }

                else if (mario[0].x > 660 && flagelv!=1)

                {
                    mario[0].y = 800;
                }



            }
            if (counter % 1 == 0)
            {

                animateturtle();


            }
            if (counter % 5 == 0)
            {


                animateelevator();

            }
            if (counter2 % 5 == 0)
            {
                animategrass();
                animateblue();
               
            }
            if (counter2 % 8 == 0)
            {
                animatebluee();

            }
          
            if (counter % 10 == 0)
            {
                if(flagover!=1 && flagwin!=1)
                {
                    timer--;
                }
             
            }
            if (flagspace == 1)
            {
                if(flagover!=1)
                {
                    if (mario[0].y == 800 || mario[0].y == 810 || mario[0].y == 380)
                    {
                        jump = 0;
                    }

                    if (mario[0].y >= 800)
                    {

                        flagspace = 0;
                        mario[0].y = 800;


                    }
                    else if (mario[0].x > 70 && mario[0].x < 270 && mario[0].y <= 380)
                    {

                        mario[0].y = 380;
                        if (mario[0].y == 800 || mario[0].y == 810 || mario[0].y == 380)
                        {
                            jump = 0;
                        }

                    }
                    else if (mario[0].x > 415 && mario[0].x < 460 && mario[0].y <= 660)
                    {
                        mario[0].y = 660;
                        if (mario[0].y == 800 || mario[0].y == 810 || mario[0].y == 380)
                        {
                            jump = 0;
                        }

                    }

                    else if (mario[0].x > 270 && mario[0].y >= 380)
                    {
                        mario[0].y += 20;

                    }
                }
             
                
               

            }
            AnimateAllaliens();

            counter++;
            counter2++;
            animatemario();
            DrawDubb();
        }
        void Create_Score(float x, float y)
        {
            Score pnn = new Score();
            pnn.x = x;
            pnn.y = y;
            pnn.S = new Bitmap[10];
            for (int i = 0; i < 10; i++)
            {
                pnn.S[i] = new Bitmap("T" + i + ".jpg");
                pnn.S[i].MakeTransparent(pnn.S[i].GetPixel(0, 0));
            }
            Score.Add(pnn);
        }
        void createone(float x, float y)
        {


            one pnn2 = new one();

            pnn2.x = x;
            pnn2.y = y;
            pnn2.o = new Bitmap("T1.jpg");
            pnn2.o.MakeTransparent(pnn2.o.GetPixel(0, 0));
            one.Add(pnn2);

        }
        void createtwo(float x, float y)
        {


            two pnn2 = new two();

            pnn2.x = x;
            pnn2.y = y;
            pnn2.t = new Bitmap("T2.jpg");
            pnn2.t.MakeTransparent(pnn2.t.GetPixel(0, 0));
            two.Add(pnn2);

        }
        void createLaserr(float x, float y)
        {
            if (flaglaser == 0)
            {
                pnn = new Laserr();
                pnn.X = x;
                pnn.Y = 1;
                pnn.W = 1;
                pnn.H = Height - 250;
                flaglaser = 1;
            }
            Laserr.Add(pnn);
        }
        void CreateSingleStar()
        {
            Random RR = new Random();
            alien pnn2 = new alien();
            pnn2.img = new Bitmap("pp.png");
            pnn2.img.MakeTransparent(pnn2.img.GetPixel(0, 0));
            pnn2.X = RR.Next(0, this.ClientSize.Height);
            pnn2.Y = 0;
            alien.Add(pnn2);
        }

        void create_game()
        {
            int w = 0;
            live = 3;
            score = 0;
            timer = 50;
            flags = 0;
            flagst = 0;
            camerax = 0;
            cameray = 0;
            flagover = 0;
            flagwin = 0;
            create_background(0, 0);
            create_mario(50, 800);
            create_enemy(200, 410);
            create_enemyy(1700, 410);
            create_grass(804, 782);
            create_pipe(805, 781);
            create_turtle(1200, 770);
            Create_Score(880, 50);
            createone(780, 50);


            createtwo(775, 50);
            YBorder = 500;

            for (int i = 0; i < this.ClientSize.Width; i++)
            {
                create_land(w, 920);
                w += land[0].l.Width - 100;
            }

            create_elevator(910, 810);
            create_land(100, 500);
            create_land(200, 500);
            create_land(400, 500);

            create_land(300, 500);
            create_coin(100, 400);
            create_coin(200, 400);
            create_coin(300, 400);
            create_coin(400, 400);
            create_coin(830, 710);
            //
            create_land(1600, 500);
            create_land(1700, 500);
            create_land(1800, 500);

            create_land(1900, 500);

            create_coin(1600, 400);
            create_coin(1700, 400);
            create_coin(1800, 400);
            create_coin(1900, 400);
            create_coin(1400, 800);
            create_coin(1600, 800);
            create_coin(1800, 800);
            create_land(2300, 600);
            create_landd(2400, 600);
            create_land(2500, 600);
            create_land(2800, 500);
            create_coin(2800, 400);
            create_landd(2900, 500);
            create_land(3000, 500);
            create_coin(3000, 400);
            create_coin(2300, 500);

            create_coin(2500, 500);
            create_ladder(540, 560);
            create_magnet(1100, 800);
            create_exit(3420, 720);
            create_ele(1980, 650);
            this.Text = " Super Mario " + "";
            timer--;

        }


        void create_background(float x, float y)
        {
            background pnn = new background();
            pnn.x = x;
            pnn.y = y;
            pnn.bb = new Bitmap("BK.JPG");
            background.Add(pnn);

        }
        void create_start(float x, float y)
        {
            start pnn = new start();
            pnn.x = x;
            pnn.y = y;
            pnn.s = new Bitmap("start.JPG");
            start.Add(pnn);

        }
        void create_ins(float x, float y)
        {
            insta pnn = new insta();
            pnn.x = x;
            pnn.y = y;
            pnn.it = new Bitmap("inst.png");
            inst.Add(pnn);

        }
        void createkey(float x, float y)
        {
            key pnn = new key();
            pnn.x = x;
            pnn.y = y;
            pnn.k = new Bitmap("instt.png");
            key.Add(pnn);

        }
        void create_pla(float x, float y)
        {
            play pnn = new play();
            pnn.x = x;
            pnn.y = y;
            pnn.pl = new Bitmap("st.png");
            play.Add(pnn);

        }
        void create_landd(float x, float y)
        {
            landd pnn = new landd();
            pnn.x = x;
            pnn.y = y;
            pnn.ll = new Bitmap("bb.png");
            landd.Add(pnn);

        }
       
        void create_magnet(float x, float y)
        {
            magnet pnn = new magnet();
            pnn.x = x;
            pnn.y = y;
            pnn.ma = new Bitmap("magnet.png");
            magnet.Add(pnn);

        }
        void create_ele(float x, float y)
        {
            elev pnn = new elev();
            pnn.x = x;
            pnn.y = y;
            pnn.vv = new Bitmap("eleee.png");
            elev.Add(pnn);

        }
        void create_exit(float x, float y)
        {
            exit pnn = new exit();
            pnn.x = x;
            pnn.y = y;
            pnn.ex = new Bitmap("exit.png");
            exit.Add(pnn);

        }
        void create_laser(float x, float y)
        {
            laser pnn = new laser();
            pnn.x = mario[0].x + 50;
            pnn.y = mario[0].y + 50;
            pnn.ls = new Bitmap("laser.png");
            laser.Add(pnn);

        }
        void create_elevator(float x, float y)
        {
            elevator pnn = new elevator();
            pnn.x = x;
            pnn.y = y;
            pnn.el = new Bitmap("ele.png");
            elevator.Add(pnn);

        }
        void create_ladder(float x, float y)
        {
            ladder pnn = new ladder();
            pnn.x = x;
            pnn.y = y;
            pnn.la = new Bitmap("ladder.png");
            ladder.Add(pnn);

        }
        void create_button(float x, float y)
        {
            button pnn = new button();
            pnn.x = x;
            pnn.y = y;
            pnn.b = new Bitmap("button.png");
            button.Add(pnn);

        }
        void create_again(float x, float y)
        {
            again pnn = new again();
            pnn.x = x;
            pnn.y = y;
            pnn.ag = new Bitmap("again.png");
            again.Add(pnn);

        }
        void create_marioo(float x, float y)
        {
            marioo pnn = new marioo();
            pnn.x = x;
            pnn.y = y;
            pnn.ma = new Bitmap("mariooo.png");
            marioo.Add(pnn);

        }
        void create_pipe(float x, float y)
        {
            pipe pnn = new pipe();
            pnn.x = x;
            pnn.y = y;
            pnn.p = new Bitmap("pipe.png");
            pipe.Add(pnn);

        }
        void create_fire(float x, float y)
        {
            fire pnn = new fire();
            pnn.x = mario[0].x + 100;
            pnn.y = mario[0].y + 50;
            pnn.f = new Bitmap("fire.png");
            fire.Add(pnn);

        }
        void create_coin(float x, float y)
        {
            coin pnn = new coin();
            pnn.x = x;
            pnn.y = y;
            pnn.c = new Bitmap("coin.png");
            coin.Add(pnn);

        }
        void create_end(float x, float y)
        {
            end pnn = new end();
            pnn.x = x;
            pnn.y = y;
            pnn.ee = new Bitmap("end.png");
            end.Add(pnn);

        }
        void create_end2(float x, float y)
        {
            end2 pnn = new end2();
            pnn.x = x;
            pnn.y = y;
            pnn.eee = new Bitmap("end2.png");
            end2.Add(pnn);

        }
        void create_enemy(float x, float y)
        {
            enemy pnn = new enemy();
            pnn.x = x;
            pnn.y = y;
            pnn.e = new Bitmap("ene.png");
            enemy.Add(pnn);

        }
        void create_enemyy(float x, float y)
        {
            enemyy pnn = new enemyy();
            pnn.x = x;
            pnn.y = y;
            pnn.ey = new Bitmap("ene.png");
            enemyy.Add(pnn);

        }
        void create_land(float x, float y)
        {
            land pnn = new land();
            pnn.x = x;
            pnn.y = y;
            pnn.l = new Bitmap("land3.JPG");
            land.Add(pnn);

        }
        void create_mario(float x, float y)
        {
            mario pnn = new mario();
            pnn.x = x;
            pnn.y = y;
            pnn.m = new Bitmap[2];
            pnn.ml = new Bitmap[2];
            for (int i = 0; i < 2; i++)
            {
                pnn.m[i] = new Bitmap("mario" + (i + 1) + ".png");

            }
            for (int i = 0; i < 2; i++)
            {
                pnn.ml[i] = new Bitmap("mariol" + (i + 1) + ".png");

            }
            mario.Add(pnn);

        }
        void create_grass(float x, float y)
        {
            grass pnn = new grass();
            pnn.x = x;
            pnn.y = y;
            pnn.g = new Bitmap[2];

            for (int i = 0; i < 2; i++)
            {
                pnn.g[i] = new Bitmap("enee" + (i + 1) + ".png");
                pnn.g[i].MakeTransparent(pnn.g[i].GetPixel(0, 0));
            }
            grass.Add(pnn);

        }
        void create_turtle(float x, float y)
        {
            turtle pnn = new turtle();
            pnn.x = x;
            pnn.y = y;
            pnn.t = new Bitmap[2];

            for (int i = 0; i < 2; i++)
            {
                pnn.t[i] = new Bitmap("eneee" + (i + 1) + ".png");
                pnn.t[i].MakeTransparent(pnn.t[i].GetPixel(0, 0));
            }
            turtle.Add(pnn);

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            iButton = HitStartGame(e.X, e.Y);
            iRestart = Hitrestart(e.X, e.Y);
            iAgain = Hitagain(e.X, e.Y);
            iIn = Hitins(e.X, e.Y);
            iPly = Hitpla(e.X, e.Y);
            if (iButton != -1)
            {
                isStart = true;
                button.RemoveAt(0);
                start.RemoveAt(0);
                marioo.RemoveAt(0);
                create_game();
                flagcreate = 1;
            }
            if (iPly != -1)
            {
                isStart = true;
                button.RemoveAt(0);
                
                marioo.RemoveAt(0);
                create_game();
                flagcreate = 1;
            }
            if (iRestart != -1)
            {
                isStart = true;
                end2.RemoveAt(0);


                create_game();
            }
            if (iAgain != -1)
            {
                isStart = true;
                again.RemoveAt(0);


                create_game();
            }
            if (iIn != -1)
            {
               
                start.RemoveAt(0);
                marioo.RemoveAt(0);
                inst.RemoveAt(0);
               
                button.RemoveAt(0);
                create_pla(900, 90); ;
                createkey(250, 160);
               
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }
        void animatemario()
        {



        }
        void animateblue()
        {
            for (int i = 0; i < enemy.Count; i++)
            {
                if (enemy[i].x < 600 && flagg == 0)
                {
                    enemy[i].x += 120;
                    flagg = 1;

                }
                else if (enemy[i].x > 200 && flagg == 1)
                {
                    enemy[i].x -= 120;
                    flagg = 0;
                }
            }
        }
        void animatebluee()
        {
            for (int i = 0; i < enemyy.Count; i++)
            {
                if (enemyy[i].x < 2100 && flagge == 0)
                {
                    enemyy[i].x += 120;
                    flagge = 1;

                }
                else if (enemyy[i].x > 1700 && flagge == 1)
                {
                    enemyy[i].x -= 120;
                    flagge = 0;
                }
            }
        }
        void animateelevator()
        {
            for (int i = 0; i < elevator.Count; i++)
            {
                if (elevator[i].y < 1000 && flaggl == 1)
                {
                    elevator[i].y += 300;
                    flaggl = 0;

                }
                else if (elevator[i].y > 600 && flaggl == 0)
                {
                    elevator[i].y -= 300;
                    flaggl = 1;
                }
            }
        }
        void AnimateAllaliens()
        {
            for (int i = 0; i < alien.Count; i++)
            {
               
                alien[i].Y += alien[i].Speed;


                if (alien[i].Y >= 800)
                {
                    alien[i].Speed = 0;
                    live--;
                }
            }
        }

        void animategrass()
        {
            //create_grass(804, 782);
            for (int i = 0; i < grass.Count; i++)
            {
                grass[i].iFrame++;

                if (grass[i].iFrame > 2)
                {
                    grass[i].iFrame--;

                }
                else if (grass[i].iFrame < 1)
                {
                    grass[i].iFrame++;

                }
                if (grass[i].y < 900 && flaggg == 0)
                {
                    grass[i].y -= 120;
                    flaggg = 1;

                }
                else if (grass[i].x > 700 && flaggg == 1)
                {
                    grass[i].y += 120;
                    flaggg = 0;
                }
            }
        }
        void animateturtle()
        {
            for (int i = 0; i < turtle.Count; i++)
            {
                turtle[i].iFrame++;
                if (turtle[i].x > 1000 && turtle[i].x != 1400)
                {
                    turtle[i].x -= 10;


                }
                else if (turtle[i].x == 1000)
                {
                    turtle[i].x += 200;
                }
                if (turtle[i].iFrame > 2)
                {
                    turtle[i].iFrame--;


                }

                else if (turtle[i].iFrame < 1)
                {
                    turtle[i].iFrame++;

                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (flagover != 1 && flagwin != 1)
            {
                float x = mario[0].x;
                float y = mario[0].y;
                switch (e.KeyCode)
                {
                    case Keys.Right:

                        if (laserr == 1)
                        {
                            laser.RemoveAt(0);
                            laserr = 0;
                        }
                        for (int k = 0; k < mario.Count; k++)
                        {

                            mario[0].dy = 1;
                            mario[k].x += 10;

                            if (mario[k].x < 1730 && mario[k].x > 60)
                            {
                                camerax -= 10;
                            }
                            mario[k].iFrame++;
                            if (mario[k].iFrame == 2)
                            {
                                mario[k].iFrame = 0;
                            }
                        }

                        break;
                    case Keys.Left:

                        if (firee == 1)
                        {
                            fire.RemoveAt(0);
                            firee = 0;
                        }
                        for (int i = 0; i < mario.Count; i++)
                        {
                            mario[0].dy = 0;
                            mario[i].x -= 10;
                            
                            if (mario[i].x < 1730 && mario[i].x > 60)
                            {
                                camerax += 10;
                            }
                            mario[i].iFrame++;
                            if (mario[i].iFrame == 2)
                            {
                                mario[i].iFrame = 0;
                            }
                        }

                        break;
                    case Keys.Space:
                        if(jump==0)
                        {
                            mario[0].y -= 100;
                            cameray -= 10;
                            flagspace = 1;
                            jump = 1;
                        }
                      

                        break;
                    case Keys.Up:

                        if (flagup == 1)
                        {
                            mario[0].y -= 10;
                        }

                        break;
                    case Keys.Down:

                        if (flagdown == 1)
                        {
                            if(mario[0].y<800)
                            {
                                mario[0].y += 10;
                            }
                           

                        }

                        break;
                    case Keys.U:
                       
                        createLaserr(x, y);
                        flagu = 1;
                        break;

                    case Keys.Escape:
                        tt.Stop();
                    
                        isStart = false;
                        MessageBox.Show("Pause | Click OK to Resume");
                        isStart = true;
                        tt.Start();
                        break;

                    case Keys.F:


                        if (mario[0].y + 30 == enemy[0].y)
                        {
                            create_fire(x, y);
                            enemy.RemoveAt(0);
                            firee = 1;
                        }

                        break;
                    case Keys.L:
                        if (mario[0].y - 30 == turtle[0].y && mario[0].x > 300)
                        {
                            create_laser(x, y);
                            turtle.RemoveAt(0);
                            laserr = 1;
                        }


                        break;


                }
                /*
                iWhich3 = Hitland(mario[0].x, mario[0].y, mario[0].x + mario[0].m[mario[0].iFrame].Width, mario[0].m[mario[0].iFrame].Height);
                if (iWhich3 != -1)
                {
                    mario[0].x = x;
                    mario[0].y = y;
                }*/
            }








            for (int i = 0; i < enemy.Count; i++)
            {
                if (mario[0].x == enemy[i].x && mario[0].y <= enemy[i].y)
                {


                    live--;


                }
            }
            for (int i = 0; i < turtle.Count; i++)
            {
                if (mario[0].x == turtle[i].x && mario[0].y <= turtle[i].y)
                {


                    live--;


                }
            }
            for (int i = 0; i < grass.Count; i++)
            {
                if (mario[0].x == grass[i].x && mario[0].y <= grass[i].y)
                {


                    live--;


                }
            }


        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubb();

        }

        private void Form1_Load1(object sender, EventArgs e)
        {

            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            create_start(0, 0);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void DrawScene(Graphics g2)
        {

            if (!isStart)
            {
                create_marioo(150, 100);
                create_button(this.ClientSize.Width / 2 - 130, this.ClientSize.Height / 2 + 100);
                create_ins(this.ClientSize.Width / 2-250, this.ClientSize.Height / 2 + 300);
            }







            for (int i = 0; i < start.Count; i++)
            {

                Rectangle rcDst = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
                Rectangle rcSrc = new Rectangle(0, 0, start[i].s.Width, start[i].s.Height);
                g2.DrawImage(start[i].s, rcDst, rcSrc, GraphicsUnit.Pixel);
            }

            for (int i = 0; i < button.Count; i++)
            {
                g2.DrawImage(button[i].b, button[i].x, button[i].y);
            }


            for (int i = 0; i < inst.Count; i++)
            {
                g2.DrawImage(inst[i].it, inst[i].x, inst[i].y);
            }


            for (int i = 0; i < play.Count; i++)
            {
                g2.DrawImage(play[i].pl, play[i].x, play[i].y);
            }
           

            for (int i = 0; i < marioo.Count; i++)
            {
                g2.DrawImage(marioo[i].ma, marioo[i].x, marioo[i].y);
            }


            for (int i = 0; i < key.Count; i++)
            {
                g2.DrawImage(key[i].k, key[i].x, key[i].y);
            }

            for (int i = 0; i < background.Count; i++)
            {

                Rectangle rcDst = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
                Rectangle rcSrc = new Rectangle(0, 0, background[i].bb.Width, background[i].bb.Height);
                g2.DrawImage(background[i].bb, rcDst, rcSrc, GraphicsUnit.Pixel);
            }
            for (int i = 0; i < land.Count; i++)
            {


                g2.DrawImage(land[i].l, land[i].x + camerax, land[i].y);


            }
            for (int i = 0; i < landd.Count; i++)
            {


                g2.DrawImage(landd[i].ll, landd[i].x + camerax, landd[i].y);

            }
            for (int i = 0; i < coin.Count; i++)
            {

                g2.DrawImage(coin[i].c, coin[i].x + camerax, coin[i].y);


            }
            for (int i = 0; i < ladder.Count; i++)
            {

                g2.DrawImage(ladder[i].la, ladder[i].x + camerax, ladder[i].y);


            }
            for (int i = 0; i < fire.Count; i++)
            {
                g2.DrawImage(fire[i].f, fire[i].x + camerax, fire[i].y);
            }
            for (int i = 0; i < laser.Count; i++)
            {

                g2.DrawImage(laser[i].ls, laser[i].x + camerax, laser[i].y);


            }
            for (int i = 0; i < elevator.Count; i++)
            {

                g2.DrawImage(elevator[i].el, elevator[i].x + camerax, elevator[i].y);


            }
            for (int i = 0; i < enemy.Count; i++)
            {

                g2.DrawImage(enemy[i].e, enemy[i].x + camerax, enemy[i].y);



            }
            for (int i = 0; i < enemyy.Count; i++)
            {

                g2.DrawImage(enemyy[i].ey, enemyy[i].x + camerax, enemyy[i].y);



            }
            for (int i = 0; i < mario.Count; i++)
            {
                if (mario[i].dy == 1)
                {
                    if (mario[0].iFrame < 2)
                    {

                        g2.DrawImage(mario[i].m[mario[i].iFrame], mario[marioloc].x, mario[marioloc].y);
                    }
                    else
                    {
                        mario[i].iFrame = 0;
                        g2.DrawImage(mario[i].m[mario[i].iFrame], mario[marioloc].x, mario[marioloc].y);
                    }
                }
                else
                {
                    if (mario[0].iFrame < 2)
                    {


                        g2.DrawImage(mario[i].ml[mario[i].iFrame], mario[marioloc].x, mario[marioloc].y);
                    }
                    else
                    {
                        mario[i].iFrame = 0;
                        g2.DrawImage(mario[i].ml[mario[i].iFrame], mario[marioloc].x, mario[marioloc].y);
                    }
                }

            }

            for (int i = 0; i < grass.Count; i++)
            {
                if (grass[i].iFrame < 2)
                {
                    if (mario[0].x > 60 && mario[0].x < 2000)
                    {
                        g2.DrawImage(grass[i].g[grass[i].iFrame], grass[i].x + camerax, grass[i].y);
                    }
                    else
                    {
                        g2.DrawImage(grass[i].g[grass[i].iFrame], grass[i].x, grass[i].y);
                    }

                }
                else
                {
                    grass[i].iFrame = 0;
                    if (mario[0].x > 60 && mario[0].x < 2000)
                    {
                        g2.DrawImage(grass[i].g[grass[i].iFrame], grass[i].x + camerax, grass[i].y);
                    }
                    else
                    {
                        g2.DrawImage(grass[i].g[grass[i].iFrame], grass[i].x, grass[i].y);
                    }
                }

            }
            for (int i = 0; i < pipe.Count; i++)
            {

                g2.DrawImage(pipe[i].p, pipe[i].x + camerax, pipe[i].y);



            }
            for (int i = 0; i < exit.Count; i++)
            {

                g2.DrawImage(exit[i].ex, exit[i].x + camerax, exit[i].y);



            }
            for (int i = 0; i < magnet.Count; i++)
            {

                g2.DrawImage(magnet[i].ma, magnet[i].x + camerax, magnet[i].y);




            }
            for (int i = 0; i < Laserr.Count; i++)
            {


                if (flaglaser == 1)
                {
                    Pen pn = new Pen(Color.Yellow, 2);
                    g2.DrawRectangle(pn, mario[marioloc].x + mario[marioloc].m[mario[marioloc].iFrame].Width / 2, Laserr[i].Y, Laserr[i].W, Laserr[i].H);
                    flaglaser = 0;
                }


            }

            for (int i = 0; i< elev.Count; i++)
            {

                g2.DrawImage(elev[i].vv, elev[i].x + camerax, elev[i].y);



            }
            for (int i = 0; i < alien.Count; i++)
            {

                g2.DrawImage(alien[i].img, alien[i].X + camerax, alien[i].Y);



            }
            for (int i = 0; i < turtle.Count; i++)
            {
                if (turtle[i].iFrame < 2)
                {
                    if (mario[0].x > 60 && mario[0].x < 2000)
                    {
                        g2.DrawImage(turtle[i].t[turtle[i].iFrame], turtle[i].x + camerax, turtle[i].y);
                    }
                    else
                    {
                        g2.DrawImage(turtle[i].t[turtle[i].iFrame], turtle[i].x, turtle[i].y);
                    }

                }
                else
                {
                    turtle[i].iFrame = 0;
                    if (mario[0].x > 60 && mario[0].x < 2000)
                    {
                        g2.DrawImage(turtle[i].t[turtle[i].iFrame], turtle[i].x + camerax, turtle[i].y);
                    }
                    else
                    {
                        g2.DrawImage(turtle[i].t[turtle[i].iFrame], turtle[i].x, turtle[i].y);
                    }
                }

            }
            for (int i = 0; i < Score.Count; i++)
            {
                if (Score[i].iFrame < 10)
                {

                    g2.DrawImage(Score[i].S[Score[i].iFrame], Score[i].x, Score[i].y);
                    if (flags == 1)
                    {
                        g2.DrawImage(one[0].o, one[0].x, one[0].y);
                    }
                    if (flagst == 1)
                    {

                        // one.Remove(one[0]);
                        g2.DrawImage(two[0].t, two[0].x, two[0].y);
                    }
                }
                else if (Score[i].iFrame == 10 && score != 20)
                {
                    Score[i].iFrame = 0;
                    //Create_Score2(700,50);
                    flags = 1;

                }
                else if (Score[i].iFrame == 10 && score == 20)
                {
                    Score[i].iFrame = 0;
                    flags = 0;
                    flagst = 1;
                }

            }


            if (live == 0 || timer==0)
            {
                flagover = 1;
                background[0].bb = new Bitmap("end.png");
                create_end2(700, 300);
                g2.DrawImage(end2[0].eee, end2[0].x, end2[0].y);
                delete_game();
               
            }
            for (int i = 0; i < exit.Count; i++)
            {
                if (mario[0].x == 1750)
                {
                    create_again(700, 200);
                    background[0].bb = new Bitmap("win.png");

                    delete_game();

                    flagwin = 1;

                }
            }
            for (int i = 0; i < again.Count; i++)
            {
                g2.DrawImage(again[i].ag, again[i].x, again[i].y);
            }
            if (isStart)
            {
                Font f = new Font(Name, 20);
                Brush brush = new SolidBrush(Color.White);
                Brush brush2 = new SolidBrush(Color.Yellow);
                Brush brush3 = new SolidBrush(Color.White);
                Brush brush5 = new SolidBrush(Color.Red);
                Brush brush6 = new SolidBrush(Color.DarkBlue);
                g2.DrawString("score : " + score.ToString(), f, brush, 10, 10);
                g2.DrawString("Live : " + live.ToString(), f, brush, 10, 50);
                g2.DrawString("Timer : " + timer.ToString(), f, brush2, 10, 90);
            }
        }
        void DrawDubb()
        {
            Graphics g = CreateGraphics();
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }


        int HitStartGame(float XM, float YM)
        {
            for (int i = 0; i < button.Count; i++)
            {
                float xs = button[i].x;
                float xe = button[i].x + button[i].b.Width;
                float ys = button[i].y;
                float ye = button[i].y + button[i].b.Height;
                if (XM >= xs && XM <= xe && YM >= ys && YM <= ye)
                {
                    return i;

                }


            }
            return -1;
        }


        int Hitrestart(float XM, float YM)
        {
            for (int i = 0; i < end2.Count; i++)
            {
                float xs = end2[i].x;
                float xe = end2[i].x + end2[i].eee.Width;
                float ys = end2[i].y;
                float ye = end2[i].y + end2[i].eee.Height;
                if (XM >= xs && XM <= xe && YM >= ys && YM <= ye)
                {
                    return i;

                }


            }
            return -1;
        }


        int Hitpla(float XM, float YM)
        {
            for (int i = 0; i < play.Count; i++)
            {
                float xs = play[i].x;
                float xe = play[i].x + play[i].pl.Width;
                float ys = play[i].y;
                float ye = play[i].y + play[i].pl.Height;
                if (XM >= xs && XM <= xe && YM >= ys && YM <= ye)
                {
                    return i;

                }


            }
            return -1;
        }


        int Hitagain(float XM, float YM)
        {
            for (int i = 0; i < again.Count; i++)
            {
                float xs = again[i].x;
                float xe = again[i].x + again[i].ag.Width;
                float ys = again[i].y;
                float ye = again[i].y + again[i].ag.Height;
                if (XM >= xs && XM <= xe && YM >= ys && YM <= ye)
                {
                    return i;

                }


            }
            return -1;
        }


        int Hitins(float XM, float YM)
        {
            for (int i = 0; i < inst.Count; i++)
            {
                float xs = inst[i].x;
                float xe = inst[i].x + inst[i].it.Width;
                float ys = inst[i].y;
                float ye = inst[i].y + inst[i].it.Height;
                if (XM >= xs && XM <= xe && YM >= ys && YM <= ye)
                {
                    return i;

                }


            }
            return -1;
        }


        int Hitalien(float XM)
        {
            for (int i = 0; i < alien.Count; i++)
            {
                float xs = alien[i].X;
                float xe = alien[i].X + alien[i].img.Width;
                if (XM >= xs && XM <= xe)
                {

                    return i;
                }

            }
            return -1;
        }


        int HitCoin(float XM, float YM)
        {
            for (int i = 0; i < coin.Count; i++)
            {
                float xs = coin[i].x;
                float xe = coin[i].x + coin[i].c.Width;
                float ys = coin[i].y;
                float ye = coin[i].y + coin[i].c.Height;
                if (XM >= xs && XM <= xe && YM >= ys && YM <= ye)
                {
                    return i;

                }


            }
            return -1;
        }


        int Hitland(float XM, float YM, float XU, float YU)
        {
            for (int i = 0; i < land.Count; i++)
            {
                float xs = land[i].x;
                float xe = land[i].x + land[i].l.Width;
                float ys = land[i].y;
                float ye = land[i].y + land[i].l.Height;
                if (XM >= xs && XM <= xe && YM >= ys && YM <= ye ||
                    XU >= xs && XU <= xe && YM >= ys && YM <= ye ||
                    XM >= xs && XM <= xe && YU >= ys && YU <= ye ||
                    XU >= xs && XU <= xe && YU >= ys && YU <= ye)
                {
                    return i;
                }


            }
            return -1;
        }

        void delete_game()
        {
            
            while (land.Count > 0)
            {
                land.RemoveAt(0);
            }

            while (enemy.Count > 0)
            {
                enemy.RemoveAt(0);
            }

            while (enemyy.Count > 0)
            {
                enemyy.RemoveAt(0);
            }

            while (grass.Count > 0)
            {
                grass.RemoveAt(0);
            }

            while (coin.Count > 0)
            {
                coin.RemoveAt(0);
            }

            while (turtle.Count > 0)
            {
                turtle.RemoveAt(0);
            }

            while (ladder.Count > 0)
            {
                ladder.RemoveAt(0);
            }

            while (elevator.Count > 0)
            {
                elevator.RemoveAt(0);
            }

            while (mario.Count > 0)
            {
                mario.RemoveAt(0);
            }

            while (landd.Count > 0)
            {
                landd.RemoveAt(0);
            }

            while (pipe.Count > 0)
            {
                pipe.RemoveAt(0);
            }

            while (fire.Count > 0)
            {
                fire.RemoveAt(0);
            }

            while (laser.Count > 0)
            {
                laser.RemoveAt(0);
            }

            while (one.Count > 0)
            {
                one.RemoveAt(0);
            }

            while (two.Count > 0)
            {
                two.RemoveAt(0);
            }

            while (Score.Count > 0)
            {
                Score.RemoveAt(0);
            }

            while (exit.Count > 0)
            {
                exit.RemoveAt(0);
            }

            while (magnet.Count > 0)
            {
                magnet.RemoveAt(0);
            }

            while (elev.Count > 0)
            {
                elev.RemoveAt(0);
            }

            while (play.Count > 0)
            {
                play.RemoveAt(0);
            }

            while (inst.Count > 0)
            {
                inst.RemoveAt(0);
            }

            while (key.Count > 0)
            {
                key.RemoveAt(0);
            }

        }

    }
}


