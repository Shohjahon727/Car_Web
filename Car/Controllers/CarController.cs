using Car.Data;
using Car.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Car.Controllers;

public class CarController : Controller
{
    private readonly AppDbContext _context;

    public CarController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {

        var cars = _context.Carss.ToList();
        return View(cars);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Cars car)
    {
        if (ModelState.IsValid)
        {
            _context.Carss.Add(car);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(car);
    }
    [HttpPost]
    public IActionResult FilterByColor(string filterbycolor)
    {

        if (string.IsNullOrWhiteSpace(filterbycolor))
        {

            var allCars = _context.Carss.ToList();
            return View("Index", allCars);
        }


        var colors = filterbycolor.Split(',')
            .Select(c => c.Trim().ToLower())
            .ToList();


        var filteredCars = _context.Carss
            .Where(car => colors.Contains(car.Color.ToLower()))
            .ToList();

        return View("Index", filteredCars);
    }

    [HttpPost]
    public IActionResult PriceRange(decimal startPrice, decimal endPrice)
    {

        var filteredCars = _context.Carss
                                    .Where(a => a.Price >= startPrice && a.Price <= endPrice)
                                    .ToList();

        return View("Index", filteredCars);
    }
}
