using Microsoft.AspNetCore.Mvc;

public class SearchController : Controller
{
    private readonly AppDbContext _context;

    public SearchController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index(string query)
    {
        var workers = _context.Workers.Where(w => w.FullName.Contains(query)).ToList();
        var offers = _context.JobOffers.Where(j => j.Title.Contains(query) || j.Description.Contains(query)).ToList();
        var reviews = _context.Reviews.Where(r => r.Comment.Contains(query) || r.ReviewerName.Contains(query)).ToList();

        var model = new SearchViewModel
        {
            Query = query,
            Workers = workers,
            JobOffers = offers,
            Reviews = reviews
        };

        return View("SearchResults", model);
    }
}
