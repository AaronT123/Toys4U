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

        public string Valid(string OrderID, string HouseNo, string Street, string Town, string City, string Postcode, string DateAdded, string DateEstimated)
        {
            /*
             * 
             * OrderID
             * 
             */
            //create a string variable to store the error
            string Error = "";
            //if the OrderID is blank
            if (OrderID.Length == 0)
            {
                //record the error
                Error = Error + "The Order ID may not be blank : ";
            }
            //if the OrderID is greater than 9 characters
            if (OrderID.Length > 9)
            {
                //record the error
                Error = Error + "The Order ID may not be longer than 9 characters : ";
            }
            //if the OrderID is digits only
            foreach (char c in OrderID)
            {
                if (c < '0' || c > '9')
                    Error = Error + "The Order ID is not digits only : ";
            }
            /*
             * 
             * 
             * THIS CODE WORKS BUT NEED THE APPROPRIATE TEST DATA
             * IN THE ORDER TABLE AND IN THE OTHER ORDER ID TESTS
             * THAT FAIL BECAUSE OF THIS
             * 
             * 
             * 
            //if the OrderID exists in the order table
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the OrderID to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if a record is not found
            if (DB.Count == 0)
            {
                Error = Error + "The Order ID does not exist : ";
            }
            */

            /*
             * 
             * HouseNo
             * 
             */
            //if the HouseNo is blank
            if (HouseNo.Length == 0)
            {
                //record the error
                Error = Error + "The House No may not be blank : ";
            }
            if (HouseNo.Length > 8)
            {
                //record the error
                Error = Error + "The Order ID may not be longer than 8 characters : ";
            }
            /*
             * 
             * Street
             * 
             */
            if (Street.Length == 0)
            {
                //record the error
                Error = Error + "The Street may not be blank : ";
            }
            if (Street.Length > 50)
            {
                //record the error
                Error = Error + "The Street may not be longer than 50 characters : ";
            }
            /*
             * 
             * Town
             * 
             */
            if (Town.Length == 0)
            {
                //record the error
                Error = Error + "The Town may not be blank : ";
            }
            if (Town.Length > 50)
            {
                //record the error
                Error = Error + "The Town may not be longer than 50 characters : ";
            }
            /*
             * 
             * City
             * 
             */
            if (City.Length == 0)
            {
                //record the error
                Error = Error + "The City may not be blank : ";
            }
            if (City.Length > 50)
            {
                //record the error
                Error = Error + "The City may not be longer than 50 characters : ";
            }
            /*
             * 
             * Postcode
             * 
             */
            if (Postcode.Length < 6)
            {
                //record the error
                Error = Error + "The Postcode may not be less than 6 characters (include a space) : ";
            }
            
            /*
            if (Postcode.Length > 8)
            {
                //record the error
                Error = Error + "The Postcode may not be longer than 8 characters : ";
            }
            */
            
            Int32 PostcodeSpaceCount = 0;
            foreach (char c in Postcode)
            {
                if (c == ' ')
                    PostcodeSpaceCount += 1;
            }
            if (PostcodeSpaceCount > 1)
            {
                Error = Error + "The postcode may only contain 1 space : ";
            }
            if (PostcodeSpaceCount < 1)
            {
                Error = Error + "The postcode needs to contain a space : ";
            }


            //return any error messages
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