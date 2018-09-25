using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRight_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Location.X < ClientRectangle.Width - pictureBox1.Width)
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
			}
		}
       

        private void btnUp_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Location.Y > 0)
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
			}
		}
        

        private void btnDown_Click(object sender, EventArgs e)
		{
	         if(pictureBox1.Location.Y < ClientRectangle.Height - pictureBox1.Height)
			{
					pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
			}
		}

        private void btnLeft_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Location.X > 0)
			{
				pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
			}
		}
        

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void ffffffffffffffffffffff_Click(object sender, EventArgs e)
        {
            int d;

            try
            {
                d = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Dont be an idiot. Type in a number");
                d = 10;
            }

            for (int i = 0; i < 10; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
                await Task.Delay(d);
            }
        }
    }
}
