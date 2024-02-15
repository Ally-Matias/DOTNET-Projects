using System.ComponentModel.DataAnnotations.Schema;
using Dapper.Contrib.Extensions;

namespace Blog.Models{
    [Dapper.Contrib.Extensions.Table("[Tag]")]
    public class Tag{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}