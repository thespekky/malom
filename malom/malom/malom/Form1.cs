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
        static List<int> position = new List<int>();
        static List<Panel> panelPosition = new List<Panel>();
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
            int kozepi = 250;
            int kozepj = 220;
            PictureBox kep2 = new PictureBox();
            kep2.Location = new System.Drawing.Point(kozepi,kozepj);
            kep2.Visible = true;
            kep2.BackColor = Color.Brown;
            kep2.Size = new System.Drawing.Size(20, 20);
            kulsopanel.Controls.Add(kep2);
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
            }
           
        }

        private void klikk(object sender, EventArgs e)
        {
            Panel klikkelt = sender as Panel;
            MessageBox.Show($"Name: {klikkelt.Name}, Tag: {klikkelt.Tag}");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
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
           
            this.Hide();
            info.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
