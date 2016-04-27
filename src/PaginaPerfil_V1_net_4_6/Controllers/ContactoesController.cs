using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using PaginaPerfil_V1_net_4_6.Modelo;
using PaginaPerfil_V1_net_4_6.Models;
using System.Collections.Generic;
using System.Net;
using System;

namespace PaginaPerfil_V1_net_4_6.Controllers
{
    public class ContactoesController : Controller
    {
        private PaginaPerfil_V1_net_4_6Context _context;

        public ContactoesController(PaginaPerfil_V1_net_4_6Context context)
        {
            _context = context;    
        }

        // GET: Contactoes
        public IActionResult Index()
        {
            List<ListContactos> cnt = new List<ListContactos>();

            foreach (Contacto cn in _context.Contacto.ToList())
            {
                ListContactos lt = new ListContactos();
                lt.Id = cn.Id;
                lt.Nombre = cn.Nombre;
                lt.Apellido = cn.Apellido;
                //lt.Ciudad = _context.Ciudad.First(y => y.Id == cn.Id).Nombre;
                cnt.Add(lt);                
            }

            //return View(_context.Contacto.ToList());
            return View(cnt);
        }

        // GET: Contactoes/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Contacto contacto = _context.Contacto.Single(m => m.Id == id);
            if (contacto == null)
            {
                return HttpNotFound();
            }

            return View(contacto);
        }

        // GET: Contactoes/Create
        public IActionResult Enviar()
        {
            return View();
        }

        // POST: Contactoes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Enviar(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                _context.Contacto.Add(contacto);
                _context.SaveChanges();

                if (contacto.Email != null)
                {
                    //EnviarMail(contacto.Email);
                }

                return RedirectToAction("Index");
            }
            return View(contacto);
        }

        // GET: Contactoes/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Contacto contacto = _context.Contacto.Single(m => m.Id == id);
            if (contacto == null)
            {
                return HttpNotFound();
            }
            return View(contacto);
        }

        // POST: Contactoes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                _context.Update(contacto);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contacto);
        }

        // GET: Contactoes/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Contacto contacto = _context.Contacto.Single(m => m.Id == id);
            if (contacto == null)
            {
                return HttpNotFound();
            }

            return View(contacto);
        }

        // POST: Contactoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Contacto contacto = _context.Contacto.Single(m => m.Id == id);
            _context.Contacto.Remove(contacto);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
                
               
    }

    
}
