﻿using CRUDASPNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDASPNetMVC.DAO
{
    public class CategoriaDAO
    {
        public void Adiciona(CategoriaDoProduto categoria)
        {
            using(var context = new EstoqueContext())
            {
                context.Categorias.Add(categoria);
                context.SaveChanges();
            }
        }

        public IList<CategoriaDoProduto> Lista()
        {
            using (var contexto = new EstoqueContext())
            {
                return contexto.Categorias.ToList();
            }
        }

        public CategoriaDoProduto BuscarPorId(int id)
        {
            using(var contexto = new EstoqueContext())
            {
                return contexto.Categorias.Find(id);
            }
        }

        public void Atualiza(CategoriaDoProduto categoria)
        {
            using (var contexto = new EstoqueContext())
            {
                contexto.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}