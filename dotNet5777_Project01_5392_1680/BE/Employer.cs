using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Employer
    {
        public int idCompany { get; set; }
        public bool isCompany { get; set; }
        public string employerFirstName { get; set; }
        public string employerLastName { get; set; }
        public string companyName { get; set; }
        public string numberCompany { get; set; }
        public Address adress { get; set; }
        public domainOccupation occupation { get; set; }
        public DateTime eslablishDate { get; set; }
        public bool isShares { get; set; } // indicates if the company has shares in the stock market
        public PhoneNum phoneCompany { get; set; }

        public override string ToString()
        {
            string str = "Company ID: " + idCompany + "\n" +
                         "Employer Name: " + employerFirstName + " " + employerLastName + "\n";
            if (isCompany)
                str += "Company Name" + isCompany.ToString() + "\n";

            str += "Number of Company: " + phoneCompany + "\n" +
                   "Adress: " + adress + "\n" +
                   "Domain of occupation: " + occupation + "\n" +
                   "Date Established" + eslablishDate;
            if (isShares)
                str += "The company is traded on the stock exchange";
            return str;
        }
    }
}
