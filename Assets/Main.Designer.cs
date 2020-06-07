using System.Windows.Forms;
using Assets.AssetManage;

namespace Assets
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.资产管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AssetStorage_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.AssetsBorrow_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.AssetsReturn_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.AssetsRetirement_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.资产类别管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.类别添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.类别报废ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.品牌ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.存放地点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供应商ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1323, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜单";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.资产管理ToolStripMenuItem,
            this.资产类别管理ToolStripMenuItem,
            this.品牌ToolStripMenuItem,
            this.存放地点ToolStripMenuItem,
            this.供应商ToolStripMenuItem,
            this.部门管理ToolStripMenuItem,
            this.个人信息ToolStripMenuItem,
            this.连接数据库ToolStripMenuItem,
            this.测试窗口ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1315, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 资产管理ToolStripMenuItem
            // 
            this.资产管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AssetStorage_Item,
            this.AssetsBorrow_Item,
            this.AssetsReturn_Item,
            this.AssetsRetirement_Item});
            this.资产管理ToolStripMenuItem.Name = "资产管理ToolStripMenuItem";
            this.资产管理ToolStripMenuItem.Size = new System.Drawing.Size(94, 71);
            this.资产管理ToolStripMenuItem.Text = "资产管理";
            // 
            // AssetStorage_Item
            // 
            this.AssetStorage_Item.Name = "AssetStorage_Item";
            this.AssetStorage_Item.Size = new System.Drawing.Size(164, 30);
            this.AssetStorage_Item.Text = "资产入库";
            this.AssetStorage_Item.Click += new System.EventHandler(this.AssetStorage_Click);
            // 
            // AssetsBorrow_Item
            // 
            this.AssetsBorrow_Item.Name = "AssetsBorrow_Item";
            this.AssetsBorrow_Item.Size = new System.Drawing.Size(164, 30);
            this.AssetsBorrow_Item.Text = "资产借用";
            this.AssetsBorrow_Item.Click += new System.EventHandler(this.AssetsBorrow_Click);
            // 
            // AssetsReturn_Item
            // 
            this.AssetsReturn_Item.Name = "AssetsReturn_Item";
            this.AssetsReturn_Item.Size = new System.Drawing.Size(164, 30);
            this.AssetsReturn_Item.Text = "资产归还";
            this.AssetsReturn_Item.Click += new System.EventHandler(this.AssetsReturn_Click);
            // 
            // AssetsRetirement_Item
            // 
            this.AssetsRetirement_Item.Name = "AssetsRetirement_Item";
            this.AssetsRetirement_Item.Size = new System.Drawing.Size(164, 30);
            this.AssetsRetirement_Item.Text = "资产报废";
            this.AssetsRetirement_Item.Click += new System.EventHandler(this.AssetsRetirement_Click);
            // 
            // 资产类别管理ToolStripMenuItem
            // 
            this.资产类别管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.类别添加ToolStripMenuItem,
            this.类别报废ToolStripMenuItem});
            this.资产类别管理ToolStripMenuItem.Name = "资产类别管理ToolStripMenuItem";
            this.资产类别管理ToolStripMenuItem.Size = new System.Drawing.Size(130, 71);
            this.资产类别管理ToolStripMenuItem.Text = "资产类别管理";
            // 
            // 类别添加ToolStripMenuItem
            // 
            this.类别添加ToolStripMenuItem.Name = "类别添加ToolStripMenuItem";
            this.类别添加ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.类别添加ToolStripMenuItem.Text = "类别添加";
            this.类别添加ToolStripMenuItem.Click += new System.EventHandler(this.AssetsClassAdd_Click);
            // 
            // 类别报废ToolStripMenuItem
            // 
            this.类别报废ToolStripMenuItem.Name = "类别报废ToolStripMenuItem";
            this.类别报废ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.类别报废ToolStripMenuItem.Text = "类别报废";
            this.类别报废ToolStripMenuItem.Click += new System.EventHandler(this.AssetsClassRetirement_Click);
            // 
            // 品牌ToolStripMenuItem
            // 
            this.品牌ToolStripMenuItem.Name = "品牌ToolStripMenuItem";
            this.品牌ToolStripMenuItem.Size = new System.Drawing.Size(58, 71);
            this.品牌ToolStripMenuItem.Text = "品牌";
            this.品牌ToolStripMenuItem.Click += new System.EventHandler(this.Brand_Click);
            // 
            // 存放地点ToolStripMenuItem
            // 
            this.存放地点ToolStripMenuItem.Name = "存放地点ToolStripMenuItem";
            this.存放地点ToolStripMenuItem.Size = new System.Drawing.Size(94, 71);
            this.存放地点ToolStripMenuItem.Text = "存放地点";
            this.存放地点ToolStripMenuItem.Click += new System.EventHandler(this.Place_Click);
            // 
            // 供应商ToolStripMenuItem
            // 
            this.供应商ToolStripMenuItem.Name = "供应商ToolStripMenuItem";
            this.供应商ToolStripMenuItem.Size = new System.Drawing.Size(76, 71);
            this.供应商ToolStripMenuItem.Text = "供应商";
            this.供应商ToolStripMenuItem.Click += new System.EventHandler(this.Supplier_Click);
            // 
            // 部门管理ToolStripMenuItem
            // 
            this.部门管理ToolStripMenuItem.Name = "部门管理ToolStripMenuItem";
            this.部门管理ToolStripMenuItem.Size = new System.Drawing.Size(94, 71);
            this.部门管理ToolStripMenuItem.Text = "部门管理";
            this.部门管理ToolStripMenuItem.Click += new System.EventHandler(this.Department_Click);
            // 
            // 个人信息ToolStripMenuItem
            // 
            this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(94, 71);
            this.个人信息ToolStripMenuItem.Text = "个人信息";
            this.个人信息ToolStripMenuItem.Click += new System.EventHandler(this.Information_Click);
            // 
            // 连接数据库ToolStripMenuItem
            // 
            this.连接数据库ToolStripMenuItem.Name = "连接数据库ToolStripMenuItem";
            this.连接数据库ToolStripMenuItem.Size = new System.Drawing.Size(112, 71);
            this.连接数据库ToolStripMenuItem.Text = "连接数据库";
            this.连接数据库ToolStripMenuItem.Click += new System.EventHandler(this.ConnectionSql_Click);
            // 
            // 测试窗口ToolStripMenuItem
            // 
            this.测试窗口ToolStripMenuItem.Name = "测试窗口ToolStripMenuItem";
            this.测试窗口ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.测试窗口ToolStripMenuItem.Text = "测试窗口";
            this.测试窗口ToolStripMenuItem.Click += new System.EventHandler(this.Text_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(22, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 512);
            this.panel1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "资管管理系统";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 资产管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AssetStorage_Item;
        private System.Windows.Forms.ToolStripMenuItem AssetsBorrow_Item;
        private System.Windows.Forms.ToolStripMenuItem AssetsReturn_Item;
        private System.Windows.Forms.ToolStripMenuItem AssetsRetirement_Item;
        private System.Windows.Forms.ToolStripMenuItem 资产类别管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 类别添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 类别报废ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 品牌ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存放地点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供应商ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private ToolStripMenuItem 连接数据库ToolStripMenuItem;
        private ToolStripMenuItem 测试窗口ToolStripMenuItem;
    }
}

