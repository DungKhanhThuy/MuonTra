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
    public partial class frmSuCo : Form
    {
        public frmSuCo()
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

        ClassSuCo suCo = new ClassSuCo();
        int chon;
        ConnectDB cn = new ConnectDB();


        public void KhoiTao()
        {
            textMaSC.Enabled = comboBoxMaYC.Enabled  = richTextBoxSuCo.Enabled = richTextBoxXuLy.Enabled = false;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = true;
            buttonLuu.Enabled = buttonHuy.Enabled = false;
        }

        //Mo cac button enable
        public void Mo()
        {
            textMaSC.Enabled = comboBoxMaYC.Enabled =  richTextBoxSuCo.Enabled = richTextBoxXuLy.Enabled = true;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = false;
            buttonLuu.Enabled = buttonHuy.Enabled = true;
        }

        public void SetNull()
        {
            textMaSC.Text = comboBoxMaYC.Text = comboBoxMaTB.Text = richTextBoxSuCo.Text = richTextBoxXuLy.Text = "";
        }



        private void dataGridViewSuCo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textMaSC.Text = dataGridViewSuCo.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBoxMaYC.Text = dataGridViewSuCo.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBoxMaTB.Text = dataGridViewSuCo.Rows[e.RowIndex].Cells[2].Value.ToString();
                richTextBoxSuCo.Text = dataGridViewSuCo.Rows[e.RowIndex].Cells[3].Value.ToString();
                richTextBoxXuLy.Text = dataGridViewSuCo.Rows[e.RowIndex].Cells[4].Value.ToString();

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
                DataTable dt = cn.LoadData("HienThi_SuCo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            frmSuCo_Load(sender, e);
            SetNull();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Mo();
            textMaSC.Enabled = false;

            chon = 2;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.LoadData1("XemSC", "@MaSC", textMaSC.Text).Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy sự cố này");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        cn.LoadData1("XoaSC", "@MaSC", textMaSC.Text);
                        MessageBox.Show("Xóa thành công!");
                        frmSuCo_Load(sender, e);
                        SetNull();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmSuCo_Load(object sender, EventArgs e)
        {
            try
            {
                KhoiTao();
                dataGridViewSuCo.DataSource = suCo.Show();
                HienThi_MaYC();
                HienThi_MaTB(comboBoxMaYC.Text);
                
                dataGridViewSuCo.Columns[0].Width = 60;
                dataGridViewSuCo.Columns[1].Width = 60;
                dataGridViewSuCo.Columns[2].Width = 100;
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
                    if (cn.LoadData1("XemSC", "@MaSC", textMaSC.Text).Rows.Count > 0)
                        MessageBox.Show("sự cố đã có trong danh sách");
                    else
                    {
                        if (comboBoxMaYC.Text == "" || comboBoxMaTB.Text == "" || richTextBoxSuCo.Text == "" || richTextBoxXuLy.Text == "")
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        else
                        {
                            suCo.SuCo_DB("ThemSC", textMaSC.Text, comboBoxMaYC.Text, comboBoxMaTB.Text, richTextBoxSuCo.Text, richTextBoxXuLy.Text);
                            MessageBox.Show("Thêm thành công");
                            frmSuCo_Load(sender, e);
                        }
                    }

                }
                else if (chon == 2) //Sua
                {
                    if (cn.LoadData1("XemSC", "@MaSC", textMaSC.Text).Rows.Count == 0)
                        MessageBox.Show("sự cố này chưa có trong danh sách");
                    else
                    {
                        if (comboBoxMaYC.Text == "" || comboBoxMaTB.Text == "" || richTextBoxSuCo.Text == "" || richTextBoxXuLy.Text == "")
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        else
                        {
                            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa thời khoá biểu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                suCo.SuCo_DB("SuaSC", textMaSC.Text, comboBoxMaYC.Text, comboBoxMaTB.Text, richTextBoxSuCo.Text, richTextBoxXuLy.Text);
                                MessageBox.Show("Sửa thành công");
                                frmSuCo_Load(sender, e);
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

        public void HienThi_MaYC()
        {
            comboBoxMaYC.DataSource = cn.LoadData("HienThi_YeuCau");
            comboBoxMaYC.DisplayMember = "MaYC";
            comboBoxMaYC.ValueMember = "MaYC";
            comboBoxMaYC.SelectedValue = "MaYC";
            comboBoxMaYC.SelectedIndex = 0;
        }

        public void HienThi_MaTB(string mayc)
        {
            comboBoxMaTB.DataSource = cn.LoadData1("HienThi_CTYC", "@mayc", mayc);
            comboBoxMaTB.DisplayMember = "MaTB";
            comboBoxMaTB.ValueMember = "MaTB";
            comboBoxMaTB.SelectedValue = "MaTB";
            comboBoxMaTB.SelectedIndex = 0;
        }

        private void comboBoxMaYC_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMaYC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxMaTB.Enabled = true;
                HienThi_MaTB(comboBoxMaYC.Text);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
