using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace MuiltiPro
{
   class gray : IDisposable
    {
        IplImage subgray;

        public IplImage grayProcess(IplImage src_tmp)
        {
            subgray = new IplImage(src_tmp.Size, BitDepth.U8, 1);
            Cv.CvtColor(src_tmp, subgray, ColorConversion.BgrToGray);
            return subgray;
        }

        public IplImage ThresholdProcess(IplImage src_tmp, int data)
        {

            subgray = new IplImage(src_tmp.Size, BitDepth.U8, 1);  //메모리 확보
            Cv.CvtColor(src_tmp, subgray, ColorConversion.BgrToGray); //그레이로 변환
            Cv.Smooth(subgray, subgray, SmoothType.Gaussian, 5);  //가우시안 스무스 주기
            Cv.Threshold(subgray, subgray, data, 255, ThresholdType.Binary);  //data는 기준이 될 임계치
            return subgray;
        }

        public IplImage BuildSobel(IplImage src_tmp)
        {
            subgray = new IplImage(src_tmp.Size, BitDepth.U8, 1);//메모리 확보
            Cv.CvtColor(src_tmp, subgray, ColorConversion.BgrToGray); //그레이로 변환
            Cv.Sobel(subgray, subgray, 1, 0, ApertureSize.Size3);
            return subgray;
        }
        public IplImage BuildLaplace(IplImage src_tmp)
        {
            subgray = new IplImage(src_tmp.Size, BitDepth.U8, 1);//메모리 확보
            using (IplImage temp = new IplImage(src_tmp.Size, BitDepth.S16, 1))
            using (IplImage graytemp = new IplImage(src_tmp.Size, BitDepth.U8, 1))
            {
                Cv.CvtColor(src_tmp, graytemp, ColorConversion.BgrToGray); //그레이로 변환
                Cv.Laplace(graytemp, temp);
                Cv.ConvertScaleAbs(temp, subgray);
                return subgray;
            }
        }
 
        public void Dispose()
        {
            if (subgray != null) Cv.ReleaseImage(subgray);
        }
        
    }
}
