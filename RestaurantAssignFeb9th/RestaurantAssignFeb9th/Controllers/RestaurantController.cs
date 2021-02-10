using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantAssignFeb9th.Models;

namespace RestaurantAssignFeb9th.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Index()
        {
            var res = new List<Restaurant>
            {
                new Restaurant(){Id = 1, Name = "Pizza", Cusine = Cusinetype.Italian},
                new Restaurant(){Id = 2, Name = "pulihora", Cusine = Cusinetype.Indian},
                new Restaurant(){Id = 3, Name = "Cassolute", Cusine = Cusinetype.French},
                new Restaurant(){Id = 4, Name = "biriyani", Cusine = Cusinetype.None},
                new Restaurant(){Id = 5, Name = "Sambar", Cusine = Cusinetype.Indian},
            };
            return View(res);
        }
        public ActionResult Details(int id)
        {
            var res = new List<Restaurant>
            {
                new Restaurant(){Id = 1, Name = "Pizza", Cusine = Cusinetype.Italian},
                new Restaurant(){Id = 2, Name = "pulihora", Cusine = Cusinetype.Indian},
                new Restaurant(){Id = 3, Name = "Cassolute", Cusine = Cusinetype.French},
                new Restaurant(){Id = 4, Name = "biriyani", Cusine = Cusinetype.None},
                new Restaurant(){Id = 5, Name = "Sambar", Cusine = Cusinetype.Indian},
            };
            Restaurant res1 = null;
            foreach (var item in res)
            {
                if (item.Id == id)
                {
                    res1 = item;
                }
            }
            return View(res1);
        }
        public ActionResult Image1()
        {
            return View();
        }
    }
}