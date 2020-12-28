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
    public partial class frmMuonTra : Form
    {
        public frmMuonTra()
        {
            InitializeComponent();
        }

        YeuCau yc = new YeuCau();
        HocVien hv = new HocVien();
        ClassNhanVien nv = new ClassNhanVien();
        int chon;
        ConnectDB cn = new ConnectDB();

        public void KhoiTao_YeuCau()
        {
            textMaYC.Enabled = textMaHV.Enabled = textTenHV.Enabled = textMaNV.Enabled = textTenNV.Enabled = textTGMuon.Enabled = textTGTra.Enabled = textGhiChu.Enabled = false;
            buttonThemYC.Enabled = buttonSuaYC.Enabled = buttonXoaYC.Enabled = true;
            buttonLuuYC.Enabled = buttonHuyYC.Enabled = false;
        }

        //Mo cac button enable
        public void Mo_YeuCau()
        {
            textMaYC.Enabled = textMaHV.Enabled = textTenHV.Enabled = textMaNV.Enabled = textTenNV.Enabled = textTGMuon.Enabled = textTGTra.Enabled = textGhiChu.Enabled = true;
            buttonThemYC.Enabled = buttonSuaYC.Enabled = buttonXoaYC.Enabled = false;
            buttonLuuYC.Enabled = buttonHuyYC.Enabled = true;
        }

        public void SetNull_YeuCau()
        {
            textMaYC.Text = textMaHV.Text = textTenHV.Text = textMaNV.Text = textTenNV.Text = textTGMuon.Text = textTGTra.Text = textGhiChu.Text = "";
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
            frmNguoiDung hd = new frmNguoiDung();
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
            frmLoai hd = new frmLoai();
            hd.Show();
            Hide();
        }

        private void dataGridView_YeuCau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textMaYC.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[0].Value.ToString();
                textMaHV.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[1].Value.ToString();
                textTenHV.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[2].Value.ToString();
                textMaNV.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[3].Value.ToString();
                textTenNV.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[4].Value.ToString();
                textTGMuon.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[5].Value.ToString();
                textTGTra.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[6].Value.ToString();
                textGhiChu.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch
            { }
        }

        private void buttonThemYC_Click(object sender, EventArgs e)
        {
            Mo_YeuCau();
            SetNull_YeuCau();
            chon = 1;
        }

        private void buttonSuaYC_Click(object sender, EventArgs e)
        {
            Mo_YeuCau();
            textMaYC.Enabled = false;
            chon = 2;
        }

        private void buttonXoaYC_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.LoadData1("XemYeuCau", "@MaYC", textMaYC.Text).Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy yêu cầu này");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        cn.Xoa("XoaYeuCau", "@MaYC", textMaYC.Text);
                        MessageBox.Show("Xóa thành công!");
                        frmMuonTra_Load(sender, e);
                        SetNull_YeuCau();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMuonTra_Load(object sender, EventArgs e)
        {
            KhoiTao_YeuCau();
            dataGridView_YeuCau.DataSource = yc.Show();
            chon = 0;
        }

        private void buttonLuuYC_Click(object sender, EventArgs e)
        {
            if (chon == 1) //Them
            {
                if (cn.LoadData1("XemYeuCau", "@MaYC", textMaYC.Text).Rows.Count > 0)
                    MessageBox.Show("Mã yêu cầu này đã có trong danh sách");
                else
                {
                    if (textMaHV.Text == "" || textTenHV.Text == "" || textMaNV.Text == "" || textTenNV.Text == "" || textTGMuon.Text == "" || textTGTra.Text == "" || textGhiChu.Text == "")
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    else
                    {
                        yc.YeuCau_DB("ThemYeuCau", textMaYC.Text, textMaHV.Text, textMaNV.Text, Convert.ToDateTime(textTGMuon.Text), Convert.ToDateTime(textTGTra.Text), textGhiChu.Text);
                        MessageBox.Show("Thêm thành công");
                        frmMuonTra_Load(sender, e);
                    }
                }

            }
            else if (chon == 2) //Sua
            {
                if (cn.LoadData1("XemYeuCau", "@MaYC", textMaYC.Text).Rows.Count == 0)
                    MessageBox.Show("Yêu cầu chưa có trong danh sách");
                else
                {
                    if (textMaHV.Text == "" || textTenHV.Text == "" || textMaNV.Text == "" || textTenNV.Text == "" || textTGMuon.Text == "" || textTGTra.Text == "" || textGhiChu.Text == "")
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa yêu cầu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            yc.YeuCau_DB("SuaYeuCau", textMaYC.Text, textMaHV.Text, textMaNV.Text, Convert.ToDateTime(textTGMuon.Text), Convert.ToDateTime(textTGTra.Text), textGhiChu.Text);
                            MessageBox.Show("Sửa thành công");
                            frmMuonTra_Load(sender, e);
                        }
                    }
                }
            }

        }

        

        private void textMaHV_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textMaYC_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textMaHV_KeyDown(object sender, KeyEventArgs e)
        {
            //try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    DataTable dt = cn.LoadData1("HienThi_HocVien", "@MaHV", textMaHV.Text);
                    if (dt.Rows.Count != 0)
                    {
                        textTenHV.Text = dt.Rows[0][1].ToString();
                    }
                }    
                
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
