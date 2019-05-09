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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void UserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.registrForm.Close();
        }

        private void btnLogOutUD_Click(object sender, EventArgs e)
        {
            this.Close();
            Session.registrForm.Show();
        }

        private void lnkCreateTicket_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AddTicket(this).ShowDialog();
            this.Hide();
        }
    }
}
