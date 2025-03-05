using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suhareva_UP.Models
{
    public partial class Partner
    {
        public string Discount
        {
            get {
                int discount = 0;
                int count = 0;
                foreach (var item in Partnersproducts)
                {
                    if (Partnersid == item.Partnersid)
                    {
                        count += item.Numberofproducts;
                    }
                }

                if (count < 10000) discount = 0;
                else if (10000 <=count && count< 50000) discount = 5;
                else if (50000 <= count && count < 300000) discount = 10;
                else if (300000 <= count) discount = 15;

                return Convert.ToString(discount) + "%";
            }
        }
    }
}
