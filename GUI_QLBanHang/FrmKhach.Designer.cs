﻿namespace GUI_QLBanHang
{
    partial class FrmKhach
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            txtDienthoai = new TextBox();
            txtHoten = new TextBox();
            txtDiachi = new TextBox();
            rbNam = new RadioButton();
            rbNu = new RadioButton();
            btndong = new Button();
            btndanhsach = new Button();
            btnboqua = new Button();
            btnluu = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            btnthem = new Button();
            btntimkiem = new Button();
            txttimkiem = new TextBox();
            dtView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(322, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 31);
            label1.TabIndex = 0;
            label1.Text = "Khách Hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 62);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 1;
            label2.Text = "Điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 94);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 2;
            label3.Text = "Họ và tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(374, 62);
            label4.Name = "label4";
            label4.Size = new Size(50, 19);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(374, 94);
            label5.Name = "label5";
            label5.Size = new Size(61, 19);
            label5.TabIndex = 4;
            label5.Text = "Giới tính";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Location = new Point(103, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 2);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Location = new Point(103, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 2);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateBlue;
            panel3.Location = new Point(444, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 2);
            panel3.TabIndex = 6;
            // 
            // txtDienthoai
            // 
            txtDienthoai.BorderStyle = BorderStyle.None;
            txtDienthoai.Location = new Point(103, 63);
            txtDienthoai.Name = "txtDienthoai";
            txtDienthoai.Size = new Size(240, 16);
            txtDienthoai.TabIndex = 7;
            txtDienthoai.KeyPress += txtDienthoai_KeyPress;
            // 
            // txtHoten
            // 
            txtHoten.BorderStyle = BorderStyle.None;
            txtHoten.Location = new Point(103, 95);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(240, 16);
            txtHoten.TabIndex = 8;
            // 
            // txtDiachi
            // 
            txtDiachi.BorderStyle = BorderStyle.None;
            txtDiachi.Location = new Point(444, 63);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(240, 16);
            txtDiachi.TabIndex = 9;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Location = new Point(444, 93);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(51, 19);
            rbNam.TabIndex = 10;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Location = new Point(523, 93);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(41, 19);
            rbNu.TabIndex = 11;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
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
            btndong.Location = new Point(689, 472);
            btndong.Name = "btndong";
            btndong.Size = new Size(73, 32);
            btndong.TabIndex = 32;
            btndong.Text = "Đóng";
            btndong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndong.UseVisualStyleBackColor = false;
            btndong.Click += btndong_Click;
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
            btndanhsach.Location = new Point(544, 472);
            btndanhsach.Name = "btndanhsach";
            btndanhsach.Size = new Size(109, 32);
            btndanhsach.TabIndex = 31;
            btndanhsach.Text = "Danh sách";
            btndanhsach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndanhsach.UseVisualStyleBackColor = false;
            btndanhsach.Click += btndanhsach_Click;
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
            btnboqua.Location = new Point(424, 472);
            btnboqua.Name = "btnboqua";
            btnboqua.Size = new Size(84, 32);
            btnboqua.TabIndex = 30;
            btnboqua.Text = "Bỏ qua";
            btnboqua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnboqua.UseVisualStyleBackColor = false;
            btnboqua.Click += btndanhsach_Click;
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
            btnluu.Location = new Point(329, 472);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(59, 32);
            btnluu.TabIndex = 29;
            btnluu.Text = "Lưu";
            btnluu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnluu.UseVisualStyleBackColor = false;
            btnluu.Click += btnluu_Click;
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
            btnsua.Location = new Point(234, 472);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(59, 32);
            btnsua.TabIndex = 28;
            btnsua.Text = "Sửa";
            btnsua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsua.UseVisualStyleBackColor = false;
            btnsua.Click += btnsua_Click;
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
            btnxoa.Location = new Point(140, 472);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(58, 32);
            btnxoa.TabIndex = 27;
            btnxoa.Text = "Xoá";
            btnxoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnxoa.UseVisualStyleBackColor = false;
            btnxoa.Click += btnxoa_Click;
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
            btnthem.Location = new Point(29, 472);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(75, 32);
            btnthem.TabIndex = 26;
            btnthem.Text = "Thêm";
            btnthem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
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
            btntimkiem.Location = new Point(455, 422);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.RightToLeft = RightToLeft.Yes;
            btntimkiem.Size = new Size(112, 34);
            btntimkiem.TabIndex = 25;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.TextImageRelation = TextImageRelation.TextBeforeImage;
            btntimkiem.UseVisualStyleBackColor = false;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // txttimkiem
            // 
            txttimkiem.BorderStyle = BorderStyle.FixedSingle;
            txttimkiem.Location = new Point(242, 426);
            txttimkiem.Multiline = true;
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(191, 25);
            txttimkiem.TabIndex = 24;
            txttimkiem.KeyPress += txtDienthoai_KeyPress;
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
            dtView.Location = new Point(49, 142);
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
            dtView.TabIndex = 23;
            dtView.Click += dtView_Click;
            // 
            // FrmKhach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Controls.Add(rbNu);
            Controls.Add(rbNam);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDienthoai);
            Controls.Add(txtHoten);
            Controls.Add(txtDiachi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmKhach";
            Text = "FrmKhach";
            Load += FrmKhach_Load;
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtDienthoai;
        private TextBox txtHoten;
        private TextBox txtDiachi;
        private RadioButton rbNam;
        private RadioButton rbNu;
        private Button btndong;
        private Button btndanhsach;
        private Button btnboqua;
        private Button btnluu;
        private Button btnsua;
        private Button btnxoa;
        private Button btnthem;
        private Button btntimkiem;
        private TextBox txttimkiem;
        private DataGridView dtView;
    }
}