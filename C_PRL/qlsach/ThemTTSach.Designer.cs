using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace C_PRL.qlsach
{
    public class MultiSelectComboBox : ComboBox
    {
        private CheckedListBox _listBox;
        private bool _isDroppedDown;

        public MultiSelectComboBox()
        {
            _listBox = new CheckedListBox
            {
                SelectionMode = SelectionMode.MultiSimple,
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(100, 100),
                BorderStyle = BorderStyle.FixedSingle
            };
            _listBox.Visible = false;
            _listBox.ItemCheck += (s, e) => OnItemCheckChanged(s, e);
        }

        public new bool DroppedDown
        {
            get { return _isDroppedDown; }
            set
            {
                _isDroppedDown = value;
                _listBox.Visible = value;
                if (_isDroppedDown)
                {
                    UpdateListBoxLocation();
                    _listBox.BringToFront();
                    _listBox.Focus();
                }
            }
        }

        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);
            DroppedDown = true;
        }

        protected void OnItemCheckChanged(object sender, ItemCheckEventArgs e)
        {
            string displayText = "";
            foreach (var item in _listBox.CheckedItems)
            {
                displayText += item.ToString() + ", ";
            }

            if (displayText.Length > 2)
            {
                displayText = displayText.Substring(0, displayText.Length - 2);
            }

            this.Text = displayText;
        }

        private void UpdateListBoxLocation()
        {
            _listBox.Location = this.PointToScreen(new System.Drawing.Point(0, this.Height));
            _listBox.Width = this.Width;
            _listBox.Height = 100; // Set this to the desired height
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (!_listBox.ContainsFocus)
            {
                DroppedDown = false;
            }
        }

        public void SetItems(List<string> items)
        {
            foreach (var item in items)
            {
                _listBox.Items.Add(item, false);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _listBox.Dispose();
            }
            base.Dispose(disposing);
        }
    }

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
            textBox1 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            btnThem = new Button();
            SuspendLayout();
            // 
            // tbBarcode
            // 
            tbBarcode.Location = new Point(98, 12);
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
            // textBox1
            // 
            textBox1.Location = new Point(98, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 5;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(336, 70);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(171, 23);
            dateTimePicker1.TabIndex = 9;
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
            // textBox2
            // 
            textBox2.Location = new Point(98, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(409, 23);
            textBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(409, 23);
            comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 131);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 13;
            label6.Text = "Thể loại";
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
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Controls.Add(btnRescan);
            Controls.Add(tbBarcode);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private TextBox textBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Button btnThem;
    }
}