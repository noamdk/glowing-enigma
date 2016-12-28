using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class Dal_imp :IDAL
    {
        public List<BankAccount> ListBankAccount()
        { 
            List<BankAccount> BankList = new List<BankAccount>(5);
            BankAccount tmp = new BankAccount();
            for (int i = 0; i < 5; i++)
            {
                switch(i)
                {
                    case 0:
                        tmp.BankName = "Hapoalim";
                        tmp.BranchCity = "Jerousalem";
                        tmp.BankBranchAddress = "Givat Mordehai, shahal 230";
                        break;
                    case 1:
                        tmp.BankName = "Discont";
                        tmp.BranchCity = "Petah Tikva";
                        tmp.BankBranchAddress = "Rotshild 106";
                        break;
                    case 2:
                        tmp.BankName = "Pagi";
                        tmp.BranchCity = "Haifa";
                        tmp.BankBranchAddress = "Davidson 6";
                        break;
                    case 3:
                        tmp.BankName = "Mizrahi";
                        tmp.BranchCity = "Tel Aviv";
                        tmp.BankBranchAddress = "Orlozorov 33";
                        break;
                    case 4:
                        tmp.BankName = "Tefahot";
                        tmp.BranchCity = "Jerousalem";
                        tmp.BankBranchAddress = "King Jorg 41";
                        break;
                }
                tmp.BankNumber = i+1;
                tmp.BankBranchNumber = i + 111;
                tmp.AccountNumber = 999 - i;
                BankList[i] = tmp;
            }
            return BankList;
        }
    }
}
