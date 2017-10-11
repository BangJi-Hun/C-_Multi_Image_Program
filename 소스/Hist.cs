using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace MuiltiPro
{
   class Hist : IDisposable
    {
        IplImage DstHist;
        public IplImage BuildHist(IplImage src_tmp)
        {
            const int histSize = 64;
            float[] range0 = { 0, 256 };
            float[][] ranges = { range0 };
            // 화상의 읽기
            using (IplImage srcImg = new IplImage(src_tmp.Size, BitDepth.U8, 1))
            using (IplImage dstImg = new IplImage(src_tmp.Size, BitDepth.U8, 1)) 
            using (IplImage histImg = new IplImage(new CvSize(400, 400), BitDepth.U8, 1))
            using (CvHistogram hist = new CvHistogram(new int[] { histSize }, HistogramFormat.Array, ranges, true))
            {
                src_tmp.CvtColor(srcImg, ColorConversion.BgrToGray);
                srcImg.Copy(dstImg);
                using (CvWindow windowImage = new CvWindow("변환된 이미지", WindowMode.AutoSize))
                using (CvWindow windowHist = new CvWindow("히스토그램", WindowMode.AutoSize))
                {
                    // 트랙바가 동작되었을 때의 처리
                    CvTrackbar ctBrightness = null;
                    CvTrackbar ctContrast = null;
                    CvTrackbarCallback callback = delegate(int pos)
                    {
                        int brightness = ctBrightness.Pos - 100;
                        int contrast = ctContrast.Pos - 100;
                        // LUT의 적용
                        byte[] lut = CalcLut(contrast, brightness);
                        srcImg.LUT(dstImg, lut);
                        // 히스토그램 그리기
                        CalcHist(dstImg, hist);
                        DrawHist(histImg, hist, histSize);
                        // 윈도우에 표시
                        DstHist = histImg.Clone();
                        windowImage.ShowImage(dstImg);
                        windowHist.ShowImage(histImg);
                        dstImg.Zero();
                        histImg.Zero();
                    };
                    // 트랙바의 작성
                    ctBrightness = windowImage.CreateTrackbar("명도", 100, 200, callback);
                    ctContrast = windowImage.CreateTrackbar("대조", 100, 200, callback);
                    // 첫회 그리기
                    callback(0);
                    // 키 입력대기
                    Cv.WaitKey(0);
                }
                return DstHist;
            }
        }
        //contrast와 brightness의 값으로부터 LUT의 값을 계산해, byte 배열로 돌려준다
        private static byte[] CalcLut(int contrast, int brightness)
        {
            byte[] lut = new byte[256];
            if (contrast > 0)
            {
                double delta = 127.0 * contrast / 100;
                double a = 255.0 / (255.0 - delta * 2);
                double b = a * (brightness - delta);
                for (int i = 0; i < 256; i++)
                {
                    int v = Cv.Round(a * i + b);
                    if (v < 0)
                        v = 0;
                    if (v > 255)
                        v = 255;
                    lut[i] = (byte)v;
                }
            }
            else
            {
                double delta = -128.0 * contrast / 100;
                double a = (256.0 - delta * 2) / 255.0;
                double b = a * brightness + delta;
                for (int i = 0; i < 256; i++)
                {
                    int v = Cv.Round(a * i + b);
                    if (v < 0)
                        v = 0;
                    if (v > 255)
                        v = 255;
                    lut[i] = (byte)v;
                }
            }
            return lut;
        }
        //히스토그램 계산
        private static void CalcHist(IplImage img, CvHistogram hist)
        {
            hist.Calc(img);
            float minValue, maxValue;
            hist.GetMinMaxValue(out minValue, out maxValue);
            Cv.Scale(hist.Bins, hist.Bins, ((double)img.Height) / maxValue, 0);
        }
        //히스토그램 그리기
        private static void DrawHist(IplImage img, CvHistogram hist, int histSize)
        {
            img.Set(CvColor.White);
            int binW = Cv.Round((double)img.Width / histSize);
            for (int i = 0; i < histSize; i++)
            {
                img.Rectangle(
                    new CvPoint(i * binW, img.Height),
                    new CvPoint((i + 1) * binW, img.Height - Cv.Round(hist.Bins[i])),
                    CvColor.Black, -1, LineType.AntiAlias, 0
                );
            }
        }
        public void Dispose()
        {
            if (DstHist != null) Cv.ReleaseImage(DstHist);
        }
    }
}