using Curso.NotificationContext;

namespace Curso.ContentContext{
    public class Article : Content{

        public Article(string title, string url) 
        : base(title, url){
            
        }
    }
}