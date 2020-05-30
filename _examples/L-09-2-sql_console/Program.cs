using System;
using System.Data.SQLite;

string connectionString = "Data Source=../sql/students_db.db";
using (SQLiteConnection connection = new SQLiteConnection(connectionString))
{
    connection.Open();

    // Execute SQL queries and fetch results
    string sql = @" SELECT  Registration.StudentID, Registration.ClassID,   
                            Students.Advisor,
                            Faculty.Room, Faculty.Dept
                   FROM     Registration
                   JOIN     Students on Registration.StudentID = Students.StudentID
                   JOIN     Faculty on Faculty.Name = Students.Advisor
                   ORDER BY Registration.StudentID ; ";

    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
    {
        using (SQLiteDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                // Access the result values using reader["column_name"]
                var column1Value = reader["Advisor"]; 
                var column2Value = reader["Room"];    

                // Process the data as needed
                Console.WriteLine($"{column1Value} | {column2Value} ");
            }
        }
    }
}
    