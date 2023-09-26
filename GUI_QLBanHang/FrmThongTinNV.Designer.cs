namespace GUI_QLBanHang
{
    partial class FrmThongTinNV
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtOldpass = new TextBox();
            txtNewpass = new TextBox();
            txtNewpassRepeat = new TextBox();
            btnUpdate = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.key;
            pictureBox1.Location = new Point(74, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 111);
            label1.Name = "label1";
            label1.Size = new Size(199, 21);
            label1.TabIndex = 1;
            label1.Text = "Đổi Mật Khẩu Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 145);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Email Nhân Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 194);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 3;
            label3.Text = "Mật Khẩu Cũ ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 243);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 4;
            label4.Text = "Mật Khẩu Mới";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 292);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 5;
            label5.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(19, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtOldpass
            // 
            txtOldpass.BorderStyle = BorderStyle.FixedSingle;
            txtOldpass.Location = new Point(19, 212);
            txtOldpass.Name = "txtOldpass";
            txtOldpass.Size = new Size(250, 23);
            txtOldpass.TabIndex = 7;
            // 
            // txtNewpass
            // 
            txtNewpass.BorderStyle = BorderStyle.FixedSingle;
            txtNewpass.Location = new Point(19, 261);
            txtNewpass.Name = "txtNewpass";
            txtNewpass.Size = new Size(250, 23);
            txtNewpass.TabIndex = 8;
            // 
            // txtNewpassRepeat
            // 
            txtNewpassRepeat.BorderStyle = BorderStyle.FixedSingle;
            txtNewpassRepeat.Location = new Point(19, 310);
            txtNewpassRepeat.Name = "txtNewpassRepeat";
            txtNewpassRepeat.Size = new Size(250, 23);
            txtNewpassRepeat.TabIndex = 9;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkSlateBlue;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(84, 339);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 32);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Đổi Mật Khẩu";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += txtUpdate_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.DarkSlateBlue;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = SystemColors.ButtonFace;
            btnThoat.Location = new Point(84, 379);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(121, 32);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // FrmThongTinNV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 423);
            Controls.Add(btnThoat);
            Controls.Add(btnUpdate);
            Controls.Add(txtNewpassRepeat);
            Controls.Add(txtNewpass);
            Controls.Add(txtOldpass);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmThongTinNV";
            Text = "FrmThongTinNV";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtOldpass;
        private TextBox txtNewpass;
        private TextBox txtNewpassRepeat;
        private Button btnUpdate;
        private Button btnThoat;
    }
}