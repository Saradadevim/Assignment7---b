using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCellPhonev2025.Model
{
    public class PayAsYouGo : CellPhoneAccount
    {
        //field

        /*private char _accountType;

        public char AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }
        }*/

        public char AccountType { get; set; }

        //parameterized Constructor
        public PayAsYouGo
            (string cellPhoneNumber, double totalCallTime, double totalCost, char accountType) : 
            base(cellPhoneNumber, totalCallTime, totalCost)
        {
            this.AccountType = accountType;
        }

        // override ToString
        public override string? ToString()
        {
            //return base.ToString();
            StringBuilder stringBuilder = new StringBuilder(base.ToString());
            stringBuilder.AppendLine($"Account Type: {this.AccountType}");
            stringBuilder.AppendLine("----------------------------------------------------------------------");
            return stringBuilder.ToString();
        }
    }
}
