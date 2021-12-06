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
    public partial class beállítások : Form
    {
        static bool i = true;
        public int r = 0;
        public int g = 0;
        public int b = 0;
        public bool szines = false;
        public bool bgszinezvelettebeall = false;
        public beállítások()
        {
            InitializeComponent();
        }

        private void vissza_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            if(bgszinezvelettebeall)
            { 
            this.Close();
                form.BackColor = Color.FromArgb(r, g, b);
                form.Show();
           
            form.rr = r;
            form.gg = g;
            form.bb = b;
            if (szines)
            {
                form.lepesszinezve = true;
            }
            form.bgszinezvelettef1 = true;
            }
            else
            {
                this.Close();
                form.Show();
                if (szines)
                {
                    form.lepesszinezve = true;
                }
                form.bgszinezvelettef1 = false;
            }
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            if(i)
            {
                Rscrollbar.Value = r;
                Gscrollbar.Value = g;
                Bscrollbar.Value = b;
                i = false;
            }

            bgtesztnezet.BackColor = Color.FromArgb(Rscrollbar.Value, Gscrollbar.Value, Bscrollbar.Value);
        }

        private void beállítások_Load(object sender, EventArgs e)
        {
            bgtesztnezet.BackColor = Color.FromArgb(r, g, b);
        
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (i)
            {
                Rscrollbar.Value = r;
                Gscrollbar.Value = g;
                Bscrollbar.Value = b;
                i = false;
            }
            bgtesztnezet.BackColor = Color.FromArgb(Rscrollbar.Value, Gscrollbar.Value, Bscrollbar.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            if (i)
            {
                Rscrollbar.Value = r;
                Gscrollbar.Value = g;
                Bscrollbar.Value = b;
                i = false;
            }
            bgtesztnezet.BackColor = Color.FromArgb(Rscrollbar.Value, Gscrollbar.Value, Bscrollbar.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = Rscrollbar.Value;
            g = Gscrollbar.Value;
            b = Bscrollbar.Value;
            Form1 form = new Form1();
            this.Close();
            form.BackColor = Color.FromArgb(r, g, b);
            form.Show();

            form.rr = r;
            form.gg = g;
            form.bb = b;
            if (szines)
            {
                form.lepesszinezve = true;
            }
            form.bgszinezvelettef1 = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            szines = true;
            valasztottlbl.Visible = true;
            valasztottlbl.Text = "Szeretném ha szinezve lenne a lépéseim lehetőségei";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            szines = false;
            valasztottlbl.Visible = true;
            valasztottlbl.Text = "Nem szeretném ha szinezve lenne a lépéseim lehetőségei";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
            if (szines)
            {
                form.lepesszinezve = true;
            }
        }

        private void vissza_MouseEnter(object sender, EventArgs e)
        {
            vissza.BackColor = Color.Black;
            vissza.ForeColor = Color.White;
            vissza.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void vissza_MouseLeave(object sender, EventArgs e)
        {
            vissza.BackColor = Color.Transparent;
            vissza.ForeColor = Color.Black;
            vissza.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.Black;
            button2.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
            button3.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
            button3.ForeColor = Color.Black;
            button3.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.White;
            button4.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Transparent;
            button4.ForeColor = Color.Black;
            button4.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
            button1.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }
    }
}
