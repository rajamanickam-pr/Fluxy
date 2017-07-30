using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Fluxy.Data;
using Fluxy.Data.EntityModels.Categories;
using Fluxy.Services.Categories;
using Fluxy.Misc.Mvc.Controllers;

namespace Fluxy.Web.Areas.Admin.Controllers
{
    [Authorize]
    public class SubCategoriesController : BaseController
    {
        private readonly ISubCategoryService _subCategoryService;

        public SubCategoriesController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }

        private FluxyContext db = new FluxyContext();

        // GET: Admin/SubCategories
        public ActionResult Index()
        {
            var subCategories = _subCategoryService.GetAll();
            return View(subCategories.ToList());
        }

        // GET: Admin/SubCategories/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategory subCategory =_subCategoryService.GetById(id.Value);
            if (subCategory == null)
            {
                return HttpNotFound();
            }
            return View(subCategory);
        }

        // GET: Admin/SubCategories/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        // POST: Admin/SubCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,CategoryId,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy")] SubCategory subCategory)
        {
            if (ModelState.IsValid)
            {
                _subCategoryService.Create(subCategory);
                Success("Successfuly created SubCategory", true);
                return RedirectToAction("Index");
            }
            Danger("Please fill all the fileds", true);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", subCategory.CategoryId);
            return View(subCategory);
        }

        // GET: Admin/SubCategories/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategory subCategory = _subCategoryService.GetById(id.Value);
            if (subCategory == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", subCategory.CategoryId);
            return View(subCategory);
        }

        // POST: Admin/SubCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,CategoryId,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy")] SubCategory subCategory)
        {
            if (ModelState.IsValid)
            {
                _subCategoryService.Update(subCategory);
                Success("Successfuly category updated", true);
                return RedirectToAction("Index");
            }
            Danger("Something went wrong", true);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", subCategory.CategoryId);
            return View(subCategory);
        }

        // GET: Admin/SubCategories/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubCategory subCategory = _subCategoryService.GetById(id.Value);
            if (subCategory == null)
            {
                return HttpNotFound();
            }
            return View(subCategory);
        }

        // POST: Admin/SubCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            SubCategory subCategory = _subCategoryService.GetById(id);
            Success("Successfuly category deleted", true);
            _subCategoryService.Delete(subCategory);
            return RedirectToAction("Index");
        }
    }
}
