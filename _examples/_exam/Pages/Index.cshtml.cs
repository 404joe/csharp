using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace fj.Pages;

public struct Person
{
    public string pName { get; set; }
    public int pAge { get; set; }
}

public class IndexModel : PageModel
{
    [BindProperty] public string Name { get; set; } = "";
    [BindProperty] public int Age { get; set; } = 0;

    public List<Person> persons { get; set; } = new List<Person>();
 
    public IActionResult OnPost() { 
        // Read the JSON file and load the list of Person objects
        string jsonr = System.IO.File.ReadAllText("./data.json");
        
        // List<Person>
        persons = JsonSerializer.Deserialize<List<Person>>(jsonr);

        // Create a new Person object and add it to the list
        Person newPerson = new Person { pName = Name, pAge = Age };
        persons.Add(newPerson);

        // Convert the list of objects to JSON format
        string jsonw = JsonSerializer.Serialize(persons);

        // Save the updated list back to the JSON file
        System.IO.File.WriteAllText("./data.json", jsonw);
        
        return Page(); 
    }

}