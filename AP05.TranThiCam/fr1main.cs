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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ulatroi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nạpÂmThanhDùngWMPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nạpÂmThanhDùngWMPLoadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nạpÂmThanhDùngWMPToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        //gọi form quản lí âm thanh//
        private void quảnLýÂmThanhDùngWMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr2wmp fr = new Fr2wmp();
            fr.ShowDialog();

        }
    }
}
