using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            if (Quota!=null && AchievedTarget < Quota )
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs
                {
                    Cause = LayOffCause.SalesTargetFailed
                });
                return false;
            }
            return true;
        }
    }
}
