
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
            this.gametablePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // nev1txb
            // 
            this.nev1txb.Location = new System.Drawing.Point(666, 68);
            this.nev1txb.Name = "nev1txb";
            this.nev1txb.Size = new System.Drawing.Size(100, 20);
            this.nev1txb.TabIndex = 0;
            // 
            // nev2txb
            // 
            this.nev2txb.Location = new System.Drawing.Point(666, 111);
            this.nev2txb.Name = "nev2txb";
            this.nev2txb.Size = new System.Drawing.Size(100, 20);
            this.nev2txb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ELső név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Második név:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gametablePanel
            // 
            this.gametablePanel.Location = new System.Drawing.Point(38, 12);
            this.gametablePanel.Name = "gametablePanel";
            this.gametablePanel.Size = new System.Drawing.Size(520, 440);
            this.gametablePanel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.gametablePanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nev2txb);
            this.Controls.Add(this.nev1txb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nev1txb;
        private System.Windows.Forms.TextBox nev2txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel gametablePanel;
    }
}

