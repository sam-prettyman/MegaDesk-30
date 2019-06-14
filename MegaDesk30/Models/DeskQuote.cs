using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk30.Models
{
    public class DeskQuote
    {
        const decimal BASE_PRICE = 200;

        public int ID { get; set; }
        public Desk newDesk { get; set; }
        public decimal rushDays { get; set; }
        public string customerName { get; set; }
        public DateTime quoteDate { get; set; }
        public decimal shippingCost { get; set; }
        public decimal deskPrice { get; set; }

        //
        // create new deskQuote from addQuote variables
        //
    /*  public DeskQuote(Desk deskCopy, decimal days, string name)
        {
            this.newDesk = deskCopy;
            this.rushDays = days;
            this.customerName = name;
            this.quoteDate = DateTime.Now;
            decimal area = newDesk.surfaceArea();
            this.shippingCost = calcshippingCost(rushDays, area);
            decimal materialCost = newDesk.newMaterial.Price;
            this.deskPrice = calcDeskPrice(materialCost, area, this.shippingCost);
        }
        */
        //
        // Calculate Shipping Cost 
        //
        public decimal calcshippingCost(decimal pvRushDays, decimal pvArea)
        {

            decimal shippingPrice;
            

            if (pvRushDays == 3)
            {
                if (pvArea < 1000)
                {
                    shippingPrice = 60;
                }
                else if (pvArea < 2001)
                {
                    shippingPrice = 70;
                }
                else
                {
                    shippingPrice = 80;
                }
            }
            else if (pvRushDays == 5)
            {
                if (pvArea < 1000)
                {
                    shippingPrice = 40;
                }
                else if (pvArea < 2001)
                {
                    shippingPrice = 45;
                }
                else
                {
                    shippingPrice = 60;
                }
            }
            else
            {
                if (pvArea < 1000)
                {
                    shippingPrice = 60;
                }
                else if (pvArea < 2001)
                {
                    shippingPrice = 70;
                }
                else
                {
                    shippingPrice = 80;
                }
            }
            return shippingPrice;

        }

      
        //
        // Calculate the cost of the desk
        //
        public decimal calcDeskPrice(decimal pvMaterialCost, decimal pvArea, decimal pvShippingCost)
        {
            if (pvArea < 1000)
                return BASE_PRICE + pvShippingCost + pvMaterialCost;
            else
                return BASE_PRICE + pvShippingCost + pvMaterialCost + pvArea;


        }

    }

}
