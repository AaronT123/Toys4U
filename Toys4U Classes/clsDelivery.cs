using System;

namespace Toys4U_Classes
{
    public class clsDelivery
    {
        //private data member for the DeliveryID property
        private Int32 mDeliveryID;
        //private data member for the OrderID property
        private Int32 mOrderID;
        //private data member for the HouseNo property
        private string mHouseNo;
        //private data member for the Street property
        private string mStreet;
        //private data member for the Town property
        private string mTown;
        //private data member for the City property
        private string mCity;
        //private data member for the Postcode property
        private string mPostcode;
        //private data member for the DateAdded property
        private DateTime mDateAdded;
        //private data member for the DateEstimated property
        private DateTime mDateEstimated;

        //public property for the DeliveryID
        public int DeliveryID
        {
            get
            {
                //return the private data
                return mDeliveryID;
            }
            set
            {
                //set the value of the private data member
                mDeliveryID = value;

            }
        }

        //public property for the OrderID
        public int OrderID
        {
            get
            {
                //return the private data
                return mOrderID;
            }
            set
            {
                //set the value of the private data member
                mOrderID = value;

            }
        }

        //public property for the HouseNo
        public string HouseNo
        {
            get
            {
                //return the private data
                return mHouseNo;
            }
            set
            {
                //set the value of the private data member
                mHouseNo = value;

            }
        }

        //public property for the Street
        public string Street
        {
            get
            {
                //return the private data
                return mStreet;
            }
            set
            {
                //set the value of the private data member
                mStreet = value;

            }
        }

        //public property for the Town
        public string Town
        {
            get
            {
                //return the private data
                return mTown;
            }
            set
            {
                //set the value of the private data member
                mTown = value;

            }
        }

        //public property for the City
        public string City
        {
            get
            {
                //return the private data
                return mCity;
            }
            set
            {
                //set the value of the private data member
                mCity = value;

            }
        }

        //public property for the Postcode
        public string Postcode
        {
            get
            {
                //return the private data
                return mPostcode;
            }
            set
            {
                //set the value of the private data member
                mPostcode = value;

            }
        }

        //public property for the DateAdded
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the value of the private data member
                mDateAdded = value;

            }
        }

        //public property for the DateEstimated
        public DateTime DateEstimated
        {
            get
            {
                //return the private data
                return mDateEstimated;
            }
            set
            {
                //set the value of the private data member
                mDateEstimated = value;

            }
        }

        public string Valid(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8)
        {
            string Error = "";
            return Error;
        }

        public Boolean Find(int DeliveryID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the DeliveryID to search for
            DB.AddParameter("@DeliveryID", DeliveryID);
            //execute the stored procedure
            DB.Execute("sproc_tblDelivery_FilterByDeliveryID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mDeliveryID = Convert.ToInt32(DB.DataTable.Rows[0]["DeliveryID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mHouseNo = Convert.ToString(DB.DataTable.Rows[0]["HouseNo"]);
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                mCity = Convert.ToString(DB.DataTable.Rows[0]["City"]);
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mDateEstimated = Convert.ToDateTime(DB.DataTable.Rows[0]["DateEstimated"]);

                //return everything that worked ok
                return true;
            }
            else
            {
                //if no record was found
                return false;
            }

        }
    }
}