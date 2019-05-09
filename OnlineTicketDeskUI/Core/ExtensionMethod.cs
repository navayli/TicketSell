using OnlineTicketDeskUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTicketDeskUI.Core
{
   public static class ExtensionMethod
    {
        public static Card FindCardByNumber(this DbSet<Card> dbSet, string number)
        {
            Card _card = null;
            foreach(Card cr in dbSet.GetAll())
            {
                if (cr.Number == number)
                    _card = cr;
                break;
            }
            return _card;
        }
        public static User FindUserTextBox(this DbSet<User> dbSet, string email, string password)
        {
            User _user = null;
            foreach(User user in dbSet.GetAll())
            {
                if(user.Email == email && user.Password == password)
                {
                    _user = user;
                    break;
                }
            }
            return _user;
        }
    }
}
