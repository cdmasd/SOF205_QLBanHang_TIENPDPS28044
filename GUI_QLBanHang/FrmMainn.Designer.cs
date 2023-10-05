namespace GUI_QLBanHang
{
    partial class FrmMainn
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
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            hồSơNhânViênToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            ThốngKêSPTồnToolStripMenuItem = new ToolStripMenuItem();
            hướngDẫnToolStripMenuItem = new ToolStripMenuItem();
            hướngDẫnSửDụngToolStripMenuItem = new ToolStripMenuItem();
            giớiThiệuPhầnMềmToolStripMenuItem = new ToolStripMenuItem();
            thôngTinNvToolStripMenuItem = new ToolStripMenuItem();
            Container = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonFace;
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhMụcToolStripMenuItem, thốngKêToolStripMenuItem, hướngDẫnToolStripMenuItem, thôngTinNvToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngNhậpToolStripMenuItem, đăngXuấtToolStripMenuItem, hồSơNhânViênToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(71, 20);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            đăngNhậpToolStripMenuItem.Image = Properties.Resources.login;
            đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            đăngNhậpToolStripMenuItem.RightToLeft = RightToLeft.No;
            đăngNhậpToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            đăngNhậpToolStripMenuItem.Size = new Size(207, 22);
            đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            đăngNhậpToolStripMenuItem.Click += đăngNhậpToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Image = Properties.Resources.logout;
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            đăngXuấtToolStripMenuItem.Size = new Size(207, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // hồSơNhânViênToolStripMenuItem
            // 
            hồSơNhânViênToolStripMenuItem.Image = Properties.Resources.determining;
            hồSơNhânViênToolStripMenuItem.Name = "hồSơNhânViênToolStripMenuItem";
            hồSơNhânViênToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            hồSơNhânViênToolStripMenuItem.Size = new Size(207, 22);
            hồSơNhânViênToolStripMenuItem.Text = "Hồ Sơ Nhân Viên";
            hồSơNhânViênToolStripMenuItem.Click += hồSơNhânViênToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Image = Properties.Resources.power_off;
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            thoátToolStripMenuItem.Size = new Size(207, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sảnPhẩmToolStripMenuItem, nhânViênToolStripMenuItem, kháchHàngToolStripMenuItem });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(74, 20);
            danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.Image = Properties.Resources.features;
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Size = new Size(139, 22);
            sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            sảnPhẩmToolStripMenuItem.Click += sảnPhẩmToolStripMenuItem_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Image = Properties.Resources.employee;
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(139, 22);
            nhânViênToolStripMenuItem.Text = "Nhân Viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click_1;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Image = Properties.Resources.costumer;
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(139, 22);
            kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ThốngKêSPTồnToolStripMenuItem });
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(69, 20);
            thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // ThốngKêSPTồnToolStripMenuItem
            // 
            ThốngKêSPTồnToolStripMenuItem.Image = Properties.Resources.stats;
            ThốngKêSPTồnToolStripMenuItem.Name = "ThốngKêSPTồnToolStripMenuItem";
            ThốngKêSPTồnToolStripMenuItem.Size = new Size(180, 22);
            ThốngKêSPTồnToolStripMenuItem.Text = "Thống Kê Sản Phẩm";
            ThốngKêSPTồnToolStripMenuItem.Click += ThốngKêSPTồnToolStripMenuItem_Click;
            // 
            // hướngDẫnToolStripMenuItem
            // 
            hướngDẫnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hướngDẫnSửDụngToolStripMenuItem, giớiThiệuPhầnMềmToolStripMenuItem });
            hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            hướngDẫnToolStripMenuItem.Size = new Size(80, 20);
            hướngDẫnToolStripMenuItem.Text = "Hướng Dẫn";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            hướngDẫnSửDụngToolStripMenuItem.Image = Properties.Resources.instruction;
            hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            hướngDẫnSửDụngToolStripMenuItem.Size = new Size(188, 22);
            hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng Dẫn Sử Dụng";
            // 
            // giớiThiệuPhầnMềmToolStripMenuItem
            // 
            giớiThiệuPhầnMềmToolStripMenuItem.Image = Properties.Resources.search3;
            giớiThiệuPhầnMềmToolStripMenuItem.Name = "giớiThiệuPhầnMềmToolStripMenuItem";
            giớiThiệuPhầnMềmToolStripMenuItem.Size = new Size(188, 22);
            giớiThiệuPhầnMềmToolStripMenuItem.Text = "Giới Thiệu Phần Mềm";
            // 
            // thôngTinNvToolStripMenuItem
            // 
            thôngTinNvToolStripMenuItem.Name = "thôngTinNvToolStripMenuItem";
            thôngTinNvToolStripMenuItem.Size = new Size(86, 20);
            thôngTinNvToolStripMenuItem.Text = "Thông tin nv";
            // 
            // Container
            // 
            Container.Dock = DockStyle.Fill;
            Container.Location = new Point(0, 24);
            Container.Name = "Container";
            Container.Size = new Size(800, 526);
            Container.TabIndex = 1;
            // 
            // FrmMainn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(Container);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMainn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMainn";
            Load += FrmMainn_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem hồSơNhânViênToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem ThốngKêSPTồnToolStripMenuItem;
        private ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private ToolStripMenuItem giớiThiệuPhầnMềmToolStripMenuItem;
        private Panel Container;
        private ToolStripMenuItem thôngTinNvToolStripMenuItem;
    }
}