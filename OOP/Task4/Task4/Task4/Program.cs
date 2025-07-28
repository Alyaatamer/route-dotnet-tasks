namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01

            #region Q1
            /*
             
            What is the primary purpose of an interface in C#?
                a) To provide a way to implement multiple inheritance
                b) To define a blueprint for a class
                c) To declare abstract methods and properties
                d) To create instances of objects
            */

            // Answer: a) To provide a way to implement multiple inheritance

            #endregion

            #region Q2

            /*
             Which of the following is NOT a valid access modifier for interface members in C#?
                a) private
                b) protected
                c) internal
                d) public
            */

            // Answer : a) private
            // Interface members without an implementation can't include an access modifier.
            // Members with a default implementation can include any access modifier.
            #endregion

            #region Q3

            /*
             Can an interface contain fields in C#?
                a) Yes
                b) No
                c) Only if they are static
                d) Only if they are read only
            */

            // Answer : b) No

            //An interface can contain methods, properties, events, indexers,
            //and default implementations (from C# 8.0)
            //, but not fields.

            #endregion

            #region Q4

            /*
             In C#, can an interface inherit from another interface?
                a) No, interfaces cannot inherit from each other
                b) Yes, interfaces can inherit from multiple interfaces
                c) Yes, but only if they have the same methods
                d) Only if the interfaces are in the same namespace
            */

            // Answer : b) Yes, interfaces can inherit from multiple interfaces

            #endregion

            #region Q5

            /*
             Which keyword is used to implement an interface in a class in C#?
                a) inherit
                b) use
                c) extends
                d) implements
            */

            // Answer :  d) implements  

            #endregion

            #region Q6

            /*
             Can an interface contain static methods in C#?
                a) Yes
                b) No
                c) Only if the interface is sealed
                d) Only if the methods are private
            */

            // Answer : a) Yes

            #endregion

            #region Q7

            /*
             n C#, can an interface have explicit access modifiers for its members?
                a) Yes, for all members
                b) No, all members are implicitly public
                c) Yes, but only for abstract members
                d) Only if the interface is sealed
            */

            // Answer : b) No, all members are implicitly public

            #endregion

            #region Q8

            /*
             What is the purpose of an explicit interface implementation in C#?
                a) To hide the interface members from outside access
                b) To provide a clear separation between interface and class members
                c) To allow multiple classes to implement the same interface
                d) To speed up method resolution
            */

            // Answer : a) To hide the interface members from outside access

            #endregion

            #region Q9

            /*
             In C#, can an interface have a constructor?
                a) Yes, but it must be private
                b) No, interfaces cannot have constructors
                c) Yes, but only if the interface is sealed
                d) Only if the constructor is static
            */

            // Answer : b) No, interfaces cannot have constructors

            #endregion

            #region Q10

            /*
             How can a C# class implement multiple interfaces?
                a) By using the "implements" keyword
                b) By using the "extends" keyword
                c) By separating interface names with commas
                d) A class cannot implement multiple interfaces         
            */

            // Answer : c) By separating interface names with commas

            #endregion

            #endregion

            #region Part02

            #region Q1

            ICircle circle = new Circle(3);
            IRectangle rectangle = new Rectangle(1, 2);


            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();

            #endregion

            #region Q2

            IAuthenticationService a = new BasicAuthenticationService();

            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            bool isAuthenticated = a.AuthenticateUser(username, password);
             
            if (isAuthenticated)
            {
                Console.WriteLine("Authentication successful.");

                Console.Write("Enter role to check authorization (Admin/User): ");
                string role = Console.ReadLine();

                bool isAuthorized = a.AuthorizeUser(username, role);

                if (isAuthorized)
                    Console.WriteLine("Authorization successful.");
                else
                    Console.WriteLine("Authorization failed.");
            }
            else
            {
                Console.WriteLine("Authentication failed.");
            }


            #endregion

            #endregion

        }
    }
}
