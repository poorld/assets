using Assets.AssetManage;
using Assets.AssetsClass;
using Assets.BrandManage;
using Assets.Common.Enums;
using Assets.Common.Tools;
using Assets.DB;
using Assets.DepartmentManage;
using Assets.InformationManage;
using Assets.PlaceManage;
using Assets.SupplierManage;
using Assets.Test.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// teenyda
/// </summary>
namespace Assets
{
    public partial class Main : Form
    {

        private AssetsStorage assetsStorage = new AssetsStorage();

        private AssetsBorrow assetsBorrow = new AssetsBorrow();

        private AssetsRetirement assetsRetirement = new AssetsRetirement();

        private AssetsReturn assetsReturn = new AssetsReturn();

        private AssetsClassForm assetsClassAdd = new AssetsClassForm();

        private AssetsClassRetirement assetsClassRetirement = new AssetsClassRetirement();

        private BrandForm brand = new BrandForm();

        private DepartmentForm department = new DepartmentForm();

        private Information information = new Information();

        private PlaceForm place = new PlaceForm();

        private SupplierForm supplier = new SupplierForm();



        public Main()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void Main_Load(object sender, EventArgs e)
        {
            // 资产入库为主界面

            //嵌入子窗体到父窗体中，把添加学员信息嵌入到主窗体右侧
            assetsStorage.TopLevel = false; //将子窗体设置成非最高层，非顶级控件
            assetsStorage.WindowState = FormWindowState.Maximized;//将当前窗口设置成最大化
            assetsStorage.FormBorderStyle = FormBorderStyle.None;//去掉窗体边框
            assetsStorage.Parent = this.panel1;//指定子窗体显示的容器
            assetsStorage.Show();


        }

        private void Show_Form(Form form)
        {
            this.panel1.Controls.Clear();
            //AssetStorage assetStorage = new AssetStorage();
            //嵌入子窗体到父窗体中，把添加学员信息嵌入到主窗体右侧
            form.TopLevel = false; //将子窗体设置成非最高层，非顶级控件
            form.WindowState = FormWindowState.Maximized;//将当前窗口设置成最大化
            form.FormBorderStyle = FormBorderStyle.None;//去掉窗体边框
            form.Parent = this.panel1;//指定子窗体显示的容器
            form.Show();
        }

        // 资产入库
        private void AssetStorage_Click(object sender, EventArgs e)
        {
            Show_Form(assetsStorage);
        }

        // 资产借用
        private void AssetsBorrow_Click(object sender, EventArgs e)
        {
            Show_Form(assetsBorrow);
        }

        // 资产归还
        private void AssetsReturn_Click(object sender, EventArgs e)
        {
            Show_Form(assetsReturn);
        }

        // 资产报废
        private void AssetsRetirement_Click(object sender, EventArgs e)
        {
            Show_Form(assetsRetirement);
        }

        //类别添加
        private void AssetsClassAdd_Click(object sender, EventArgs e)
        {
            Show_Form(assetsClassAdd);
        }

        //类别报废
        private void AssetsClassRetirement_Click(object sender, EventArgs e)
        {
            Show_Form(assetsClassRetirement);
        }

        //品牌
        private void Brand_Click(object sender, EventArgs e)
        {
            Show_Form(brand);
        }

        //存放地点
        private void Place_Click(object sender, EventArgs e)
        {
            Show_Form(place);
        }

        //供应商
        private void Supplier_Click(object sender, EventArgs e)
        {
            Show_Form(supplier);
        }


        //部门
        private void Department_Click(object sender, EventArgs e)
        {
            Show_Form(department);
        }

        //供应商
        private void Information_Click(object sender, EventArgs e)
        {
            Show_Form(information);
        }

        private void ConnectionSql_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQL.getConnectionByLocal(SQL.DATABASE_NAME);
            if (conn != null)
            {
                conn.Open();
            }
        }

        private void Text_Click(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
            //form.Show();
            Common.Entity.Brand brand = new Common.Entity.Brand();

            Type type = typeof(Common.Entity.Brand);
            string name = type.Name;//获取当前成员的名称
            string fullName = type.FullName;//获取类的全部名称不包括程序集
            string nameSpace = type.Namespace;//获取该类的命名空间
            var assembly = type.Assembly;//获取该类的程序集名
            var module = type.Module;//获取该类型的模块名            
            var memberInfos = type.GetMembers();//得到所有公共成员

            string name1 = Tool.analysisFieldName("brand_id");
            string name2 = Tool.analysisFieldName("hello_ni_hao");

            object o = Enum.Parse(typeof(BrandState), "1");

        }



    }
}
