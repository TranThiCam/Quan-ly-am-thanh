
namespace AP05.TranThiCam
{
    partial class FR2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR2));
            this.audioFilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AP05_TranThiCamDataSet = new AP05.TranThiCam._AP05_TranThiCamDataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.audioFilesTableAdapter = new AP05.TranThiCam._AP05_TranThiCamDataSetTableAdapters.AudioFilesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExtentions = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxAudioFiles = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSlower = new System.Windows.Forms.Button();
            this.btnFaster = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFist = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.axWMP1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.audioFilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AP05_TranThiCamDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP1)).BeginInit();
            this.SuspendLayout();
            // 
            // audioFilesBindingSource
            // 
            this.audioFilesBindingSource.DataMember = "AudioFiles";
            this.audioFilesBindingSource.DataSource = this.AP05_TranThiCamDataSet;
            // 
            // AP05_TranThiCamDataSet
            // 
            this.AP05_TranThiCamDataSet.DataSetName = "AP05_TranThiCamDataSet";
            this.AP05_TranThiCamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // audioFilesTableAdapter
            // 
            this.audioFilesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLength);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtExtentions);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBoxAudioFiles);
            this.groupBox1.Location = new System.Drawing.Point(36, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(445, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUẢN LÝ THÔNG TIN FILES ÂM THANH";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(398, 158);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "KB";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(389, 225);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "s (giây)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 275);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Mô tả";
            // 
            // txtDesc
            // 
            this.txtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioFilesBindingSource, "desc", true));
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(278, 256);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(144, 56);
            this.txtDesc.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 228);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Chiều dài";
            // 
            // txtLength
            // 
            this.txtLength.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioFilesBindingSource, "length", true));
            this.txtLength.Enabled = false;
            this.txtLength.Location = new System.Drawing.Point(278, 223);
            this.txtLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(108, 20);
            this.txtLength.TabIndex = 28;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Phần mở rộng";
            // 
            // txtExtentions
            // 
            this.txtExtentions.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioFilesBindingSource, "ext", true));
            this.txtExtentions.Enabled = false;
            this.txtExtentions.Location = new System.Drawing.Point(278, 191);
            this.txtExtentions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExtentions.Name = "txtExtentions";
            this.txtExtentions.Size = new System.Drawing.Size(144, 20);
            this.txtExtentions.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Kích thước";
            // 
            // txtSize
            // 
            this.txtSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioFilesBindingSource, "size", true));
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(278, 156);
            this.txtSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(116, 20);
            this.txtSize.TabIndex = 24;
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Đường dẫn";
            // 
            // txtFilePath
            // 
            this.txtFilePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioFilesBindingSource, "filepath", true));
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(278, 124);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(144, 20);
            this.txtFilePath.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tên file";
            // 
            // txtFileName
            // 
            this.txtFileName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioFilesBindingSource, "filename", true));
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(278, 91);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(144, 20);
            this.txtFileName.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mã số";
            // 
            // txtMS
            // 
            this.txtMS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.audioFilesBindingSource, "ms", true));
            this.txtMS.Enabled = false;
            this.txtMS.Location = new System.Drawing.Point(278, 58);
            this.txtMS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(144, 20);
            this.txtMS.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thông tin chi tiết về files âm thanh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn files âm thanh";
            // 
            // listBoxAudioFiles
            // 
            this.listBoxAudioFiles.DataSource = this.audioFilesBindingSource;
            this.listBoxAudioFiles.DisplayMember = "filename";
            this.listBoxAudioFiles.FormattingEnabled = true;
            this.listBoxAudioFiles.Location = new System.Drawing.Point(18, 58);
            this.listBoxAudioFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxAudioFiles.Name = "listBoxAudioFiles";
            this.listBoxAudioFiles.Size = new System.Drawing.Size(178, 251);
            this.listBoxAudioFiles.TabIndex = 0;
            this.listBoxAudioFiles.ValueMember = "filepath";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSlower);
            this.groupBox2.Controls.Add(this.btnFaster);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnPause);
            this.groupBox2.Controls.Add(this.btnLast);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnPrevious);
            this.groupBox2.Controls.Add(this.btnFist);
            this.groupBox2.Controls.Add(this.btnPlay);
            this.groupBox2.Controls.Add(this.axWMP1);
            this.groupBox2.Location = new System.Drawing.Point(496, 87);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(441, 392);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KIỂM (NGHE THỬ)  FILES ÂM THANH";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSlower
            // 
            this.btnSlower.Location = new System.Drawing.Point(361, 302);
            this.btnSlower.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSlower.Name = "btnSlower";
            this.btnSlower.Size = new System.Drawing.Size(52, 29);
            this.btnSlower.TabIndex = 4;
            this.btnSlower.Text = "Slower";
            this.btnSlower.UseVisualStyleBackColor = true;
            this.btnSlower.Click += new System.EventHandler(this.btnSlower_Click);
            // 
            // btnFaster
            // 
            this.btnFaster.Location = new System.Drawing.Point(284, 302);
            this.btnFaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFaster.Name = "btnFaster";
            this.btnFaster.Size = new System.Drawing.Size(52, 29);
            this.btnFaster.TabIndex = 5;
            this.btnFaster.Text = "Faster";
            this.btnFaster.UseVisualStyleBackColor = true;
            this.btnFaster.Click += new System.EventHandler(this.btnFaster_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(199, 302);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(52, 29);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(116, 302);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(52, 29);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(326, 347);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(74, 29);
            this.btnLast.TabIndex = 8;
            this.btnLast.Text = "Last Tract";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(236, 347);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 29);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next Tract";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(128, 347);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(91, 29);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "Previous Tract";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFist
            // 
            this.btnFist.Location = new System.Drawing.Point(42, 347);
            this.btnFist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFist.Name = "btnFist";
            this.btnFist.Size = new System.Drawing.Size(74, 29);
            this.btnFist.TabIndex = 11;
            this.btnFist.Text = "First Tract";
            this.btnFist.UseVisualStyleBackColor = true;
            this.btnFist.Click += new System.EventHandler(this.btnFist_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(32, 302);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(52, 29);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // axWMP1
            // 
            this.axWMP1.DataBindings.Add(new System.Windows.Forms.Binding("URL", this.audioFilesBindingSource, "filepath", true));
            this.axWMP1.Enabled = true;
            this.axWMP1.Location = new System.Drawing.Point(25, 37);
            this.axWMP1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axWMP1.Name = "axWMP1";
            this.axWMP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP1.OcxState")));
            this.axWMP1.Size = new System.Drawing.Size(388, 261);
            this.axWMP1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(129, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "04_Trần Thị Cam_QUẢN LÝ ÂM THANH GIỌNG NÓI VÙNG MIỀN DÙNG THƯ VIỆN WWP.DLL CỦA MS" +
    ".WINDOWN";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(790, 483);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát khỏi App";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(624, 483);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Đóng file, về màn hình chính";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(496, 483);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 29);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa files";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(369, 483);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(98, 29);
            this.btnRecord.TabIndex = 7;
            this.btnRecord.Text = "Ghi âm file mới";
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(229, 483);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(98, 29);
            this.btnModify.TabIndex = 8;
            this.btnModify.Text = "Sửa thông tin file";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(87, 483);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Nạp thêm files";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FR2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 515);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FR2";
            this.Text = "04_TTC_Quản Lý Âm Thanh dùng WMP";
            this.Load += new System.EventHandler(this.FR2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.audioFilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AP05_TranThiCamDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWMP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private _AP05_TranThiCamDataSet AP05_TranThiCamDataSet;
        private System.Windows.Forms.BindingSource audioFilesBindingSource;
        private _AP05_TranThiCamDataSetTableAdapters.AudioFilesTableAdapter audioFilesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxAudioFiles;
        private AxWMPLib.AxWindowsMediaPlayer axWMP1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtExtentions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.Button btnSlower;
        private System.Windows.Forms.Button btnFaster;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFist;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}