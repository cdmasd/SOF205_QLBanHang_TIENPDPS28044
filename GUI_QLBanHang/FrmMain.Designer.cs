namespace GUI_QLBanHang
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            Container = new Panel();
            btnthoat = new Button();
            label1 = new Label();
            btnDanhMuc = new Button();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuDanhMuc = new FlowLayoutPanel();
            panel6 = new Panel();
            btnSanPham = new Button();
            panel9 = new Panel();
            btnNhanVien = new Button();
            panel10 = new Panel();
            btnKhachHang = new Button();
            menuThongKe = new FlowLayoutPanel();
            panel7 = new Panel();
            btnThongKe = new Button();
            panel8 = new Panel();
            btnSPNhapKho = new Button();
            panel11 = new Panel();
            btnSPTonKho = new Button();
            menuHuongDan = new FlowLayoutPanel();
            panel12 = new Panel();
            btnHuongDan = new Button();
            panel13 = new Panel();
            btnHdsd = new Button();
            panel14 = new Panel();
            btnGTSP = new Button();
            menuHeThong = new FlowLayoutPanel();
            panel15 = new Panel();
            btnHeThong = new Button();
            panel16 = new Panel();
            btnDangNhap = new Button();
            panel17 = new Panel();
            btnDangXuat = new Button();
            panel2 = new Panel();
            btnHoSoNV = new Button();
            panel4 = new Panel();
            btnThoat2 = new Button();
            Transition_DanhMuc = new System.Windows.Forms.Timer(components);
            Transition_ThongKe = new System.Windows.Forms.Timer(components);
            Transition_HuongDan = new System.Windows.Forms.Timer(components);
            Transition_HeThong = new System.Windows.Forms.Timer(components);
            panel18 = new Panel();
            Container.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            menuDanhMuc.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            menuThongKe.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel11.SuspendLayout();
            menuHuongDan.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            menuHeThong.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // Container
            // 
            Container.Controls.Add(btnthoat);
            Container.Controls.Add(label1);
            Container.Dock = DockStyle.Top;
            Container.Location = new Point(0, 0);
            Container.Name = "Container";
            Container.Size = new Size(933, 33);
            Container.TabIndex = 0;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.GhostWhite;
            btnthoat.Dock = DockStyle.Right;
            btnthoat.FlatAppearance.BorderSize = 0;
            btnthoat.FlatStyle = FlatStyle.Flat;
            btnthoat.Image = Properties.Resources.delete;
            btnthoat.Location = new Point(900, 0);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(33, 33);
            btnthoat.TabIndex = 14;
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 7);
            label1.Name = "label1";
            label1.Size = new Size(142, 17);
            label1.TabIndex = 2;
            label1.Text = "MANAGEMENT FORM";
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.BackColor = Color.DarkSlateBlue;
            btnDanhMuc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhMuc.ForeColor = SystemColors.Control;
            btnDanhMuc.Location = new Point(-22, -12);
            btnDanhMuc.Margin = new Padding(0);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(213, 58);
            btnDanhMuc.TabIndex = 7;
            btnDanhMuc.Text = "Danh Mục";
            btnDanhMuc.UseVisualStyleBackColor = false;
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDanhMuc);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(177, 34);
            panel3.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DarkSlateBlue;
            flowLayoutPanel1.Controls.Add(menuDanhMuc);
            flowLayoutPanel1.Controls.Add(menuThongKe);
            flowLayoutPanel1.Controls.Add(menuHuongDan);
            flowLayoutPanel1.Controls.Add(menuHeThong);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 33);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(177, 461);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // menuDanhMuc
            // 
            menuDanhMuc.BackColor = Color.FromArgb(82, 69, 158);
            menuDanhMuc.Controls.Add(panel3);
            menuDanhMuc.Controls.Add(panel6);
            menuDanhMuc.Controls.Add(panel9);
            menuDanhMuc.Controls.Add(panel10);
            menuDanhMuc.Location = new Point(0, 0);
            menuDanhMuc.Margin = new Padding(0);
            menuDanhMuc.Name = "menuDanhMuc";
            menuDanhMuc.Size = new Size(177, 34);
            menuDanhMuc.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnSanPham);
            panel6.Location = new Point(0, 34);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(177, 34);
            panel6.TabIndex = 9;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.FromArgb(82, 69, 158);
            btnSanPham.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSanPham.ForeColor = SystemColors.Control;
            btnSanPham.Location = new Point(-10, -11);
            btnSanPham.Margin = new Padding(0);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(199, 56);
            btnSanPham.TabIndex = 7;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnNhanVien);
            panel9.Location = new Point(0, 68);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(177, 34);
            panel9.TabIndex = 10;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.FromArgb(82, 69, 158);
            btnNhanVien.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhanVien.ForeColor = SystemColors.Control;
            btnNhanVien.Location = new Point(-10, -11);
            btnNhanVien.Margin = new Padding(0);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(199, 56);
            btnNhanVien.TabIndex = 7;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnKhachHang);
            panel10.Location = new Point(0, 102);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(177, 34);
            panel10.TabIndex = 11;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.FromArgb(82, 69, 158);
            btnKhachHang.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhachHang.ForeColor = SystemColors.Control;
            btnKhachHang.Location = new Point(-10, -11);
            btnKhachHang.Margin = new Padding(0);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(199, 56);
            btnKhachHang.TabIndex = 7;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.UseVisualStyleBackColor = false;
            // 
            // menuThongKe
            // 
            menuThongKe.BackColor = Color.FromArgb(82, 69, 158);
            menuThongKe.Controls.Add(panel7);
            menuThongKe.Controls.Add(panel8);
            menuThongKe.Controls.Add(panel11);
            menuThongKe.Location = new Point(0, 34);
            menuThongKe.Margin = new Padding(0);
            menuThongKe.Name = "menuThongKe";
            menuThongKe.Size = new Size(177, 34);
            menuThongKe.TabIndex = 13;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnThongKe);
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(177, 34);
            panel7.TabIndex = 8;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.DarkSlateBlue;
            btnThongKe.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnThongKe.ForeColor = SystemColors.Control;
            btnThongKe.Location = new Point(-22, -12);
            btnThongKe.Margin = new Padding(0);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(213, 58);
            btnThongKe.TabIndex = 7;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnSPNhapKho);
            panel8.Location = new Point(0, 34);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(177, 34);
            panel8.TabIndex = 11;
            // 
            // btnSPNhapKho
            // 
            btnSPNhapKho.BackColor = Color.FromArgb(82, 69, 158);
            btnSPNhapKho.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSPNhapKho.ForeColor = SystemColors.Control;
            btnSPNhapKho.Location = new Point(-10, -11);
            btnSPNhapKho.Margin = new Padding(0);
            btnSPNhapKho.Name = "btnSPNhapKho";
            btnSPNhapKho.Size = new Size(199, 56);
            btnSPNhapKho.TabIndex = 7;
            btnSPNhapKho.Text = "Sản Phẩm Nhập Kho";
            btnSPNhapKho.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnSPTonKho);
            panel11.Location = new Point(0, 68);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(177, 34);
            panel11.TabIndex = 10;
            // 
            // btnSPTonKho
            // 
            btnSPTonKho.BackColor = Color.FromArgb(82, 69, 158);
            btnSPTonKho.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSPTonKho.ForeColor = SystemColors.Control;
            btnSPTonKho.Location = new Point(-10, -11);
            btnSPTonKho.Margin = new Padding(0);
            btnSPTonKho.Name = "btnSPTonKho";
            btnSPTonKho.Size = new Size(199, 56);
            btnSPTonKho.TabIndex = 7;
            btnSPTonKho.Text = "Sản Phẩm Tồn Kho";
            btnSPTonKho.UseVisualStyleBackColor = false;
            // 
            // menuHuongDan
            // 
            menuHuongDan.BackColor = Color.FromArgb(82, 69, 158);
            menuHuongDan.Controls.Add(panel12);
            menuHuongDan.Controls.Add(panel13);
            menuHuongDan.Controls.Add(panel14);
            menuHuongDan.Location = new Point(0, 68);
            menuHuongDan.Margin = new Padding(0);
            menuHuongDan.Name = "menuHuongDan";
            menuHuongDan.Size = new Size(177, 34);
            menuHuongDan.TabIndex = 14;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnHuongDan);
            panel12.Location = new Point(0, 0);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Size = new Size(177, 34);
            panel12.TabIndex = 8;
            // 
            // btnHuongDan
            // 
            btnHuongDan.BackColor = Color.DarkSlateBlue;
            btnHuongDan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuongDan.ForeColor = SystemColors.Control;
            btnHuongDan.Location = new Point(-22, -12);
            btnHuongDan.Margin = new Padding(0);
            btnHuongDan.Name = "btnHuongDan";
            btnHuongDan.Size = new Size(213, 58);
            btnHuongDan.TabIndex = 7;
            btnHuongDan.Text = "Hướng Dẫn";
            btnHuongDan.UseVisualStyleBackColor = false;
            btnHuongDan.Click += btnHuongDan_Click;
            // 
            // panel13
            // 
            panel13.Controls.Add(btnHdsd);
            panel13.Location = new Point(0, 34);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.Size = new Size(177, 34);
            panel13.TabIndex = 11;
            // 
            // btnHdsd
            // 
            btnHdsd.BackColor = Color.FromArgb(82, 69, 158);
            btnHdsd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHdsd.ForeColor = SystemColors.Control;
            btnHdsd.Location = new Point(-10, -11);
            btnHdsd.Margin = new Padding(0);
            btnHdsd.Name = "btnHdsd";
            btnHdsd.Size = new Size(199, 56);
            btnHdsd.TabIndex = 7;
            btnHdsd.Text = "Hướng Dẫn Sử Dụng";
            btnHdsd.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            panel14.Controls.Add(btnGTSP);
            panel14.Location = new Point(0, 68);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.Size = new Size(177, 34);
            panel14.TabIndex = 10;
            // 
            // btnGTSP
            // 
            btnGTSP.BackColor = Color.FromArgb(82, 69, 158);
            btnGTSP.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGTSP.ForeColor = SystemColors.Control;
            btnGTSP.Location = new Point(-10, -11);
            btnGTSP.Margin = new Padding(0);
            btnGTSP.Name = "btnGTSP";
            btnGTSP.Size = new Size(199, 56);
            btnGTSP.TabIndex = 7;
            btnGTSP.Text = "Giới Thiệu Sản Phẩm";
            btnGTSP.UseVisualStyleBackColor = false;
            // 
            // menuHeThong
            // 
            menuHeThong.BackColor = Color.FromArgb(82, 69, 158);
            menuHeThong.Controls.Add(panel15);
            menuHeThong.Controls.Add(panel16);
            menuHeThong.Controls.Add(panel17);
            menuHeThong.Controls.Add(panel2);
            menuHeThong.Controls.Add(panel4);
            menuHeThong.Location = new Point(0, 102);
            menuHeThong.Margin = new Padding(0);
            menuHeThong.Name = "menuHeThong";
            menuHeThong.Size = new Size(177, 34);
            menuHeThong.TabIndex = 15;
            // 
            // panel15
            // 
            panel15.Controls.Add(btnHeThong);
            panel15.Location = new Point(0, 0);
            panel15.Margin = new Padding(0);
            panel15.Name = "panel15";
            panel15.Size = new Size(177, 34);
            panel15.TabIndex = 8;
            // 
            // btnHeThong
            // 
            btnHeThong.BackColor = Color.DarkSlateBlue;
            btnHeThong.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHeThong.ForeColor = SystemColors.Control;
            btnHeThong.Location = new Point(-22, -12);
            btnHeThong.Margin = new Padding(0);
            btnHeThong.Name = "btnHeThong";
            btnHeThong.Size = new Size(213, 58);
            btnHeThong.TabIndex = 7;
            btnHeThong.Text = "Hệ Thống";
            btnHeThong.UseVisualStyleBackColor = false;
            btnHeThong.Click += btnHeThong_Click;
            // 
            // panel16
            // 
            panel16.Controls.Add(btnDangNhap);
            panel16.Location = new Point(0, 34);
            panel16.Margin = new Padding(0);
            panel16.Name = "panel16";
            panel16.Size = new Size(177, 34);
            panel16.TabIndex = 11;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(82, 69, 158);
            btnDangNhap.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangNhap.ForeColor = SystemColors.Control;
            btnDangNhap.Location = new Point(-10, -11);
            btnDangNhap.Margin = new Padding(0);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(199, 56);
            btnDangNhap.TabIndex = 7;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // panel17
            // 
            panel17.Controls.Add(btnDangXuat);
            panel17.Location = new Point(0, 68);
            panel17.Margin = new Padding(0);
            panel17.Name = "panel17";
            panel17.Size = new Size(177, 34);
            panel17.TabIndex = 10;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.FromArgb(82, 69, 158);
            btnDangXuat.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangXuat.ForeColor = SystemColors.Control;
            btnDangXuat.Location = new Point(-10, -11);
            btnDangXuat.Margin = new Padding(0);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(199, 56);
            btnDangXuat.TabIndex = 7;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHoSoNV);
            panel2.Location = new Point(0, 102);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 34);
            panel2.TabIndex = 11;
            // 
            // btnHoSoNV
            // 
            btnHoSoNV.BackColor = Color.FromArgb(82, 69, 158);
            btnHoSoNV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHoSoNV.ForeColor = SystemColors.Control;
            btnHoSoNV.Location = new Point(-10, -11);
            btnHoSoNV.Margin = new Padding(0);
            btnHoSoNV.Name = "btnHoSoNV";
            btnHoSoNV.Size = new Size(199, 56);
            btnHoSoNV.TabIndex = 7;
            btnHoSoNV.Text = "Hồ Sơ Nhân Viên";
            btnHoSoNV.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnThoat2);
            panel4.Location = new Point(0, 136);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(177, 34);
            panel4.TabIndex = 12;
            // 
            // btnThoat2
            // 
            btnThoat2.BackColor = Color.FromArgb(82, 69, 158);
            btnThoat2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat2.ForeColor = SystemColors.Control;
            btnThoat2.Location = new Point(-10, -11);
            btnThoat2.Margin = new Padding(0);
            btnThoat2.Name = "btnThoat2";
            btnThoat2.Size = new Size(199, 56);
            btnThoat2.TabIndex = 7;
            btnThoat2.Text = "Thoát";
            btnThoat2.UseVisualStyleBackColor = false;
            // 
            // Transition_DanhMuc
            // 
            Transition_DanhMuc.Interval = 10;
            Transition_DanhMuc.Tick += Transition_Tick;
            // 
            // Transition_ThongKe
            // 
            Transition_ThongKe.Interval = 10;
            Transition_ThongKe.Tick += Transition_ThongKe_Tick;
            // 
            // Transition_HuongDan
            // 
            Transition_HuongDan.Interval = 10;
            Transition_HuongDan.Tick += Transition_HuongDan_Tick;
            // 
            // Transition_HeThong
            // 
            Transition_HeThong.Interval = 10;
            Transition_HeThong.Tick += Transition_HeThong_Tick;
            // 
            // panel18
            // 
            panel18.Dock = DockStyle.Fill;
            panel18.Location = new Point(177, 33);
            panel18.Name = "panel18";
            panel18.Size = new Size(756, 461);
            panel18.TabIndex = 10;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 494);
            Controls.Add(panel18);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Container);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMain";
            Load += FrmMain_Load;
            Container.ResumeLayout(false);
            Container.PerformLayout();
            panel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            menuDanhMuc.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            menuThongKe.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel11.ResumeLayout(false);
            menuHuongDan.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel14.ResumeLayout(false);
            menuHeThong.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Container;
        private Label label1;
        private Button btnthoat;
        private Button btnDanhMuc;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button btnSanPham;
        private Panel panel9;
        private Button btnNhanVien;
        private Panel panel10;
        private Button btnKhachHang;
        private FlowLayoutPanel menuDanhMuc;
        private System.Windows.Forms.Timer Transition_DanhMuc;
        private Button btnHoSoNV;
        private Button button2;
        private Panel panel11;
        private Button btnSPTonKho;
        private Panel panel7;
        private Button btnThongKe;
        private FlowLayoutPanel menuThongKe;
        private Panel panel8;
        private Button btnSPNhapKho;
        private System.Windows.Forms.Timer Transition_ThongKe;
        private FlowLayoutPanel menuHuongDan;
        private Panel panel12;
        private Button btnHuongDan;
        private Panel panel13;
        private Button btnHdsd;
        private Panel panel14;
        private Button btnGTSP;
        private System.Windows.Forms.Timer Transition_HuongDan;
        private FlowLayoutPanel menuHeThong;
        private Panel panel15;
        private Button btnHeThong;
        private Panel panel16;
        private Button btnDangNhap;
        private Panel panel17;
        private Button btnDangXuat;
        private Button btnThoat2;
        private System.Windows.Forms.Timer Transition_HeThong;
        private Panel panel18;
    }
}