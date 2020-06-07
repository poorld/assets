using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Enums
{
    /// <summary>
    /// 资产 状态
    /// </summary>
    public enum PropertyState
    {
        未使用 = 1,
        已借用 = 2,
        已归还 = 3,
        已报废 = 4
    }
}
