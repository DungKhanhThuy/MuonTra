namespace GiangDuong
{
    partial class frmLoai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mượnTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thờiKhoáBiểuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.họcViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sựCốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewNguoiDung = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textTenLoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.textMaLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mượnTrảToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.giaoBanToolStripMenuItem,
            this.sựCốToolStripMenuItem,
            this.ngườiDùngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mượnTrảToolStripMenuItem
            // 
            this.mượnTrảToolStripMenuItem.Name = "mượnTrảToolStripMenuItem";
            this.mượnTrảToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.mượnTrảToolStripMenuItem.Text = "Mượn trả";
            this.mượnTrảToolStripMenuItem.Click += new System.EventHandler(this.mượnTrảToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lịchSửToolStripMenuItem,
            this.thờiKhoáBiểuToolStripMenuItem,
            this.thiếtBịToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.họcViênToolStripMenuItem,
            this.phòngToolStripMenuItem,
            this.lớpToolStripMenuItem,
            this.loạiToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // lịchSửToolStripMenuItem
            // 
            this.lịchSửToolStripMenuItem.Name = "lịchSửToolStripMenuItem";
            this.lịchSửToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.lịchSửToolStripMenuItem.Text = "Lịch sử";
            this.lịchSửToolStripMenuItem.Click += new System.EventHandler(this.lịchSửToolStripMenuItem_Click);
            // 
            // thờiKhoáBiểuToolStripMenuItem
            // 
            this.thờiKhoáBiểuToolStripMenuItem.Name = "thờiKhoáBiểuToolStripMenuItem";
            this.thờiKhoáBiểuToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.thờiKhoáBiểuToolStripMenuItem.Text = "Thời khoá biểu";
            this.thờiKhoáBiểuToolStripMenuItem.Click += new System.EventHandler(this.thờiKhoáBiểuToolStripMenuItem_Click);
            // 
            // thiếtBịToolStripMenuItem
            // 
            this.thiếtBịToolStripMenuItem.Name = "thiếtBịToolStripMenuItem";
            this.thiếtBịToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.thiếtBịToolStripMenuItem.Text = "Thiết bị";
            this.thiếtBịToolStripMenuItem.Click += new System.EventHandler(this.thiếtBịToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // họcViênToolStripMenuItem
            // 
            this.họcViênToolStripMenuItem.Name = "họcViênToolStripMenuItem";
            this.họcViênToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.họcViênToolStripMenuItem.Text = "Học viên";
            this.họcViênToolStripMenuItem.Click += new System.EventHandler(this.họcViênToolStripMenuItem_Click);
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.phòngToolStripMenuItem.Text = "Phòng";
            this.phòngToolStripMenuItem.Click += new System.EventHandler(this.phòngToolStripMenuItem_Click);
            // 
            // lớpToolStripMenuItem
            // 
            this.lớpToolStripMenuItem.Name = "lớpToolStripMenuItem";
            this.lớpToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.lớpToolStripMenuItem.Text = "Lớp";
            this.lớpToolStripMenuItem.Click += new System.EventHandler(this.lớpToolStripMenuItem_Click);
            // 
            // loạiToolStripMenuItem
            // 
            this.loạiToolStripMenuItem.Name = "loạiToolStripMenuItem";
            this.loạiToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.loạiToolStripMenuItem.Text = "Loại";
            this.loạiToolStripMenuItem.Click += new System.EventHandler(this.loạiToolStripMenuItem_Click);
            // 
            // giaoBanToolStripMenuItem
            // 
            this.giaoBanToolStripMenuItem.Name = "giaoBanToolStripMenuItem";
            this.giaoBanToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.giaoBanToolStripMenuItem.Text = "Giao ban";
            this.giaoBanToolStripMenuItem.Click += new System.EventHandler(this.giaoBanToolStripMenuItem_Click);
            // 
            // sựCốToolStripMenuItem
            // 
            this.sựCốToolStripMenuItem.Name = "sựCốToolStripMenuItem";
            this.sựCốToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.sựCốToolStripMenuItem.Text = "Sự cố";
            this.sựCốToolStripMenuItem.Click += new System.EventHandler(this.sựCốToolStripMenuItem_Click);
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            this.ngườiDùngToolStripMenuItem.Click += new System.EventHandler(this.ngườiDùngToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewNguoiDung, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.73109F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1026, 595);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridViewNguoiDung
            // 
            this.dataGridViewNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNguoiDung.Location = new System.Drawing.Point(3, 229);
            this.dataGridViewNguoiDung.Name = "dataGridViewNguoiDung";
            this.dataGridViewNguoiDung.ReadOnly = true;
            this.dataGridViewNguoiDung.RowHeadersWidth = 51;
            this.dataGridViewNguoiDung.RowTemplate.Height = 24;
            this.dataGridViewNguoiDung.Size = new System.Drawing.Size(1020, 363);
            this.dataGridViewNguoiDung.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.textTenLoai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonHuy);
            this.panel1.Controls.Add(this.buttonLuu);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.buttonSua);
            this.panel1.Controls.Add(this.buttonThem);
            this.panel1.Controls.Add(this.textMaLoai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(220, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 220);
            this.panel1.TabIndex = 0;
            // 
            // textTenLoai
            // 
            this.textTenLoai.Location = new System.Drawing.Point(458, 78);
            this.textTenLoai.Name = "textTenLoai";
            this.textTenLoai.Size = new System.Drawing.Size(100, 22);
            this.textTenLoai.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên loại";
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(469, 151);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(71, 48);
            this.buttonHuy.TabIndex = 6;
            this.buttonHuy.Text = "Huỷ";
            this.buttonHuy.UseVisualStyleBackColor = true;
            // 
            // buttonLuu
            // 
            this.buttonLuu.Location = new System.Drawing.Point(364, 151);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(71, 48);
            this.buttonLuu.TabIndex = 5;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(259, 151);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(71, 48);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Xoá";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(154, 151);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(71, 48);
            this.buttonSua.TabIndex = 1;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(49, 151);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(71, 48);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // textMaLoai
            // 
            this.textMaLoai.Location = new System.Drawing.Point(154, 76);
            this.textMaLoai.Name = "textMaLoai";
            this.textMaLoai.Size = new System.Drawing.Size(100, 22);
            this.textMaLoai.TabIndex = 3;
            this.textMaLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại";
            // 
            // frmLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 641);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin Loại thiết bị";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mượnTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thờiKhoáBiểuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thiếtBịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem họcViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sựCốToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewNguoiDung;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textMaLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.TextBox textTenLoai;
        private System.Windows.Forms.Label label1;
    }
}