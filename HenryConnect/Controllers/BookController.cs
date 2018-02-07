using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using HenryConnect.Models;
using Microsoft.EntityFrameworkCore;

namespace HenryConnect.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository repository;
        private readonly HenryDbContext _context;
        public BookController(IBookRepository repo, HenryDbContext context)
        {
            repository = repo;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> 
            Create([Bind("BookCode,Title,PublisherCode,Type,Paperback")] ABook aBook)
        {
           // _context.Book.Find(aBook.BookCode);
           

            if (ModelState.IsValid)
            {
                _context.Add(aBook);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch(Exception ex)
                {//this stops the error
                    
                    return View(aBook);//send back to Create
                }
                return RedirectToAction("List");
            }
            return View(aBook);//send back to Create
        }
        public ViewResult List() => View(repository.Book
            .OrderBy(b => b.Title));

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Update(string id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var aBook = await _context.Book.SingleOrDefaultAsync(m => m.BookCode == id);
            if(aBook == null)
            {
                return NotFound();
            }
            return View(aBook);
        }

        private bool ABookExists(string id)
        {
            return _context.Book.Any(m => m.BookCode == id);
        }
        [HttpPost]
        public async Task<IActionResult> Update(string id, 
            [Bind("BookCode,Title,PublisherCode,Type,Paperback")] ABook aBook)
        {
            if(id != aBook.BookCode)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aBook);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if(!ABookExists(aBook.BookCode))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("List");
            }//model state is valid
            return View(aBook);
        }//end Update

    }
}
