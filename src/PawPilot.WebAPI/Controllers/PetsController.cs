using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace PawPilot.WebAPI.Controllers;

/// <summary>
/// Controller for managing pet information
/// </summary>
[ApiController]
[Route("pets")]
public class PetsController : ControllerBase
{
    ///<summary>
    ///Get all pets
    ///</summary>
    /// <returns>Returns a list of pets.</returns>
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok("in progress.");
    }

    ///<summary>
    ///Get all tasks for a given pet id
    ///</summary>
    /// <returns>Returns a list of tasks.</returns>
    [HttpGet("{id}/tasks")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok("in progress.");
    }

    ///<summary>
    ///Create a new pet
    ///</summary>
    /// <returns>Returns the newly created pet.</returns>
    [HttpPost]
    public async Task<IActionResult> Create()
    {
        return Ok("in progress.");
    }
}
