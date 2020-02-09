using System;
using System.Drawing;
using System.Windows.Forms;

[assembly: CLSCompliant(true)]
namespace SnakeGame
{
    public partial class Main : Form
    {
        Food apple;
        Snake snake;
        private int score;
        About about = new About();
        Settings settings = new Settings();
        HighScore highscore = new HighScore();
        DialogResult result = new DialogResult();

        public Main()
        {
            InitializeComponent();
            GameStart();
        }


        private void GameStart()
        {
            score = 0;
            apple = new Apple();
            HighScore.CreatePath();
            snake = new YellowSnake();
            lblPausa.Visible = true;
            lblResume.Visible = false;
            settings.ChooseLevel(timer);
            lblScore.Text = "Xal: " + score;
            timer.Start();
        }
                    

        private void GameOver()
        {
            timer.Enabled = false;
            result = MessageBox.Show("Oyuna davam etmək istiyirsən?", "Diqqət!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                HighScore.Write(score);
                GameStart();
            }
            else
            {
                HighScore.Write(score);
                this.Close();
            }
        }

        private void Collision()
        {
            if (snake.Body[0].IntersectsWith(apple.Body))
            {
                score += apple.Point;
                snake.Grow();
                apple.Move();
                lblScore.Text = "Xal: " + score;
            }

            for (int i = 1; i < snake.Body.Length; i++)
                if (snake.Body[0].IntersectsWith(snake.Body[i]))
                    GameOver();

            if (snake.Body[0].X < 0 || snake.Body[0].X > field.Size.Width || snake.Body[0].Y < 0 || snake.Body[0].Y > field.Size.Height)
                GameOver();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Collision();
            snake.Move();
            HighScore.Read();
            settings.ChooseLevel(timer);
            field.Invalidate();
        }

        private void Main_KeyDown(object sender, KeyEventArgs key)
        {
            if (key.KeyData == Keys.P)
            {
                timer.Stop();
                lblPausa.Visible = false;
                lblResume.Visible = true;
            }

            if (key.KeyData == Keys.L)
            {
                timer.Start();
                lblPausa.Visible = true;
                lblResume.Visible = false;
            }

            if (settings.Arrows.Checked)
                snake.KeyControl(key, Keys.Up, Keys.Down, Keys.Right, Keys.Left);
            else if (settings.Keys.Checked)
                snake.KeyControl(key, Keys.W, Keys.S, Keys.D, Keys.A);
        }

        private void field_Paint(object sender, PaintEventArgs e)
        {
            snake.Draw(e.Graphics, Color.Yellow);
            apple.Draw(e.Graphics, Color.Red);
        }

        private void menuFilePlay_Click(object sender, EventArgs e)
        {
            GameStart();
        }

        private void menuFileHighscore_Click(object sender, EventArgs e)
        {
            highscore.ShowDialog();
        }

        private void menuFileSettings_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }

        private void menuFileQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            about.ShowDialog();
        }
    }
}