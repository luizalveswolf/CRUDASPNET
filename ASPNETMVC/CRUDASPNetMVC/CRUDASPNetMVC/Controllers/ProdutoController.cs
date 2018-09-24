using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDASPNetMVC.DAO;
using CRUDASPNetMVC.Models;

namespace CRUDASPNetMVC.Controllers
{
    public class ProdutoController : Controller
    {
        //logica d negocio

        // GET: Produto
        public ActionResult Index()
        {
            ProdutoDAO dao = new ProdutoDAO();
            IList<Produto> produtos = dao.Lista();
            ViewBag.Produtos = produtos;
            return View();
        }
    }
}