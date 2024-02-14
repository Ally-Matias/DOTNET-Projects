using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class UserRepositoriy
    {
        private readonly SqlConnection _connection;

        public UserRepositoriy(SqlConnection connection){
            _connection = connection;
        }
        public IEnumerable<User> Get()
        {
            return _connection.GetAll<User>();
        }

        public User Get(int id)
        {
            return _connection.Get<User>(id);
        }

        public void Create(User user)
        {
            _connection.Insert<User>(user);
        }
    }
}