using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DS
{
    public class DataSource
    {
        public static List<Specialization> specializations;
        public static List<Employee> employees;
        public static List<Employer> employers;
        public static List<Contract> contracts;
        public DataSource()
        {
            specializations = new List<Specialization>();
            employees = new List<Employee>();
            employers = new List<Employer>();
            contracts = new List<Contract>();
        }
    }
}
