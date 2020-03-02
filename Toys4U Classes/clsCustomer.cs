using System;

namespace Toys4U_Classes
{
    public class clsCustomer
    {
        public int CustomerID { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string PostCode { get; set; }
        public string StreetName { get; set; }
        public string HouseNo { get; set; }

        public Boolean Find(int CustomerID)
        {
            //always return true
            return true;
        }

        public string Valid(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8)
        {
            string Error = "";
            return Error;
        }
    }
}