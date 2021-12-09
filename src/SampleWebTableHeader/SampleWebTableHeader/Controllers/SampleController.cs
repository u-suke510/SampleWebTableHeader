using Microsoft.AspNetCore.Mvc;
using SampleWebTableHeader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebTableHeader.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new SampleViewModel();
            viewModel.Items.AddRange(getItems());
            return View(viewModel);
        }

        private IEnumerable<SampleViewModel.ListItem> getItems()
        {
            var start = DateTime.Parse("2021/11/01");
            var end = DateTime.Parse("2021/12/01");

            var result = new List<SampleViewModel.ListItem>();
            while (start < end)
            {
                result.Add(new SampleViewModel.ListItem { Date = start });
                start = start.AddDays(1);
            }
            return result;
        }
    }
}
