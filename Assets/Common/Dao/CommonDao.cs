using Assets.Common.Attributes;
using Assets.Common.Entity;
using Assets.Common.Tools;
using Assets.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Dao
{
    public abstract class CommonDao <T> where T : TableEntity,new()
    {

        public CommonDao()
        {
            setTableName();
            getPrimaryKey();
        }

        private string tableName;

        private string cmd_select_all = "select * from {0}";

        /// <summary>
        /// 根据主键
        /// </summary>
        private string cmd_select_by_id = "select * from {0} where {1} = ";

        private string cmd_select_by_field = "select * from {0} where {1} = {2}";

        protected void setTableName()
        {
            tableName = getEntityName();
        }

        protected void setPrimaryKey(string key)
        {
            cmd_select_by_id = String.Format(cmd_select_by_id, tableName, key);
        }

        protected SqlConnection getConnection()
        {
            SqlConnection conn = SQL.getConnectionByLocal(SQL.DATABASE_NAME);
            conn.Open();
            return conn;
        }

        protected string getEntityName()
        {
            Type type = typeof(T);
            string name = type.Name;//获取当前成员的名称
            string fullName = type.FullName;//获取类的全部名称不包括程序集
            string nameSpace = type.Namespace;//获取该类的命名空间
            var assembly = type.Assembly;//获取该类的程序集名
            var module = type.Module;//获取该类型的模块名            
            var memberInfos = type.GetMembers();//得到所有公共成员


            return name.ToLower();
        }

        protected void getPrimaryKey()
        {
            PropertyInfo[] peroperties = typeof(T).GetProperties();//BindingFlags.Public | BindingFlags.Instance

            foreach (PropertyInfo property in peroperties)
            {
                object[] objs = property.GetCustomAttributes(typeof(TableFieldAttribute), true);
                if (objs.Length > 0)
                {
                    Console.WriteLine("{0}: {1}", property.Name, ((TableFieldAttribute)objs[0]).FieldName);
                    //属性名 BrandId
                    string propertyName = property.Name;
                    //表字段名 brand_id
                    string fieldName = ((TableFieldAttribute)objs[0]).FieldName;
                    //表类型 int varchar...
                    string fieldType = ((TableFieldAttribute)objs[0]).FieldType;
                    //主键 true false
                    bool primaryKey = ((TableFieldAttribute)objs[0]).PrimaryKey;

                    if (primaryKey)
                    {
                        setPrimaryKey(fieldName);
                        return;
                    }
                        

                }
            }

        }

        protected void closeConnection(SqlConnection conn)
        {
            conn.Close();
        }

        protected List<T> findAll()
        {
            string cmd = String.Format(cmd_select_all, tableName);

            SqlConnection conn = getConnection();

            SqlCommand com = new SqlCommand(cmd, conn);
            SqlDataReader dr = com.ExecuteReader();
            List<T> list = new List<T>();
            while (dr.Read())
            {
                T t = foreachField(dr);
                list.Add(t);
            }

            closeConnection(conn);

            return list;
        }

        protected T findById(int id)
        {
            cmd_select_by_id += id;

            SqlConnection conn = getConnection();

            SqlCommand com = new SqlCommand(cmd_select_by_id, conn);
            SqlDataReader dr = com.ExecuteReader();
            T t = null;
            while (dr.Read())
            {
                t = foreachField(dr);
            }

            closeConnection(conn);

            return t;
        }

        protected T findByField()
        {
            return null;
        }

        //protected List<T> findByField()
        //{
        //    return new List<T>();
        //}

        /// <summary>
        /// 遍历字段，通过反射赋值给对象
        /// by teenyda
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        protected T foreachField(SqlDataReader dr)
        {
            T t = new T();

            int count = dr.VisibleFieldCount;
            // 遍历实体字段，利用反射赋值给对象
            for (int i = 0; i < count; i++)
            {
                string name = dr.GetName(i);
                string fieldName = Tool.analysisFieldName(name);
                object value = dr.GetValue(i);

                foreach (System.Reflection.PropertyInfo p in t.GetType().GetProperties())
                {
                    if (p.Name.Equals(fieldName))
                    {
                        object[] objs = p.GetCustomAttributes(typeof(EnumFieldAttribute), true);
                        //如果有枚举关联
                        if (objs.Length > 0)
                        {
                            object enumValue = Enum.Parse(((EnumFieldAttribute)objs[0]).EnumClazz, Convert.ToString(value));
                            p.SetValue(t, enumValue.ToString());
                        }
                        else
                        {
                            p.SetValue(t, value);
                        }

                        break;

                    }
                }
            }

            return t;

        }


        private void gg()
        {
            //if (p.PropertyType == typeof(string))
            //{
            //    values += string.Format("{0}='{1}', ", p.Name, p.GetValue(t));
            //}
            //if (p.PropertyType == typeof(int)|| p.PropertyType == typeof(uint))
            //{
            //    values += string.Format("{0}={1},", p.Name, p.GetValue(t));
            //}
            //if (p.PropertyType == typeof(DateTime))
            //{
            //    values += string.Format("{0}='{1}', ", p.Name, p.GetValue(t));
            //}
            //if (p.PropertyType == typeof(decimal) || p.PropertyType == typeof(double)|| p.PropertyType == typeof(float))
            //{
            //    values += string.Format("{0}={1}, ", p.Name, p.GetValue(t));
            //}

            //if (p.PropertyType == typeof(bool))
            //{
            //    values += string.Format("{0}={1}, ", p.Name, p.GetValue(t));
            //}
            //if (p.PropertyType == typeof(sbyte))
            //{
            //    values += string.Format("{0}={1}, ", p.Name, p.GetValue(t));
            //}
            //if (p.PropertyType == typeof(byte) || p.PropertyType == typeof(short) || p.PropertyType == typeof(ushort) )
            //{
            //    values += string.Format("{0}={1}, ", p.Name, p.GetValue(t));
            //}
            //if (p.PropertyType == typeof(long) || p.PropertyType == typeof(ulong))
            //{
            //    values += string.Format("{0}={1}, ", p.Name, p.GetValue(t));
            //}

            //values +=string.Format( "{0}={1},", p.Name, p.GetValue(t));
            //Console.WriteLine("Name:{0} Value:{1}", p.Name, p.GetValue(t));
        }

    }

}
