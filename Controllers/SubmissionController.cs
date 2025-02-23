using WishlistExpress.Models;
using WishlistExpress.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WishlistExpress.Controllers;

public class SubmissionController : Controller
{
    private readonly ApplicationDbContext _context;

    public SubmissionController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(int wishlistId, int userId)
    {
        var submissions = await _context.Submissions
            .Where(s => s.WishlistId == wishlistId && s.UserId == userId)
            .ToListAsync();
        return View(submissions);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Submission submission)
    {
        if (ModelState.IsValid)
        {
            _context.Submissions.Add(submission);
            await _context.SaveChangesAsync();
            return RedirectToAction("Success");
        }
        return View(submission);
    }

    public IActionResult Success()
    {
        return View();
    }
}