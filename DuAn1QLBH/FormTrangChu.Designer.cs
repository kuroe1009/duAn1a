namespace PRL
{
    partial class FormTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            mstr_Menu = new MenuStrip();
            tool_BanHang = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            nhàToolStripMenuItem = new ToolStripMenuItem();
            loạiHàngToolStripMenuItem = new ToolStripMenuItem();
            giảmGiáToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            mstr_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(313, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 192, 128);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(313, 63);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1384, 878);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // mstr_Menu
            // 
            mstr_Menu.BackColor = Color.FromArgb(255, 224, 192);
            mstr_Menu.Dock = DockStyle.Left;
            mstr_Menu.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            mstr_Menu.GripStyle = ToolStripGripStyle.Visible;
            mstr_Menu.ImageScalingSize = new Size(20, 20);
            mstr_Menu.Items.AddRange(new ToolStripItem[] { tool_BanHang, sảnPhẩmToolStripMenuItem, hóaĐơnToolStripMenuItem, nhàToolStripMenuItem, loạiHàngToolStripMenuItem, giảmGiáToolStripMenuItem, kháchHàngToolStripMenuItem, thoátToolStripMenuItem });
            mstr_Menu.Location = new Point(0, 0);
            mstr_Menu.Name = "mstr_Menu";
            mstr_Menu.Padding = new Padding(7, 240, 0, 3);
            mstr_Menu.Size = new Size(314, 941);
            mstr_Menu.TabIndex = 2;
            mstr_Menu.Text = "menuStrip1";
            mstr_Menu.ItemClicked += mstr_Menu_ItemClicked;
            // 
            // tool_BanHang
            // 
            tool_BanHang.Image = (Image)resources.GetObject("tool_BanHang.Image");
            tool_BanHang.ImageAlign = ContentAlignment.MiddleRight;
            tool_BanHang.ImageScaling = ToolStripItemImageScaling.None;
            tool_BanHang.Name = "tool_BanHang";
            tool_BanHang.Padding = new Padding(0, 25, 0, 10);
            tool_BanHang.Size = new Size(299, 82);
            tool_BanHang.Text = "Bán Hàng";
            tool_BanHang.Click += tool_BanHang_Click;
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.Image = (Image)resources.GetObject("sảnPhẩmToolStripMenuItem.Image");
            sảnPhẩmToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            sảnPhẩmToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Padding = new Padding(0, 25, 0, 10);
            sảnPhẩmToolStripMenuItem.Size = new Size(299, 82);
            sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            sảnPhẩmToolStripMenuItem.Click += sảnPhẩmToolStripMenuItem_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Image = Properties.Resources.Capture3;
            hóaĐơnToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            hóaĐơnToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Padding = new Padding(0, 25, 0, 10);
            hóaĐơnToolStripMenuItem.Size = new Size(299, 82);
            hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            hóaĐơnToolStripMenuItem.Click += hóaĐơnToolStripMenuItem_Click;
            // 
            // nhàToolStripMenuItem
            // 
            nhàToolStripMenuItem.Image = Properties.Resources.Capture5;
            nhàToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            nhàToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            nhàToolStripMenuItem.Name = "nhàToolStripMenuItem";
            nhàToolStripMenuItem.Padding = new Padding(0, 25, 0, 10);
            nhàToolStripMenuItem.Size = new Size(299, 82);
            nhàToolStripMenuItem.Text = "Nhà Cung Cấp ";
            nhàToolStripMenuItem.Click += nhàToolStripMenuItem_Click;
            // 
            // loạiHàngToolStripMenuItem
            // 
            loạiHàngToolStripMenuItem.Image = Properties.Resources.Capture1;
            loạiHàngToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            loạiHàngToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            loạiHàngToolStripMenuItem.Name = "loạiHàngToolStripMenuItem";
            loạiHàngToolStripMenuItem.Padding = new Padding(0, 25, 0, 10);
            loạiHàngToolStripMenuItem.Size = new Size(299, 82);
            loạiHàngToolStripMenuItem.Text = "Loại Hàng";
            loạiHàngToolStripMenuItem.Click += loạiHàngToolStripMenuItem_Click;
            // 
            // giảmGiáToolStripMenuItem
            // 
            giảmGiáToolStripMenuItem.Image = Properties.Resources.Capture91;
            giảmGiáToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            giảmGiáToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            giảmGiáToolStripMenuItem.Name = "giảmGiáToolStripMenuItem";
            giảmGiáToolStripMenuItem.Padding = new Padding(0, 25, 0, 10);
            giảmGiáToolStripMenuItem.Size = new Size(299, 82);
            giảmGiáToolStripMenuItem.Text = "Giảm Giá";
            giảmGiáToolStripMenuItem.Click += giảmGiáToolStripMenuItem_Click;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Image = Properties.Resources.Capture10;
            kháchHàngToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            kháchHàngToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Padding = new Padding(0, 25, 0, 10);
            kháchHàngToolStripMenuItem.Size = new Size(299, 82);
            kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Image = Properties.Resources.cancelpng;
            thoátToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            thoátToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Padding = new Padding(0, 25, 0, 10);
            thoátToolStripMenuItem.Size = new Size(299, 82);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // FormTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1694, 941);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(mstr_Menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mstr_Menu;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1712, 1144);
            MinimumSize = new Size(855, 564);
            Name = "FormTrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTrangChu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            mstr_Menu.ResumeLayout(false);
            mstr_Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MenuStrip mstr_Menu;
        private ToolStripMenuItem tool_BanHang;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem nhàToolStripMenuItem;
        private ToolStripMenuItem loạiHàngToolStripMenuItem;
        private ToolStripMenuItem giảmGiáToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
    }
}