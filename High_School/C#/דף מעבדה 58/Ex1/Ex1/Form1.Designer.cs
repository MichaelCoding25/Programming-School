namespace Ex1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button_start = new System.Windows.Forms.Button();
            this.Button_Stop = new System.Windows.Forms.Button();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Hits_Label = new System.Windows.Forms.Label();
            this.BombPicture = new System.Windows.Forms.PictureBox();
            this.Move_Timer1 = new System.Windows.Forms.Timer(this.components);
            this.BoomPicture = new System.Windows.Forms.PictureBox();
            this.Boom_Timer = new System.Windows.Forms.Timer(this.components);
            this.GameOverPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BombPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoomPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_start
            // 
            this.Button_start.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Button_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Button_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_start.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_start.Location = new System.Drawing.Point(12, 485);
            this.Button_start.Name = "Button_start";
            this.Button_start.Size = new System.Drawing.Size(86, 34);
            this.Button_start.TabIndex = 0;
            this.Button_start.Text = "START";
            this.Button_start.UseVisualStyleBackColor = false;
            this.Button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // Button_Stop
            // 
            this.Button_Stop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Button_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Stop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Button_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_Stop.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Stop.Location = new System.Drawing.Point(124, 485);
            this.Button_Stop.Name = "Button_Stop";
            this.Button_Stop.Size = new System.Drawing.Size(86, 34);
            this.Button_Stop.TabIndex = 1;
            this.Button_Stop.Text = "STOP";
            this.Button_Stop.UseVisualStyleBackColor = false;
            this.Button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // Button_Reset
            // 
            this.Button_Reset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Button_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Reset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Button_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Button_Reset.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Reset.Location = new System.Drawing.Point(1179, 485);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(86, 34);
            this.Button_Reset.TabIndex = 2;
            this.Button_Reset.Text = "RESET";
            this.Button_Reset.UseVisualStyleBackColor = false;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Title.Location = new System.Drawing.Point(431, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(327, 42);
            this.Title.TabIndex = 3;
            this.Title.Text = "Catch the Runner";
            // 
            // Hits_Label
            // 
            this.Hits_Label.AutoSize = true;
            this.Hits_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Hits_Label.Location = new System.Drawing.Point(560, 487);
            this.Hits_Label.Name = "Hits_Label";
            this.Hits_Label.Size = new System.Drawing.Size(68, 24);
            this.Hits_Label.TabIndex = 4;
            this.Hits_Label.Text = "Hits: 0";
            // 
            // BombPicture
            // 
            this.BombPicture.Image = ((System.Drawing.Image)(resources.GetObject("BombPicture.Image")));
            this.BombPicture.Location = new System.Drawing.Point(43, 204);
            this.BombPicture.Name = "BombPicture";
            this.BombPicture.Size = new System.Drawing.Size(73, 75);
            this.BombPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BombPicture.TabIndex = 5;
            this.BombPicture.TabStop = false;
            this.BombPicture.Click += new System.EventHandler(this.BombPicture_Click);
            // 
            // Move_Timer1
            // 
            this.Move_Timer1.Interval = 150;
            this.Move_Timer1.Tick += new System.EventHandler(this.Move_Timer1_Tick);
            // 
            // BoomPicture
            // 
            this.BoomPicture.Image = ((System.Drawing.Image)(resources.GetObject("BoomPicture.Image")));
            this.BoomPicture.Location = new System.Drawing.Point(495, 167);
            this.BoomPicture.Name = "BoomPicture";
            this.BoomPicture.Size = new System.Drawing.Size(259, 194);
            this.BoomPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoomPicture.TabIndex = 6;
            this.BoomPicture.TabStop = false;
            // 
            // Boom_Timer
            // 
            this.Boom_Timer.Tick += new System.EventHandler(this.Boom_Timer_Tick);
            // 
            // GameOverPicture
            // 
            this.GameOverPicture.Image = ((System.Drawing.Image)(resources.GetObject("GameOverPicture.Image")));
            this.GameOverPicture.Location = new System.Drawing.Point(-1255, -14);
            this.GameOverPicture.Name = "GameOverPicture";
            this.GameOverPicture.Size = new System.Drawing.Size(1283, 480);
            this.GameOverPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameOverPicture.TabIndex = 7;
            this.GameOverPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 528);
            this.Controls.Add(this.GameOverPicture);
            this.Controls.Add(this.BoomPicture);
            this.Controls.Add(this.BombPicture);
            this.Controls.Add(this.Hits_Label);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Button_Stop);
            this.Controls.Add(this.Button_start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BombPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoomPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_start;
        private System.Windows.Forms.Button Button_Stop;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Hits_Label;
        private System.Windows.Forms.PictureBox BombPicture;
        private System.Windows.Forms.Timer Move_Timer1;
        private System.Windows.Forms.PictureBox BoomPicture;
        private System.Windows.Forms.Timer Boom_Timer;
        private System.Windows.Forms.PictureBox GameOverPicture;


    }
}

