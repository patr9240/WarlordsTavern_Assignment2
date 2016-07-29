using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WarlordsTavern.Models;

/*
     MenuController.cs
     Patrick Ross - Ryan Jameson
     Worlds End Tavern
     This is the custom controller for the food menu
*/

namespace WarlordsTavern.Controllers
{
    public class MenuController : Controller
    {
        private RestaurantContext menuDB = new RestaurantContext();

        // GET: Menu
        public ActionResult Index()
        {
            List<FoodType> foodtypes = menuDB.FoodTypes.ToList();
            return View(foodtypes);
        }

        // GET: Menu/Details/5
        public ActionResult Browse(string foodtype = "Feast")
        {
            // Retrieve FoodType and its Associated Foods from database
            FoodType foodtypeModel = menuDB.FoodTypes.Include("Foods").Single(g => g.Name == foodtype);

            return View(foodtypeModel);
        }
        public ActionResult Details(int id = 1)
        {
            Food food = menuDB.Foods.Find(id);

            return View(food);
        }

    }
}
