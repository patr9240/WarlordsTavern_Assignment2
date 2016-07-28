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

namespace WarlordsTavern.Controllers
{
    [Authorize]
    public class MenuManagerController : Controller
    {
        private RestaurantContext db = new RestaurantContext();

        // GET: MenuManager
        public async Task<ActionResult> Index()
        {
            var foods = db.Foods.Include(f => f.FoodType);
            return View(await foods.ToListAsync());
        }

        // GET: MenuManager/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food food = await db.Foods.FindAsync(id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        // GET: MenuManager/Create
        public ActionResult Create()
        {
            ViewBag.FoodTypeID = new SelectList(db.FoodTypes, "FoodTypeID", "Name");
            return View();
        }

        // POST: MenuManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FoodID,FoodTypeID,Name,Price,Description,DishPictureUrl")] Food food)
        {
            if (ModelState.IsValid)
            {
                db.Foods.Add(food);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FoodTypeID = new SelectList(db.FoodTypes, "FoodTypeID", "Name", food.FoodTypeID);
            return View(food);
        }

        // GET: MenuManager/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food food = await db.Foods.FindAsync(id);
            if (food == null)
            {
                return HttpNotFound();
            }
            ViewBag.FoodTypeID = new SelectList(db.FoodTypes, "FoodTypeID", "Name", food.FoodTypeID);
            return View(food);
        }

        // POST: MenuManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FoodID,FoodTypeID,Name,Price,Description,DishPictureUrl")] Food food)
        {
            if (ModelState.IsValid)
            {
                db.Entry(food).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FoodTypeID = new SelectList(db.FoodTypes, "FoodTypeID", "Name", food.FoodTypeID);
            return View(food);
        }

        // GET: MenuManager/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food food = await db.Foods.FindAsync(id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        // POST: MenuManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Food food = await db.Foods.FindAsync(id);
            db.Foods.Remove(food);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
