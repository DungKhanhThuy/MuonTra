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
    public partial class frmThietBi : Form
    {
        public frmThietBi()
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



        ClassThietBi thietBi = new ClassThietBi();
        int chon;
        ConnectDB cn = new ConnectDB();


        public void KhoiTao()
        {
            textMaTB.Enabled = textTenTB.Enabled = comboBoxMaLoai.Enabled = textTinhTrang.Enabled = comboBoxMaPhong.Enabled = false;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = true;
            buttonLuu.Enabled = buttonHuy.Enabled = false;
        }

        //Mo cac button enable
        public void Mo()
        {
            textMaTB.Enabled = textTenTB.Enabled = comboBoxMaLoai.Enabled = textTinhTrang.Enabled = comboBoxMaPhong.Enabled = true;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = false;
            buttonLuu.Enabled = buttonHuy.Enabled = true;
        }

        public void SetNull()
        {
            textMaTB.Text = textTenTB.Text = comboBoxMaLoai.Text = textTenLoai.Text = textTinhTrang.Text = comboBoxMaPhong.Text = "";
        }



        private void dataGridViewThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textMaTB.Text = dataGridViewThietBi.Rows[e.RowIndex].Cells[0].Value.ToString();
                textTenTB.Text = dataGridViewThietBi.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBoxMaLoai.Text = dataGridViewThietBi.Rows[e.RowIndex].Cells[2].Value.ToString();
                textTenLoai.Text = dataGridViewThietBi.Rows[e.RowIndex].Cells[3].Value.ToString();
                textTinhTrang.Text = dataGridViewThietBi.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboBoxMaPhong.Text = dataGridViewThietBi.Rows[e.RowIndex].Cells[5].Value.ToString();
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
                DataTable dt = cn.LoadData("HienThi_ThietBi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            frmThietBi_Load(sender, e);
            SetNull();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Mo();
            textMaTB.Enabled = false;
            chon = 2;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxMaPhong.Text == "")
                {
                    if (cn.LoadData1("XemTB", "@MaTB", textMaTB.Text).Rows.Count == 0)
                        MessageBox.Show("Không tìm thấy thiết bị");
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            cn.LoadData1("XoaTB", "@MaTB", textMaTB.Text);
                            MessageBox.Show("Xóa thành công!");
                            frmThietBi_Load(sender, e);
                            SetNull();
                        }
                    }
                }
                else
                {
                    if (cn.LoadData1("XemTB", "@MaTB", textMaTB.Text).Rows.Count == 0)
                        MessageBox.Show("Không tìm thấy thiết bị");
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            cn.LoadData2("XoaTB1", "@MaTB", "@MaPhong", textMaTB.Text, comboBoxMaPhong.Text);
                            MessageBox.Show("Xóa thành công!");
                            frmThietBi_Load(sender, e);
                            SetNull();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmThietBi_Load(object sender, EventArgs e)
        {
            try
            {
                KhoiTao();

                HienThi_MaLoai();
                HienThi_MaPhong();
                dataGridViewThietBi.DataSource = thietBi.Show();
                //dataGridViewThietBi.Columns[0].Width = 100;



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
                    if (cn.LoadData1("XemTB", "@MaTB", textMaTB.Text).Rows.Count > 0)
                        MessageBox.Show("Thiết bị đã có trong danh sách");
                    else
                    {
                        if (textTenTB.Text == "" || textTenLoai.Text == "" || textTinhTrang.Text == "")
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        else
                        {
                            if (comboBoxMaPhong.Text == "")

                                thietBi.TB_DB("ThemTB", textMaTB.Text, textTenTB.Text, comboBoxMaLoai.Text, textTinhTrang.Text);
                            else
                                cn.LoadData5("ThemTB1", "@MaTB", "@TenTB", "@MaLoai", "@TinhTrang", "@MaPhong",
                                textMaTB.Text, textTenTB.Text, comboBoxMaLoai.Text, textTinhTrang.Text, comboBoxMaPhong.Text);

                            MessageBox.Show("Thêm thành công");
                            frmThietBi_Load(sender, e);
                        }
                    }

                }
                else if (chon == 2) //Sua
                {
                    if (cn.LoadData1("XemTB", "@MaTB", textMaTB.Text).Rows.Count == 0)
                        MessageBox.Show("Thiết bị này chưa có trong danh sách");
                    else
                    {
                        if (textTenTB.Text == "" || textTenLoai.Text == "" || textTinhTrang.Text == "")
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        else
                        {
                            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa thiết bị này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                if (comboBoxMaPhong.Text == "")
                                    thietBi.TB_DB("SuaTB", textMaTB.Text, textTenTB.Text, comboBoxMaLoai.Text, textTinhTrang.Text);
                                else
                                {
                                    try
                                    {
                                        cn.LoadData5("SuaTB2", "@MaTB", "@TenTB", "@MaLoai", "@TinhTrang", "@MaPhong",
                                                                                textMaTB.Text, textTenTB.Text, comboBoxMaLoai.Text, textTinhTrang.Text, comboBoxMaPhong.Text);
                                    }
                                    catch (Exception)
                                    {
                                        cn.LoadData5("SuaTB1", "@MaTB", "@TenTB", "@MaLoai", "@TinhTrang", "@MaPhong",
                                                                                textMaTB.Text, textTenTB.Text, comboBoxMaLoai.Text, textTinhTrang.Text, comboBoxMaPhong.Text);
                                    }
                                }
                                MessageBox.Show("Sửa thành công");
                                frmThietBi_Load(sender, e);
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
        public void HienThi_MaLoai()
        {
            comboBoxMaLoai.DataSource = cn.LoadData("HienThi_Loai");
            comboBoxMaLoai.DisplayMember = "MaLoai";
            comboBoxMaLoai.ValueMember = "MaLoai";
            comboBoxMaLoai.SelectedValue = "MaLoai";
            comboBoxMaLoai.SelectedIndex = 0;

        }

        public void HienThi_MaPhong()
        {
            //comboBoxMaPhong.DataSource = cn.LoadData("HienThi_Phong");
            //comboBoxMaPhong.DisplayMember = "MaPhong";
            //comboBoxMaPhong.ValueMember = "MaPhong";
            //comboBoxMaPhong.SelectedValue = "MaPhong";
            //comboBoxMaPhong.SelectedIndex = 0;
            ////comboBoxMaPhong.SelectedItem = -1;

            //comboBoxMaPhong.ResetText();

            ////to reset selected value
            //comboBoxMaPhong.SelectedIndex = -1;
            //comboBoxMaPhong.Items.Add("Tokyo");






            DataTable dt = new DataTable();

            dt = cn.LoadData("HienThi_Phong");

            //dt.Columns.Add("ID", typeof(int));
            //dt.Columns.Add("CategoryName");

            DataRow dr = dt.NewRow();
            dr["MaPhong"] = "";
            //dr["ID"] = 0;

            dt.Rows.InsertAt(dr, 0);

            //cmbCategory.DisplayMember = "CategoryName";
            //cmbCategory.ValueMember = "ID";
            //cmbCategory.DataSource = dt;
            //cmbCategory.SelectedIndex = 0;

            comboBoxMaPhong.DataSource = dt;
            comboBoxMaPhong.DisplayMember = "MaPhong";
            comboBoxMaPhong.ValueMember = "MaPhong";
            comboBoxMaPhong.SelectedValue = "MaPhong";
            comboBoxMaPhong.SelectedIndex = 0;

        }
        private void comboBoxMaLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = cn.LoadData1("XemLoai", "@MaLoai", comboBoxMaLoai.Text);
                if (dt.Rows.Count != 0)
                {
                    if (comboBoxMaLoai.SelectedItem != null)
                    {
                        textTenLoai.Text = dt.Rows[0][1].ToString();
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
