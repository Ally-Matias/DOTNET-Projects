using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Repositories
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=matias202510#";
        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();

            // ReadUsers();
            // ReadUser();
            // CreateUser();
            // UpdateUser();
            // DeleteUser();

            connection.Close();
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new UserRepositoriy(connection);
            var users = repository.Get();

            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
        }

        public static void ReadUser()
        {
            using (var connection = new SqlConnection())
            {
                var user = connection.Get<User>(1);

                Console.WriteLine(user.Name);
            }
        }

        public static void CreateUser()
        {
            var user = new User(){
                Bio = "Equipe Matias",
                Email = "hello@equipe.io",
                Image = "https://..",
                Name = "equipe Matias",
                PasswordHash = "HASH",
                Slug = "equipe-matias"
            };

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Insert<User>(user);

                Console.WriteLine("Cadastro realizado com sucesso!");
            }
        }

        public static void UpdateUser()
        {
            var user = new User(){
                Id = 2,
                Bio = "Equipe | Matias",
                Email = "hello@equipe.io",
                Image = "https://..",
                Name = "Equipe de suporte | Matias",
                PasswordHash = "HASH",
                Slug = "equipe-matias"
            };

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Update<User>(user);

                Console.WriteLine("Atualização realizado com sucesso!");
            }
        }


        public static void DeleteUser()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(2);

                connection.Delete<User>(user);

                Console.WriteLine("Exclusão realizado com sucesso!");
            }
        }
    }
}
