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
    public class UsersController : Controller
    {
<<<<<<< HEAD
        private readonly MSIPContext _context;

        public UsersController(MSIPContext context)
=======
<<<<<<< HEAD
        private readonly MSIP_AppContext _context;

        public UsersController(MSIP_AppContext context)
=======
        private readonly MSIPContext _context;

        public UsersController(MSIPContext context)
>>>>>>> master
>>>>>>> HarleyBranch
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
<<<<<<< HEAD
            return View(await _context.Users.ToListAsync());
=======
<<<<<<< HEAD
            return View(await _context.User.ToListAsync());
=======
            return View(await _context.Users.ToListAsync());
>>>>>>> master
>>>>>>> HarleyBranch
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

<<<<<<< HEAD
            var user = await _context.Users
=======
<<<<<<< HEAD
            var user = await _context.User
=======
            var user = await _context.Users
>>>>>>> master
>>>>>>> HarleyBranch
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,Password,DateOfBirth,FirstName,LastName,Location,Email,PhoneNumber,DateJoined,Bio,LinkedInURL,GitHubURL,ForumPriv")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

<<<<<<< HEAD
            var user = await _context.Users.FindAsync(id);
=======
<<<<<<< HEAD
            var user = await _context.User.FindAsync(id);
=======
            var user = await _context.Users.FindAsync(id);
>>>>>>> master
>>>>>>> HarleyBranch
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,UserName,Password,DateOfBirth,FirstName,LastName,Location,Email,PhoneNumber,DateJoined,Bio,LinkedInURL,GitHubURL,ForumPriv")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
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
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

<<<<<<< HEAD
            var user = await _context.Users
=======
<<<<<<< HEAD
            var user = await _context.User
=======
            var user = await _context.Users
>>>>>>> master
>>>>>>> HarleyBranch
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
<<<<<<< HEAD
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
=======
<<<<<<< HEAD
            var user = await _context.User.FindAsync(id);
            _context.User.Remove(user);
=======
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
>>>>>>> master
>>>>>>> HarleyBranch
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(long id)
        {
<<<<<<< HEAD
            return _context.Users.Any(e => e.Id == id);
=======
<<<<<<< HEAD
            return _context.User.Any(e => e.Id == id);
=======
            return _context.Users.Any(e => e.Id == id);
>>>>>>> master
>>>>>>> HarleyBranch
        }
    }
}
