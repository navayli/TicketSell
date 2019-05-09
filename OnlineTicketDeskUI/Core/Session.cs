using OnlineTicketDeskUI.Forms;
using OnlineTicketDeskUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTicketDeskUI.Core
{
    public static class Session
    {
        public static User User { get; set; }
        public static RegistrForm registrForm;
     
    }
}
