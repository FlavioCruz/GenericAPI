using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookStoreAPI.Models.DB;
using BookStoreAPI.Models.Entities;
using BookStoreAPI.Database;
//using BookStoreAPI.DataAccessSQLServer.Utils;

namespace BookStoreAPI.Controller.ViewsControllers
{
    public class BookSubjectController : System.Web.Mvc.Controller
    {
        private Entities.BookSubjectController controller = new Entities.BookSubjectController();

        // GET: BookSubject
        public async Task<ActionResult> Index()
        {
            return View(await controller.ListAllBookSubject(Querys.ListAllBookSubject));
        }

        // GET: BookSubject/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            return View(await controller.ListBookSubject(Querys.ListBookSubjectById, id));
        }

        // GET: BookSubject/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookSubject/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,TITLE")] BookSubjectDTO bookSubjectDTO)
        {
            if (ModelState.IsValid)
            {
                await controller.InsertBookSubject(Querys.InsertBookSubject, bookSubjectDTO.TITLE);
                return RedirectToAction("Index");
            }

            return View(bookSubjectDTO);
        }

        // GET: BookSubject/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookSubjectDTO bookSubjectDTO = await controller.ListBookSubject(Querys.ListBookSubjectById, id);
            if (bookSubjectDTO == null)
            {
                return HttpNotFound();
            }
            return View(bookSubjectDTO);
        }

        // POST: BookSubject/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,TITLE")] BookSubjectDTO bookSubjectDTO)
        {
            if (ModelState.IsValid)
            {
                await controller.UpdateBookSubject(Querys.UpdateBookSubject, bookSubjectDTO.TITLE, bookSubjectDTO.ID);
                return RedirectToAction("Index");
            }
            return View(bookSubjectDTO);
        }

        // GET: BookSubject/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookSubjectDTO bookSubjectDTO = await controller.ListBookSubject(Querys.ListBookSubjectById, id);
            if (bookSubjectDTO == null)
            {
                return HttpNotFound();
            }
            return View(bookSubjectDTO);
        }

        // POST: BookSubject/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            BookSubjectDTO bookSubjectDTO = await controller.ListBookSubject(Querys.ListBookSubjectById, id);
            await controller.DeleteBookSubject(Querys.DeleteBookSubject, id);
            return RedirectToAction("Index");
        }
    }
}
