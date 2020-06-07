using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Entity
{
    class Locale : TableEntity
    {
        private int localeId;

        public int LocaleId
        {
            get { return localeId; }
            set { localeId = value; }
        }
        private string localeName;

        public string LocaleName
        {
            get { return localeName; }
            set { localeName = value; }
        }
        private int localeType;

        public int LocaleType
        {
            get { return localeType; }
            set { localeType = value; }
        }
        private int localeState;

        public int LocaleState
        {
            get { return localeState; }
            set { localeState = value; }
        }
        private string localeExplain;

        public string LocaleExplain
        {
            get { return localeExplain; }
            set { localeExplain = value; }
        }
    }
}
