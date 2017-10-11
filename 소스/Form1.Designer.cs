namespace MuiltiPro
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.읽기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.적용취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.영상변환ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGB2GRAYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.좌우반전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상하반전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.비트플레인출력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.히스토그램스트레칭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.히스토그램평준화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.임계치필터링ThresholdingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공간기반처리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.블러링3x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.블러링5x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.샤프닝ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.평균값필터링ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.중간값필터링ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.가우시안필터링ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.에지추출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.소벨마스킹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.라플라시안마스킹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모폴로지연산ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열림ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.닫힘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기하학처리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대NNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.축소NNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대선형보간ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.축소선형보간ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.영상변환ToolStripMenuItem,
            this.pixelToolStripMenuItem,
            this.공간기반처리ToolStripMenuItem,
            this.에지추출ToolStripMenuItem,
            this.모폴로지연산ToolStripMenuItem,
            this.기하학처리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.읽기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.다른이름으로저장ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 읽기ToolStripMenuItem
            // 
            this.읽기ToolStripMenuItem.Name = "읽기ToolStripMenuItem";
            this.읽기ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.읽기ToolStripMenuItem.Text = "읽기";
            this.읽기ToolStripMenuItem.Click += new System.EventHandler(this.읽기ToolStripMenuItem_Click);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
            // 
            // 다른이름으로저장ToolStripMenuItem
            // 
            this.다른이름으로저장ToolStripMenuItem.Name = "다른이름으로저장ToolStripMenuItem";
            this.다른이름으로저장ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.다른이름으로저장ToolStripMenuItem.Text = "다른이름으로 저장";
            this.다른이름으로저장ToolStripMenuItem.Click += new System.EventHandler(this.다른이름으로저장ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.적용취소ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 적용취소ToolStripMenuItem
            // 
            this.적용취소ToolStripMenuItem.Name = "적용취소ToolStripMenuItem";
            this.적용취소ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.적용취소ToolStripMenuItem.Text = "적용취소";
            this.적용취소ToolStripMenuItem.Click += new System.EventHandler(this.적용취소ToolStripMenuItem_Click);
            // 
            // 영상변환ToolStripMenuItem
            // 
            this.영상변환ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rGB2GRAYToolStripMenuItem,
            this.좌우반전ToolStripMenuItem,
            this.상하반전ToolStripMenuItem,
            this.비트플레인출력ToolStripMenuItem});
            this.영상변환ToolStripMenuItem.Name = "영상변환ToolStripMenuItem";
            this.영상변환ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.영상변환ToolStripMenuItem.Text = "영상변환";
            // 
            // rGB2GRAYToolStripMenuItem
            // 
            this.rGB2GRAYToolStripMenuItem.Name = "rGB2GRAYToolStripMenuItem";
            this.rGB2GRAYToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.rGB2GRAYToolStripMenuItem.Text = "RGB2GRAY";
            this.rGB2GRAYToolStripMenuItem.Click += new System.EventHandler(this.rGB2GRAYToolStripMenuItem_Click);
            // 
            // 좌우반전ToolStripMenuItem
            // 
            this.좌우반전ToolStripMenuItem.Name = "좌우반전ToolStripMenuItem";
            this.좌우반전ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.좌우반전ToolStripMenuItem.Text = "좌우반전";
            this.좌우반전ToolStripMenuItem.Click += new System.EventHandler(this.좌우반전ToolStripMenuItem_Click);
            // 
            // 상하반전ToolStripMenuItem
            // 
            this.상하반전ToolStripMenuItem.Name = "상하반전ToolStripMenuItem";
            this.상하반전ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.상하반전ToolStripMenuItem.Text = "상하반전";
            this.상하반전ToolStripMenuItem.Click += new System.EventHandler(this.상하반전ToolStripMenuItem_Click);
            // 
            // 비트플레인출력ToolStripMenuItem
            // 
            this.비트플레인출력ToolStripMenuItem.Name = "비트플레인출력ToolStripMenuItem";
            this.비트플레인출력ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.비트플레인출력ToolStripMenuItem.Text = "비트플레인 출력";
            this.비트플레인출력ToolStripMenuItem.Click += new System.EventHandler(this.비트플레인출력ToolStripMenuItem_Click);
            // 
            // pixelToolStripMenuItem
            // 
            this.pixelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.히스토그램스트레칭ToolStripMenuItem,
            this.히스토그램평준화ToolStripMenuItem,
            this.negativeToolStripMenuItem,
            this.임계치필터링ThresholdingToolStripMenuItem});
            this.pixelToolStripMenuItem.Name = "pixelToolStripMenuItem";
            this.pixelToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.pixelToolStripMenuItem.Text = "Pixel 처리";
            // 
            // 히스토그램스트레칭ToolStripMenuItem
            // 
            this.히스토그램스트레칭ToolStripMenuItem.Name = "히스토그램스트레칭ToolStripMenuItem";
            this.히스토그램스트레칭ToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.히스토그램스트레칭ToolStripMenuItem.Text = "히스토그램 스트레칭";
            this.히스토그램스트레칭ToolStripMenuItem.Click += new System.EventHandler(this.히스토그램스트레칭ToolStripMenuItem_Click);
            // 
            // 히스토그램평준화ToolStripMenuItem
            // 
            this.히스토그램평준화ToolStripMenuItem.Name = "히스토그램평준화ToolStripMenuItem";
            this.히스토그램평준화ToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.히스토그램평준화ToolStripMenuItem.Text = "히스토그램 평준화";
            this.히스토그램평준화ToolStripMenuItem.Click += new System.EventHandler(this.히스토그램평준화ToolStripMenuItem_Click);
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.negativeToolStripMenuItem.Text = "Negative 영상";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // 임계치필터링ThresholdingToolStripMenuItem
            // 
            this.임계치필터링ThresholdingToolStripMenuItem.Name = "임계치필터링ThresholdingToolStripMenuItem";
            this.임계치필터링ThresholdingToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.임계치필터링ThresholdingToolStripMenuItem.Text = "임계치 필터링 (Thresholding)";
            this.임계치필터링ThresholdingToolStripMenuItem.Click += new System.EventHandler(this.임계치필터링ThresholdingToolStripMenuItem_Click);
            // 
            // 공간기반처리ToolStripMenuItem
            // 
            this.공간기반처리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.블러링3x3ToolStripMenuItem,
            this.블러링5x5ToolStripMenuItem,
            this.샤프닝ToolStripMenuItem,
            this.평균값필터링ToolStripMenuItem,
            this.중간값필터링ToolStripMenuItem,
            this.가우시안필터링ToolStripMenuItem});
            this.공간기반처리ToolStripMenuItem.Name = "공간기반처리ToolStripMenuItem";
            this.공간기반처리ToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.공간기반처리ToolStripMenuItem.Text = "공간 기반 처리";
            // 
            // 블러링3x3ToolStripMenuItem
            // 
            this.블러링3x3ToolStripMenuItem.Name = "블러링3x3ToolStripMenuItem";
            this.블러링3x3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.블러링3x3ToolStripMenuItem.Text = "블러링 3x3";
            this.블러링3x3ToolStripMenuItem.Click += new System.EventHandler(this.블러링3x3ToolStripMenuItem_Click);
            // 
            // 블러링5x5ToolStripMenuItem
            // 
            this.블러링5x5ToolStripMenuItem.Name = "블러링5x5ToolStripMenuItem";
            this.블러링5x5ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.블러링5x5ToolStripMenuItem.Text = "블러링 5x5";
            this.블러링5x5ToolStripMenuItem.Click += new System.EventHandler(this.블러링5x5ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Location = new System.Drawing.Point(19, 27);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(730, 480);
            this.pictureBoxIpl1.TabIndex = 3;
            this.pictureBoxIpl1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "임계치 :";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 518);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 513);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "120";
            // 
            // 샤프닝ToolStripMenuItem
            // 
            this.샤프닝ToolStripMenuItem.Name = "샤프닝ToolStripMenuItem";
            this.샤프닝ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.샤프닝ToolStripMenuItem.Text = "샤프닝";
            this.샤프닝ToolStripMenuItem.Click += new System.EventHandler(this.샤프닝ToolStripMenuItem_Click);
            // 
            // 평균값필터링ToolStripMenuItem
            // 
            this.평균값필터링ToolStripMenuItem.Name = "평균값필터링ToolStripMenuItem";
            this.평균값필터링ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.평균값필터링ToolStripMenuItem.Text = "평균값 필터링";
            this.평균값필터링ToolStripMenuItem.Click += new System.EventHandler(this.평균값필터링ToolStripMenuItem_Click);
            // 
            // 중간값필터링ToolStripMenuItem
            // 
            this.중간값필터링ToolStripMenuItem.Name = "중간값필터링ToolStripMenuItem";
            this.중간값필터링ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.중간값필터링ToolStripMenuItem.Text = "중간값 필터링";
            this.중간값필터링ToolStripMenuItem.Click += new System.EventHandler(this.중간값필터링ToolStripMenuItem_Click);
            // 
            // 가우시안필터링ToolStripMenuItem
            // 
            this.가우시안필터링ToolStripMenuItem.Name = "가우시안필터링ToolStripMenuItem";
            this.가우시안필터링ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.가우시안필터링ToolStripMenuItem.Text = "가우시안 필터링";
            this.가우시안필터링ToolStripMenuItem.Click += new System.EventHandler(this.가우시안필터링ToolStripMenuItem_Click);
            // 
            // 에지추출ToolStripMenuItem
            // 
            this.에지추출ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.소벨마스킹ToolStripMenuItem,
            this.라플라시안마스킹ToolStripMenuItem});
            this.에지추출ToolStripMenuItem.Name = "에지추출ToolStripMenuItem";
            this.에지추출ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.에지추출ToolStripMenuItem.Text = "에지 추출";
            // 
            // 소벨마스킹ToolStripMenuItem
            // 
            this.소벨마스킹ToolStripMenuItem.Name = "소벨마스킹ToolStripMenuItem";
            this.소벨마스킹ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.소벨마스킹ToolStripMenuItem.Text = "소벨 마스킹";
            this.소벨마스킹ToolStripMenuItem.Click += new System.EventHandler(this.소벨마스킹ToolStripMenuItem_Click);
            // 
            // 라플라시안마스킹ToolStripMenuItem
            // 
            this.라플라시안마스킹ToolStripMenuItem.Name = "라플라시안마스킹ToolStripMenuItem";
            this.라플라시안마스킹ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.라플라시안마스킹ToolStripMenuItem.Text = "라플라시안 마스킹";
            this.라플라시안마스킹ToolStripMenuItem.Click += new System.EventHandler(this.라플라시안마스킹ToolStripMenuItem_Click);
            // 
            // 모폴로지연산ToolStripMenuItem
            // 
            this.모폴로지연산ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열림ToolStripMenuItem,
            this.닫힘ToolStripMenuItem});
            this.모폴로지연산ToolStripMenuItem.Name = "모폴로지연산ToolStripMenuItem";
            this.모폴로지연산ToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.모폴로지연산ToolStripMenuItem.Text = "모폴로지 연산";
            // 
            // 열림ToolStripMenuItem
            // 
            this.열림ToolStripMenuItem.Name = "열림ToolStripMenuItem";
            this.열림ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.열림ToolStripMenuItem.Text = "열림";
            this.열림ToolStripMenuItem.Click += new System.EventHandler(this.열림ToolStripMenuItem_Click);
            // 
            // 닫힘ToolStripMenuItem
            // 
            this.닫힘ToolStripMenuItem.Name = "닫힘ToolStripMenuItem";
            this.닫힘ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.닫힘ToolStripMenuItem.Text = "닫힘";
            this.닫힘ToolStripMenuItem.Click += new System.EventHandler(this.닫힘ToolStripMenuItem_Click);
            // 
            // 기하학처리ToolStripMenuItem
            // 
            this.기하학처리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.확대NNToolStripMenuItem,
            this.축소NNToolStripMenuItem,
            this.확대선형보간ToolStripMenuItem,
            this.축소선형보간ToolStripMenuItem,
            this.회전ToolStripMenuItem});
            this.기하학처리ToolStripMenuItem.Name = "기하학처리ToolStripMenuItem";
            this.기하학처리ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.기하학처리ToolStripMenuItem.Text = "기하학 처리";
            // 
            // 확대NNToolStripMenuItem
            // 
            this.확대NNToolStripMenuItem.Name = "확대NNToolStripMenuItem";
            this.확대NNToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.확대NNToolStripMenuItem.Text = "확대 NN";
            this.확대NNToolStripMenuItem.Click += new System.EventHandler(this.확대NNToolStripMenuItem_Click);
            // 
            // 축소NNToolStripMenuItem
            // 
            this.축소NNToolStripMenuItem.Name = "축소NNToolStripMenuItem";
            this.축소NNToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.축소NNToolStripMenuItem.Text = "축소 NN";
            this.축소NNToolStripMenuItem.Click += new System.EventHandler(this.축소NNToolStripMenuItem_Click);
            // 
            // 확대선형보간ToolStripMenuItem
            // 
            this.확대선형보간ToolStripMenuItem.Name = "확대선형보간ToolStripMenuItem";
            this.확대선형보간ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.확대선형보간ToolStripMenuItem.Text = "확대 선형보간";
            this.확대선형보간ToolStripMenuItem.Click += new System.EventHandler(this.확대선형보간ToolStripMenuItem_Click);
            // 
            // 축소선형보간ToolStripMenuItem
            // 
            this.축소선형보간ToolStripMenuItem.Name = "축소선형보간ToolStripMenuItem";
            this.축소선형보간ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.축소선형보간ToolStripMenuItem.Text = "축소 선형보간";
            this.축소선형보간ToolStripMenuItem.Click += new System.EventHandler(this.축소선형보간ToolStripMenuItem_Click);
            // 
            // 회전ToolStripMenuItem
            // 
            this.회전ToolStripMenuItem.Name = "회전ToolStripMenuItem";
            this.회전ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.회전ToolStripMenuItem.Text = "회전";
            this.회전ToolStripMenuItem.Click += new System.EventHandler(this.회전ToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "확대 축소 비율 :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 513);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(505, 514);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "각도 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 542);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "20110596 방지훈 멀티미디어 과제";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 읽기ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 적용취소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 영상변환ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGB2GRAYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 좌우반전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상하반전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 비트플레인출력ToolStripMenuItem;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem pixelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 히스토그램스트레칭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 히스토그램평준화ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 임계치필터링ThresholdingToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 공간기반처리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 블러링3x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 블러링5x5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 샤프닝ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 평균값필터링ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 중간값필터링ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 가우시안필터링ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 에지추출ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 소벨마스킹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 라플라시안마스킹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모폴로지연산ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열림ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 닫힘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기하학처리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대NNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 축소NNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대선형보간ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 축소선형보간ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회전ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}

