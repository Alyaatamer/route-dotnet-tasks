using System.Collections;

namespace Task2
{
    /*     
        Assign the following security privileges to the employee (guest,
        Developer, secretary and DBA) in a form of Enum
    */
    [Flags]
    enum securityLevel : byte
    {
        none = 0,
        guest = 1,
        Developer = 2,
        secretary = 4,
        DBA = 8,
        all = guest | Developer | secretary | DBA
    }
    internal class employee 
    {
        /*
          Employee is identified by an ID, Name, security level, salary, hire date
            and Gender.
        */
        private int id;
        private string name;
        private securityLevel level;
        private decimal salary;
        private HiringDate hireDate;
        private char gender;

        public int Id
        {
            get { return id; }            
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public securityLevel Level
        {
            get { return level; }
            set { level = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public HiringDate HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        /*        
            We need to restrict the Gender field to be only M or F [Male or Female]
        */
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value =='m' || value == 'M' || value == 'f' || value == 'F')
                {
                    gender = value;
                }
            }
        }

        public employee(int id , string name , securityLevel level , decimal salary, HiringDate hireDate , char gender)
        {
            this.id = id;
            this.name = name;
            this.level = level;
            this.salary = salary;
            this.hireDate = hireDate;
            this.gender = gender;
        }

        /*          
            We want to provide the Employee Class to represent Employee data in a
            string Form (override ToString())
        */
        public override string ToString()
        {
            return $"id : {id} ,\nname : {name} ,\nlevel : {level} ,\nsalary : {salary} ,\nhirsdate : {hireDate} ,\ngender : {gender}\n";
        }

        /*
         display employee salary in a currency
         format. [Use String.Format() Function]
        */
        public void display()
        {
            Console.WriteLine(string.Format("{0:C}",salary));
        }

        //  Sort the employees based on their hire date
        public class ReverseClass : IComparer<employee>
        {
            public int Compare(employee? x, employee? y)
            {
                if (x == null && y == null) return 0;
                if (x == null) return 1;
                if (y == null) return -1;

                DateTime dateX = new DateTime(x.HireDate.Year, x.HireDate.Month, x.HireDate.Day);
                DateTime dateY = new DateTime(y.HireDate.Year, y.HireDate.Month, y.HireDate.Day);
          
                return dateX.CompareTo(dateY);
            }
        }


    }
}
