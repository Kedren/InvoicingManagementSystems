using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuQiJing.DBUtility
{
    public class NoRecordException:Exception
    {
        public NoRecordException() : base("没有这条记录")
        {

        }
        public NoRecordException(string message)
            : base(message)
        {

        }

    }
}
