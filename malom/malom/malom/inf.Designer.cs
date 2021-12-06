
namespace malom
{
    partial class inf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inf));
            this.visszabtn = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.informaciolbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.korong1 = new System.Windows.Forms.PictureBox();
            this.krong2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krong2)).BeginInit();
            this.SuspendLayout();
            // 
            // visszabtn
            // 
            this.visszabtn.Location = new System.Drawing.Point(30, 27);
            this.visszabtn.Name = "visszabtn";
            this.visszabtn.Size = new System.Drawing.Size(84, 34);
            this.visszabtn.TabIndex = 0;
            this.visszabtn.Text = "Vissza";
            this.visszabtn.UseVisualStyleBackColor = true;
            this.visszabtn.Click += new System.EventHandler(this.visszabtn_Click);
            this.visszabtn.MouseEnter += new System.EventHandler(this.visszabtn_MouseEnter);
            this.visszabtn.MouseLeave += new System.EventHandler(this.visszabtn_MouseLeave);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(560, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // informaciolbl
            // 
            this.informaciolbl.BackColor = System.Drawing.Color.Red;
            this.informaciolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.informaciolbl.ForeColor = System.Drawing.Color.Black;
            this.informaciolbl.Location = new System.Drawing.Point(54, 84);
            this.informaciolbl.Name = "informaciolbl";
            this.informaciolbl.Size = new System.Drawing.Size(405, 327);
            this.informaciolbl.TabIndex = 2;
            this.informaciolbl.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(525, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Készítők:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(631, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bodnár András";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(631, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bodnár Tamás";
            // 
            // korong1
            // 
            this.korong1.BackColor = System.Drawing.Color.Red;
            this.korong1.Image = ((System.Drawing.Image)(resources.GetObject("korong1.Image")));
            this.korong1.Location = new System.Drawing.Point(131, 355);
            this.korong1.Name = "korong1";
            this.korong1.Size = new System.Drawing.Size(42, 42);
            this.korong1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.korong1.TabIndex = 7;
            this.korong1.TabStop = false;
            // 
            // krong2
            // 
            this.krong2.BackColor = System.Drawing.Color.Red;
            this.krong2.Image = ((System.Drawing.Image)(resources.GetObject("krong2.Image")));
            this.krong2.Location = new System.Drawing.Point(300, 355);
            this.krong2.Name = "krong2";
            this.krong2.Size = new System.Drawing.Size(45, 42);
            this.krong2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.krong2.TabIndex = 8;
            this.krong2.TabStop = false;
            this.krong2.Click += new System.EventHandler(this.krong2_Click);
            // 
            // inf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.ControlBox = false;
            this.Controls.Add(this.krong2);
            this.Controls.Add(this.korong1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.informaciolbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.visszabtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 602);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 602);
            this.Name = "inf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "információ";
            this.Load += new System.EventHandler(this.inf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krong2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button visszabtn;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label informaciolbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox krong2;
        private System.Windows.Forms.PictureBox korong1;
    }
}