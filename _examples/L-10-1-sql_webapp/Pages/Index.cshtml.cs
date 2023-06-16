using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.Sqlite; // +++

namespace sql_webapp.Pages; 

public class IndexModel : PageModel
{
    /*private readonly ILogger<IndexModel> _logger; // ---

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }*/

        
    public List<string> Columns { get; set; }  = new List<string>();
    public List<List<string>> Rows { get; set; }  = new List<List<string>>();

    public void OnGet() // +++
    {
        string connectionString = "Data Source=../sql/students_db.db";
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            string sql = @" SELECT  Registration.StudentID, Registration.ClassID,   
                            Students.Advisor,
                            Faculty.Room, Faculty.Dept
                   FROM     Registration
                   JOIN     Students on Registration.StudentID = Students.StudentID
                   JOIN     Faculty on Faculty.Name = Students.Advisor
                   ORDER BY Registration.StudentID ; ";

            using (var command = new SqliteCommand(sql, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    Columns = new List<string>();
                    Rows = new List<List<string>>();

                    // Get column names
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Columns.Add(reader.GetName(i));
                    }

                    // Get rows
                    while (reader.Read())
                    {
                        var row = new List<string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.Add(reader[i].ToString() ! ); // ! -> null forgiving operator
                        }
                        Rows.Add(row);
                    }
                }
            }
        }
    }        
}
    
