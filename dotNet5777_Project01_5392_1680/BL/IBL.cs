using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    public interface IBL:IDAL
    {
        /// <summary>
        /// Check if the emploee age less then 18
        /// </summary>
        bool ForbidenAddEmploee(Employee E);

        /// <summary>
        /// Check if exist this employee and employer 
        /// </summary>
        bool CheckTheMenContract(Contract C);

        /// <summary>
        /// Check if employer new less then year
        /// </summary>
        bool CheckTheEmployerContract(Contract C);

        /// <summary>
        /// Calculate bruto salary 
        /// </summary>
        /// <param name="s">In s there is function that calculate deamand level</param>
        int BrutoSalary(Specialization s);

        /// <summary>
        /// Calaulate neto salary
        /// </summary>
        int NetoSalalry(Specialization s);

        IEnumerable<Contract> GetAllContract(Func<Contract, bool> predicat = null);
        IEnumerable<Contract> GetAllContractNum(Func<Contract, bool> predicat = null);
    }
}
