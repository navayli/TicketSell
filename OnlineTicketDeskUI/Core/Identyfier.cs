using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTicketDeskUI.Core
{
    public class Identyfier<T>
    {
        private static int _identity;
        static Identyfier()
        {
            _identity = 0;
        }
        public static int Generate()
        {
            return _identity++;
        }
    }
}
