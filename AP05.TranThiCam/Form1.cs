using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP05.TranThiCam
{
    public partial class FRmain : Form
    {
        public FRmain()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //toolStripStatusLabel3.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void FRmain_Load(object sender, EventArgs e)
        {


        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void quanLyAmThanhDungWMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR2 fr = new FR2();//khai báo biến đối tượng quản lý Form QL Ân thanh
            fr.ShowDialog();
        }

        private void quanLyAmThanhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tắtMởThanhThựcĐơnMenuBarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = !menuStrip1.Visible;
        }

        private void tắtMởThanhCôngCụToolBarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
        }

        private void tắtMởDòngTrạngTháiStatusBarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = !statusStrip1.Visible;
        }

        private void tắtMởFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có chắc chắn muốn thoát không (Y/N)?", "Xác nhận",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có chắc chắn muốn thoát không (Y/N)?", "Xác nhận",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void quảnLýÂmThanhDùngIrrKlangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrirrKlang fr = new FrirrKlang();//khai báo biến đối tượng quản lý Form QL Ân thanh
            fr.ShowDialog();
        }
    }
}
