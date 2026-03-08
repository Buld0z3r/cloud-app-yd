using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CloudBackend.Data;
using CloudBackend.Models;
using System.Threading.Tasks;

namespace CloudBackend.Controllers;

[ApiController]
[Route("api/[controller]")] // http://localhost:8081/api/tasks
public class TasksController : ControllerBase
{
    private readonly AppDbContext _context;

    // Dependency Injection kontekstu bazy danych
    public TasksController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet] // 1. Lista (READ ALL)
    public async Task<ActionResult> GetAll()
    {
        return Ok(await _context.Tasks.ToListAsync());
    }

    [HttpGet("{id}")] // 2. Szczegóły (READ ONE)
    public async Task<ActionResult> GetById(int id)
    {
        var task = await _context.Tasks.FindAsync(id);

        if (task == null)
            return NotFound();

        return Ok(task);
    }

    [HttpPost] // 3. Dodaj (CREATE)
    public async Task<ActionResult> Create(CloudTask task)
    {
        _context.Tasks.Add(task);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = task.Id }, task);
    }

    [HttpPut("{id}")] // 4. Edytuj (UPDATE)
    public async Task<ActionResult> Update(int id, CloudTask task)
    {
        if (id != task.Id)
            return BadRequest("ID mismatch");

        _context.Entry(task).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")] // 5. Usuń (DELETE)
    public async Task<ActionResult> Delete(int id)
    {
        var task = await _context.Tasks.FindAsync(id);

        if (task == null)
            return NotFound();

        _context.Tasks.Remove(task);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}