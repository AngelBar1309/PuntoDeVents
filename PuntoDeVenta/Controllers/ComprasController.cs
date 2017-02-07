using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PuntoDeVenta.Models;

namespace PuntoDeVenta.Controllers
{
    public class ComprasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Compras
        public ActionResult Index()
        {
            var compras = db.Compras.Include(c => c.productos).Include(c => c.proveedores);
            return View(compras.ToList());
        }

        // GET: Compras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compras compras = db.Compras.Find(id);
            if (compras == null)
            {
                return HttpNotFound();
            }
            return View(compras);
        }

        // GET: Compras/Create
        public ActionResult Create()
        {
            ViewBag.proveedorRfc = new SelectList(db.proveedores, "proveedorRfc", "nombreProveedora");

            return View();
        }

        // POST: Compras/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ComprasViewModel compras)
        {
            if (ModelState.IsValid)
            {
                Productos producto = new Productos
                {
                    productoID = 0,
                    nombreProducto = compras.nombreProducto,
                    stock = compras.stock,
                    precio = compras.precio,
                    categoria = compras.categoria,
                };
                db.productos.Add(producto);
                db.SaveChanges();
                ///este es para obtener el id del producto con el nombre
                int productoGetID=db.productos.Single(a => a.nombreProducto == compras.nombreProducto).productoID;
                Compras compraNueva = new Compras
                {
                    compraID = 0,
                    fecha = compras.fecha,
                    productoID = productoGetID,
                    proveedorRfc =compras.proveedorRfc ,
                };
                db.Compras.Add(compraNueva);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.proveedorRfc = new SelectList(db.proveedores, "proveedorRfc", "nombreProveedora", compras.proveedorRfc);
            return View(compras);
        }

        // GET: Compras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compras compras = db.Compras.Find(id);
            if (compras == null)
            {
                return HttpNotFound();
            }
            ViewBag.productoID = new SelectList(db.productos, "productoID", "nombreProducto", compras.productoID);
            ViewBag.proveedorRfc = new SelectList(db.proveedores, "proveedorRfc", "nombreProveedora", compras.proveedorRfc);
            return View(compras);
        }

        // POST: Compras/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "compraID,fecha,productoID,proveedorRfc")] Compras compras)
        {
            if (ModelState.IsValid)
            {
                db.Entry(compras).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.productoID = new SelectList(db.productos, "productoID", "nombreProducto", compras.productoID);
            ViewBag.proveedorRfc = new SelectList(db.proveedores, "proveedorRfc", "nombreProveedora", compras.proveedorRfc);
            return View(compras);
        }

        // GET: Compras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compras compras = db.Compras.Find(id);
            if (compras == null)
            {
                return HttpNotFound();
            }
            return View(compras);
        }

        // POST: Compras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Compras compras = db.Compras.Find(id);
            db.Compras.Remove(compras);
            db.SaveChanges();
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
