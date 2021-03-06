﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvc.Models;
using ITB.Shared;

namespace AspNetCoreMvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _prodRepo;

        public ProductController(IProductRepository prodRepo)
        {
            _prodRepo = prodRepo;
        }

        // GET: Product
        public async Task<IActionResult> Index()
        {
            var products = await _prodRepo.GetProducts();
            return View(products);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var products = _prodRepo.GetProduct(id);
            return View(products);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                var name = collection["Name"];          
                Product prod = new Product { Name = name };
                _prodRepo.AddProduct(prod);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var name = collection["Name"];
                Product prod = new Product { Id = id, Name = name };
                _prodRepo.UpdateProduct(prod);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var prod = _prodRepo.GetProduct(id);
            return View(prod);
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _prodRepo.DeleteProduct(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}