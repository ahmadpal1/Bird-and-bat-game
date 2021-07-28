namespace WindowsFormsApplication4
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
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bat_2 = new System.Windows.Forms.PictureBox();
            this.bat_1 = new System.Windows.Forms.PictureBox();
            this.bat_3 = new System.Windows.Forms.PictureBox();
            this.star_1 = new System.Windows.Forms.PictureBox();
            this.star_2 = new System.Windows.Forms.PictureBox();
            this.scorelbl = new System.Windows.Forms.Label();
            this.gameoverlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star_2)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::WindowsFormsApplication4.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(180, 107);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 64);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication4.Properties.Resources.cloud_left;
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "cloud";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApplication4.Properties.Resources.cloud_left;
            this.pictureBox2.Location = new System.Drawing.Point(1, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "cloud";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::WindowsFormsApplication4.Properties.Resources.cloud_right;
            this.pictureBox3.Location = new System.Drawing.Point(332, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "cloud";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::WindowsFormsApplication4.Properties.Resources.cloud_right;
            this.pictureBox4.Location = new System.Drawing.Point(332, 236);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 200);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "cloud";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bat_2
            // 
            this.bat_2.BackColor = System.Drawing.Color.Transparent;
            this.bat_2.Image = global::WindowsFormsApplication4.Properties.Resources.bat1;
            this.bat_2.Location = new System.Drawing.Point(272, 381);
            this.bat_2.Name = "bat_2";
            this.bat_2.Size = new System.Drawing.Size(41, 55);
            this.bat_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bat_2.TabIndex = 5;
            this.bat_2.TabStop = false;
            this.bat_2.Tag = "bat";
            // 
            // bat_1
            // 
            this.bat_1.BackColor = System.Drawing.Color.Transparent;
            this.bat_1.Image = global::WindowsFormsApplication4.Properties.Resources.bat2;
            this.bat_1.Location = new System.Drawing.Point(231, 249);
            this.bat_1.Name = "bat_1";
            this.bat_1.Size = new System.Drawing.Size(41, 55);
            this.bat_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bat_1.TabIndex = 5;
            this.bat_1.TabStop = false;
            this.bat_1.Tag = "bat";
            // 
            // bat_3
            // 
            this.bat_3.BackColor = System.Drawing.Color.Transparent;
            this.bat_3.Image = global::WindowsFormsApplication4.Properties.Resources.bat3;
            this.bat_3.Location = new System.Drawing.Point(83, 362);
            this.bat_3.Name = "bat_3";
            this.bat_3.Size = new System.Drawing.Size(41, 55);
            this.bat_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bat_3.TabIndex = 5;
            this.bat_3.TabStop = false;
            this.bat_3.Tag = "bat";
            // 
            // star_1
            // 
            this.star_1.BackColor = System.Drawing.Color.Transparent;
            this.star_1.Image = global::WindowsFormsApplication4.Properties.Resources.start;
            this.star_1.Location = new System.Drawing.Point(83, 202);
            this.star_1.Name = "star_1";
            this.star_1.Size = new System.Drawing.Size(40, 40);
            this.star_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star_1.TabIndex = 6;
            this.star_1.TabStop = false;
            // 
            // star_2
            // 
            this.star_2.BackColor = System.Drawing.Color.Transparent;
            this.star_2.Image = global::WindowsFormsApplication4.Properties.Resources.start;
            this.star_2.Location = new System.Drawing.Point(257, 172);
            this.star_2.Name = "star_2";
            this.star_2.Size = new System.Drawing.Size(40, 40);
            this.star_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star_2.TabIndex = 6;
            this.star_2.TabStop = false;
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.BackColor = System.Drawing.Color.Transparent;
            this.scorelbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.ForeColor = System.Drawing.Color.White;
            this.scorelbl.Location = new System.Drawing.Point(178, 12);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(32, 33);
            this.scorelbl.TabIndex = 7;
            this.scorelbl.Text = "0";
            // 
            // gameoverlbl
            // 
            this.gameoverlbl.AutoSize = true;
            this.gameoverlbl.BackColor = System.Drawing.Color.DarkOrange;
            this.gameoverlbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameoverlbl.ForeColor = System.Drawing.Color.White;
            this.gameoverlbl.Location = new System.Drawing.Point(111, 156);
            this.gameoverlbl.Name = "gameoverlbl";
            this.gameoverlbl.Size = new System.Drawing.Size(170, 33);
            this.gameoverlbl.TabIndex = 8;
            this.gameoverlbl.Text = "Game-Over";
            this.gameoverlbl.Visible = false;
            this.gameoverlbl.Click += new System.EventHandler(this.gameoverlbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.gameoverlbl);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.star_2);
            this.Controls.Add(this.star_1);
            this.Controls.Add(this.bat_3);
            this.Controls.Add(this.bat_1);
            this.Controls.Add(this.bat_2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox bat_2;
        private System.Windows.Forms.PictureBox bat_1;
        private System.Windows.Forms.PictureBox bat_3;
        private System.Windows.Forms.PictureBox star_1;
        private System.Windows.Forms.PictureBox star_2;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label gameoverlbl;
    }
}

