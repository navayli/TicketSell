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
using OnlineTicketDeskUI.Core;

namespace OnlineTicketDeskUI.Forms
{
    public partial class RegistrForm : Form
    {
        public RegistrForm()
        {
            InitializeComponent();
        }

        private void RegistrForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistr_Click(object sender, EventArgs e)
        {
            if(txbxPassword.Text != txbxConfirmPas.Text)
            {
                MessageBox.Show("Enter correct password");
                return;
            }
            User user = new User
            {
                Name = txbxName.Text,
                Surname = txbxSurname.Text,
                Email = txbxEmail.Text,
                Password = txbxPassword.Text,
                Id = Identyfier<User>.Generate(),
                userType = UserType.User
            };

            DbContext.Users.Add(user);
            MessageBox.Show("Registr is successfully");
        }

        private void btnRegistrWC_Click(object sender, EventArgs e)
        {
            if(txbxPasswordWC.Text != txbxConfirmPasWC.Text)
            {
                MessageBox.Show("Enter correct password");
                return;
            }
            Card card = DbContext.Cards.FindCardByNumber(txbxCardNum.Text);
            if(card == null)
            {
                MessageBox.Show("Card number not valid");
                return;
            }
            else
            {
                User user = new User
                {
                    Email = txbxEmailWC.Text,
                    Password = txbxPasswordWC.Text,
                    Id = Identyfier<User>.Generate(),
                    userType = UserType.User
                    
                };
                DbContext.Users.Add(user);
            }
            MessageBox.Show("Registr is successfully");
            
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Session.registrForm = this;
            new LoginForm().ShowDialog();
        }
    }
}
