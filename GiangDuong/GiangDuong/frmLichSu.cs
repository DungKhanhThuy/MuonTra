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
    public partial class frmLichSu : Form
    {
        public frmLichSu()
        {
            InitializeComponent();
        }

        ConnectDB cn = new ConnectDB();
        LichSu ls = new LichSu();

        #region menustrip
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
        #endregion

        private void frmLichSu_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewLichSu.DataSource = ls.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewLichSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMaLS.Text = dataGridViewLichSu.Rows[e.RowIndex].Cells[0].Value.ToString();
            textTenBang.Text = dataGridViewLichSu.Rows[e.RowIndex].Cells[1].Value.ToString();
            textNhanVien.Text = dataGridViewLichSu.Rows[e.RowIndex].Cells[4].Value.ToString();
            textThoiGian.Text = dataGridViewLichSu.Rows[e.RowIndex].Cells[5].Value.ToString();
            textKey1.Text = dataGridViewLichSu.Rows[e.RowIndex].Cells[2].Value.ToString();
            textKey2.Text = dataGridViewLichSu.Rows[e.RowIndex].Cells[3].Value.ToString();
            textNoiDung.Text = dataGridViewLichSu.Rows[e.RowIndex].Cells[6].Value.ToString();
            textNdCu.Text = dataGridViewLichSu.Rows[e.RowIndex].Cells[7].Value.ToString();
            textNdMoi.Text = dataGridViewLichSu.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
    }
}
