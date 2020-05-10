using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MSIP_App.Models;

namespace MSIP_App.Controllers
{
    public class UrlsController : Controller
    {
        private readonly MSIPContext _context;

        public UrlsController(MSIPContext context)
        {
            _context = context;
        }

        // GET: Urls
        public async Task<IActionResult> Index()
        {
            return View(await _context.Urls.ToListAsync());
        }

        // GET: Urls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var urls = await _context.Urls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (urls == null)
            {
                return NotFound();
            }

            return View(urls);
        }

        // GET: Urls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Urls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Url")] Urls urls)
        {
            if (ModelState.IsValid)
            {
                _context.Add(urls);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(urls);
        }

        // GET: Urls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var urls = await _context.Urls.FindAsync(id);
            if (urls == null)
            {
                return NotFound();
            }
            return View(urls);
        }

        // POST: Urls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Url")] Urls urls)
        {
            if (id != urls.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(urls);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UrlsExists(urls.Id))
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
            return View(urls);
        }

        // GET: Urls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var urls = await _context.Urls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (urls == null)
            {
                return NotFound();
            }

            return View(urls);
        }

        // POST: Urls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var urls = await _context.Urls.FindAsync(id);
            _context.Urls.Remove(urls);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UrlsExists(int id)
        {
            return _context.Urls.Any(e => e.Id == id);
        }
    }
}
