using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk30.Models
{
    public class DeskQuote
    {
        
        public int ID { get; set; }
        public Desk newDesk { get; set; }
        public decimal rushDays { get; set; }
        public string customerName { get; set; }
        public DateTime quoteDate { get; set; }
        public decimal shippingCost { get; set; }
        public decimal deskPrice { get; set; }
        
    }

}
