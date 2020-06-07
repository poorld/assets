using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Entity
{
    class User
    {
        private int userId;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        private string userAlias;

        public string UserAlias
        {
            get { return userAlias; }
            set { userAlias = value; }
        }
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string userPassword;

        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }
        private string userCode;

        public string UserCode
        {
            get { return userCode; }
            set { userCode = value; }
        }
        private string userPhone;

        public string UserPhone
        {
            get { return userPhone; }
            set { userPhone = value; }
        }
        private string userSex;

        public string UserSex
        {
            get { return userSex; }
            set { userSex = value; }
        }
        private string departmentName;

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        private string userJob;

        public string UserJob
        {
            get { return userJob; }
            set { userJob = value; }
        }
    }
}
