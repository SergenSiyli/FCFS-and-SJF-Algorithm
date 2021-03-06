﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operatin_System
{
    public partial class Form1 : Form
    {
        struct proc {
            public int turn_around_time;
            public int waiting_time;
            public int arrival_time;
            public int burst_time;
            public string proc_name;
            public int response_time;
        };

        proc[] pross;
        int sum_bu;

        Graphics graphicsObj;
        Pen myPen = new Pen(System.Drawing.Color.Black, 3);
        Bitmap bmp = new Bitmap(200, 200);

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*There is no*/
        bool same_arrival_time_control(proc[] ps,int rnd_value)
        {
            for (int i = 0; i < ps.Length; i++)
            {
                if (ps[i].arrival_time == rnd_value)
                    return false;
            }
           

            return true;
        }


        /*there is no*/
        int sum_burst(proc [] ps)
        {
            int sum = 0;
            for (int i = 0; i < ps.Length; i++)
            {
                sum += ps[i].burst_time;
            }

            return sum;
        }
        int now = 0;
        int last_x=0, last_y=0,up=0,down=50;
        

        void draw_function(int now,int burst, string proc_name, int last)
        {
            //(10,97)
          

            int k = (pictureBox1.Width) / sum_bu;

            graphicsObj = Graphics.FromImage(bmp);

            if (last_x > pictureBox1.Width-30)
            {

                up=down+50;
                down += 70;
                last_x = 0;
            }
              
      
                graphicsObj.DrawLine(myPen, last_x,up,  last_x, down);//this for first | 
                graphicsObj.DrawLine(myPen, last_x, up,last_x+5*burst+30, up);//this for up horizontal
                graphicsObj.DrawLine(myPen, last_x, down, last_x + 5 * burst + 30, down);//this for down horizontal
                graphicsObj.DrawLine(myPen, last_x + 5 * burst + 30, up, last_x + 5 * burst + 30, down);//this for last |



            int x_middle = (2 * last_x + 5 * burst + 30) / 2;
            int y_middle = ((down+up) / 2);

           

            graphicsObj.DrawString(" P"+proc_name+" ", new Font(FontFamily.GenericSansSerif,7.2F , FontStyle.Regular), Brushes.Black, last_x+5, y_middle-10);// the middle of proc_box  
            graphicsObj.DrawString(now.ToString(), new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular), Brushes.Black,last_x, down + 5);

            last_x += 5 * burst + 30;

            if (last == 0)
            {


                graphicsObj.DrawString((now + burst).ToString(), new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular), Brushes.Black, (last_x), down + 5);
            }


        }

        int max_arrival(proc[] p)
        {
            int max = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].arrival_time > max)
                    max = p[i].arrival_time;
            }

            return max;
        }


        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public Bitmap CropImage(Bitmap source, Rectangle section)
        {
            // An empty bitmap which will hold the cropped image
            Bitmap bmp = new Bitmap(section.Width, section.Height);

            Graphics g = Graphics.FromImage(bmp);

            // Draw the given area (section) of the source image
            // at location 0,0 on the empty bitmap (bmp)
            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);

            return bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, 10000);
            Random rnd = new Random();
            int rand_count = Convert.ToInt32(txtProsCount.Text);
            last_x = 0; last_y = 0; up = 0; down =20;

            pross = new proc[rand_count];
            lblRespond.Visible = false;
            label3.Visible = false;
            lblArt.Visible = false;
            lstRespond.Visible = false;



            lblRespond.Text = "";

            for (int i =0; i < rand_count; i++)
            {
                int rnd_arrival_time = rnd.Next(rand_count+10);

                while (!same_arrival_time_control(pross, rnd_arrival_time)) {
                    rnd_arrival_time = rnd.Next(rand_count+10);
                }

                pross[i].arrival_time = rnd_arrival_time;
                pross[i].proc_name = i.ToString();
               

                
            }

            int max = max_arrival(pross);

            for (int i = 0; i < rand_count; i++)
            {

                int rnd_burst_time = rnd.Next(4, 20);
                pross[i].burst_time = rnd_burst_time;
            }



            for (int i = 0; i < pross.Length; i++)
            {
                for (int j = i+1; j < pross.Length; j++)
                {
                    if (pross[i].arrival_time > pross[j].arrival_time)
                    {
                        proc temp = pross[i];
                        pross[i] = pross[j];
                        pross[j] = temp;
                    }

                }
            }


            pross[0].arrival_time = 0;
            pross[0].burst_time = max + 1;
            sum_bu = sum_burst(pross);

            int now = 0;

            int queue = pross.Length;
            int k= 0;

            while (queue != 0) {
              
                pross[k].waiting_time = now - pross[k].arrival_time;
                int last = 1;
                if (queue == 1)
                    last = 0;
                draw_function(now,pross[k].burst_time, pross[k].proc_name,last);
                now += pross[k].burst_time;
                pross[k].turn_around_time = now - pross[k].arrival_time;
                queue--;
                k++;

            }

            pictureBox1.Image = null;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            //Bitmap bmp_new = new Bitmap(pictureBox1.Width, down + 100);
            //bmp_new = bmp;
            //bmp = ResizeImage(bmp,pictureBox1.Width,down+100);
            bmp = CropImage(bmp, new Rectangle(0, 0, pictureBox1.Width, down + 200));
            pictureBox1.Image = bmp;
            

            /*for Timearound,Waiting,Respond time*/

            int ATT = 0;
            int AWT = 0;
            lblturnaround.Text = "";
            lblwaiting.Text = "";
            lblArrival.Text = "";
            lblBurst.Text = "";
            lstArrival.Items.Clear();
            lstTurnAround.Items.Clear();
            lstWaiting.Items.Clear();
            lstBurst.Items.Clear();

            for (int i = 0; i < pross.Length; i++)
            {

                for (int j = 0; j < pross.Length; j++)
                {
                    if (pross[j].proc_name == i.ToString())
                    {
                        lstTurnAround.Items.Add("T" + pross[j].proc_name + "=" + pross[j].turn_around_time.ToString());
                        ATT += pross[j].turn_around_time;
                        lstWaiting.Items.Add("W" + pross[j].proc_name + "=" + pross[j].waiting_time.ToString());
                        AWT += pross[j].waiting_time;
                        lstArrival.Items.Add("P" + pross[j].proc_name + "=" + pross[j].arrival_time.ToString());
                        lstBurst.Items.Add("P" + pross[j].proc_name + "=" + pross[j].burst_time.ToString());
                    }
                }
               

            }
            lblAtt.Text = "ATT :";
            lblAwt.Text = "AWT :";
            lblAtt.Text += " " + (ATT / pross.Length).ToString();
            lblAwt.Text += " " + (AWT / pross.Length).ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        bool situation_queue(int now,int j)
        {
            for (int i = j; i < pross.Length; i++)
            {
                if (now > pross[i].arrival_time)
                    return true;
            }
            return false;
        }

        int turn_to_be_processed(int k)
        {
            
            int min = pross[0].burst_time;
            int indis = 0;
            for (int i = 0; i <= k; i++)
            {
                
                if(min>pross[i].burst_time && pross[i].burst_time>0)
                {
                    indis = i;
                    min = pross[i].burst_time;

                }
            }


            return indis;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, 10000);
            Random rnd = new Random();
            int rand_count = Convert.ToInt32(txtProsCount.Text);
            last_x = 0; last_y = 0; up = 0; down = 20;
            pross = new proc[rand_count];

            lblRespond.Visible = true;
            label3.Visible = true;
            lstRespond.Visible = true;
            lblArt.Visible = true;



           

            for (int i = 0; i < rand_count; i++)
            {
                int rnd_arrival_time = rnd.Next(rand_count+10);

                while (!same_arrival_time_control(pross, rnd_arrival_time))
                {
                    rnd_arrival_time = rnd.Next(rand_count+10);
                }

                pross[i].arrival_time = rnd_arrival_time;

              

                pross[i].proc_name = i.ToString();

                pross[i].response_time = -1;

            }

            //int max = max_arrival(pross);

            for (int i = 0; i < rand_count; i++)
            {

                int rnd_burst_time = rnd.Next(rand_count+10,rand_count+15);
                pross[i].burst_time = rnd_burst_time;
            }


            for (int i = 0; i < pross.Length; i++)
            {
                for (int j = i + 1; j < pross.Length; j++)
                {
                    if (pross[i].arrival_time > pross[j].arrival_time)
                    {
                        proc temp = pross[i];
                        pross[i] = pross[j];
                        pross[j] = temp;
                    }

                }
            }


            

            pross[0].arrival_time = 0;

            pross[0].burst_time = rnd.Next(rand_count + 20, rand_count + 40);
            pross[1].burst_time = rnd.Next(rand_count + 20, rand_count + 40);

            sum_bu = sum_burst(pross);
            

           

            lstArrival.Items.Clear();
            lstBurst.Items.Clear();
            


            for (int i = 0; i < pross.Length; i++)
            {
                for (int j = 0; j < pross.Length; j++)
                {
                    if (pross[j].proc_name == i.ToString()) {
                        lstArrival.Items.Add("P" + pross[j].proc_name + "=" + pross[j].arrival_time.ToString());
                        lstBurst.Items.Add("P" + pross[j].proc_name + "=" + pross[j].burst_time.ToString());
                    }
                }
               
            }

            int now = 0;

            int processed = pross.Length;


            
            for (int i = 0; i < processed-1; i++) {


                int j = turn_to_be_processed(i);
                int burst = 0;

               burst = pross[i +1].arrival_time - pross[i].arrival_time;
               pross[j].waiting_time += now - pross[j].arrival_time;
               

                if (pross[j].response_time==-1)
                    pross[j].response_time = now - pross[j].arrival_time;
              

                draw_function(now, burst, pross[j].proc_name, 1);

                pross[j].burst_time -= burst;
                if (pross[j].burst_time <= 0)
                    processed--;

                now = now + burst;
                pross[j].turn_around_time += now-pross[j].arrival_time;
                pross[j].arrival_time = now;
                

            }

            for (int i = 0; i < pross.Length; i++)
            {
                for (int j = i + 1; j < pross.Length; j++)
                {
                    if ((pross[i].burst_time > pross[j].burst_time))
                    {
                        proc temp = pross[i];
                        pross[i] = pross[j];
                        pross[j] = temp;
                    }

                }
            }

            int k = 0;

            while (processed != 0)
            {

                //pross[k].waiting_time = now - pross[k].arrival_time;
                int last = 1;
                if (processed == 1)
                    last = 0;


                if (pross[k].burst_time != 0)
                {
                    pross[k].waiting_time += now - pross[k].arrival_time;

                    if (pross[k].response_time == -1)
                        pross[k].response_time = now - pross[k].arrival_time;


                    draw_function(now, pross[k].burst_time, pross[k].proc_name, last);
                    now += pross[k].burst_time;
                    pross[k].turn_around_time += now - pross[k].arrival_time;
                    ///pross[k].turn_around_time = now - pross[k].arrival_time;

                    processed--;
                   
                }
                k++;

            }
            //label3.Text = "";
            //lbl_arrival.Text = "";
            //for (int i = 0; i < pross.Length; i++)
            //{
            //    label3.Text += "\n" + pross[i].proc_name + "Waiting time=" + pross[i].waiting_time;
            //    lbl_arrival.Text += "\n" + pross[i].proc_name + "Response time=" + pross[i].response_time;

            //}
            double ATT = 0;
            double AWT = 0;
            double ART = 0;

            lstTurnAround.Items.Clear();
            lstWaiting.Items.Clear();
            lstRespond.Items.Clear();

            for (int i = 0; i < pross.Length; i++)
            {
                for (int j = 0; j < pross.Length; j++)
                {
                    if(pross[j].proc_name==i.ToString())
                    {
                        lstTurnAround.Items.Add("T" + pross[j].proc_name + "=" + pross[j].turn_around_time.ToString());
                        ATT += pross[j].turn_around_time;
                        lstWaiting.Items.Add("W" + pross[j].proc_name + "=" + pross[j].waiting_time.ToString());
                        AWT += pross[j].waiting_time;
                        lstRespond.Items.Add("R" + pross[j].proc_name + "=" + pross[j].response_time.ToString());
                        ART += pross[j].response_time;

                    }
            
                }
               

            }

            lblAtt.Text = "ATT : ";
            lblAwt.Text = "AWT : ";
            lblArt.Text = "ART : ";

            lblAtt.Text += (ATT / pross.Length).ToString();
            lblAwt.Text += (AWT / pross.Length).ToString();
            lblArt.Text += (ART / pross.Length).ToString();


            pictureBox1.Image = null;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
         
            bmp = CropImage(bmp, new Rectangle(0, 0, pictureBox1.Width, down + 200));
            pictureBox1.Image = bmp;

        }
    }
}
