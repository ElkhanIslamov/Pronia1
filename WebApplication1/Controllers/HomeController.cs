using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication1.Contexts;


namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly PronioDbContext _context;
    public HomeController(PronioDbContext _context)
    {
        _context = _context;
    }


    public async Task<IActionResult> Index()
    {
        var sliders = await  _context.Sliders.ToListAsync();
        var shippings = await _context.Shippings.ToListAsync();

        HomeViewModel homeViewModel = new HomeViewModel
        {
            Sliders = sliders,
            Shippings = shippings
        };
        return View(homeViewModel);
    }

}