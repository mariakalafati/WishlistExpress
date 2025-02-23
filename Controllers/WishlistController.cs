using WishlistExpress.Models;
using WishlistExpress.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WishlistExpress.Controllers;

public class WishlistController : Controller
{
    private readonly ApplicationDbContext _context;

    public WishlistController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(int userId)
    {
        var wishlists = await _context.Wishlists.Where(w => w.UserId == userId).ToListAsync();
        return View(wishlists);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Wishlist wishlist)
    {
        if (ModelState.IsValid)
        {
            _context.Wishlists.Add(wishlist);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { userId = wishlist.UserId });
        }
        return View(wishlist);
    }
}