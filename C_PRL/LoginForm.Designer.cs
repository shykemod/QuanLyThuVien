namespace C_PRL
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            btnHide = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 62);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(17, 128);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(229, 32);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(17, 27);
            tbUserName.MaxLength = 15;
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(229, 23);
            tbUserName.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(17, 80);
            tbPassword.MaxLength = 15;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(197, 23);
            tbPassword.TabIndex = 4;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnHide
            // 
            btnHide.BackgroundImage = Properties.Resources.view1;
            btnHide.BackgroundImageLayout = ImageLayout.Stretch;
            btnHide.Location = new Point(220, 79);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(26, 24);
            btnHide.TabIndex = 5;
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 175);
            Controls.Add(btnHide);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnLogin;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Button btnHide;
    }
}