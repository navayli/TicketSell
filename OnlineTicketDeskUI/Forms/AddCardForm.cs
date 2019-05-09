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

namespace OnlineTicketDeskUI
{
    public partial class AddCardForm : Form
    {
        public AddCardForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string tx = Guid.NewGuid().ToString();
            txbxNumber.Text =  tx.Substring(tx.IndexOf('-')+1, 14).ToUpper();

            Random random = new Random();
            int indexOfArray = random.Next(0, 3);

            int[] values = (int[])Enum.GetValues(typeof(CardAmaountType));
            txbxAmount.Text = values[indexOfArray].ToString();

            CardAmaountType[] cardAmaountTypes = (CardAmaountType[])Enum.GetValues(typeof(CardAmaountType));
            CardAmaountType cardAmaountType = cardAmaountTypes[indexOfArray];

            CardData cardData = new CardData();
            Month month = cardData.GetMonthByAmount(cardAmaountType);
            txbxExpireDate.Text = DateTime.Now.AddMonths((int)month).ToString();
            //txbxExpireDate.Text = DateTime.Now.AddMonths((int)cardData.GetMonthByAmount(cardAmaountType)).ToString();



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //CardAmaountType cardAmaountType = (CardAmaountType)Enum.Parse(typeof(CardAmaountType), txbxAmount.Text);
            CardAmaountType cardAmaount = EnumHelper<CardAmaountType>.StringToEnum(txbxAmount.Text);
            DateTime expireDate = DateTime.Parse(txbxExpireDate.Text);

            Card card = new Card
            {
                CreateDate = DateTime.Now,
                CardAmaountType = cardAmaount,
                Id = Identyfier<Card>.Generate(),
                ExpireDate = expireDate,
                Number = txbxNumber.Text
            };
            DbContext.Cards.Add(card);
            DrawStatistic();
        }

        private void AddCardForm_Load(object sender, EventArgs e)
        {
            DrawStatistic();
        }
        private void DrawStatistic()
        {
            int count = DbContext.Cards.GetAll().Count;
            linkLblCount.Text = count.ToString();
        }

    }
}
