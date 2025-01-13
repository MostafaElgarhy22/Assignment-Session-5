using Assignment_Session_5.First_Project;
using Assignment_Session_5.Second_Project;
using Assignment_Session_5.Third_Project;

namespace Assignment_Session_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project


            //Point_3D point_3D = new Point_3D(15, 4, 6);
            //Console.WriteLine($"{point_3D.ToString()}");

            //Point_3D PC = (Point_3D)PC.Clone();
            //Console.WriteLine(PC);

            //Point_3D[] P = new Point_3D[]
            //{
            //   new Point_3D(5, 6,10),
            //   new Point_3D(10,32,7),
            //   new Point_3D(1,1,1),
            //   new Point_3D(1,8,9)
            //};

            //Array.Sort(P);
            //foreach (var point in P)
            //{
            //    Console.WriteLine(point.ToString());
            //}

            #endregion
            #region Second Project

            //int Addition = Maths.Add(20, 10);
            //Console.WriteLine($"Addition = {Addition}");

            //int Subtraction = Maths.Subtract(20, 10);
            //Console.WriteLine($"Subtraction = {Subtraction}");

            //int Multiplication = Maths.Multiply(20, 10);
            //Console.WriteLine($"Multiplication = {Multiplication}");

            //double Division = Maths.Divide(20, 10);
            //Console.WriteLine($"Division = {Division}");
            #endregion
            #region Third Project

            Console.WriteLine("Enter UserType of : (Regular, Premium , Guest)");
            string userType = Console.ReadLine();

            User user;
            if(userType == "Regular")
            {
                user = new RegularUser("Regular User");
            }
            else if (userType == "Premium")
            {
                user = new RegularUser("Premium User");
            }
            else if (userType == "Guest")
            {
                user = new RegularUser("Guest User");
            }
            else
            {
                user = null;
            }




            if (user == null)
            {
                Console.WriteLine("Invalid user type.");
                return;
            }

            Console.WriteLine("Enter product price:");
             decimal.TryParse(Console.ReadLine(), out decimal price);

            Console.WriteLine("Enter product quantity:");
            int.TryParse(Console.ReadLine(), out int quantity);

            Discount discount = user.GetDiscount();
            decimal discountAmount = discount?.CalculateDiscount(price, quantity) ?? 0; // لو مفيش Discount هيبقا ب 0
            decimal finalPrice = (price * quantity) - discountAmount;

            Console.WriteLine($"User: {user.Name}");
            Console.WriteLine($"Discount Type: {discount?.Name ?? "No Discount"}");
            Console.WriteLine($"Discount Amount: {discountAmount:C}");
            Console.WriteLine($"Final Price: {finalPrice}");
        }
        #endregion
    }
    
}
