using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsApplication4
{
    class PicMatrix
    {
        public PictureBox[,] pic = new PictureBox[2,3];
        Color []c = new Color[4];
        private int []rs=new int[3];
        Random r = new Random();
        private int height;
        private int width;
        public  int countright=0;
        public PicMatrix(int height,int width)
        {
            c[0] = Color.Blue;
            c[1] = Color.Red;
            c[2] = Color.Green;
            c[3] = Color.Yellow;
            rs[0] = r.Next(0, 3);
            rs[1] = r.Next(0, 3);
            rs[2] = r.Next(0, 3);

            this.height = height;
            this.width = width;
        }
        public void picShow(Form form1)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    pic[j, i] = new PictureBox();
                    pic[j, i].Size = new Size(height, width);
                    pic[j, i].Location = new Point(300 + i * height, 200 + j * width);
                    pic[j, i].BorderStyle = BorderStyle.Fixed3D;
                    form1.Controls.Add(pic[j, i]);
                    pic[j, i].Visible = false;
                }

                
            }
        }
        public void randomShow()
        {
            for(int j =0;j<2;j++)
            {
                for(int i=0;i<3;i++)
                {
                    pic[j, i].BackColor = c[rs[i]];
                    pic[j, i].Visible = true;
                }
                this.randomColor();
            }
        }
        public void randomColor()
        {
            int rr,temp;
            for(int i=0;i<rs.Length;i++)
            {
                rr = r.Next(0,3);
                temp = rs[i];
                rs[i] = rs[rr];
                rs[rr] = temp;
            }
        }
        public void resetColor()
        {
            for(int i=0;i<rs.Length;i++)
            {
                rs[i] = r.Next(0, 3);
            }
        }
        public void compareColor(PictureBox p,int i)
        {
            if(countright==3)
            {
                countright = 0;
                this.resetColor();
                this.randomShow();
            }
            else if(p.BackColor.Equals(c[rs[i]]))
            {
                pic[1, i].BackColor = c[rs[i]];
                countright=countright+1;
            }
            else
            {
                countright = 0;
                this.resetColor();
                this.randomShow();
            }
        }
        
    }
}
