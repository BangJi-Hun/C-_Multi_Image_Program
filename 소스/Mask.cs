using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace MuiltiPro
{
    class Mask : IDisposable
    {
        IplImage maskimg;

        public IplImage SunMyung(IplImage src_tmp)
        {
            double[,] _b = new double[,]{ {0, -1, 0},
                                          {-1, 5, -1},
                                          {0, -1, 0} };
            using (CvMat b = CvMat.FromArray(_b))
            using (IplImage temp = new IplImage(src_tmp.Size, BitDepth.U8, 1))
            using (IplImage s1 = new IplImage(src_tmp.Size, BitDepth.U8, 1)) // 추가
            {
                Cv.CvtColor(src_tmp, s1, ColorConversion.BgrToGray); // src를 그레이로 s1에 저장
                Cv.Filter2D(s1, temp, b, new CvPoint(-1, -1));
                maskimg = temp.Clone();
            }
            return maskimg;
        }
 
        public void Dispose()
        {
            if (maskimg != null) Cv.ReleaseImage(maskimg);
        }
    }
}

