using Microsoft.AspNetCore.Mvc;

namespace Suzane.WebApp.Controllers;
public class MyFirstController : Controller
{
    private readonly IMyFileService _fileService;

    public MyFirstController(IMyFileService fileService)
    {
        _fileService = fileService;
    }
    [HttpGet("readmyfile")]
    public IActionResult ReadMyFile([FromQuery] string filePath)
    {
        if (string.IsNullOrEmpty(filePath))
        {
            return BadRequest("File path cannot be null or empty");
        }

        var content = _fileService.ReadMyFile(filePath);
        return Ok(content);
    }


}