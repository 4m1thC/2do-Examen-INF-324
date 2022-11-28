using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication23
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        int x, y;

        int mR = 0, mG = 0, mB = 0;

        int[] arr = new int[9];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todos|*.*|Archivos JPGE|*.jpg|Archivos GIF|*.gif" ;
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = bmp;

        }

        //seleccionar color
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            textBox4.Text = x.ToString();
            textBox5.Text = y.ToString();
            Color c = new Color();
            c = bmp.GetPixel(x,y);
            mR = 0; mG = 0; mB = 0;

            for (int i = x; i < x+10; i++)
            {
                for (int j = y; j < y+10; j++)
                {
                    c = bmp.GetPixel(i, j);
                    mR = mR + c.R;
                    mG = mG + c.G;
                    mB = mB + c.B;
                }
            }
            mR = mR/100;
            mG = mG/100;
            mB = mB/100;
            textBox1.Text = mR.ToString();
            textBox2.Text = mG.ToString();
            textBox3.Text = mB.ToString();

        }

        //pintar segmentos con el primer color
        private void button8_Click(object sender, EventArgs e)
        {
            int mRn = 0, mGn = 0, mBn = 0;
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            arr[0] = mR;
            arr[1] = mG;
            arr[2] = mB;
            for (int i = 0; i < bmp.Width-10; i=i+10)
                for (int j = 0; j < bmp.Height-10; j=j+10)
                {
                    for (int i2 = i; i2 < i + 10; i2++)
                        for (int j2 = j; j2 < j + 10; j2++)
                        {
                            c = bmp.GetPixel(i2, j2);
                            mRn = mRn + c.R;
                            mGn = mGn + c.G;
                            mBn = mBn + c.B;
                        }
                    
                        mRn = mRn / 100;
                        mGn = mGn / 100;
                        mBn = mBn / 100;

                    if ((arr[0] - 10 <= mRn) && (mRn <= arr[0] + 10) &&
                        ((arr[1] - 10 <= mGn) && (mGn <= arr[1] + 10) &&
                        (arr[2] - 10 <= mBn) && (mBn <= arr[2] + 10)))
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                bmp2.SetPixel(i2, j2, Color.Fuchsia);
                            }
                    }
                    else if ((arr[3] - 10 <= mRn) && (mRn <= arr[3] + 10) &&
                      ((arr[4] - 10 <= mGn) && (mGn <= arr[4] + 10) &&
                      (arr[5] - 10 <= mBn) && (mBn <= arr[5] + 10)))
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                bmp2.SetPixel(i2, j2, Color.Bisque);
                            }
                    }
                    else if ((arr[6] - 10 <= mRn) && (mRn <= arr[6] + 10) &&
                      ((arr[7] - 10 <= mGn) && (mGn <= arr[7] + 10) &&
                      (arr[8] - 10 <= mBn) && (mBn <= arr[8] + 10)))
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                bmp2.SetPixel(i2, j2, Color.DarkRed);
                            }
                    }
                    else {
                            for (int i2 = i; i2 < i + 10; i2++)
                                for (int j2 = j; j2 < j + 10; j2++)
                                {
                                    c = bmp.GetPixel(i2, j2);
                                    bmp2.SetPixel(i2, j2, Color.FromArgb(c.R,c.G,c.B));
                                }
                        }
                }
            pictureBox1.Image = bmp2;
        }


        //pintar segmentos con el segundo color
        private void button3_Click_1(object sender, EventArgs e)
        {
            int mRn = 0, mGn = 0, mBn = 0;
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            arr[3] = mR;
            arr[4] = mG;
            arr[5] = mB;
            for (int i = 0; i < bmp.Width - 10; i = i + 10)
                for (int j = 0; j < bmp.Height - 10; j = j + 10)
                {
                    for (int i2 = i; i2 < i + 10; i2++)
                        for (int j2 = j; j2 < j + 10; j2++)
                        {
                            c = bmp.GetPixel(i2, j2);
                            mRn = mRn + c.R;
                            mGn = mGn + c.G;
                            mBn = mBn + c.B;
                        }

                    mRn = mRn / 100;
                    mGn = mGn / 100;
                    mBn = mBn / 100;

                    if ((arr[3] - 10 <= mRn) && (mRn <= arr[3] + 10) &&
                        ((arr[4] - 10 <= mGn) && (mGn <= arr[4] + 10) &&
                        (arr[5] - 10 <= mBn) && (mBn <= arr[5] + 10)))
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                bmp2.SetPixel(i2, j2, Color.Bisque);
                            }
                    } else if ((arr[0] - 10 <= mRn) && (mRn <= arr[0] + 10) &&
                        ((arr[1] - 10 <= mGn) && (mGn <= arr[1] + 10) &&
                        (arr[2] - 10 <= mBn) && (mBn <= arr[2] + 10)))
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                bmp2.SetPixel(i2, j2, Color.Fuchsia);
                            }
                    }
                    else if ((arr[6] - 10 <= mRn) && (mRn <= arr[6] + 10) &&
                      ((arr[7] - 10 <= mGn) && (mGn <= arr[7] + 10) &&
                      (arr[8] - 10 <= mBn) && (mBn <= arr[8] + 10)))
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                bmp2.SetPixel(i2, j2, Color.DarkRed);
                            }
                    }
                    else
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                c = bmp.GetPixel(i2, j2);
                                bmp2.SetPixel(i2, j2, Color.FromArgb(c.R, c.G, c.B));
                            }
                    }
                }
            pictureBox1.Image = bmp2;
        }

        //pintar segmentos con el tercer color
        private void button4_Click_1(object sender, EventArgs e)
        {
            int mRn = 0, mGn = 0, mBn = 0;
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            arr[6] = mR;
            arr[7] = mG;
            arr[8] = mB;
            for (int i = 0; i < bmp.Width - 10; i = i + 10)
                for (int j = 0; j < bmp.Height - 10; j = j + 10)
                {
                    for (int i2 = i; i2 < i + 10; i2++)
                        for (int j2 = j; j2 < j + 10; j2++)
                        {
                            c = bmp.GetPixel(i2, j2);
                            mRn = mRn + c.R;
                            mGn = mGn + c.G;
                            mBn = mBn + c.B;
                        }

                    mRn = mRn / 100;
                    mGn = mGn / 100;
                    mBn = mBn / 100;

                    if ((arr[6] - 10 <= mRn) && (mRn <= arr[6] + 10) &&
                        ((arr[7] - 10 <= mGn) && (mGn <= arr[7] + 10) &&
                        (arr[8] - 10 <= mBn) && (mBn <= arr[8] + 10)))
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                bmp2.SetPixel(i2, j2, Color.DarkRed);
                            }
                    }
                    else if ((arr[0] - 10 <= mRn) && (mRn <= arr[0] + 10) &&
                      ((arr[1] - 10 <= mGn) && (mGn <= arr[1] + 10) &&
                      (arr[2] - 10 <= mBn) && (mBn <= arr[2] + 10)))
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                bmp2.SetPixel(i2, j2, Color.Fuchsia);
                            }
                    }
                    else if ((arr[3] - 10 <= mRn) && (mRn <= arr[3] + 10) &&
                      ((arr[4] - 10 <= mGn) && (mGn <= arr[4] + 10) &&
                      (arr[5] - 10 <= mBn) && (mBn <= arr[5] + 10)))
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                bmp2.SetPixel(i2, j2, Color.Bisque);
                            }
                    }
                    else
                    {
                        for (int i2 = i; i2 < i + 10; i2++)
                            for (int j2 = j; j2 < j + 10; j2++)
                            {
                                c = bmp.GetPixel(i2, j2);
                                bmp2.SetPixel(i2, j2, Color.FromArgb(c.R, c.G, c.B));
                            }
                    }
                }
            pictureBox1.Image = bmp2;
        }


    }
}
