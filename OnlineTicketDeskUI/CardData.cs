using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTicketDeskUI
{
   public class CardData
    {
        private Dictionary<CardAmaountType, Month> _keyValuePairs;
        public CardData()
        {
            _keyValuePairs = new Dictionary<CardAmaountType, Month>();
            _keyValuePairs.Add(CardAmaountType.Fifteen, Month.One);
            _keyValuePairs.Add(CardAmaountType.Thirty, Month.Three);
            _keyValuePairs.Add(CardAmaountType.Fifty, Month.Six);
        }
        public Month GetMonthByAmount(CardAmaountType cardAmaountType)
        {
            return _keyValuePairs[cardAmaountType];
        }
    }
}
