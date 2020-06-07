using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Entity
{
    /// <summary>
    /// 部门
    /// </summary>
    class Department : TableEntity
    {
        private int departmentId;

        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }

        private string departmentCode;

        public string DepartmentCode
        {
            get { return departmentCode; }
            set { departmentCode = value; }
        }

        private string departmentState;

        public string DepartmentState
        {
            get { return departmentState; }
            set { departmentState = value; }
        }

        private string departmentName;

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }

    }
}
