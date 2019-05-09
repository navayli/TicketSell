using OnlineTicketDeskUI.Core;
using OnlineTicketDeskUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineTicketDeskUI.Forms
{
    public partial class AddTicket : Form
    {
        private UserDashboard _userdashboard;
        public AddTicket(UserDashboard userDashboard)
        {
            InitializeComponent();
            _userdashboard = userDashboard;
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket
            {
                Title = txbxTitle.Text,
                Description = txbxDescription.Text,
                UserId = Session.User.Id,
                Id = Identyfier<Ticket>.Generate(),
                TicketStatus = TicketStatus.Open
            };
            DbContext.Tickets.Add(ticket);
            lnkCount.Text = DbContext.Tickets.GetAll().Count.ToString();
            MessageBox.Show("Ticket successfully created");
        }

        private void btnToDashboard_Click(object sender, EventArgs e)
        {
            //_userdashboard.Show();
            new UserDashboard().ShowDialog();
            this.Hide();
        }
    }
}
