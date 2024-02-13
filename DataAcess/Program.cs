using Dapper;
using DataAcess.Models;
using Microsoft.Data.SqlClient;

// OBS: Versões atualizadas do dapper e Microsoft.Data.SqlClient podem não funcionar da mesma forma e apresentar erros.
// pois eles verificam as certificações SSL/TLS.
// Versões que usei: dotnet add package Microsoft.Data.SqlClient --version 2.1.3  e  dotnet add package Dapper --version 2.0.90

const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=matias202510#";

using (var connection = new SqlConnection(connectionString)){
    // CreateManyCategory(connection);
    // UpdateCategory(connection);
    ListCategories(connection);
    // ExecuteProcedure(connection);
    
}


static void ListCategories(SqlConnection connection){
    var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");

    foreach (var item in categories)
    {
        Console.WriteLine($"{item.Id} - {item.Title}");
    }
}

static void CreateManyCategory(SqlConnection connection){

    var category = new Category();
    category.Id = Guid.NewGuid();
    category.Title = "Amazon AWS";
    category.Url = "' INSERT INTO Users VALUES () '";
    category.Description = "Categoria destinada  a serviços do AWS";
    category.Order=8;
    category.Summary = "AWS Cloud";
    category.Featured = false;

    var category2 = new Category();
    category2.Id = Guid.NewGuid();
    category2.Title = "Categoria Nova";
    category2.Url = "categoria-nova";
    category2.Description = "Categoria nova";
    category2.Order=9;
    category2.Summary = "Categoria";
    category2.Featured = true;

    var insertSql = $@"INSERT INTO
        [Category]
        VALUES(
            @Id,
            @Title, 
            @Url, 
            @Summary, 
            @Order, 
            @Description, 
            @Featured)";

    var rows = connection.Execute(insertSql, new[]{
        new {
        category.Id,
        category.Title, 
        category.Url, 
        category.Summary, 
        category.Order, 
        category.Description, 
        category.Featured
    },new{
        category2.Id,
        category2.Title, 
        category2.Url, 
        category2.Summary, 
        category2.Order, 
        category2.Description, 
        category2.Featured
    }
    });
    
    Console.WriteLine($"{rows} linhas inseridas");
}

static void UpdateCategory(SqlConnection connection){
    var updateQuery = "UPDATE [Category] SET [Title]=@title WHERE [Id]=@id";
    var rows = connection.Execute(updateQuery, new{
        id = new Guid("af3407aa-11ae-4621-a2ef-2028b85507c4"),
        title = "Frontend 2024"
    });

    Console.WriteLine($"{rows} registros atualizados");
}

static void ExecuteProcedure(SqlConnection connection){
    var procedure = "[spDeleteStudent]";
    var pars = new { StudentId = "cf1213aa-266b-48f5-b014-8bde98944b66" };
    var affectedRows =  connection.Execute(
        procedure, 
        pars, 
        commandType: System.Data.CommandType.StoredProcedure);

    Console.WriteLine($"{affectedRows} linhas afetadas");


    // No Sql coloquei : 
    
    // SELECT * FROM [Student]

    // INSERT INTO [Student] VALUES(NEWID(), 'ally matias', 'matias@gmail.com', 12233, 888888, 10-09-2021, 12-01-2024)
} 