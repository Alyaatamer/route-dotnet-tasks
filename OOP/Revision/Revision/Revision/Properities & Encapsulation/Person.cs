namespace Revision.Properities___Encapsulation
{
    internal class Person
    {
        // Bundling & Hiding
        private string name;
        private int age;
        private double height;


        public void Talk()
        {

        }

        // prop
        public string Name
        {
            get { return name; }

            set 
            {
                if (!string.IsNullOrEmpty(value) && !char.IsUpper(value[0]))
                {
                    name = char.ToUpper(value[0]) + value.Substring(1);
                }
                else if (string.IsNullOrEmpty(value))
                {
                    name = "Unknown";
                }
                else
                {
                    name = value;
                }     
            }
        }

        public int Age
        {
            get; set;
        }
    }
}
