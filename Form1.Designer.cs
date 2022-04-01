
namespace Warcaby
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
            this.picGround = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelp1 = new System.Windows.Forms.Label();
            this.labelp2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.TextBox();
            this.Player2 = new System.Windows.Forms.TextBox();
            this.W = new System.Windows.Forms.Panel();
            this.labelw = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.play = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.W.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picGround
            // 
            this.picGround.BackColor = System.Drawing.Color.Gray;
            this.picGround.Location = new System.Drawing.Point(10, 10);
            this.picGround.Name = "picGround";
            this.picGround.Size = new System.Drawing.Size(484, 484);
            this.picGround.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Warcaby.Properties.Resources.g;
            this.pictureBox1.Location = new System.Drawing.Point(500, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Warcaby.Properties.Resources.r;
            this.pictureBox2.Location = new System.Drawing.Point(500, 444);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // labelp1
            // 
            this.labelp1.AutoSize = true;
            this.labelp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelp1.ForeColor = System.Drawing.Color.Green;
            this.labelp1.Location = new System.Drawing.Point(556, 19);
            this.labelp1.Name = "labelp1";
            this.labelp1.Size = new System.Drawing.Size(36, 37);
            this.labelp1.TabIndex = 3;
            this.labelp1.Text = "0";
            // 
            // labelp2
            // 
            this.labelp2.AutoSize = true;
            this.labelp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelp2.ForeColor = System.Drawing.Color.Red;
            this.labelp2.Location = new System.Drawing.Point(556, 452);
            this.labelp2.Name = "labelp2";
            this.labelp2.Size = new System.Drawing.Size(36, 37);
            this.labelp2.TabIndex = 4;
            this.labelp2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(500, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(500, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player 1";
            // 
            // Player1
            // 
            this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Player1.Location = new System.Drawing.Point(614, 74);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(155, 35);
            this.Player1.TabIndex = 7;
            this.Player1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Player1_KeyPress);
            // 
            // Player2
            // 
            this.Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Player2.Location = new System.Drawing.Point(614, 389);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(155, 35);
            this.Player2.TabIndex = 8;
            this.Player2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Player1_KeyPress);
            // 
            // W
            // 
            this.W.BackColor = System.Drawing.Color.Gold;
            this.W.Controls.Add(this.panel1);
            this.W.Controls.Add(this.label4);
            this.W.Controls.Add(this.labelw);
            this.W.Dock = System.Windows.Forms.DockStyle.Fill;
            this.W.Location = new System.Drawing.Point(0, 0);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(800, 511);
            this.W.TabIndex = 9;
            // 
            // labelw
            // 
            this.labelw.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelw.ForeColor = System.Drawing.Color.White;
            this.labelw.Location = new System.Drawing.Point(139, 138);
            this.labelw.Name = "labelw";
            this.labelw.Size = new System.Drawing.Size(523, 113);
            this.labelw.TabIndex = 0;
            this.labelw.Text = "You win";
            this.labelw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(246, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 84);
            this.label4.TabIndex = 1;
            this.label4.Text = "Play again";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.play);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 511);
            this.panel1.TabIndex = 2;
            // 
            // play
            // 
            this.play.AutoSize = true;
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.play.ForeColor = System.Drawing.Color.White;
            this.play.Location = new System.Drawing.Point(320, 208);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(161, 73);
            this.play.TabIndex = 0;
            this.play.Text = "Play";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.W);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelp2);
            this.Controls.Add(this.labelp1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.W.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel picGround;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelp1;
        private System.Windows.Forms.Label labelp2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Player1;
        private System.Windows.Forms.TextBox Player2;
        private System.Windows.Forms.Panel W;
        private System.Windows.Forms.Label labelw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label play;
    }
}

