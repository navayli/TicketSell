using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTicketDeskUI
{
   public class Card
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int? ActivatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ActivateDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public CardAmaountType CardAmaountType { get; set; }
    }
}
