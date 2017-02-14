using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceItemTracker
{
    public class InvoiceItem
    {
        public string Buyer { get; set; } //THESE ARE PROPERTIES
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime Timestamp { get; set; }

        public InvoiceItem() //THIS IS A CONSTRUCTOR    
        {
            this.Timestamp =  DateTime.Now;
        }

        public InvoiceItem(DateTime timestamp)
        {
            this.Timestamp = timestamp;
        }

        public bool IsOverdue()
        {
            TimeSpan difference = DateTime.Now - this.Timestamp;
            return (difference.Minutes > 4); //you could use an IF stmt but this is far better

        }
    }
}
