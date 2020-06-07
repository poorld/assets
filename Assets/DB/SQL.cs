using Assets.Common.Exception;
using Assets.Common.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets.DB
{
    class SQL
    {
        /// <summary>
        /// 数据库名称
        /// </summary>
        public const string DATABASE_NAME = "assets";





        public static SqlConnection getSqlServerConnection()
        {
            string connectStr = "Data Source=PC-913135;Initial Catalog=Student;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(connectStr);
            return sqlCon;
        }

        public static SqlConnection getConnectionByLocal(string dbName)
        {
            startMSSQLSERVER();

            string localHostName = Tool.getLocalHostName();
            string connectStr = "Data Source={0};Initial Catalog={1};Integrated Security=True";
            connectStr = String.Format(connectStr, localHostName, dbName);
            SqlConnection sqlCon = new SqlConnection(connectStr);
            Console.WriteLine(sqlCon.State);
            try
            {
                sqlCon.Open();
                sqlCon.Close();
                //MessageBox.Show("数据库连接成功!");
                return sqlCon;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                
            }

            return null;
        }

        public static bool startMSSQLSERVER()
        {
            ServiceController sc = new ServiceController("MSSQLSERVER");
            //判断服务是否已经关闭
            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                sc.Start();
                return true;
            }

            return false;
        }

        public static bool stopMSSQLSERVER()
        {
            ServiceController sc = new ServiceController("MSSQLSERVER");
            //判断服务是否已经开启
            if (sc.Status != ServiceControllerStatus.Stopped)
            {
                sc.Stop();
                return true;
            }
            return false;
        }


        public static void getMysqlConnection()
        {

        }

    }
}
