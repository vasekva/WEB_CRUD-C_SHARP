using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEB_CRUD.Data;
using WEB_CRUD.Models;

namespace WEB_CRUD.Controllers
{
    public class TaskEntitiesController : Controller
    {
        private readonly TaskContext _context;

        public TaskEntitiesController(TaskContext context)
        {
            _context = context;
        }

        // GET: TaskEntities
        public async Task<IActionResult> Index()
        {
            var taskContext = _context.Tasks.Include(t => t.Project);
            return View(await taskContext.ToListAsync());
        }

        // GET: TaskEntities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskEntity = await _context.Tasks
                .Include(t => t.Project)
                .FirstOrDefaultAsync(m => m.TaskEntityID == id);
            if (taskEntity == null)
            {
                return NotFound();
            }

            return View(taskEntity);
        }

        // GET: TaskEntities/Create
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_context.Projects, "ID", "ID");
            return View();
        }

        // POST: TaskEntities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaskEntityID,TaskName,TaskStatus,TaskDescriprion,TaskPriority,ProjectId")] TaskEntity taskEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taskEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "ID", "ID", taskEntity.ProjectId);
            return View(taskEntity);
        }

        // GET: TaskEntities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskEntity = await _context.Tasks.FindAsync(id);
            if (taskEntity == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "ID", "ID", taskEntity.ProjectId);
            return View(taskEntity);
        }

        // POST: TaskEntities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TaskEntityID,TaskName,TaskStatus,TaskDescriprion,TaskPriority,ProjectId")] TaskEntity taskEntity)
        {
            if (id != taskEntity.TaskEntityID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taskEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskEntityExists(taskEntity.TaskEntityID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "ID", "ID", taskEntity.ProjectId);
            return View(taskEntity);
        }

        // GET: TaskEntities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskEntity = await _context.Tasks
                .Include(t => t.Project)
                .FirstOrDefaultAsync(m => m.TaskEntityID == id);
            if (taskEntity == null)
            {
                return NotFound();
            }

            return View(taskEntity);
        }

        // POST: TaskEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taskEntity = await _context.Tasks.FindAsync(id);
            _context.Tasks.Remove(taskEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskEntityExists(int id)
        {
            return _context.Tasks.Any(e => e.TaskEntityID == id);
        }
    }
}
