using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureTracking
{
    class RectangaleObject
    {
        Mat _rectMat;
        Mat _reSizeMat;
        Mat _outMat;
        Mat _OriginalImage;
        Rectangle _Rect;
        Rectangle _zoomRect;
        RectangleF _roi=new Rectangle();
        Size _pictureBoxSize;
        Point _RectPoint= new Point(0,0);
        bool canMoveRect;
        bool canZoomRect;
        public RectangaleObject(Size pictureBoxSize)
        {
            _pictureBoxSize = pictureBoxSize;
            _Rect = new Rectangle(pictureBoxSize.Width / 3, pictureBoxSize.Height / 3, pictureBoxSize.Width / 3, pictureBoxSize.Width / 3);
            _zoomRect = new Rectangle(_Rect.Right - 10, _Rect.Bottom - 10, 20, 20);
            _rectMat = new Mat(_pictureBoxSize, Emgu.CV.CvEnum.DepthType.Cv8U, 3);
            _outMat = new Mat();
            _reSizeMat = new Mat();
        }
        public Mat DrawRectagale(Mat mat)
        {
            _OriginalImage = mat;
            CvInvoke.Resize(mat, _reSizeMat, _pictureBoxSize);
            _rectMat.SetTo(new Emgu.CV.Structure.MCvScalar(0, 0, 0));
            CvInvoke.Rectangle(_rectMat, _Rect, new Emgu.CV.Structure.MCvScalar(255, 255, 0), 1);
            CvInvoke.Add(_reSizeMat, _rectMat, _outMat);
            //CvInvoke.Rectangle(mat, _Rect, new Emgu.CV.Structure.MCvScalar(255, 0, 0), 1);
            return _outMat;
        }
        public Mat GetRectImage()
        { 
            float Xmultiple = (float)_OriginalImage.Width / (float)_pictureBoxSize.Width;
            float Ymultiple = (float)_OriginalImage.Height / (float)_pictureBoxSize.Height;
            _roi.X = _Rect.X * Xmultiple;
            _roi.Y = _Rect.Y * Ymultiple;
            _roi.Width=_Rect.Width * Xmultiple;
            _roi.Height = _Rect.Height * Ymultiple;
            return new Mat(_OriginalImage, Rectangle.Round(_roi));
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            if(_zoomRect.Contains(e.Location) )
            {
                Cursor.Current = Cursors.SizeNWSE;
            }
            else if(_Rect.Contains(e.Location) )
            {
                Cursor.Current = Cursors.SizeAll;
            }
            if(canMoveRect)
            {
                
                _Rect.X += e.X-_RectPoint.X ;
                _Rect.Y += e.Y-_RectPoint.Y ;
                _zoomRect.X += e.X - _RectPoint.X;
                _zoomRect.Y += e.Y - _RectPoint.Y;
                _RectPoint.X = e.X;
                _RectPoint.Y = e.Y;    
            }
            else if(canZoomRect)
            {
                _Rect.Width += e.X - _RectPoint.X;
                _Rect.Height += e.Y - _RectPoint.Y;
                _zoomRect.X += e.X - _RectPoint.X;
                _zoomRect.Y += e.Y - _RectPoint.Y;
                _RectPoint.X = e.X;
                _RectPoint.Y = e.Y;
            }
        }
        public void MouseUp(object sender, MouseEventArgs e)
        {
            canMoveRect = false;
            canZoomRect = false;
        }
        public void MouseDown(object sender, MouseEventArgs e)
        {
            _RectPoint = e.Location;
            if (_Rect.Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                canMoveRect = true;
            }
            if(_zoomRect.Contains(e.Location)&&e.Button==MouseButtons.Left)
            {
                canMoveRect = false;
                canZoomRect = true;

            }
        }
    }
}
