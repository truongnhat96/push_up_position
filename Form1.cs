using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace push_up_position
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            music = new SoundPlayer("Nhac001.wav");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK) e.Cancel = false;
            else e.Cancel = true;
        }

        private void lblOutputname_Click(object sender, EventArgs e)
        {
            
        }

        private void txtInputname_TextChanged(object sender, EventArgs e)
        {
            lblOutputname.Text = $"Hi {txtInputname.Text}, Click vào nút [Push-Up] để chống đẩy nhé!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picUp.Visible = true;
            picDown.Visible = false;
        }
        int cnt = 0, dembtn = 0;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMusic.Checked) music.Play();
            else music.Stop();
        }

        private void btnChongday_Click(object sender, EventArgs e)
        {
            if (picUp.Visible)
            {
                picUp.Visible = false;
                picDown.Visible = true;
            }
            else
            {
                picUp.Visible = true;
                picDown.Visible = false;
            }
            ++dembtn;
            if (dembtn == 2)
            {
                ++cnt;
                dembtn = 0;
            }
            lblKetqua.Text = cnt.ToString();
            if ((cnt == 10 || cnt == 100 || cnt == 1000 || cnt == 10000 || cnt == 100000 || cnt == 1000000) && dembtn == 0)
                MessageBox.Show($"Xin chúc mừng! {txtInputname.Text} đã chống đẩy được {cnt} cái. Hãy tiếp tục phát huy nhé! ^_^", "Thông báo");
        }

    }
}
