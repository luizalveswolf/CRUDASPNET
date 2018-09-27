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
        //logica de negocio

        // GET: Produto
        public ActionResult Index()
        {
            ProdutoDAO dao = new ProdutoDAO();
            IList<Produto> produtos = dao.Lista();
            ViewBag.Produtos = produtos;
            return View();
        }

        //Criação do cadastro de produto usando o formulario
        public ActionResult Form()
        {
            CategoriaDAO categoriasDAO = new CategoriaDAO();
            IList<CategoriaDoProduto> categorias = categoriasDAO.Lista();
            ViewBag.Categorias = categorias;
            return View();
        }

        //Modelo 1 passando os valores por parametros
        //Metodo para adicionar o produto ao carrinho
        //Recebe o que foi digitado no formulario e salva no objeto Produto atraves do ProdutoDAO
        //public ActionResult Adiciona(String nome, float preco, String descricao, int quantidade, int categoriaId)
        //{
        //    Produto produto = new Produto()
        //    {
        //        Nome = nome,
        //        Preco = preco,
        //        Descricao = descricao,
        //        Quantidade = quantidade,
        //        CategoriaId = categoriaId
        //    };

        //    ProdutoDAO dao = new ProdutoDAO();
        //    dao.Adiciona(produto);

        //    return View();
        //}


        [HttpPost]
        public ActionResult Adiciona(Produto produto)
        {
            ProdutoDAO dao = new ProdutoDAO();
            dao.Adiciona(produto);

            return RedirectToAction("Index","Produto");
        }
    }
}