using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrrKlang;
using System.Windows.Forms;

namespace AP05.TranThiCam
{
    public partial class FrirrKlang : Form
    {
        public FrirrKlang()
        {
            InitializeComponent();
        }
        //KHAI BÁO CÁC BIẾN TOÀN CỤC 
        ISoundEngine fn = new ISoundEngine();
        //Khai báo biến toàn cục thuộc đối tượng File âm thanh của irrKLang 
        string audiopath =
           System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath));
        //LẤY THƯ MỤC HIỆN TẠI (PATH) CỦA APP
        //Application.StartupPath = đường dẫn thư mục App \bin\Debug => để path của App lấy ra ngoài thư mục cha 2 lần
        //để lấy thư mục cha sử dụng System.IO.Path.GetDirectoryName(Application.StartupPath)

        //PLAY SOUND 2D DÙNG irrKLang
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            fn.SoundVolume = 100;
            fn.Play2D(audiopath + "\\Audios\\keshi - always.mp3", true);
            MessageBox.Show("OK");
        }


    }
}
