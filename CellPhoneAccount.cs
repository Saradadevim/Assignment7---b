using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCellPhonev2025.Model
{
    public class CellPhoneAccount
    {

        //fields or properties common to all accounts
        private string _cellPhoneNumber;
        private double _totalCallTime;
        private double _totalCost;


         //Getter and Setter
        public string CellPhoneNumber
        {
            get { return _cellPhoneNumber; }
            set { _cellPhoneNumber = value; }
        }

        private int myVar;

        public double TotalCallTime
        {
            get { return _totalCallTime; }
            set { _totalCallTime = value; }
        }

        public double TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

        //default constructor

        public CellPhoneAccount()
        {

        }

        // 1 - parametrized Constructor
        public CellPhoneAccount(string cellPhoneNumber, double totalCallTime, double totalCost)
        {
            this._cellPhoneNumber = cellPhoneNumber;
            this._totalCallTime = totalCallTime;
            this._totalCost = totalCost;
        }

        //2-parametrized Constructor

        public CellPhoneAccount(string cellPhoneNumber)
        {
            _cellPhoneNumber = cellPhoneNumber;
        }


        // override ToString
        public override string? ToString()
        {
            //return base.ToString();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{this.CellPhoneNumber,-16} \t" + 
                $"{this._totalCallTime, -15} \t {this._totalCost,-11}");
            stringBuilder.AppendLine("----------------------------------------------------------------------");
            return stringBuilder.ToString();
        }
    }
}