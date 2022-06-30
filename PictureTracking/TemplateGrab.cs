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
    public partial class TemplateGrab : Form
    {
        public TemplateGrab()
        {
            InitializeComponent();
            rectangaleObject = new RectangaleObject(TemplatePictureBox.Size);
            TemplatePictureBox.MouseMove += rectangaleObject.MouseMove;
            TemplatePictureBox.MouseDown += rectangaleObject.MouseDown;
            TemplatePictureBox.MouseUp += rectangaleObject.MouseUp;
        }
        public bool CanShowTemplate;
        bool canIRun = true;
        Mat _ScrMat;
        Mat _rectMat;
        Mat _rectImage;
        RectangaleObject rectangaleObject;

        private void GrabButton_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Sure to Grab Image?", "Grabe", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
           {
                _rectImage=rectangaleObject.GetRectImage();
                CanShowTemplate = true;
                canIRun = false;
                Close();
           }

        }
        public void DisplayImage(Mat mat)
        {
            _ScrMat = mat.Clone();
            _rectMat = new Mat();
            
            //CvInvoke.Resize(_ScrMat, _reSizeMat, TemplatePictureBox.Size);
            Thread T1 = new Thread(ShowImage);
            T1.Start();
        }
        public Mat GetImage()
        {
            
            return _rectImage.Clone();
        }
        private void ShowImage()
        {
            while (canIRun)
            {
                _rectMat = rectangaleObject.DrawRectagale(_ScrMat);
                TemplatePictureBox.Image = _rectMat.ToBitmap();
                Thread.Sleep(50);
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            canIRun = false;
            Close();
        }

        private void TemplateGrab_Load(object sender, EventArgs e)
        {
           
        }
    }
}
