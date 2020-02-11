using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace snake
{
    public partial class frm1 : Form
    {
        public Snake snake;
        public PictureBox[] pb_SnakePieces;
        public Direction direction;
        public bool Have_Food;
        private Random random = new Random();
        private PictureBox Food;
        public int Score;
        public int Level;
        public frm1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();


        }
        private void NewGame()
        {
            snake = new Snake();
            direction = new Direction(-10, 0);
            pb_SnakePieces = new PictureBox[0];
            for (int i = 0; i < 3; i++)
            {
                Array.Resize(ref pb_SnakePieces, pb_SnakePieces.Length + 1);
                pb_SnakePieces[i] = AddPictureBox();
            }
            timer1.Start();
            btnRefresh.Enabled = false;
            Have_Food = false;
            Score = 0;
            Level = 1;
            timer1.Interval = 50;
        }
        private PictureBox AddPictureBox()
        {
            PictureBox pb = new PictureBox();
            pb.Size = new Size(10, 10);
            pb.BackColor = Color.Green;
            pb.Location = snake.getPosition(pb_SnakePieces.Length - 1);
            panel1.Controls.Add(pb);
            return pb;
        }
        private void PB_Update()
        {
            for (int i = 0; i < pb_SnakePieces.Length; i++)
            {
                pb_SnakePieces[i].Location = snake.getPosition(i);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (direction._y != 10)
                    direction = new Direction(0, -10);
            }

            else if (e.KeyCode == Keys.Down)
            {
                if (direction._y != -10)
                    direction = new Direction(0, 10);
            }

            else if (e.KeyCode == Keys.Left)
            {
                if (direction._x != 10)
                    direction = new Direction(-10, 0);
            }

            else if (e.KeyCode == Keys.Right)
            {
                if (direction._x != -10)
                    direction = new Direction(10, 0);
            }

            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.H)
            {
                cheats = true;
            }
            if (e.KeyCode == Keys.J)
            {
                cheats = false;
            }
            if (e.KeyCode == Keys.Space)
            {

                if (pasue)
                {
                    timer1.Start();
                    pasue = false;
                }
                else
                {
                    timer1.Stop();
                    pasue = true;
                }

            }
        }
        bool pasue = false;
        bool cheats = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            snake.Forward(direction);
            PB_Update();
            CreateFood();
            Has_Eat_Food();
            if (!cheats)
            {

                this.BackColor = Color.White;
                panel1.BackColor = Color.Black;
                Snake_eat_own();
                Crush_Walls();
            }
            else
            {
                this.BackColor = Color.Black;
                panel1.BackColor = Color.White;
                Easy_World();
            }
        }
        public void CreateFood()
        {
            if (!Have_Food)
            {
                Have_Food = true;
                PictureBox pb = new PictureBox();
                pb.BackColor = Color.Blue;
                pb.Size = new Size(10, 10);
                pb.Location = new Point(random.Next(panel1.Width / 10) * 10, random.Next(panel1.Height / 10) * 10);
                Food = pb;
                panel1.Controls.Add(pb);
            }
        }
        public void Has_Eat_Food()
        {
            if (snake.getPosition(0) == Food.Location)
            {
                Score += 10;
                if (Score % 100 == 0)
                    Level_Up();
                lblScore.Text = "Score : " + Score;
                snake.GrowUp();
                Array.Resize(ref pb_SnakePieces, pb_SnakePieces.Length + 1);
                pb_SnakePieces[pb_SnakePieces.Length - 1] = AddPictureBox();
                Have_Food = false;
                panel1.Controls.Remove(Food);
            }
        }
        public void Snake_eat_own()
        {
            for (int i = 1; i < snake.SneakeSize; i++)
            {
                if (snake.getPosition(0) == snake.getPosition(i))
                {
                    Game_over();
                }

            }
        }
        public void Crush_Walls()
        {
            Point p = snake.getPosition(0);
            if (p.X < 0 || p.X > panel1.Width - 10 || p.Y < 0 || p.Y > panel1.Height - 10)
            {
                Game_over();
            }
        }
        private void Game_over()
        {
            timer1.Stop();
            MessageBox.Show("Game Over  Lost \nYour Score : " + (Score + (Level * 100)));
            btnRefresh.Enabled = true;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            NewGame();
        }
        private void Level_Up()
        {
            if ((timer1.Interval - Level * 2) > 0)
                timer1.Interval -= Level * 2;
            else
                timer1.Interval = 12;
            lblLevel.Text = "Level : " + Level;
            Score = 0;
            Level++;

        }
        private void Easy_World()
        {

            Point p = snake.getPosition(0);
            if (p.X < 0) // Sol Duvar
            {
                snake.setPosition(panel1.Width - 10, p.Y);
                direction = new Direction(-10, 0);
            }
            else if (p.X > panel1.Width - 10)// Sað duvar
            {
                snake.setPosition(0, p.Y);
                direction = new Direction(10, 0);
            }
            else if (p.Y < 0)//Üst
            {
                snake.setPosition(p.X, panel1.Height - 10);
                direction = new Direction(0, -10);
            }
            else if (p.Y > panel1.Height - 10)//Alt
            {
                snake.setPosition(p.X, 0);
                direction = new Direction(0, 10);
            }
        }

        private void frm1_BackColorChanged(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                lblKeys.ForeColor = Color.Black;
                lblLevel.ForeColor = Color.Black;
                lblScore.ForeColor = Color.Black;
            }
            else
            {
                lblKeys.ForeColor = Color.White;
                lblLevel.ForeColor = Color.White;
                lblScore.ForeColor = Color.White;
            }
        }
    }
}
