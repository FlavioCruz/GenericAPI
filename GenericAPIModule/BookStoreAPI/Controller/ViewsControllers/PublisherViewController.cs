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

namespace BookStoreAPI.Controller.ViewsControllers
{
    public class PublisherViewController : System.Web.Mvc.Controller
    {
        private Entities.PublisherController controller = new Entities.PublisherController();

        // GET: Publisher
        public async Task<ActionResult> Index()
        {
            return View(await controller.ListAllPublisher(Querys.ListAllPublishers));
        }

        // GET: Publisher/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            return View(await controller.ListPublisher(Querys.ListPublisherById, id));
        }

        // GET: Publisher/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Publisher/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,TITLE")] PublisherDTO PublisherDTO)
        {
            if (ModelState.IsValid)
            {
                await controller.InsertPublisher(Querys.InsertPublisher, PublisherDTO.NAME, PublisherDTO.ADDRESS, PublisherDTO.ADDRESS_NUMBER, PublisherDTO.ADDRESS_NUMBER_COMPL);
                return RedirectToAction("Index");
            }

            return View(PublisherDTO);
        }

        // GET: Publisher/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PublisherDTO publisherDTO = await controller.ListPublisher(Querys.ListPublisherById, id);
            if (publisherDTO == null)
            {
                return HttpNotFound();
            }
            return View(publisherDTO);
        }

        // POST: Publisher/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,TITLE")] PublisherDTO PublisherDTO)
        {
            if (ModelState.IsValid)
            {
                await controller.UpdatePublisher(Querys.updatePublisher, PublisherDTO.NAME, PublisherDTO.ADDRESS, PublisherDTO.ADDRESS_NUMBER, PublisherDTO.ADDRESS_NUMBER_COMPL, PublisherDTO.ID);
                return RedirectToAction("Index");
            }
            return View(PublisherDTO);
        }

        // GET: Publisher/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PublisherDTO PublisherDTO = await controller.ListPublisher(Querys.ListPublisherById, id);
            if (PublisherDTO == null)
            {
                return HttpNotFound();
            }
            return View(PublisherDTO);
        }

        // POST: Publisher/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            PublisherDTO PublisherDTO = await controller.ListPublisher(Querys.ListPublisherById, id);
            await controller.DeletePublisher(Querys.DeletePublisher, id);
            return RedirectToAction("Index");
        }
    }
}