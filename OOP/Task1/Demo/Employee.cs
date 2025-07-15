namespace Demo
{
    internal class Employee
    {

        private string name;
        private int salary;

        public int id { get; }

        public string Name { 
            get { return name ;}
            set { this.name = value ; }
        }

        public int Salary
        {
            get { return salary ;}
            set { this.salary = value <=1000 ? value : 1000 ; }
        }


        public override string ToString()
        {
            return $"id : {id}  , name : {Name} , salary : {Salary} ";
        }



        public Employee(int id , string name , int salary)
        {
            this.id = id;
            this.Name = name;
            this.Salary = salary;

        }
    }
}
