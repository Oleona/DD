using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigitalDesignTask
{
    public partial class WorkingForm : Form
    {
        readonly List<Button> btns = new();
        enum Orientation
        {
            Horizontal,
            Vertical
        }
        void PlayingFieldSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PlayingFieldSize_Draw();  
            }
        }
        void PlayingFieldSize_Draw()
        {
            bool result = int.TryParse(playingFieldSize.Text, out var N);
            if (!result)
            {
                MessageBox.Show("You entered not an integer. Please enter an integer greater than 3");
                Application.Exit();
                Application.Restart();
            }
            if (N <= 3)
            {
                MessageBox.Show("Please enter an integer greater than 3");
                Application.Exit();
                Application.Restart();
            }
            playingFieldSize.Visible = false;
            lblInputN.Visible = false;
            ButtonCreate(N);
        }

        void ButtonCreate(int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Button btn = new();
                    btn.Height = ClientSize.Height > ClientSize.Width
                        ? ClientSize.Width / N
                        : ClientSize.Height / N;
                    btn.Width = btn.Height;
                    btn.Name = (j + 1) + (i + 1).ToString();
                    btn.Tag = new Random().Next(2) == 0 ? Orientation.Vertical : Orientation.Horizontal;
                    if (btn.Tag.ToString().Equals("Vertical"))
                    {
                        btn.BackgroundImage = Image.FromFile(@"d:\skills_recovery\DigitalDesignTask\dd1\image\btnvert.png", false);
                    }
                    else
                    {
                        btn.BackgroundImage = Image.FromFile(@"d:\skills_recovery\DigitalDesignTask\dd1\image\btnhor.png", false);
                    }
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Location = new Point(btn.Height * i, btn.Width * j);
                    btn.Click += ButtonOnClick;
                    Controls.Add(btn);
                    btns.Add(btn);
                }
            }
        }

        void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var btn = (Button)sender;
            if (btn != null)
            {
                StringBuilder sb = new();
                var btnName = btn.Name;
                var btnNameStart = btnName[0..^1];
                var btnNameEnd = btnName[1..];
                foreach (Button b in btns)
                {
                    if (b.Name.StartsWith(btnNameStart) || b.Name.EndsWith(btnNameEnd))
                    {
                        string tag = b.Tag.ToString();                                                     
                        if (tag == "Horizontal")
                        {
                            b.Tag = Orientation.Vertical;                   
                            b.BackgroundImage = Image.FromFile(@"d:\skills_recovery\DigitalDesignTask\dd1\image\btnvert.png", false);
                        }
                        else
                        {
                            b.Tag = Orientation.Horizontal;
                            b.BackgroundImage = Image.FromFile(@"d:\skills_recovery\DigitalDesignTask\dd1\image\btnhor.png", false);
                        }
                    }
                    sb.Append(b.Tag.ToString());
                }
                string directions = sb.ToString();
                if (!(directions.Contains("Horizontal") & directions.Contains("Vertical")))
                {
                    MessageBox.Show("YOU WIN!!!!");
                    Application.Exit();
                    Application.Restart();
                }
            }
        }
        public WorkingForm()
        {
            InitializeComponent();
            btnExit.BackgroundImage = Image.FromFile(@"d:\skills_recovery\DigitalDesignTask\dd1\image\exit.png", false);
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            playingFieldSize.KeyDown += PlayingFieldSize_KeyDown;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      
    }
}
