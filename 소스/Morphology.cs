using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace MuiltiPro
{
    class Morphology : IDisposable
    {
        IplImage morph;

        public IplImage OpenMorphology(IplImage src_tmp)
        {
            // 구조 요소를 지정하고, 오픈 모폴로지 연산을 행한다
            //(1) 화상 읽어들여, 연산 결과 화상 영역의 확보를 행한다
            using (IplImage srcImg = src_tmp.Clone())
            using (IplImage dstImg = srcImg.Clone())
            using (IplImage tmpImg = srcImg.Clone())
            {
                //(2) 구조 요소를 생성한다 
                IplConvKernel element = Cv.CreateStructuringElementEx(9, 9, 4, 4, ElementShape.Rect, null);
                //(3) 모폴로지 연산을 실행한다 
                Cv.MorphologyEx(srcImg, dstImg, tmpImg, element, MorphologyOperation.Open, 1);
                morph = dstImg.Clone();
            }
            return morph;
        }
        public IplImage CloseMorphology(IplImage src_tmp)
        {
            // 구조 요소를 지정하고, 닫힘 모폴로지 연산을 행한다
            //(1) 화상 읽어들여, 연산 결과 화상 영역의 확보를 행한다
            using (IplImage srcImg = src_tmp.Clone())
            using (IplImage dstImg = srcImg.Clone())
            using (IplImage tmpImg = srcImg.Clone())
            {
                //(2) 구조 요소를 생성한다 
                IplConvKernel element = Cv.CreateStructuringElementEx(9, 9, 4, 4, ElementShape.Rect, null);
                //(3) 모폴로지 연산을 실행한다 
                Cv.MorphologyEx(srcImg, dstImg, tmpImg, element, MorphologyOperation.Close, 1);
                morph = dstImg.Clone();
            }
            return morph;
        }

        public void Dispose()
        {
            if (morph != null) Cv.ReleaseImage(morph);
        }
    }
}