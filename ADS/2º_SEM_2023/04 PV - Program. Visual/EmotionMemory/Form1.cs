
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace EmotionMemory
{
    public partial class Form1 : Form
    {
        int movs, clicks, found, tagIndex;

        Image[] img = new Image[8];

        List<string> list = new List<string>();
        int[] tags = new int[2];

        public Form1()
        {
            InitializeComponent();
            start();
        }


        private void start ()   
        { 
          foreach (PictureBox item in Controls.OfType<PictureBox>()) 
          {
                int tagIndex = int.Parse(String.Format("{0}", item.Tag));
                img[tagIndex] = item.Image;
                item.Image = Properties.Resources.card;
                item.Enabled = true;
          }
            Positions();
        }

        private void Positions() {

            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                Random rnd = new Random();
                int[] xP = { 37, 147, 256, 366};
                int[] yP = { 50, 161, 274, 384};

                sort:
                var X = xP[rnd.Next (0, xP.Length)];
                var Y = yP[rnd.Next (0, yP.Length)];


                string ok = X.ToString() + Y.ToString(); 

                if (list.Contains (ok))
                {
                    goto sort;
                }

                else
                {
                    item.Location = new Point(X, Y);
                    list.Add (ok);
                }

            }
        }

        private void ImagensClick_CLick (object sender, EventArgs e)
        {

            PictureBox pic = (PictureBox)sender;
            clicks++;
            tagIndex = int.Parse(String.Format("{0}", pic.Tag));
            pic.Image = img[tagIndex];
            pic.Refresh();
            pic.Enabled = false;   

            if ( clicks == 1 )
            {
                tags[0] = tagIndex;
            }

            else if ( clicks == 2 )
            {
                tags[1] = tagIndex;
                movs++;
                //lblmovs.Text = "Movimentos: " + movs.ToString();

                bool check = Checked();
                Showup(check);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool Checked ()
        {

            if (tags[0] == tags[1]) 
            {
                return true;   
            }
            else 
            {
                return false; 
            }
        }

        private void Showup(bool check)
        {
            Thread.Sleep(500);
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                if (int.Parse(String.Format("{0}", item.Tag)) == tags[0] || int.Parse(String.Format("{0}", item.Tag)) == tags[1])
                {
                    if (check)
                    {
                        found++;
                    }

                    else
                    {
                        item.Image = Properties.Resources.card;
                        item.Enabled = true;
                        item.Refresh();
                    }
                }
              
            }
            clicks = 0;
            EndGame();
        }
        private void EndGame()
        {
            if (found == (img.Length * 2))
            {
                MessageBox.Show("Parabéns, você terminou o jogo, com apenas " + movs + " movimentos !!", "Parabéns");
                DialogResult msg = MessageBox.Show("Deseja jogar novamente?!", "Parabéns", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    clicks = 0; movs = 0; found = 0; list.Clear(); start();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}