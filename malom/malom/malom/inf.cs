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
    public partial class inf : Form
    {
        public inf()
        {
            InitializeComponent();
        }

        private void visszabtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inf_Load(object sender, EventArgs e)
        {
            informaciolbl.Text = "A játék célja az, hogy az ellenfél korongjait levegyük, vagy olyan helyzetbe kerüljünk, hogy az ellenfél képtelen legyen lépni.\n \n Ennek elsődleges módja a malmok kialakítása(függőleges vagy vízszintes sorokban három korong egymás mellett),ugyanis egy malom létrejöttével levehetünk egy korongot az ellenfél készletéből.\n\n Ha valakinek csak két korongja marad, elvesztette a játékot.\n\n A játék alapvetően három fázisból áll: \n -a bábuk felrakása a táblára(felváltva) \n -lépegetés a táblán";
            informaciolbl.Text+="\n\n--------------------------------------------Korongok-----------------------------------------";
        }
    }
}
