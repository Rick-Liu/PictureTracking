using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;

namespace PictureTracking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        VideoCapture cap = new VideoCapture();
        TemplateGrab templateGrab;
        Mat _SrcImage;
        Mat _ShowImage;
        Mat _matctMat;
        Mat _templateMat;
        object key = new object();

        bool IsRuncap;
        //RectangaleObject _Rect = new RectangaleObject();
        private void OpenButton_Click(object sender, EventArgs e)
        {
            if(!IsRuncap)
            {
                IsRuncap = true;
                cap.FlipHorizontal = true;
                //cap.ImageGrabbed += ShowImage;
                _SrcImage = new Mat();
                _ShowImage = new Mat();
                //cap.Start();
                cap.Grab();

                Thread T1 = new Thread(ShowImage);
                T1.Start();
            }
            
        }

        private void ShowImage()
        {
            while(IsRuncap)
            {
                //cap.Retrieve(_SrcImage);
                _SrcImage = cap.QueryFrame();
                _SrcImage.CopyTo(_ShowImage);
                //lock (key)
                //{
                if (ShowTemplatPictureBox.Image != null)
                {
                    _ShowImage = MatchImage(_ShowImage, _templateMat);
                    //_SrcImage = _matctMat;
                }

                CvInvoke.Resize(_ShowImage, _ShowImage, pictureBox1.Size);
                Bitmap oldBitmap = pictureBox1.Image as Bitmap;
                pictureBox1.Image = _ShowImage.ToBitmap();
                if (oldBitmap != null)
                {
                    oldBitmap.Dispose();
                }
                Thread.Sleep(20);
                //}
            }

        }
        private Mat MatchImage(Mat mat,Mat template)
        {
            Rectangle maxLocDraw = new Rectangle();
            double minVal = 0;
            double maxVal = 0;
            Point minLoc = new Point(0, 0);
            Point maxLoc = new Point(0, 0);
            
            CvInvoke.MatchTemplate(mat, template, _matctMat, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);
            CvInvoke.MinMaxLoc(_matctMat, ref minVal, ref maxVal, ref minLoc, ref maxLoc);
            CvInvoke.Normalize(_matctMat, _matctMat, 255, 0,Emgu.CV.CvEnum.NormType.MinMax,Emgu.CV.CvEnum.DepthType.Cv8U);
            /*
            pictureBox2.Image = _matctMat.ToBitmap();
            */
            if (Math.Round(maxVal, 2)>=0.7)
            {
                maxLocDraw.Location = maxLoc;
                maxLocDraw.Width = template.Width;
                maxLocDraw.Height = template.Height;
                //_templateMat= new Mat(mat, maxLocDraw);
                CvInvoke.Rectangle(mat, maxLocDraw, new Emgu.CV.Structure.MCvScalar(0, 0, 255));
                CvInvoke.PutText(mat, Math.Round(maxVal, 2).ToString(), maxLoc, Emgu.CV.CvEnum.FontFace.HersheyDuplex, 1, new Emgu.CV.Structure.MCvScalar(0, 0, 255),2);
                GC.Collect();
                return mat.Clone();
                
            }
            GC.Collect();
            return mat.Clone();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cap.Stop();
            IsRuncap = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _matctMat = new Mat();
        }
        bool xxx=true;
        private void TemplateButton_Click(object sender, EventArgs e)
        {

            templateGrab = new TemplateGrab();
            //templateGrab.DisplayImage(_SrcImage);
            if (xxx)
            {
                cap.ImageGrabbed += CaptureImage;
                
                templateGrab.ShowDialog();
                if (templateGrab.CanShowTemplate)
                {
                    _templateMat = templateGrab.GetImage();
                    ShowTemplatPictureBox.Image = _templateMat.ToBitmap();
                    //TemplateButton.BackColor = Color.GreenYellow;

                }
            }

            
            //Mat vv=templateGrab._rectImage.Clone();
            
            
            


        }
        private void CaptureImage(object sender, EventArgs e)
        {
            xxx = false;
            //cap.Pause();
            templateGrab.DisplayImage(_SrcImage);
            cap.ImageGrabbed -= CaptureImage;
            //cap.Start();
            xxx = true;
        }
    }
}
