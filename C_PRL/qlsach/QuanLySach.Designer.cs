namespace C_PRL
{
    partial class FormQLSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLSach));
            dataGridView1 = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            NamXuatBan = new DataGridViewTextBoxColumn();
            TacGia = new DataGridViewTextBoxColumn();
            TheLoai = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            btnThem = new Button();
            label1 = new Label();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { stt, ID, Ten, Gia, NamXuatBan, TacGia, TheLoai, SoLuong });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.DarkGray;
            dataGridView1.Location = new Point(12, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1069, 254);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // stt
            // 
            stt.FillWeight = 30F;
            stt.HeaderText = "Stt";
            stt.MinimumWidth = 40;
            stt.Name = "stt";
            stt.ReadOnly = true;
            // 
            // ID
            // 
            ID.FillWeight = 50F;
            ID.HeaderText = "Barcode";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Ten
            // 
            Ten.FillWeight = 80F;
            Ten.HeaderText = "Tên sách";
            Ten.Name = "Ten";
            Ten.ReadOnly = true;
            // 
            // Gia
            // 
            Gia.FillWeight = 60F;
            Gia.HeaderText = "Giá";
            Gia.Name = "Gia";
            Gia.ReadOnly = true;
            // 
            // NamXuatBan
            // 
            NamXuatBan.FillWeight = 60F;
            NamXuatBan.HeaderText = "Năm xuất bản";
            NamXuatBan.Name = "NamXuatBan";
            NamXuatBan.ReadOnly = true;
            // 
            // TacGia
            // 
            TacGia.HeaderText = "Tác giả";
            TacGia.Name = "TacGia";
            TacGia.ReadOnly = true;
            // 
            // TheLoai
            // 
            TheLoai.HeaderText = "Thể loại";
            TheLoai.Name = "TheLoai";
            TheLoai.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.FillWeight = 50F;
            SoLuong.HeaderText = "Số lượng sách";
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(855, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 23);
            textBox1.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 96);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(127, 23);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm thông tin sách";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(793, 100);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Tìm kiếm: ";
            // 
            // FormQLSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1093, 392);
            Controls.Add(label1);
            Controls.Add(btnThem);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormQLSach";
            Text = "Quản lý thư viện";
            Load += QuanLySach_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn NamXuatBan;
        private DataGridViewTextBoxColumn TacGia;
        private DataGridViewTextBoxColumn TheLoai;
        private DataGridViewTextBoxColumn SoLuong;
        private TextBox textBox1;
        private Button btnThem;
        private Label label1;
    }
}