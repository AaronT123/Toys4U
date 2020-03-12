using System;

namespace Toys4U_Classes
{
    public class clsDelivery
    {
        public int DeliveryID { get; set; }
        public int OrderID { get; set; }
        public string HouseNo { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateEstimated { get; set; }

        public Boolean Find(int DeliveryID)
        {
            return false;
        }
    }
}