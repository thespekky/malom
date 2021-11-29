
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
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // visszabtn
            // 
            this.visszabtn.Location = new System.Drawing.Point(30, 27);
            this.visszabtn.Name = "visszabtn";
            this.visszabtn.Size = new System.Drawing.Size(75, 23);
            this.visszabtn.TabIndex = 0;
            this.visszabtn.Text = "Vissza";
            this.visszabtn.UseVisualStyleBackColor = true;
            this.visszabtn.Click += new System.EventHandler(this.visszabtn_Click);
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
            this.informaciolbl.AutoSize = true;
            this.informaciolbl.Location = new System.Drawing.Point(27, 84);
            this.informaciolbl.Name = "informaciolbl";
            this.informaciolbl.Size = new System.Drawing.Size(35, 13);
            this.informaciolbl.TabIndex = 2;
            this.informaciolbl.Text = "label1";
            // 
            // inf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.ControlBox = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button visszabtn;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label informaciolbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}