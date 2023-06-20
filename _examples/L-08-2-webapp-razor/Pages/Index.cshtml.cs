using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace WebApp.Pages;

public class IndexModel : PageModel
{
    // private readonly ILogger<IndexModel> _logger;

    public static int countplus;

    [BindProperty]
    public string Data { get; set; } = "";

    // [BindProperty(SupportsGet = true)]
    public string Msg { set; get; } = ""; /* *** */
    public string MyVariable { get; set; } = ""; 

    public IActionResult OnPost(){  
            countplus ++;
            
            //  Msg = "Hold my beer x2 x4 " + countplus;
            Console.WriteLine("---MSG change --- -> post msg :" + Msg);
            Console.WriteLine("---MSG change --- -> post data:" + Data);
            
            return  Page(); // RedirectToPage("/Privacy"); // Page(); // Partial("_IndexModel"); // Page(); //Partial("IndexModel");

    }

 }
