namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new FilmContext())
            {
                // Insert
                var member = new Member 
                {
                    Name="Alyaa",
                    Address = "Cairo",
                };
                context.Member.Add(member);
                context.SaveChanges();
            }


            //Select
            using (var context = new FilmContext())
            {
                var members = context.Member.ToList();
                foreach (var m in members)
                    Console.WriteLine($"{m.MemberID} - {m.Name}");
            }

            //update
            using (var context = new FilmContext())
            {
                var members = context.Member.FirstOrDefault();
                if (members != null)
                {
                    members.Name = "alyaa update";
                    context.SaveChanges();
                }
            }

            //delete
            using (var context = new FilmContext())
            {
                var members = context.Member.FirstOrDefault();
                if (members != null)
                {
                    context.Member.Remove(members);
                    context.SaveChanges();
                }
            }
        }
    }
}
