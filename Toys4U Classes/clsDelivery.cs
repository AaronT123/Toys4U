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

        public string Valid(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8)
        {
            string Error = "";
            return Error;
        }

        public Boolean Find(int DeliveryID)
        {
            return false;
        }
    }
}