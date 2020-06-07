using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Entity
{
    class Property
    {
        private int property_id;
        public int Property_id
        {
            get { return property_id; }
            set { property_id = value; }
        }

        private string property_code;
        public string Property_code
        {
            get { return property_code; }
            set { property_code = value; }
        }

        private string property_name;
        public string Property_name
        {
            get { return property_name; }
            set { property_name = value; }
        }

        private string property_date;
        public string Property_date
        {
            get { return property_date; }
            set { property_date = value; }
        }

        private string create_date;
        public string Create_date
        {
            get { return create_date; }
            set { create_date = value; }
        }

        private string property_descr;
        public string Property_descr
        {
            get { return property_descr; }
            set { property_descr = value; }
        }

        private int property_state;
        public int Property_state
        {
            get { return property_state; }
            set { property_state = value; }
        }

        private int scrap_way;
        public int Scrap_way
        {
            get { return scrap_way; }
            set { scrap_way = value; }
        }

        private Locale locale;
        internal Locale Locale
        {
            get { return locale; }
            set { locale = value; }
        }

        private Supplier supplier;
        internal Supplier Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }

        private Department department;
        internal Department Department
        {
            get { return department; }
            set { department = value; }
        }

        private PropertyClass pc;
        internal PropertyClass Pc
        {
            get { return pc; }
            set { pc = value; }
        }

        private Brand brand;
        internal Brand Brand
        {
            get { return brand; }
            set { brand = value; }
        }


    }
}
