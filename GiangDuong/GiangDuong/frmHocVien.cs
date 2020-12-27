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
    public partial class frmHocVien : Form
    {
        public frmHocVien()
        {
            InitializeComponent();
            HienThi_MaHV();
        }

        HocVien hv = new HocVien();
        int chon;
        ConnectDB cn = new ConnectDB();

        
        public void KhoiTao()
        {
            textMaHV.Enabled = textTenHV.Enabled = comboBoxMaLop.Enabled = textTenLop.Enabled = textSDT.Enabled = textDonVi.Enabled = false;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = true;
            buttonLuu.Enabled = buttonHuy.Enabled = false;
        }

        //Mo cac button enable
        public void Mo()
        {
            textMaHV.Enabled = textTenHV.Enabled = comboBoxMaLop.Enabled = textTenLop.Enabled = textSDT.Enabled = textDonVi.Enabled = true;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = false;
            buttonLuu.Enabled = buttonHuy.Enabled = true;
        }

        public void SetNull()
        {
            textMaHV.Text = textTenHV.Text = comboBoxMaLop.Text = textTenLop.Text = textSDT.Text = textDonVi.Text = "";
        }



        private void dataGridViewHocVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textMaHV.Text = dataGridViewHocVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                textTenHV.Text = dataGridViewHocVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                textTenLop.Text = dataGridViewHocVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                textSDT.Text = dataGridViewHocVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                textDonVi.Text = dataGridViewHocVien.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
            catch
            { }
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            Mo();
            SetNull();
            chon = 1;
            DataTable dt = cn.LoadData("HienThi_Lop");
            comboBoxMaLop.Text = dt.Rows[0][0].ToString();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            frmHocVien_Load(sender, e);
            SetNull();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Mo();
            textMaHV.Enabled = false;
            chon = 2;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.LoadData1("XemHocVien", "@MaHV", textMaHV.Text).Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy Học viên này");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        cn.Xoa("XoaHocVien","@MaHV", textMaHV.Text);
                        MessageBox.Show("Xóa thành công!");
                        frmHocVien_Load(sender, e);
                        SetNull();
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmHocVien_Load(object sender, EventArgs e)
        {
            KhoiTao();
            dataGridViewHocVien.DataSource = hv.Show();

            

            chon = 0;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1) //Them
            {
                if (cn.LoadData1("XemHocVien", "@MaHV", textMaHV.Text).Rows.Count > 0)
                    MessageBox.Show("Mã học viên đã có trong danh sách");
                else
                {
                    if (textTenHV.Text == "" || comboBoxMaLop.Text == "" || textTenLop.Text == "" || textSDT.Text == "" || textDonVi.Text == "")
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    else
                    {
                        hv.ThemHocVien(textMaHV.Text, textTenHV.Text, textDonVi.Text, textSDT.Text, comboBoxMaLop.Text);
                        MessageBox.Show("Thêm thành công");
                        frmHocVien_Load(sender, e);
                    }
                }
                
            }
            else if (chon == 2) //Sua
            {
                if (textTenHV.Text == "" || comboBoxMaLop.Text == "" || textTenLop.Text == "" || textSDT.Text == "" || textDonVi.Text == "")
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa học viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        hv.SuaHocVien(textMaHV.Text, textTenHV.Text, textDonVi.Text, textSDT.Text, comboBoxMaLop.Text);
                        MessageBox.Show("Sửa thành công");
                        frmHocVien_Load(sender, e);
                    }
                }
            }
        }

        public void HienThi_MaHV()
        {
            comboBoxMaLop.DataSource = cn.LoadData("HienThi_Lop");
            comboBoxMaLop.DisplayMember = "MaLop";
            comboBoxMaLop.ValueMember = "TenLop";
            comboBoxMaLop.SelectedValue = "MaLop";
            comboBoxMaLop.SelectedIndex = 0;

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

        

        

        private void comboBoxMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectDB cn = new ConnectDB();

            textTenLop.Text = cn.LoadData1("HienThi_TenLop", "MaLop", comboBoxMaLop.Text).ToString();
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
