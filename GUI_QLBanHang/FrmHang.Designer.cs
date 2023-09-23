namespace GUI_QLBanHang
{
    partial class FrmHang
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtmahang = new TextBox();
            txttenhang = new TextBox();
            txtsoluong = new TextBox();
            txtdongianhap = new TextBox();
            txtdongiaban = new TextBox();
            txthinh = new TextBox();
            txtghichu = new TextBox();
            btnmo = new Button();
            pichinh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pichinh).BeginInit();
            SuspendLayout();
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
            btndong.Location = new Point(680, 494);
            btndong.Name = "btndong";
            btndong.Size = new Size(73, 32);
            btndong.TabIndex = 45;
            btndong.Text = "Đóng";
            btndong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndong.UseVisualStyleBackColor = false;
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
            btndanhsach.Location = new Point(535, 494);
            btndanhsach.Name = "btndanhsach";
            btndanhsach.Size = new Size(109, 32);
            btndanhsach.TabIndex = 44;
            btndanhsach.Text = "Danh sách";
            btndanhsach.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndanhsach.UseVisualStyleBackColor = false;
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
            btnboqua.Location = new Point(415, 494);
            btnboqua.Name = "btnboqua";
            btnboqua.Size = new Size(84, 32);
            btnboqua.TabIndex = 43;
            btnboqua.Text = "Bỏ qua";
            btnboqua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnboqua.UseVisualStyleBackColor = false;
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
            btnluu.Location = new Point(320, 494);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(59, 32);
            btnluu.TabIndex = 42;
            btnluu.Text = "Lưu";
            btnluu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnluu.UseVisualStyleBackColor = false;
            // 
            // btnsua
            // 
            btnsua.BackColor = SystemColors.MenuHighlight;
            btnsua.FlatAppearance.BorderSize = 0;
            btnsua.FlatStyle = FlatStyle.Flat;
            btnsua.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnsua.ForeColor = SystemColors.Control;
            btnsua.Image = Properties.Resources.edit;
            btnsua.Location = new Point(225, 494);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(59, 32);
            btnsua.TabIndex = 41;
            btnsua.Text = "Sửa";
            btnsua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsua.UseVisualStyleBackColor = false;
            // 
            // btnxoa
            // 
            btnxoa.BackColor = SystemColors.MenuHighlight;
            btnxoa.FlatAppearance.BorderSize = 0;
            btnxoa.FlatStyle = FlatStyle.Flat;
            btnxoa.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnxoa.ForeColor = SystemColors.Control;
            btnxoa.Image = Properties.Resources.delete;
            btnxoa.Location = new Point(131, 494);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(58, 32);
            btnxoa.TabIndex = 40;
            btnxoa.Text = "Xoá";
            btnxoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnxoa.UseVisualStyleBackColor = false;
            // 
            // btnthem
            // 
            btnthem.BackColor = SystemColors.MenuHighlight;
            btnthem.FlatAppearance.BorderSize = 0;
            btnthem.FlatStyle = FlatStyle.Flat;
            btnthem.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnthem.ForeColor = SystemColors.Control;
            btnthem.Image = Properties.Resources.add1;
            btnthem.Location = new Point(20, 494);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(75, 32);
            btnthem.TabIndex = 39;
            btnthem.Text = "Thêm";
            btnthem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnthem.UseVisualStyleBackColor = false;
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
            btntimkiem.Location = new Point(462, 444);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.RightToLeft = RightToLeft.Yes;
            btntimkiem.Size = new Size(112, 34);
            btntimkiem.TabIndex = 38;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.TextImageRelation = TextImageRelation.TextBeforeImage;
            btntimkiem.UseVisualStyleBackColor = false;
            // 
            // txttimkiem
            // 
            txttimkiem.BorderStyle = BorderStyle.FixedSingle;
            txttimkiem.Location = new Point(249, 448);
            txttimkiem.Multiline = true;
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(191, 25);
            txttimkiem.TabIndex = 37;
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
            dtView.Location = new Point(56, 241);
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
            dtView.Size = new Size(676, 188);
            dtView.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(337, 4);
            label1.Name = "label1";
            label1.Size = new Size(124, 27);
            label1.TabIndex = 23;
            label1.Text = "Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 59);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 46;
            label2.Text = "Mã hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 93);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 47;
            label3.Text = "Tên hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 127);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 48;
            label4.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 161);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 49;
            label5.Text = "Đơn giá nhập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 195);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 50;
            label6.Text = "Đơn giá bán";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(363, 50);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 51;
            label7.Text = "Hình";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(363, 137);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 52;
            label8.Text = "Ghi Chú";
            // 
            // txtmahang
            // 
            txtmahang.BorderStyle = BorderStyle.FixedSingle;
            txtmahang.Location = new Point(106, 55);
            txtmahang.Name = "txtmahang";
            txtmahang.Size = new Size(232, 23);
            txtmahang.TabIndex = 53;
            // 
            // txttenhang
            // 
            txttenhang.BorderStyle = BorderStyle.FixedSingle;
            txttenhang.Location = new Point(106, 89);
            txttenhang.Name = "txttenhang";
            txttenhang.Size = new Size(232, 23);
            txttenhang.TabIndex = 54;
            // 
            // txtsoluong
            // 
            txtsoluong.BorderStyle = BorderStyle.FixedSingle;
            txtsoluong.Location = new Point(106, 123);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(232, 23);
            txtsoluong.TabIndex = 55;
            // 
            // txtdongianhap
            // 
            txtdongianhap.BorderStyle = BorderStyle.FixedSingle;
            txtdongianhap.Location = new Point(106, 157);
            txtdongianhap.Name = "txtdongianhap";
            txtdongianhap.Size = new Size(232, 23);
            txtdongianhap.TabIndex = 56;
            // 
            // txtdongiaban
            // 
            txtdongiaban.BorderStyle = BorderStyle.FixedSingle;
            txtdongiaban.Location = new Point(106, 191);
            txtdongiaban.Name = "txtdongiaban";
            txtdongiaban.Size = new Size(232, 23);
            txtdongiaban.TabIndex = 57;
            // 
            // txthinh
            // 
            txthinh.BorderStyle = BorderStyle.FixedSingle;
            txthinh.Location = new Point(363, 72);
            txthinh.Multiline = true;
            txthinh.Name = "txthinh";
            txthinh.Size = new Size(172, 57);
            txthinh.TabIndex = 58;
            // 
            // txtghichu
            // 
            txtghichu.BorderStyle = BorderStyle.FixedSingle;
            txtghichu.Location = new Point(363, 158);
            txtghichu.Multiline = true;
            txtghichu.Name = "txtghichu";
            txtghichu.Size = new Size(172, 57);
            txtghichu.TabIndex = 59;
            // 
            // btnmo
            // 
            btnmo.FlatStyle = FlatStyle.Flat;
            btnmo.Image = Properties.Resources.openfile;
            btnmo.Location = new Point(541, 72);
            btnmo.Name = "btnmo";
            btnmo.Size = new Size(77, 34);
            btnmo.TabIndex = 60;
            btnmo.Text = "Mở hình";
            btnmo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnmo.UseVisualStyleBackColor = true;
            // 
            // pichinh
            // 
            pichinh.Location = new Point(624, 72);
            pichinh.Name = "pichinh";
            pichinh.Size = new Size(142, 142);
            pichinh.TabIndex = 61;
            pichinh.TabStop = false;
            // 
            // FrmHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 538);
            Controls.Add(pichinh);
            Controls.Add(btnmo);
            Controls.Add(txtghichu);
            Controls.Add(txthinh);
            Controls.Add(txtdongiaban);
            Controls.Add(txtdongianhap);
            Controls.Add(txtsoluong);
            Controls.Add(txttenhang);
            Controls.Add(txtmahang);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
            Controls.Add(label1);
            Name = "FrmHang";
            Text = "FrmHang";
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pichinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtmahang;
        private TextBox txttenhang;
        private TextBox txtsoluong;
        private TextBox txtdongianhap;
        private TextBox txtdongiaban;
        private TextBox txthinh;
        private TextBox txtghichu;
        private Button btnmo;
        private PictureBox pichinh;
    }
}