namespace Demo
{
    public class parent
    {
        public int x {  get; set; }

        public int y { get; set; }

        public parent(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual int product()
        {
            return x * y;
        }

        public virtual void print()
        {
            Console.WriteLine($"x: {x} , y : {y} ");
        }
    }
}
