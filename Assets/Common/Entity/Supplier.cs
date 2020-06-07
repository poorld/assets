using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Entity
{
    /// <summary>
    /// 供应商
    /// </summary>
    class Supplier : TableEntity
    {
        private int supplierId;

        public int SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }
        private string supplierApellation;

        public string SupplierApellation
        {
            get { return supplierApellation; }
            set { supplierApellation = value; }
        }
        private int supplierType;

        public int SupplierType
        {
            get { return supplierType; }
            set { supplierType = value; }
        }
        private int supplierState;

        public int SupplierState
        {
            get { return supplierState; }
            set { supplierState = value; }
        }
        private string supplierName;

        public string SupplierName
        {
            get { return supplierName; }
            set { supplierName = value; }
        }
        private string supplierPhone;

        public string SupplierPhone
        {
            get { return supplierPhone; }
            set { supplierPhone = value; }
        }
        private string supplierAddress;

        public string SupplierAddress
        {
            get { return supplierAddress; }
            set { supplierAddress = value; }
        }

    }
}
