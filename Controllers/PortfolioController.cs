using Microsoft.AspNetCore.Mvc;
namespace portfolio_1.Controllers;
public class PortfolioController : Controller
{




    // Route declaration Option A
    // This will go to "localhost:5XXX"
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "This is my index";
    }
    



    // Route declaration Option B
    // This will go to "localhost:5XXX/projects"
    
    [HttpGet("projects")]
    public string Projects()
    {
        return "These are my Projects";
    }
    

   // Route declaration Option C
    // This will go to "localhost:5XXX/contact"
    
    [HttpGet("contact")]
    public string Contact()
    {
        return "This is my Contact";
    }
    







    // Don't worry about what the form is doing for now. We'll get to those soon!
    // Note: You will not be able to navigate to this route! This is for demonstration only!
    public string FormSubmission(string formInput)
    {
    	// Logic for post request here
        return "I handled a request!";
    }
}

