using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.Data.Sqlite;

namespace sqlw.Pages;

public class IndexModel : PageModel
{
    public List<string> Cols { get; set; }  = new List<string>(); // to pass to index.cshtml
    public List<List<string>> Rows { get; set; }  = new List<List<string>>(); // to pass to index.cshtml
    
    public void OnGet() // The OnGet method is called when a request is made to index.html
    {
        string connectionString = "Data Source=students.db";
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            string sql =" SELECT NAME, NUMBER, MARK FROM MARKS; ";
                   
            var command = new SqliteCommand(sql, connection);
            
            var reader = command.ExecuteReader();
                
            Cols = new List<string>();
            Rows    = new List<List<string>>();
                    
            // column names
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Cols.Add(reader.GetName(i));
            }
                    
            // rows
            while (reader.Read())
            {
                var row = new List<string>();
                for (int i = 0; i < reader.FieldCount; i++)
                {   
                    row.Add(reader[i].ToString() ! ); 
                }
                Rows.Add(row);
                
            }
        }        
    }      
}
