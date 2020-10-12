using System;

namespace passwordhash2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            CustomPasswordHasher customPasswordHasher = new CustomPasswordHasher();
            string passwordHash = customPasswordHasher.HashPassword(password);

            Console.WriteLine($"Hashed Password: {passwordHash}");
            Console.ReadLine();

            if (customPasswordHasher.VerifyPassword(passwordHash, password))
            {
                Console.WriteLine("Verification Success");
            }
            else
            {
                Console.WriteLine("Verification Failed");
            }
            Console.ReadLine();
        }
    }
}
