using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace C_PRL.qlsach
{

    partial class ThemTTSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemTTSach));
            tbBarcode = new TextBox();
            btnRescan = new Button();
            label1 = new Label();
            label2 = new Label();
            tbName = new TextBox();
            label3 = new Label();
            tbGia = new TextBox();
            label4 = new Label();
            tbNXB = new DateTimePicker();
            label5 = new Label();
            tbTacgGia = new TextBox();
            cbbViTri = new ComboBox();
            label6 = new Label();
            btnThem = new Button();
            SuspendLayout();
            // 
            // tbBarcode
            // 
            tbBarcode.Location = new Point(98, 12);
            tbBarcode.MaxLength = 13;
            tbBarcode.Name = "tbBarcode";
            tbBarcode.Size = new Size(409, 23);
            tbBarcode.TabIndex = 0;
            tbBarcode.TextChanged += tbBarcode_TextChanged;
            // 
            // btnRescan
            // 
            btnRescan.Location = new Point(196, 157);
            btnRescan.Name = "btnRescan";
            btnRescan.Size = new Size(75, 23);
            btnRescan.TabIndex = 1;
            btnRescan.Text = "Rescan";
            btnRescan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 16);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Barcode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 45);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "Tên sách";
            // 
            // tbName
            // 
            tbName.Location = new Point(98, 41);
            tbName.MaxLength = 50;
            tbName.Name = "tbName";
            tbName.Size = new Size(409, 23);
            tbName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 73);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 6;
            label3.Text = "Giá";
            // 
            // tbGia
            // 
            tbGia.Location = new Point(98, 70);
            tbGia.MaxLength = 12;
            tbGia.Name = "tbGia";
            tbGia.Size = new Size(118, 23);
            tbGia.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 73);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 8;
            label4.Text = "Ngày xuất bản";
            // 
            // tbNXB
            // 
            tbNXB.CustomFormat = "dd/MM/yyyy";
            tbNXB.Format = DateTimePickerFormat.Custom;
            tbNXB.Location = new Point(336, 70);
            tbNXB.MaxDate = new DateTime(2023, 11, 29, 0, 0, 0, 0);
            tbNXB.MinDate = new DateTime(1800, 1, 1, 0, 0, 0, 0);
            tbNXB.Name = "tbNXB";
            tbNXB.Size = new Size(171, 23);
            tbNXB.TabIndex = 9;
            tbNXB.Value = new DateTime(2023, 11, 29, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 102);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 11;
            label5.Text = "Tác giả";
            // 
            // tbTacgGia
            // 
            tbTacgGia.Location = new Point(98, 99);
            tbTacgGia.MaxLength = 256;
            tbTacgGia.Name = "tbTacgGia";
            tbTacgGia.Size = new Size(409, 23);
            tbTacgGia.TabIndex = 10;
            // 
            // cbbViTri
            // 
            cbbViTri.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbViTri.FormattingEnabled = true;
            cbbViTri.Location = new Point(98, 128);
            cbbViTri.Name = "cbbViTri";
            cbbViTri.Size = new Size(409, 23);
            cbbViTri.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 131);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 13;
            label6.Text = "Vị trí";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(277, 157);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // ThemTTSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 200);
            Controls.Add(btnThem);
            Controls.Add(label6);
            Controls.Add(cbbViTri);
            Controls.Add(label5);
            Controls.Add(tbTacgGia);
            Controls.Add(tbNXB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbGia);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Controls.Add(btnRescan);
            Controls.Add(tbBarcode);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ThemTTSach";
            Text = "Thêm thông tin sách";
            Load += ThemTTSach_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbBarcode;
        private Button btnRescan;
        private Label label1;
        private Label label2;
        private TextBox tbName;
        private Label label3;
        private TextBox tbGia;
        private Label label4;
        private DateTimePicker tbNXB;
        private Label label5;
        private TextBox tbTacgGia;
        private ComboBox cbbViTri;
        private Label label6;
        private Button btnThem;
    }
}