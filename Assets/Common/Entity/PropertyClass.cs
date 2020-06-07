using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Entity
{
    /// <summary>
    /// 资产类别
    /// </summary>
    class PropertyClass : TableEntity
    {
        private int pcId;

        public int PcId
        {
            get { return pcId; }
            set { pcId = value; }
        }
        private string pcCode;

        public string PcCode
        {
            get { return pcCode; }
            set { pcCode = value; }
        }
        private string pcName;

        public string PcName
        {
            get { return pcName; }
            set { pcName = value; }
        }
        private string pcState;

        public string PcState
        {
            get { return pcState; }
            set { pcState = value; }
        }
    }
}
