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
    public partial class frmLop : Form
    {
        public frmLop()
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

        ClassLop lop = new ClassLop();
        int chon;
        ConnectDB cn = new ConnectDB();


        public void KhoiTao()
        {
            textMaLop.Enabled = textTenLop.Enabled = false;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = true;
            buttonLuu.Enabled = buttonHuy.Enabled = false;
        }

        //Mo cac button enable
        public void Mo()
        {
            textMaLop.Enabled = textTenLop.Enabled = true;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = false;
            buttonLuu.Enabled = buttonHuy.Enabled = true;
        }

        public void SetNull()
        {
            textMaLop.Text = textTenLop.Text = "";
        }



        private void dataGridViewLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textMaLop.Text = dataGridViewLop.Rows[e.RowIndex].Cells[0].Value.ToString();
                textTenLop.Text = dataGridViewLop.Rows[e.RowIndex].Cells[1].Value.ToString();
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
            DataTable dt = cn.LoadData("HienThi_Lop");
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            frmLop_Load(sender, e);
            SetNull();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Mo();
            textMaLop.Enabled = false;
            chon = 2;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.LoadData1("XemLop", "@MaLop", textMaLop.Text).Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy Lớp này");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        cn.Xoa("XoaLop", "@MaLop", textMaLop.Text);
                        MessageBox.Show("Xóa thành công!");
                        frmLop_Load(sender, e);
                        SetNull();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            try
            {
                KhoiTao();
                dataGridViewLop.DataSource = lop.Show();
                chon = 0;
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
                    if (cn.LoadData1("XemLop", "@MaLop", textMaLop.Text).Rows.Count > 0)
                        MessageBox.Show("Mã lớp đã có trong danh sách");
                    else
                    {
                        if (textTenLop.Text == "")
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        else
                        {
                            lop.ThemLop(textMaLop.Text, textTenLop.Text);
                            MessageBox.Show("Thêm thành công");
                            frmLop_Load(sender, e);
                        }
                    }

                }
                else if (chon == 2) //Sua
                {
                    if (cn.LoadData1("XemLop", "@MaLop", textMaLop.Text).Rows.Count == 0)
                        MessageBox.Show("Mã lớp chưa có trong danh sách");
                    else
                    {
                        if (textTenLop.Text == "")
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        else
                        {
                            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa loại này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                lop.SuaLop(textMaLop.Text, textTenLop.Text);
                                MessageBox.Show("Sửa thành công");
                                frmLop_Load(sender, e);
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
    }
}
