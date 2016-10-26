namespace DapperLearn
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using Dapper;

    internal class Program
    {
        private static void Main()
        {
            var connectionString = @"Data Source=192.168.1.43;Initial Catalog=DapperLearn;User ID=sa; Password=zxc12EE";


            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var users = db.Query<User>("SELECT * FROM Users").ToList();
                users.ForEach(Console.WriteLine);
            }

            Console.WriteLine(new string('-', 80));

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var user = db.Query<User>("SELECT * FROM Users Where Id = 1").FirstOrDefault();
                Console.WriteLine(user);
            }
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"Id: {Id}, Name: {Name}, Age: {Age}";
    }
}