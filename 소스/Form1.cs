using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.CPlusPlus;
using OpenCvSharp.Extensions;

namespace MuiltiPro
{
    public partial class Form1 : Form
    {
        string image_path = null;
        IplImage src, result, src_tmp;

        bool flipFlag = false;
        bool basicFlag = false;

        public Form1()
        {            
            InitializeComponent();
        }

        //프로그램 종료
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //파일 입출력
        //사진 src 초기화
        private void LoadImage(String fileName)
        {
            src = new IplImage(fileName, LoadMode.AnyColor);

            src_tmp = src;
            result = src;
            pictureBoxIpl1.ImageIpl = src;
        }

        //사진 불러오기
        private void 읽기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image_path = openFileDialog1.FileName;
                LoadImage(image_path);
            }
        }

        //사진 저장
        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fullPathName = openFileDialog1.FileName;
            string fileName = openFileDialog1.SafeFileName;
            string pathName = fullPathName.Substring(0, (fullPathName.Length - fileName.Length));

            src.Dispose();


            if (System.IO.File.Exists(fullPathName))       // 디렉토리가 존재하지 않으면 생성한다.   
                System.IO.File.Delete(fullPathName);

            pictureBoxIpl1.Image.Save(fullPathName, System.Drawing.Imaging.ImageFormat.Jpeg);

        }

        //사진 다른 이름으로 저장
        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "다른 이름으로 저장";
            dlg.DefaultExt = "jpg";
            dlg.Filter = "JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif";
            dlg.FilterIndex = 0;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBoxIpl1.Image.Save(dlg.FileName);
            }
        }

        //편집 적용취소    
        private void 적용취소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (basicFlag == true)
            {
                if (flipFlag == true)
                {
                    src_tmp.Flip(result, FlipMode.Y);
                }
                else
                {
                    src_tmp.Flip(result, FlipMode.X);
                }
            }
            pictureBoxIpl1.ImageIpl = src_tmp;
            result = src_tmp;
        }



        //영상 변환
        //사진 RGB -> GRAY
        private void rGB2GRAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            using (gray gg = new gray())
            using (IplImage temp = gg.grayProcess(src))
            {
                result = temp.Clone();
                
            }
            pictureBoxIpl1.ImageIpl = result;

        }

        private void 좌우반전ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            flipFlag = true;
            basicFlag = true;

            src_tmp.Flip(result, FlipMode.Y);

            pictureBoxIpl1.ImageIpl = result;
        }

        private void 상하반전ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            flipFlag = false;
            basicFlag = true;

            src_tmp.Flip(result, FlipMode.X);

            pictureBoxIpl1.ImageIpl = result;
        }

        private void 비트플레인출력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            int cols, rows;
            cols = src_tmp.Width;
            rows = src_tmp.Height;
            IplImage bit_mask = new IplImage(src_tmp.Size, BitDepth.U8, 1);

            for (int i = 0; i < 8; ++i)
            {
                src_tmp = src_tmp / 2;
                src_tmp += 1;
            }
            pictureBoxIpl1.ImageIpl = result;
        }
        
        //히스토그램
        private void 히스토그램스트레칭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            using (Hist Hi = new  Hist())
            using (IplImage temp = Hi.BuildHist(src))
            {
                result = temp.Clone();
            }
        }
        private void 히스토그램평준화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            using (gray gg = new gray())
            using (IplImage temp = gg.grayProcess(src))
            {
                result = temp.Clone();
            }
            src_tmp = result;

            Cv.EqualizeHist(src_tmp, result);

            pictureBoxIpl1.ImageIpl = result;            
        }

        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;
            Cv.Not(src_tmp, result);
            pictureBoxIpl1.ImageIpl = result;
        }

        private void 임계치필터링ThresholdingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            int anInteger;
            anInteger = Convert.ToInt32(textBox1.Text);

            using (gray gg = new gray())
            using (IplImage temp = gg.ThresholdProcess(src, anInteger))
            {
                result = temp.Clone();
            }

            pictureBoxIpl1.ImageIpl = result;
        }

        //공간 기반 처리
        private void 블러링3x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            Cv.Smooth(src_tmp, result, SmoothType.Blur, 3, 3);
            pictureBoxIpl1.ImageIpl = result;
        }

        private void 블러링5x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            Cv.Smooth(src_tmp, result, SmoothType.Blur, 5, 5);
            pictureBoxIpl1.ImageIpl = result;
        }

        private void 샤프닝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            using (Mask Mk = new Mask())
            using (IplImage temp = Mk.SunMyung(src_tmp))
            {
                result = temp.Clone();
            }
            pictureBoxIpl1.ImageIpl = result;
        }

        private void 평균값필터링ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            Cv.Smooth(src_tmp, result, SmoothType.Blur, 4, 4);
            pictureBoxIpl1.ImageIpl = result;
        }

        private void 중간값필터링ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            Cv.Smooth(src_tmp, result, SmoothType.Median, 3, 3);
            pictureBoxIpl1.ImageIpl = result;

        }

        private void 가우시안필터링ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            Cv.Smooth(src_tmp, result, SmoothType.Gaussian, 3, 3, 1);
            pictureBoxIpl1.ImageIpl = result;
        }

        //에지 추출
        private void 소벨마스킹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            using (gray gg = new gray())
            using (IplImage temp = gg.BuildSobel(src))
            {
                result = temp.Clone();
            }
            pictureBoxIpl1.ImageIpl = result;
        }

        private void 라플라시안마스킹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            using (gray gg = new gray())
            using (IplImage temp = gg.BuildLaplace(src))
            {
                result = temp.Clone();
            }
            pictureBoxIpl1.ImageIpl = result;
        }

        //모폴로지 연산
        private void 열림ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            using (Morphology Mp = new Morphology())
            using (IplImage temp = Mp.OpenMorphology(src_tmp))
            {
                result = temp.Clone();
            }
            pictureBoxIpl1.ImageIpl = result;
        }

        private void 닫힘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            using (Morphology Mp = new Morphology())
            using (IplImage temp = Mp.CloseMorphology(src_tmp))
            {
                result = temp.Clone();
            }
            pictureBoxIpl1.ImageIpl = result;
        }

        //기하학적 처리
        private void 확대NNToolStripMenuItem_Click(object sender, EventArgs e)
        {

            src_tmp = result;

            double n;
            n = Convert.ToDouble(textBox2.Text);

            if (src == null) return;
            using (pix Px = new  pix())
            using (IplImage temp = Px.NN(src_tmp, n))
            {
                result = temp.Clone();
            }
            pictureBoxIpl1.ImageIpl = result;            

        }

        private void 축소NNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            double n;
            n = Convert.ToDouble(textBox2.Text);

            if (src_tmp == null) return;
            using (pix Px = new pix())
            using (IplImage temp = Px.NN(src_tmp, n))
            {
                result = temp.Clone();
            }
            pictureBoxIpl1.ImageIpl = result;
        }

        private void 회전ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;

            double degree;
            degree = Convert.ToDouble(textBox3.Text);


            if (src_tmp == null) return;
            using (pix Px2 = new pix())
            using (IplImage temp = Px2.Degree(src_tmp, degree))
            {
                result = temp.Clone();
            }
            pictureBoxIpl1.ImageIpl = result;

        }

        private void 확대선형보간ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;
            double n;
            n = Convert.ToDouble(textBox2.Text);

            if (src_tmp == null) return;
            using (pix Px1 = new pix())
            using (IplImage temp = Px1.NN(src_tmp, n))
            {
                result = temp.Clone();
            }
            using (pix Px2 = new pix())
            using (IplImage temp = Px2.Interpol(result))
            {
                result = temp.Clone();
            }
            pictureBoxIpl1.ImageIpl = result;
        }

        private void 축소선형보간ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            src_tmp = result;
            double n;
            n = Convert.ToDouble(textBox2.Text);

            if (src_tmp == null) return;
            using (pix Px1 = new pix())
            using (IplImage temp = Px1.NN(src_tmp, n))
            {
                result = temp.Clone();
            }
            using (pix Px2 = new pix())
            using (IplImage temp = Px2.Interpol(result))
            {
                result = temp.Clone();
            }
            pictureBoxIpl1.ImageIpl = result;
        }


    }
}
