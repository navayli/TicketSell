using OnlineTicketDeskUI.Core;
using OnlineTicketDeskUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTicketDeskUI
{
    public static class DbContext
    {
        public static DbSet<Card> Cards { get; set; }
        public static DbSet<User> Users { get; set; }
        public static DbSet<Ticket> Tickets { get; set; }
        public static void InitializeDefaultuser()
        {
            Users.Add(new User
            {
                Name = "Admin",
                Surname = "Admin",
                Email = "admin@mail.ru",
                Password = "12345",
                userType = UserType.Admin,
                Id = Identyfier<User>.Generate()
            });
            Users.Add(new User
            {
                Name = "Ali",
                Surname = "Nadjafli",
                Email = "ali@mail.ru",
                Password = "12345",
                userType = UserType.User,
                Id = Identyfier<User>.Generate()
            });
        }
        static DbContext()
        {
            Cards = new DbSet<Card>();
            Users = new DbSet<User>();
            Tickets = new DbSet<Ticket>();

            InitializeDefaultuser();
        }
    }
}
