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
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát?\nThông tin các tài khoản đã tạo sẽ không được lưu", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK) e.Cancel = false;
            else e.Cancel = true;
        }

        private void lblOutputname_Click(object sender, EventArgs e)
        {
            
        }
        string[] ds = new string[100];
        private void txtInputname_TextChanged(object sender, EventArgs e)
        {
            if (cboTk.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInputname.Clear();
                return;
            }
            ds[cboTk.SelectedIndex] = txtInputname.Text;
            lblOutputname.Text = $"Hi {ds[cboTk.SelectedIndex]}, Click vào nút [Push-Up] để chống đẩy nhé!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picUp.Visible = true;
            picDown.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMusic.Checked) music.Play();
            else music.Stop();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboTk.Items.Add(txtTk.Text);
            MessageBox.Show("Tài khoản được tạo thành công!");
        }

        int[] cnt = new int[100], dembtn = new int[100];

        private void cboTk_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblKetqua.Text = cnt[cboTk.SelectedIndex].ToString();
            txtInputname.Text = ds[cboTk.SelectedIndex];
        }

        private void btnChongday_Click(object sender, EventArgs e)
        {
            if(cboTk.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            ++dembtn[cboTk.SelectedIndex];
            if (dembtn[cboTk.SelectedIndex] == 2)
            {
                ++cnt[cboTk.SelectedIndex];
                dembtn[cboTk.SelectedIndex] = 0;
            }
            lblKetqua.Text = cnt[cboTk.SelectedIndex].ToString();
            if ((cnt[cboTk.SelectedIndex] == 10 || cnt[cboTk.SelectedIndex] == 100 || cnt[cboTk.SelectedIndex] == 1000 || cnt[cboTk.SelectedIndex] == 10000 || cnt[cboTk.SelectedIndex] == 100000 || cnt[cboTk.SelectedIndex] == 1000000) && dembtn[cboTk.SelectedIndex] == 0)
                MessageBox.Show($"Xin chúc mừng! {txtInputname.Text} đã chống đẩy được {cnt[cboTk.SelectedIndex]} cái. Hãy tiếp tục phát huy nhé! ^_^", "Thông báo");
        }

    }
}
