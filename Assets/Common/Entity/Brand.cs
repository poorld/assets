using Assets.Common.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Entity
{
    /// <summary>
    /// 品牌
    /// </summary>
    class Brand : TableEntity
    {
        private int brandId;
        [TableField("brand_id", "int", true)]
        public int BrandId
        {
            get { return brandId; }
            set { brandId = value; }
        }

        private string brandCode;
        [TableField("brand_code", "nchar(10)")]
        public string BrandCode
        {
            get { return brandCode; }
            set { brandCode = value; }
        }

        private string brandName;
        [TableField("brand_name", "nvarchar(50)")]
        public string BrandName
        {
            get { return brandName; }
            set { brandName = value; }
        }

        private int brandState;
        [TableField("brand_state", "int")]
        public int BrandState
        {
            get { return brandState; }
            set { brandState = value; }
        }
        
    }
}
