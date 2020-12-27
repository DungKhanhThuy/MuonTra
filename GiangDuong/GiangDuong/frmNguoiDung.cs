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
    public partial class frmNguoiDung : Form
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }
        private void mượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuonTra hd = new frmMuonTra();
            hd.Show();
            Hide();
        }

        private void lịchSửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichSu hd = new frmLichSu();
            hd.Show();
            Hide();
        }

        private void thờiKhoáBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThoiKhoaBieu hd = new frmThoiKhoaBieu();
            hd.Show();
            Hide();
        }

        private void thiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThietBi hd = new frmThietBi();
            hd.Show();
            Hide();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien hd = new frmNhanVien();
            hd.Show();
            Hide();
        }

        private void họcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHocVien hd = new frmHocVien();
            hd.Show();
            Hide();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhong hd = new frmPhong();
            hd.Show();
            Hide();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop hd = new frmLop();
            hd.Show();
            Hide();
        }

        private void loạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoai hd = new frmLoai();
            hd.Show();
            Hide();
        }

        private void giaoBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiaoBan hd = new frmGiaoBan();
            hd.Show();
            Hide();
        }

        private void sựCốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuCo hd = new frmSuCo();
            hd.Show();
            Hide();
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNguoiDung hd = new frmNguoiDung();
            hd.Show();
            Hide();
        }

        //==================================

        ClassNguoiDung nguoidung = new ClassNguoiDung();
        int chon;
        ConnectDB cn = new ConnectDB();


        public void KhoiTao()
        {
            comboBoxMaNV.Enabled = textMatKhau.Enabled = comboBoxLaAdmin.Enabled  = false;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = true;
            buttonLuu.Enabled = buttonHuy.Enabled = false;
        }

        //Mo cac button enable
        public void Mo()
        {
            comboBoxMaNV.Enabled = textMatKhau.Enabled = comboBoxLaAdmin.Enabled = true;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = false;
            buttonLuu.Enabled = buttonHuy.Enabled = true;
        }

        public void SetNull()
        {
            comboBoxMaNV.Text = textMatKhau.Text = comboBoxLaAdmin.Text = "";
        }



        private void dataGridViewNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                comboBoxMaNV.Text = dataGridViewNguoiDung.Rows[e.RowIndex].Cells[0].Value.ToString();
                textMatKhau.Text = dataGridViewNguoiDung.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBoxLaAdmin.Text = dataGridViewNguoiDung.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            Mo();
            SetNull();
            chon = 1;
            DataTable dt = cn.LoadData("HienThi_NguoiDung");
            comboBoxMaNV.Text = dt.Rows[0][0].ToString();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            frmNguoiDung_Load(sender, e);
            SetNull();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Mo();
            comboBoxMaNV.Enabled = false;
            chon = 2;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.LoadData1("XemNguoiDung", "@MaNV", comboBoxMaNV.Text).Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy Nhân viên này");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        cn.Xoa("XoaNguoiDung", "@MaNV", comboBoxMaNV.Text);
                        MessageBox.Show("Xóa thành công!");
                        frmNguoiDung_Load(sender, e);
                        SetNull();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            KhoiTao();
            dataGridViewNguoiDung.DataSource = nguoidung.Show();
            chon = 0;
            HienThi_MaNV();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1) //Them
            {
                if (cn.LoadData1("XemNguoiDung", "@MaNV", comboBoxMaNV.Text).Rows.Count > 0)
                    MessageBox.Show("Tài khoản đã có trong danh sách");
                else
                {
                    if (textMatKhau.Text == "" || comboBoxLaAdmin.Text == "" )
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    else
                    {
                        nguoidung.NguoiDung_DB("ThemNguoiDung", comboBoxMaNV.Text, textMatKhau.Text, comboBoxLaAdmin.Text);
                        MessageBox.Show("Thêm thành công");
                        frmNguoiDung_Load(sender, e);
                    }
                }

            }
            else if (chon == 2) //Sua
            {
                if (cn.LoadData1("XemNguoiDung", "@MaNV", comboBoxMaNV.Text).Rows.Count == 0)
                    MessageBox.Show("Tài khoản này chưa có trong danh sách");
                else
                {
                    if (textMatKhau.Text == "" || comboBoxLaAdmin.Text == "" )
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa học viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            nguoidung.NguoiDung_DB("SuaNguoiDung", comboBoxMaNV.Text, textMatKhau.Text, comboBoxLaAdmin.Text);
                            MessageBox.Show("Sửa thành công");
                            frmNguoiDung_Load(sender, e);
                        }
                    }
                }

            }
        }

        public void HienThi_MaNV()
        {
            comboBoxMaNV.DataSource = cn.LoadData("HienThi_NhanVien");
            comboBoxMaNV.DisplayMember = "MaNV";
            comboBoxMaNV.ValueMember = "MaNV";
            comboBoxMaNV.SelectedValue = "MaNV";
            comboBoxMaNV.SelectedIndex = 0;

        }


        private void comboBoxMaNV_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = cn.LoadData1("HienThi_MatKhau_LaAdmin", "@MaNV", comboBoxMaNV.Text);
                if (dt.Rows.Count != 0)
                {
                    if (comboBoxMaNV.SelectedItem != null)
                    {
                        textMatKhau.Text = dt.Rows[0][1].ToString();
                        comboBoxLaAdmin.Text = dt.Rows[0][2].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
