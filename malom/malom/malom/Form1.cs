using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace malom
{
    public partial class Form1 : Form
    {
        public int r = 0;
        public int g = 0;
        public int b = 0;
        public bool bgszinezvelettef1=false;
        public bool lepesszinezve = false;
        static List<int> position = new List<int>();
        //static List<Panel> panelPosition = new List<Panel>();
        //PicturePos tömb, 0-24 ig a megfelelő indexű helyre(panel pos? vagy position) mindig hozzáadni picPos hoz 
        static List<PictureBox> PicturePosition = new List<PictureBox>();
        static PictureBox[] PicPosition = new PictureBox[24];
        static int[] szinek = new int[24];
        static string nev1 = "";
        static string nev2 = "";
        static int letetel = 18;
        static int szin = 0;
        static bool mozgatas = false;
        static bool lerakas = false;
        static int honnan = 0;
        static int letetelutan = 0;
        static int kijon = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nev1txb.Text==""||nev2txb.Text=="")
            {
                MessageBox.Show("Addjon meg 2 nevet");
            }
            else
            { if(nev2txb.Text != nev1txb.Text)
                {
                    nev1 = nev1txb.Text;
                    nev2 = nev2txb.Text;
                    kijonlbl.Text = "Letevés: "+nev1;
                    kijonlbl.Visible = true;
                    tablageneralas();
                    eltuntetes();
                    vonalakgeneralas();
                }
            else
                {
                    MessageBox.Show("Adjon meg különböző neveket.");
                }
            }
        }

        private void eltuntetes()
        {
            label1.Visible = false;
            label2.Visible = false;
            nev2txb.Visible = false;
            nev1txb.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void vonalakgeneralas()
        {
            //fönti, lenti

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Panel vonal = new Panel();
                    switch (j)
                    {
                        case 0:
                            vonalgen(i, j, vonal, kulsopanel);
                            break;
                        case 1:
                            vonalgen(i, j, vonal, kozepsopanel);
                            break;
                        case 2:
                            vonalgen(i, j, vonal, belsopanel);
                            break;
                        case 3:
                            vonalgen(i, j, vonal, kulsopanel);
                            break;
                        case 4:
                            vonalgen(i, j, vonal, kozepsopanel);
                            break;
                        case 5:
                            vonalgen(i, j, vonal, belsopanel);
                            break;
                    }
                    
                }
            }

            //jobb, bal oldal 

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Panel vonal = new Panel();
                    switch (j)
                    {
                        case 0:
                            oldalvonal(i, j, vonal, kulsopanel);
                            break;
                        case 1:
                            oldalvonal(i, j, vonal, kozepsopanel);
                            break;
                        case 2:
                            oldalvonal(i, j, vonal, belsopanel);
                            break;
                        case 3:
                            oldalvonal(i, j, vonal, kulsopanel);
                            break;
                        case 4:
                            oldalvonal(i, j, vonal, kozepsopanel);
                            break;
                        case 5:
                            oldalvonal(i, j, vonal, belsopanel);
                            break;
                    }
                }
            }

            //a középen lévőeket köti össze
            
            for (int j = 0; j < 2; j++)
            {
                
                int i = 1;
                if (j==0)
                {
                    Panel vonal = new Panel();
                    kozepbal(j, i, vonal, kulsopanel);
                }
                if (j == 1)
                {
                    Panel vonal = new Panel();
                    kozepbal(j, i, vonal, kozepsopanel);
                }
            }

            for (int j = 0; j < 2; j++)
            {
                int i = 1;
                if (j == 0)
                {
                    Panel vonal = new Panel();
                    
                    kozepjobb(j, i, vonal, kulsopanel);
                }
                if (j == 1)
                {
                    Panel vonal = new Panel();
                    kozepjobb(j, i, vonal, kozepsopanel);
                }
            }
            
            //felső és alsó vonalak
            for (int j = 0; j < 2; j++)
            {
                int i = 1;
                if (j == 0)
                {
                    Panel vonal = new Panel();
                    felso(j,i,vonal,kulsopanel);
                }
                if (j == 0)
                {
                    Panel vonal = new Panel();
                    felso(j, i, vonal, kozepsopanel);
                }
            }
            
            for (int j = 0; j < 2; j++)
            {
                int i = 1;
                if (j == 0)
                {
                    Panel vonal = new Panel();
                    also(j,i,vonal,kulsopanel);
                }
                if (j == 0)
                {
                    Panel vonal = new Panel();
                    also(j, i, vonal, kozepsopanel);

                }
            }
            
        }

        private void also(int j, int i, Panel vonal, Panel panel)
        {
            vonal.Visible = true;
            vonal.BackColor = Color.Brown;
            vonal.Location = new System.Drawing.Point(panel.Width / 2, panel.Height - 60);
            vonal.Size = new System.Drawing.Size(2, 60);
            panel.Controls.Add(vonal);
        }

        private void felso(int j, int i, Panel vonal, Panel panel)
        {
            vonal.Visible = true;
            vonal.BackColor = Color.Brown;
            vonal.Location = new System.Drawing.Point(panel.Width / 2, 10);
            vonal.Size = new System.Drawing.Size(2, 60);
            panel.Controls.Add(vonal);
        }

        private void kozepbal(int j, int i, Panel vonal, Panel panel)
        {
            vonal.Visible = true;
            vonal.BackColor = Color.Brown;
            vonal.Location = new System.Drawing.Point(10, i * (panel.Height / 2 - 10));
            vonal.Size = new System.Drawing.Size(60, 2);
            panel.Controls.Add(vonal);
        }

        private void kozepjobb(int j, int i, Panel vonal, Panel panel)
        {
            vonal.Visible = true;
            vonal.BackColor = Color.Brown;
            vonal.Location = new System.Drawing.Point(panel.Width - 80, i * (panel.Height / 2 - 10));
            vonal.Size = new System.Drawing.Size(60, 2);
            panel.Controls.Add(vonal);
        }

        private void oldalvonal(int i, int j, Panel vonal, Panel panel)
        {
            if (j <= 2)
            {
                vonal.Visible = true;
                vonal.BackColor = Color.Brown;
                vonal.Location = new System.Drawing.Point(10, i * (panel.Height / 2 - 10));
                vonal.Size = new System.Drawing.Size(2, panel.Height / 2 - 10);
                panel.Controls.Add(vonal);
            }
            if (j >= 3)
            {
                vonal.Visible = true;
                vonal.BackColor = Color.Brown;
                vonal.Location = new System.Drawing.Point(panel.Width - 10, i * (panel.Height / 2 - 10));
                vonal.Size = new System.Drawing.Size(2, panel.Height / 2 - 10);
                panel.Controls.Add(vonal);
            }
        }

        private void vonalgen(int i, int j, Panel vonal, Panel panel)
        {
            if (j<=2)
            {
                vonal.Visible = true;
                vonal.BackColor = Color.Brown;
                vonal.Location = new System.Drawing.Point(10 + i * (panel.Width / 2 - 10), 10);
                vonal.Size = new System.Drawing.Size(panel.Width / 2 - 20, 2);
                panel.Controls.Add(vonal);
                
            }
            if (j>=3)
            {
                
                vonal.Visible = true;
                vonal.BackColor = Color.Brown;
                vonal.Location = new System.Drawing.Point(10 + i * (panel.Width / 2 - 10), panel.Height - 10);
                vonal.Size = new System.Drawing.Size(panel.Width / 2 - 20, 2);
                panel.Controls.Add(vonal);
            }
        }

        private void tablageneralas()
        {
            for (int i = 0; i < szinek.Length; i++)
            {
                szinek[i] =-1;
            }
            //MessageBox.Show("Szinek utolsó eleme elivelg -1:   " + szinek[23]);
            int kozepi = 250;
            int kozepj = 220;
            /*
            PictureBox kep2 = new PictureBox();
            kep2.Location = new System.Drawing.Point(kozepi,kozepj);
            kep2.Visible = true;
            kep2.BackColor = Color.Brown;
            kep2.Size = new System.Drawing.Size(20, 20);
            kulsopanel.Controls.Add(kep2);
            MessageBox.Show("Első kép?");*/
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Panel kep = new Panel();
                    if (j == 0)
                    {
                        
                        if (i==0)
                        {
                            position.Add(1);
                        }
                        else if(i==1)
                        {
                            position.Add(2);
                        }
                        else
                        {
                            position.Add(3);
                        }
                        panelgen(i, j, kulsopanel, kep);
                    }
                    if (j == 1)
                    {
                        
                        if (i==0)
                        {
                            position.Add(4);
                        }
                        else if (i == 1)
                        {
                            position.Add(5);
                        }
                        else
                        {
                            position.Add(6);
                        }
                        panelgen(i, j, kozepsopanel, kep);

                    }
                    if (j == 2)
                    {
                        
                        if (i==0)
                        {
                            position.Add(7);
                        }
                        else if(i==1)
                        {
                            position.Add(8);
                        }
                        else
                        {
                            position.Add(9);
                        }
                        panelgen(i, j, belsopanel, kep);
                    }
                    if (j == 3)
                    {

                       
                        if (i==0)
                        {
                            position.Add(16);
                        }
                        else if (i == 1)
                        {
                            position.Add(17);
                        }
                        else
                        {
                            position.Add(18);
                        }
                        panelgen(i, j, belsopanel, kep);
                    }
                    if (j == 4)
                    {
                       
                        if (i==0)
                        {
                            position.Add(19);
                        }
                        else if (i == 1)
                        {
                            position.Add(20);
                        }
                        else
                        {
                            position.Add(21);
                        }
                        panelgen(i, j, kozepsopanel, kep);
                    }
                    if (j == 5)
                    {
                        
                        if (i==0)
                        {
                            position.Add(22);
                        }
                        else if (i == 1)
                        {
                            position.Add(23);
                        }
                        else
                        {
                            position.Add(24);
                        }
                        panelgen(i, j, kulsopanel, kep);
                    }
                }
                
            }
            
            oldalpanelek();
        }

        private void panelgen(int i, int j, Panel panel, Panel kep)
        {
            if(j<=2)
            { 
            kep.Location = new System.Drawing.Point(0 + i * (panel.Width / 2 - 10), 0);
            kep.Name = position[position.Count - 1]+"";
            
            kep.Visible = true;
            kep.BackColor = Color.Red;
            kep.Size = new System.Drawing.Size(20, 20);
            kep.Click += new System.EventHandler(this.klikk);
            panel.Controls.Add(kep);

            
           //MessageBox.Show("Panel name: " + klikkelt.Name);

            PictureBox picture = new PictureBox();
            picture.Location = new System.Drawing.Point(0, 0);
            picture.Size = new System.Drawing.Size(20, 20);
            picture.Name = kep.Name + "";
            picture.Tag = "";
            //MessageBox.Show("Picture name: " + picture.Name);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Click += new System.EventHandler(this.kepKlikk);
            picture.BringToFront();
            kep.Controls.Add(picture);

            int id = Convert.ToInt32(picture.Name)-1;
            PicPosition[id] = new PictureBox();
            PicPosition[id] = picture;
            }
            if(j>=3)
            {
                kep.Location = new System.Drawing.Point(0 + i * (panel.Width / 2 - 10), panel.Height - 20);
                kep.Name = position[position.Count - 1]+"";
                kep.Visible = true;
                kep.BackColor = Color.Red;
                kep.Size = new System.Drawing.Size(20, 20);
                kep.Click += new System.EventHandler(this.klikk);
                panel.Controls.Add(kep);

                PictureBox picture = new PictureBox();
                picture.Location = new System.Drawing.Point(0, 0);
                picture.Size = new System.Drawing.Size(20, 20);
                picture.Name = kep.Name + "";
                picture.Tag = "";
                //MessageBox.Show("Picture name: " + picture.Name);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Click += new System.EventHandler(this.kepKlikk);
                picture.BringToFront();
                kep.Controls.Add(picture);

                int id = Convert.ToInt32(picture.Name)-1;
                PicPosition[id] = new PictureBox();
                PicPosition[id] = picture;

            }
        }

        private void oldalpanelek()
        {
            for (int i = 0; i < 6; i++)
            {
                Panel kep = new Panel();
                if (i==0)
                {
                   
                    position.Add(10);
                    oldalgen(i, kep, kulsopanel);

                }
                if(i==1)
                {
                    
                    position.Add(11);
                    oldalgen(i, kep, kozepsopanel);
                }
                if (i == 2)
                {
                    
                    position.Add(12);
                    oldalgen(i, kep, belsopanel);
                }
                if(i==3)
                {
                    
                    position.Add(13);
                    oldalgen(i, kep, belsopanel);
                }
                if (i == 4)
                {
                    
                    position.Add(14);
                    oldalgen(i, kep, kozepsopanel);
                }
                if (i == 5)
                {
                    
                    position.Add(15);
                    oldalgen(i, kep, kulsopanel);
                }
            }
        }

        private void oldalgen(int i,Panel kep, Panel panel)
        {
            if(i<=2)
                {
                kep.Location = new System.Drawing.Point(0, panel.Height / 2 - 20);
                kep.Visible = true;
                kep.Name = position[position.Count - 1] + "";
                kep.BackColor = Color.Red;
                kep.Size = new System.Drawing.Size(20, 20);
                kep.Click += new System.EventHandler(this.klikk);
                panel.Controls.Add(kep);

                PictureBox picture = new PictureBox();
                picture.Location = new System.Drawing.Point(0, 0);
                picture.Size = new System.Drawing.Size(20, 20);
                picture.Name = kep.Name + "";
                picture.Tag = "";
                //MessageBox.Show("Picture name: " + picture.Name);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Click += new System.EventHandler(this.kepKlikk);
                picture.BringToFront();
                kep.Controls.Add(picture);

                int id = Convert.ToInt32(picture.Name)-1;
                PicPosition[id] = new PictureBox();
                PicPosition[id] = picture;
            }
            if(i>=3)
            {
                kep.Location = new System.Drawing.Point(panel.Width - 20, panel.Height / 2 - 20);
                kep.Visible = true;
                kep.Name = position[position.Count - 1] + "";
                kep.BackColor = Color.Red;
                kep.Size = new System.Drawing.Size(20, 20);
                kep.Click += new System.EventHandler(this.klikk);
                panel.Controls.Add(kep);

                PictureBox picture = new PictureBox();
                picture.Location = new System.Drawing.Point(0, 0);
                picture.Size = new System.Drawing.Size(20, 20);
                picture.Name = kep.Name + "";
                picture.Tag = "";
                //MessageBox.Show("Picture name: " + picture.Name);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Click += new System.EventHandler(this.kepKlikk);
                picture.BringToFront();
                kep.Controls.Add(picture);

                int id = Convert.ToInt32(picture.Name)-1;
                PicPosition[id] = new PictureBox();
                PicPosition[id] = picture;
            }
           
        }

        private void klikk(object sender, EventArgs e)
        {/*
            //MessageBox.Show("Position : " + position[position.Count - 1]);
            Panel klikkelt = sender as Panel;
           //MessageBox.Show("Panel name: " + klikkelt.Name);

            PictureBox picture = new PictureBox();
            picture.Location = new System.Drawing.Point(0, 0);
            picture.Size = new System.Drawing.Size(20, 20);
            picture.Name = klikkelt.Name + "";
            picture.Tag = "";
            //MessageBox.Show("Picture name: " + picture.Name);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Click += new System.EventHandler(this.kepKlikk);
            if (letetel>0)
            {
                if (szin == 0)
                {
                    szin = 1;
                    picture.Image = Image.FromFile("feher.png");
                }
                else
                {
                    szin = 0;
                    picture.Image = Image.FromFile("fekete.png");
                }
                letetel--;
                
            }
            if (letetel==0)
            {
                kijonlbl.Text = "Mozgatás: ";
                kijonlbl.Visible = true;
                mozgatas = true;
            }
            picture.BringToFront();
            klikkelt.Controls.Add(picture);
            //PicturePosition.Add(picture);
            //PicturePosition[klikkelt.Name] = picture;
            int id = Convert.ToInt32(klikkelt.Name);
            PicPosition[id] = new PictureBox();
            PicPosition[id] = picture;
            //MessageBox.Show($"Name: {klikkelt.Name}, Tag: {klikkelt.Tag}");
            */
        }

        private void kepKlikk(object sender, EventArgs e)
        {
            
            PictureBox klikkelt = sender as PictureBox;
            int iduj = Convert.ToInt32(klikkelt.Name);
            
            if (lerakas)
            {
                //MessageBox.Show("Lerakásban vagyunk az előző kattintás id je: " + honnan);
                //ugyan oda kapcsolt
                if (honnan==iduj+1)
                {
                    lerakas = false;
                }
                if (PicPosition[iduj-1].Tag=="1")
                {
                    //puictureboxok id jét át kéne váltani?
                    // ha nincs ott semmi akkor csak simán tegye bele
                    
                    if (szinek[honnan]==0)
                    {
                        if (kijon==0)
                        {
                        klikkelt.Image = Image.FromFile("feher.png");
                        PicPosition[honnan].Image = null;
                        PicPosition[honnan].Tag = "0";
                        szinek[iduj - 1] = 0;
                        szinek[honnan] = -1;
                        //MessageBox.Show("Elivleg kész a képváltás!");
                        
                         kijon = 1;
                            kijonlbl.Text = "Mozgatás: " + nev2;
                            szinektorlese();
                        }

                    }
                    if (szinek[honnan] == 1)
                    {
                        if (kijon==1)
                        {
                            klikkelt.Image = Image.FromFile("fekete.png");
                            PicPosition[honnan].Image = null;
                            PicPosition[honnan].Tag = "0";
                            szinek[iduj - 1] = 1;
                            szinek[honnan] = -1;
                            //MessageBox.Show("Elivleg kész a képváltás!");
                            
                             kijon = 0;
                            kijonlbl.Text = "Mozgatás: " + nev1;
                            szinektorlese();
                        }
                        
                    }
                }
                lerakas = false;
               
            }
            else
            {
                if (szinek[iduj - 1] == -1)
                {
                    if (letetel > 0)
                    {
                        if (szin == 0)
                        {
                            szin = 1;
                            klikkelt.Image = Image.FromFile("feher.png");
                            szinek[iduj - 1] = 0; 
                            kijonlbl.Text = "Letevés: " + nev2;
                            szinektorlese();
                        }
                        else
                        {
                            szin = 0;
                            klikkelt.Image = Image.FromFile("fekete.png");
                            szinek[iduj - 1] = 1;
                            kijonlbl.Text = "Letevés: " + nev1;
                            szinektorlese();
                        }
                        letetel--;

                    }
                    if (letetel == 0)
                    {
                        kijonlbl.Text = "Mozgatás: "+nev1;
                        kijonlbl.Visible = true;
                        mozgatas = true;
                    }
                }
                if (mozgatas == true)
                {
                    //MessageBox.Show("klikkelt name: " + iduj);
                    // ez nem a nevét tárolja hanem a pozícióját a színek és a PicPos tömbön belül
                    honnan = iduj-1;
                    hovamozoghat(iduj);
                }
            }
            //MessageBox.Show("klikkelt name convertálás előtt: " +klikkelt.Name);
            //ID zéssel bajok vannak
            //MessageBox.Show("" + PicPosition[1].Name);
            
        }

        private void szinektorlese()
        {
            for (int i = 0; i <24; i++)
            {
                PicPosition[i].BackColor = Color.Red;
            }
        }

        private void hovamozoghat(int id)
        {
            //probléma   18 helyre klikkeltünk oda létre hoz picturebox okat, de a többi maradék helyre még nem
            // és ez nem tesz majd jót az ellerőzésnek, ezért majd valahol kell a maradék helyre is létrehozni 
            //pictureboxokat   vagy ahol nézzük a letevést vagy éppenséggel itt

            // 0 ahova nem tud mozogni
            //1 ahova tud
            
            for (int i = 0; i < PicPosition.Length; i++)
            {
                PicPosition[i].Tag = "0";
            }
            int[] pos = new int[4];
            for (int i = 0; i < pos.Length-1; i++)
            {
                pos[i] = -1;
            }

            switch (id)
            {
                case 1:
                    //MessageBox.Show("picposition tag: " + PicPosition[1].Tag);
                    PicPosition[1].Tag = "1";
                    PicPosition[9].Tag = "1";
                    pos[0] = 1;
                    pos[1] = 9;
                    vaneottelem(pos);
                    
                    //MessageBox.Show("elvileg tíz: " + PicPosition[1].Tag);
                    break;
                case 2:
                    PicPosition[0].Tag = "1";
                    PicPosition[2].Tag = "1";
                    PicPosition[4].Tag = "1";
                    pos[0] = 0;
                    pos[1] = 2;
                    pos[2] = 4;
                    
                    vaneottelem(pos);
                    break;
                case 3:
                    PicPosition[1].Tag = "1";
                    PicPosition[14].Tag = "1";
                    pos[0] = 1;
                    pos[1] = 14;
                    

                    vaneottelem(pos);
                    break;
                case 4:
                    PicPosition[4].Tag = "1";
                    PicPosition[10].Tag = "1";
                    pos[0] = 4;
                    pos[1] = 10;
                    

                    vaneottelem(pos);
                    break;
                case 5:
                    PicPosition[1].Tag = "1";
                    PicPosition[3].Tag = "1";
                    PicPosition[5].Tag = "1";
                    PicPosition[7].Tag = "1";

                    pos[0] = 1;
                    pos[1] = 3;
                    pos[2] = 5;
                    pos[3] = 7;

                    vaneottelem(pos);
                    break;
                case 6:
                    PicPosition[4].Tag = "1";
                    PicPosition[13].Tag = "1";
                    pos[0] = 4;
                    pos[1] = 13;
                    

                    vaneottelem(pos);
                    break;
                case 7:
                    PicPosition[7].Tag = "1";
                    PicPosition[11].Tag = "1";
                    pos[0] = 7;
                    pos[1] = 11;
                    
                    vaneottelem(pos);
                    break;
                case 8:
                    PicPosition[6].Tag = "1";
                    PicPosition[8].Tag = "1";
                    PicPosition[4].Tag = "1";
                    pos[0] = 6;
                    pos[1] = 8;
                    pos[2] = 4;
                    vaneottelem(pos);
                    break;
                case 9:
                    PicPosition[7].Tag = "1";
                    PicPosition[12].Tag = "1";
                    pos[0] = 7;
                    pos[1] = 12;
                    
                    vaneottelem(pos);
                    break;
                case 10:
                    PicPosition[0].Tag = "1";
                    PicPosition[10].Tag = "1";
                    PicPosition[21].Tag = "1";
                    pos[0] = 0;
                    pos[1] = 10;
                    pos[2] = 21;
                    
                    vaneottelem(pos);
                    break;
                case 11:
                    PicPosition[3].Tag = "1";
                    PicPosition[9].Tag = "1";
                    PicPosition[11].Tag = "1";
                    PicPosition[18].Tag = "1";
                    pos[0] = 3;
                    pos[1] = 9;
                    pos[2] = 11;
                    pos[3] = 18;

                    vaneottelem(pos);
                    break;
                case 12:
                    PicPosition[6].Tag = "1";
                    PicPosition[15].Tag = "1";
                    pos[0] = 6;
                    pos[1] = 15;
                    

                    vaneottelem(pos);
                    break;
                case 13:
                    PicPosition[8].Tag = "1";
                    PicPosition[17].Tag = "1";
                    PicPosition[13].Tag = "1";
                    pos[0] = 8;
                    pos[1] = 17;
                    pos[2] = 13;
                    
                    vaneottelem(pos);
                    break;
                case 14:
                    PicPosition[5].Tag = "1";
                    PicPosition[12].Tag = "1";
                    PicPosition[14].Tag = "1";
                    PicPosition[20].Tag = "1";
                    pos[0] = 5;
                    pos[1] = 12;
                    pos[2] = 14;
                    pos[3] = 20;

                    vaneottelem(pos);
                    break;
                case 15:
                    PicPosition[2].Tag = "1";
                    PicPosition[13].Tag = "1";
                    PicPosition[23].Tag = "1";

                    pos[0] = 2;
                    pos[1] = 13;
                    pos[2] = 23;
                    

                    vaneottelem(pos);
                    break;
                case 16:
                    PicPosition[11].Tag = "1";
                    PicPosition[16].Tag = "1";
                    pos[0] = 11;
                    pos[1] = 16;

                    vaneottelem(pos);
                    break;
                case 17:
                    PicPosition[15].Tag = "1";
                    PicPosition[17].Tag = "1";
                    PicPosition[19].Tag = "1";
                    pos[0] = 15;
                    pos[1] = 17;
                    pos[2] = 19;

                    vaneottelem(pos);
                    break;
                case 18:
                    PicPosition[16].Tag = "1";
                    PicPosition[12].Tag = "1";
                    pos[0] = 16;
                    pos[1] = 12;

                    vaneottelem(pos);
                    break;
                case 19:
                    PicPosition[10].Tag = "1";
                    PicPosition[19].Tag = "1";
                    pos[0] = 10;
                    pos[1] = 19;

                    vaneottelem(pos);
                    break;
                case 20:
                    PicPosition[16].Tag = "1";
                    PicPosition[18].Tag = "1";
                    PicPosition[20].Tag = "1";
                    PicPosition[22].Tag = "1";
                    pos[0] = 16;
                    pos[1] = 18;
                    pos[2] = 20;
                    pos[3] = 22;

                    vaneottelem(pos);
                    break;
                case 21:
                    PicPosition[19].Tag = "1";
                    PicPosition[13].Tag = "1";
                    pos[0] = 19;
                    pos[1] = 13;
                    

                    vaneottelem(pos);
                    break;
                case 22:
                    PicPosition[9].Tag = "1";
                    PicPosition[22].Tag = "1";
                    pos[0] = 9;
                    pos[1] = 22;

                    vaneottelem(pos);
                    break;
                case 23:
                    PicPosition[21].Tag = "1";
                    PicPosition[19].Tag = "1";
                    PicPosition[23].Tag = "1";
                    pos[0] = 21;
                    pos[1] = 19;
                    pos[2] = 23;

                    vaneottelem(pos);
                    break;
                case 24:
                    PicPosition[22].Tag = "1";
                    PicPosition[14].Tag = "1";
                    pos[0] = 22;
                    pos[1] = 14;

                    vaneottelem(pos);
                    break;

                default:
                    break;
            }

            //a képek name-je 1 től megy 24 ig , DE a picPosition 0-23 ig
            // meg náz a position int lista is 1 essel kezdődik és 24 essel ér véget
            //a 0. elem az 1 es 
            /*for (int i = 0; i < PicPosition.Length; i++)
            {
                if (PicPosition[i].Tag=="1")
                {
                    MessageBox.Show("Helyek ahol 1 es: "+i);
                }
            }*/
        }

        private void vaneottelem(int[] pos)
        {
           /* MessageBox.Show("Szinek 23 utolsó:" + szinek[23]);
            MessageBox.Show("picPosition 23 utolsó tag: " + PicPosition[23].Tag);*/
            for (int i = 0; i < pos.Length; i++)
            {
                if (pos[i]!=-1)
                {
                    if (szinek[pos[i]] == 0 || szinek[pos[i]] == 1)
                    {
                        PicPosition[pos[i]].Tag = "0";
                    }
                }
                
            }
            
            if (letetelutan>0)
            {
                lerakas = true;
                if (lepesszinezve)
                {
                    for (int i = 0; i < 24; i++)
                    {
                        if (PicPosition[i].Tag == "1")
                        {
                            PicPosition[i].BackColor = Color.Yellow;
                        }
                    }
                }
            }
            letetelutan++;
            //Itt valamiért a szin 23: 0 ami miatt átváltódik a picpos 23 tag ja 0 vá
           /* MessageBox.Show("A vaneottelem elkészült");
            MessageBox.Show("Szinek 23 utolsó:" + szinek[23]);
            MessageBox.Show("picPosition 23 utolsó tag: " + PicPosition[23].Tag);*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            if(bgszinezvelettef1)
            {
                this.BackColor = Color.FromArgb(r, g, b);
            }
            
            panelekbordere();
        }

        private void panelekbordere()
        {
            kulsopanel.BorderStyle = BorderStyle.None;
            belsopanel.BorderStyle = BorderStyle.None;
            kozepsopanel.BorderStyle = BorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inf info = new inf();
            if (bgszinezvelettef1)
            {
                //MessageBox.Show("bg szinezve form 1");
                this.Hide();
                info.Show();
                info.red = r;
                info.green =b;
                info.blue = g;
                info.bgszinezveletteinf = true;
                if(lepesszinezve)
                {
                   // MessageBox.Show("sziezvelépés");
                info.lepesszinezveform1 = true;
                }
                else
                {
                    info.lepesszinezveform1 = false;
                }
                info.BackColor = Color.FromArgb(r, g, b);
            }
            else
            {
                this.Hide();
                info.Show();
                if (lepesszinezve)
                {
                   // MessageBox.Show("sziezvelépés");
                    info.lepesszinezveform1 = true;
                }
                else
                {
                    info.lepesszinezveform1 = false;
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            beállítások beallit = new beállítások();

            if (bgszinezvelettef1)
            {
                MessageBox.Show("bg szinezve form 1");
                this.Hide();
                beallit.Show();
                beallit.r = r;
                beallit.g = b;
                beallit.b = g;
                beallit.bgszinezvelettebeall = true;
                if (lepesszinezve)
                {
                    // MessageBox.Show("sziezvelépés");
                    beallit.szines = true;
                }
                else
                {
                    beallit.szines = false;
                }
                beallit.BackColor = Color.FromArgb(r, g, b);
            }
            else
            {
                this.Hide();
                beallit.Show();
                beallit.bgszinezvelettebeall = false;
                if (lepesszinezve)
                {
                    // MessageBox.Show("sziezvelépés");
                    beallit.szines = true;
                }
                else
                {
                    beallit.szines = false;
                }
            }
        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void button1_DragLeave(object sender, EventArgs e)
        {
           
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
        }
          private void button2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button2_MouseEnter_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.Black;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
            button3.ForeColor = Color.Black;
        }

        private void bezarbtn_MouseEnter(object sender, EventArgs e)
        {
            bezarbtn.BackColor = Color.Black;
            bezarbtn.ForeColor = Color.White;
        }

        private void bezarbtn_MouseLeave(object sender, EventArgs e)
        {
            bezarbtn.BackColor = Color.Transparent;
            bezarbtn.ForeColor = Color.Black;
        }
    }
}
