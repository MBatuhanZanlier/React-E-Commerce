using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API.Controllers; 

[ApiController]  
[Route("API/[Controller]")] 

public class ErrorController : ControllerBase
{
    
    [HttpGet]
    public IActionResult NotFoundError()
    {
        return NotFound();
    } 

    [HttpGet("bad-request")] 
    public IActionResult BadRequestError()
    {
        return BadRequest();
    } 

    
    [HttpGet("unauthorized")]
    public IActionResult UnauthorizedError()
    {
        return Unauthorized();
    } 
    
    [HttpGet("server-error")]
    public IActionResult ServerError()
    {
        throw new Exception("Server Error");
    }  

    [HttpGet("validation-error")]    
    public IActionResult ValidationError()
    {
           ModelState.AddModelError("validation error1", "validation error details"); 
          ModelState.AddModelError("validation error2", "validation error details");
      return ValidationProblem();
        
    }
}    
