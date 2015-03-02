using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        PicMatrix pictureshow = new PicMatrix(100, 100); 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1024,768);
            pictureshow.picShow(this);
            pictureshow.randomShow();
            button1.Location = new Point(300,500);
            button1.Text = "PLAY";
            pictureshow.pic[1, 0].Click += new EventHandler(pic_Click1);
            pictureshow.pic[1, 1].Click += new EventHandler(pic_Click2);
            pictureshow.pic[1, 2].Click += new EventHandler(pic_Click3);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureshow.pic[1,0].BackColor=Color.Gray;
            pictureshow.pic[1, 1].BackColor = Color.Gray;
            pictureshow.pic[1, 2].BackColor = Color.Gray;
            
        }
        private void pic_Click1(object sender, EventArgs e)
        {
            pictureshow.compareColor(pictureshow.pic[0,pictureshow.countright],0);
        }
        private void pic_Click2(object sender, EventArgs e)
        {
            pictureshow.compareColor(pictureshow.pic[0, pictureshow.countright], 1);
        }
        private void pic_Click3(object sender, EventArgs e)
        {
            pictureshow.compareColor(pictureshow.pic[0, pictureshow.countright], 2);
        }

    }
}
