namespace Demo
{
    internal interface ICar
    {
        string Code { get; }
        CarColors Color { get; set; }
        string Model { get; set; }
        CarType Type { get; set; }
        int Year { get; }

        string ToString();
    }
}