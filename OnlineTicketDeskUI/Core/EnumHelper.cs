using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTicketDeskUI.Core
{
    public static class EnumHelper<T>
    {
        public static T StringToEnum(string data)
        {
            return (T)Enum.Parse(typeof(T), data);
        }
    }
}
