namespace C_PRL
{
    partial class QuanLySachChiTiet
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            Barcode = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewTextBoxColumn();
            LanTaiBan = new DataGridViewTextBoxColumn();
            NamTaiBan = new DataGridViewTextBoxColumn();
            KichCo = new DataGridViewTextBoxColumn();
            DiemUyTin = new DataGridViewTextBoxColumn();
            NhaXuatBan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { stt, Barcode, TinhTrang, LanTaiBan, NamTaiBan, KichCo, DiemUyTin, NhaXuatBan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.DarkGray;
            dataGridView1.Location = new Point(12, 245);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(987, 254);
            dataGridView1.TabIndex = 1;
            // 
            // stt
            // 
            stt.FillWeight = 30F;
            stt.HeaderText = "Stt";
            stt.MinimumWidth = 40;
            stt.Name = "stt";
            stt.ReadOnly = true;
            // 
            // Barcode
            // 
            Barcode.HeaderText = "Barcode Id";
            Barcode.Name = "Barcode";
            Barcode.ReadOnly = true;
            // 
            // TinhTrang
            // 
            TinhTrang.HeaderText = "Tình trạng sách";
            TinhTrang.Name = "TinhTrang";
            TinhTrang.ReadOnly = true;
            // 
            // LanTaiBan
            // 
            LanTaiBan.HeaderText = "Lần tái bản";
            LanTaiBan.Name = "LanTaiBan";
            LanTaiBan.ReadOnly = true;
            // 
            // NamTaiBan
            // 
            NamTaiBan.HeaderText = "Năm tái bản";
            NamTaiBan.Name = "NamTaiBan";
            NamTaiBan.ReadOnly = true;
            // 
            // KichCo
            // 
            KichCo.HeaderText = "Kích cỡ";
            KichCo.Name = "KichCo";
            KichCo.ReadOnly = true;
            // 
            // DiemUyTin
            // 
            DiemUyTin.HeaderText = "Điểm uy tín";
            DiemUyTin.Name = "DiemUyTin";
            DiemUyTin.ReadOnly = true;
            // 
            // NhaXuatBan
            // 
            NhaXuatBan.FillWeight = 200F;
            NhaXuatBan.HeaderText = "Nhà xuất bản";
            NhaXuatBan.Name = "NhaXuatBan";
            NhaXuatBan.ReadOnly = true;
            // 
            // QuanLySachChiTiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 511);
            Controls.Add(dataGridView1);
            Name = "QuanLySachChiTiet";
            Text = "QuanLySachChiTiet";
            Load += QuanLySachChiTiet_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn TinhTrang;
        private DataGridViewTextBoxColumn LanTaiBan;
        private DataGridViewTextBoxColumn NamTaiBan;
        private DataGridViewTextBoxColumn KichCo;
        private DataGridViewTextBoxColumn DiemUyTin;
        private DataGridViewTextBoxColumn NhaXuatBan;
    }
}