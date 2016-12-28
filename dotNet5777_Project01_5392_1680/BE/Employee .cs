using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BE
{
    public class Employee
    {
        enum Certificate { Diploma, Ba, Ma, Doc, Student }
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EmployeeBornDate { get; set; }
        public PhoneNum PhoneNumber { get; set;}
        public Address EmployeeAdrs { get; set; }
        public bool MilitaryGraduate { get; set; }
        public BankAccount AccountEmployee { get; set; }
        public Specialization SpecialEmployee { get; set; }
        public override string ToString()
        {  
            string str = "id: " + EmployeeId.ToString() + "\nLast Name: " + LastName.ToString() + " " + "\nFirst Name: " + FirstName.ToString();
            str += "\nEmployee Born Date: " + EmployeeBornDate.ToString() + "\nPhoneNumber: " + PhoneNumber.ToString()+ "\nEmployee Address :" + EmployeeAdrs.ToString();
            str += "\nMilitary Graduate :" + MilitaryGraduate.ToString()+ "\nAccount Employee: "+ AccountEmployee.ToString()+ "\nSpecialization of employee: "+ SpecialEmployee.ToString();
            return str;
        }
    }
}
