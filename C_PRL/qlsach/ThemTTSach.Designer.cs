
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
            btnClear = new Button();
            label1 = new Label();
            label2 = new Label();
            tbName = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();

            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // tbBarcode
            // 
            tbBarcode.Location = new Point(98, 12);
            tbBarcode.Name = "tbBarcode";
            tbBarcode.Size = new Size(409, 23);
            tbBarcode.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(513, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
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
            // ThemTTSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 346);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(tbBarcode);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ThemTTSach";
            Text = "Thêm thông tin sách";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbBarcode;
        private Button btnClear;
        private Label label1;
        private Label label2;
        private TextBox tbName;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
    }
}