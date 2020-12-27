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
        }

        HocVien hv = new HocVien();
        int chon;

        public void KhoiTao()
        {
            textMaHV.Enabled = textTenHV.Enabled = textMaLop.Enabled = textTenLop.Enabled = textSDT.Enabled = textDonVi.Enabled = false;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = true;
            buttonLuu.Enabled = buttonHuy.Enabled = false;
        }

        //Mo cac button enable
        public void Mo()
        {
            textMaHV.Enabled = textTenHV.Enabled = textMaLop.Enabled = textTenLop.Enabled = textSDT.Enabled = textDonVi.Enabled = true;
            buttonThem.Enabled = buttonSua.Enabled = buttonXoa.Enabled = false;
            buttonLuu.Enabled = buttonHuy.Enabled = true;
        }

        public void SetNull()
        {
            textMaHV.Text = textTenHV.Text = textMaLop.Text = textTenLop.Text = textSDT.Text = textDonVi.Text = "";
        }



        private void dataGridViewHocVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textMaHV.Text = dataGridViewHocVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                textTenHV.Text = dataGridViewHocVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                textTenLop.Text = dataGridViewHocVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                textDonVi.Text = dataGridViewHocVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                textSDT.Text = dataGridViewHocVien.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
            catch
            { }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Mo();
            textMaHV.Enabled = false;
            chon = 1;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                hv.XoaHocVien(textMaHV.Text);
                MessageBox.Show("Xóa thành công!");
                frmHocVien_Load(sender, e);
                SetNull();
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
            if(chon == 1)
            {
                if (textTenHV.Text == "" || textMaLop.Text == "" || textTenLop.Text == "" || textSDT.Text == "" || textDonVi.Text == "")
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                else
                {
                    if(DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa học viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        hv.SuaHocVien(textMaHV.Text, textTenHV.Text, textDonVi.Text, textSDT.Text, textMaLop.Text);
                        MessageBox.Show("Sửa thành công");
                        frmHocVien_Load(sender, e);
                    }    
                }    
            }
            else if(chon == 2)
            {
                if (textTenHV.Text == "" || textMaLop.Text == "" || textTenLop.Text == "" || textSDT.Text == "" || textDonVi.Text == "")
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm học viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        hv.ThemHocVien(textMaHV.Text, textTenHV.Text, textDonVi.Text, textSDT.Text, textMaLop.Text);
                        MessageBox.Show("Thêm thành công");
                        SetNull();
                        frmHocVien_Load(sender, e);
                    }
                }
            }    
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            Mo();
            SetNull();
            chon = 2;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            frmHocVien_Load(sender, e);
            SetNull();
        }
    }
}
