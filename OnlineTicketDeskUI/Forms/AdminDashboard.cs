using OnlineTicketDeskUI.Core;
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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void linkAddCard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            new AddCardForm().ShowDialog();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lblGreeting.Text+=" " + Session.User.Email;
        }

        private void linkShowCard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CardsForm().ShowDialog();
        }

       
        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.registrForm.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Session.registrForm.ShowDialog();
        }

        private void linkUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UsersForm().ShowDialog();

        }
    }
}
