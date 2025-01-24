using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCellPhonev2025.Model
{
    public class Contract : CellPhoneAccount
    {
        //fields
        public string AccountHolderName { get; set; }
        public string Address { get; set; }
        public int ContractLengthMonths { get; set; }

        //parameterized
        public Contract(string cellPhoneNumber, double totalCallTime, double totalcost, 
            string accName, string address, int lengthMonths)
            : base(cellPhoneNumber, totalCallTime, totalcost)
        {
            this.AccountHolderName = accName;
            this.Address = address; 
            this.ContractLengthMonths = lengthMonths;
        }
    }
}
