using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.Data.Sqlite;

namespace MyApp.Namespace
{
    public class PagesModel : PageModel
    {
        [BindProperty] public string Name { get; set; } = "";
        [BindProperty] public string Number { get; set; } = "";
        [BindProperty] public double Mark { get; set; } = 4.00;

        public void OnPost()
        {
            string connectionString = "Data Source=students.db";
            var connection = new SqliteConnection(connectionString);
            
            connection.Open();
            string sql = $"INSERT INTO MARKS (NAME, NUMBER, MARK) VALUES ( '{Name}', '{Number}', '{Mark}' ); ";
            var command = new SqliteCommand(sql, connection);
                
            command.ExecuteNonQuery();
        }
    }
}
