using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using AxWMPLib;

namespace AP05.TranThiCam
{
    public partial class FR2 : Form
    {

        static string audioPath = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)) + "\\Auidos\\";

        public FR2()
        {
            InitializeComponent();
        }

        private void FR2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AP05_TranThiCamDataSet.AudioFiles' table. You can move, or remove it, as needed.
            this.audioFilesTableAdapter.Fill(this.AP05_TranThiCamDataSet.AudioFiles);

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            axWMP1.Ctlcontrols.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axWMP1.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWMP1.Ctlcontrols.stop();
        }

        private void btnFaster_Click(object sender, EventArgs e)
        {
            axWMP1.Ctlcontrols.fastForward();
        }

        private void btnSlower_Click(object sender, EventArgs e)
        {
            axWMP1.Ctlcontrols.fastReverse();
        }

        private void btnFist_Click(object sender, EventArgs e)
        {
            listBoxAudioFiles.SelectedIndex = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (listBoxAudioFiles.SelectedIndex > 0) listBoxAudioFiles.SelectedIndex--;
            else listBoxAudioFiles.SelectedIndex = listBoxAudioFiles.Items.Count - 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listBoxAudioFiles.SelectedIndex < listBoxAudioFiles.Items.Count - 1)
                listBoxAudioFiles.SelectedIndex++;
            else listBoxAudioFiles.SelectedIndex = 0;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            listBoxAudioFiles.SelectedIndex = listBoxAudioFiles.Items.Count - 1;
        }
        static DialogResult ch = DialogResult.No;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMS.Enabled = !txtMS.Enabled;
            txtDesc.Enabled = !txtDesc.Enabled;
            btnModify.Enabled = !btnModify.Enabled;
            btnRecord.Enabled = !btnRecord.Enabled;
            btnDelete.Enabled = !btnDelete.Enabled;
            btnPlay.Enabled = !btnPlay.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
            btnPause.Enabled = !btnPause.Enabled;
            btnFaster.Enabled = !btnFaster.Enabled;
            btnSlower.Enabled = !btnSlower.Enabled;
            btnFist.Enabled = !btnFist.Enabled;
            btnLast.Enabled = !btnLast.Enabled;
            btnNext.Enabled = !btnNext.Enabled;
            btnPrevious.Enabled = !btnPrevious.Enabled;
            if (btnAdd.Text == "Nạp thêm files")
            {
                ch = openFileDialog1.ShowDialog();
                txtMS.Text = "Nhập mã số";
                txtDesc.Text = "Nhập mô tả cho file âm thanh";
                btnAdd.Text = "Lưu file";
            }
            else
            {
                if (ch == DialogResult.OK)
                {
                    string fileName = Path.GetFileName(openFileDialog1.FileName);
                    //[1] COPY FILE ÂM THANH ĐÃ CHỌN VÀO THƯ MỤC ~\\AudioFiles
                    try
                    {
                        Console.WriteLine(audioPath + fileName);
                        File.Copy(openFileDialog1.FileName, audioPath + fileName, true);
                    }
                    catch (System.Exception ex) { MessageBox.Show("Có lỗi copy file âm thanh:" + ex.Message); }

                    //[2] NẠP THÔNG TIN CỦA FILE ÂM THANH ĐÃ CHỌN VÀO DATABASE SQL
                    if (txtMS.Text != "" && txtMS.Text != "Nhập mã số")
                    {
                        try
                        {
                            //(ms, filepath, filename, size, ext, length, [desc])
                            audioFilesTableAdapter.Insert(txtMS.Text.Trim(), audioPath + fileName,
                                                     fileName, 0, "", TimeSpan.Parse("03:00"), txtDesc.Text);
                        }
                        catch (System.Exception ex)
                        { MessageBox.Show("Có lỗi khi nạp thông tin file âm thanh vào DB: " + ex.Message); }
                    }
                    else MessageBox.Show("Không được để trống mã file");
                    try
                    {
                        this.audioFilesTableAdapter.Fill(this.AP05_TranThiCamDataSet.AudioFiles);
                    }
                    catch (System.Exception ex)
                    { MessageBox.Show("Có lỗi tải các files âm thanh lên danh sách! " + ex.Message); }
                    btnAdd.Text = "Nạp thêm files";

                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            txtDesc.Enabled = !txtDesc.Enabled;
            btnAdd.Enabled = !btnAdd.Enabled;
            btnRecord.Enabled = !btnRecord.Enabled;
            btnDelete.Enabled = !btnDelete.Enabled;
            btnPlay.Enabled = !btnPlay.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
            btnPause.Enabled = !btnPause.Enabled;
            btnFaster.Enabled = !btnFaster.Enabled;
            btnSlower.Enabled = !btnSlower.Enabled;
            btnFist.Enabled = !btnFist.Enabled;
            btnLast.Enabled = !btnLast.Enabled;
            btnNext.Enabled = !btnNext.Enabled;
            btnPrevious.Enabled = !btnPrevious.Enabled;
            if (btnModify.Text == "Sửa thông tin file")
            {
                btnModify.Text = "Lưu chỉnh sửa";
            }
            else
            {
                try
                {
                    audioFilesTableAdapter.Update(txtDesc.Text, txtMS.Text.Trim());
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi khi SỬA thông tin file âm thanh: " + ex.Message); }
                try
                {
                    this.audioFilesTableAdapter.Fill(this.AP05_TranThiCamDataSet.AudioFiles);
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi tải các files âm thanh lên danh sách! " + ex.Message); }
                btnModify.Text = "Sửa thông tin file";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có chắc chắn muốn xóa file âm thanh này: " + txtMS.Text.Trim()
                        + " _ " + txtFileName.Text.Trim() + " không(Y/N)?", "Xác nhận",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                try
                {
                    audioFilesTableAdapter.Delete(txtMS.Text.Trim());
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi khi XÓA file âm thanh: " + ex.Message); }
                try
                {
                    this.audioFilesTableAdapter.Fill(this.AP05_TranThiCamDataSet.AudioFiles);
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi tải các files âm thanh lên danh sách! " + ex.Message); }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có chắc chắn muốn về màn hình chính không (Y/N)?", "Xác nhận",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                axWMP1.Ctlcontrols.stop();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có chắc chắn muốn thoát không (Y/N)?", "Xác nhận",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
