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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablageneralas();
            vonalakgeneralas();
        }

        private void vonalakgeneralas()
        {
            //fönti, lenti
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j==0)
                    {
                        
                        Panel vonal = new Panel();
                        vonalgen(i,j,vonal,kulsopanel);
                    }
                    if (j == 1)
                    {
                        Panel vonal = new Panel();
                        vonalgen(i, j, vonal, kozepsopanel);

                    }
                    if (j == 2)
                    {
                        Panel vonal = new Panel();
                        vonalgen(i, j, vonal, belsopanel);
                       
                    }
                    if (j == 3)
                    {
                        Panel vonal = new Panel();
                        vonalgen(i, j, vonal, kulsopanel);
                    }
                    if (j == 4)
                    {
                        Panel vonal = new Panel();
                        vonalgen(i, j, vonal, kozepsopanel);
                       
                    }
                    if (j == 5)
                    {
                        Panel vonal = new Panel();
                        vonalgen(i, j, vonal, belsopanel);
                    }

                }
            }
            //jobb, bal oldal 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j == 0)
                    {
                        Panel vonal = new Panel();
                        oldalvonal(i,j,vonal,kulsopanel);
                    }
                    if (j == 1)
                    {
                        Panel vonal = new Panel();
                        oldalvonal(i, j, vonal, kozepsopanel);
                    }
                    if (j == 2)
                    {
                        Panel vonal = new Panel();
                        oldalvonal(i, j, vonal, belsopanel);
                    }
                    if (j == 3)
                    {
                        Panel vonal = new Panel();
                        oldalvonal(i, j, vonal, kulsopanel);
                    }
                    if (j == 4)
                    {
                        Panel vonal = new Panel();
                        oldalvonal(i, j, vonal, kozepsopanel);
                    }
                    if (j == 5)
                    {
                        Panel vonal = new Panel();
                        oldalvonal(i, j, vonal, belsopanel);
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
                    vonal.Visible = true;
                    vonal.BackColor = Color.Brown;
                    vonal.Location = new System.Drawing.Point(10, i * (kulsopanel.Height / 2 - 10));
                    vonal.Size = new System.Drawing.Size(60, 2);
                    kulsopanel.Controls.Add(vonal);
                }
                if (j == 1)
                {
                    
                    Panel vonal = new Panel();
                    vonal.Visible = true;
                    vonal.BackColor = Color.Brown;
                    vonal.Location = new System.Drawing.Point(10, i * (kozepsopanel.Height / 2 - 10));
                    vonal.Size = new System.Drawing.Size(60, 2);
                    kozepsopanel.Controls.Add(vonal);
                }
                
            }

            for (int j = 0; j < 2; j++)
            {
                int i = 1;
                if (j == 0)
                {
                    Panel vonal = new Panel();
                    vonal.Visible = true;
                    vonal.BackColor = Color.Brown;
                    vonal.Location = new System.Drawing.Point(kulsopanel.Width-80, i * (kulsopanel.Height / 2 - 10));
                    vonal.Size = new System.Drawing.Size(60,2);
                    kulsopanel.Controls.Add(vonal);
                }
                if (j == 1)
                {
                    Panel vonal = new Panel();
                    vonal.Visible = true;
                    vonal.BackColor = Color.Brown;
                    vonal.Location = new System.Drawing.Point(kozepsopanel.Width - 80, i * (kozepsopanel.Height / 2 - 10));
                    vonal.Size = new System.Drawing.Size(60, 2);
                    kozepsopanel.Controls.Add(vonal);
                }


            }
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
                        panelgen(i,j,kulsopanel,kep);
                      
                    }
                    if (j == 1)
                    {
                        panelgen(i, j, kozepsopanel, kep);

                    }
                    if (j == 2)
                    {
                        panelgen(i, j, belsopanel, kep);
                    }
                    if (j == 3)
                    {

                        panelgen(i, j, belsopanel, kep);
                    }
                    if (j == 4)
                    {
                       panelgen(i, j, kozepsopanel, kep);;

                    }
                    if (j == 5)
                    {
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
            kep.Name = j + "";
            kep.Visible = true;
            kep.BackColor = Color.Red;
            kep.Size = new System.Drawing.Size(20, 20);

            panel.Controls.Add(kep);
            }
            if(j>=3)
            {
                kep.Location = new System.Drawing.Point(0 + i * (panel.Width / 2 - 10), panel.Height - 20);
                kep.Name = j + "";
                kep.Visible = true;
                kep.BackColor = Color.Red;
                kep.Size = new System.Drawing.Size(20, 20);

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
                    oldalgen(i,kep,kulsopanel);
                    
                }
                if(i==1)
                {
                    oldalgen(i, kep, kozepsopanel);
                }
                if (i == 2)
                {
                    oldalgen(i, kep, belsopanel);
                }
                if(i==3)
                {
                    oldalgen(i, kep, belsopanel);
                }
                if (i == 4)
                {
                    oldalgen(i, kep, kozepsopanel);
                }
                if (i == 5)
                {
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
                kep.BackColor = Color.Red;
                kep.Size = new System.Drawing.Size(20, 20);

                panel.Controls.Add(kep);
            }
            if(i>=3)
            {
                kep.Location = new System.Drawing.Point(panel.Width - 20, panel.Height / 2 - 20);
                kep.Visible = true;
                kep.BackColor = Color.Red;
                kep.Size = new System.Drawing.Size(20, 20);

                panel.Controls.Add(kep);
            }
           
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
    }
}
