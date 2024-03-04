using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PawPilot.WebAPI.Controllers;

/// <summary>
/// Controller for managing task information
/// </summary>
[ApiController]
[Route("tasks")]
public class TasksController : ControllerBase
{
    ///<summary>
    ///Create a new task
    ///</summary>
    /// <returns>Returns the newly created task.</returns>
    [HttpPost]
    public async Task<IActionResult> Create()
    {
        return Ok("in progress.");
    }

    ///<summary>
    ///Complete a task
    ///</summary>
    /// <returns>Returns the updated task.</returns>
    [HttpPut("{id}/complete")]
    public async Task<IActionResult> Complete(int id)
    {
        return Ok("in progress.");
    }

    ///<summary>
    ///Delete a task
    ///</summary>
    /// <returns>??.</returns>
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok("in progress.");
    }

    ///<summary>
    ///Complete a task
    ///</summary>
    /// <returns>Returns the task with the updated to-do date.</returns>
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id)
    {
        return Ok("in progress.");
    }

    ///<summary>
    ///Get all events for a given task id
    ///</summary>
    /// <returns>Returns a list of events.</returns>
    [HttpGet("{id}/events")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok("in progress.");
    }

}
