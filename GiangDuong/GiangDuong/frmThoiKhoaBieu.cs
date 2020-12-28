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
    public partial class frmThoiKhoaBieu : Form
    {
        public frmThoiKhoaBieu()
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

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap hd = new frmDangNhap();
            hd.Show();
            Hide();
        }


        ClassThoiKhoaBieu thoiKhoaBieu = new ClassThoiKhoaBieu();
        int chon;
        ConnectDB cn = new ConnectDB();


        public void KhoiTao()
        {
            comboBoxMaLop.Enabled = textTenLop.Enabled = dateTimePickerNgayBatDau.Enabled = dateTimePickerNgayKetThuc.Enabled = textBuoi.Enabled = comboBoxMaPhong.Enabled = false;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = true;
            buttonLuu.Enabled = buttonHuy.Enabled = false;
        }

        //Mo cac button enable
        public void Mo()
        {
            comboBoxMaLop.Enabled = textTenLop.Enabled = dateTimePickerNgayBatDau.Enabled = dateTimePickerNgayKetThuc.Enabled = textBuoi.Enabled = comboBoxMaPhong.Enabled = true;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = false;
            buttonLuu.Enabled = buttonHuy.Enabled = true;
        }

        public void SetNull()
        {
            comboBoxMaLop.Text = textTenLop.Text = dateTimePickerNgayBatDau.Text = dateTimePickerNgayKetThuc.Text = textBuoi.Text = comboBoxMaPhong.Text = "";
        }



        private void dataGridViewTKB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                comboBoxMaLop.Text = dataGridViewTKB.Rows[e.RowIndex].Cells[0].Value.ToString();
                textTenLop.Text = dataGridViewTKB.Rows[e.RowIndex].Cells[1].Value.ToString();
                dateTimePickerNgayBatDau.Text = dataGridViewTKB.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePickerNgayKetThuc.Text = dataGridViewTKB.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBuoi.Text = dataGridViewTKB.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboBoxMaPhong.Text = dataGridViewTKB.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            { }
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            Mo();
            SetNull();
            chon = 1;
            DataTable dt = cn.LoadData("HienThi_TKB");
            comboBoxMaLop.Text = dt.Rows[0][0].ToString();
            comboBoxMaPhong.Text = dt.Rows[0][5].ToString();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            frmThoiKhoaBieu_Load(sender, e);
            SetNull();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Mo();
            comboBoxMaLop.Enabled = false;
            comboBoxMaPhong.Enabled = false;
            chon = 2;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.LoadData2("XemTKB", "@MaLop", "@MaPhong", comboBoxMaLop.Text, comboBoxMaPhong.Text).Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy Thời khoá biểu này");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        cn.Xoa("XoaHocVien", "@MaHV", comboBoxMaLop.Text);
                        MessageBox.Show("Xóa thành công!");
                        frmHocVien_Load(sender, e);
                        SetNull();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            KhoiTao();

            dataGridViewTKB.DataSource = thoiKhoaBieu.Show();
            HienThi_MaLop();
            HienThi_MaPhong();
            chon = 0;
            ngườiDùngToolStripMenuItem.Enabled = frmDangNhap.bientoancuc.ad;

        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1) //Them
            {
                if (cn.LoadData1("XemHocVien", "@MaHV", comboBoxMaLop.Text).Rows.Count > 0)
                    MessageBox.Show("Mã học viên đã có trong danh sách");
                else
                {
                    if (textTenLop.Text == "" || comboBoxMaLop.Text == "" || textTenLop.Text == "" || textSDT.Text == "" || textDonVi.Text == "")
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    else
                    {
                        hv.HocVien_DB("ThemHocVien", comboBoxMaLop.Text, textTenLop.Text, textDonVi.Text, textSDT.Text, comboBoxMaLop.Text);
                        MessageBox.Show("Thêm thành công");
                        frmHocVien_Load(sender, e);
                    }
                }

            }
            else if (chon == 2) //Sua
            {
                if (cn.LoadData1("XemHocVien", "@MaHV", comboBoxMaLop.Text).Rows.Count == 0)
                    MessageBox.Show("Mã học viên chưa có trong danh sách");
                else
                {
                    if (textTenLop.Text == "" || comboBoxMaLop.Text == "" || textTenLop.Text == "" || textSDT.Text == "" || textDonVi.Text == "")
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa học viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            hv.HocVien_DB("SuaHocVien", comboBoxMaLop.Text, textTenLop.Text, textDonVi.Text, textSDT.Text, comboBoxMaLop.Text);
                            MessageBox.Show("Sửa thành công");
                            frmHocVien_Load(sender, e);
                        }
                    }
                }

            }
        }

        public void HienThi_MaHV()
        {
            comboBoxMaLop.DataSource = cn.LoadData("HienThi_Lop");

            comboBoxMaLop.DisplayMember = "TenLop";
            comboBoxMaLop.ValueMember = "MaLop";

            comboBoxMaLop.SelectedValue = "MaLop";
            comboBoxMaLop.SelectedIndex = 0;

        }


        public void HienThi_MaPhong()
        {
            comboBoxMaLop.DataSource = cn.LoadData("HienThi_Phong");
            comboBoxMaLop.DisplayMember = "MaLop";
            comboBoxMaLop.ValueMember = "MaLop";
            comboBoxMaLop.SelectedValue = "MaLop";
            comboBoxMaLop.SelectedIndex = 0;

        }



        private void comboBoxMaLop_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = cn.LoadData1("HienThi_TenLop", "@MaLop", comboBoxMaLop.Text);
                if (dt.Rows.Count != 0)
                {
                    if (comboBoxMaLop.SelectedItem != null)
                    {
                        textTenLop.Text = dt.Rows[0][1].ToString();
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
