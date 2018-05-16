using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Select
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int leftPos = 250;
        public int topPos = 0;
        public int i = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string card in imageList1.Images.Keys)
            {
                imageList1.Images.Keys.ToString();
                listBox1.Items.Add(card);
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CardSelected = listBox1.SelectedItem.ToString();
            Image Card = imageList1.Images[CardSelected];
            pictureBox1.BackgroundImage = imageList1.Images[CardSelected];
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            foreach (string card in imageList1.Images.Keys)
            {
                PictureBox newCard = new PictureBox();
                newCard.Size = new Size(70, 140);
                newCard.Location = new Point(leftPos, topPos);
                newCard.Image = imageList1.Images[i];
                this.Controls.Add(newCard);
                newCard.BringToFront();
                leftPos = (leftPos + 20);

                if (leftPos > 550)
                {
                    topPos = topPos + 75;
                    leftPos = 250;
                }
                i++;

            }
        }
    }
}
