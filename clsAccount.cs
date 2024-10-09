using BankDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBussinessLayer
{
    public class clsAccount
    {

        public static DataTable GetAllAccountsRelatedToClient(int CifID)
        {
            return clsAccountsData.GetAllAccountsRelatedToClient(CifID);
        }
    }
}
