namespace GUI_QLBanHang
{
    partial class FrmDangNhap
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnthoat = new Button();
            btndangnhap = new Button();
            btnquenmatkhau = new Button();
            chkghinhotk = new CheckBox();
            txtmatkhau = new TextBox();
            txtemail = new TextBox();
            lblmatkhau = new Label();
            lblemail = new Label();
            lbldangnhap = new Label();
            picdangnhap = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picdangnhap).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnthoat);
            panel1.Controls.Add(btndangnhap);
            panel1.Controls.Add(btnquenmatkhau);
            panel1.Controls.Add(chkghinhotk);
            panel1.Controls.Add(txtmatkhau);
            panel1.Controls.Add(txtemail);
            panel1.Controls.Add(lblmatkhau);
            panel1.Controls.Add(lblemail);
            panel1.Controls.Add(lbldangnhap);
            panel1.Controls.Add(picdangnhap);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 454);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Location = new Point(9, 275);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 2);
            panel2.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateBlue;
            panel3.Location = new Point(9, 213);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 2);
            panel3.TabIndex = 22;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.DarkSlateBlue;
            btnthoat.Cursor = Cursors.Hand;
            btnthoat.FlatAppearance.BorderSize = 0;
            btnthoat.FlatStyle = FlatStyle.Flat;
            btnthoat.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnthoat.ForeColor = SystemColors.ButtonFace;
            btnthoat.Location = new Point(88, 402);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(176, 38);
            btnthoat.TabIndex = 21;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // btndangnhap
            // 
            btndangnhap.BackColor = Color.DarkSlateBlue;
            btndangnhap.Cursor = Cursors.Hand;
            btndangnhap.FlatAppearance.BorderSize = 0;
            btndangnhap.FlatStyle = FlatStyle.Flat;
            btndangnhap.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btndangnhap.ForeColor = SystemColors.ButtonFace;
            btndangnhap.Location = new Point(88, 356);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(176, 38);
            btndangnhap.TabIndex = 20;
            btndangnhap.Text = "Đăng Nhập";
            btndangnhap.UseVisualStyleBackColor = false;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // btnquenmatkhau
            // 
            btnquenmatkhau.Cursor = Cursors.Hand;
            btnquenmatkhau.FlatAppearance.BorderSize = 0;
            btnquenmatkhau.FlatAppearance.MouseDownBackColor = Color.White;
            btnquenmatkhau.FlatAppearance.MouseOverBackColor = Color.White;
            btnquenmatkhau.FlatStyle = FlatStyle.Flat;
            btnquenmatkhau.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnquenmatkhau.Location = new Point(220, 309);
            btnquenmatkhau.Name = "btnquenmatkhau";
            btnquenmatkhau.Size = new Size(135, 34);
            btnquenmatkhau.TabIndex = 19;
            btnquenmatkhau.Text = "Quên Mật Khẩu";
            btnquenmatkhau.UseVisualStyleBackColor = true;
            btnquenmatkhau.Click += btnquenmatkhau_Click;
            // 
            // chkghinhotk
            // 
            chkghinhotk.AutoSize = true;
            chkghinhotk.Cursor = Cursors.Hand;
            chkghinhotk.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chkghinhotk.Location = new Point(9, 313);
            chkghinhotk.Name = "chkghinhotk";
            chkghinhotk.Size = new Size(150, 24);
            chkghinhotk.TabIndex = 18;
            chkghinhotk.Text = "Ghi Nhớ Tài Khoản";
            chkghinhotk.UseVisualStyleBackColor = true;
            // 
            // txtmatkhau
            // 
            txtmatkhau.BorderStyle = BorderStyle.None;
            txtmatkhau.Cursor = Cursors.IBeam;
            txtmatkhau.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtmatkhau.Location = new Point(9, 257);
            txtmatkhau.Multiline = true;
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.PasswordChar = '*';
            txtmatkhau.Size = new Size(337, 27);
            txtmatkhau.TabIndex = 17;
            // 
            // txtemail
            // 
            txtemail.BorderStyle = BorderStyle.None;
            txtemail.Cursor = Cursors.IBeam;
            txtemail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.Location = new Point(9, 192);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(337, 27);
            txtemail.TabIndex = 16;
            // 
            // lblmatkhau
            // 
            lblmatkhau.AutoSize = true;
            lblmatkhau.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblmatkhau.Location = new Point(6, 232);
            lblmatkhau.Name = "lblmatkhau";
            lblmatkhau.Size = new Size(110, 20);
            lblmatkhau.TabIndex = 15;
            lblmatkhau.Text = "Nhập mật khẩu";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblemail.Location = new Point(6, 167);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(86, 20);
            lblemail.TabIndex = 14;
            lblemail.Text = "Nhập email";
            // 
            // lbldangnhap
            // 
            lbldangnhap.AutoSize = true;
            lbldangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldangnhap.Location = new Point(89, 115);
            lbldangnhap.Margin = new Padding(4, 0, 4, 0);
            lbldangnhap.Name = "lbldangnhap";
            lbldangnhap.Size = new Size(175, 21);
            lbldangnhap.TabIndex = 13;
            lbldangnhap.Text = "Đăng Nhập Hệ Thống";
            // 
            // picdangnhap
            // 
            picdangnhap.Image = Properties.Resources.LoginIcon;
            picdangnhap.Location = new Point(123, 15);
            picdangnhap.Margin = new Padding(4, 3, 4, 3);
            picdangnhap.Name = "picdangnhap";
            picdangnhap.Size = new Size(107, 97);
            picdangnhap.SizeMode = PictureBoxSizeMode.Zoom;
            picdangnhap.TabIndex = 12;
            picdangnhap.TabStop = false;
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(361, 454);
            Controls.Add(panel1);
            Font = new Font("Montserrat Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDangNhap";
            Load += FrmDangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picdangnhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnthoat;
        private Button btndangnhap;
        private Button btnquenmatkhau;
        private CheckBox chkghinhotk;
        private TextBox txtmatkhau;
        private TextBox txtemail;
        private Label lblmatkhau;
        private Label lblemail;
        private Label lbldangnhap;
        private PictureBox picdangnhap;
    }
}