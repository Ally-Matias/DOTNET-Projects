using System.ComponentModel.DataAnnotations.Schema;
using Dapper.Contrib.Extensions;

namespace Blog.Models{
    [Dapper.Contrib.Extensions.Table("[Category]")]
    public class Category{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        
        // public List<Post> Posts { get; set; }

    }
}