using System;

namespace Toys4U_Classes
{
    public class clsProduct
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }

        public Boolean Find(int primaryKey)
        {
            return false;
        }

        public string Valid(string text1, string text2, string text3)
        {
            return "";
        }
    }
}