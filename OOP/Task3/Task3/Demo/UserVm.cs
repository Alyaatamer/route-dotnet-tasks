
namespace Demo
{
    internal class UserVm
    {
        public int id {  get; set; }
        public string? FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public static explicit operator UserVm(User user)
        {
            string[] Names = user?.FUllName?.Split(" ");
            return new UserVm()
            {
                id = user.Id,
                FirstName = Names[0] ?? string.Empty,
                LastName = Names[1] ?? string.Empty,
                Email = user.Email
            };
        }
        public override string ToString()
        {
            return $"userid = {id}\n firstname = {FirstName}\n lastname = {LastName}\n email = {Email}";
        }
    }
}
