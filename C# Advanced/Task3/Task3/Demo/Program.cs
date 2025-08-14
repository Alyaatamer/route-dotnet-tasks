namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>()
            {
                new Department("HR",1),
                new Department("Sales",2),
            };

            List<Employee> employeeList = new List<Employee>()
            {
                new Employee(3,"alyaa",1000,1),
                new Employee(4,"engy",200000,2),
                new Employee(5,"soher",30000,1),
            };

            Dictionary<Department,List<Employee>> pairs = new Dictionary<Department,List<Employee>>();

            foreach(Department dept in departments)
            {
                List<Employee> deptemp = new List<Employee>();

                foreach(Employee emp in employeeList)
                {
                    if (dept.Id == emp.deptId)
                    {
                        deptemp.Add(emp);
                    }
                }

                if(deptemp.Count > 0)
                {
                    pairs.Add(dept,deptemp);
                }
            }

            foreach (KeyValuePair<Department,List<Employee>> pair in pairs)
            {
                Console.WriteLine(pair.Key);
                foreach (Employee emp in pair.Value)
                {
                    Console.WriteLine(emp);
                }
            }
        }
    }
}
