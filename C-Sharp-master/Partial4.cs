using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public partial class Employee2
    {
        public void CalculateSalary()
        {
            if (this.dep == "CS")
            {
                this.Salary = 100000;
            }
            else
            {
                this.Salary = 80000;
            }
        }
        public void DisplaySalary()
        {
            Console.WriteLine(this.Salary);
        }
    }
    internal class Partial4
    {
    }
}
