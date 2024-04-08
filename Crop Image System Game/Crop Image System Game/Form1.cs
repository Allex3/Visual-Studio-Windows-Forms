using System;

namespace Crop_Image_System_Game
{
    public partial class Form1 : Form
    {
        Image image = Image.FromFile("lies.jpg");
        PictureBox[] pbs = new PictureBox[4];
        Image[] imgs = new Image[4];
        int move = 0;
        Point p1 = new Point();
        Point p2 = new Point();
        PictureBox pb1 = new PictureBox();
        PictureBox pb2 = new PictureBox();
        Point[] p = new Point[4];
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox[] pbs = new PictureBox[4];
            for (int i = 0; i < 4; i++)
            {
                pbs[i] = new PictureBox();
            }
            Size size = new Size(image.Width / 2, image.Height / 2);
            //size is a quarter of the original image

            Rectangle crop;
            //part of the image that we crop from the image's bitmap
            //crop(point, width, height) is a rectangle that
            //starts at point(x, y) and goes right width and down height

            Bitmap bmp = new Bitmap(image);

            //cropping the upper left part
            crop = new Rectangle(new Point(0, 0), size);
            imgs[0] = (Image)bmp.Clone(crop, bmp.PixelFormat);
            //bmp.Clone is copying the crop part of the image in pixel format

            //upper right part
            crop = new Rectangle(new Point(image.Width / 2, 0), size);
            imgs[1] = (Image)bmp.Clone(crop, bmp.PixelFormat);

            //lower left part
            crop = new Rectangle(new Point(0, image.Height/2), size);
            imgs[2] = (Image)bmp.Clone(crop, bmp.PixelFormat);

            //lower right part
            crop = new Rectangle(new Point(image.Width / 2, image.Height/2), size);
            imgs[3] = (Image)bmp.Clone(crop, bmp.PixelFormat);

            //practic in groupBox1 se afla toate cele 4 parti ale imaginii pe care le mut
            //locatia fiecarei parti este in cele 4 colturi ale lor ca mai sus
            pbs[0].Location = new Point(0, 0);
            pbs[1].Location = new Point(groupBox1.Width / 2, 0);
            pbs[2].Location = new Point(0, groupBox1.Height / 2);
            pbs[3].Location = new Point(groupBox1.Width / 2, groupBox1.Height / 2);

            for (int i = 0; i < 4; i++)
            {
                //quarter of image
                pbs[i].Size = new Size(groupBox1.Width / 2, groupBox1.Height / 2);
                //image parts are from groupbox1
                pbs[i].Parent = groupBox1;
                pbs[i].Visible = true;
                //at the beginning in i'th quarter is i'th image part so its sorted
                pbs[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pbs[i].Image = imgs[i];
                //single line border between parts to separate them visually
                pbs[i].BorderStyle = BorderStyle.FixedSingle;
                //point location where each part starts
                p[i] = pbs[i].Location;
            }

            int[] parti = new int[4] { 0, 1, 2, 3 };

            //Shuffle the array of position of parts of the image
            rnd.Shuffle(parti);
            for (int i = 0; i < 4; i++)
            {
                pbs[i].Location = p[parti[i]]; //shuffled locations of the parts
            }

            for (int i=0; i < 4; i++)
            {
                //adaug la Click-ul pe partea imaginii evenimentul
                //cu obiectul ss si argumentul eventului ee
                pbs[i].Click += (ss, ee) =>
                {
                    //if I am not in a move between two images yet it means I am clicking the first one
                    //so move is 0, and it sets my image that is to be changed with another
                    if (move == 0)
                    {
                        //object ss is a pictureBox class here
                        pb1 = ss as PictureBox;
                        p1 = pb1.Location;
                        move = 1;
                    }
                    //move is 1, so i am in a move already
                    //switch the two images location's (basically the two images in themselves)
                    //and check if the image is done
                    else if (move == 1)
                    {
                        pb2 = ss as PictureBox;
                        p2 = pb2.Location;
                        pb1.Location = p2;
                        pb2.Location = p1;
                        move = 0;
                        if (location(pbs) == true)
                            MessageBox.Show("In sfarsit sunt ordonate");
                    }
                };
            }


        }

        private bool location(PictureBox[] pb)
        {
            bool verify = false;

            Point p0 = new Point(0, 0);
            Point p1 = new Point(groupBox1.Width / 2, 0);
            Point p2 = new Point(0, groupBox1.Height / 2);
            Point p3 = new Point(groupBox1.Width / 2, groupBox1.Height / 2);

            if ((pb[0].Location) == p0 && (pb[1].Location) == p1 && (pb[2].Location) == p2 && (pb[3].Location) == p3) 
                    verify = true;

            return verify; //true if original image
        }
    }
}
