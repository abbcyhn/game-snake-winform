namespace SnakeGame
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.faylToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilePlay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileHighscore = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPausa = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.field = new System.Windows.Forms.PictureBox();
            this.lblResume = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.field)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(14, 14);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faylToolStripMenuItem,
            this.menuAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(551, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // faylToolStripMenuItem
            // 
            this.faylToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.faylToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFilePlay,
            this.menuFileHighscore,
            this.menuFileSettings,
            this.menuFileQuit});
            this.faylToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faylToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.faylToolStripMenuItem.Image = global::SnakeGame.Properties.Resources.file;
            this.faylToolStripMenuItem.Name = "faylToolStripMenuItem";
            this.faylToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.faylToolStripMenuItem.Text = "Fayl";
            // 
            // menuFilePlay
            // 
            this.menuFilePlay.ForeColor = System.Drawing.Color.Black;
            this.menuFilePlay.Image = global::SnakeGame.Properties.Resources.start;
            this.menuFilePlay.Name = "menuFilePlay";
            this.menuFilePlay.Size = new System.Drawing.Size(164, 22);
            this.menuFilePlay.Text = "Oyna";
            this.menuFilePlay.Click += new System.EventHandler(this.menuFilePlay_Click);
            // 
            // menuFileHighscore
            // 
            this.menuFileHighscore.ForeColor = System.Drawing.Color.Black;
            this.menuFileHighscore.Image = global::SnakeGame.Properties.Resources.score;
            this.menuFileHighscore.Name = "menuFileHighscore";
            this.menuFileHighscore.Size = new System.Drawing.Size(164, 22);
            this.menuFileHighscore.Text = "Yüksək xal";
            this.menuFileHighscore.Click += new System.EventHandler(this.menuFileHighscore_Click);
            // 
            // menuFileSettings
            // 
            this.menuFileSettings.ForeColor = System.Drawing.Color.Black;
            this.menuFileSettings.Image = global::SnakeGame.Properties.Resources.options;
            this.menuFileSettings.Name = "menuFileSettings";
            this.menuFileSettings.Size = new System.Drawing.Size(164, 22);
            this.menuFileSettings.Text = "Tənzimləmələr";
            this.menuFileSettings.Click += new System.EventHandler(this.menuFileSettings_Click);
            // 
            // menuFileQuit
            // 
            this.menuFileQuit.ForeColor = System.Drawing.Color.Black;
            this.menuFileQuit.Image = global::SnakeGame.Properties.Resources.quit;
            this.menuFileQuit.Name = "menuFileQuit";
            this.menuFileQuit.Size = new System.Drawing.Size(164, 22);
            this.menuFileQuit.Text = "Çıxış";
            this.menuFileQuit.Click += new System.EventHandler(this.menuFileQuit_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.BackColor = System.Drawing.Color.Transparent;
            this.menuAbout.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuAbout.ForeColor = System.Drawing.Color.Black;
            this.menuAbout.Image = global::SnakeGame.Properties.Resources.about;
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(102, 21);
            this.menuAbout.Text = "Haqqında";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 311);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(551, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Matura MT Script Capitals", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 313);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(66, 20);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Xal: 0";
            // 
            // lblPausa
            // 
            this.lblPausa.AutoSize = true;
            this.lblPausa.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPausa.Location = new System.Drawing.Point(446, 316);
            this.lblPausa.Name = "lblPausa";
            this.lblPausa.Size = new System.Drawing.Size(78, 17);
            this.lblPausa.TabIndex = 3;
            this.lblPausa.Text = "P - Fasilə";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // field
            // 
            this.field.BackColor = System.Drawing.Color.Black;
            this.field.Location = new System.Drawing.Point(0, 25);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(551, 285);
            this.field.TabIndex = 4;
            this.field.TabStop = false;
            this.field.Paint += new System.Windows.Forms.PaintEventHandler(this.field_Paint);
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblResume.Location = new System.Drawing.Point(433, 316);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(100, 17);
            this.lblResume.TabIndex = 5;
            this.lblResume.Text = "L - Davam et";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 333);
            this.Controls.Add(this.lblResume);
            this.Controls.Add(this.field);
            this.Controls.Add(this.lblPausa);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "İlan Oyunu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.field)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem faylToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFilePlay;
        private System.Windows.Forms.ToolStripMenuItem menuFileHighscore;
        private System.Windows.Forms.ToolStripMenuItem menuFileSettings;
        private System.Windows.Forms.ToolStripMenuItem menuFileQuit;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPausa;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox field;
        private System.Windows.Forms.Label lblResume;
    }
}

