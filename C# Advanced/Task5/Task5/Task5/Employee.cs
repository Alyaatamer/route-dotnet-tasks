using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public enum LayOffCause
    {
        NegativeVacationStock, // If Employee Vacation Stock < 0
        AgeLimitExceeded, // If Employee Age > 60
        SalesTargetFailed,
        Resigned
    }

    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; }
    }

    public class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }

        public int EmployeeID { get; set; }

        public DateTime BD { get; set; }

        public int VacationStock { get; set; }

        public int GetAge
        {
            get
            {
                int age = DateTime.Now.Year - BD.Year;
                if (BD > DateTime.Now.AddYears(-age)) age--;
                return age;
            }
        }

        public bool RequestVacation(DateTime From, DateTime To)
        {
            int NumberOfVacationDays = (To - From).Days;
            VacationStock -= NumberOfVacationDays;

            if (VacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs
                {
                    Cause = LayOffCause.NegativeVacationStock
                });
                return false;
            }

            return true;
        }

        public void EndOfYearOperation()
        {
            if (GetAge > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs
                {
                    Cause = LayOffCause.AgeLimitExceeded
                });
            }
        }
    }
}
