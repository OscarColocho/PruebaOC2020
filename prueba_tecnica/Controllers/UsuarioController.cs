﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prueba_tecnica.Models;

namespace prueba_tecnica.Controllers
{
    public class UsuarioController : Controller
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        
        // GET: Usuario
        public ActionResult Index()
        {
            
            var getusuariorecords = dc.crudUsuario(null, null, null, null,null,null, "Select").ToList();

            
            aplicacion1Entities sd = new aplicacion1Entities();
            List<Usuario> vusuario = sd.Usuarios.ToList();
            List<Role> vrole = sd.Roles.ToList();
            List<Membresia> vmembresia = sd.Membresias.ToList();

            var seleccion = from c in vusuario
                            join st in vrole on c.idrol equals st.idrol into table1
                            from st in table1.DefaultIfEmpty()
                            join ct in vmembresia on c.idMembresia equals ct.idMembresia into table2
                            from ct in table2.DefaultIfEmpty()
                            select new UsuarioClass { tipousuario = c, tiporol = st, tipoMembresia = ct };

            return View(seleccion);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
          
            var empdetails = dc.crudUsuario(id, null, null, null, null, null, "Details").Single(x => x.idUsuario == id);
            return View(empdetails);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(UsuarioClass collection)
        {
            try
            {
                // TODO: Add insert logic here
                dc.crudUsuario(null, collection.nomUsuario, collection.apeUsuario, collection.correo, collection.idrol, collection.idMembresia, "Insert");
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            
            var empdetails = dc.crudUsuario(id, null, null, null,null,null, "Details").Single(x => x.idUsuario == id);
            return View(empdetails);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, UsuarioClass collection)
        {
            try
            {
                // TODO: Add update logic here
                dc.crudUsuario(id, collection.nomUsuario, collection.apeUsuario, collection.correo, collection.idrol, collection.idMembresia, "Update");
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
          

            var empdetails = dc.crudUsuario(id, null, null, null, null, null, "Details").Single(x => x.idUsuario == id);
            return View(empdetails);

        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, UsuarioClass collection)
        {
           
            try
            {
                if (id != 0)
                {

                    // TODO: Add delete logic here
                    dc.crudUsuario(id, null, null, null, null, null, "Delete");
                    dc.SubmitChanges();
                    return RedirectToAction("Index");

                    throw new ApplicationException("Registro eliminado");
                }
                else
                {
                    throw new ApplicationException("No se pudo eliminar el registro");
                }
               
               

            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public JsonResult BorrarPersona(int id)
        {
            try
            {
                if (id != 0)
                {

                    // TODO: Add delete logic here
                    dc.crudUsuario(id, null, null, null, null, null, "Delete");
                    dc.SubmitChanges();
                    

                    throw new ApplicationException("Registro eliminado");
                }
                else
                {
                    throw new ApplicationException("No se pudo eliminar el registro");
                }
            }
            catch
            {

            }
            return Json("Index");
        }




    }
}