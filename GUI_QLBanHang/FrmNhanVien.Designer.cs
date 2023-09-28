namespace GUI_QLBanHang
{
    partial class FrmNhanVien
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtemail = new TextBox();
            txttennv = new TextBox();
            txtdiachi = new TextBox();
            rbnhanvien = new RadioButton();
            rbquantri = new RadioButton();
            rbhoatdong = new RadioButton();
            rbngung = new RadioButton();
            dtView = new DataGridView();
            txttimkiem = new TextBox();
            btntimkiem = new Button();
            btnthem = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnluu = new Button();
            btnboqua = new Button();
            btndanhsach = new Button();
            btndong = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(329, 5);
            label1.Name = "label1";
            label1.Size = new Size(128, 27);
            label1.TabIndex = 0;
            label1.Text = "Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 49);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 84);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 119);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Vai Trò";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 47);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 4;
            label5.Text = "Địa Chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(411, 117);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 5;
            label6.Text = "Tình Trạng";
            // 
            // txtemail
            // 
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Cursor = Cursors.IBeam;
            txtemail.Location = new Point(153, 48);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(222, 23);
            txtemail.TabIndex = 6;
            // 
            // txttennv
            // 
            txttennv.BorderStyle = BorderStyle.FixedSingle;
            txttennv.Cursor = Cursors.IBeam;
            txttennv.Location = new Point(153, 82);
            txttennv.Multiline = true;
            txttennv.Name = "txttennv";
            txttennv.Size = new Size(222, 24);
            txttennv.TabIndex = 7;
            // 
            // txtdiachi
            // 
            txtdiachi.BorderStyle = BorderStyle.FixedSingle;
            txtdiachi.Cursor = Cursors.IBeam;
            txtdiachi.Location = new Point(510, 47);
            txtdiachi.Multiline = true;
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(262, 57);
            txtdiachi.TabIndex = 8;
            // 
            // rbnhanvien
            // 
            rbnhanvien.AutoSize = true;
            rbnhanvien.Location = new Point(14, 1);
            rbnhanvien.Name = "rbnhanvien";
            rbnhanvien.Size = new Size(101, 24);
            rbnhanvien.TabIndex = 9;
            rbnhanvien.TabStop = true;
            rbnhanvien.Text = "Nhân viên";
            rbnhanvien.UseVisualStyleBackColor = true;
            // 
            // rbquantri
            // 
            rbquantri.AutoSize = true;
            rbquantri.Location = new Point(150, 1);
            rbquantri.Name = "rbquantri";
            rbquantri.Size = new Size(86, 24);
            rbquantri.TabIndex = 10;
            rbquantri.TabStop = true;
            rbquantri.Text = "Quản trị";
            rbquantri.UseVisualStyleBackColor = true;
            // 
            // rbhoatdong
            // 
            rbhoatdong.AutoSize = true;
            rbhoatdong.Location = new Point(4, 1);
            rbhoatdong.Name = "rbhoatdong";
            rbhoatdong.Size = new Size(104, 24);
            rbhoatdong.TabIndex = 11;
            rbhoatdong.TabStop = true;
            rbhoatdong.Text = "Hoạt động";
            rbhoatdong.UseVisualStyleBackColor = true;
            // 
            // rbngung
            // 
            rbngung.AutoSize = true;
            rbngung.Location = new Point(114, 1);
            rbngung.Name = "rbngung";
            rbngung.Size = new Size(158, 24);
            rbngung.TabIndex = 12;
            rbngung.TabStop = true;
            rbngung.Text = "Ngưng hoạt động";
            rbngung.UseVisualStyleBackColor = true;
            // 
            // dtView
            // 
            dtView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtView.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtView.GridColor = SystemColors.ActiveCaptionText;
            dtView.Location = new Point(48, 156);
            dtView.MultiSelect = false;
            dtView.Name = "dtView";
            dtView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtView.RowTemplate.Height = 25;
            dtView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtView.Size = new Size(676, 265);
            dtView.TabIndex = 13;
            dtView.Click += dtView_Click;
            // 
            // txttimkiem
            // 
            txttimkiem.BorderStyle = BorderStyle.FixedSingle;
            txttimkiem.Location = new Point(241, 440);
            txttimkiem.Multiline = true;
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(191, 25);
            txttimkiem.TabIndex = 14;
            // 
            // btntimkiem
            // 
            btntimkiem.BackColor = SystemColors.MenuHighlight;
            btntimkiem.FlatAppearance.BorderSize = 0;
            btntimkiem.FlatStyle = FlatStyle.Flat;
            btntimkiem.Font = new Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btntimkiem.ForeColor = SystemColors.Control;
            btntimkiem.Image = Properties.Resources.search2;
            btntimkiem.ImageAlign = ContentAlignment.MiddleLeft;
            btntimkiem.Location = new Point(454, 436);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.RightToLeft = RightToLeft.Yes;
            btntimkiem.Size = new Size(112, 34);
            btntimkiem.TabIndex = 15;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.TextImageRelation = TextImageRelation.TextBeforeImage;
            btntimkiem.UseVisualStyleBackColor = false;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // btnthem
            // 
            btnthem.BackColor = SystemColors.MenuHighlight;
            btnthem.FlatAppearance.BorderSize = 0;
            btnthem.FlatStyle = FlatStyle.Flat;
            btnthem.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnthem.ForeColor = SystemColors.Control;
            btnthem.Image = Properties.Resources.add1;
            btnthem.ImageAlign = ContentAlignment.MiddleLeft;
            btnthem.Location = new Point(28, 486);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(75, 32);
            btnthem.TabIndex = 16;
            btnthem.Text = "Thêm";
            btnthem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // btnxoa
            // 
            btnxoa.BackColor = SystemColors.MenuHighlight;
            btnxoa.FlatAppearance.BorderSize = 0;
            btnxoa.FlatStyle = FlatStyle.Flat;
            btnxoa.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnxoa.ForeColor = SystemColors.Control;
            btnxoa.Image = Properties.Resources.delete;
            btnxoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnxoa.Location = new Point(139, 486);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(58, 32);
            btnxoa.TabIndex = 17;
            btnxoa.Text = "Xoá";
            btnxoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnxoa.UseVisualStyleBackColor = false;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.BackColor = SystemColors.MenuHighlight;
            btnsua.FlatAppearance.BorderSize = 0;
            btnsua.FlatStyle = FlatStyle.Flat;
            btnsua.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnsua.ForeColor = SystemColors.Control;
            btnsua.Image = Properties.Resources.edit;
            btnsua.ImageAlign = ContentAlignment.MiddleLeft;
            btnsua.Location = new Point(233, 486);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(59, 32);
            btnsua.TabIndex = 18;
            btnsua.Text = "Sửa";
            btnsua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsua.UseVisualStyleBackColor = false;
            btnsua.Click += btnsua_Click;
            // 
            // btnluu
            // 
            btnluu.BackColor = SystemColors.MenuHighlight;
            btnluu.FlatAppearance.BorderSize = 0;
            btnluu.FlatStyle = FlatStyle.Flat;
            btnluu.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnluu.ForeColor = SystemColors.Control;
            btnluu.Image = Properties.Resources.save;
            btnluu.ImageAlign = ContentAlignment.MiddleLeft;
            btnluu.Location = new Point(328, 486);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(59, 32);
            btnluu.TabIndex = 19;
            btnluu.Text = "Lưu";
            btnluu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnluu.UseVisualStyleBackColor = false;
            btnluu.Click += btnluu_Click;
            // 
            // btnboqua
            // 
            btnboqua.BackColor = SystemColors.MenuHighlight;
            btnboqua.FlatAppearance.BorderSize = 0;
            btnboqua.FlatStyle = FlatStyle.Flat;
            btnboqua.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnboqua.ForeColor = SystemColors.Control;
            btnboqua.Image = Properties.Resources.skip;
            btnboqua.ImageAlign = ContentAlignment.MiddleLeft;
            btnboqua.Location = new Point(423, 486);
            btnboqua.Name = "btnboqua";
            btnboqua.Size = new Size(84, 32);
            btnboqua.TabIndex = 20;
            btnboqua.Text = "Bỏ qua";
            btnboqua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnboqua.UseVisualStyleBackColor = false;
            btnboqua.Click += btnboqua_Click;
            // 
            // btndanhsach
            // 
            btndanhsach.BackColor = SystemColors.MenuHighlight;
            btndanhsach.FlatAppearance.BorderSize = 0;
            btndanhsach.FlatStyle = FlatStyle.Flat;
            btndanhsach.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btndanhsach.ForeColor = SystemColors.Control;
            btndanhsach.Image = Properties.Resources.list;
            btndanhsach.ImageAlign = ContentAlignment.MiddleLeft;
            btndanhsach.Location = new Point(543, 486);
            btndanhsach.Name = "btndanhsach";
            btndanhsach.Size = new Size(109, 32);
            btndanhsach.TabIndex = 21;
            btndanhsach.Text = "Danh sách";
            btndanhsach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndanhsach.UseVisualStyleBackColor = false;
            btndanhsach.Click += btndanhsach_Click;
            // 
            // btndong
            // 
            btndong.BackColor = SystemColors.MenuHighlight;
            btndong.FlatAppearance.BorderSize = 0;
            btndong.FlatStyle = FlatStyle.Flat;
            btndong.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btndong.ForeColor = SystemColors.Control;
            btndong.Image = Properties.Resources.off;
            btndong.ImageAlign = ContentAlignment.MiddleLeft;
            btndong.Location = new Point(688, 486);
            btndong.Name = "btndong";
            btndong.Size = new Size(73, 32);
            btndong.TabIndex = 22;
            btndong.Text = "Đóng";
            btndong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndong.UseVisualStyleBackColor = false;
            btndong.Click += btndong_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbhoatdong);
            panel1.Controls.Add(rbngung);
            panel1.Location = new Point(508, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 27);
            panel1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Controls.Add(rbnhanvien);
            panel2.Controls.Add(rbquantri);
            panel2.Location = new Point(142, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 27);
            panel2.TabIndex = 24;
            // 
            // FrmNhanVien
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(790, 526);
            Controls.Add(btndong);
            Controls.Add(btndanhsach);
            Controls.Add(btnboqua);
            Controls.Add(btnluu);
            Controls.Add(btnsua);
            Controls.Add(btnxoa);
            Controls.Add(btnthem);
            Controls.Add(btntimkiem);
            Controls.Add(txttimkiem);
            Controls.Add(dtView);
            Controls.Add(txtdiachi);
            Controls.Add(txttennv);
            Controls.Add(txtemail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmNhanVien";
            Load += FrmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtemail;
        private TextBox txttennv;
        private TextBox txtdiachi;
        private RadioButton rbnhanvien;
        private RadioButton rbquantri;
        private RadioButton rbhoatdong;
        private RadioButton rbngung;
        private DataGridView dtView;
        private TextBox txttimkiem;
        private Button btntimkiem;
        private Button btnthem;
        private Button btnxoa;
        private Button btnsua;
        private Button btnluu;
        private Button btnboqua;
        private Button btndanhsach;
        private Button btndong;
        private Panel panel1;
        private Panel panel2;
    }
}