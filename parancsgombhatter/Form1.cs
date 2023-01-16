using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parancsgombhatter
{
    public partial class Form1 : Form
    {
        int sorokSzama = 3;
        int oszlopokSzama = 6;
        int kepSize = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    PictureBox kep = new PictureBox();

                    kep.SetBounds(j * kepSize, i * kepSize, kepSize, kepSize);
                    kep.Text = (i * oszlopokSzama + j.ToString());
                    kep.BackColor = Color.Black;
                    kep.Click += (o, ev) => {
                       

                        PictureBox gomb = (PictureBox)o;
                        gomb.BackgroundImage = Properties.Resources.hell4;
                        gomb.BackgroundImageLayout = ImageLayout.Zoom;
                        

                    };
                    panel1.Controls.Add(kep);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
