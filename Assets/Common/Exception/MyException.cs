using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets.Common.Exception
{
    class MyException : ApplicationException
    {
        public MyException(string message)
            : base(message)
        {
            MessageBox.Show(Convert.ToString(message));
        }
    }
}
