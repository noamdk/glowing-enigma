using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public struct BankAccount
    {
        public int BankNumber { get; set; }
        public string BankName { get; set; }
        public int BankBranchNumber { get; set; }
        public string BankBranchAddress { get; set; }
        public string BranchCity { get; set; }
        public int AccountNumber { get; set; }
        public override string ToString()
        {
            return "Bank Number: " + BankNumber.ToString()+ "\nBank Name: "+ BankName.ToString() + "\nBank Branch Address: "+ BankBranchAddress.ToString()+ "\nBranch City: "+ BranchCity.ToString()+ "\nAccount Number: "+ AccountNumber.ToString();
        }
    }

    public enum domainOccupation
    { dataBase, communication, dataSecurity, serverProgramming, mobileProgramming, interfaceDesign }
    //  בסיסי נתונים, תקשורת, אבטחת מידע, תכנות צד שרת, תכנות מובייל, עיצוב ממשקי משתמש 


    /// <summary>
    /// template of phone number
    /// </summary>
    public struct PhoneNum : IComparable<PhoneNum>
    {
        private int phoneNumber;
        public int PhoneNumber
        {
            set
            {
                if (value.ToString().Length == 9 || value.ToString().Length == 8)
                    phoneNumber = value;
                else
                    throw new Exception("wrong with PhoneNumber!!! ");
            }
        }

        /// <summary>
        /// can compare with other phon numbers
        /// </summary>
        public int CompareTo(PhoneNum p)
        {
            return phoneNumber.CompareTo(p.phoneNumber);
        }

        public override string ToString()
        {
            return "0" + phoneNumber.ToString();
        }
    }

    /// <summary>
    /// template of adrress
    /// </summary>
    public struct Address
    {
        public string CityName { get; set; }
        public string StreetName { get; set; }
        int HouseNum { get; set; }
        public override string ToString()
        {
            return "City Name: " + CityName.ToString() + "\nStreet Name: " + StreetName.ToString()+"\nHouse Number: "+HouseNum.ToString();
        }
    }
}
