using JokesApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JokesApp.Controllers
{
    public class ShowStatsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShowStatsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var employees = await _context.Employee.ToListAsync();

            // Compute statistics
            var salaries = employees.Select(e => e.Salary).ToList();


            var viewModel = new EmployeeStatsViewModel
            {
                Employees = employees,
                Salaries = salaries,
    };

            return View(viewModel);
        }
    }

   
}
