using Curso.ContentContext;
using System.Linq;
using System;
using System.Collections.Generic;

var articles = new List<Article>();
articles.Add(new Article("Artigo sobre OOP", "Orientacao a objeto"));
articles.Add(new Article("Artigo sobre C#", "Teste"));
articles.Add(new Article("Artigo sobre .NET", "Teste .NET"));

foreach (var article in articles)
{
    Console.WriteLine(article.id);
    Console.WriteLine(article.Title);
    Console.WriteLine(article.Url);
}

var courses = new List<Course>();
var courseOOP = new Course("Fundamentos", "fundamentooos");
var courseCsharp = new Course("C#", "fundamentooos");
var courseDotNet = new Course(".NET", "fundamentooos");

courses.Add(courseOOP);
courses.Add(courseCsharp);
courses.Add(courseDotNet);

var careers = new List<Career>();
var careerDotNet = new Career("Especialista .net", "especialista");
var CareerItem = new CareerItem(1, "comece por aqui 1", "teste", courseOOP);
var CareerItem3 = new CareerItem(3, "comece por aqui 3", "teste", courseDotNet);
var CareerItem2 = new CareerItem(2, "comece por aqui 2", "teste", null);


careerDotNet.Items.Add(CareerItem);
careerDotNet.Items.Add(CareerItem3);
careerDotNet.Items.Add(CareerItem2);

careers.Add(careerDotNet);

foreach (var career in careers)
{
    Console.WriteLine(career.Title);
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course?.Title);
        Console.WriteLine(item.Course?.Level);

        // foreach (var notification in item.Notifications)
        // {
        //     Console.WriteLine($"{notification.Property} - {notification.Message}");
        // }
    }
}
