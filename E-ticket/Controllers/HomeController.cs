using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using E_ticket.Models;
using E_ticket.DataAccess;
using Microsoft.EntityFrameworkCore;
using E_ticket.Models.ViewModels;

namespace E_ticket.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private ApplicationDbContext _context = new();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(MovieFiltersVM movieFiltersVM)
    {
        IQueryable<Movie> movies = _context.Movies
                .Include(e => e.Cinema)
                .Include(e => e.Category)
                .Include(e => e.Images);
        if (movieFiltersVM.MovieName is not null)
        {
            movies = movies.Where(e => e.Name.ToLower().Contains(movieFiltersVM.MovieName.ToLower()));
        }
        if (movieFiltersVM.CinemaName is not null)
        {
            movies = movies.Where(e => e.Cinema.Name.ToLower().Contains(movieFiltersVM.CinemaName.ToLower()));
        }
        if (movieFiltersVM.CategoryId.HasValue)
        {
            movies = movies.Where(m => m.CategoryId == movieFiltersVM.CategoryId);
        }

        ViewData["category"] = _context.Categories.ToList();
        return View(movies);
    }

    public IActionResult Details(int id)
    {
        var det = _context.Movies
            .Include(e => e.Cinema)
            .Include(e => e.Category)
            .Include(e => e.Images)
            .FirstOrDefault(e => e.Id == id);

        var actormovies = _context.ActorsMovies
            .Include(e => e.Actors)
            .Where(e => e.MoviesId == id)
            .Include(e => e.Actors)
            .ToList();
        if (det == null)
        {
            return NotFound();
        }
        var model = new ModelsAndActorMovieVM() { actorMovies = actormovies, Movie = det };
        return View(model);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
