using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace DAL
{
    public interface IDAL
    {
        
        void AddSpecialization(Specialization S);
        bool RemoveSpecialization(int Code);
        void UpdateSpecialization(Specialization S);
        
        void AddEmployee(Employee E);
        bool RemoveEmployee(int id);
        void UpdateEmployee(Employee E);

        void AddEmployer(Employer E);
        bool RemoveEmployer(Employer id);
        void UpdateEmployer(Employer E);

        void AddContract(Contract C);
        bool RemoveContract(int ContractNumber);
        void UpdateContract(Contract E);

        //IEnumerable<Specialization> GetAllSpecialization(Func<Specialization, bool> predicat = null);
        //IEnumerable<Employee> GetAllEmployee(Func<Employee, bool> predicat = null);
        //IEnumerable<Employer> GetAllEmployer(Func<Employer, bool> predicat = null);
        //IEnumerable<Contract> GetAllContract(Func<Contract, bool> predicat = null);
       List<BankAccount> ListBankAccount();
    }
}
