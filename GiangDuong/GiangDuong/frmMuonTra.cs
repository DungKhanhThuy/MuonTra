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
        //public frmMuonTra()
        //{
        //    InitializeComponent();
        //}

        public delegate void SendMessage(string message);
        public SendMessage Sender; public frmMuonTra()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }

        private void GetMessage(string message)
        {
            textMaNV.Text = message;
        }


        YeuCau yc = new YeuCau();
        CTYC ct = new CTYC();
        HocVien hv = new HocVien();
        NhanVien nv = new NhanVien();
        int chon;   //chon yeu cau
        int chonctyc; //chon ctyc
        ConnectDB cn = new ConnectDB();

        public void KhoiTao_YeuCau()
        {
            textMaYC.Enabled = textMaPhong.Enabled = textMaHV.Enabled = textTenHV.Enabled = textMaNV.Enabled = textTenNV.Enabled = textTGMuon.Enabled = textTGTra.Enabled = textGhiChu.Enabled = false;
            buttonThemYC.Enabled = buttonSuaYC.Enabled = buttonXoaYC.Enabled = true;
            buttonLuuYC.Enabled = buttonHuyYC.Enabled = false;
        }

        public void KhoiTao_CTYC()
        {
            textMaYC_CTYC.Enabled = comboboxLoai.Enabled = comboboxMaTB.Enabled = textTenTB.Enabled = textTinhTrang.Enabled = checkDaTra.Enabled = false;
            buttonThem_CTYC.Enabled = buttonSua_CTYC.Enabled = buttonXoa_CTYC.Enabled = true;
            buttonLuu_CTYC.Enabled = buttonHuy_CTYC.Enabled = buttonTra.Enabled = false;
            buttonTraAll.Enabled = true;
        }

        //Mo cac button enable
        public void Mo_YeuCau()
        {
            textMaYC.Enabled = textMaPhong.Enabled = textMaHV.Enabled = textTenHV.Enabled = textMaNV.Enabled = textTenNV.Enabled = textTGMuon.Enabled = textTGTra.Enabled = textGhiChu.Enabled = true;
            buttonThemYC.Enabled = buttonSuaYC.Enabled = buttonXoaYC.Enabled = false;
            buttonLuuYC.Enabled = buttonHuyYC.Enabled = true;
        }
        public void Mo_CTYC()
        {
            textMaYC_CTYC.Enabled = comboboxLoai.Enabled = comboboxMaTB.Enabled = textTenTB.Enabled = textTinhTrang.Enabled = checkDaTra.Enabled = true;
            buttonThem_CTYC.Enabled = buttonSua_CTYC.Enabled = buttonXoa_CTYC.Enabled = false;
            buttonLuu_CTYC.Enabled = buttonHuy_CTYC.Enabled = buttonTra.Enabled = true;
        }

        public void SetNull_YeuCau()
        {
            textMaYC.Text = textMaPhong.Text = textMaHV.Text = textTenHV.Text = textTGMuon.Text= textTGTra.Text= textGhiChu.Text = "";
        }
        public void SetNull_CTYC()
        {
            textMaYC_CTYC.Text = comboboxLoai.Text = comboboxMaTB.Text = textTenTB.Text = textTinhTrang.Text = "";
            checkDaTra.Checked = false;
        }

        public void CTYC_Enable(bool check)
        {
            buttonThem_CTYC.Enabled = buttonSua_CTYC.Enabled = buttonXoa_CTYC.Enabled = buttonLuu_CTYC.Enabled = buttonHuy_CTYC.Enabled = buttonTra.Enabled = buttonTraAll.Enabled = check;
             
        }




        #region menuStrip


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

        #endregion
        private void dataGridView_YeuCau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textMaYC.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[0].Value.ToString();
                textMaPhong.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[1].Value.ToString();
                textMaHV.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[2].Value.ToString();
                textTenHV.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[3].Value.ToString();
                textMaNV.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[4].Value.ToString();
                textTenNV.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[5].Value.ToString();
                textTGMuon.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[6].Value.ToString();
                textTGTra.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[7].Value.ToString();
                textGhiChu.Text = dataGridView_YeuCau.Rows[e.RowIndex].Cells[8].Value.ToString();
                dataGridView_CTYC.DataSource = ct.Show(dataGridView_YeuCau.Rows[e.RowIndex].Cells[0].Value.ToString());
                KhoiTao_CTYC();
                load_MaYC();
                buttonTraAll.Enabled = true;
            }
            catch
            { }
        }

        private void buttonThemYC_Click(object sender, EventArgs e)
        {
            Mo_YeuCau();
            SetNull_YeuCau();
            chon = 1;
            Sender = new SendMessage(GetMessage);
            textTGMuon.Text = DateTime.Now.ToString();
            load_MaYC();
        }

        private void buttonSuaYC_Click(object sender, EventArgs e)
        {
            if (cn.LoadData1("XemYeuCau", "@MaYC", textMaYC.Text).Rows.Count == 0)
                MessageBox.Show("Yêu cầu chưa có trong danh sách");
            else
            {
                Mo_YeuCau();
                textMaYC.Enabled = false;
                chon = 2;
            }
            load_MaYC();
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
            load_TenNV(textMaNV.Text);
            dataGridView_CTYC.DataSource = ct.Show(textMaYC.Text);
            CTYC_Enable(false);
        }

        private void buttonLuuYC_Click(object sender, EventArgs e)
        {
            if (chon == 1) //Them
            {
                if (cn.LoadData1("XemYeuCau", "@MaYC", textMaYC.Text).Rows.Count > 0)
                    MessageBox.Show("Mã yêu cầu này đã có trong danh sách");
                else
                {
                    if (textMaHV.Text == "" || textTenHV.Text == "" || textMaNV.Text == "" || textTenNV.Text == "" || textTGMuon.Text == "")
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    else
                    {
                        yc.YeuCau_DB("ThemYeuCau", textMaYC.Text, textMaHV.Text, textMaNV.Text, DateTime.ParseExact(textTGMuon.Text, "MM/dd/yyyy hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture), textGhiChu.Text);
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
                    if (textMaHV.Text == "" || textTenHV.Text == "" || textMaNV.Text == "" || textTenNV.Text == "" || textTGMuon.Text == "")
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa yêu cầu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            yc.SuaYeuCau("SuaYeuCau", textMaYC.Text, textMaHV.Text, textMaNV.Text, Convert.ToDateTime(textTGMuon.Text), Convert.ToDateTime(textTGTra.Text), textGhiChu.Text);
                            MessageBox.Show("Sửa thành công");
                            frmMuonTra_Load(sender, e);
                        }
                    }
                }
            }
            load_MaYC();
        }


        private void textMaHV_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    DataTable dt = cn.LoadData1("XemHocVien", "@MaHV", textMaHV.Text);
                    if (dt.Rows.Count != 0)
                    {
                        textTenHV.Text = dt.Rows[0][1].ToString();
                    }
                }    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textMaNV_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DataTable dt = cn.LoadData1("XemNhanVien", "@MaNV", textMaNV.Text);
                    if (dt.Rows.Count != 0)
                    {
                        textTenNV.Text = dt.Rows[0][1].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonHuyYC_Click(object sender, EventArgs e)
        {
            frmMuonTra_Load(sender, e);
            SetNull_YeuCau();
            buttonThemYC.Enabled = true;
            buttonSuaYC.Enabled = true;
            buttonXoaYC.Enabled = true;
        }

        private void load_TenNV(string manv)
        {
            try
            {
                DataTable dt = cn.LoadData1("XemNhanVien", "@MaNV", textMaNV.Text);
                if (dt.Rows.Count != 0)
                {
                    textTenNV.Text = dt.Rows[0][1].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void HienThi_TenLoai(string maphong)
        {
            if (maphong == "")
                comboboxLoai.DataSource = cn.LoadData("HienThi_LoaiAll");
            else
                comboboxLoai.DataSource = cn.LoadData1("HienThi_Loai", "@MaPhong", maphong);
            comboboxLoai.DisplayMember = "TenLoai";
            comboboxLoai.ValueMember = "TenLoai";
            comboboxLoai.SelectedValue = "TenLoai";
            comboboxLoai.SelectedIndex = 0;
        }



        public void HienThi_MaTB(string TenLoai, string maphong)
        {
            comboboxMaTB.DataSource = cn.LoadData2("HienThi_MaTB", "@TenLoai", "@MaPhong", TenLoai, maphong);
            comboboxMaTB.DisplayMember = "MaTB";
            comboboxMaTB.ValueMember = "MaTB";
            comboboxMaTB.SelectedValue = "MaTB";
            comboboxMaTB.SelectedValueChanged += new System.EventHandler(comboboxMaTB_SelectedValueChanged);
            //comboboxMaTB.SelectedIndex = 0;
        }



        private void buttonThem_CTYC_Click(object sender, EventArgs e)
        {
            HienThi_TenLoai(textMaPhong.Text);
            Mo_CTYC();
            SetNull_CTYC();
            chonctyc = 1;
            load_MaYC();
            textMaYC_CTYC.Enabled = false;
        }

        private void dataGridView_CTYC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textMaYC_CTYC.Text = dataGridView_CTYC.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboboxLoai.Text = dataGridView_CTYC.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboboxMaTB.Text = dataGridView_CTYC.Rows[e.RowIndex].Cells[2].Value.ToString();
                textTenTB.Text = dataGridView_CTYC.Rows[e.RowIndex].Cells[3].Value.ToString();
                textTinhTrang.Text = dataGridView_CTYC.Rows[e.RowIndex].Cells[4].Value.ToString();
                checkDaTra.Checked = (bool)dataGridView_CTYC.Rows[e.RowIndex].Cells[5].Value;
                buttonTra.Enabled = true;
                buttonTraAll.Enabled = true;
            }
            catch
            { }
        }

        private void buttonSua_CTYC_Click(object sender, EventArgs e)
        {
            if (cn.LoadData2("XemCTYC", "@MaYC", "@MaTB", textMaYC.Text, comboboxMaTB.Text).Rows.Count == 0)
                MessageBox.Show("Chi tiết yêu cầu chưa có trong danh sách");
            else
            {
                Mo_CTYC();
                textMaYC_CTYC.Enabled = false;
                chonctyc = 2;
            }
        }

        private void buttonXoa_CTYC_Click(object sender, EventArgs e)
        {
            try
            {
                if (cn.LoadData2("XemCTYC", "@MaYC", "@MaTB", textMaYC.Text, comboboxMaTB.Text).Rows.Count == 0)
                    MessageBox.Show("Chi tiết yêu cầu chưa có trong danh sách");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        ct.Xoa_CTYC("XoaYeuCau", textMaYC.Text, comboboxMaTB.Text);
                        MessageBox.Show("Xóa thành công!");
                        frmMuonTra_Load(sender, e);
                        SetNull_CTYC();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonHuy_CTYC_Click(object sender, EventArgs e)
        {
            frmMuonTra_Load(sender, e);
            SetNull_CTYC();
            buttonThem_CTYC.Enabled = buttonSua_CTYC.Enabled = buttonXoa_CTYC.Enabled = true;
            buttonTraAll.Enabled = true;
        }

        private void comboboxLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            HienThi_MaTB(comboboxLoai.Text, textMaPhong.Text);
        }

        private void comboboxMaTB_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = cn.LoadData2("HienThi_MaTB", "@TenLoai", "@MaPhong" , comboboxLoai.Text, textMaPhong.Text);
                if (dt.Rows.Count != 0)
                {
                    if (comboboxMaTB.SelectedItem != null)
                    {
                        textTenTB.Text = dt.Rows[0][1].ToString();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void load_MaYC()
        {
            textMaYC_CTYC.Text = textMaYC.Text;
        }

        private void buttonLuu_CTYC_Click(object sender, EventArgs e)
        {
            if (chonctyc == 1) //Them
            {
                if (cn.LoadData2("XemCTYC", "@MaYC", "@MaTB", textMaYC.Text, comboboxMaTB.Text).Rows.Count > 0)
                    MessageBox.Show("Chi tiết yêu cầu này đã có trong danh sách");
                else
                {
                    if (comboboxLoai.Text == "" || comboboxMaTB.Text == "" )
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    else
                    {
                        ct.CTYC_DB("ThemCTYC", textMaYC_CTYC.Text, comboboxMaTB.Text, "false");
                        MessageBox.Show("Thêm thành công");
                        frmMuonTra_Load(sender, e);
                        Mo_CTYC();
                    }
                }

            }
            else if (chonctyc == 2) //Sua
            {
                if (cn.LoadData2("XemCTYC", "@MaYC", "@MaTB", textMaYC.Text, comboboxMaTB.Text).Rows.Count == 0)
                    MessageBox.Show("Chi tiết yêu cầu này chưa có trong danh sách");
                else
                {
                    if (comboboxLoai.Text == "" || comboboxMaTB.Text == "")
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa chi tiết yêu cầu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            ct.CTYC_DB("SuaCTYC", textMaYC_CTYC.Text, comboboxMaTB.Text, checkDaTra.Checked.ToString());
                            MessageBox.Show("Sửa thành công");
                            frmMuonTra_Load(sender, e);
                            Mo_CTYC();
                        }
                    }
                }
            }
        }

        private void buttonTra_Click(object sender, EventArgs e)
        {
            ct.CTYC_DB("SuaCTYC", textMaYC_CTYC.Text, comboboxMaTB.Text, "true");
            
            DataTable dt = cn.LoadData1("KiemTra_TraHet", "@MaYC", textMaYC_CTYC.Text);
            if(dt.Rows.Count == 0)  //Da tra het
            {
                cn.LoadData2("Update_TGTra", "@MaYC", "@TGTra", textMaYC_CTYC.Text, DateTime.Now.ToString());
                MessageBox.Show("Đã trả hết");
            }
            frmMuonTra_Load(sender, e);
            KhoiTao_CTYC();
        }

        private void buttonTraAll_Click(object sender, EventArgs e)
        {
            cn.LoadData1("TraAll", "@MaYC", textMaYC_CTYC.Text);
            DataTable dt = cn.LoadData1("KiemTra_TraHet", "@MaYC", textMaYC_CTYC.Text);
            if (dt.Rows.Count == 0)  //Da tra het
            {
                cn.LoadData2("Update_TGTra", "@MaYC", "@TGTra", textMaYC_CTYC.Text, DateTime.Now.ToString());
                MessageBox.Show("Đã trả hết");
            }
            frmMuonTra_Load(sender, e);
            KhoiTao_CTYC();
        }


    }
}
