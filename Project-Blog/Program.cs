using Microsoft.Data.SqlClient;
using Blog.Screens.TagScreens;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=matias202510#";
        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }


        private static void Load(){
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de tag");
            Console.WriteLine("5 - Vincular perfil/usuário");
            Console.WriteLine("6 - Vincular post/tag");
            Console.WriteLine("7 - Relatórios");
            Console.WriteLine("8 - Sair");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 4:
                    MenuTagScreen.Load();
                    break;
                case 8:
                    System.Environment.Exit(0);
                    break;
                default: Load(); break;
            }
        }










        // public static void ReadUsersWithRoles(SqlConnection connection)
        // {
        //     var repository = new UserRepository(connection);
        //     var items = repository.GetWithRoles();

        //     foreach (var item in items)
        //     {
        //         Console.WriteLine(item.Name);
        //         foreach (var role in item.Roles){
        //             Console.WriteLine($" - {role.Name}");
        //         }
        //         {
                    
        //         }
        //     }
        // }


        // public static void ReadRoles(SqlConnection connection)
        // {
        //     var repository = new Repository<Role>(connection);
        //     var items = repository.Get();

        //     foreach (var item in items)
        //     {
        //         Console.WriteLine(item.Name);
        //     }
        // }

        // public static void ReadTags(SqlConnection connection)
        // {
        //     var repository = new Repository<Tag>(connection);
        //     var items = repository.Get();

        //     foreach (var item in items)
        //     {
        //         Console.WriteLine(item.Name);
        //     }
        // }





        // public static void ReadUser()
        // {
        //     using (var connection = new SqlConnection())
        //     {
        //         var user = connection.Get<User>(1);

        //         Console.WriteLine(user.Name);
        //     }
        // }

        // public static void CreateUser()
        // {
        //     var user = new User(){
        //         Bio = "Equipe Matias",
        //         Email = "hello@equipe.io",
        //         Image = "https://..",
        //         Name = "equipe Matias",
        //         PasswordHash = "HASH",
        //         Slug = "equipe-matias"
        //     };

        //     using (var connection = new SqlConnection(CONNECTION_STRING))
        //     {
        //         connection.Insert<User>(user);

        //         Console.WriteLine("Cadastro realizado com sucesso!");
        //     }
        // }

        // public static void UpdateUser()
        // {
        //     var user = new User(){
        //         Id = 2,
        //         Bio = "Equipe | Matias",
        //         Email = "hello@equipe.io",
        //         Image = "https://..",
        //         Name = "Equipe de suporte | Matias",
        //         PasswordHash = "HASH",
        //         Slug = "equipe-matias"
        //     };

        //     using (var connection = new SqlConnection(CONNECTION_STRING))
        //     {
        //         connection.Update<User>(user);

        //         Console.WriteLine("Atualização realizado com sucesso!");
        //     }
        // }


        // public static void DeleteUser()
        // {
        //     using (var connection = new SqlConnection(CONNECTION_STRING))
        //     {
        //         var user = connection.Get<User>(2);

        //         connection.Delete<User>(user);

        //         Console.WriteLine("Exclusão realizado com sucesso!");
        //     }
        // }
    }
}
