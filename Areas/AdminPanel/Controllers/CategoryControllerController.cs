﻿using DummyBazaarWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DummyBazaarWebApp.Areas.AdminPanel.Controllers
{
    public class CategoryControllerController : Controller
    {
        DummyBazaarModel db = new DummyBazaarModel();
        // GET: AdminPanel/CategoryController
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.suleyman = "Süleyman Burdaydı";
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Category c = db.Categories.Find(id);
            return View(c);
        }
        [HttpPost]
        public ActionResult Edit(Category model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    ViewBag.Mesaj = "Düzenleme İşlemi Başarılı";
                }
                catch (Exception)
                {

                    ViewBag.Mesaj = "Kategori Düzenlenirken Bir Hata Oluştu";
                }
            }
            
            return View(model);
        }
        public ActionResult Delete(int? id)
        {
            if (id!=null)
            {
                Category c = db.Categories.Find(id);
                db.Categories.Remove(c);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}