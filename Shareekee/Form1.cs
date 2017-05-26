/*Данная программа написана анонимусом во имя лулзов.*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shareekee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YobaBox_MouseMove(object sender, MouseEventArgs e)
        {

        }
        

        private void Render()
        {
            
         sosach.bmp = new Bitmap(YobaBox.BackgroundImage);
         sosach.DrawBitard();
            
         YobaBox.Image = sosach.bmp;
        }

        private void EndGame(object sender, sosachArgs e)
        {
            AnalClock.Enabled = false;
            sosach.ClearList();
            YobaBox.Image = e.img;
            EBLABEL.Text = e.msg;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            EBLABEL.Text = "";
            ScoreL.Text = "";
            ScoreL.Text = lblScore.Text;
            sosach.ClearList();
            sosach.GenerateField();
            
            sosach.Perekat();
            Render();
            AnalClock.Enabled = true;

        }

        private void AnalClock_Tick(object sender, EventArgs e)
        {
            sosach.PerdakNagrev();
            if (sosach.roll())
            {
                Render();
                lblScore.Text = sosach.score.ToString();
                lblPerdak.Text = sosach.perdak.ToString();
            }
            
        }

        private void YobaBox_MouseClick(object sender, MouseEventArgs e)
        {//Мышеклик
            
            sosach.SetPenisDirection(new Point(e.X,e.Y));
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(c) by Anonymous, 2017");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sosach.GameOver += EndGame;
            YobaBox.BackgroundImage = sosach.pic();

        }
    }
   
    internal class sosachArgs : EventArgs
    {
        private readonly string m_message;       
        private readonly Int32 m_flag;
        private readonly Image m_img;

        public sosachArgs(string msg, Int32 flg, Image img) { m_message = msg; m_flag = flg; m_img = img; }

        public Image img { get { return m_img; } }
        public string msg { get { return m_message; } }
        public Int32 flag { get { return m_flag; } }


    }
     static internal class sosach 
    {
         public static bool game=false;
        public static event EventHandler<sosachArgs> GameOver;
        private static Int32 microroll = 72;

        private static Int32 m_perdak;

        public static Int32 perdak
        {

            set { m_perdak = value; microroll = m_perdak<-200?5:m_perdak<100?10:m_perdak<0?20:m_perdak<40?30:m_perdak<80?40:50; if (m_perdak >= 100) { OnGameOver(new sosachArgs("Пердак воспламенился!",0,Shareekee.Properties.Resources.pukan_fire)); }; if (m_perdak < -273) { m_perdak = -273; }; }
            get { return m_perdak; }
        }

        private static void OnGameOver(sosachArgs sa)
        { 
            EventHandler<sosachArgs> temp = GameOver;
            if (temp != null) temp(typeof(sosach),sa);
    }
        public static Dictionary<Int32, Image> Backgrounds = new Dictionary<Int32, Image>() { { 0, Shareekee.Properties.Resources.zadnique1 }, { 1, Shareekee.Properties.Resources.zadnique2 }, { 2, Shareekee.Properties.Resources.zadnique3 }, { 3, Shareekee.Properties.Resources.zadnique4 }, { 4, Shareekee.Properties.Resources.zadnique5 }, { 5, Shareekee.Properties.Resources.zadnique6 }, { 6, Shareekee.Properties.Resources.zadnique7 }, { 7, Shareekee.Properties.Resources.zadnique8 } };

        public static Int32 score;
         static  Dictionary<Int32,Color> RandomTrash = new Dictionary<Int32,Color>()
         {{0,Color.Yellow},   {2,Color.Blue},   {3,Color.Red},   {4,Color.Black},   {1,Color.Green}};
         static Dictionary<Int32, Icon> YobaFaces = new Dictionary<Int32, Icon>() 
         { { 0, Shareekee.Properties.Resources.Yoba1 }, 
         { 2,  Shareekee.Properties.Resources.yoba2 }, 
         { 3,  Shareekee.Properties.Resources.yoba3 }, 
         { 4,  Shareekee.Properties.Resources.yoba4 }, 
         { 1,  Shareekee.Properties.Resources.yoba5 },
         { 5,  Shareekee.Properties.Resources.yoba6 },
         { 6,  Shareekee.Properties.Resources.yoba7 },
         { 7,  Shareekee.Properties.Resources.yoba8 }};
         public const Int32 radius = 20;
         const Int32 HorRes = 800;
         const Int32 VertRes = 600;
        const Int32 left = radius;
        const Int32 right = HorRes-radius ;
        const Int32 top = radius;
        const Int32 bottom = VertRes-radius;
        const Int32 YobaCount=133;
        
         static sosach(){gandoshka= new Random();}
         private static Random gandoshka;
         public static void PerdakNagrev() { perdak += gandoshka.Next(100) > 95 ? gandoshka.Next(3) : 0; }
         private static Color rColor() { return RandomTrash[gandoshka.Next(4)]; }         public static Image pic() {   return (DateTime.Now > new DateTime(2017, 05, 29))?Backgrounds[gandoshka.Next(8)]:Backgrounds[0];}

        private static bool anal_limit( this Int32 x, Int32 min, Int32 max)
        {return ((x<=max)&&(x>=min));}
        private static Bitmap m_bmp;
        //public static Yoba bitard;
        public static Yoba rollingyoba;

        private static Point m_penis;

        private static Point m_yobavector;

        private static Int32 anvalveindexera() { return gandoshka.Next(15);}
  
        private static List<Yoba>Yobas = new List<Yoba>();
        private static List<Yoba> RollingYobas = new List<Yoba>();

        private static Graphics g;
    public static Bitmap bmp { get { return m_bmp; } set{m_bmp=value; g = Graphics.FromImage(bmp);} }

    public static void ClearList() { game = false;  Yobas.Clear(); score = 0; perdak = 36; }
    public static void SetPenisDirection(Point PenisDir)
    {
        if(LaunchEnabled){
        m_penis = PenisDir; 
        rollingyoba.vector = nahui(rollingyoba, m_penis); rollingyoba.resetstate(); 
        }
        LaunchEnabled = false;
       
    }
    private static bool LaunchEnabled = false;
        
        private delegate PointF trans2d(Yoba Ball, Point G);
        private delegate float trans1d(double x1, double y1, double x2, double y2);
        private static trans1d penislength = (x1, y1, x2, y2) => (Single)Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
        private static trans2d nahui = (chego, kuda) => new PointF((kuda.X - chego.x) / penislength(chego.x, chego.y, kuda.X, kuda.Y), (kuda.Y - chego.y) / penislength(chego.x, chego.y, kuda.X, kuda.Y));
        
        public static void GenerateField()
        {
            
            for (int i=0;i<YobaCount;i++)
            {
                Int32 YobasInRow=((right-left)/(2*radius));
                Yobas.Add(new Yoba(left + radius + (i) % (YobasInRow) * (2 * radius), top + radius + (i) / (YobasInRow) * (2 * radius), rColor(), gandoshka.Next(YobaFaces.Count)));
            }
            game = true;
        }

        public static bool wallcollision(Yoba b) //Условие остановки Йобы
        {
            return !(b.x.anal_limit(left, right) && b.y.anal_limit(top, bottom));
        }

        public static bool end_roll(Yoba b) //Условие остановки Йобы
        {
            bool stop = false; 
          foreach (Yoba yobik in Yobas) { stop |= (yobik.touch(b)); };
            return (stop || wallcollision(b)); 
        }
        public static bool roll()
        {

            bool result = true;
            for (int i = 0; i < microroll;i++ )
                if (!end_roll(rollingyoba))
                                {
                                    rollingyoba.move(1);

            //                        rollingyoba.x++;

                                }
                                else
                                {

                                    if (!YobaDestroy(rollingyoba))
                                    {
                                        Yobas.Add(rollingyoba);
                                        perdak += anvalveindexera();
                                    }
                                    else { perdak -= gandoshka.Next(5); }
                                    Perekat();
                                    //RollingYobas.RemoveAt(i);
                                    
                                    result = false;
                                }


            if ((game)&&(Yobas.Count == 0)) { OnGameOver(new sosachArgs("Вы выиграли!", 0, Shareekee.Properties.Resources.YOBASMILE)); }
                
            return result;
        }

        
        public static bool YobaDestroy(Yoba yobushka)
        {
            bool result = true; ;
            bool it = false;

            //Предварительный проход - поджигаем пердаки
            if (Yobas.Count > 0)
                foreach (Yoba yobik in Yobas)
                // for(int i)
                {
                    if (yobushka.neighbour(yobik) && (yobushka.color == yobik.color) && (yobik.perdak == 0))
                    {
                        //   MessageBox.Show("Пукан горит!");
                        yobik.Ignite();
                        result = true; it = true;
                    }
                }

            while (result)//Главный проход - пердаки детонируют
            {
                result = false;
                if (Yobas.Count > 0)
                   foreach (Yoba yobik1 in Yobas)
                       if (yobik1.perdak>0)
                    foreach (Yoba yobik in Yobas)
                    // for(int i)
                    {
                        
                        if (yobik1.neighbour(yobik) && (yobik1.color == yobik.color) && (yobik.perdak == 0))
                        {
                            yobik.Ignite();
                            result = true; it = true;
                        }
                    }
            }

          //var Indexes= new List<Int32>();
            for (int j=Yobas.Count-1;j>=0;j--)
                if (0 != Yobas[j].perdak) { Yobas.RemoveAt(j); score++; }

                return it;

        }

        public static void Perekat()
        {
            rollingyoba = new Yoba(400, 550, rColor(), gandoshka.Next(YobaFaces.Count));
            LaunchEnabled = true;
            
        }
        public static void FirePukan()
        {
          
        }

        private static void DrawYoba(Yoba eblo)//Рисуем колобков
        {
        Pen pen1 = new Pen(Color.Black,2);
        //g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            Rectangle YobaFace=new Rectangle(eblo.x-Yoba.radius,eblo.y-Yoba.radius,Yoba.radius*2,Yoba.radius*2);
           // Rectangle YobaIcon=new Rectangle(eblo.x-Yoba.radius+4,eblo.y-Yoba.radius+4,Yoba.radius*2-4,Yoba.radius*2-4);
            SolidBrush brush = new SolidBrush(eblo.color);
        g.FillEllipse(brush,YobaFace);
        g.DrawIcon(YobaFaces[eblo.ebliwko], eblo.x - Yoba.radius + 4, eblo.y - Yoba.radius + 4);
        //g.DrawImage(Shareekee.Properties.Resources.red, new Point(eblo.x - Yoba.radius+5, eblo.y - Yoba.radius+5));
         g.DrawEllipse(pen1, YobaFace); 
        
        }
        
        private static void EndDraw(){    g.Save();}
        public static void DrawBitard()
        {
           // DrawYoba(bitard);
        try { foreach (Yoba yobik in Yobas) { DrawYoba(yobik); } }
        catch (Exception e) { }
        // foreach (Yoba yobik in RollingYobas) { DrawYoba(yobik); }
         DrawYoba(rollingyoba);

            EndDraw();}
    }
    public class Yoba
    {
        public int ebliwko;
        public Int32 perdak;
        private Int32 ix;
        private Int32 iy;
        private Int32 step;
        public PointF vector;
        public static readonly Int32 radius;
        public Int32 x;
        public Int32 y;
        public Color color;
        public  const  Int32 gap = 10;
        public void resetstate()
        { step = 0; x = ix; y = iy; }
        public void move(Int32 i)
        {
         
        x = ix + (Int32)(step * vector.X);
        y = iy + (Int32)(step * vector.Y);
        step += i;
        
        }
        public bool touch(Yoba soska)
        {
            return (Math.Sqrt((soska.x - this.x) * (soska.x - this.x) + (soska.y - this.y) * (soska.y - this.y)) <= ((Double)radius * 2));
        }
        public bool neighbour(Yoba soska)
        {
            return (Math.Sqrt((soska.x - this.x) * (soska.x - this.x) + (soska.y - this.y) * (soska.y - this.y)) <= ((Double)radius * 2+gap));
        }
        public Yoba(Int32 X, Int32 Y, Color Clr,Int32 ebliwe)
        {
            ix = x = X; iy = y = Y; color = Clr; vector = new PointF(0, 0); step = 0; perdak = 0; ebliwko = ebliwe;
        }
        public void Ignite(){this.perdak=1000;}

        static Yoba(){radius=sosach.radius;}
    }
}