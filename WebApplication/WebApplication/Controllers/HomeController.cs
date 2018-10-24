using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using WebApplicationBll.DTO;
using WebApplicationBll.Interfaces;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataService dataService;

        public HomeController(IDataService dataService)
        {
            this.dataService = dataService;
        }
        [HttpGet]
        public IActionResult Index()
        {

            var merged = dataService.GetAll();
            return View(merged);
        }

        [HttpPost]
        public IActionResult Index(ChooseFilterModel filterData)
        {
            var filterModel = new FilteredModel();
            string[] strArray = filterData.FilterValue.Split(' ');
            var log = new LogTableDTO();
            log.WhenItUse = DateTime.Now;
            switch (filterData.TableName)
            {
                case "Id":
                    List<int> l0 = new List<int>();
                    foreach (var s in strArray)
                    {
                        l0.Add(Int32.Parse(s));
                    }

                    filterModel.Id = l0;
                    log.FilterName = "Id";
                    dataService.AddLog(log);
                    break;

                case "FtableId":
                    List<int?> l1 = new List<int?>();
                    foreach (var s in strArray)
                    {
                        l1.Add(Int32.Parse(s));
                    }

                    filterModel.FtableId = l1;
                    log.FilterName = "FtableId";
                    break;

                case "LastName":
                    List<string> l2 = new List<string>();
                    foreach (var s in strArray)
                    {
                        l2.Add(s);
                    }

                    filterModel.LastName = l2;
                    log.FilterName = "LastName";

                    break;

                case "SomeDate":
                    List<DateTime?> l3 = new List<DateTime?>();
                    foreach (var s in strArray)
                    {
                        l3.Add(DateTime.Parse(s));
                    }

                    filterModel.SomeDate = l3;
                    log.FilterName = "SomeDate";

                    break;

                case "SecondFloatNumber":
                    List<double?> l4 = new List<double?>();
                    foreach (var s in strArray)
                    {
                        l4.Add(Double.Parse(s));
                    }

                    filterModel.SecondFloatNumber = l4;
                    log.FilterName = "SecondFloatNumber";

                    break;

                case "Checker":
                    List<bool?> l5 = new List<bool?>();
                    foreach (var s in strArray)
                    {
                        l5.Add(Boolean.Parse(s));
                    }

                    filterModel.Checker = l5;
                    log.FilterName = "Checker";

                    break;

                case "Access":
                    List<bool?> l6 = new List<bool?>();
                    foreach (var s in strArray)
                    {
                        l6.Add(Boolean.Parse(s));
                    }

                    filterModel.Access = l6;
                    log.FilterName = "Access";

                    break;

                case "FirstName":
                    List<string> l7 = new List<string>();
                    foreach (var s in strArray)
                    {
                        l7.Add(s);
                    }

                    filterModel.FirstName= l7;
                    log.FilterName = "FirstName";

                    break;

                case "TableDate":
                    List<DateTime?> l8 = new List<DateTime?>();
                    foreach (var s in strArray)
                    {
                        l8.Add(DateTime.Parse(s));
                    }

                    filterModel.TableDate = l8;
                    log.FilterName = "TableDate";

                    break;

                case "SomeFloatNumber":
                    List<double?> l9 = new List<double?>();
                    foreach (var s in strArray)
                    {
                        l9.Add(Double.Parse(s));
                    }

                    filterModel.SomeFloatNumber = l9;
                    log.FilterName = "SomeFloatNumber";

                    break;

                case "SomeIntNumber":
                    List<int?> l10 = new List<int?>();
                    foreach (var s in strArray)
                    {
                        l10.Add(Int32.Parse(s));
                    }

                    filterModel.SomeIntNumber = l10;
                    log.FilterName = "SomeIntNumber";


                    break;
            }

            var result = dataService.GetFiltered(filterModel);
            return View("Filter", result);

        }
        [HttpGet]
        public IActionResult Filter(IEnumerable<MergedTablesDTO> result)
        {

            return View("Filter", result);
        }

        [HttpPost]
        public void Filter(string chose)
        {
            if (chose.Contains('n'))
            {
                var result = dataService.GetAll();
                dataService.Report(result);
            }
            

        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
    }
}
