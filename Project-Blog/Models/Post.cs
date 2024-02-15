using System.ComponentModel.DataAnnotations.Schema;
using Dapper.Contrib.Extensions;

namespace Blog.Models{
    [Dapper.Contrib.Extensions.Table("[Post]")]
    public class Post{
        public int Id { get; set; }
        public string Name { get; set; }
        
        // public int CategoryId { get; set; }
    }
}