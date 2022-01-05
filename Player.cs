using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA220105
{
    internal class Player
    {
        public string Name { get; set; }
        public int AnnualSalary { get; set; }
        public int ContractPeriod { get; set; }

        public Player(string name, string annualSalaryString, string contractPeriodString)
        {
            Name = name;
            AnnualSalary = int.Parse(annualSalaryString);
            ContractPeriod = int.Parse(contractPeriodString);
        }
    }
}
