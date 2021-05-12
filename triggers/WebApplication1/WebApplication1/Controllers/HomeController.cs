using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;
using Quartz;
using WebApplication1.Jobs;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IScheduler _scheduler;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        public async Task<IActionResult> CheckAvailabilty()
        {
            ITrigger trigger = TriggerBuilder.Create().WithIdentity($"Check Availability-{DateTime.Now}").StartNow().WithPriority(1).Build();

            IJobDetail job = JobBuilder.Create<CheckAvailabilityJob>().WithIdentity("Check Availability").Build();

            await _scheduler.ScheduleJob(job, trigger);

            return RedirectToAction("Index");
        }
    }
}
