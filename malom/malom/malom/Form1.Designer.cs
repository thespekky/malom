
namespace malom
{
    partial class Form1
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
            this.nev1txb = new System.Windows.Forms.TextBox();
            this.nev2txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kulsopanel = new System.Windows.Forms.Panel();
            this.kozepsopanel = new System.Windows.Forms.Panel();
            this.belsopanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kijonlbl = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.kulsopanel.SuspendLayout();
            this.kozepsopanel.SuspendLayout();
            this.belsopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nev1txb
            // 
            this.nev1txb.Location = new System.Drawing.Point(180, 3);
            this.nev1txb.Name = "nev1txb";
            this.nev1txb.Size = new System.Drawing.Size(100, 20);
            this.nev1txb.TabIndex = 0;
            // 
            // nev2txb
            // 
            this.nev2txb.Location = new System.Drawing.Point(180, 29);
            this.nev2txb.Name = "nev2txb";
            this.nev2txb.Size = new System.Drawing.Size(100, 20);
            this.nev2txb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "első játékos neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "második játékos neve:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kulsopanel
            // 
            this.kulsopanel.BackColor = System.Drawing.Color.Transparent;
            this.kulsopanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kulsopanel.Controls.Add(this.kozepsopanel);
            this.kulsopanel.Location = new System.Drawing.Point(148, 54);
            this.kulsopanel.Name = "kulsopanel";
            this.kulsopanel.Size = new System.Drawing.Size(520, 440);
            this.kulsopanel.TabIndex = 5;
            // 
            // kozepsopanel
            // 
            this.kozepsopanel.BackColor = System.Drawing.Color.Transparent;
            this.kozepsopanel.Controls.Add(this.belsopanel);
            this.kozepsopanel.Controls.Add(this.label1);
            this.kozepsopanel.Controls.Add(this.label2);
            this.kozepsopanel.Controls.Add(this.nev1txb);
            this.kozepsopanel.Controls.Add(this.nev2txb);
            this.kozepsopanel.Location = new System.Drawing.Point(60, 60);
            this.kozepsopanel.Name = "kozepsopanel";
            this.kozepsopanel.Size = new System.Drawing.Size(400, 320);
            this.kozepsopanel.TabIndex = 6;
            // 
            // belsopanel
            // 
            this.belsopanel.BackColor = System.Drawing.Color.Transparent;
            this.belsopanel.Controls.Add(this.button3);
            this.belsopanel.Controls.Add(this.button2);
            this.belsopanel.Controls.Add(this.button1);
            this.belsopanel.Location = new System.Drawing.Point(60, 60);
            this.belsopanel.Name = "belsopanel";
            this.belsopanel.Size = new System.Drawing.Size(280, 200);
            this.belsopanel.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "Információ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(102, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 52);
            this.button3.TabIndex = 6;
            this.button3.Text = "Készítők";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // kijonlbl
            // 
            this.kijonlbl.AutoSize = true;
            this.kijonlbl.BackColor = System.Drawing.Color.Transparent;
            this.kijonlbl.Location = new System.Drawing.Point(321, 13);
            this.kijonlbl.Name = "kijonlbl";
            this.kijonlbl.Size = new System.Drawing.Size(29, 13);
            this.kijonlbl.TabIndex = 6;
            this.kijonlbl.Text = "kijon";
            this.kijonlbl.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(694, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Bezár";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(816, 602);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.kijonlbl);
            this.Controls.Add(this.kulsopanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 602);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 602);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Malom";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.kulsopanel.ResumeLayout(false);
            this.kozepsopanel.ResumeLayout(false);
            this.kozepsopanel.PerformLayout();
            this.belsopanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nev1txb;
        private System.Windows.Forms.TextBox nev2txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel kulsopanel;
        private System.Windows.Forms.Panel kozepsopanel;
        private System.Windows.Forms.Panel belsopanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label kijonlbl;
        private System.Windows.Forms.Button button4;
    }
}

