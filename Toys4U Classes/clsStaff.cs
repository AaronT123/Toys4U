using System;

namespace Toys4U_Classes
{
    public class clsStaff
    {
        //PRIVATE DATA MEMEBER FOR THE PROPERTY
        private Int32 mStaffNo;
        private bool mAdmin;


        private DateTime mDateJoined;
        private DateTime mDateOfBirth;
        private string mEmail;
        private string mFirstName;
        private decimal mHourlyPay;
        private string mJobTitle;
        private string mLastName;
        private string mPassword;
        private string mPhoneNumber;
        public int StaffNo
        {
            get
            {
                //return the private data
                return mStaffNo;
            }
            set
            {
                //set the value of the provate data ember
                mStaffNo = value;
            }
        }

        public bool Admin
        {
            get
            {
                //return the private data
                return mAdmin;
            }
            set
            {
                //set the value of the provate data ember
                mAdmin = value;
            }
        }

        public DateTime DateJoined
        {
            get
            {
                //return the private data
                return mDateJoined;
            }
            set
            {
                //set the value of the provate data ember
                mDateJoined = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                //return the private data
                return mDateOfBirth;
            }
            set
            {
                //set the value of the provate data ember
                mDateOfBirth = value;
            }
        }

        public string Email
        {
            get
            {
                //return the private data
                return mEmail;
            }
            set
            {
                //set the value of the provate data ember
                mEmail = value;
            }
        }

        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the value of the provate data ember
                mFirstName = value;
            }
        }

        public decimal HourlyPay
        {
            get
            {
                //return the private data
                return mHourlyPay;
            }
            set
            {
                //set the value of the provate data ember
                mHourlyPay = value;
            }
        }

        public string JobTitle
        {
            get
            {
                //return the private data
                return mJobTitle;
            }
            set
            {
                //set the value of the provate data ember
                mJobTitle = value;
            }
        }

        public string LastName
        {
            get
            {
                //return the private data
                return mLastName;
            }
            set
            {
                //set the value of the provate data ember
                mLastName = value;
            }
        }
        public string Password
        {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the value of the provate data ember
                mPassword = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                //return the private data
                return mPhoneNumber;
            }
            set
            {
                //set the value of the provate data ember
                mPhoneNumber = value;
            }
        }

        public Boolean Find(int StaffNo)
        {
         
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("StaffNo", StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count ==1)
            {
                //copy the data from the database to the private data members
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["Admin"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mHourlyPay = Convert.ToDecimal(DB.DataTable.Rows[0]["HourlyPay"]); ;
                mJobTitle = Convert.ToString(DB.DataTable.Rows[0]["JobTitle"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string DateJoined, string DateOfBirth, string Email, string FirstName, string HourlyPay, string JobTitle, string LastName, string Password, string PhoneNumber)
        {
            string Error = "";

            if (FirstName.Length > 0 && FirstName.Length<41)
            {
                foreach(char c in FirstName)
                {

                    if(!Char.IsLetter(c))
                    {
                        Error += "The first name must only contain letters";
                    }

                    Error += "";
                }
            }
            else
            {
                Error += "First name must be between 0 and 41 characters";
            }


            if(HourlyPay!="")
            {
                try
                {
                    decimal hourlypay;
                    hourlypay = Convert.ToDecimal(HourlyPay);
                    int decimalplaces = BitConverter.GetBytes(decimal.GetBits(hourlypay)[3])[2];
                    if(decimalplaces == 2)
                    {
                        if(hourlypay>6.14m && hourlypay<1000.01m)
                        {
                            Error += "";
                        }
                        else
                        {
                            Error += "HourlyPay must be between £6.14 and £1000.01";
                        }

                    }
                    else
                    {

                        Error += "Hourly Pay Must have 2 decimal places";
                    }

                }
                catch
                {
                    Error += "HourlyPay must be a decimal";
                }


            }
            else
            {
                Error += "HourlyPay cannot be left empty";
            }


            if (JobTitle.Length > 0 && JobTitle.Length < 41)
            {
                foreach (char c in JobTitle)
                {

                    if (!Char.IsLetter(c))
                    {
                        Error += "The JobTitle name must only contain letters";
                    }

                    Error += "";
                }
            }
            else
            {
                Error += "JobTitle must be between 0 and 41 characters";
            }



            if (LastName.Length > 0 && LastName.Length < 41)
            {
                foreach (char c in LastName)
                {

                    if (!Char.IsLetter(c))
                    {
                        Error += "The LastName name must only contain letters";
                    }

                    Error += "";
                }
            }
            else
            {
                Error += "LastName must be between 0 and 41 characters";
            }


            try
            {


                DateTime Temp = Convert.ToDateTime(DateOfBirth);
                DateTime minDate = DateTime.Today.AddYears(-120);
                DateTime maxDate = DateTime.Today.AddYears(-18);
                if (Temp < minDate | Temp > maxDate)
                {
                    Error += "Age must be between 18 and 100";
                }


            }
            catch//if it failed report an error
            {
                //set the error message
                Error = Error += "Date is not valid, please use the format DD/MM/YYYY";
            }
            
            

            try
            {


                //assign the date to the temporary var
                DateTime Temp = Convert.ToDateTime(DateJoined);

                if (Temp > DateTime.Now.Date)
                {
                    Error += "Must of joined today ";
                }
                if (Temp < DateTime.Now.Date)
                {
                    Error += "Must of joined today ";
                }
            }
            catch//if it failed report an error
            {
                //set the error message
                Error = Error += "Date is not valid please use format DD/MM/YYYY";
            }




            if (Email!= "")
            {
                try
                {
                   
                    var address = new System.Net.Mail.MailAddress(Email);
                    if (Email.Length>50)
                    {
                        Error += "Email must be less than 50 characters";
                    }
                }
                catch
                {
                    Error += "Email must be in the format xx@yy.zz";
                }

            }
            else
            {
                Error += "Email must not be blank";
            }

            
            if (Password.Length > 0 && Password.Length < 41)
            {
                bool ContainsCapitalLetter = false;
                bool ContainsLowerLetter = false;
                bool ContainsNumber = false;

                foreach (char c in Password)
                {


                    if (char.IsUpper(c)) ContainsCapitalLetter = true;

                    if (char.IsLower(c)) ContainsLowerLetter = true;
                    if (char.IsDigit(c)) ContainsNumber = true;
                }
                if(ContainsCapitalLetter==false)
                {
                    Error += "Please include one capital letter in your password  ";
                }
                else if (ContainsLowerLetter ==false)
                {
                    Error += "Please include one lower letter in your password";
                }
                else if (ContainsNumber==false)
                {
                    Error += "Please include one number in your password ";
                }

            }
            else
            {
                Error += "Password must be between 0 and 41 chararcters";

            }


            if(PhoneNumber!="")
            {
       
               PhoneNumber= System.Text.RegularExpressions.Regex.Replace(PhoneNumber, @" ", "");
                if (PhoneNumber.Length==11)
                { 
                    
                    foreach (char c in PhoneNumber)
                    {


                        if (!Char.IsDigit(c))
                        {
                            Error += "The PhoneNumber must only contain Digits";
                        }
                    }
                }
               else
                {
                    Error += "The PhoneNumber must be 11 digits " + PhoneNumber;

                }

            }


           return Error;
        }

    }
   
  
}