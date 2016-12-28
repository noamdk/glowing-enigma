using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Contract
    {
        static public int contNumber = 000000000;
        public int contractNum { get; set; }
        public int idEmployerNum { get; set; }
        public int idWorkerNum { get; set; }
        public bool isInterview { get; set; }
        public bool isContract { get; set; }
        public float brutoSalary { get; set; }
        public float netoSalary { get; set; }
        public DateTime startEmployment { get; set; }
        public DateTime endEmployment { get; set; }
        public float hoursEmployment { get; set; }

        public override string ToString()
        {
            string str;
            str = "contract number : " + contractNum +
                  "ID of employer: " + idEmployerNum +
                  "ID of worker: " + idWorkerNum;
            if (isInterview)
                str += "Interview was done ";
            if (isContract)
                str += "Employment contract signed";
            str += "Bruto salary is: " + brutoSalary +
                   "Neto salary is: " + netoSalary +
                   "Employement start at: " + startEmployment +
                   "Emloyement end at: " + endEmployment +
                   "Employment hours: " + hoursEmployment;
            return str;
        }

        //c-tor
        public Contract()
        {
            this.contractNum = contNumber;
            contNumber++; // promote the contract number
        }

    }
}
