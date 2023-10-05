namespace GUI_QLBanHang
{
    partial class FrmThongKe
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
            menuStrip1 = new MenuStrip();
            sảnPhẩmNhậpKhoToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmTồnKhoToolStripMenuItem = new ToolStripMenuItem();
            panelContainer = new Panel();
            dtView = new DataGridView();
            menuStrip1.SuspendLayout();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sảnPhẩmNhậpKhoToolStripMenuItem, sảnPhẩmTồnKhoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sảnPhẩmNhậpKhoToolStripMenuItem
            // 
            sảnPhẩmNhậpKhoToolStripMenuItem.Name = "sảnPhẩmNhậpKhoToolStripMenuItem";
            sảnPhẩmNhậpKhoToolStripMenuItem.Size = new Size(125, 20);
            sảnPhẩmNhậpKhoToolStripMenuItem.Text = "Sản phẩm nhập kho";
            sảnPhẩmNhậpKhoToolStripMenuItem.Click += sảnPhẩmNhậpKhoToolStripMenuItem_Click;
            // 
            // sảnPhẩmTồnKhoToolStripMenuItem
            // 
            sảnPhẩmTồnKhoToolStripMenuItem.Name = "sảnPhẩmTồnKhoToolStripMenuItem";
            sảnPhẩmTồnKhoToolStripMenuItem.Size = new Size(116, 20);
            sảnPhẩmTồnKhoToolStripMenuItem.Text = "Sản phẩm tồn kho";
            sảnPhẩmTồnKhoToolStripMenuItem.Click += sảnPhẩmTồnKhoToolStripMenuItem_Click;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(dtView);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 24);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(800, 502);
            panelContainer.TabIndex = 1;
            // 
            // dtView
            // 
            dtView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtView.BackgroundColor = Color.White;
            dtView.BorderStyle = BorderStyle.None;
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
            dtView.Location = new Point(12, 15);
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
            dtView.Size = new Size(776, 420);
            dtView.TabIndex = 37;
            // 
            // FrmThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 526);
            Controls.Add(panelContainer);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "FrmThongKe";
            Text = "Thống kê";
            Load += FrmThongKe_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sảnPhẩmNhậpKhoToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmTồnKhoToolStripMenuItem;
        private Panel panelContainer;
        private DataGridView dtView;
    }
}