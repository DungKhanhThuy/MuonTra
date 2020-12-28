using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiangDuong
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        DangNhap dn = new DangNhap();

        public class bientoancuc
        {
            public static bool ad = false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (dn.DangNhapHT(txtUserName.Text, txtPass.Text) == true)
            {
                MessageBox.Show("Bạn đăng nhập thành công ^^", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConnectDB cn = new ConnectDB();
                DataTable dt = cn.LoadData1("HienThi_MatKhau_LaAdmin", "@MaNV", txtUserName.Text);
                if (dt.Rows[0][2].ToString() == "Co")
                {
                    bientoancuc.ad = true;
                }
                else
                {
                    bientoancuc.ad = false;
                }
                frmHocVien hv = new frmHocVien();
                hv.Show();
                Hide();
            }
            else MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai. Mời bạn nhập lại !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có chắc muốn thoát ??", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.ResizeRedraw, true);

        }

    }
}
