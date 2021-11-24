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
            gametablePanel.Controls.Add(kep2);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    PictureBox kep = new PictureBox();
                    if (j == 0)
                    {
                        kep.Location = new System.Drawing.Point(0 + (i * 250), 20 + (j * 50));
                        kep.Name = j + "";
                        kep.Visible = true;
                        kep.BackColor = Color.Red;
                        kep.Size = new System.Drawing.Size(20, 20);
                    }
                    if (j == 1)
                    {
                        kep.Location = new System.Drawing.Point(0 + (i * 250), 20 + (j * 50));
                        kep.Name = j + "";
                        kep.Visible = true;
                        kep.BackColor = Color.Red;
                        kep.Size = new System.Drawing.Size(20, 20);
                    }


                    gametablePanel.Controls.Add(kep);
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
