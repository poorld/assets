using Assets.Common.Dao;
using Assets.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Common.Entity;
using Assets.Common.Tools;

namespace Assets.Views.BrandManage.Dao
{
    class BrandDao : CommonDao<Brand>
    {
        public List<Brand> getBrands()
        {
            return base.findAll();
        }

        public void test()
        {
            base.findById(100001);
        }
    }
}
