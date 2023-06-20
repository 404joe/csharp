using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace WebApp.Pages;

public class IndexModel : PageModel
{

    [BindProperty]
    public string Data { get; set; } = "";

    public string Msg { set; get; } = ""; /* *** */
    public string MyVariable { get; set; } = ""; 

    public IActionResult OnPost(){  
            countplus ++;
            
            //  Msg = "Hold my beer x2 x4 ";
            Console.WriteLine("---MSG change --- -> post msg :" + Msg);
            Console.WriteLine("---MSG change --- -> post data:" + Data);
            
            return  Page(); // RedirectToPage("/Privacy"); // Partial("_IndexModel"); // Page(); - same page

    }

 }
