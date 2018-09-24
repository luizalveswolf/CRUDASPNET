﻿using CRUDASPNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDASPNetMVC.DAO
{
    public class EstoqueContext :DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<CategoriaDoProduto> Categorias { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}