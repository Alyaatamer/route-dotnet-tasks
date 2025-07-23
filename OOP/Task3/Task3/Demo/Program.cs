namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Id = 1,
                FUllName = "Test hhjhh",
                Email = "Test@gmail.com",
                Password = "password",
                security = new Guid()
            };

            UserVm u = (UserVm)user;
            Console.WriteLine(u);


        }
    }
}
