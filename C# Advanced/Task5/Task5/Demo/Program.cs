namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball(10);

            Player p1 = new Player("Mo Salah", "liverpool");
            Player p2 = new Player("Alisoon", "liverpool");
            Player p3 = new Player("ejka", "Man united");
            Player p4 = new Player("wkjaghr", "Man United");

            ball.OnBallChanged += p1.Run;
            ball.OnBallChanged += p2.Run;
            ball.OnBallChanged += p3.Run;
            ball.OnBallChanged += p4.Run;

            ball.Location = new Location(10, 20, 30);
            Console.WriteLine("====================================");

            ball.Location = new Location(10, 20, 30);
            Console.WriteLine("====================================");

            ball.Location = new Location(40, 50, 60);
           

        }
    }
}
