namespace Task3
{
    public class Stud_Course
    {
        public int Stud_ID { get; set; }
        public virtual Student Student { get; set; } = null!;

        public int Course_ID { get; set; }
        public virtual Course Course { get; set; } = null!;
        public decimal Grade { get; set; }

    }
}
