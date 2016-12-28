using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Specialization
    {
        //domain of specialization
        public domainOccupation domain { get; set; }

        //for min salary we want to know The level of demand in the market
        public int DemandLevel { get; set; }

        static private int CodeExpertise = 11111111;

        // every argument will get specail code
        private readonly int codeExp;
        public int CodeExp
        {
            get { return codeExp; }
        }
        
        // name of the domain
        public string DomainName { get; set; }

        /// <summary>
        /// cotr to give auto code for each one of argument
        /// demand level auto will be 1 but this value changeable
        /// </summary>
        /// <param name="DomainName">enter the name of the domain </param>
        public Specialization()
        {
            codeExp = CodeExpertise++;
            DemandLevel = 1;
        }

        /// <summary>
        ///min salary per hour per domain
        /// </summary>
        public int minSalary()
        {
            return 27 * DemandLevel;
        }

        /// <summary>
        /// max slalry per hour per domain
        /// </summary>
        public int maxSalary()
        {
            return 60 * DemandLevel;
        }

        public override string ToString()
        {
            return "Specialization Code: " + CodeExp.ToString();
        }

    }
}
