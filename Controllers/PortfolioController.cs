using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;



namespace portfolio_1.Controllers;
public class PortfolioController : Controller
{

[HttpGet("")]
    public ViewResult Home()
    {

        return View("Index");
    }



    [HttpGet("home")]
    public ViewResult Index()
    {

        return View("Index");
    }

    [HttpGet("projects")]
    public ViewResult Projects()
    {
        return View("MyProjects");
    }



    [HttpGet("contact")]
    public ViewResult Contact()
    {
        return View("Contact");
    }








    // Don't worry about what the form is doing for now. We'll get to those soon!
    // Note: You will not be able to navigate to this route! This is for demonstration only!
    public string FormSubmission(string formInput)
    {
        // Logic for post request here
        return "I handled a request!";
    }
}

