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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txbxEmail.Text) && !string.IsNullOrEmpty(txbxPassword.Text))
            {
                User user = DbContext.Users.FindUserTextBox(txbxEmail.Text, txbxPassword.Text);
                Session.User = user;
                
                if(user!=null)
                {
                  if(user.userType == UserType.Admin)
                    {
                        this.Close();
                        new AdminDashboard().ShowDialog();
                    }
                  else
                    {
                        this.Close();
                        new UserDashboard().ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Email or Password invalid");
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.registrForm.Close();
        }
    }
}
