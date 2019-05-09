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
    public partial class CardsForm : Form
    {
        public CardsForm()
        {
            InitializeComponent();
        }

        private void CardsForm_Load(object sender, EventArgs e)
        {
            dataCardGrid.DataSource = DbContext.Cards.GetAll();
        }
    }
}
