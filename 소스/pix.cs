using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace MuiltiPro
{
    class pix : IDisposable
    {
        IplImage Px;
        IplImage Px2;        

        double pi = 3.141592;
        double seta;

        public IplImage NN(IplImage src_tmp, double n)
        {            
            using (IplImage img = src_tmp.Clone())
            {
                int new_x, new_y;

                //배경 검은색
                for (int i = 0; i < img.Height; i++)
                {
                    for (int j = 0; j < img.Width; j++)
                    {
                        img[i,j] = 0;	// 0: 검정색
                    }
                }

                for (int i = 0; i < src_tmp.Height; i++)
                {
                    new_y = Cv.Ceil(i * n);
                    if (new_y >= img.Height)
                    {
                        new_y = img.Height - 1;
                    }

                    for (int j = 0; j < src_tmp.Width; j++)
                    {
                        new_x = Cv.Ceil(j * n);
                        if (new_x >= img.Width)
                        {
                            new_x = img.Width - 1;
                        }

                        img[new_y,new_x] = src_tmp[i,j];
                    }
                }
                Px = img.Clone();
                return Px;
                
            }
        }

        public IplImage Degree(IplImage src_tmp, double degree)
        {
            int new_x, new_y;

            int center_x = src_tmp.Width / 2;
            int center_y = src_tmp.Height / 2;

            seta = pi / (180.0 / degree);

            int sin, cos;


            //배경 검은색
            using (IplImage img2 = src_tmp.Clone())
            {
                for (int i = 0; i < img2.Height; i++)
                {
                    for (int j = 0; j < img2.Width; j++)
                    {
                        img2[i, j] = 0;	// 0: 검정색
                    }
                }
                //회전
                for (int i = 0; i < src_tmp.Height; i++)
                {
                    for (int j = 0; j < src_tmp.Width; j++)
                    {
                        sin = (int)Math.Sin(seta);
                        cos = (int)Math.Cos(seta);
                        new_x = (i - center_y) * sin + (j - center_x) * cos + center_x;
                        new_y = (i - center_y) * cos - (j - center_x) * sin + center_y;

                        if (new_x < 0) { continue; }
                        if (new_x >= src_tmp.Width) { continue; }
                        if (new_y < 0) { continue; }
                        if (new_y >= src_tmp.Height) { continue; }

                        img2[new_y, new_x] = src_tmp[i, j];
                    }
                }
                Px2 = img2.Clone();
                return Px2;
            }

        }

        public IplImage Interpol(IplImage src_tmp)
        {
            double pre_pixval = 0;
            using (IplImage img = src_tmp.Clone())
            {
                // → 방향으로 진행
                for (int i = 0; i < src_tmp.Height; i++)
                {
                    for (int j = 0; j < src_tmp.Width; j++)
                    {
                        if (src_tmp[i, j] == 0 && pre_pixval != 0)
                        {
                            src_tmp[i, j] = pre_pixval;
                        }

                        pre_pixval = src_tmp[i, j];
                    }

                    pre_pixval = 0;
                }


                // ↓ 방향으로 진행
                for (int m = 0; m < src_tmp.Height; m++)
                {
                    for (int n = 0; n < src_tmp.Width; n++)
                    {
                        if (src_tmp[m, n] == 0 && pre_pixval != 0)
                        {
                            src_tmp[m, n] = pre_pixval;
                        }

                        pre_pixval = src_tmp[m, n];
                    }

                    pre_pixval = 0;
                }
                Px2 = img.Clone();
                return Px2;
            }
        }

        public void Dispose()
        {
            if (Px != null) Cv.ReleaseImage(Px);
        }
    }
}

