using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Controllers
{
  public class PatronsController : Controller
  {
    private readonly LibraryContext _db;

    public PatronsController(LibraryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Patron> model = _db.Patrons.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Patron patron)
    {
      _db.Patrons.Add(patron);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisPatron = _db.Patrons.FirstOrDefault(patron => patron.PatronId == id);
      return View(thisPatron);
    }

    public ActionResult Checkout(int id)
    {
      var thisPatron = _db.Patrons.FirstOrDefault(patron => patron.PatronId == id);
      // List<Book> thisbook = _db.Books.ToList();
      ViewBag.BookId = new SelectList(_db.Books, "BookId", "Title");
      return View(thisPatron);
    }

    [HttpPost]
    public ActionResult Checkout(Patron patron)
    {
      if (patron.Books.Count != 0)
      {
        _db.Patrons.Add(patron);
        _db.SaveChanges();
        return RedirectToAction("Details", new { id = patron.PatronId });
      }
      else
      {
        return RedirectToAction("Books", "Index");

     }
    }
  }
}