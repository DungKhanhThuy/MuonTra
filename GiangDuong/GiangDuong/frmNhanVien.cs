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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
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

        NhanVien nhanVien = new NhanVien();
        int chon;
        ConnectDB cn = new ConnectDB();


        public void KhoiTao()
        {
            textMaNV.Enabled = textTenNV.Enabled = textSDT.Enabled = textChucVu.Enabled  = false;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = true;
            buttonLuu.Enabled = buttonHuy.Enabled = false;
        }

        //Mo cac button enable
        public void Mo()
        {
            textMaNV.Enabled = textTenNV.Enabled = textSDT.Enabled = textChucVu.Enabled  = true;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = false;
            buttonLuu.Enabled = buttonHuy.Enabled = true;
        }

        public void SetNull()
        {
            textMaNV.Text = textTenNV.Text = textSDT.Text = textChucVu.Text = "";
        }



        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textMaNV.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                textTenNV.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                textSDT.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                textChucVu.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                Mo();
                SetNull();
                chon = 1;
                DataTable dt = cn.LoadData("HienThi_NhanVien");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
            SetNull();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Mo();
            textMaNV.Enabled = false;
            chon = 2;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.LoadData1("XemNV", "@MaNV", textMaNV.Text).Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy Nhân viên này");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        cn.LoadData1("XoaNV", "@MaNV", textMaNV.Text);
                        MessageBox.Show("Xóa thành công!");
                        frmNhanVien_Load(sender, e);
                        SetNull();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                KhoiTao();
                dataGridViewNhanVien.DataSource = nhanVien.Show();
                dataGridViewNhanVien.Columns[0].Width = 100;
                chon = 0;
                ngườiDùngToolStripMenuItem.Enabled = frmDangNhap.bientoancuc.ad;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (chon == 1) //Them
                {
                    if (cn.LoadData1("XemNV", "@MaNV", textMaNV.Text).Rows.Count > 0)
                        MessageBox.Show("NhanVien đã có trong danh sách");
                    else
                    {
                        if (textTenNV.Text == "" || textSDT.Text == "" || textChucVu.Text == "")
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        else
                        {
                            nhanVien.NV_DB("ThemNV", textMaNV.Text, textTenNV.Text, textChucVu.Text, textSDT.Text);
                            MessageBox.Show("Thêm thành công");
                            frmNhanVien_Load(sender, e);
                        }
                    }

                }
                else if (chon == 2) //Sua
                {
                    if (cn.LoadData1("XemNV", "@MaNV", textMaNV.Text).Rows.Count == 0)
                        MessageBox.Show("Nhân viên này chưa có trong danh sách");
                    else
                    {
                        if (textTenNV.Text == "" || textSDT.Text == "" || textChucVu.Text == "")
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        else
                        {
                            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                nhanVien.NV_DB("SuaNV", textMaNV.Text, textTenNV.Text, textChucVu.Text, textSDT.Text);
                                MessageBox.Show("Sửa thành công");
                                frmNhanVien_Load(sender, e);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
            Hide();
        }
    }
}
