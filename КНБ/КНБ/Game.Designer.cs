namespace КНБ
{
    partial class Game
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
            this.button1 = new System.Windows.Forms.Button();
            this.ChatTbMl = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textTb = new System.Windows.Forms.TextBox();
            this.scisPb = new System.Windows.Forms.PictureBox();
            this.paperPb = new System.Windows.Forms.PictureBox();
            this.rockPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.scisPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPb)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 274);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сделать ход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChatTbMl
            // 
            this.ChatTbMl.Location = new System.Drawing.Point(12, 12);
            this.ChatTbMl.Margin = new System.Windows.Forms.Padding(2);
            this.ChatTbMl.Multiline = true;
            this.ChatTbMl.Name = "ChatTbMl";
            this.ChatTbMl.Size = new System.Drawing.Size(212, 225);
            this.ChatTbMl.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 274);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Отправить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 274);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Добро пожаловать!";
            // 
            // textTb
            // 
            this.textTb.Location = new System.Drawing.Point(12, 242);
            this.textTb.Margin = new System.Windows.Forms.Padding(4);
            this.textTb.Name = "textTb";
            this.textTb.Size = new System.Drawing.Size(212, 22);
            this.textTb.TabIndex = 8;
            // 
            // scisPb
            // 
            this.scisPb.Image = global::КНБ.Properties.Resources.ножницы;
            this.scisPb.Location = new System.Drawing.Point(364, 12);
            this.scisPb.Margin = new System.Windows.Forms.Padding(2);
            this.scisPb.Name = "scisPb";
            this.scisPb.Size = new System.Drawing.Size(109, 180);
            this.scisPb.TabIndex = 2;
            this.scisPb.TabStop = false;
            this.scisPb.Click += new System.EventHandler(this.scisPb_Click);
            // 
            // paperPb
            // 
            this.paperPb.Image = global::КНБ.Properties.Resources.бумага;
            this.paperPb.Location = new System.Drawing.Point(478, 12);
            this.paperPb.Margin = new System.Windows.Forms.Padding(2);
            this.paperPb.Name = "paperPb";
            this.paperPb.Size = new System.Drawing.Size(109, 180);
            this.paperPb.TabIndex = 1;
            this.paperPb.TabStop = false;
            this.paperPb.Click += new System.EventHandler(this.paperPb_Click);
            // 
            // rockPb
            // 
            this.rockPb.Image = global::КНБ.Properties.Resources.камень;
            this.rockPb.Location = new System.Drawing.Point(250, 12);
            this.rockPb.Margin = new System.Windows.Forms.Padding(2);
            this.rockPb.Name = "rockPb";
            this.rockPb.Size = new System.Drawing.Size(109, 180);
            this.rockPb.TabIndex = 0;
            this.rockPb.TabStop = false;
            this.rockPb.Click += new System.EventHandler(this.rockPb_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(630, 321);
            this.Controls.Add(this.textTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ChatTbMl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scisPb);
            this.Controls.Add(this.paperPb);
            this.Controls.Add(this.rockPb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Game";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.scisPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rockPb;
        private System.Windows.Forms.PictureBox paperPb;
        private System.Windows.Forms.PictureBox scisPb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ChatTbMl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTb;
    }
}