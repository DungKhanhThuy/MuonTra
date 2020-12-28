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
    public partial class frmGiaoBan : Form
    {
        public frmGiaoBan()
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
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
            Hide();
        }

        ClassGiaoBan giaoBan = new ClassGiaoBan();
        int chon;
        ConnectDB cn = new ConnectDB();


        public void KhoiTao()
        {
            textMaNK.Enabled = comboBoxMaNV.Enabled = dateTimePickerThoiGian.Enabled = richTextBoxNoiDung.Enabled  = false;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = true;
            buttonLuu.Enabled = buttonHuy.Enabled = false;
        }

        //Mo cac button enable
        public void Mo()
        {
            textMaNK.Enabled = comboBoxMaNV.Enabled = dateTimePickerThoiGian.Enabled = richTextBoxNoiDung.Enabled = true;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = false;
            buttonLuu.Enabled = buttonHuy.Enabled = true;
        }

        public void SetNull()
        {
            textMaNK.Text = comboBoxMaNV.Text = dateTimePickerThoiGian.Text = richTextBoxNoiDung.Text = "";
        }



        private void dataGridViewGiaoBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textMaNK.Text = dataGridViewGiaoBan.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBoxMaNV.Text = dataGridViewGiaoBan.Rows[e.RowIndex].Cells[1].Value.ToString();
                dataGridViewGiaoBan.Text = dataGridViewGiaoBan.Rows[e.RowIndex].Cells[2].Value.ToString();
                richTextBoxNoiDung.Text = dataGridViewGiaoBan.Rows[e.RowIndex].Cells[3].Value.ToString();
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
                comboBoxMaNV.Text = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            frmGiaoBan_Load(sender, e);
            SetNull();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Mo();
            textMaNK.Enabled = false;
            
            chon = 2;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.LoadData1("XemNK", "@MaNK", textMaNK.Text).Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy nhật ký này");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        cn.LoadData1("XoaNK", "@MaNK", textMaNK.Text);
                        MessageBox.Show("Xóa thành công!");
                        frmGiaoBan_Load(sender, e);
                        SetNull();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmGiaoBan_Load(object sender, EventArgs e)
        {
            try
            {
                KhoiTao();
                dataGridViewGiaoBan.DataSource = giaoBan.Show();
                HienThi_MaNV();
                dataGridViewGiaoBan.Columns[0].Width = 60;
                dataGridViewGiaoBan.Columns[1].Width = 60;
                dataGridViewGiaoBan.Columns[2].Width = 100;
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
            try { 
            if (chon == 1) //Them
            {
                if (cn.LoadData1("XemNK", "@MaNK",textMaNK.Text).Rows.Count > 0)
                    MessageBox.Show("Giao ban đã có trong danh sách");
                else
                {
                    if (comboBoxMaNV.Text == "" || dateTimePickerThoiGian.Text == "" || richTextBoxNoiDung.Text == "" )
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    else
                    {
                        giaoBan.GiaoBan_DB("ThemNK", textMaNK.Text, comboBoxMaNV.Text, dateTimePickerThoiGian.Text, richTextBoxNoiDung.Text);
                        MessageBox.Show("Thêm thành công");
                        frmGiaoBan_Load(sender, e);
                    }
                }

            }
            else if (chon == 2) //Sua
            {
                if (cn.LoadData1("XemNK", "@MaNK", textMaNK.Text).Rows.Count == 0)
                    MessageBox.Show("Giao ban này chưa có trong danh sách");
                else
                {
                    if (comboBoxMaNV.Text == "" || dateTimePickerThoiGian.Text == "" || richTextBoxNoiDung.Text == "")
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa thời khoá biểu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            giaoBan.GiaoBan_DB("SuaNK", textMaNK.Text, comboBoxMaNV.Text, dateTimePickerThoiGian.Text, richTextBoxNoiDung.Text);
                            MessageBox.Show("Sửa thành công");
                            frmGiaoBan_Load(sender, e);
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

        public void HienThi_MaNV()
        {
            comboBoxMaNV.DataSource = cn.LoadData("HienThi_NhanVien");
            comboBoxMaNV.DisplayMember = "MaNV";
            comboBoxMaNV.ValueMember = "MaNV";
            comboBoxMaNV.SelectedValue = "MaNV";
            comboBoxMaNV.SelectedIndex = 0;

        }
    }
}
