namespace PRL
{
    partial class FormSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSanPham));
            dgv_SanPham = new DataGridView();
            ptb_SanPham = new PictureBox();
            txt_Ten = new TextBox();
            txt_Mota = new TextBox();
            txt_Gia = new TextBox();
            txt_Search = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbb_TrangThai = new ComboBox();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            btn_Reset = new Button();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_SanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_SanPham
            // 
            dgv_SanPham.BackgroundColor = Color.FromArgb(128, 255, 128);
            dgv_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SanPham.Location = new Point(6, 26);
            dgv_SanPham.Name = "dgv_SanPham";
            dgv_SanPham.Size = new Size(1038, 373);
            dgv_SanPham.TabIndex = 0;
            dgv_SanPham.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ptb_SanPham
            // 
            ptb_SanPham.BackColor = Color.Maroon;
            ptb_SanPham.Location = new Point(12, 16);
            ptb_SanPham.Name = "ptb_SanPham";
            ptb_SanPham.Size = new Size(331, 272);
            ptb_SanPham.TabIndex = 1;
            ptb_SanPham.TabStop = false;
            // 
            // txt_Ten
            // 
            txt_Ten.Font = new Font("Segoe UI", 12F);
            txt_Ten.Location = new Point(374, 39);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.PlaceholderText = "Tên sản phẩm...";
            txt_Ten.Size = new Size(246, 29);
            txt_Ten.TabIndex = 2;
            // 
            // txt_Mota
            // 
            txt_Mota.Font = new Font("Segoe UI", 12F);
            txt_Mota.Location = new Point(635, 39);
            txt_Mota.Multiline = true;
            txt_Mota.Name = "txt_Mota";
            txt_Mota.PlaceholderText = "Mô tả...";
            txt_Mota.Size = new Size(246, 84);
            txt_Mota.TabIndex = 3;
            // 
            // txt_Gia
            // 
            txt_Gia.Font = new Font("Segoe UI", 12F);
            txt_Gia.Location = new Point(374, 94);
            txt_Gia.Name = "txt_Gia";
            txt_Gia.PlaceholderText = "Giá bán...";
            txt_Gia.Size = new Size(246, 29);
            txt_Gia.TabIndex = 4;
            // 
            // txt_Search
            // 
            txt_Search.Font = new Font("Segoe UI", 12F);
            txt_Search.Location = new Point(394, 253);
            txt_Search.Name = "txt_Search";
            txt_Search.PlaceholderText = "Nhập tên sản phẩm...";
            txt_Search.Size = new Size(474, 29);
            txt_Search.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(374, 16);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 7;
            label1.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(374, 71);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 7;
            label2.Text = "Giá bán:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(635, 16);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 7;
            label3.Text = "Mô tả:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(374, 182);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 7;
            label4.Text = "Trạng thái:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(374, 126);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 7;
            label5.Text = "Số lượng";
            // 
            // cbb_TrangThai
            // 
            cbb_TrangThai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_TrangThai.FormattingEnabled = true;
            cbb_TrangThai.Items.AddRange(new object[] { "Sắp hết hàng" });
            cbb_TrangThai.Location = new Point(374, 205);
            cbb_TrangThai.Name = "cbb_TrangThai";
            cbb_TrangThai.Size = new Size(246, 29);
            cbb_TrangThai.TabIndex = 8;
            cbb_TrangThai.Text = "Chọn trạng thái";
            // 
            // btn_Them
            // 
            btn_Them.BackColor = Color.FromArgb(255, 128, 255);
            btn_Them.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Them.ForeColor = Color.Black;
            btn_Them.Image = Properties.Resources.Add;
            btn_Them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Them.Location = new Point(916, 39);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(146, 44);
            btn_Them.TabIndex = 9;
            btn_Them.Text = "  Thêm mới";
            btn_Them.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            btn_Sua.BackColor = Color.FromArgb(255, 128, 255);
            btn_Sua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Sua.ForeColor = Color.Black;
            btn_Sua.Image = Properties.Resources.Edit;
            btn_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Sua.Location = new Point(916, 102);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(146, 44);
            btn_Sua.TabIndex = 10;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = Color.FromArgb(255, 128, 255);
            btn_Xoa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Xoa.ForeColor = Color.Black;
            btn_Xoa.Image = (Image)resources.GetObject("btn_Xoa.Image");
            btn_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Xoa.Location = new Point(916, 244);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(146, 44);
            btn_Xoa.TabIndex = 11;
            btn_Xoa.Text = "Tìm kiếm";
            btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Reset
            // 
            btn_Reset.BackColor = Color.FromArgb(255, 128, 255);
            btn_Reset.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Reset.ForeColor = Color.Black;
            btn_Reset.Image = Properties.Resources.reset;
            btn_Reset.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Reset.Location = new Point(916, 169);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(146, 44);
            btn_Reset.TabIndex = 12;
            btn_Reset.Text = "Làm mới";
            btn_Reset.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(374, 149);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(246, 29);
            numericUpDown1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(635, 126);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 7;
            label6.Text = "Mã loại:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(635, 148);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Mã sản phẩm...";
            textBox1.Size = new Size(246, 29);
            textBox1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(635, 182);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 7;
            label7.Text = "Mã nhà cung cấp:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(635, 205);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Mã nhà cung cấp...";
            textBox2.Size = new Size(246, 29);
            textBox2.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_SanPham);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 294);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1050, 405);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bảng thông tin các sản phẩm";
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1074, 711);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(btn_Reset);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(cbb_TrangThai);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Search);
            Controls.Add(txt_Gia);
            Controls.Add(txt_Mota);
            Controls.Add(txt_Ten);
            Controls.Add(ptb_SanPham);
            Name = "FormSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_SanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_SanPham;
        private PictureBox ptb_SanPham;
        private TextBox txt_Ten;
        private TextBox txt_Mota;
        private TextBox txt_Gia;
        private TextBox txt_Search;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbb_TrangThai;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_Reset;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private TextBox textBox2;
        private GroupBox groupBox1;
    }
}