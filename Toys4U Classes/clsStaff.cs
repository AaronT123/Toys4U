using System;

namespace Toys4U_Classes
{
    public class clsStaff
    {
        public bool Admin { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public decimal HourlyPay { get; set; }
        public string JobTitle { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int StaffID { get; set; }

        public void Find(int primaryKey)
        {

        }

        public string Valid(string text1, string text2, string text3)
        {
            throw new NotImplementedException();
        }
    }

  
}